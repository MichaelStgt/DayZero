namespace DayZero.Model
{
    public partial class SubstanceItem : ObservableObject
    {
        [ObservableProperty]
        public partial string? Name
        {
            get; set;
        }

        [ObservableProperty]
        public partial string? IconGlyph
        {
            get; set;
        } // Helpful later if you want to add FontAwesome icons

        [ObservableProperty]
        public partial bool IsSelected
        {
            get; set;
        }
    }
}
