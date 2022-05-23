using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ClsPersonal
    {
      
        private int _id;
        private string _nombrePersona, _apelPat, _apelMat;
        private DateTime _fechaNacimiento;
        

        
        public int Id { get => _id; set => _id = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string ApelPat { get => _apelPat; set => _apelPat = value; }
        public string ApelMat { get => _apelMat; set => _apelMat = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        
    }
}
