namespace Components.Models.Weather
{
    public class Hour
    {
        /// <summary>
        /// Time as epoch.
        /// </summary>
        public int time_epoch { get; set; }

        /// <summary>
        /// Date and time.
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// Return short time string.
        /// </summary>

        /// <summary>
        /// Temperature in celsius.
        /// </summary>
        public decimal temp_c { get; set; }

        /// <summary>
        /// Temperature in fahrenheit.
        /// </summary>
        public decimal temp_f { get; set; }

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
        /// Windchill temperature in celcius.
        /// </summary>
        public decimal windchill_c { get; set; }

        /// <summary>
        /// Windchill temperature in fahrenheit.
        /// </summary>
        public decimal windchill_f { get; set; }

        /// <summary>
        /// Heat index in celcius.
        /// </summary>
        public decimal heatindex_c { get; set; }

        /// <summary>
        /// Heat index in fahrenheit.
        /// </summary>
        public decimal heatindex_f { get; set; }

        /// <summary>
        /// Dew point in celcius.
        /// </summary>
        public decimal dewpoint_c { get; set; }

        /// <summary>
        /// Dew point in fahrenheit.
        /// </summary>
        public decimal dewpoint_f { get; set; }

        /// <summary>
        /// 1 = Yes 0 = No.
        /// Will it will rain or not.
        /// </summary>
        public int will_it_rain { get; set; }

        /// <summary>
        /// 1 = Yes 0 = No.
        /// Will it snow or not.
        /// </summary>
        public int will_it_snow { get; set; }

        /// <summary>
        /// 1 = Yes 0 = No.
        /// Whether to show day condition icon or night icon.
        /// </summary>
        public int is_day { get; set; }

        /// <summary>
        /// Visibility in kilometer
        /// </summary>
        public double vis_km { get; set; }

        /// <summary>
        /// Visibility in miles
        /// </summary>
        public double vis_miles { get; set; }
    }
}
