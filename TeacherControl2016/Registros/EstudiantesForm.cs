using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TeacherControl2016.Registros
{
    public partial class EstudiantesForm : Form
    {
        public EstudiantesForm()
        {
            InitializeComponent();
        }


      private void Limpiar()
        {
            EstudianteIdtextBox.Clear();
            MatriculatextBox.Clear();
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            MasculinoRadioButton.Checked = false;
            FemeninoradioButton.Checked = false;
            FechaDateTimePicker.Value = new DateTime(000, 00, 00);
            TelefonoMaskedTextBox.Mask = "###-###-####";
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
            //CursocomboBox.SelectedIndex = 0;
            GrupocomboBox.SelectedIndex = 0;
            NombrePadretextBox.Clear();
            TelefonoPmaskedTextBox.Mask = "###-###-####";
        }
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
    }
}
