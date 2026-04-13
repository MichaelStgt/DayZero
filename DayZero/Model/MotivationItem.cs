namespace DayZero.Model
{
    public partial class MotivationItem : ObservableObject
    {
        [ObservableProperty]
        public partial string? Text
        {
            get; set;
        }

        [ObservableProperty]
        public partial bool IsSelected
        {
            get; set;
        }
    }
}
