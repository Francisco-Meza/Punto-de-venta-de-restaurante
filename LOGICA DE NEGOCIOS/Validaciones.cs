using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace LOGICA_DE_NEGOCIO
{
    public class Validaciones
    {
        public bool VerificarCorreo(string correo)
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

        public bool VerificarTelefono(string telefono)
        {
            Regex rgx = new Regex(@"^\d{3}(-\d{3})(-\d{4})$");
            return rgx.IsMatch(telefono);
        }

        public bool VerificarContrasena(string contrasena)
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
    }
}
