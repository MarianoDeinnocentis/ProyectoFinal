using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Carrera: IID, IABMC, ICarrera
    

    {
        static List<Carrera> Carreras = new List<Carrera>();
        public int ID { get; set ; }
        public string Nombre { get ; set ; }
        public string Sigla { get ; set ; }
        public string Titulo { get ; set; }
        public int Duracion { get ; set; }

        public Carrera FindBySigla(string Sigla)
        {
            foreach (var carrera in Carreras)
            {
                if(carrera.Sigla == Sigla) 
                {
                    return carrera;
                } 
            }
            throw new Exception("No se encontro Carrera" +Sigla);
        }

        public string List()
        {
            string result = List();
            foreach (var carrera in Carreras) 
            { 
                result += carrera.List(); 
            }
            return result;
            
        }

        public bool NombreExist(string nombre)
        {
            foreach(var carrera in Carreras) 
            {
                if(carrera.Nombre == nombre)
                {
                    return true;  
                }
            }
            return false;
        }

        public bool SiglaExist(string Sigla)
        {
            foreach (var carrera in Carreras)
            {
                if (carrera.Sigla == Sigla)
                {
                    return true;
                }
            }
            return false;
        }
        
    internal interface IABMC
        {
        }
    }
}


    
}
