using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.DAOS
{
    public class MusicosGruposDao
    {
        public List<MusicosGrupos> getAll()
        {
            List<MusicosGrupos> lista;
            lista = new List<MusicosGrupos>();
            lista.Add(new MusicosGrupos()
            {
                Idgrupo = 1,
                Idmusico = 1,
                Instrumento = "GUITARRA"
            });
            return lista;
        }
    }
}
