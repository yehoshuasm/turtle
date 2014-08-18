using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace turtle.Utils
{
    public class Validator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <param name="pattern"></param>
        /// <param name="emptyAllowed">Cadena vacía permitida</param>
        /// <returns></returns>
        private static bool IsMatch(string value, string pattern, bool emptyAllowed)
        {
            return emptyAllowed && value == "" ? true : Regex.IsMatch(value, pattern);
        }

        #region StringValidations
        
        /// <summary>
        /// Revisa si una cadena contiene sólo caracteres alfabéticos
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <param name="emptyAllowed">Cadena vacía permitida</param>
        /// <returns>Verdadero si la cadena contiene solo caracteres alfabéticos</returns>
        public static bool IsAlphabetic(string value, bool emptyAllowed)
        {
            return IsMatch(value, @"^[a-zA-Z ]+$", emptyAllowed);
        }

        /// <summary>
        /// Revisa si una cadena contiene sólo caracteres alfanuméricos
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <param name="emptyAllowed">Cadena vacía permitida</param>
        /// <returns></returns>
        public static bool IsAlphanumeric(string value, bool emptyAllowed)
        {
            return IsMatch(value, @"^[a-zA-Z0-9 ]+$", emptyAllowed);
        }

        /// <summary>
        /// Revisa si una cadena es un RFC válido
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <param name="emptyAllowed">Cadena vacía permitida</param>
        /// <returns>Verdadero si la cadena es un RFC</returns>
        public static bool IsRfc(string value, bool emptyAllowed)
        {
            string rfc = @"[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?";
            return IsMatch(value, rfc, emptyAllowed);
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
        /// <param name="emptyAllowed">Cadena vacía permitida</param>
        /// <returns>Verdadero si la cadena es un número entero</returns>
        public static bool IsInteger(string value, bool emptyAllowed)
        {
            return IsMatch(value, @"^[0-9]+$", emptyAllowed);
        }

        /// <summary>
        /// Revisa si una cadena es un número decimal
        /// </summary>
        /// <param name="value">Cadena a validar</param>
        /// <param name="emptyAllowed">Cadena vacía permitida</param>
        /// <returns>Verdadero si la cadena es un número decimal</returns>
        public static bool IsDecimal(string value, bool emptyAllowed)
        {
            return IsMatch(value, @"^[0-9]+(\.[0-9]{1,2})?$", emptyAllowed);
        }

        #endregion

        public static bool Validate(Dictionary<Control, bool> controlsValidations)
        {
            var notValidControls = controlsValidations.Where(v => !v.Value).ToList();
            SetNotValidColor(notValidControls.Select(v => v.Key).ToList());
            return notValidControls.Count == 0; // Si no hay elementos no válidos regresa verdadero
        }

        private static void SetNotValidColor(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.BackColor = Color.FromArgb(252, 144, 144);
            }
        }
    }
}