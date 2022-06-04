using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dapper;

namespace DapperApp
{
    public partial class CrearCliente : System.Web.UI.Page
    {
        string strConexion = "Data Source =192.168.1.23; Initial Catalog =Tienda; User ID =cbeltran; Password=root";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void crear(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text;
            string nomb = txtNombre.Text;
            string direc = txtDireccion.Text;
            string tel = txtTelefono.Text;

            using (var db = new SqlConnection(strConexion))
            {
                var sqlInsert = "Insert into Cliente(NroDocumento,Nombre,Direccion,Telefono) Values(@documento,@nombre,@direccion,@telefono)";
                var result = db.Execute(sqlInsert, new
                {
                    documento = doc.ToString(),
                    nombre = nomb.ToString(),
                    direccion = direc.ToString(),
                    telefono = tel.ToString()
                });
               
                    var script = "alert('Cliente registrado');" +
                        "window.location='Clientes.aspx'";
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "mensaje", script, true);                         
            }


        }
    }
}
    
    
