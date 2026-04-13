// <copyright file="DashboardView.xaml.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.View
{
    /// <summary>
    /// The main view.
    /// </summary>
    public partial class DashboardView : ContentPage
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardView"/> class.
        /// </summary>
        public DashboardView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardView"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public DashboardView(DashboardViewModel viewModel)
        {
            this.InitializeComponent();
            this.ViewModel = viewModel;
            this.BindingContext = this.ViewModel;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        public ObservableViewModel? ViewModel
        {
            get; set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The OnAppearing.
        /// </summary>
        protected async override void OnAppearing()
        {
        }

        #endregion
    }
}
