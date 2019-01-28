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
        string formacion;
        string desintegracion;

        public Grupo() { }

        public Grupo(int idgrupo, string nombre, string formacion, string desintegracion)
        {
            this.idgrupo = idgrupo;
            this.nombre = nombre;
            this.formacion = formacion;
            this.desintegracion = desintegracion;
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

        public string Formacion
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

        public string Desintegracion
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
