using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace YoutubeIdExtractor
{
	public class YoutubeCommunication
	{
		internal static string[] GetPlaylistItems(string playlistId)
		{
			string getPlaylistUrl = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId={0}{1}&key=AIzaSyBnlRJjwdRrn5yXXhxHOWIDzYzQJIVAyIg";
			string getPlaylistMethod = "GET";

			var pageToken = string.Empty;
			string url = string.Format(getPlaylistUrl, playlistId, pageToken);
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Proxy = null;
			request.Method = getPlaylistMethod;
			request.Credentials = CredentialCache.DefaultCredentials;
			request.ProtocolVersion = HttpVersion.Version11;

			var list = new List<string>();
			Response response = null;
			string responseString;

			// Wurde auf Webservice-Response umgestellt und muss noch vertestet werden.
			while (!string.IsNullOrWhiteSpace((response = JsonConvert.DeserializeObject<Response>(responseString = Communicate(request))).nextPageToken))
			{
				foreach (var item in response.items)
				{
					list.Add(item.contentDetails.videoId);
				}

				pageToken = string.Empty;
				if (!string.IsNullOrWhiteSpace(response.nextPageToken))
				{
					pageToken = string.Format("&pageToken={0}", response.nextPageToken);
				}

				url = string.Format(getPlaylistUrl, playlistId, pageToken);
				request = (HttpWebRequest)WebRequest.Create(url);
				request.Proxy = null;
				request.Method = getPlaylistMethod;
				request.Credentials = CredentialCache.DefaultCredentials;
				request.ProtocolVersion = HttpVersion.Version11;
			}

			if (response.etag == null && response.items == null && response.pageInfo == null)
			{
				throw new Exception(responseString);
			}

			foreach (var item in response.items)
			{
				list.Add(item.contentDetails.videoId);
			}

			return list.ToArray();
		}
		private static string Communicate(WebRequest request, byte[] bytes = null, string headerName = null)
		{
			if (bytes != null && bytes.Length != 0)
			{
				// Senden
				var requestStream = request.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
			}

			try
			{
				// Verbinden
				var response = request.GetResponse();
				var responseStream = response.GetResponseStream();

				if (string.IsNullOrWhiteSpace(headerName))
				{
					// Lesen
					StreamReader responseReader = new StreamReader(responseStream);
					return responseReader.ReadToEnd();
				}
				else
				{
					// Url erhalten
					return response.Headers.Get(headerName);
				}
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.ProtocolError)
				{
					var response = ex.Response as HttpWebResponse;
					if ((int)response.StatusCode == 308)
					{
						var range = response.Headers.Get("range");
						return range;
					}
				}

				if (ex.Response != null)
				{
					using (var stream = ex.Response.GetResponseStream())
					{
						using (var reader = new StreamReader(stream))
						{
							var error = reader.ReadToEnd();
							return error;
						}
					}
				}
				return null;
			}
		}
	}
}
