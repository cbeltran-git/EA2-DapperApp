using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace DapperApp
{
    public partial class Clientes : System.Web.UI.Page
    {
        string strConexion = "Data Source =192.168.1.23; Initial Catalog =Tienda; User ID =cbeltran; Password=root";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        void cargarDatos()
        {
            using (var db= new SqlConnection(strConexion))
            {
             
                var sql = "Select * from Cliente";
                var lista = db.Query<ClassCliente>(sql);
                                   
                    gvDatos.DataSource = lista;
                    gvDatos.DataBind();                                              
            }
          
        }
    }
}