using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qatar_2022
{
    public partial class Cargapaises : Form
    {
        List<Pais> paises = new List<Pais>();

        bool datovalido;

        public Cargapaises()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=(local); Initial Catalog=Qatar; Integrated Security = true");

        public void Limpiar_box ()//limpia los datos aun no guardados
        {
            ingresoNombre.Clear();
            ingresocontinente.Clear();
            ingresoranquing.Clear();
            ingresohabitantes.Clear();
            comboGanador.ResetText();
            comboparticipaciones.ResetText();

        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_box();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonbajar_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ganomundiales = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ingresoNombre = new System.Windows.Forms.TextBox();
            this.ingresocontinente = new System.Windows.Forms.TextBox();
            this.ingresoranquing = new System.Windows.Forms.TextBox();
            this.ingresohabitantes = new System.Windows.Forms.TextBox();
            this.comboGanador = new System.Windows.Forms.ComboBox();
            this.comboparticipaciones = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVPais = new System.Windows.Forms.DataGridView();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cuantos = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Participo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.botonguardar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.bajarranking = new System.Windows.Forms.Button();
            this.AgregarMundial = new System.Windows.Forms.Button();
            this.SubirRanking = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.textBoxbuscador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciones incluidas en el Mundial Qatar 2022";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(191, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(149, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Continente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(149, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ranking FiFA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(177, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Habitantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(36, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Es su primer participacion?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ganomundiales
            // 
            this.Ganomundiales.AutoSize = true;
            this.Ganomundiales.BackColor = System.Drawing.Color.Transparent;
            this.Ganomundiales.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ganomundiales.ForeColor = System.Drawing.Color.Olive;
            this.Ganomundiales.Location = new System.Drawing.Point(198, 316);
            this.Ganomundiales.Name = "Ganomundiales";
            this.Ganomundiales.Size = new System.Drawing.Size(45, 21);
            this.Ganomundiales.TabIndex = 7;
            this.Ganomundiales.Text = "Si";
            this.Ganomundiales.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(58, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "¿Gano mundiales?";
            // 
            // ingresoNombre
            // 
            this.ingresoNombre.Location = new System.Drawing.Point(436, 111);
            this.ingresoNombre.Name = "ingresoNombre";
            this.ingresoNombre.Size = new System.Drawing.Size(144, 23);
            this.ingresoNombre.TabIndex = 9;
            // 
            // ingresocontinente
            // 
            this.ingresocontinente.Location = new System.Drawing.Point(435, 162);
            this.ingresocontinente.Name = "ingresocontinente";
            this.ingresocontinente.Size = new System.Drawing.Size(145, 23);
            this.ingresocontinente.TabIndex = 10;
            // 
            // ingresoranquing
            // 
            this.ingresoranquing.Location = new System.Drawing.Point(435, 220);
            this.ingresoranquing.Name = "ingresoranquing";
            this.ingresoranquing.Size = new System.Drawing.Size(145, 23);
            this.ingresoranquing.TabIndex = 11;
            // 
            // ingresohabitantes
            // 
            this.ingresohabitantes.Location = new System.Drawing.Point(435, 271);
            this.ingresohabitantes.Name = "ingresohabitantes";
            this.ingresohabitantes.Size = new System.Drawing.Size(145, 23);
            this.ingresohabitantes.TabIndex = 12;
            // 
            // comboGanador
            // 
            this.comboGanador.FormattingEnabled = true;
            this.comboGanador.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.comboGanador.Location = new System.Drawing.Point(435, 312);
            this.comboGanador.Name = "comboGanador";
            this.comboGanador.Size = new System.Drawing.Size(65, 23);
            this.comboGanador.TabIndex = 13;
            // 
            // comboparticipaciones
            // 
            this.comboparticipaciones.FormattingEnabled = true;
            this.comboparticipaciones.Items.AddRange(new object[] {
            "SI",
            "No"});
            this.comboparticipaciones.Location = new System.Drawing.Point(436, 361);
            this.comboparticipaciones.Name = "comboparticipaciones";
            this.comboparticipaciones.Size = new System.Drawing.Size(64, 23);
            this.comboparticipaciones.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(520, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "¿Cuantos?";
            // 
            // DGVPais
            // 
            this.DGVPais.AllowUserToAddRows = false;
            this.DGVPais.AllowUserToDeleteRows = false;
            this.DGVPais.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pais,
            this.Continente,
            this.Ranking,
            this.Habitantes,
            this.dataGridViewCheckBoxColumn1,
            this.Cuantos,
            this.Participo});
            this.DGVPais.Location = new System.Drawing.Point(639, 246);
            this.DGVPais.Name = "DGVPais";
            this.DGVPais.ReadOnly = true;
            this.DGVPais.RowTemplate.Height = 25;
            this.DGVPais.Size = new System.Drawing.Size(332, 268);
            this.DGVPais.TabIndex = 16;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // Continente
            // 
            this.Continente.HeaderText = "Continente";
            this.Continente.Name = "Continente";
            this.Continente.ReadOnly = true;
            // 
            // Ranking
            // 
            this.Ranking.HeaderText = "Ranking";
            this.Ranking.Name = "Ranking";
            this.Ranking.ReadOnly = true;
            // 
            // Habitantes
            // 
            this.Habitantes.HeaderText = "Habitantes";
            this.Habitantes.Name = "Habitantes";
            this.Habitantes.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Gano mundiales";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // Cuantos
            // 
            this.Cuantos.HeaderText = "Cuantos";
            this.Cuantos.Name = "Cuantos";
            this.Cuantos.ReadOnly = true;
            // 
            // Participo
            // 
            this.Participo.HeaderText = "Participo antes";
            this.Participo.Name = "Participo";
            this.Participo.ReadOnly = true;
            // 
            // botonguardar
            // 
            this.botonguardar.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonguardar.ForeColor = System.Drawing.Color.Olive;
            this.botonguardar.Location = new System.Drawing.Point(501, 402);
            this.botonguardar.Name = "botonguardar";
            this.botonguardar.Size = new System.Drawing.Size(98, 31);
            this.botonguardar.TabIndex = 17;
            this.botonguardar.Text = "Agregar";
            this.botonguardar.UseVisualStyleBackColor = true;
            this.botonguardar.Click += new System.EventHandler(this.botonguardar_Click_1);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonEliminar.ForeColor = System.Drawing.Color.Olive;
            this.botonEliminar.Location = new System.Drawing.Point(501, 483);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(98, 31);
            this.botonEliminar.TabIndex = 18;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.LimpiarButton_Click_1);
            // 
            // bajarranking
            // 
            this.bajarranking.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bajarranking.ForeColor = System.Drawing.Color.Olive;
            this.bajarranking.Location = new System.Drawing.Point(795, 154);
            this.bajarranking.Name = "bajarranking";
            this.bajarranking.Size = new System.Drawing.Size(163, 31);
            this.bajarranking.TabIndex = 20;
            this.bajarranking.Text = "Bajar Ranking Fifa";
            this.bajarranking.UseVisualStyleBackColor = true;
            this.bajarranking.Click += new System.EventHandler(this.bajarranking_Click);
            // 
            // AgregarMundial
            // 
            this.AgregarMundial.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgregarMundial.ForeColor = System.Drawing.Color.Olive;
            this.AgregarMundial.Location = new System.Drawing.Point(608, 103);
            this.AgregarMundial.Name = "AgregarMundial";
            this.AgregarMundial.Size = new System.Drawing.Size(163, 31);
            this.AgregarMundial.TabIndex = 21;
            this.AgregarMundial.Text = "Agregar Mundial";
            this.AgregarMundial.UseVisualStyleBackColor = true;
            this.AgregarMundial.Click += new System.EventHandler(this.AgregarMundial_Click);
            // 
            // SubirRanking
            // 
            this.SubirRanking.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubirRanking.ForeColor = System.Drawing.Color.Olive;
            this.SubirRanking.Location = new System.Drawing.Point(795, 103);
            this.SubirRanking.Name = "SubirRanking";
            this.SubirRanking.Size = new System.Drawing.Size(163, 31);
            this.SubirRanking.TabIndex = 19;
            this.SubirRanking.Text = "Subir Ranking Fifa";
            this.SubirRanking.UseVisualStyleBackColor = true;
            this.SubirRanking.Click += new System.EventHandler(this.SubirRanking_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonModificar.ForeColor = System.Drawing.Color.Olive;
            this.botonModificar.Location = new System.Drawing.Point(501, 439);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(98, 31);
            this.botonModificar.TabIndex = 22;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // textBoxbuscador
            // 
            this.textBoxbuscador.Location = new System.Drawing.Point(198, 504);
            this.textBoxbuscador.Name = "textBoxbuscador";
            this.textBoxbuscador.Size = new System.Drawing.Size(144, 23);
            this.textBoxbuscador.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(36, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Buscador de paises";
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonbuscar.ForeColor = System.Drawing.Color.Olive;
            this.buttonbuscar.Location = new System.Drawing.Point(361, 497);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(99, 34);
            this.buttonbuscar.TabIndex = 25;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // Cargapaises
            // 
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::Qatar_2022.Properties.Resources.QFMYH4JZPBF4PIWJZF7RXXDEXY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1007, 567);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxbuscador);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.bajarranking);
            this.Controls.Add(this.AgregarMundial);
            this.Controls.Add(this.SubirRanking);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonguardar);
            this.Controls.Add(this.DGVPais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboparticipaciones);
            this.Controls.Add(this.comboGanador);
            this.Controls.Add(this.ingresohabitantes);
            this.Controls.Add(this.ingresoranquing);
            this.Controls.Add(this.ingresocontinente);
            this.Controls.Add(this.ingresoNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ganomundiales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.Name = "Cargapaises";
            this.Text = "Mundial Qatar \"022";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SubirRanking_Click(object sender, EventArgs e)
        {
            if (ingresoNombre.Text.Trim() == "")
            {
                MessageBox.Show(ingresoNombre, "Ingrese Nombre para modificacion");
                ingresoNombre.Focus();

            }
            else
            {
                
            }
            
        }

        private void AgregarMundial_Click(object sender, EventArgs e)
        {
            if (ingresoNombre.Text.Trim() == "")
            {
                MessageBox.Show(ingresoNombre, "Ingrese Nombre para modificacion");
                ingresoNombre.Focus();
                
            }
            else
            {

            }
        }

        private void bajarranking_Click(object sender, EventArgs e)
        {
            if (ingresoNombre.Text.Trim() == "")
            {
                MessageBox.Show(ingresoNombre, "Ingrese Nombre para modificacion");
                ingresoNombre.Focus();

            }
            else
            {

            }
        }

        public bool Validar()
        {
            //valida si los datos ingresados por el usuario son correctos

            datovalido = true;

            if (ingresoNombre.Text.Trim() == "")
            {
                MessageBox.Show(ingresoNombre, "Nombre Vacio");
                ingresoNombre.Focus();
                datovalido = false;
            }

            if (ingresocontinente.Text.Trim() == "")
            {
                MessageBox.Show(ingresocontinente, "Continente Vacio");
                ingresocontinente.Focus();
                datovalido = false;
            }

            if (ingresoranquing.Text.Trim() == "")
            {
                MessageBox.Show(ingresoranquing, "Ranquing Vacio");
                ingresoranquing.Focus();
                datovalido = false;
            }

            if (ingresohabitantes.Text.Trim() == "")
            {
                MessageBox.Show(ingresohabitantes, "Cantidad de habitantes Vacio");
                ingresohabitantes.Focus();
                datovalido = false;
            }

            if ((String)comboGanador.SelectedItem == "")
            {
                MessageBox.Show(comboGanador, "Ingrese mundiales ganados");
                comboGanador.Focus();
                datovalido = false;
            }


            if (Ganomundiales.Checked == true && (String)comboparticipaciones.SelectedItem == "")
            {

                MessageBox.Show(comboparticipaciones, "Seleccione las veces que participo en un mundial");
                comboparticipaciones.Focus();
                datovalido = false;

            }


            return datovalido;
        }

        public void RefrescarTabla()
        {
            DGVPais.AllowUserToAddRows = false;

            SqlCommand Adaptador = new SqlCommand("select * from Biblioteca", conexion);
            DataTable dt = new DataTable();
            //Adaptador.Fill(dt);
            DGVPais.DataSource = dt;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {

        }

        private void botonguardar_Click_1(object sender, EventArgs e)
        {
            Validar();

            if (datovalido == true)
            {
                Pais a = new Pais();

                a.Nombre = ingresoNombre.Text;

                a.Continente = ingresocontinente.Text;

                a.Ranquing = Convert.ToInt32(ingresoranquing.Text);

                a.habitantes = Convert.ToInt32(ingresohabitantes.Text);

                a.Ganador = (String)comboGanador.SelectedItem; //combobox

                a.Participaciones = (String)comboparticipaciones.SelectedItem; //combobox


                paises.Add(a);


                #region datagridview

                int n = DGVPais.Rows.Add();

                DGVPais.Rows[n].Cells[0].Value = a.Nombre;
                DGVPais.Rows[n].Cells[0].Value = a.Continente;
                DGVPais.Rows[n].Cells[0].Value = a.Ranquing;
                DGVPais.Rows[n].Cells[0].Value = a.habitantes;
                DGVPais.Rows[n].Cells[0].Value = a.Ganador;
                DGVPais.Rows[n].Cells[0].Value = a.Participaciones;

                SqlCommand Agregar = new SqlCommand("insert into Qatar values (@Nombre, @Continente, @Ranquing, @habitantes, @Ganador, @Participaciones) ", conexion);
                conexion.Open();

                try
                {
                    foreach (DataGridViewRow row in DGVPais.Rows)
                    {
                        Agregar.Parameters.Clear();

                        Agregar.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["Column1"].Value));
                        Agregar.Parameters.AddWithValue("@Continente", Convert.ToString(row.Cells["Column2"].Value));
                        Agregar.Parameters.AddWithValue("@Ranquing", Convert.ToInt32(row.Cells["Column3"].Value));
                        Agregar.Parameters.AddWithValue("@habitantes", Convert.ToInt32(row.Cells["Column4"].Value));
                        Agregar.Parameters.AddWithValue("@Ganador", Convert.ToString(row.Cells["Column5"].Value));
                        Agregar.Parameters.AddWithValue("@Participaciones", Convert.ToString(row.Cells["Column6"].Value));

                        Agregar.ExecuteNonQuery();

                        MessageBox.Show("Pais agregado correctamente a la base de datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar pais a la base de datos");
                }
                finally
                {
                    conexion.Close();
                }

                RefrescarTabla();


                #endregion

                Limpiar_box();
                
            }
            else
            {
                MessageBox.Show("Error en el ingreso de los pais a la base de datos");
            }
        }

        private void LimpiarButton_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand borrar = new SqlCommand("delete from Qatar where Nombre =" + ingresoNombre.Text + ",Continente= " + ingresocontinente.Text + ", Ranquing=" + ingresoranquing.Text + ", Habitantes= " + ingresohabitantes.Text + ", Ganador=" + comboGanador.SelectedItem + ", Participaciones=" + comboparticipaciones.SelectedItem +") ", conexion);
            RefrescarTabla();
            conexion.Close();

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand update = new SqlCommand("update Qatar set Nombre =" + ingresoNombre.Text + ",Continente= " + ingresocontinente.Text + ", Ranquing=" + ingresoranquing.Text + ", Habitantes= " + ingresohabitantes.Text + ", Ganador=" + comboGanador.SelectedItem + ", Participaciones=" + comboparticipaciones.SelectedItem + ") ", conexion);
            

            try
            {
                foreach (DataGridViewRow row in DGVPais.Rows)
                {
                    update.Parameters.Clear();

                    update.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["Column1"].Value));
                    update.Parameters.AddWithValue("@Continente", Convert.ToString(row.Cells["Column2"].Value));
                    update.Parameters.AddWithValue("@Ranquing", Convert.ToInt32(row.Cells["Column3"].Value));
                    update.Parameters.AddWithValue("@habitantes", Convert.ToInt32(row.Cells["Column4"].Value));
                    update.Parameters.AddWithValue("@Ganador", Convert.ToString(row.Cells["Column5"].Value));
                    update.Parameters.AddWithValue("@Participaciones", Convert.ToString(row.Cells["Column6"].Value));

                    update.ExecuteNonQuery();

                    MessageBox.Show("Pais modificado correctamente en la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar pais en la base de datos");
            }
            finally
            {
                conexion.Close();
            }

            RefrescarTabla();


            Limpiar_box();
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand("SELECT FROM Qatar WHERE Nombre LIKE % + textBoxbuscador.Text + % + ") ", conexion);

        }
    }

}
