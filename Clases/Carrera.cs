using Final_Algoritmos_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Algoritmos_2.Clases
{
    internal class Carrera : IDD, IABMC<Carrera>, ICarrera
    {
        static List<Carrera> Carreras = new List<Carrera>();
        private static int lasId = 0;

        #region IDD
        public int ID { get; set; }
        #endregion

        #region IABMC
        
        public void Add(Carrera carrera) //Para agregar carreras
        {
            if (NameExists(carrera.nombre)) throw new Exception("");
            if (SiglaExists(carrera.sigla)) throw new Exception("");

            carrera.ID = lasId;
            lasId++;
            Carreras.Add(carrera);
        }

        public void Modify(Carrera carrera) //Para modificar el nombre de las carreras
        {
            Carrera c = Find(carrera);
            if (c.Equals(null)) throw new Exception("");
            c.nombre = carrera.nombre;
        }

        public void Erase(Carrera carrera) //Para eliminar carreras
        {
            foreach (Carrera c in Carreras)
            {
                if (c.sigla.Equals(carrera.sigla))
                {
                    Carreras.Remove(c);

                    return;
                }
            }
            throw new Exception("");
        }

        public Carrera Find(Carrera carrera) //Para encontrar carreras en base a su ID
        {
            foreach (Carrera c in Carreras)
            {
                if (c.ID.Equals(carrera.ID))
                {
                    return c;
                }
            }
            throw new Exception("");
        }
        #endregion

        #region ICarrera
        public string nombre { get; set; }
        public string sigla { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }

        public Carrera FindBySigla(string sigla) //Para encontrar carreras en base a sus siglas
        {
            foreach (Carrera c in Carreras)
            {
                if (c.sigla == sigla)
                {
                    return c;
                }
            }
            throw new Exception("No hay ninguna carrera con las siglas ingresadas");
        }

        public List<Carrera> List() //Lista que contiene las carreras ingresadas
        {
            return Carreras;
        }

        public bool NameExists(string nombre) //Para verificar si el nombre de la carrera ingresada ya existe
        {
            foreach(Carrera c in Carreras)
            {
                if(c.nombre.Equals(nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SiglaExists(string sigla) //Para verificar si las siglas de la carrera ingresada ya existe
        {
            foreach(Carrera c in Carreras)
            {
                if(c.sigla.Equals(sigla))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
