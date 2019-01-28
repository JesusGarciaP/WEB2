using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.DAOS
{
    public class GrupoDao
    {
        public List<Grupo> getAll()
        {
            List<Grupo> lista;
            lista = new List<Grupo>();
            lista.Add(new Grupo()
            {
                Idgrupo = 1,
                Nombre = "Jesus",
                Formacion = "formacion"
            });
            return lista;
        }
    }
}
