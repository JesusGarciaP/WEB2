using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelo
{
    public class Grupo
    {
        int idgrupo;
        string nombre;
        DateTime formacion;
        DateTime desintegracion;

        public Grupo() { }

        public Grupo(int idgrupo, string nombre, DateTime formacion, DateTime desintegracion)
        {
            this.Idgrupo = idgrupo;
            this.Nombre = nombre;
            this.Formacion = formacion;
            this.Desintegracion = desintegracion;
        }

        public int Idgrupo
        {
            get
            {
                return idgrupo;
            }

            set
            {
                idgrupo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public DateTime Formacion
        {
            get
            {
                return formacion;
            }

            set
            {
                formacion = value;
            }
        }

        public DateTime Desintegracion
        {
            get
            {
                return desintegracion;
            }

            set
            {
                desintegracion = value;
            }
        }

        
    }
}
