// <copyright file="OnboardingMotivationViewModel.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.ViewModel
{
    using DayZero.Model;
    using System.Collections.ObjectModel;

    [QueryProperty(nameof(SelectedSubstances), "SelectedSubstances")]
    [QueryProperty(nameof(StartDateTime), "StartDateTime")]
    [QueryProperty(nameof(EstimatedCost), "EstimatedCost")]
    [QueryProperty(nameof(DaysPerWeek), "DaysPerWeek")]
    public partial class OnboardingMotivationViewModel : ObservableViewModel
    {
        #region Constructors

        public OnboardingMotivationViewModel()
        {
            // TODO: Replace these hardcoded strings with AppResources later

            this.Title = "What is your primary drive?";
            this.Description = "Remind yourself why you are starting this journey.";

            this.LoadMotivations();
        }

        #endregion

        #region Properties

        [ObservableProperty]
        public partial string? CustomMotivation
        {
            get; set;
        }

        [ObservableProperty]
        public partial int DaysPerWeek
        {
            get; set;
        }

        [ObservableProperty]
        public partial decimal EstimatedCost
        {
            get; set;
        }

        public ObservableCollection<MotivationItem> Motivations { get; } = new();

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

        #endregion

        #region Methods

        [RelayCommand]
        private async Task FinishOnboardingAsync()
        {
            // 1. Gather all selected motivations
            var selectedMotivations = this.Motivations.Where(m => m.IsSelected).Select(m => m.Text).ToList();
            if (!string.IsNullOrWhiteSpace(this.CustomMotivation))
            {
                selectedMotivations.Add(this.CustomMotivation);
            }

            // 2. Construct the final Record (You will eventually save this to a local SQLite DB)
            var newRecord = new SobrietyRecord
            {
                Id = Guid.NewGuid(),
                // Storing as a comma-separated string for simplicity right now
                SubstanceType = string.Join(", ", this.SelectedSubstances?.Select(s => s.Name) ?? Array.Empty<string>()),
                StartDate = this.StartDateTime
                // Note: You would also save EstimatedCost, DaysPerWeek, and Motivations to your database here
            };

            // 3. Mark Onboarding as Complete in Preferences
            Preferences.Default.Set("IsFirstLaunch", false);

            // 4. Exit the Onboarding Flow and transition to the Main AppShell
            // Double slashes clear the navigation stack so the user can't hit "Back" into the wizard
            await Shell.Current.GoToAsync("//DashboardView");
        }

        private void LoadMotivations()
        {
            // TODO: Replace these hardcoded strings with AppResources later
            this.Motivations.Add(new MotivationItem { Text = "Improve physical health", IsSelected = false });
            this.Motivations.Add(new MotivationItem { Text = "Mental clarity & focus", IsSelected = false });
            this.Motivations.Add(new MotivationItem { Text = "Save money", IsSelected = false });
            this.Motivations.Add(new MotivationItem { Text = "For my family/loved ones", IsSelected = false });
        }

        #endregion
    }
}