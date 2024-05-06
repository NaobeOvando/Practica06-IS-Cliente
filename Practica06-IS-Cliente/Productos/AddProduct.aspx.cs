using Newtonsoft.Json;
using Practica06_IS_Cliente.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica06_IS_Cliente.Productos
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text!=""&& TxtPrecio.Text != "" && TxtIdCategoria.Text != "")
            {
                Product product = new Product();    
                product.nombre= TxtNombre.Text;
                product.precio_unitario= (decimal)double.Parse(TxtPrecio.Text);
                product.idCategoria=int.Parse(TxtIdCategoria.Text);
                if (RadioButtonIva.Checked)
                    product.iva = true;
                else product.iva=false;

                string url = "http://localhost:59274/api/productos";
                string verb = "POST";
                WebClient webClient = new WebClient();  

                string JsonDatos= JsonConvert.SerializeObject(product); 
                UTF8Encoding uTF8Encoding = new UTF8Encoding();
                Byte[] bytes = uTF8Encoding.GetBytes(JsonDatos);

                webClient.Headers.Add("content-type", "application/json");
                webClient.UploadData(url, verb, bytes);
            }
        }
    }
}