using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsCuenta
    {
        private string _nombrePersona;
        private string _apelPat;
        private string _apelMat;
        private DateTime _fechaNacimiento;
        private int _idPuesto;
        private string _correo;
        private string _clave;

        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string ApelPat { get => _apelPat; set => _apelPat = value; }
        public string ApelMat { get => _apelMat; set => _apelMat = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public int IdPuesto { get => _idPuesto; set => _idPuesto = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Clave { get => _clave; set => _clave = value; }
    }
}
