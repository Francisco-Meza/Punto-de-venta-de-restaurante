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
        string _nombrePuesto;
        string _descripcion;

        int _idPersonal;
        string _nombrePersona;
        string _apelPat;
        string _apelMat;
        DateTime _fechaNacimiento;

        public int Id { get => _id; set => _id = value; }                
        public string Correo { get => _correo; set => _correo = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public int IdTipoPuesto { get => _idTipoPuesto; set => _idTipoPuesto = value; }
        public string NombrePuesto { get => _nombrePuesto; set => _nombrePuesto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int IdPersonal { get => _idPersonal; set => _idPersonal = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string ApelPat { get => _apelPat; set => _apelPat = value; }
        public string ApelMat { get => _apelMat; set => _apelMat = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
    }
}
