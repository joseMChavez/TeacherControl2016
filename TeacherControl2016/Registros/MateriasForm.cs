﻿using System;
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
   
    public partial class MateriasForm : Form
    {
        public MateriasForm()
        {
            InitializeComponent();
            DesactivarMenuContextual();
        }
        Materias materia = new Materias();

    private void LlenarDatos()
    {
        int id = Utility.ConvierteEntero(MateriaIdtextBox.Text);
            materia.MateriaId = id;
            materia.Descripcion = DescripcionTextBox.Text;

    }
    private void DesactivarMenuContextual()
    {
        var blankContextMenu = new ContextMenu();

        foreach (Control control in this.Controls)
        {
            control.ContextMenu = blankContextMenu;
        }
    }
    private void Limpiar()
    {
        MateriaIdtextBox.Clear();
        DescripcionTextBox.Clear();
        MateriasErrorProvider.Clear();
        DescripcionTextBox.Focus();
    }


    public void ActivarBotones(bool btn)
    {
        GuardarButton.Enabled = btn;
        EliminarButton.Enabled = btn;
    }
    private bool ValidarTodo()
    {
        if (DescripcionTextBox.Text.Equals(""))
        {
            MateriasErrorProvider.SetError(DescripcionTextBox, "Digite el Nombre \n o\n Descripcion de La Nueva Materia.");
            DescripcionTextBox.Focus();
            return true;
        }
        else
        {
            MateriasErrorProvider.Clear();
            return false;
        }
    }
    private bool Validar(TextBox tb, string mensaje)
    {

        if (tb.Text.Equals(""))
        {
            MateriasErrorProvider.SetError(tb, mensaje);
          
            tb.Focus();
            return true;

            }
        else
        {
                MateriasErrorProvider.Clear();
                return false;

            }
    }
    private void MateriaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            if (e.KeyChar == 13)
            {
                DescripcionTextBox.Focus();
            }
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
            {
                MateriaIdtextBox.Focus();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utility.ConvierteEntero(MateriaIdtextBox.Text);
            try
            {
                
                if (Validar(MateriaIdtextBox, "Digite un Id") == false && materia.Buscar(id) )
                {
                    MateriaIdtextBox.Text = materia.MateriaId.ToString();
                    DescripcionTextBox.Text = materia.Descripcion;
                    ActivarBotones(true);
                }
                else
                {
                    Utility.Mensajes(3, "Id No Encontrado!");
                    Limpiar();
                    ActivarBotones(false);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDatos();
                if (MateriaIdtextBox.Text.Equals(""))
                {
                    if (ValidarTodo() == false && materia.BuscarDescripcion(DescripcionTextBox.Text))
                    {
                        Utility.Mensajes(3, "La Materia " + DescripcionTextBox.Text + " Ya Existe!");
                        Limpiar();

                    }
                    else
                    {
                        if (materia.Insertar())
                        {
                            Utility.Mensajes(1, "La Materia " + DescripcionTextBox.Text + "Fue Guardada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(3, "La Materia " + DescripcionTextBox.Text + " No Fue Guardada!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    if(ValidarTodo() == false &&  materia.BuscarDescripcion(DescripcionTextBox.Text))
                    {
                        Utility.Mensajes(3, "La Materia " + DescripcionTextBox.Text + " Ya Existe!");
                        Limpiar();

                    }
                    else
                    {
                        if (materia.Editar())
                        {
                            Utility.Mensajes(1, "La Materia " + DescripcionTextBox.Text + " Fue Modificada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(3, "La Materia " + DescripcionTextBox.Text + " No Fue Modificada!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            int id = Utility.ConvierteEntero(MateriaIdtextBox.Text);
            try
            {

                if (Validar(MateriaIdtextBox, "Digite un Id") == false && materia.Buscar(id))
                {
                    resultado = MessageBox.Show("¿Estas seguro(a) de Eliminal La Materia" + DescripcionTextBox.Text + " ?", "Teacher Control", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        if (materia.Eliminar())
                        {
                            Utility.Mensajes(1, "La Materia" + DescripcionTextBox.Text + " Fue Eliminada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);

                        }
                        else
                        {
                            Utility.Mensajes(2, "La Materia" + DescripcionTextBox.Text + "No Pudo Ser Eliminada!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    else
                    {
                        Limpiar();
                    }
                   
                }
                else
                {
                    Utility.Mensajes(3, "Id No Encontrado!");
                    Limpiar();
                    ActivarBotones(false);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
