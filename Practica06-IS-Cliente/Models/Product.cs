using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica06_IS_Cliente.Models
{
    public class Product
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public decimal precio_unitario { get; set; }
        public bool iva { get; set;}
        public int idCategoria { get; set; }

        public Product()
        {

        }

        public Product(int idProducto, string nombre, decimal precio_unitario, bool iva, int idCategoria)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio_unitario = precio_unitario;
            this.iva = iva;
            this.idCategoria = idCategoria;
        }
    }
 
    }
