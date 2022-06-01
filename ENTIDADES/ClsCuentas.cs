using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsCuentas
    {
        int _id;        
        string _correo;
        string _contrasena;
        int _idTipoPuesto;
        int _idPersonal;
        string _nombrePersona;
        string _apelPat;
        string _apelMat;
        DateTime _fechaNacimiento;
        string telefono;

        public int Id { get => _id; set => _id = value; }                
        public string Correo { get => _correo; set => _correo = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public int IdTipoPuesto { get => _idTipoPuesto; set => _idTipoPuesto = value; }
        public int IdPersonal { get => _idPersonal; set => _idPersonal = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string ApelPat { get => _apelPat; set => _apelPat = value; }
        public string ApelMat { get => _apelMat; set => _apelMat = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
