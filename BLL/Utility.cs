﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Controls;

namespace BLL
{
    public static class Utility
    {
        
        // Regex esta función permite mediante un patrón verificar si una cadena cumple con ese patrón 
        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            if (!Regex.Match(sEmailAComprobar, @"\A(\w+\.?\w*\@\w+.)(com)\z").Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Este metodo es para Validar los Textbox
        //1 Informacion...2 Error....3 Cuidado.
        public static void Mensajes(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "Teacher Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "Teacher Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "Teacher Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }
        public static int ConvierteEntero(string s)
        {
            int id = 0;
            int.TryParse(s, out id);
            return id;
        }

        // Estos metodos reciven un evento cuando se presiona una tecla en el textbox para Validarlos
        public static void TextBoxNuemericos(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


        }

        public static void TextboxAlfaNumerico(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public static void TextBoxEspecial(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 44 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 33) || (e.KeyChar == 95) || (e.KeyChar >= 63 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        public static void TextBoxSoloTexto(KeyPressEventArgs e) {
            if ( (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 33) || (e.KeyChar == 95) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165) || (e.KeyChar >= 129 && e.KeyChar <= 130) )
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void Validar(Control tb,ErrorProvider e, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                e.SetError(tb, mensaje);
                tb.Focus();

            }
            else
            {
                e.Clear();

            }
        }
    }
}
