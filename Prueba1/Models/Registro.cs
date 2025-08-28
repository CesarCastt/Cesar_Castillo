using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Models
{
    public class Registro
    {
        public string NombreAlumno { get; set; }
        public string NombreRamo { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float Nota4 { get; set; }
        public int Ponderacion1 { get; set; }
        public int Ponderacion2 { get; set; }
        public int Ponderacion3 { get; set; }
        public int Ponderacion4 { get; set; }
        public float NotaExamen { get; set; }
        public float PromedioFinal { get; set; }
    }

}
