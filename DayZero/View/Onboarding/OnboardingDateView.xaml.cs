// <copyright file="OnboardingDateView.xaml.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.View
{
    /// <summary>
    /// Defines the <see cref="OnboardingDateView" />.
    /// </summary>
    public partial class OnboardingDateView : ContentPage, IShellNavigationTarget
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingDateView"/> class.
        /// </summary>
        public OnboardingDateView()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingDateView"/> class.
        /// </summary>
        /// <param name="viewModel">The viewModel<see cref="OnboardingDateViewModel"/>.</param>
        public OnboardingDateView(OnboardingDateViewModel viewModel)
        {
            this.InitializeComponent();
            this.ViewModel = viewModel;
            this.BindingContext = this.ViewModel;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ViewModel.
        /// </summary>
        public ObservableViewModel? ViewModel
        {
            get; set;
        }

        #endregion
    }
}