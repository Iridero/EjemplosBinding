using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjemplosBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Alumno> grupo;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grupo=new List<Alumno>();
            grupo.Add(new Alumno("01","Ana",DateTime.Parse("05/12/2010")));
            grupo.Add(new Alumno("02", "Sergio", DateTime.Parse("11/09/2010")));
            grupo.Add(new Alumno("03", "Maria", DateTime.Parse("05/11/2011")));
            lstAlumnos.ItemsSource = grupo;
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            var contenedor = (GroupBox) ((UniformGrid)btnEliminar.Parent).Parent;
            var a = (Alumno)contenedor.DataContext;            
            MessageBox.Show(a.Nombre);
            
        }
    }
    
}
