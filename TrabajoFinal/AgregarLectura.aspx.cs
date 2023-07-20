using MedidoresModel.DAL;
using MedidoresModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class AgregarLectura : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        private ILecturasDAL lecturasDAL = new LecturasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorDDL.DataSource = this.medidoresDAL.ObtenerMedidores();
                this.medidorDDL.DataTextField = "Ndserie";
                this.medidorDDL.DataTextField = "Tipomedidor";
                this.medidorDDL.DataValueField = "Id";
                this.medidorDDL.DataBind();
            }

        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Lectura lectura = new Lectura();
            lectura.Fecha = Convert.ToDateTime(this.calendarTXT.SelectedDate);
            lectura.Hora = this.horaTXT.Text.Trim();
            lectura.Minuto = this.minutoTXT.Text.Trim();
            lectura.Valorconsumo = this.valorConsumotxt.Text.Trim();
            lectura.IdMedidor = Convert.ToInt32(this.medidorDDL.SelectedItem.Value);

            this.lecturasDAL.AgregarLectura(lectura);
            Response.Redirect("MostrarLectura.aspx");
        }
    }
}