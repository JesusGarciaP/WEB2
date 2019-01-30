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
    public partial class GenerosGrupoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            GenerosGrupos m = new GenerosGrupos();
            GenerosGruposDao dao = new GenerosGruposDao();


            m.Idgrupo = int.Parse(txtIdGrupo.Text);
            m.Idgenero = int.Parse(txtIdGenero.Text);

        }
    }
}