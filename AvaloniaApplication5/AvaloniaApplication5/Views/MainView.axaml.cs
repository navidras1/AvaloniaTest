using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication5.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Btn1_OnClick(object? sender, RoutedEventArgs e)
    {
        //throw new System.NotImplementedException();
        var a = 5;
        var b = 6;
        var c = a + b;
    }
}