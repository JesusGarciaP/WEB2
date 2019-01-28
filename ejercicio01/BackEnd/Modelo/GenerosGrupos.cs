using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelo
{
    public class GenerosGrupos
    {
        int idgrupo;
        int idgenero;

        public GenerosGrupos() { }
        
        public GenerosGrupos(int idgrupo, int idgenero)
        {
            this.idgrupo = idgrupo;
            this.idgenero = idgenero;
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
    }
}
