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
        int _idTipoPuesto;
        int _idPersonal;
        string _correo;
        string _contrasena;

        public int Id { get => _id; set => _id = value; }
        public int IdTipoPuesto { get => _idTipoPuesto; set => _idTipoPuesto = value; }
        public int IdPersonal { get => _idPersonal; set => _idPersonal = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
    }
}
