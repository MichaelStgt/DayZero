// <copyright file="OnboardingSubstanceView.xaml.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.View
{
    /// <summary>
    /// Defines the <see cref="OnboardingSubstanceView" />.
    /// </summary>
    public partial class OnboardingSubstanceView : ContentPage, IShellNavigationTarget
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingSubstanceView"/> class.
        /// </summary>
        public OnboardingSubstanceView()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingSubstanceView"/> class.
        /// </summary>
        /// <param name="viewModel">The viewModel<see cref="OnboardingSubstanceViewModel"/>.</param>
        public OnboardingSubstanceView(OnboardingSubstanceViewModel viewModel)
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