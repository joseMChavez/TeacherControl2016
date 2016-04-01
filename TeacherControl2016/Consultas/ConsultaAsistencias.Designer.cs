namespace TeacherControl2016.Consultas
{
    partial class ConsultaAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAsistencias));
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.AsistenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.Totallabel = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActivarcheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Id",
            "Estudiante",
            "Curso"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(158, 31);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(200, 21);
            this.FiltrocomboBox.TabIndex = 28;
            this.FiltrocomboBox.TextChanged += new System.EventHandler(this.FiltrocomboBox_TextChanged);
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filtrolabel.Location = new System.Drawing.Point(33, 36);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(93, 16);
            this.Filtrolabel.TabIndex = 27;
            this.Filtrolabel.Text = "Filtrado Por:";
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(389, 31);
            this.BuscartextBox.MaxLength = 49;
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.ReadOnly = true;
            this.BuscartextBox.Size = new System.Drawing.Size(164, 20);
            this.BuscartextBox.TabIndex = 26;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
            // 
            // AsistenciaDataGridView
            // 
            this.AsistenciaDataGridView.AllowUserToAddRows = false;
            this.AsistenciaDataGridView.AllowUserToDeleteRows = false;
            this.AsistenciaDataGridView.AllowUserToOrderColumns = true;
            this.AsistenciaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AsistenciaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AsistenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistenciaDataGridView.Location = new System.Drawing.Point(36, 127);
            this.AsistenciaDataGridView.Name = "AsistenciaDataGridView";
            this.AsistenciaDataGridView.ReadOnly = true;
            this.AsistenciaDataGridView.Size = new System.Drawing.Size(646, 261);
            this.AsistenciaDataGridView.TabIndex = 24;
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
            this.BuscarButton.Location = new System.Drawing.Point(595, 31);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(87, 64);
            this.BuscarButton.TabIndex = 25;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Enabled = false;
            this.ImprimirButton.FlatAppearance.BorderSize = 0;
            this.ImprimirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ImprimirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ImprimirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ImprimirButton.Image = global::TeacherControl2016.Properties.Resources._1458844922_folder_print2;
            this.ImprimirButton.Location = new System.Drawing.Point(595, 394);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(87, 55);
            this.ImprimirButton.TabIndex = 35;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Totallabel.Location = new System.Drawing.Point(33, 406);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(48, 16);
            this.Totallabel.TabIndex = 34;
            this.Totallabel.Text = "Total:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(87, 405);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(61, 20);
            this.TotaltextBox.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HastadateTimePicker);
            this.groupBox1.Controls.Add(this.DesdedateTimePicker);
            this.groupBox1.Controls.Add(this.ActivarcheckBox);
            this.groupBox1.Location = new System.Drawing.Point(36, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 59);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(314, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Desde:";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(397, 19);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.HastadateTimePicker.TabIndex = 2;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(122, 23);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.DesdedateTimePicker.TabIndex = 1;
            // 
            // ActivarcheckBox
            // 
            this.ActivarcheckBox.AutoSize = true;
            this.ActivarcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivarcheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActivarcheckBox.Location = new System.Drawing.Point(0, -3);
            this.ActivarcheckBox.Name = "ActivarcheckBox";
            this.ActivarcheckBox.Size = new System.Drawing.Size(75, 20);
            this.ActivarcheckBox.TabIndex = 0;
            this.ActivarcheckBox.Text = "Activar";
            this.ActivarcheckBox.UseVisualStyleBackColor = true;
            this.ActivarcheckBox.CheckedChanged += new System.EventHandler(this.ActivarcheckBox_CheckedChanged);
            // 
            // ConsultaAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.AsistenciaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Asistencias";
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView AsistenciaDataGridView;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.CheckBox ActivarcheckBox;
    }
}