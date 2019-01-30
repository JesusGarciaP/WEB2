using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;
using BackEnd.util;

namespace BackEnd.DAOS
{
    public class GenerosGruposDao
    {
        public List<GenerosGrupos> getAll()
        {
            List<GenerosGrupos> Lista = BDDUMMY.ListaGenerosGrupos;
            return Lista;
        }

        public void add(GenerosGrupos m)
        {
            List<GenerosGrupos> Lista = BDDUMMY.ListaGenerosGrupos;
            Lista.Add(m);
        }
    }
}
