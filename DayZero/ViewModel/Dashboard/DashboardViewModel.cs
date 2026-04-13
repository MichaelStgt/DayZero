// <copyright file="DashboardViewModel.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.ViewModel
{
    /// <summary>
    /// Defines the <see cref="DashboardViewModel" />.
    /// </summary>
    public partial class DashboardViewModel : ObservableViewModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardViewModel"/> class.
        /// </summary>
        public DashboardViewModel()
        {
            this.Title = AppResources.Dashboard;
            // TODO: Replace these hardcoded strings with AppResources later
            this.Description = "Welcome to Day Zero.";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [ObservableProperty]
        public partial string? Text
        {
            get; set;
        }

        #endregion

        #region Methods


        #endregion
    }
}
