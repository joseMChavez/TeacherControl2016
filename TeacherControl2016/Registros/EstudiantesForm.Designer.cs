namespace TeacherControl2016.Registros
{
    partial class EstudiantesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudiantesForm));
            this.EstudianteIdtextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Generolabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MatriculaLavel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MatriculatextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.ApellidostextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MasculinoRadioButton = new System.Windows.Forms.RadioButton();
            this.FemeninoradioButton = new System.Windows.Forms.RadioButton();
            this.Cursolabel = new System.Windows.Forms.Label();
            this.CursocomboBox = new System.Windows.Forms.ComboBox();
            this.GrupocomboBox = new System.Windows.Forms.ComboBox();
            this.Grupolabel = new System.Windows.Forms.Label();
            this.NombrePadretextBox = new System.Windows.Forms.TextBox();
            this.TelefonoPmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EstudianteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Edadlabel = new System.Windows.Forms.Label();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudianteIdtextBox
            // 
            this.EstudianteIdtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EstudianteIdtextBox.Location = new System.Drawing.Point(175, 68);
            this.EstudianteIdtextBox.Name = "EstudianteIdtextBox";
            this.EstudianteIdtextBox.Size = new System.Drawing.Size(84, 20);
            this.EstudianteIdtextBox.TabIndex = 16;
            this.EstudianteIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstudianteIdtextBox_KeyPress);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdLabel.Location = new System.Drawing.Point(58, 69);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 16);
            this.IdLabel.TabIndex = 12;
            this.IdLabel.Text = "Id:";
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BuscarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BuscarButton.Image = global::TeacherControl2016.Properties.Resources._1453541260_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(282, 44);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 64);
            this.BuscarButton.TabIndex = 17;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.GuardarButton.FlatAppearance.BorderSize = 0;
            this.GuardarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GuardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GuardarButton.Image = global::TeacherControl2016.Properties.Resources._1453541193_save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(353, 358);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 64);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.EliminarButton.FlatAppearance.BorderSize = 0;
            this.EliminarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EliminarButton.Image = global::TeacherControl2016.Properties.Resources._1452899178_trash;
            this.EliminarButton.Location = new System.Drawing.Point(534, 360);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 60);
            this.EliminarButton.TabIndex = 14;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.NuevoButton.FlatAppearance.BorderSize = 0;
            this.NuevoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NuevoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NuevoButton.Image = global::TeacherControl2016.Properties.Resources._1452825521_Add;
            this.NuevoButton.Location = new System.Drawing.Point(176, 362);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 60);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nombrelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombrelabel.Location = new System.Drawing.Point(58, 150);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(67, 16);
            this.Nombrelabel.TabIndex = 18;
            this.Nombrelabel.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(58, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(58, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha de Nacimiento: ";
            // 
            // Generolabel
            // 
            this.Generolabel.AutoSize = true;
            this.Generolabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Generolabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Generolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generolabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Generolabel.Location = new System.Drawing.Point(58, 217);
            this.Generolabel.Name = "Generolabel";
            this.Generolabel.Size = new System.Drawing.Size(63, 16);
            this.Generolabel.TabIndex = 21;
            this.Generolabel.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(58, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Apellidos:";
            // 
            // MatriculaLavel
            // 
            this.MatriculaLavel.AutoSize = true;
            this.MatriculaLavel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MatriculaLavel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MatriculaLavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaLavel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MatriculaLavel.Location = new System.Drawing.Point(58, 113);
            this.MatriculaLavel.Name = "MatriculaLavel";
            this.MatriculaLavel.Size = new System.Drawing.Size(75, 16);
            this.MatriculaLavel.TabIndex = 23;
            this.MatriculaLavel.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(380, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Direcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(384, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(384, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(380, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre del padre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(400, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 28;
            // 
            // MatriculatextBox
            // 
            this.MatriculatextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatriculatextBox.Location = new System.Drawing.Point(176, 109);
            this.MatriculatextBox.Name = "MatriculatextBox";
            this.MatriculatextBox.Size = new System.Drawing.Size(84, 20);
            this.MatriculatextBox.TabIndex = 29;
            this.MatriculatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatriculatextBox_KeyPress);
            // 
            // NombretextBox
            // 
            this.NombretextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombretextBox.Location = new System.Drawing.Point(176, 150);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(184, 20);
            this.NombretextBox.TabIndex = 30;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirecciontextBox.Location = new System.Drawing.Point(534, 149);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(228, 20);
            this.DirecciontextBox.TabIndex = 31;
            this.DirecciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirecciontextBox_KeyPress);
            // 
            // ApellidostextBox
            // 
            this.ApellidostextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApellidostextBox.Location = new System.Drawing.Point(175, 184);
            this.ApellidostextBox.Name = "ApellidostextBox";
            this.ApellidostextBox.Size = new System.Drawing.Size(185, 20);
            this.ApellidostextBox.TabIndex = 32;
            this.ApellidostextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidostextBox_KeyPress);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailtextBox.Location = new System.Drawing.Point(534, 109);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(228, 20);
            this.EmailtextBox.TabIndex = 33;
            this.EmailtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailtextBox_KeyPress);
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(534, 68);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(75, 20);
            this.TelefonoMaskedTextBox.TabIndex = 34;
            this.TelefonoMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoMaskedTextBox_KeyPress);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(227, 246);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.FechaDateTimePicker.TabIndex = 35;
            this.FechaDateTimePicker.ValueChanged += new System.EventHandler(this.FechaDateTimePicker_ValueChanged);
            this.FechaDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FechaDateTimePicker_KeyPress);
            // 
            // MasculinoRadioButton
            // 
            this.MasculinoRadioButton.AutoSize = true;
            this.MasculinoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasculinoRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MasculinoRadioButton.Location = new System.Drawing.Point(175, 218);
            this.MasculinoRadioButton.Name = "MasculinoRadioButton";
            this.MasculinoRadioButton.Size = new System.Drawing.Size(38, 20);
            this.MasculinoRadioButton.TabIndex = 37;
            this.MasculinoRadioButton.TabStop = true;
            this.MasculinoRadioButton.Text = "M";
            this.MasculinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemeninoradioButton
            // 
            this.FemeninoradioButton.AutoSize = true;
            this.FemeninoradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemeninoradioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FemeninoradioButton.Location = new System.Drawing.Point(227, 218);
            this.FemeninoradioButton.Name = "FemeninoradioButton";
            this.FemeninoradioButton.Size = new System.Drawing.Size(35, 20);
            this.FemeninoradioButton.TabIndex = 38;
            this.FemeninoradioButton.TabStop = true;
            this.FemeninoradioButton.Text = "F";
            this.FemeninoradioButton.UseVisualStyleBackColor = true;
            // 
            // Cursolabel
            // 
            this.Cursolabel.AutoSize = true;
            this.Cursolabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cursolabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cursolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursolabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cursolabel.Location = new System.Drawing.Point(380, 187);
            this.Cursolabel.Name = "Cursolabel";
            this.Cursolabel.Size = new System.Drawing.Size(52, 16);
            this.Cursolabel.TabIndex = 39;
            this.Cursolabel.Text = "Curso:";
            // 
            // CursocomboBox
            // 
            this.CursocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CursocomboBox.FormattingEnabled = true;
            this.CursocomboBox.Location = new System.Drawing.Point(534, 186);
            this.CursocomboBox.Name = "CursocomboBox";
            this.CursocomboBox.Size = new System.Drawing.Size(127, 21);
            this.CursocomboBox.TabIndex = 40;
           
            // 
            // GrupocomboBox
            // 
            this.GrupocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrupocomboBox.FormattingEnabled = true;
            this.GrupocomboBox.Items.AddRange(new object[] {
            "---",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.GrupocomboBox.Location = new System.Drawing.Point(534, 219);
            this.GrupocomboBox.Name = "GrupocomboBox";
            this.GrupocomboBox.Size = new System.Drawing.Size(75, 21);
            this.GrupocomboBox.TabIndex = 41;
            // 
            // Grupolabel
            // 
            this.Grupolabel.AutoSize = true;
            this.Grupolabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grupolabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grupolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupolabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Grupolabel.Location = new System.Drawing.Point(380, 220);
            this.Grupolabel.Name = "Grupolabel";
            this.Grupolabel.Size = new System.Drawing.Size(54, 16);
            this.Grupolabel.TabIndex = 42;
            this.Grupolabel.Text = "Grupo:";
            // 
            // NombrePadretextBox
            // 
            this.NombrePadretextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombrePadretextBox.Location = new System.Drawing.Point(534, 257);
            this.NombrePadretextBox.Name = "NombrePadretextBox";
            this.NombrePadretextBox.Size = new System.Drawing.Size(228, 20);
            this.NombrePadretextBox.TabIndex = 43;
            this.NombrePadretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrePadretextBox_KeyPress);
            // 
            // TelefonoPmaskedTextBox
            // 
            this.TelefonoPmaskedTextBox.Location = new System.Drawing.Point(534, 288);
            this.TelefonoPmaskedTextBox.Mask = "000-000-0000";
            this.TelefonoPmaskedTextBox.Name = "TelefonoPmaskedTextBox";
            this.TelefonoPmaskedTextBox.Size = new System.Drawing.Size(75, 20);
            this.TelefonoPmaskedTextBox.TabIndex = 45;
            this.TelefonoPmaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoPmaskedTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(380, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Telefono del Padre:";
            // 
            // EstudianteErrorProvider
            // 
            this.EstudianteErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EstudianteErrorProvider.ContainerControl = this;
            // 
            // Edadlabel
            // 
            this.Edadlabel.AutoSize = true;
            this.Edadlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edadlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Edadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edadlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Edadlabel.Location = new System.Drawing.Point(62, 292);
            this.Edadlabel.Name = "Edadlabel";
            this.Edadlabel.Size = new System.Drawing.Size(49, 16);
            this.Edadlabel.TabIndex = 46;
            this.Edadlabel.Text = "Edad:";
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdadtextBox.Location = new System.Drawing.Point(175, 288);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.ReadOnly = true;
            this.EdadtextBox.Size = new System.Drawing.Size(46, 20);
            this.EdadtextBox.TabIndex = 47;
            // 
            // EstudiantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 443);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.Edadlabel);
            this.Controls.Add(this.TelefonoPmaskedTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NombrePadretextBox);
            this.Controls.Add(this.Grupolabel);
            this.Controls.Add(this.GrupocomboBox);
            this.Controls.Add(this.CursocomboBox);
            this.Controls.Add(this.Cursolabel);
            this.Controls.Add(this.FemeninoradioButton);
            this.Controls.Add(this.MasculinoRadioButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.ApellidostextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.MatriculatextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatriculaLavel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Generolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EstudianteIdtextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.IdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EstudiantesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox EstudianteIdtextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Generolabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MatriculaLavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MatriculatextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox ApellidostextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.RadioButton MasculinoRadioButton;
        private System.Windows.Forms.RadioButton FemeninoradioButton;
        private System.Windows.Forms.Label Cursolabel;
        private System.Windows.Forms.ComboBox CursocomboBox;
        private System.Windows.Forms.ComboBox GrupocomboBox;
        private System.Windows.Forms.Label Grupolabel;
        private System.Windows.Forms.TextBox NombrePadretextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoPmaskedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider EstudianteErrorProvider;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.Label Edadlabel;
    }
}