using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_libPedidos
{
    public class clsPersonas
    {
        #region Propiedades
        private int _idPersona;
        private string _nombre;
        private string _apellido;

        protected int IdPersona {
            get => _idPersona;
            set => _idPersona = value;
        }
        public string Nombre {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido { 
            get => _apellido; 
            set => _apellido = value; 
        }
        #endregion

        #region Constructor
        public clsPersonas() //El constructor debe ser público y llevar el mismo nombre que la clase.
            {
            _idPersona = 0;
            _nombre = String.Empty; 
            _apellido = String.Empty;
            }
        #endregion

        #region Métodos
        #endregion
    }
}
