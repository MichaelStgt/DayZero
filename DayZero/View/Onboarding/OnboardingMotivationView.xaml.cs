namespace DayZero.View
{
    public partial class OnboardingMotivationView : ContentPage, IShellNavigationTarget
    {
        public OnboardingMotivationView()
        {
            throw new NotImplementedException();
        }

        public OnboardingMotivationView(OnboardingMotivationViewModel viewModel)
        {
            this.InitializeComponent();
            this.ViewModel = viewModel;
            this.BindingContext = this.ViewModel;
        }

        public ObservableViewModel? ViewModel
        {
            get; set;
        }
    }
}