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
    public partial class GrupoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Grupo m = new Grupo();
            GrupoDao dao = new GrupoDao();

            
            m.Idgrupo = int.Parse(txtIdGrupo.Text);
            m.Nombre = txtNombre.Text;
            m.Formacion = clnFormacion.SelectedDate;
            m.Desintegracion = clnDesintegracion.SelectedDate;
        }
    }
}