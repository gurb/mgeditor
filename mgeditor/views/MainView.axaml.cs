using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using mgeditor.viewmodels;

namespace mgeditor;

public partial class MainView : UserControl
{

    public MainViewModel ViewModel { get; private set; }

    public MainView()
    {
        ViewModel = App.GetService<MainViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }
}