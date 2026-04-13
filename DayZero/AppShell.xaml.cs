// <copyright file="AppShell.xaml.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

namespace DayZero
{
    /// <summary>
    /// Defines the <see cref="AppShell" />.
    /// </summary>
    public partial class AppShell : Shell
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AppShell"/> class.
        /// </summary>
        public AppShell()
        {
            throw new NotImplementedException();
            // this.InitializeComponent();

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppShell"/> class.
        /// </summary>
        /// <param name="viewModel">The viewModel<see cref="AppShellViewModel?"/>.</param>
        public AppShell(AppShellViewModel? viewModel)
        {
            this.InitializeComponent();
            this.ViewModel = viewModel;
            this.BindingContext = this.ViewModel;
            this.RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // Get the assembly where your views are located
            var assembly = typeof(AppShell).Assembly;

            // Find all types that implement IShellNavigationTarget, and are actual classes (not the interface itself or abstract classes)
            var viewTypes = assembly.GetTypes()
                .Where(t => typeof(IShellNavigationTarget).IsAssignableFrom(t)
                         && !t.IsInterface
                         && !t.IsAbstract);

            // Iterate and register each dynamically
            foreach (var type in viewTypes)
            {
                Routing.RegisterRoute(type.Name, type);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ViewModel.
        /// </summary>
        public AppShellViewModel? ViewModel
        {
            get; set;
        }

        #endregion
    }
}
