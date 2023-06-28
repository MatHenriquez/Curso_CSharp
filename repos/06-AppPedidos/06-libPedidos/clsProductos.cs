using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_libPedidos
{
    public class clsProductos
    {
        #region Propiedades
        public int idProducto { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        #endregion

        #region Constructor
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Id del producto: {idProducto.ToString()} || " +
                $"Descripción: {Description} || " +
                $"Código de Barras: {BarCode} || ";
        }
        #endregion
    }
}
