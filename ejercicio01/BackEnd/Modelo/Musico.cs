using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelo
{
    public class Musico
    {
        int idmusico;
        string nombre;
        string instrumento;
        string lugarnacimiento;
        DateTime fechanacimiento;
        DateTime fechamuerte;
        public Musico() { }
        public Musico(int idmusico, string nombre, string instrumento, string lugarnacimiento, DateTime fechanacimiento, DateTime fechamuerte)
        {
            this.idmusico = idmusico;
            this.nombre = nombre;
            this.instrumento = instrumento;
            this.lugarnacimiento = lugarnacimiento;
            this.fechanacimiento = fechanacimiento;
            this.fechamuerte = fechamuerte;
        }

        public int Idmusico
        {
            get
            {
                return idmusico;
            }

            set
            {
                idmusico = value;
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

        public string Instrumento
        {
            get
            {
                return instrumento;
            }

            set
            {
                instrumento = value;
            }
        }

        public string Lugarnacimiento
        {
            get
            {
                return lugarnacimiento;
            }

            set
            {
                lugarnacimiento = value;
            }
        }

        public DateTime Fechanacimiento
        {
            get
            {
                return fechanacimiento;
            }

            set
            {
                fechanacimiento = value;
            }
        }

        public DateTime Fechamuerte
        {
            get
            {
                return fechamuerte;
            }

            set
            {
                fechamuerte = value;
            }
        }
    }
}
