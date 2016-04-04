namespace TeacherControl2016
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioNametextBox = new System.Windows.Forms.TextBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.ImagepictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(45, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(48, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bienvenido a Teacher Control";
            // 
            // UsuarioNametextBox
            // 
            this.UsuarioNametextBox.Location = new System.Drawing.Point(146, 129);
            this.UsuarioNametextBox.MaxLength = 40;
            this.UsuarioNametextBox.Name = "UsuarioNametextBox";
            this.UsuarioNametextBox.Size = new System.Drawing.Size(144, 20);
            this.UsuarioNametextBox.TabIndex = 6;
            this.UsuarioNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioNametextBox_KeyPress);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(146, 173);
            this.PasstextBox.MaxLength = 12;
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(144, 20);
            this.PasstextBox.TabIndex = 7;
            this.PasstextBox.UseSystemPasswordChar = true;
            this.PasstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasstextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(48, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TeacherControl2016.Properties.Resources._1458766531_Key;
            this.pictureBox1.Location = new System.Drawing.Point(12, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.FlatAppearance.BorderSize = 0;
            this.Cancelarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cancelarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Cancelarbutton.Image = global::TeacherControl2016.Properties.Resources._1458765921_Close;
            this.Cancelarbutton.Location = new System.Drawing.Point(206, 205);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(84, 58);
            this.Cancelarbutton.TabIndex = 3;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.FlatAppearance.BorderSize = 0;
            this.Aceptarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Aceptarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aceptarbutton.Image = global::TeacherControl2016.Properties.Resources._1453541179_ok_sign;
            this.Aceptarbutton.Location = new System.Drawing.Point(34, 205);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(84, 58);
            this.Aceptarbutton.TabIndex = 2;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // ImagepictureBox
            // 
            this.ImagepictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagepictureBox.Image = global::TeacherControl2016.Properties.Resources._1455915734_Generate_keys;
            this.ImagepictureBox.Location = new System.Drawing.Point(92, 9);
            this.ImagepictureBox.Name = "ImagepictureBox";
            this.ImagepictureBox.Size = new System.Drawing.Size(129, 114);
            this.ImagepictureBox.TabIndex = 8;
            this.ImagepictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TeacherControl2016.Properties.Resources._1458766571_user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 40);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // LoginerrorProvider
            // 
            this.LoginerrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.UsuarioNametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagepictureBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.PictureBox ImagepictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider LoginerrorProvider;
        private System.Windows.Forms.TextBox UsuarioNametextBox;
    }
}