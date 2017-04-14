using System;

namespace YoutubeIdExtractor
{
	public class Response
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public string prevPageToken { get; set; }
		public string nextPageToken { get; set; }
		public PageInfo pageInfo { get; set; }
		public Item[] items { get; set; }
	}

	public class PageInfo
	{
		public int totalResults { get; set; }
		public int resultsPerPage { get; set; }
	}

	public class Item
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public string id { get; set; }
		public ContentDetails contentDetails { get; set; }
		public Snippet snippet { get; set; }
		public Statistics statistics { get; set; }
	}

	public class Statistics
	{
		public int viewCount { get; set; }
		public int likeCount { get; set; }
		public int dislikeCount { get; set; }
		public int favoriteCount { get; set; }
		public int commentCount { get; set; }
	}

	public class ContentDetails
	{
		public string videoId { get; set; }
		public string videoPublishedAt { get; set; }
	}

	public class Snippet
	{
		public string title { get; set; }
		public string description { get; set; }
		public string customUrl { get; set; }
		public DateTime publishedAt { get; set; }
		public string country { get; set; }
		public Thumbnails thumbnails { get; set; }
		public Localization localized { get; set; }
	}

	public class Thumbnails
	{
		public Url Default { get; set; }
		public Url medium { get; set; }
		public Url high { get; set; }
	}

	public class Url
	{
		public string url { get; set; }
	}

	public class Localization
	{
		public string title { get; set; }
		public string description { get; set; }
	}
}
