// <copyright file="MauiProgram.cs" company="Behr, Michael">
// Copyright Behr, Michael.
// All rights reserved.
// Use of this code is subject to the terms of our license.
// See license.txt file in the project root for full license information.
// </copyright>

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DayZero
{
    using CommunityToolkit.Maui.Core;
    using DayZero.Resources.Generated;
    using LibraryTen;
    using LibraryTen.Authentication;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Defines the <see cref="MauiProgram" />.
    /// </summary>
    public static class MauiProgram
    {
        #region Methods

        /// <summary>
        /// The CreateMauiApp.
        /// </summary>
        /// <returns>The <see cref="MauiApp"/>.</returns>
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureAutoFonts()
                .UseMauiCommunityToolkitCore()
                .UseMauiCommunityToolkit(static options =>
                {
                    options.SetShouldUseStatusBarBehaviorOnAndroidModalPage(true);
                });

            //#if DEBUG
            //            builder.Logging.AddDebug();
            //#endif

            Type[] inputElement = [typeof(Entry), typeof(Editor), typeof(DatePicker), typeof(TimePicker)];
            builder.InputElementBorder(removeBorder: true, args: inputElement);

            builder.UseLibraryToolkit();
            // RegisterEssentials(builder);
            RegisterNavigation(builder);
            RegisterDependencies(builder);
            builder.InitializeServiceHelper();

            return builder.Build();
        }

        /// <summary>
        /// The RegisterNavigation.
        /// </summary>
        /// <param name="builder">The builder<see cref="MauiAppBuilder"/>.</param>
        private static void RegisterNavigation(in MauiAppBuilder builder)
        {
#pragma warning disable CA1416 // Validate platform compatibility

            builder.Services.AddSingleton<AboutViewModel>();
            builder.Services.AddSingleton<AppShellViewModel>();
            builder.Services.AddSingleton<MainWindowViewModel>();
            builder.Services.AddSingleton<MainViewModel>();


            builder.Services.AddTransient<DashboardView>();
            builder.Services.AddTransient<DashboardViewModel>();

            // Register Dependencies for Onboarding
            builder.Services.AddTransient<OnboardingSubstanceViewModel>();
            builder.Services.AddTransient<OnboardingSubstanceView>();

            builder.Services.AddTransient<OnboardingDateViewModel>();
            builder.Services.AddTransient<OnboardingDateView>();

            builder.Services.AddTransient<OnboardingUsageView>();
            builder.Services.AddTransient<OnboardingUsageViewModel>();

            builder.Services.AddTransient<OnboardingMotivationView>();
            builder.Services.AddTransient<OnboardingMotivationViewModel>();

#if WINDOWS
            builder.Services.AddSingleton<View.Desktop.MainView>();
#else
            if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            {
                // builder.Services.AddTransientWithShellRoute<View.MainView, MainViewModel>();
                builder.Services.AddSingleton<View.Tablet.MainView>();
            }
            else if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
            {
                builder.Services.AddSingleton<View.Tablet.MainView>();
            }
#endif
#pragma warning restore CA1416 // Validate platform compatibility

        }

        /// <summary>
        /// Registers the dependencies.
        /// </summary>
        /// <param name="builder">The builder.</param>
        private static void RegisterDependencies(in MauiAppBuilder builder)
        {
#pragma warning disable CA1416 // Validate platform compatibility
            builder.Services.AddSingleton<IBiometric>(provider => BiometricAuthenticationService.Default);
            builder.Services.AddSingleton<IWindowCreator, Services.WindowCreator>();
        }



        ///// <summary>
        ///// Registers the essentials.
        ///// </summary>
        ///// <param name="builder">The builder.</param>
        //private static void RegisterEssentials(in MauiAppBuilder builder)
        //{
        //    builder.Services.AddSingleton<IDeviceDisplay>(DeviceDisplay.Current);
        //    builder.Services.AddSingleton<IDeviceInfo>(DeviceInfo.Current);
        //    builder.Services.AddSingleton<IFileSaver>(FileSaver.Default);
        //    builder.Services.AddSingleton<IFileSystem>(FileSystem.Current);
        //    builder.Services.AddSingleton<IFolderPicker>(FolderPicker.Default);
        //}

        #endregion
    }
}
