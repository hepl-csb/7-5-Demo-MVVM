using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Models;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            //Ici le this, à savoir la fenêtre est sous-entendu.
            // Donc c'est bien le dataContext de la fenêtre qui vaut _viewModel
            DataContext = _viewModel;
        }

        private void BtnToggle_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ToggleCase();
        }

        private void ListViewPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.CurrentPerson = ListViewPeople.SelectedItem as Person;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.CurrentPerson = DataGrid.CurrentItem as Person;
        }
    }
}
