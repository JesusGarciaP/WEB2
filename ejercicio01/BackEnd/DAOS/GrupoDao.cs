using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;
using BackEnd.util;

namespace BackEnd.DAOS
{
    public class GrupoDao
    {
        public List<Grupo> getAll()
        {
            List<Grupo> Lista = BDDUMMY.ListaGrupo;
            return Lista;
        }

        public void add(Grupo m)
        {
            List<Grupo> Lista = BDDUMMY.ListaGrupo;
            Lista.Add(m);
        }
    }
}
