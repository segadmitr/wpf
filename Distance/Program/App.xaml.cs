using System.Windows;
using DistanceCalculation.ViewModels;
using DistanceCalculation.Views;

namespace DistanceCalculation
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var view = new MainWindow();
            var viewModel = new MainViewModel();
            view.DataContext = viewModel; 
            view.Show();
        }
    }
}
