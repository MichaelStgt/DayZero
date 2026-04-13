using DayZero.Model;
using System.Collections.ObjectModel;

namespace DayZero.ViewModel
{
    [QueryProperty(nameof(SelectedSubstances), "SelectedSubstances")]
    [QueryProperty(nameof(StartDateTime), "StartDateTime")]
    public partial class OnboardingUsageViewModel : ObservableViewModel
    {
        [ObservableProperty]
        public partial List<SubstanceItem>? SelectedSubstances
        {
            get; set;
        }

        [ObservableProperty]
        public partial DateTime StartDateTime
        {
            get; set;
        }

        // Using decimal for currency calculations
        [ObservableProperty]
        public partial decimal? EstimatedCost
        {
            get; set;
        }

        public ObservableCollection<FrequencyItem> Frequencies { get; } = new();

        [ObservableProperty]
        public partial FrequencyItem? SelectedFrequency
        {
            get; set;
        }

        public OnboardingUsageViewModel()
        {
            // TODO: Replace these hardcoded strings with AppResources later
            this.Title = "Let's set your baseline";
            this.Description = "This helps us calculate the exact amount of money you are saving.";

            this.LoadFrequencies();

            // Default to Daily (7 days)
            this.SelectedFrequency = this.Frequencies.LastOrDefault();
        }

        private void LoadFrequencies()
        {
            // TODO: Replace these hardcoded strings with AppResources later
            this.Frequencies.Add(new FrequencyItem { DisplayText = "1 day a week", DaysPerWeek = 1 });
            this.Frequencies.Add(new FrequencyItem { DisplayText = "2 days a week", DaysPerWeek = 2 });
            this.Frequencies.Add(new FrequencyItem { DisplayText = "3 days a week", DaysPerWeek = 3 });
            this.Frequencies.Add(new FrequencyItem { DisplayText = "4 days a week", DaysPerWeek = 4 });
            this.Frequencies.Add(new FrequencyItem { DisplayText = "5 days a week", DaysPerWeek = 5 });
            this.Frequencies.Add(new FrequencyItem { DisplayText = "6 days a week", DaysPerWeek = 6 });
            this.Frequencies.Add(new FrequencyItem { DisplayText = "Daily", DaysPerWeek = 7 });
        }

        [RelayCommand]
        private async Task ContinueAsync()
        {
            var navParams = new Dictionary<string, object>
        {
            { "SelectedSubstances", this.SelectedSubstances! },
            { "StartDateTime", this.StartDateTime },
            { "EstimatedCost", this.EstimatedCost ?? 0m },
            { "DaysPerWeek", this.SelectedFrequency?.DaysPerWeek ?? 7 }
        };

            // Use your dynamic routing name matching
            await Shell.Current.GoToAsync(nameof(OnboardingMotivationView), navParams);
        }
    }
}