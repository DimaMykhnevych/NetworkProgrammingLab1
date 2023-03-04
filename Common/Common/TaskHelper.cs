namespace Common
{
    /// <summary>
    /// Provides functions to work with text. Inherits <see cref="MarshalByRefObject"/>.
    /// </summary>
    public class TaskHelper : MarshalByRefObject
    {
        /// <summary>
        /// Arranges the words in the text in reverse alphabetical order.
        /// </summary>
        /// <param name="originalText">The original text to arragne the words.</param>
        /// <returns>The text with the words arranged in the reverse alphabetical order.</returns>
        public string ReverseText(string originalText)
        {
            // Split original text by whitespace characters
            // with removing empty entries. Sorting the result
            // words array by descending.
            IEnumerable<string> words = originalText
                .Split(new char[] { ' ', ',', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(w => w);

            // Joining sorted array of words in a single string.
            // Each word is separated by the space character.
            return string.Join(" ", words);
        }
    }
}
