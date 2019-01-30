using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;
using BackEnd.util;

namespace BackEnd.DAOS
{
    public class MusicoDao
    {
        public List<Musico> getAll()
        {
            List<Musico> Lista = BDDUMMY.ListaMusico;
            return Lista;
        }

        public void add(Musico m)
        {
            List<Musico> Lista = BDDUMMY.ListaMusico;
            Lista.Add(m);
        }
    }
}
