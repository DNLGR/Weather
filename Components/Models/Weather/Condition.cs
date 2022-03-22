namespace Components.Models.Weather
{
    public class Condition
    {
        /// <summary>
        /// Weather condition text
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Weather icon url
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// Weather condition unique code.
        /// </summary>
        public int code { get; set; }
    }
}
