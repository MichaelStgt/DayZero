// <copyright file="OnboardingDateViewModel.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.ViewModel
{
    using DayZero.Model;

    [QueryProperty(nameof(SelectedSubstances), "SelectedSubstances")]
    public partial class OnboardingDateViewModel : ObservableViewModel
    {
        #region Constructors

        public OnboardingDateViewModel()
        {
            //Title = "When did your Day Zero begin?";
            //Description = "Select the date and time of your last use.";
            // TODO: Replace these hardcoded strings with AppResources later
            this.Title = "When did your Day Zero begin?";
            this.Description = "Select the date and time of your last use.";
        }

        #endregion

        #region Properties

        // Receives the data from the previous page

        [ObservableProperty]
        public partial List<SubstanceItem>? SelectedSubstances
        {
            get; set;
        }

        [ObservableProperty]
        public partial DateTime StartDate { get; set; } = DateTime.Today;

        [ObservableProperty]
        public partial TimeSpan StartTime { get; set; } = DateTime.Now.TimeOfDay;

        #endregion

        #region Methods

        //[RelayCommand]
        //private async Task ContinueAsync()
        //{
        //    // Combine Date and Time into a single DateTime record
        //    DateTime finalStartDateTime = this.StartDate.Date + this.StartTime;
        //}

        [RelayCommand]
        private async Task ContinueAsync()
        {
            // Combine Date and Time into a single DateTime record
            DateTime finalStartDateTime = this.StartDate.Date + this.StartTime;

            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedSubstances", this.SelectedSubstances! },
                { "StartDateTime", finalStartDateTime }
            };

            await Shell.Current.GoToAsync(nameof(OnboardingUsageView), navigationParameter);
        }

        #endregion
    }
}
