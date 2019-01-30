using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BackEnd.Modelo;
using BackEnd.DAOS;
using BackEnd.util;

namespace ejercicio01
{
    public partial class MusicosGruposForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            MusicosGrupos m = new MusicosGrupos();
            MusicosGruposDao dao = new MusicosGruposDao();

            m.Idmusico = int.Parse(txtIdMusico.Text);
            m.Idgrupo = int.Parse(txtIdGrupo.Text);
            m.Instrumento = txtInstrumento.Text;           
            m.Fechainicio = clnFechaInicio.SelectedDate;
            m.Fechafin = clnFechaFin.SelectedDate;
        }
    }
}