using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace YoutubeIdExtractor
{
	public partial class saveForm : Form
	{
		public saveForm(string id)
		{
			InitializeComponent();
			playlistTextBox.Text = id;
		}

		public string Id { get; set; }

		private void saveButtonClick(object sender, System.EventArgs e)
		{
			var file = "playlists.json";

			var playlist = new PlaylistSave() { Id = playlistTextBox.Text, Name = nameTextBox.Text };

			if (!string.IsNullOrWhiteSpace(playlist.Id) && !string.IsNullOrWhiteSpace(playlist.Name))
			{
				List<PlaylistSave> playlists = new List<PlaylistSave>();

				if (File.Exists(file))
				{
					using (var reader = new StreamReader(file))
					{
						var content = reader.ReadToEnd();
						playlists.AddRange(JsonConvert.DeserializeObject<PlaylistSave[]>(content));

						int i = 1;
						string name = playlist.Name;
						while (playlists.Any(p => p.Name.ToLower() == name.ToLower()))
						{
							name = $"{playlist.Name}_{i}";
							i++;
						}
						playlist.Name = name;
					}
				}

				playlists.Insert(0, playlist);

				using (var writer = new StreamWriter(file, false))
				{
					var content = JsonConvert.SerializeObject(playlists.ToArray());
					writer.Write(content);
				}

				Id = playlist.Id;
			}
		}
	}
}
