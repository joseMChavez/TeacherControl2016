using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherControl2016.Registros
{
    public partial class CursosForm : Form
    {
        public CursosForm()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            CursosIdtextBox.Clear();
            DescripcionTextBox.Clear();
        }
        //1 Informacion...2 Error....3 Cuidado.
        private void Mensajes(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }

        private bool Validar(TextBox tb, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                CursosErrorProvider.SetError(tb, mensaje);
                tb.Focus();
                return true;
            }
            else
            {
                CursosErrorProvider.Clear();
                return false;
            }
        }

        private void TextBoxNuemericos(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


        }

        private void TextboxAlfaNumerico(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
