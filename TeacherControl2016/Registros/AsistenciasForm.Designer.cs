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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciasForm));
            this.GrupocomboBox = new System.Windows.Forms.ComboBox();
            this.Grupolabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.TotalAsitencialabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.AsistenciaIdtextBox = new System.Windows.Forms.TextBox();
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.Cursolabel = new System.Windows.Forms.Label();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.EstacomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadEsttextBox = new System.Windows.Forms.TextBox();
            this.AsistenciaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AsistenciadataGridView = new System.Windows.Forms.DataGridView();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupocomboBox
            // 
            this.GrupocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrupocomboBox.FormattingEnabled = true;
            this.GrupocomboBox.Location = new System.Drawing.Point(433, 94);
            this.GrupocomboBox.Name = "GrupocomboBox";
            this.GrupocomboBox.Size = new System.Drawing.Size(77, 21);
            this.GrupocomboBox.TabIndex = 24;
            this.GrupocomboBox.SelectedValueChanged += new System.EventHandler(this.GrupocomboBox_SelectedValueChanged);
            // 
            // Grupolabel
            // 
            this.Grupolabel.AutoSize = true;
            this.Grupolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupolabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grupolabel.Location = new System.Drawing.Point(366, 95);
            this.Grupolabel.Name = "Grupolabel";
            this.Grupolabel.Size = new System.Drawing.Size(58, 16);
            this.Grupolabel.TabIndex = 27;
            this.Grupolabel.Text = "Grupo: ";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fechalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fechalabel.Location = new System.Drawing.Point(366, 28);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(55, 16);
            this.Fechalabel.TabIndex = 34;
            this.Fechalabel.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(433, 24);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.FechadateTimePicker.TabIndex = 35;
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
            this.Agregarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Agregarbutton.Image = global::TeacherControl2016.Properties.Resources._1455915995_user_group_new;
            this.Agregarbutton.Location = new System.Drawing.Point(427, 158);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(80, 53);
            this.Agregarbutton.TabIndex = 33;
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
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuardarButton.Image = global::TeacherControl2016.Properties.Resources._1453541193_save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(227, 426);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 64);
            this.GuardarButton.TabIndex = 19;
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
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarButton.Image = global::TeacherControl2016.Properties.Resources._1452899178_trash;
            this.EliminarButton.Location = new System.Drawing.Point(427, 428);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 60);
            this.EliminarButton.TabIndex = 18;
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
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NuevoButton.Image = global::TeacherControl2016.Properties.Resources._1452825521_Add;
            this.NuevoButton.Location = new System.Drawing.Point(43, 428);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 60);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // TotalAsitencialabel
            // 
            this.TotalAsitencialabel.AutoSize = true;
            this.TotalAsitencialabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAsitencialabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalAsitencialabel.Location = new System.Drawing.Point(40, 400);
            this.TotalAsitencialabel.Name = "TotalAsitencialabel";
            this.TotalAsitencialabel.Size = new System.Drawing.Size(181, 16);
            this.TotalAsitencialabel.TabIndex = 36;
            this.TotalAsitencialabel.Text = "Cantidad de Estudiantes:";
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BuscarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuscarButton.Image = global::TeacherControl2016.Properties.Resources._1453541260_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(243, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 64);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IdLabel.Location = new System.Drawing.Point(40, 30);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 16);
            this.IdLabel.TabIndex = 21;
            this.IdLabel.Text = "Id:";
            // 
            // AsistenciaIdtextBox
            // 
            this.AsistenciaIdtextBox.Location = new System.Drawing.Point(137, 30);
            this.AsistenciaIdtextBox.MaxLength = 5;
            this.AsistenciaIdtextBox.Name = "AsistenciaIdtextBox";
            this.AsistenciaIdtextBox.Size = new System.Drawing.Size(84, 20);
            this.AsistenciaIdtextBox.TabIndex = 22;
            this.AsistenciaIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsistenciaIdtextBox_KeyPress);
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CursoComboBox.FormattingEnabled = true;
            this.CursoComboBox.Location = new System.Drawing.Point(137, 96);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(184, 21);
            this.CursoComboBox.TabIndex = 23;
            this.CursoComboBox.SelectedValueChanged += new System.EventHandler(this.CursoComboBox_SelectedValueChanged);
            // 
            // Cursolabel
            // 
            this.Cursolabel.AutoSize = true;
            this.Cursolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cursolabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cursolabel.Location = new System.Drawing.Point(40, 100);
            this.Cursolabel.Name = "Cursolabel";
            this.Cursolabel.Size = new System.Drawing.Size(56, 16);
            this.Cursolabel.TabIndex = 26;
            this.Cursolabel.Text = "Curso: ";
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudiantecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Items.AddRange(new object[] {
            "dfd"});
            this.EstudiantecomboBox.Location = new System.Drawing.Point(43, 190);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(184, 21);
            this.EstudiantecomboBox.TabIndex = 28;
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudiantelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Estudiantelabel.Location = new System.Drawing.Point(40, 171);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(89, 16);
            this.Estudiantelabel.TabIndex = 29;
            this.Estudiantelabel.Text = "Estudiante: ";
            // 
            // EstacomboBox
            // 
            this.EstacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstacomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstacomboBox.FormattingEnabled = true;
            this.EstacomboBox.Items.AddRange(new object[] {
            "",
            "Presente",
            "Ausente",
            "Excusa"});
            this.EstacomboBox.Location = new System.Drawing.Point(277, 190);
            this.EstacomboBox.Name = "EstacomboBox";
            this.EstacomboBox.Size = new System.Drawing.Size(144, 21);
            this.EstacomboBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(274, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Estado: ";
            // 
            // CantidadEsttextBox
            // 
            this.CantidadEsttextBox.Location = new System.Drawing.Point(227, 399);
            this.CantidadEsttextBox.MaxLength = 5;
            this.CantidadEsttextBox.Name = "CantidadEsttextBox";
            this.CantidadEsttextBox.ReadOnly = true;
            this.CantidadEsttextBox.Size = new System.Drawing.Size(47, 20);
            this.CantidadEsttextBox.TabIndex = 38;
            // 
            // AsistenciaerrorProvider
            // 
            this.AsistenciaerrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AsistenciaerrorProvider.ContainerControl = this;
            // 
            // AsistenciadataGridView
            // 
            this.AsistenciadataGridView.AllowUserToAddRows = false;
            this.AsistenciadataGridView.AllowUserToOrderColumns = true;
            this.AsistenciadataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AsistenciadataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AsistenciadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistenciadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estudiante,
            this.Estado});
            this.AsistenciadataGridView.Location = new System.Drawing.Point(43, 227);
            this.AsistenciadataGridView.Name = "AsistenciadataGridView";
            this.AsistenciadataGridView.ReadOnly = true;
            this.AsistenciadataGridView.Size = new System.Drawing.Size(464, 150);
            this.AsistenciadataGridView.TabIndex = 39;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            this.Estudiante.Width = 300;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 120;
            // 
            // AsistenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 503);
            this.Controls.Add(this.AsistenciadataGridView);
            this.Controls.Add(this.CantidadEsttextBox);
            this.Controls.Add(this.TotalAsitencialabel);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstacomboBox);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.Grupolabel);
            this.Controls.Add(this.Cursolabel);
            this.Controls.Add(this.GrupocomboBox);
            this.Controls.Add(this.CursoComboBox);
            this.Controls.Add(this.AsistenciaIdtextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AsistenciasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Asistencias";
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ComboBox GrupocomboBox;
        private System.Windows.Forms.Label Grupolabel;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label TotalAsitencialabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EstacomboBox;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Label Cursolabel;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.TextBox AsistenciaIdtextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox CantidadEsttextBox;
        private System.Windows.Forms.ErrorProvider AsistenciaerrorProvider;
        private System.Windows.Forms.DataGridView AsistenciadataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}