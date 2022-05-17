using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace LOGICA_DE_NEGOCIOS
{
    public class Validaciones
    {
        public static bool VerificarCorreo(string correo)
        {
            try
            {
                new System.Net.Mail.MailAddress(correo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool VerificarTelefono(string telefono)
        {
            Regex rgx = new Regex(@"^\d{3}(-\d{3})(-\d{4})$");
            return rgx.IsMatch(telefono);
        }

        public static bool VerificarContrasena(string contrasena)
        {
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            //si no contiene las letras, regresa false
            if (!letras.IsMatch(contrasena))
            {
                return false;
            }
            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(contrasena))
            {
                return false;
            }

            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(contrasena))
            {
                return false;
            }

            //si cumple con todo, regresa true
            return true;
        }
        public static bool WithForCompareAsciiValue(string stringToVerify)
        {
            for (int i = 0; i < stringToVerify.Length; i++)
            {
                //A=65 Z=90 and a=97 z=122
                if ((int)stringToVerify[i] < 65 || ((int)stringToVerify[i] > 90
                    && (int)stringToVerify[i] < 97) || (int)stringToVerify[i] > 122)
                    return false;
            }
            return true;
        }
        public static bool SoloNumero(string cadena)
        {
            return cadena.All(char.IsDigit);
        }
    }
}
