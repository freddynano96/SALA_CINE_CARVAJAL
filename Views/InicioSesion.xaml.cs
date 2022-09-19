using SALA_CINE_CARVAJAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace SALA_CINE_CARVAJAL.Views
{
    /// <summary>
    /// Interaction logic for InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        
        public InicioSesion()
        {
            InitializeComponent();
            txtPassword.PasswordChanged += OnPasswordChanged;
            INotifyPropertyChanged usuarioContext = DataContext as INotifyPropertyChanged;
            if (usuarioContext != null)
            {
                usuarioContext.PropertyChanged += new PropertyChangedEventHandler(OnInicioSesionValido);
            }
        }

        private void OnInicioSesionValido(object o, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(ViewModels.InicioSesionViewModel.UsuarioModel))
            {
                if(((dynamic)DataContext).UsuarioModel != null)
                {
                    Application.Current.MainWindow = new MainWindow((Usuario)(((dynamic)DataContext).UsuarioModel));
                    Application.Current.MainWindow.Show();
                    this.Hide();
                }
            }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
            {
                ((dynamic)DataContext).Password = ((PasswordBox)sender).SecurePassword;
            }
        }


    }
}
