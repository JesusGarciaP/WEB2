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
    public partial class MusicoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Musico m = new Musico();
            MusicoDao dao = new MusicoDao();

            m.Idmusico = int.Parse(txtid.Text);
            m.Nombre = txtnombre.Text;
            m.Instrumento = txtInstrumento.Text;
            m.Lugarnacimiento = txtLugarNacimiento.Text;
            m.Fechanacimiento = clnFechaNacimiento.SelectedDate;
            m.Fechamuerte = clnFechaMuerte.SelectedDate;
        }
    }
}