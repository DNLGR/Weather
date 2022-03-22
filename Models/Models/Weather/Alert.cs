namespace Components.Models.Weather
{
    public class Alert
    {
        /// <summary>
        /// Alert headline
        /// </summary>
        public string headline { get; set; }

        /// <summary>
        /// Type of alert
        /// </summary>
        public string msgType { get; set; }

        /// <summary>
        /// Severity of alert
        /// </summary>
        public string severity { get; set; }

        /// <summary>
        /// Urgency
        /// </summary>
        public string urgency { get; set; }

        /// <summary>
        /// Areas covered
        /// </summary>
        public string areas { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// Certainty
        /// </summary>
        public string certainty { get; set; }

        /// <summary>
        /// Event
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        public string note { get; set; }

        /// <summary>
        /// Effective
        /// </summary>
        public DateTime effective { get; set; }

        /// <summary>
        /// Expires
        /// </summary>
        public string expires { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// Instruction
        /// </summary>
        public string instruction { get; set; }
    }
}
