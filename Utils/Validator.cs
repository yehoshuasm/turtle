using System;
using System.Text.RegularExpressions;

namespace turtle.Utils
{

    public class Validator
    {

        #region StringValidations
        
        /// <summary>
        /// Revisa si una cadena contiene sólo caracteres alfabéticos
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <returns>Verdadero si la cadena contiene solo caracteres alfabéticos</returns>
        public static bool IsAlphabetic(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
        }

        /// <summary>
        /// Revisa si una cadena contiene sólo caracteres alfanuméricos
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsAlphanumeric(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
        }

        /// <summary>
        /// Revisa si una cadena es un RFC válido
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <returns>Verdadero si la cadena es un RFC</returns>
        public static bool IsRfc(string value)
        {
            string rfc = @"[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?";
            return Regex.IsMatch(value, rfc);
        }

        /// <summary>
        /// Revisa si una cadena es un correo electrónico
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <returns>Verdadero si la cadena es un correo electrónico</returns>
        public static bool IsEmail(String value)
        {
            string email = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";

            if (Convert.ToInt32(Utils.CounterEmails.countEmails(value))>1)
            {
                String [] emails=value.Split(',');
                for (int i = 0; i < emails.Length; i++)
                {
                    if(!Regex.IsMatch(emails[i],email))
                    {
                        return false;
                    }
                }
                return true;
            }
                       
            return Regex.IsMatch(value, email);
        }
        
        #endregion

        #region NumericValidations
        /// <summary>
        /// Revisa si una cadena es un número entero
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <returns>Verdadero si la cadena es un número entero</returns>
        public static bool IsInteger(string value)
        {
            return Regex.IsMatch(value, @"^[0-9]+$");
        }

        /// <summary>
        /// Revisa si una cadena es un número decimal
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <returns>Verdadero si la cadena es un número decimal</returns>
        public static bool IsDecimal(string value)
        {
            return Regex.IsMatch(value, @"^[0-9]+(\.[0-9]{1,2})?$");
        }

        #endregion

    }

}