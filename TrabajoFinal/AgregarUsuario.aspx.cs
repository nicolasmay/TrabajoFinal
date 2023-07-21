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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Rut = this.rutTXT.Text.Trim();
            usuario.Nombre = this.nombreTXT.Text.Trim();
            usuario.Correo = this.CorreoTXT.Text.Trim();
            usuario.Contrasena = this.contrasenaTXT.Text.Trim();

            this.usuariosDAL.AgregarUsuario(usuario);
            Response.Redirect("MostrarUsuario.aspx");
        }
    }
}