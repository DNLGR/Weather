namespace Components.Models
{
    public class Instance
    {
        /// <summary>
        /// Current day info.
        /// </summary>
        public Current current { get; set; }

        /// <summary>
        /// Search location info.
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// Forecast info.
        /// </summary>
        public Forecast forecast { get; set; }

        /// <summary>
        /// Alert info.
        /// </summary>
        public ObservableCollection<Alert> alert { get; set; }
    }
}