using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.DAOS
{
    public class GenerosGruposDao
    {
        public List<GenerosGrupos> getAll()
        {
            List<GenerosGrupos> lista;
            lista = new List<GenerosGrupos>();
            lista.Add(new GenerosGrupos()
            {
                Idgrupo = 1,
                Idgenero = 1
            });
            return lista;
        }
    }
}
