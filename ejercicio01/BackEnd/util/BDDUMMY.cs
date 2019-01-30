using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Modelo;

namespace BackEnd.util
{
    public class BDDUMMY
    {
        public static List<Musico> ListaMusico = new List<Musico>();
        public static List<MusicosGrupos> ListaMusicosGrupos = new List<MusicosGrupos>();
        public static List<Grupo> ListaGrupo = new List<Grupo>();
        public static List<GenerosGrupos> ListaGenerosGrupos = new List<GenerosGrupos>();
        public static List<Genero> ListaGenero = new List<Genero>();
        
        static BDDUMMY()
        {
            ListaMusico.Add(new Musico()
            {
                Idmusico = 1,
                Nombre = "juan",
                Instrumento = "bateria",
                Lugarnacimiento = "uriangato",
                Fechanacimiento = DateTime.Parse("12-18-1989"),
                Fechamuerte = DateTime.Parse("10-12-2017")
            });

            ListaMusicosGrupos.Add(new MusicosGrupos()
            {
                Idgrupo= 1,
                Idmusico = 1,                
                Instrumento = "bateria",
                Fechainicio = DateTime.Parse("12-18-1989"),
                Fechafin = DateTime.Parse("10-12-2017")
            });

            ListaGrupo.Add(new Grupo()
            {
                Idgrupo = 1,
                Nombre = "jesus",
                Formacion = DateTime.Parse("12-18-1989"),
                Desintegracion = DateTime.Parse("10-12-2017")
            });

            ListaGenerosGrupos.Add(new GenerosGrupos()
            {
                Idgrupo = 1,
                Idgenero = 1
            });

            ListaGenero.Add(new Genero()
            {               
                Idgenero = 1,
                Descripcion = "banda"
            });
        }
    }
}
