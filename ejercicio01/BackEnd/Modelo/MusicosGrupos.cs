using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelo
{
    public class MusicosGrupos
    {
        int idgrupo;
        int idmusico;
        string instrumento;
        DateTime fechainicio;
        DateTime fechafin;
        public MusicosGrupos() { }
        public MusicosGrupos(int idgrupo, int idmusico, string instrumento, DateTime fechainicio, DateTime fechafin)
        {
            this.idgrupo = idgrupo;
            this.idmusico = idmusico;
            this.instrumento = instrumento;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
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

        public DateTime Fechainicio
        {
            get
            {
                return fechainicio;
            }

            set
            {
                fechainicio = value;
            }
        }

        public DateTime Fechafin
        {
            get
            {
                return fechafin;
            }

            set
            {
                fechafin = value;
            }
        }
    }
}
