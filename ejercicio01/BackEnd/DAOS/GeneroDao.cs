using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.DAOS
{
    public class GeneroDao
    {
        public List<Genero> getAll()
        {
            List<Genero> lista;
            lista = new List<Genero>();
            lista.Add(new Genero()
            {
                Idgenero = 1,
                Descripcion = "descripcion"
            });
            return lista;
        }
    }
}
