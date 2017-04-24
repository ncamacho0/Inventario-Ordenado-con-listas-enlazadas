using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        private int _codigo;
        public int codigo { get { return _codigo; }  }
        private string _nombre;
        public string nombre { get {return _nombre; }  }
        private int _cantidad;
        public int cantidad { get { return _cantidad; } }
        private int _costo;
        public int costo { get { return _costo; } }
        public Producto siguiente;

        public Producto(int codigo,string nombre,int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
            siguiente = null;
        }

        public override string ToString()
        {
            return codigo + Environment.NewLine + nombre + Environment.NewLine + cantidad + Environment.NewLine + costo;
        }
    }
}
