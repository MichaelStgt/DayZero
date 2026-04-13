namespace DayZero.Model
{
    public class SobrietyRecord
    {
        // Unique identifier for local DB storage later
        public Guid Id { get; set; } = Guid.NewGuid();

        // The substance the user is quitting (e.g., "Alcohol", "Nicotine", or "Both")
        public string SubstanceType
        {
            get; set;
        }

        // The exact date and time the user started their "Day Zero"
        public DateTime StartDate
        {
            get; set;
        }

        // A calculated property to easily get the total time sober
        public TimeSpan TimeSober => DateTime.Now - this.StartDate;

        // A calculated property specifically for the daily streak counter
        public int DaysSober => (int)this.TimeSober.TotalDays;
    }
}
