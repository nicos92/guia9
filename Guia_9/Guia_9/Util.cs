using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_9
{
    public static class Util
    {
        public static void HabilitarBtn(out bool nom, out bool ape, out bool dni, out bool tel, out bool tel2, out bool dire, Button btn, List<TextBox> Txt )
        {
            nom = Txt[0].Text.Length > 2;
            ape = Txt[1].Text.Length > 2;
            dni = Txt[2].Text.Length == 8;
            tel = Txt[3].Text.Length > 7;
            tel2 = Txt[4].Text.Length > 7;
            dire = Txt[5].Text.Length > 3;
            btn.Enabled = nom && ape && dni && tel && tel2 && dire;
        }

        public static void SacarDobleEspacio(TextBox txt)
        {
            if (Regex.IsMatch(txt.Text, @"\s{2,}"))
            {

                int cursor = txt.SelectionStart;
                txt.Text = Regex.Replace(txt.Text, @"\s{2,}", " ");
                txt.SelectionStart = cursor - 1;
            }
        }
    }
}
