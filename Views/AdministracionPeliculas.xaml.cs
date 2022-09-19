using SALA_CINE_CARVAJAL.Models;
using SALA_CINE_CARVAJAL.ViewModels;
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
    /// Interaction logic for AdministracionPeliculas.xaml
    /// </summary>
    public partial class AdministracionPeliculas : Window
    {
        private readonly Usuario _usuarioAutenticado;
        public AdministracionPeliculas(Usuario usuarioAutenticado)
        {
            InitializeComponent();
            _usuarioAutenticado = usuarioAutenticado;
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            ((dynamic)DataContext).EliminarPelicula(Convert.ToInt32(((Button)(sender)).Tag));
        }
    }
}
