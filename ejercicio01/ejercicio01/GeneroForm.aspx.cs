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
    public partial class GeneroForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Genero m = new Genero();
            GeneroDao dao = new GeneroDao();


            m.Idgenero = int.Parse(txtIdGenero.Text);
            m.Descripcion = txtDescripcion.Text;
        }
    }
}