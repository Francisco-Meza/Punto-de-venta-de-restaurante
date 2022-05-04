using System.Data;

namespace ACCESO_A_DATOS
{//
    public class ClsParametros
    {
        #region Variables privadas
        private string _nombre;
        private object _valor;
        private SqlDbType _tipoDato;
        private int _tamanio;
        private ParameterDirection _direccion;
        #endregion

        #region Variable publicas
        public string Nombre { get => _nombre; set => _nombre = value; }
        public object Valor { get => _valor; set => _valor = value; }
        public SqlDbType TipoDato { get => _tipoDato; set => _tipoDato = value; }
        public int Tamanio { get => _tamanio; set => _tamanio = value; }
        public ParameterDirection Direccion { get => _direccion; set => _direccion = value; }
        #endregion

        #region Constructores
        public ClsParametros(string nombre, object valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
            Direccion = ParameterDirection.Input;
        }

        public ClsParametros(string nombre, SqlDbType tipo, int tamanio)
        {
            this.Nombre = nombre;
            this.TipoDato = tipo;
            this.Tamanio = tamanio;
            Direccion = ParameterDirection.Output;
        }
        #endregion
    }
}
