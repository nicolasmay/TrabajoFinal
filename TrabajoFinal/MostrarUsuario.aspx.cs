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
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL=new UsuariosDALDB();

        private void cargarGrilla(List<Usuario> usuarios)
        {
            this.grillaLectura.DataSource = usuarios;
            this.grillaLectura.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.cargarGrilla(this.usuariosDAL.ObtenerUsuarios());
            }

        }
    }
}