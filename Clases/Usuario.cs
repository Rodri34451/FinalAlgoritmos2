using Final_Algoritmos_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Algoritmos_2.Clases
{
    internal class Usuario : IABMC<Usuario>, IUsuario
    {
        static List<Usuario> Usuarios = new List<Usuario>();
        private static int lasId = 0;

        #region IDD
        public int ID { get; set; }
        #endregion

        # region IUsuario
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Mail { get; set; }

        public Usuario FindByDni(int dni) //Para encontrar usuarios en base a su DNI
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Dni == dni)
                {
                    return u;
                }
            }
            throw new Exception("");
        }

        public Usuario FindByMail(string mail) //Para encontrar a usuarios en base a su mail
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Mail == mail)
                {
                    return u;
                }
            }
            throw new Exception("");
        }

        public bool MailExist(string mail) //Para verificar si el mail de un usuario ingresado ya existe en la lista
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Mail == mail)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DniExist(int dni) //Para verificar si el DNI de un usuario ingresado ya existe en la lista
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Dni == dni)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Usuario> List() //Lista que contiene a los usuarios ingresados
        {
            return Usuarios;
        }
        #endregion

        #region IABMC
        public void Add(Usuario usuario) //Para añadir usuarios
        {
            if (MailExist(usuario.Mail)) throw new Exception("");
            if (DniExist(usuario.Dni)) throw new Exception("");

            usuario.ID = lasId;
            lasId++;
            Usuarios.Add(usuario);
        }

        public void Modify(Usuario usuario) //Para modificar el nombre de los usuarios
        {
            Usuario u = Find(usuario);
            if (u == null) throw new Exception("");
            u.Nombre = usuario.Nombre;
        }

        public void Erase(Usuario usuario) //Para borrar usuarios
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Dni == usuario.Dni)
                {
                    Usuarios.Remove(u);

                    return;
                }
            }
            throw new Exception("");
        }

        public Usuario Find(Usuario usuario) //Para encontrar usuarios en base a su ID
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.ID == usuario.ID)
                {
                    return u;
                }
            }
            throw new Exception("");
        }
        #endregion
    }
}
