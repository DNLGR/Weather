namespace Components.Models.Weather
{ 
    public class Current
    {
        /// <summary>
        /// Local time when the real time data was updated.
        /// </summary>
        public string last_updated { get; set; }

        /// <summary>
        /// Local time when the real time data was updated in unix time.
        /// </summary>
        public int last_updated_epoch { get; set; }

        /// <summary>
        /// Temperature in celsius.
        /// </summary>
        public decimal temp_c { get; set; }

        /// <summary>
        /// Temperature in fahrenheit.
        /// </summary>
        public decimal temp_f { get; set; }

        /// <summary>
        /// 1 = Yes 0 = No.
        /// Whether to show day condition icon or night icon.
        /// </summary>
        public int is_day { get; set; }

        /// <summary>
        /// Condition.
        /// </summary>
        public Condition condition { get; set; }

        /// <summary>
        /// Wind speed in miles per hour.
        /// </summary>
        public decimal wind_mph { get; set; }

        /// <summary>
        /// Wind speed in kilometer per hour.
        /// </summary>
        public decimal wind_kph { get; set; }

        /// <summary>
        /// Wind direction in degrees.
        /// </summary>
        public int wind_degree { get; set; }

        /// <summary>
        /// Wind direction as 16 point compass. e.g.: NSW.
        /// </summary>
        public string wind_dir { get; set; }

        /// <summary>
        /// Pressure in millibars.
        /// </summary>
        public decimal pressure_mb { get; set; }

        /// <summary>
        /// Pressure in inches.
        /// </summary>
        public decimal pressure_in { get; set; }

        /// <summary>
        /// Precipitation amount in millimeters.
        /// </summary>
        public decimal precip_mm { get; set; }

        /// <summary>
        /// Precipitation amount in inches.
        /// </summary>
        public decimal precip_in { get; set; }

        /// <summary>
        /// Humidity as percentage.
        /// </summary>
        public int humidity { get; set; }

        /// <summary>
        /// Cloud cover as percentage.
        /// </summary>
        public int cloud { get; set; }

        /// <summary>
        /// Feels like temperature in celsius.
        /// </summary>
        public decimal feelslike_c { get; set; }

        /// <summary>
        /// Feels like temperature in fahrenheit.
        /// </summary>
        public decimal feelslike_f { get; set; }

        /// <summary>
        /// Visibility in kilometer
        /// </summary>
        public double vis_km { get; set; }

        /// <summary>
        /// Visibility in miles
        /// </summary>
        public double vis_miles { get; set; }

        /// <summary>
        /// UV Index.
        /// </summary>
        public decimal uv { get; set; }

        /// <summary>
        /// Wind gust in miles per hour.
        /// </summary>
        public decimal gust_mph { get; set; }

        /// <summary>
        /// Wind gust in kilometer per hour.
        /// </summary>
        public decimal gust_kph { get; set; }
    }
}
