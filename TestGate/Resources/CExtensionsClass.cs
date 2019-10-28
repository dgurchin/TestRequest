using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGate
{
    public static class CExtensionsClass
    {

        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public static int ToInt(this string s)
        {
            return string.IsNullOrEmpty(s) ? 0 : Convert.ToInt32(s);
        }

        public static double ToDouble(this string s)
        {
            return string.IsNullOrEmpty(s) ? 0 : Convert.ToDouble(s);
        }

        public static double ToDouble(this decimal s)
        {
            return Convert.ToDouble(s);
        }

        public static decimal ToDecimal(this string s)
        {
            return string.IsNullOrEmpty(s) ? 0 : Convert.ToDecimal(s);
        }

        public static decimal ToDecimal(this double s)
        {
            return Convert.ToDecimal(s);
        }

        public static int ToInt(this object o)
        {


            return Convert.ToInt32(o);
        }

        public static int ToInt(this decimal o)
        {


            return Convert.ToInt32(o);
        }

        public static Int16 ToInt16(this decimal o)
        {


            return Convert.ToInt16(o);
        }
    }
}
