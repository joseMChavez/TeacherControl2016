namespace TeacherControl2016.Registros
{
    partial class AsistenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciasForm));
            this.CursosIdtextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.GrupocomboBox = new System.Windows.Forms.ComboBox();
            this.Cursolabel = new System.Windows.Forms.Label();
            this.Grupolabel = new System.Windows.Forms.Label();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AsistenciadataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CursosIdtextBox
            // 
            this.CursosIdtextBox.Location = new System.Drawing.Point(141, 30);
            this.CursosIdtextBox.MaxLength = 5;
            this.CursosIdtextBox.Name = "CursosIdtextBox";
            this.CursosIdtextBox.Size = new System.Drawing.Size(84, 20);
            this.CursosIdtextBox.TabIndex = 22;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdLabel.Location = new System.Drawing.Point(44, 30);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 16);
            this.IdLabel.TabIndex = 21;
            this.IdLabel.Text = "Id:";
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CursoComboBox.FormattingEnabled = true;
            this.CursoComboBox.Location = new System.Drawing.Point(141, 96);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(184, 21);
            this.CursoComboBox.TabIndex = 23;
            // 
            // GrupocomboBox
            // 
            this.GrupocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrupocomboBox.FormattingEnabled = true;
            this.GrupocomboBox.Location = new System.Drawing.Point(443, 95);
            this.GrupocomboBox.Name = "GrupocomboBox";
            this.GrupocomboBox.Size = new System.Drawing.Size(68, 21);
            this.GrupocomboBox.TabIndex = 24;
            // 
            // Cursolabel
            // 
            this.Cursolabel.AutoSize = true;
            this.Cursolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cursolabel.Location = new System.Drawing.Point(44, 100);
            this.Cursolabel.Name = "Cursolabel";
            this.Cursolabel.Size = new System.Drawing.Size(56, 16);
            this.Cursolabel.TabIndex = 26;
            this.Cursolabel.Text = "Curso: ";
            // 
            // Grupolabel
            // 
            this.Grupolabel.AutoSize = true;
            this.Grupolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grupolabel.Location = new System.Drawing.Point(370, 95);
            this.Grupolabel.Name = "Grupolabel";
            this.Grupolabel.Size = new System.Drawing.Size(58, 16);
            this.Grupolabel.TabIndex = 27;
            this.Grupolabel.Text = "Grupo: ";
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudiantecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(47, 190);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(184, 21);
            this.EstudiantecomboBox.TabIndex = 28;
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudiantelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Estudiantelabel.Location = new System.Drawing.Point(44, 171);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(89, 16);
            this.Estudiantelabel.TabIndex = 29;
            this.Estudiantelabel.Text = "Estudiante: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(278, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Esta: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Presente",
            "Ausente",
            "Excusa"});
            this.comboBox1.Location = new System.Drawing.Point(281, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // AsistenciadataGridView
            // 
            this.AsistenciadataGridView.AllowUserToAddRows = false;
            this.AsistenciadataGridView.AllowUserToOrderColumns = true;
            this.AsistenciadataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AsistenciadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistenciadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estudiante,
            this.Esta});
            this.AsistenciadataGridView.Location = new System.Drawing.Point(47, 217);
            this.AsistenciadataGridView.Name = "AsistenciadataGridView";
            this.AsistenciadataGridView.ReadOnly = true;
            this.AsistenciadataGridView.Size = new System.Drawing.Size(453, 171);
            this.AsistenciadataGridView.TabIndex = 32;
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
            this.BuscarButton.Location = new System.Drawing.Point(247, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 64);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
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
            this.GuardarButton.Location = new System.Drawing.Point(232, 399);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 64);
            this.GuardarButton.TabIndex = 19;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
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
            this.EliminarButton.Location = new System.Drawing.Point(431, 401);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 60);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
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
            this.NuevoButton.Location = new System.Drawing.Point(47, 403);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 60);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Agregarbutton.FlatAppearance.BorderSize = 0;
            this.Agregarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Agregarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Agregarbutton.Image = global::TeacherControl2016.Properties.Resources._1455915995_user_group_new;
            this.Agregarbutton.Location = new System.Drawing.Point(431, 151);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(90, 60);
            this.Agregarbutton.TabIndex = 33;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // Esta
            // 
            this.Esta.HeaderText = "Esta";
            this.Esta.Name = "Esta";
            this.Esta.ReadOnly = true;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fechalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fechalabel.Location = new System.Drawing.Point(370, 28);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(55, 16);
            this.Fechalabel.TabIndex = 34;
            this.Fechalabel.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // AsistenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 466);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.AsistenciadataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.Grupolabel);
            this.Controls.Add(this.Cursolabel);
            this.Controls.Add(this.GrupocomboBox);
            this.Controls.Add(this.CursoComboBox);
            this.Controls.Add(this.CursosIdtextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AsistenciasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Asistencias";
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CursosIdtextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.ComboBox GrupocomboBox;
        private System.Windows.Forms.Label Cursolabel;
        private System.Windows.Forms.Label Grupolabel;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView AsistenciadataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esta;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}