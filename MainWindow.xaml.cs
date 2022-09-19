using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using SALA_CINE_CARVAJAL.Models;
using SALA_CINE_CARVAJAL.Views;
namespace SALA_CINE_CARVAJAL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Usuario _usuario_login;

        public MainWindow(Usuario usuario)
        {
            _usuario_login = usuario;
            InitializeComponent();
            this.Activated += MainWindow_Activated;
            this.Closed += MainWindow_Closed;
        }

        private void MainWindow_Activated(object? sender, EventArgs e)
        {
            if (Thread.CurrentPrincipal.IsInRole("ADMINISTRADOR"))
            {
                ((FrameworkElement)this.FindName("MENUADMINISTRADOR")).Visibility = Visibility.Visible;
                ((FrameworkElement)this.FindName("BOTONESADMINISTRADOR")).Visibility = Visibility.Visible;
            }
        }

        private void MainWindow_Closed(object? sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new AdministracionUsuarios(_usuario_login);
            Application.Current.MainWindow.Show();
            
        }

        private void MenuItemAdministrarPeliculas_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new AdministracionPeliculas(_usuario_login);
            Application.Current.MainWindow.Show();
        }

        private void AdministrarSalas_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new AdministrarSala(_usuario_login);
            Application.Current.MainWindow.Show();
        }
    }
}
