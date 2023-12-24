using Microsoft.UI.Xaml.Controls;

using Prayer_Mate.ViewModels;

namespace Prayer_Mate.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
