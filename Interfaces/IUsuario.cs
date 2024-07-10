using Final_Algoritmos_2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Algoritmos_2.Interfaces
{
    internal interface IUsuario
    {
        string Nombre {get;set;}
        int Dni {get;set;}
        string Mail {get;set;}

        bool DniExist(int dni);

        bool MailExist(string mail);

        Usuario FindByMail(string mail);

        Usuario FindByDni(int dni);

        List<Usuario> List();
    }
}
