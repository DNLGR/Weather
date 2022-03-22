namespace Components.Models.Weather
{
    public class Day
    {
        /// <summary>
        /// Maximum temperature in celsius for the day.
        /// </summary>
        public decimal maxtemp_c { get; set; }

        /// <summary>
        /// Maximum temperature in fahrenheit for the day.
        /// </summary>
        public decimal maxtemp_f { get; set; }

        /// <summary>
        /// Minimum temperature in celsius for the day.
        /// </summary>
        public decimal mintemp_c { get; set; }

        /// <summary>
        /// Minimum temperature in fahrenheit for the day.
        /// </summary>
        public decimal mintemp_f { get; set; }

        /// <summary>
        /// 	Average temperature in celsius for the day.
        /// </summary>
        public decimal avgtemp_c { get; set; }

        /// <summary>
        /// Average temperature in fahrenheit for the day.
        /// </summary>
        public decimal avgtemp_f { get; set; }

        /// <summary>
        /// Maximum wind speed in miles per hour.
        /// </summary>
        public decimal maxwind_mph { get; set; }

        /// <summary>
        /// Maximum wind speed in kilometer per hour.
        /// </summary>
        public decimal maxwind_kph { get; set; }

        /// <summary>
        /// Total precipitation in milimeter.
        /// </summary>
        public decimal totalprecip_mm { get; set; }

        /// <summary>
        /// Total precipitation in inches.
        /// </summary>
        public decimal totalprecip_in { get; set; }

        /// <summary>
        /// Average visibility in kilometer.
        /// </summary>
        public decimal avgvis_km { get; set; }

        /// <summary>
        /// Average visibility in miles.
        /// </summary>
        public decimal avgvis_miles { get; set; }

        /// <summary>
        /// Average humidity as percentage.
        /// </summary>
        public double avghumidity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal daily_will_it_rain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal daily_chance_of_rain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal daily_will_it_snow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal daily_chance_of_snow { get; set; }

        /// <summary>
        /// Condition.
        /// </summary>
        public Condition condition { get; set; }

        /// <summary>
        /// UV Index
        /// </summary>
        public decimal uv { get; set; }
    }
}
