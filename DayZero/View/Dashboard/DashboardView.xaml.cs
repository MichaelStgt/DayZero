namespace DayZero.View;

public partial class DashboardView : ContentPage, IShellNavigationTarget
{
    public DashboardView()
    {
        throw new NotImplementedException();
    }

    public DashboardView(DashboardViewModel viewModel)
    {
        InitializeComponent();
        this.ViewModel = viewModel;
        BindingContext = this.ViewModel;
    }

    public ObservableViewModel? ViewModel
    {
        get; set;
    }
}