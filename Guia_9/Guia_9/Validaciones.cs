using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validacion
{
    /// <summary>
    /// Clase para validar entradas de textos
    /// </summary>
    public static class Validaciones
    {
        /// <summary>
        /// Permite ingresar solo los caracteres que son letras.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static void Letras(ref KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite ingresar solo los caracteres que son letras.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static void LetrasNumeros(ref KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// No Permite ingresar los caracteres que son simbolos.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static void Simbolos(ref KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite ingresar caracteres de espacios o borrado
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static void EspaciosBorrar(ref KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// Permite ingresar caracteres de espacios o borrado
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static void Borrar(ref KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        /// <summary>
        ///No deja ingresar un espacio al principio ni dos espacios seguidos. A menos que volvamos a los espacios anteriores y volvamos a querer ingresar espacios
        /// </summary>
        /// <param name="e">refiere al objeto</param>
        /// <param name="len"></param>
        public static void EspPrincipio(ref KeyPressEventArgs e, string len)
        {
            if ((e.KeyChar == 32 && len.Length == 0) || (e.KeyChar == 32 && e.KeyChar == len[len.Length - 1]))
            {
                e.Handled = true;
            }
        }
		
        /// <summary>
        /// Permite ingresar solo caracteres que son numeros.
        /// </summary>
        /// <param name="e"></param>
		public static void Numeros(ref KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
