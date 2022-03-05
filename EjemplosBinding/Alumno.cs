using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosBinding
{
    public class Alumno
    {
        public Alumno(string numControl, string nombre, DateTime fechaDeNacimiento)
        {
            NumControl = numControl;
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
        }
        public string NumControl { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
    }
}
