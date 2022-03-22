namespace Components.Models.Weather
{
    public class Astro
    {
        /// <summary>
        /// Sunrise time
        /// </summary>
        public string sunrise { get; set; }

        /// <summary>
        /// Sunset time
        /// </summary>
        public string sunset { get; set; }

        /// <summary>
        /// Moonrise time
        /// </summary>
        public string moonrise { get; set; }

        /// <summary>
        /// Moonset time
        /// </summary>
        public string moonset { get; set; }

        /// <summary>
        /// Moon phases. Value returned:
        /// New Moon;
        /// Waxing Crescent;
        /// First Quarter;
        /// Waxing Gibbous;
        /// Full Moon;
        /// Waning Gibbous;
        /// Last Quarter;
        /// Waning Crescent.
        /// </summary>
        public string moon_phase { get; set; }

        /// <summary>
        /// Moon illumination as %
        /// </summary>
        public string moon_illumination { get; set; }
    }
}
