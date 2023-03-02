using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Windows.Forms;
using Common;   // common assembly

namespace Client
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TextConvertion : Form
    {
        private const string serviceUrl = "http://localhost:5000/TextFunctions.soap";
        private TaskHelper remote;

        /// <summary>
        /// 
        /// </summary>
        public TextConvertion()
        {
            InitializeComponent();
            replacedText.ReadOnly = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            string text = originalText.Text;
            string result = remote.ReverseText(text);
            replacedText.Text = result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextConvertion_Load(object sender, EventArgs e)
        {
            HttpChannel ch = new HttpChannel();
            ChannelServices.RegisterChannel(ch, false);
            remote = (TaskHelper)Activator.GetObject(typeof(TaskHelper), serviceUrl);
        }
    }
}
