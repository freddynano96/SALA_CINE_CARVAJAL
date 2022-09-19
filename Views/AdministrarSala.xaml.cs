using SALA_CINE_CARVAJAL.Models;
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
using System.Windows.Shapes;

namespace SALA_CINE_CARVAJAL.Views
{
    /// <summary>
    /// Interaction logic for AdministrarSala.xaml
    /// </summary>
    public partial class AdministrarSala : Window
    {
        private readonly Usuario _usuario_login;

        private Sala SalaSeleccionada = null;
    

        public AdministrarSala(Usuario usuarioLogin )
        {
            _usuario_login = usuarioLogin;
            InitializeComponent();
        }

        private void Eliminar_Sala_Click(object sender, RoutedEventArgs e)
        {
            ((dynamic)DataContext).EliminarSala(Convert.ToInt32(((Button)(sender)).Tag));
        }
    }
}
