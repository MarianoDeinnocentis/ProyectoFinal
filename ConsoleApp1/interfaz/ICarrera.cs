using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal interface ICarrera: IABMC
    {
        string Nombre { get; set; }
        string Sigla { get; set; }
        string Titulo { get; set; }
        int Duracion { get; set; }

        Carrera FindBySigla(string Sigla);
        String List();
        bool NombreExist(String Nombre);
        bool SiglaExist(String Sigla);

    }
}
