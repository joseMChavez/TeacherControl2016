namespace TeacherControl2016.Registros
{
    partial class MateriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriasForm));
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.MateriaIdtextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.MateriasErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MateriasErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescripcionLabel.Location = new System.Drawing.Point(25, 110);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(95, 16);
            this.DescripcionLabel.TabIndex = 17;
            this.DescripcionLabel.Text = "Descripción:";
            // 
            // MateriaIdtextBox
            // 
            this.MateriaIdtextBox.Location = new System.Drawing.Point(148, 50);
            this.MateriaIdtextBox.MaxLength = 5;
            this.MateriaIdtextBox.Name = "MateriaIdtextBox";
            this.MateriaIdtextBox.Size = new System.Drawing.Size(84, 20);
            this.MateriaIdtextBox.TabIndex = 21;
            this.MateriaIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MateriaIdtextBox_KeyPress);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(148, 108);
            this.DescripcionTextBox.MaxLength = 30;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(177, 20);
            this.DescripcionTextBox.TabIndex = 20;
            this.DescripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTextBox_KeyPress);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdLabel.Location = new System.Drawing.Point(34, 51);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 16);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "Id:";
            // 
            // MateriasErrorProvider
            // 
            this.MateriasErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.MateriasErrorProvider.ContainerControl = this;
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
            this.BuscarButton.Location = new System.Drawing.Point(247, 26);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 61);
            this.BuscarButton.TabIndex = 18;
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
            this.GuardarButton.Location = new System.Drawing.Point(131, 174);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 64);
            this.GuardarButton.TabIndex = 16;
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
            this.EliminarButton.Location = new System.Drawing.Point(245, 174);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 60);
            this.EliminarButton.TabIndex = 15;
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
            this.NuevoButton.Location = new System.Drawing.Point(28, 178);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 60);
            this.NuevoButton.TabIndex = 14;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // MateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.MateriaIdtextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MateriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Materias";
            ((System.ComponentModel.ISupportInitialize)(this.MateriasErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox MateriaIdtextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MateriasErrorProvider;
    }
}