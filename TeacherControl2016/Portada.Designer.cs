namespace TeacherControl2016
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.TeacherControlmenuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosPorEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaDeCalificacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TControlstatusStrip = new System.Windows.Forms.StatusStrip();
            this.TControltoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuariosSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuariotSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TeacherControltoolStrip = new System.Windows.Forms.ToolStrip();
            this.EstudiantesRtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MateriatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AsistenciatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CalificacionestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FechaLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TeacherControlmenuStrip.SuspendLayout();
            this.TControlstatusStrip.SuspendLayout();
            this.TeacherControltoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherControlmenuStrip
            // 
            this.TeacherControlmenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.TeacherControlmenuStrip.BackgroundImage = global::TeacherControl2016.Properties.Resources.cuadro_transparente_png_by_chocolateespuma_d6ygq45;
            this.TeacherControlmenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TeacherControlmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.evaluacionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.TeacherControlmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TeacherControlmenuStrip.Name = "TeacherControlmenuStrip";
            this.TeacherControlmenuStrip.Size = new System.Drawing.Size(1013, 24);
            this.TeacherControlmenuStrip.TabIndex = 0;
            this.TeacherControlmenuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1455915673_Courses;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1458765921_Close;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources.Exit_delete_close_remove_door_logout_out;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cerrarSesionToolStripMenuItem.Text = "&Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.categoriaDeCalificacionesToolStripMenuItem,
            this.asistenciasToolStripMenuItem,
            this.calificacionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1454312482_blog;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.registrosToolStripMenuItem.Text = "&Registros";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1455915810_userconfig;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.usuarioToolStripMenuItem.Text = "&Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1455916129_Student_id_24;
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.estudiantesToolStripMenuItem.Text = "&Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1457150845_education_course_training;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cursosToolStripMenuItem.Text = "&Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1457333256_bookcase;
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.materiasToolStripMenuItem.Text = "&Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // categoriaDeCalificacionesToolStripMenuItem
            // 
            this.categoriaDeCalificacionesToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1455099110_categories;
            this.categoriaDeCalificacionesToolStripMenuItem.Name = "categoriaDeCalificacionesToolStripMenuItem";
            this.categoriaDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.categoriaDeCalificacionesToolStripMenuItem.Text = "C&ategoria de Calificaciones";
            this.categoriaDeCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.categoriaDeCalificacionesToolStripMenuItem_Click);
            // 
            // asistenciasToolStripMenuItem
            // 
            this.asistenciasToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1458036564_attendance_list;
            this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            this.asistenciasToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.asistenciasToolStripMenuItem.Text = "Asist&encias";
            this.asistenciasToolStripMenuItem.Click += new System.EventHandler(this.asistenciasToolStripMenuItem_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources.Capture;
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.calificacionesToolStripMenuItem.Text = "Ca&lificaciones";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.estudiantesToolStripMenuItem1,
            this.cursosToolStripMenuItem1,
            this.materiasToolStripMenuItem1,
            this.categoriaDeCalificacionesToolStripMenuItem1,
            this.asistenciasToolStripMenuItem1});
            this.consultasToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1455135756_Card_file;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1455915810_userconfig;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem1
            // 
            this.estudiantesToolStripMenuItem1.Image = global::TeacherControl2016.Properties.Resources._1455916129_Student_id_241;
            this.estudiantesToolStripMenuItem1.Name = "estudiantesToolStripMenuItem1";
            this.estudiantesToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.estudiantesToolStripMenuItem1.Text = "&Estudiantes";
            this.estudiantesToolStripMenuItem1.Click += new System.EventHandler(this.estudiantesToolStripMenuItem1_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosPorEstudiantesToolStripMenuItem});
            this.cursosToolStripMenuItem1.Image = global::TeacherControl2016.Properties.Resources._1457150845_education_course_training;
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.cursosToolStripMenuItem1.Text = "&Cursos";
            this.cursosToolStripMenuItem1.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // cursosPorEstudiantesToolStripMenuItem
            // 
            this.cursosPorEstudiantesToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources._1457150845_education_course_training;
            this.cursosPorEstudiantesToolStripMenuItem.Name = "cursosPorEstudiantesToolStripMenuItem";
            this.cursosPorEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cursosPorEstudiantesToolStripMenuItem.Text = "Estudiantes por Cursos";
            this.cursosPorEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.cursosPorEstudiantesToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem1
            // 
            this.materiasToolStripMenuItem1.Image = global::TeacherControl2016.Properties.Resources._1457333256_bookcase;
            this.materiasToolStripMenuItem1.Name = "materiasToolStripMenuItem1";
            this.materiasToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.materiasToolStripMenuItem1.Text = "&Materias";
            this.materiasToolStripMenuItem1.Click += new System.EventHandler(this.materiasToolStripMenuItem1_Click);
            // 
            // categoriaDeCalificacionesToolStripMenuItem1
            // 
            this.categoriaDeCalificacionesToolStripMenuItem1.Image = global::TeacherControl2016.Properties.Resources._1455099110_categories;
            this.categoriaDeCalificacionesToolStripMenuItem1.Name = "categoriaDeCalificacionesToolStripMenuItem1";
            this.categoriaDeCalificacionesToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.categoriaDeCalificacionesToolStripMenuItem1.Text = "Ca&tegoria de Calificaciones";
            this.categoriaDeCalificacionesToolStripMenuItem1.Click += new System.EventHandler(this.categoriaDeCalificacionesToolStripMenuItem1_Click);
            // 
            // asistenciasToolStripMenuItem1
            // 
            this.asistenciasToolStripMenuItem1.Image = global::TeacherControl2016.Properties.Resources._1458036564_attendance_list;
            this.asistenciasToolStripMenuItem1.Name = "asistenciasToolStripMenuItem1";
            this.asistenciasToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.asistenciasToolStripMenuItem1.Text = "&Asistencias";
            this.asistenciasToolStripMenuItem1.Click += new System.EventHandler(this.asistenciasToolStripMenuItem1_Click);
            // 
            // evaluacionToolStripMenuItem
            // 
            this.evaluacionToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources.vector_432_10_32;
            this.evaluacionToolStripMenuItem.Name = "evaluacionToolStripMenuItem";
            this.evaluacionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.evaluacionToolStripMenuItem.Text = "&Evaluacion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = global::TeacherControl2016.Properties.Resources.Info_32;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // TControlstatusStrip
            // 
            this.TControlstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TControltoolStripStatusLabel,
            this.UsuariosSLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.UsuariotSSLabel,
            this.toolStripStatusLabel3,
            this.FechaLabel});
            this.TControlstatusStrip.Location = new System.Drawing.Point(0, 502);
            this.TControlstatusStrip.Name = "TControlstatusStrip";
            this.TControlstatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.TControlstatusStrip.Size = new System.Drawing.Size(1013, 22);
            this.TControlstatusStrip.TabIndex = 1;
            this.TControlstatusStrip.Text = "statusStrip1";
            // 
            // TControltoolStripStatusLabel
            // 
            this.TControltoolStripStatusLabel.Name = "TControltoolStripStatusLabel";
            this.TControltoolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.TControltoolStripStatusLabel.Text = "Usuario:";
            // 
            // UsuariosSLabel
            // 
            this.UsuariosSLabel.Name = "UsuariosSLabel";
            this.UsuariosSLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.ToolTipText = "Usuario";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // UsuariotSSLabel
            // 
            this.UsuariotSSLabel.Name = "UsuariotSSLabel";
            this.UsuariotSSLabel.Size = new System.Drawing.Size(13, 17);
            this.UsuariotSSLabel.Text = "..";
            // 
            // TeacherControltoolStrip
            // 
            this.TeacherControltoolStrip.BackColor = System.Drawing.SystemColors.Window;
            this.TeacherControltoolStrip.BackgroundImage = global::TeacherControl2016.Properties.Resources.cuadro_transparente_png_by_chocolateespuma_d6ygq45;
            this.TeacherControltoolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TeacherControltoolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeacherControltoolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TeacherControltoolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TeacherControltoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstudiantesRtoolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.MateriatoolStripButton,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.AsistenciatoolStripButton,
            this.toolStripSeparator5,
            this.CalificacionestoolStripButton});
            this.TeacherControltoolStrip.Location = new System.Drawing.Point(0, 24);
            this.TeacherControltoolStrip.Name = "TeacherControltoolStrip";
            this.TeacherControltoolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TeacherControltoolStrip.Size = new System.Drawing.Size(41, 478);
            this.TeacherControltoolStrip.TabIndex = 2;
            this.TeacherControltoolStrip.Text = "TeacherControltoolStrip";
            this.TeacherControltoolStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // EstudiantesRtoolStripButton
            // 
            this.EstudiantesRtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EstudiantesRtoolStripButton.Image = global::TeacherControl2016.Properties.Resources._1455916129_Student_id_24;
            this.EstudiantesRtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EstudiantesRtoolStripButton.Margin = new System.Windows.Forms.Padding(2);
            this.EstudiantesRtoolStripButton.Name = "EstudiantesRtoolStripButton";
            this.EstudiantesRtoolStripButton.Size = new System.Drawing.Size(34, 36);
            this.EstudiantesRtoolStripButton.Text = "Registro de Estudiantes";
            this.EstudiantesRtoolStripButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EstudiantesRtoolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(38, 6);
            this.toolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TeacherControl2016.Properties.Resources._1457150845_education_course_training;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 36);
            this.toolStripButton1.Text = "Registro de Cursos";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(38, 6);
            this.toolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // MateriatoolStripButton
            // 
            this.MateriatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MateriatoolStripButton.Image = global::TeacherControl2016.Properties.Resources._1457333256_bookcase;
            this.MateriatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MateriatoolStripButton.Name = "MateriatoolStripButton";
            this.MateriatoolStripButton.Size = new System.Drawing.Size(38, 36);
            this.MateriatoolStripButton.Text = "Registro de Materias";
            this.MateriatoolStripButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(38, 6);
            this.toolStripSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TeacherControl2016.Properties.Resources._1455099110_categories;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(38, 36);
            this.toolStripButton2.Text = "Registro de Categoria de Calificaciones";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(38, 6);
            this.toolStripSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // AsistenciatoolStripButton
            // 
            this.AsistenciatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AsistenciatoolStripButton.Image = global::TeacherControl2016.Properties.Resources._1458036564_attendance_list;
            this.AsistenciatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AsistenciatoolStripButton.Name = "AsistenciatoolStripButton";
            this.AsistenciatoolStripButton.Size = new System.Drawing.Size(38, 36);
            this.AsistenciatoolStripButton.Text = "Registro de Asistencia";
            this.AsistenciatoolStripButton.Click += new System.EventHandler(this.AsistenciatoolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(38, 6);
            this.toolStripSeparator5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // CalificacionestoolStripButton
            // 
            this.CalificacionestoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalificacionestoolStripButton.Image = global::TeacherControl2016.Properties.Resources.Capture;
            this.CalificacionestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalificacionestoolStripButton.Name = "CalificacionestoolStripButton";
            this.CalificacionestoolStripButton.Size = new System.Drawing.Size(38, 36);
            this.CalificacionestoolStripButton.Text = "Registro de Calificaiones";
            this.CalificacionestoolStripButton.Click += new System.EventHandler(this.CalificacionestoolStripButton_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel3.Text = "||";
            // 
            // FechaLabel
            // 
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(16, 17);
            this.FechaLabel.Text = "...";
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TeacherControl2016.Properties.Resources._733510_e191_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 524);
            this.Controls.Add(this.TeacherControltoolStrip);
            this.Controls.Add(this.TControlstatusStrip);
            this.Controls.Add(this.TeacherControlmenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TeacherControlmenuStrip;
            this.Name = "Portada";
            this.Text = "Teacher Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Portada_Load);
            this.TeacherControlmenuStrip.ResumeLayout(false);
            this.TeacherControlmenuStrip.PerformLayout();
            this.TControlstatusStrip.ResumeLayout(false);
            this.TControlstatusStrip.PerformLayout();
            this.TeacherControltoolStrip.ResumeLayout(false);
            this.TeacherControltoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TeacherControlmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip TControlstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TControltoolStripStatusLabel;
        private System.Windows.Forms.ToolStrip TeacherControltoolStrip;
        private System.Windows.Forms.ToolStripButton EstudiantesRtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursosPorEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MateriatoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeCalificacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton AsistenciatoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton CalificacionestoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel UsuariosSLabel;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel UsuariotSSLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel FechaLabel;
    }
}