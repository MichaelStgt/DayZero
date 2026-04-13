using DayZero.Model;
using System.Collections.ObjectModel;

namespace DayZero.ViewModel
{
    public partial class OnboardingSubstanceViewModel : ObservableViewModel
    {
        // The list that your XAML CollectionView will bind to
        public ObservableCollection<SubstanceItem> Substances { get; } = new();

        public OnboardingSubstanceViewModel()
        {
            // this.Title = "What are you stepping away from?";
            // this.Description = "Select the habits you want to break today.";
            this.Title = AppResources.OnboardingSubstanceTitle;
            this.Description = AppResources.OnboardingSubstanceDescription;
            // Initialize the default list
            this.LoadDefaultSubstances();
        }

        private void LoadDefaultSubstances()
        {
            this.Substances.Add(new SubstanceItem { Name = AppResources.Alcohol, IsSelected = false });
            this.Substances.Add(new SubstanceItem { Name = AppResources.Nicotine, IsSelected = false });
            this.Substances.Add(new SubstanceItem { Name = AppResources.Other, IsSelected = false });
        }

        //[RelayCommand]
        //private async Task ContinueAsync()
        //{
        //    var selectedSubstances = this.Substances.Where(s => s.IsSelected).ToList();

        //    if (!selectedSubstances.Any())
        //    {
        //        // TODO: Show an alert or validation message telling the user to pick at least one
        //        return;
        //    }

        //    // TODO: Navigate to OnboardingDateView and pass the selectedSubstances array
        //}

        [RelayCommand]
        private async Task ContinueAsync()
        {
            var selectedSubstances = this.Substances.Where(s => s.IsSelected).ToList();

            if (!selectedSubstances.Any())
            {
                // TODO: Add an alert (e.g., Shell.Current.DisplayAlert) telling the user to pick at least one
                return;
            }

            // Pass the selected items to the next page
            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedSubstances", selectedSubstances }
            };

            await Shell.Current.GoToAsync(nameof(OnboardingDateView), navigationParameter);
        }

    }
}