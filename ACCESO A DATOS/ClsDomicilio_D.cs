using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ACCESO_A_DATOS
{
    public class ClsDomicilio_D
    {
        private string _calle, _colonia, _localidad;
        private int _id, _numeroCasa;
        //Atributos
        

        ClsDataBase M = new ClsDataBase(Constantes.david);

        public int Id { get => _id; set => _id = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public string Colonia { get => _colonia; set => _colonia = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public int NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }

       



    }
}
