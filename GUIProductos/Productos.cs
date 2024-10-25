using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIProductos
{
    public class Productos
    {
        private int codigo;
        private string nombre;
        private double valor;
        private int cantidad;
        private int codCategoria;

        public Productos(int codigo, string nombre, double valor, int cantidad, int codCategoria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.valor = valor;
            this.cantidad = cantidad;
            this.codCategoria = codCategoria;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int CodCategoria { get => codCategoria; set => codCategoria = value; }
    }
}
