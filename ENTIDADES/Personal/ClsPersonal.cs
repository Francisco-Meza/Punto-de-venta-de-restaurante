using System;
using System.Data;

namespace ENTIDADES.Personal
{
    public class ClsPersonal
    {
        #region Atributos privados 

        private byte _idPersonal;
        private string _nombrePersona, _apelMat, _apelPat;
        private DateTime _fechaNacimiento;

        //atributos de manejo de la base de datos
        private string _mensajeError, _valorScalar;
        private DataTable _DtResultados;


        #endregion

        #region Atributos publicos 

        public byte IdPersonal { get => _idPersonal; set => _idPersonal = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string ApelMat { get => _apelMat; set => _apelMat = value; }
        public string ApelPat { get => _apelPat; set => _apelPat = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _DtResultados; set => _DtResultados = value; }


        #endregion
    }
}
