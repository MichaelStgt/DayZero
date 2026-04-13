// <copyright file="AboutView.xaml.cs" company="Behr, Michael">
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
    public partial class AboutView : ContentPage
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutView"/> class.
        /// </summary>
        public AboutView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutView"/> class.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        public AboutView(AboutViewModel viewModel)
        {
            this.InitializeComponent();
            this.ViewModel = viewModel;
            this.BindingContext = this.ViewModel ?? throw new ArgumentNullException(nameof(viewModel));
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
