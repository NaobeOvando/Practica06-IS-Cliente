using Newtonsoft.Json;
using Practica06_IS_Cliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// NOMBRE APELLIDOS: Naobe Ovando
// PARALELO: 1
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 5-5-2024
// PRÁCTICA No. #


namespace Practica06_IS_Cliente.Productos
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string url = "http://localhost:59274/api/productos";
            WebClient webClient = new WebClient();
            string getDatos = webClient.DownloadString(new Uri(url));
            List <Product>lista=JsonConvert.DeserializeObject<List<Product>>(getDatos);
            GridViewProductos.DataSource = lista;
            GridViewProductos.DataBind();
        }

       
    }
}