// <copyright file="MainView.xaml.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero.View
{
    /// <summary>
    /// Defines the <see cref="MainView" />.
    /// </summary>
    public partial class MainView : ContentPage
    {
        #region Fields

        /// <summary>
        /// Defines the count.
        /// </summary>
        int count = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainView"/> class.
        /// </summary>
        public MainView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainView"/> class.
        /// </summary>
        /// <param name="viewModel">The viewModel<see cref="MainViewModel"/>.</param>
        public MainView(MainViewModel viewModel)
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

        #region Methods

        /// <summary>
        /// The OnCounterClicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object?"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void OnCounterClicked(object? sender, EventArgs e)
        {
            this.count++;

            if (this.count == 1)
            {
                this.CounterBtn.Text = $"Clicked {this.count} time";
            }
            else
            {
                this.CounterBtn.Text = $"Clicked {this.count} times";
            }

            SemanticScreenReader.Announce(this.CounterBtn.Text);
        }

        #endregion
    }
}
