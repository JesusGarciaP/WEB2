using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.DAOS
{
    public class MusicoDao
    {
        public List<Musico> getAll()
        {
            List<Musico> lista;
            lista = new List<Musico>();
            lista.Add(new Musico()
            {
                Nombre = "JUAN",
                Idmusico = 1,
                Instrumento = "GUITARRA"
            });
            return lista;
        }
    }
}
