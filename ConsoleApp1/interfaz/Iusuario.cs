using Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto

{
    internal interface Iusuario
    {
        String nombre { get; set; }
        int Dni { get; set; }
        String Mail { get; set; }
        bool DniExist(int dni);
        bool MailExist(string mail);
        Usuario FindByMail(string mail);
        Usuario FindByDni(int dni);
        
        List<Usuario> List();


    }
}
