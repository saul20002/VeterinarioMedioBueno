namespace EjemploTabs_2021
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.mascotaNueva = new System.Windows.Forms.Button();
            this.usuarioNuevo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxEsterilizado = new System.Windows.Forms.TextBox();
            this.textBoxVacunas = new System.Windows.Forms.TextBox();
            this.textBoxCoste = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxChip = new System.Windows.Forms.TextBox();
            this.textBoxEnfermedad = new System.Windows.Forms.TextBox();
            this.textBoxCod_Ingreso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxNum_Telefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.telefonoDueño = new System.Windows.Forms.Label();
            this.raza = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.nombreAmo = new System.Windows.Forms.Label();
            this.nombreDueño = new System.Windows.Forms.Label();
            this.nombreMascota = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.botonDueño = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonMascota = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.mascotaNueva);
            this.tabPage1.Controls.Add(this.usuarioNuevo);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(988, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir usuario/mascota";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 289);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(751, 106);
            this.button5.TabIndex = 2;
            this.button5.Text = "AÑADIR VETERINARIO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mascotaNueva
            // 
            this.mascotaNueva.Location = new System.Drawing.Point(11, 166);
            this.mascotaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.mascotaNueva.Name = "mascotaNueva";
            this.mascotaNueva.Size = new System.Drawing.Size(751, 106);
            this.mascotaNueva.TabIndex = 1;
            this.mascotaNueva.Text = "AÑADIR MASCOTA";
            this.mascotaNueva.UseVisualStyleBackColor = true;
            this.mascotaNueva.Click += new System.EventHandler(this.mascotaNueva_Click);
            // 
            // usuarioNuevo
            // 
            this.usuarioNuevo.Location = new System.Drawing.Point(11, 43);
            this.usuarioNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioNuevo.Name = "usuarioNuevo";
            this.usuarioNuevo.Size = new System.Drawing.Size(751, 106);
            this.usuarioNuevo.TabIndex = 0;
            this.usuarioNuevo.Text = "AÑADIR USUARIO";
            this.usuarioNuevo.UseVisualStyleBackColor = true;
            this.usuarioNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxEsterilizado);
            this.tabPage2.Controls.Add(this.textBoxVacunas);
            this.tabPage2.Controls.Add(this.textBoxCoste);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxDescripcion);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.textBoxChip);
            this.tabPage2.Controls.Add(this.textBoxEnfermedad);
            this.tabPage2.Controls.Add(this.textBoxCod_Ingreso);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(988, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxEsterilizado
            // 
            this.textBoxEsterilizado.Location = new System.Drawing.Point(548, 194);
            this.textBoxEsterilizado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEsterilizado.Name = "textBoxEsterilizado";
            this.textBoxEsterilizado.Size = new System.Drawing.Size(177, 27);
            this.textBoxEsterilizado.TabIndex = 20;
            // 
            // textBoxVacunas
            // 
            this.textBoxVacunas.Location = new System.Drawing.Point(548, 122);
            this.textBoxVacunas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVacunas.Name = "textBoxVacunas";
            this.textBoxVacunas.Size = new System.Drawing.Size(177, 27);
            this.textBoxVacunas.TabIndex = 19;
            // 
            // textBoxCoste
            // 
            this.textBoxCoste.Location = new System.Drawing.Point(225, 256);
            this.textBoxCoste.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoste.Name = "textBoxCoste";
            this.textBoxCoste.Size = new System.Drawing.Size(140, 27);
            this.textBoxCoste.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Location = new System.Drawing.Point(17, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Coste";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 158);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(225, 309);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(500, 27);
            this.textBoxDescripcion.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(225, 122);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 27);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // textBoxChip
            // 
            this.textBoxChip.Location = new System.Drawing.Point(548, 55);
            this.textBoxChip.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(177, 27);
            this.textBoxChip.TabIndex = 11;
            // 
            // textBoxEnfermedad
            // 
            this.textBoxEnfermedad.Location = new System.Drawing.Point(225, 193);
            this.textBoxEnfermedad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnfermedad.Name = "textBoxEnfermedad";
            this.textBoxEnfermedad.Size = new System.Drawing.Size(140, 27);
            this.textBoxEnfermedad.TabIndex = 10;
            // 
            // textBoxCod_Ingreso
            // 
            this.textBoxCod_Ingreso.Location = new System.Drawing.Point(225, 55);
            this.textBoxCod_Ingreso.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCod_Ingreso.Name = "textBoxCod_Ingreso";
            this.textBoxCod_Ingreso.Size = new System.Drawing.Size(141, 27);
            this.textBoxCod_Ingreso.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Location = new System.Drawing.Point(13, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Motivo de ingreso";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Location = new System.Drawing.Point(393, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esterilizado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Location = new System.Drawing.Point(393, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vacunas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Location = new System.Drawing.Point(393, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chip";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enfermedad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de ingreso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de ingreso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EjemploTabs_2021.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.textBoxNum_Telefono);
            this.tabPage3.Controls.Add(this.textBoxEmail);
            this.tabPage3.Controls.Add(this.textBoxApellidos);
            this.tabPage3.Controls.Add(this.textBoxNombre);
            this.tabPage3.Controls.Add(this.textBoxDNI);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(988, 673);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pedir cita";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(719, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 253);
            this.button4.TabIndex = 12;
            this.button4.Text = "SOLICITAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxNum_Telefono
            // 
            this.textBoxNum_Telefono.Location = new System.Drawing.Point(314, 418);
            this.textBoxNum_Telefono.Name = "textBoxNum_Telefono";
            this.textBoxNum_Telefono.Size = new System.Drawing.Size(129, 27);
            this.textBoxNum_Telefono.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(314, 350);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(129, 27);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(314, 274);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(129, 27);
            this.textBoxApellidos.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(314, 201);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(129, 27);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(314, 50);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(129, 27);
            this.textBoxDNI.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Aquamarine;
            this.label14.Location = new System.Drawing.Point(105, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 27);
            this.label14.TabIndex = 6;
            this.label14.Text = "Num de teléfono";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Aquamarine;
            this.label15.Location = new System.Drawing.Point(105, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 27);
            this.label15.TabIndex = 5;
            this.label15.Text = "Email";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Aquamarine;
            this.label12.Location = new System.Drawing.Point(105, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "Apellidos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Aquamarine;
            this.label13.Location = new System.Drawing.Point(105, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 27);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nombre";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Aquamarine;
            this.label11.Location = new System.Drawing.Point(105, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fecha";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Aquamarine;
            this.label9.Location = new System.Drawing.Point(105, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "DNI";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.telefonoDueño);
            this.tabPage4.Controls.Add(this.raza);
            this.tabPage4.Controls.Add(this.especie);
            this.tabPage4.Controls.Add(this.nombreAmo);
            this.tabPage4.Controls.Add(this.nombreDueño);
            this.tabPage4.Controls.Add(this.nombreMascota);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.botonDueño);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.botonMascota);
            this.tabPage4.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.ImageIndex = 2;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(988, 673);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscador de mascotas/ dueños";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // telefonoDueño
            // 
            this.telefonoDueño.BackColor = System.Drawing.Color.Lime;
            this.telefonoDueño.Location = new System.Drawing.Point(767, 454);
            this.telefonoDueño.Name = "telefonoDueño";
            this.telefonoDueño.Size = new System.Drawing.Size(190, 32);
            this.telefonoDueño.TabIndex = 14;
            this.telefonoDueño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // raza
            // 
            this.raza.BackColor = System.Drawing.Color.Lime;
            this.raza.Location = new System.Drawing.Point(767, 224);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(190, 37);
            this.raza.TabIndex = 12;
            this.raza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Lime;
            this.especie.Location = new System.Drawing.Point(767, 51);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(190, 37);
            this.especie.TabIndex = 11;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreAmo
            // 
            this.nombreAmo.BackColor = System.Drawing.Color.Lime;
            this.nombreAmo.Location = new System.Drawing.Point(767, 168);
            this.nombreAmo.Name = "nombreAmo";
            this.nombreAmo.Size = new System.Drawing.Size(190, 37);
            this.nombreAmo.TabIndex = 10;
            this.nombreAmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreDueño
            // 
            this.nombreDueño.BackColor = System.Drawing.Color.Lime;
            this.nombreDueño.Location = new System.Drawing.Point(767, 403);
            this.nombreDueño.Name = "nombreDueño";
            this.nombreDueño.Size = new System.Drawing.Size(190, 32);
            this.nombreDueño.TabIndex = 9;
            this.nombreDueño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreMascota
            // 
            this.nombreMascota.BackColor = System.Drawing.Color.Lime;
            this.nombreMascota.Location = new System.Drawing.Point(767, 110);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(190, 37);
            this.nombreMascota.TabIndex = 8;
            this.nombreMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(752, 386);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 120);
            this.label18.TabIndex = 7;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(755, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 237);
            this.label17.TabIndex = 6;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonDueño
            // 
            this.botonDueño.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDueño.Location = new System.Drawing.Point(472, 409);
            this.botonDueño.Name = "botonDueño";
            this.botonDueño.Size = new System.Drawing.Size(238, 67);
            this.botonDueño.TabIndex = 5;
            this.botonDueño.Text = "Buscar dueño";
            this.botonDueño.UseVisualStyleBackColor = true;
            this.botonDueño.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(56, 431);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "DNI del dueño";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(263, 433);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(167, 23);
            this.textBox7.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(263, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 23);
            this.textBox6.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Chip de la mascota";
            // 
            // botonMascota
            // 
            this.botonMascota.BackColor = System.Drawing.Color.Transparent;
            this.botonMascota.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMascota.Location = new System.Drawing.Point(472, 118);
            this.botonMascota.Name = "botonMascota";
            this.botonMascota.Size = new System.Drawing.Size(238, 68);
            this.botonMascota.TabIndex = 0;
            this.botonMascota.Text = "Buscar mascota";
            this.botonMascota.UseVisualStyleBackColor = false;
            this.botonMascota.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_user_1.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_veterinarian.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_search_1.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_calendar_1.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 716);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button usuarioNuevo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button mascotaNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxChip;
        private System.Windows.Forms.TextBox textBoxEnfermedad;
        private System.Windows.Forms.TextBox textBoxCod_Ingreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCoste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNum_Telefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonMascota;
        private System.Windows.Forms.Button botonDueño;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label nombreDueño;
        private System.Windows.Forms.Label nombreMascota;
        private System.Windows.Forms.Label nombreAmo;
        private System.Windows.Forms.Label raza;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label telefonoDueño;
        private System.Windows.Forms.TextBox textBoxEsterilizado;
        private System.Windows.Forms.TextBox textBoxVacunas;
    }
}

