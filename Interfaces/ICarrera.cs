using Final_Algoritmos_2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Algoritmos_2.Interfaces
{
    internal interface ICarrera
    {
        string nombre { get; set; }
        string sigla { get; set; }
        string titulo { get; set; }
        int duracion { get; set; }

        Carrera FindBySigla(string sigla);

        List<Carrera> List();

        bool NameExists(string nombre);

        bool SiglaExists(string nombre);
    }
}
