using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DapperApp
{
    public partial class ActualizarCliente : System.Web.UI.Page
    {
        string strConexion = "Data Source =192.168.1.23; Initial Catalog =Tienda; User ID =cbeltran; Password=root";
        string idCli = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            idCli = Request.QueryString["IdCliente"];
            if (string.IsNullOrEmpty(idCli))
            {
                Response.Redirect("Clientes.aspx");
            }

            if (!Page.IsPostBack)
            {
                cargarDatos();
            }
        }

        void cargarDatos()
        {
            using (var db = new SqlConnection(strConexion))
            {
                
                idCli = Request.QueryString["IdCliente"];

                var sql = "Select * from Cliente where IdCliente = @id";
                var lista = db.Query<ClassCliente>(sql,new { id = idCli });
                

                foreach (var oelement in lista)
                {
                    txtDocumento.Text = oelement.NroDocumento;
                    txtNombre.Text=oelement.Nombre;
                    txtDireccion.Text = oelement.Direccion;
                    txtTelefono.Text=oelement.Telefono;
                    
                }
            }

        }

        protected void actualizar(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text;
            string nomb = txtNombre.Text;
            string direc = txtDireccion.Text;
            string tel = txtTelefono.Text;
            idCli = Request.QueryString["IdCliente"];



            using (var db = new SqlConnection(strConexion))
            {
                var sqlEdit = "update Cliente SET NroDocumento=@pDocumento,Nombre=@pNombre,Direccion=@pDireccion,Telefono=@pTelefono Where IdCliente=@pId";
                var result = db.Execute(sqlEdit, new
                {
                    pDocumento = doc.ToString(),
                    pNombre = nomb.ToString(),
                    pDireccion = direc.ToString(),
                    pTelefono = tel.ToString(),
                    pId=idCli
                });

                var script = "alert('Cliente Actualizado');" +
                    "window.location='Clientes.aspx'";
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "mensaje", script, true);
            }


        }
    }
}