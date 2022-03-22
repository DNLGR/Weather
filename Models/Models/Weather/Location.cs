namespace Components.Models.Weather
{
    public class Location
    {
        /// <summary>
        /// Location name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Region or state of the location, if availa.
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// Location country.
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Latitude in decimal degree.
        /// </summary>
        public decimal lat { get; set; }

        /// <summary>
        /// Longitude in decimal degree.
        /// </summary>
        public decimal lon { get; set; }

        /// <summary>
        /// Time zone name.
        /// </summary>
        public string tz_id { get; set; }

        /// <summary>
        /// Local date and time in unix time.
        /// </summary>
        public int localtime_epoch { get; set; }

        /// <summary>
        /// Local date and time.
        /// </summary>
        public string localtime { get; set; }
    }
}
