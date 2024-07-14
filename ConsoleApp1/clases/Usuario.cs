using Proyecto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
     
{
    internal class Usuario : IABMC<Usuario>, Iusuario, IID
    {
        static List<Usuario> Usuarios=new List<Usuario>();
        private static int lastid = 0;
        #region IID 
        public int ID { get; set; }
        #endregion
        #region Iusuario
        public string nombre { get ; set; }
        public int Dni { get ; set; }
        public string Mail { get ; set; }
        public bool DniExist(int dni)
        {
            foreach(Usuario i in Usuarios) 
            {
                if (i.Dni == dni) 
                {
                    return true; 
                }
            }
            return false;
        }
        public bool MailExist(string mail)
        {
            foreach(Usuario i in Usuarios)
            {
                if (i.Mail == mail)
                {
                    return true;
                }
            }
            return false;
        }

        public Usuario FindByDni(int dni)
        {
            foreach (Usuario i in Usuarios)
            {
                if (i.Dni == dni)
                {
                    return i;
                }

            }
            throw new Exception("No se encontro Dni ingresado: " + dni); ;
        }

        public Usuario FindByMail(string mail)
        {
            foreach (Usuario i in Usuarios)
            {
                if (i.Mail == mail)
                {
                    return i;
                }

            }
            throw new Exception("No se encontro Mail ingresado: " + mail);


        }
        public List<Usuario> List() 
        {
            return Usuarios;
        }

        #endregion
        #region IABMC
        public void Add(Usuario usuario)
        {
           if (MailExist(usuario.Mail)) throw new Exception("El Mail ingresado ya existe");
           if (DniExist(usuario.Dni)) throw new Exception("El Dni ingresado ya existe");

            usuario.ID = lastid;
            lastid++;
            Usuarios.Add(usuario);
        }
        public void Erase(Usuario usuario)
        {
            foreach (Usuario i in Usuarios)
            {
                if(i.Dni == usuario.Dni) 
                {
                    Usuarios.Remove(i); return;
                }
            }
            throw new Exception("No se puede borrar Usuario con ID: " + usuario.Dni);
        }
        public Usuario Find(Usuario usuario)
        {
           foreach (Usuario i in Usuarios)
            {
                if (i.ID == usuario.ID) 
                {
                    return i;
                }
            }
            throw new Exception("No se encontro usurio con ID: " + usuario.ID);
        }
        public void Modify(Usuario usuario)
        {
            Usuario i=Find(usuario);
            if (i != null) throw new Exception("El usurio no existe: ");
            i.nombre = usuario.nombre;
        }
        #endregion
    }
}
