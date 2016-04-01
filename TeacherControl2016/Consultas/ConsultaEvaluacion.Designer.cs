namespace TeacherControl2016.Consultas
{
    partial class ConsultaEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEvaluacion));
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechasgroupBox = new System.Windows.Forms.GroupBox();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActivarcheckBox = new System.Windows.Forms.CheckBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.Totallabel = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.EvaluacionDataGridView = new System.Windows.Forms.DataGridView();
            this.FechasgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluacionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(396, 23);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.HastadateTimePicker.TabIndex = 2;
            // 
            // FechasgroupBox
            // 
            this.FechasgroupBox.Controls.Add(this.Hastalabel);
            this.FechasgroupBox.Controls.Add(this.Desdelabel);
            this.FechasgroupBox.Controls.Add(this.HastadateTimePicker);
            this.FechasgroupBox.Controls.Add(this.DesdedateTimePicker);
            this.FechasgroupBox.Controls.Add(this.ActivarcheckBox);
            this.FechasgroupBox.Location = new System.Drawing.Point(32, 43);
            this.FechasgroupBox.Name = "FechasgroupBox";
            this.FechasgroupBox.Size = new System.Drawing.Size(517, 59);
            this.FechasgroupBox.TabIndex = 41;
            this.FechasgroupBox.TabStop = false;
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hastalabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hastalabel.Location = new System.Drawing.Point(314, 27);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(53, 16);
            this.Hastalabel.TabIndex = 38;
            this.Hastalabel.Text = "Hasta:";
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desdelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Desdelabel.Location = new System.Drawing.Point(32, 27);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(58, 16);
            this.Desdelabel.TabIndex = 37;
            this.Desdelabel.Text = "Desde:";
            // 
            // DesdedateTimePicker
            // 
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
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Id",
            "Estudiante",
            "Curso"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(138, 16);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(200, 21);
            this.FiltrocomboBox.TabIndex = 40;
            this.FiltrocomboBox.TextChanged += new System.EventHandler(this.FiltrocomboBox_TextChanged);
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filtrolabel.Location = new System.Drawing.Point(39, 17);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(93, 16);
            this.Filtrolabel.TabIndex = 39;
            this.Filtrolabel.Text = "Filtrado Por:";
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(369, 16);
            this.BuscartextBox.MaxLength = 49;
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.ReadOnly = true;
            this.BuscartextBox.Size = new System.Drawing.Size(180, 20);
            this.BuscartextBox.TabIndex = 38;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
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
            this.BuscarButton.Location = new System.Drawing.Point(575, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(87, 64);
            this.BuscarButton.TabIndex = 37;
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
            this.ImprimirButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ImprimirButton.Image = global::TeacherControl2016.Properties.Resources._1458844922_folder_print2;
            this.ImprimirButton.Location = new System.Drawing.Point(591, 375);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(87, 55);
            this.ImprimirButton.TabIndex = 45;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Totallabel.Location = new System.Drawing.Point(29, 387);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(48, 16);
            this.Totallabel.TabIndex = 44;
            this.Totallabel.Text = "Total:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(83, 386);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(61, 20);
            this.TotaltextBox.TabIndex = 43;
            // 
            // EvaluacionDataGridView
            // 
            this.EvaluacionDataGridView.AllowUserToAddRows = false;
            this.EvaluacionDataGridView.AllowUserToDeleteRows = false;
            this.EvaluacionDataGridView.AllowUserToOrderColumns = true;
            this.EvaluacionDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EvaluacionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EvaluacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvaluacionDataGridView.Location = new System.Drawing.Point(32, 108);
            this.EvaluacionDataGridView.Name = "EvaluacionDataGridView";
            this.EvaluacionDataGridView.ReadOnly = true;
            this.EvaluacionDataGridView.Size = new System.Drawing.Size(646, 261);
            this.EvaluacionDataGridView.TabIndex = 42;
            // 
            // ConsultaEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 443);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.EvaluacionDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechasgroupBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.BuscartextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaEvaluacion";
            this.Text = "Evaluacion";
            this.FechasgroupBox.ResumeLayout(false);
            this.FechasgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluacionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.GroupBox FechasgroupBox;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.CheckBox ActivarcheckBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.DataGridView EvaluacionDataGridView;
    }
}