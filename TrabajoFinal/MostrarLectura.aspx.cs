using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class MostrarLectura : System.Web.UI.Page
    {

        private ILecturasDAL lecturasDAL = new LecturasDALDB();

        private void cargarGrilla(List<Lectura> lecturas)
        {
            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla(this.lecturasDAL.ObtenerLecturas());
            }
        }
    }
}