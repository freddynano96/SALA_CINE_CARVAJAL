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
    /// Interaction logic for AdministrarUsuarios.xaml
    /// </summary>
    public partial class AdministracionUsuarios : Window
    {
        private readonly Usuario _usuarioAutenticado;
        public AdministracionUsuarios(Usuario usuarioAutenticado)
        {
            InitializeComponent();
            _usuarioAutenticado = usuarioAutenticado;
        }
    }
}
