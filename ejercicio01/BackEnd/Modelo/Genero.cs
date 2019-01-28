using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelo
{
    public class Genero
    {
        int idgenero;
        string descripcion;

        public Genero() { }
        public Genero(int idgenero, string descripcion)
        {
            this.idgenero = idgenero;
            this.descripcion = descripcion;
        }

        public int Idgenero
        {
            get
            {
                return idgenero;
            }

            set
            {
                idgenero = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}
