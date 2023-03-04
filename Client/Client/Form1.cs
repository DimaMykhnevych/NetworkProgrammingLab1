using Client.Models;
using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    /// <summary>
    /// Text convertion (main) form.
    /// </summary>
    public partial class TextConvertion : Form
    {
        /// <summary>
        /// The server URL to send requests.
        /// </summary>
        private const string serverUrl = "http://192.168.0.204:5286/ReverseText";

        /// <summary>
        /// Client to send HTTP requests.
        /// </summary>
        private readonly HttpClient httpClient;

        /// <summary>
        /// Creates a new instance of <see cref="TextConvertion"/>.
        /// </summary>
        public TextConvertion()
        {
            // Initializing component.
            InitializeComponent();

            // Making result text field as readonly.
            replacedText.ReadOnly = true;

            // Creating new HttpClient.
            httpClient = new HttpClient();
        }

        /// <summary>
        /// Convert button click event listener.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argumetns.</param>
        private async void ConvertBtn_Click(object sender, EventArgs e)
        {
            // Request DTO with entered text.
            ReverseTextDto reverseTextDto = new ReverseTextDto
            {
                Text = originalText.Text,
            };

            // HTTP POST request message to the serverUrl with serialized reverseTextDto.
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, serverUrl)
            {
                // String content in UTF-8 encoding.
                // Will be send with content-type application/json.
                Content = new StringContent(JsonConvert.SerializeObject(reverseTextDto), System.Text.Encoding.UTF8, "application/json"),
            };

            // Response from the server.
            HttpResponseMessage response = await httpClient.SendAsync(message);

            // Server response content in string representation.
            string responseContent = await response.Content.ReadAsStringAsync();

            // Deserializing response srting content to ReverseTextDto model that contains reversed text.
            ReverseTextDto resultDto = JsonConvert.DeserializeObject<ReverseTextDto>(responseContent);

            // Updating the view.
            replacedText.Text = resultDto.Text;
        }
    }
}
