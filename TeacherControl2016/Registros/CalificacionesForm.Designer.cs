namespace TeacherControl2016.Registros
{
    partial class CalificacionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalificacionesForm));
            this.Materialabel = new System.Windows.Forms.Label();
            this.MateriacomboBox = new System.Windows.Forms.ComboBox();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.Cursolabel = new System.Windows.Forms.Label();
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.CalificacionIdtextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.Grupolabel = new System.Windows.Forms.Label();
            this.GrupocomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CCalificaionesComboBox = new System.Windows.Forms.ComboBox();
            this.PuntostextBox = new System.Windows.Forms.TextBox();
            this.Puntoslabel = new System.Windows.Forms.Label();
            this.CalificacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CalificaioneserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificaioneserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Materialabel
            // 
            this.Materialabel.AutoSize = true;
            this.Materialabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materialabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Materialabel.Location = new System.Drawing.Point(368, 154);
            this.Materialabel.Name = "Materialabel";
            this.Materialabel.Size = new System.Drawing.Size(68, 16);
            this.Materialabel.TabIndex = 40;
            this.Materialabel.Text = "Materia: ";
            // 
            // MateriacomboBox
            // 
            this.MateriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MateriacomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MateriacomboBox.FormattingEnabled = true;
            this.MateriacomboBox.Items.AddRange(new object[] {
            "",
            "Presente",
            "Ausente",
            "Excusa"});
            this.MateriacomboBox.Location = new System.Drawing.Point(449, 150);
            this.MateriacomboBox.Name = "MateriacomboBox";
            this.MateriacomboBox.Size = new System.Drawing.Size(144, 21);
            this.MateriacomboBox.TabIndex = 39;
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudiantelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Estudiantelabel.Location = new System.Drawing.Point(52, 150);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(89, 16);
            this.Estudiantelabel.TabIndex = 38;
            this.Estudiantelabel.Text = "Estudiante: ";
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudiantecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Items.AddRange(new object[] {
            "dfd"});
            this.EstudiantecomboBox.Location = new System.Drawing.Point(147, 149);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(184, 21);
            this.EstudiantecomboBox.TabIndex = 37;
            // 
            // Cursolabel
            // 
            this.Cursolabel.AutoSize = true;
            this.Cursolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cursolabel.Location = new System.Drawing.Point(52, 97);
            this.Cursolabel.Name = "Cursolabel";
            this.Cursolabel.Size = new System.Drawing.Size(56, 16);
            this.Cursolabel.TabIndex = 36;
            this.Cursolabel.Text = "Curso: ";
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CursoComboBox.FormattingEnabled = true;
            this.CursoComboBox.Location = new System.Drawing.Point(149, 93);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(184, 21);
            this.CursoComboBox.TabIndex = 35;
            this.CursoComboBox.TextChanged += new System.EventHandler(this.CursoComboBox_TextChanged);
            // 
            // CalificacionIdtextBox
            // 
            this.CalificacionIdtextBox.Location = new System.Drawing.Point(147, 48);
            this.CalificacionIdtextBox.MaxLength = 5;
            this.CalificacionIdtextBox.Name = "CalificacionIdtextBox";
            this.CalificacionIdtextBox.Size = new System.Drawing.Size(84, 20);
            this.CalificacionIdtextBox.TabIndex = 34;
            this.CalificacionIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsistenciaIdtextBox_KeyPress);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdLabel.Location = new System.Drawing.Point(52, 48);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 16);
            this.IdLabel.TabIndex = 33;
            this.IdLabel.Text = "Id:";
            // 
            // Grupolabel
            // 
            this.Grupolabel.AutoSize = true;
            this.Grupolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grupolabel.Location = new System.Drawing.Point(368, 94);
            this.Grupolabel.Name = "Grupolabel";
            this.Grupolabel.Size = new System.Drawing.Size(58, 16);
            this.Grupolabel.TabIndex = 45;
            this.Grupolabel.Text = "Grupo: ";
            // 
            // GrupocomboBox
            // 
            this.GrupocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrupocomboBox.FormattingEnabled = true;
            this.GrupocomboBox.Location = new System.Drawing.Point(449, 92);
            this.GrupocomboBox.Name = "GrupocomboBox";
            this.GrupocomboBox.Size = new System.Drawing.Size(84, 21);
            this.GrupocomboBox.TabIndex = 44;
            this.GrupocomboBox.TextChanged += new System.EventHandler(this.GrupocomboBox_TextChanged);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(509, 23);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.FechadateTimePicker.TabIndex = 48;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fechalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fechalabel.Location = new System.Drawing.Point(416, 23);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(55, 16);
            this.Fechalabel.TabIndex = 47;
            this.Fechalabel.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Descripcón";
            // 
            // CCalificaionesComboBox
            // 
            this.CCalificaionesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCalificaionesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCalificaionesComboBox.FormattingEnabled = true;
            this.CCalificaionesComboBox.Items.AddRange(new object[] {
            "dfd"});
            this.CCalificaionesComboBox.Location = new System.Drawing.Point(55, 234);
            this.CCalificaionesComboBox.Name = "CCalificaionesComboBox";
            this.CCalificaionesComboBox.Size = new System.Drawing.Size(276, 21);
            this.CCalificaionesComboBox.TabIndex = 49;
            // 
            // PuntostextBox
            // 
            this.PuntostextBox.Location = new System.Drawing.Point(352, 234);
            this.PuntostextBox.MaxLength = 5;
            this.PuntostextBox.Name = "PuntostextBox";
            this.PuntostextBox.Size = new System.Drawing.Size(166, 20);
            this.PuntostextBox.TabIndex = 52;
            // 
            // Puntoslabel
            // 
            this.Puntoslabel.AutoSize = true;
            this.Puntoslabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Puntoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntoslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Puntoslabel.Location = new System.Drawing.Point(349, 206);
            this.Puntoslabel.Name = "Puntoslabel";
            this.Puntoslabel.Size = new System.Drawing.Size(55, 16);
            this.Puntoslabel.TabIndex = 51;
            this.Puntoslabel.Text = "Puntos";
            // 
            // CalificacionesDataGridView
            // 
            this.CalificacionesDataGridView.AllowUserToAddRows = false;
            this.CalificacionesDataGridView.AllowUserToOrderColumns = true;
            this.CalificacionesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CalificacionesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalificacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalificacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripción,
            this.Puntos});
            this.CalificacionesDataGridView.Location = new System.Drawing.Point(55, 260);
            this.CalificacionesDataGridView.Name = "CalificacionesDataGridView";
            this.CalificacionesDataGridView.ReadOnly = true;
            this.CalificacionesDataGridView.Size = new System.Drawing.Size(538, 150);
            this.CalificacionesDataGridView.TabIndex = 53;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 380;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(176, 421);
            this.TotaltextBox.MaxLength = 5;
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(66, 20);
            this.TotaltextBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Total de Puntos";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Enabled = false;
            this.Agregarbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Agregarbutton.FlatAppearance.BorderSize = 0;
            this.Agregarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Agregarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Agregarbutton.Image = global::TeacherControl2016.Properties.Resources._1456533592_notebook_add;
            this.Agregarbutton.Location = new System.Drawing.Point(524, 206);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(80, 53);
            this.Agregarbutton.TabIndex = 46;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
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
            this.GuardarButton.Location = new System.Drawing.Point(285, 450);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 64);
            this.GuardarButton.TabIndex = 43;
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
            this.EliminarButton.Location = new System.Drawing.Point(524, 452);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 60);
            this.EliminarButton.TabIndex = 42;
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
            this.NuevoButton.Location = new System.Drawing.Point(44, 452);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 60);
            this.NuevoButton.TabIndex = 41;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
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
            this.BuscarButton.Location = new System.Drawing.Point(269, 23);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 64);
            this.BuscarButton.TabIndex = 32;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CalificaioneserrorProvider
            // 
            this.CalificaioneserrorProvider.ContainerControl = this;
            // 
            // CalificacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 524);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalificacionesDataGridView);
            this.Controls.Add(this.PuntostextBox);
            this.Controls.Add(this.Puntoslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CCalificaionesComboBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Grupolabel);
            this.Controls.Add(this.GrupocomboBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Materialabel);
            this.Controls.Add(this.MateriacomboBox);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.Cursolabel);
            this.Controls.Add(this.CursoComboBox);
            this.Controls.Add(this.CalificacionIdtextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BuscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalificacionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificaioneserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Materialabel;
        private System.Windows.Forms.ComboBox MateriacomboBox;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Label Cursolabel;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.TextBox CalificacionIdtextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label Grupolabel;
        private System.Windows.Forms.ComboBox GrupocomboBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CCalificaionesComboBox;
        private System.Windows.Forms.TextBox PuntostextBox;
        private System.Windows.Forms.Label Puntoslabel;
        private System.Windows.Forms.DataGridView CalificacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider CalificaioneserrorProvider;
    }
}