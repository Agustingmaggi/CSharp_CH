using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Producto
    {
{
    private int _id;
        private string _descripcion;
        private decimal _costo;
        private decimal _precioVenta;
        private int _stock;
        private int _idUsuario;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public decimal Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public decimal PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
    }
}
}