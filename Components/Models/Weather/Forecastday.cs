namespace Components.Models.Weather
{
    public class Forecastday
    {
        /// <summary>
        /// Forecast date.
        /// </summary>
        private string date;

        /// <summary>
        /// Forecast date as unix time.
        /// </summary>
        public int date_epoch { get; set; }

        /// <summary>
        /// See day element.
        /// </summary>
        public Day day { get; set; }

        /// <summary>
        /// See astro element.
        /// </summary>
        public Astro astro { get; set; }

        /// <summary>
        /// See hour element.
        /// </summary>
        public Hour[] hour { get; set; }
    }
}
