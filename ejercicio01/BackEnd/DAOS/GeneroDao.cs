using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;
using BackEnd.util;

namespace BackEnd.DAOS
{
    public class GeneroDao
    {
        public List<Genero> getAll()
        {
            List<Genero> Lista = BDDUMMY.ListaGenero;
            return Lista;
        }

        public void add(Genero m)
        {
            List<Genero> Lista = BDDUMMY.ListaGenero;
            Lista.Add(m);
        }
    }
}
