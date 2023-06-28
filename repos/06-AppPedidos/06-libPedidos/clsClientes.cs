using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_libPedidos
{
    public class clsClientes : clsPersonas //Hereda de la clase clsPersonas
    {
        #region Propiedades
        public int dni { get; set; }
        public int idCliente { 
            get { return IdPersona;}
            set { IdPersona = value; }
        }
        #endregion

        #region Constructor
        #endregion

        #region Métodos
        public override string ToString()
        {
            string cadena = $"idCliente = {idCliente.ToString()}, Nombre: {Nombre}, Apellido: {Apellido}, DNI: {dni}.";

            return cadena;
        }
        #endregion
    }
}
