namespace TeacherControl2016.Consultas
{
    partial class ConsultaEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEstudiantes));
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.EstudianteDataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Id",
            "Matricula",
            "Nombre",
            "Apellidos",
            "Edad"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(137, 27);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(200, 21);
            this.FiltrocomboBox.TabIndex = 30;
            this.FiltrocomboBox.TextChanged += new System.EventHandler(this.FiltrocomboBox_TextChanged);
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filtrolabel.Location = new System.Drawing.Point(38, 29);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(93, 16);
            this.Filtrolabel.TabIndex = 29;
            this.Filtrolabel.Text = "Filtrado Por:";
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Totallabel.Location = new System.Drawing.Point(38, 370);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(48, 16);
            this.Totallabel.TabIndex = 28;
            this.Totallabel.Text = "Total:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(93, 369);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(61, 20);
            this.TotaltextBox.TabIndex = 27;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(413, 29);
            this.BuscartextBox.MaxLength = 50;
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.ReadOnly = true;
            this.BuscartextBox.Size = new System.Drawing.Size(204, 20);
            this.BuscartextBox.TabIndex = 26;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
            // 
            // EstudianteDataGridView
            // 
            this.EstudianteDataGridView.AllowUserToAddRows = false;
            this.EstudianteDataGridView.AllowUserToDeleteRows = false;
            this.EstudianteDataGridView.AllowUserToOrderColumns = true;
            this.EstudianteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EstudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudianteDataGridView.Location = new System.Drawing.Point(41, 68);
            this.EstudianteDataGridView.Name = "EstudianteDataGridView";
            this.EstudianteDataGridView.ReadOnly = true;
            this.EstudianteDataGridView.Size = new System.Drawing.Size(683, 295);
            this.EstudianteDataGridView.TabIndex = 24;
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
            this.BuscarButton.Location = new System.Drawing.Point(646, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 64);
            this.BuscarButton.TabIndex = 25;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 403);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Filtrolabel);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EstudianteDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView EstudianteDataGridView;
    }
}