using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;
using BackEnd.util;

namespace BackEnd.DAOS
{
    public class MusicosGruposDao
    {
        public List<MusicosGrupos> getAll()
        {
            List<MusicosGrupos> Lista = BDDUMMY.ListaMusicosGrupos;
            return Lista;
        }

        public void add(MusicosGrupos m)
        {
            List<MusicosGrupos> Lista = BDDUMMY.ListaMusicosGrupos;
            Lista.Add(m);
        }
    }
}
