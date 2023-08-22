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


namespace Biblioteca
{
    public partial class CargaLibros : Form
    {
        List<Libro> Libros = new List<Libro>();

        public CargaLibros()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Server=(local); Initial Catalog=Biblioteca; Integrated Security = true");
        //en el caso de la pc original use la siguiente coneccion
        //SqlConnection conexion = new SqlConnection ("Data Source=ESCRITORIO-YOGY\\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security = true");

        public void RefrescarTabla ()
        {
            DGVLibro.AllowUserToAddRows = false;

            SqlCommand Adaptador = new SqlCommand("select * from Biblioteca", conexion);
            DataTable dt = new DataTable();
            //Adaptador.Fill(dt);
            DGVLibro.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Libro a = new Libro();

            a.Título = textBoxTitulo.Text;

            a.Autor = textBoxAutor.Text;

            a.ISBN = Convert.ToInt32(textBoxISBN.Text);

            a.Cantidad_de_Páginas = Convert.ToInt32(textBoxPaginas.Text);

            a.Edicion = Convert.ToInt32(textBoxEdicion.Text);

            a.Editorial = textBoxEditorial.Text;

            a.Lugar = textBoxLugar.Text;

            a.FechaEdicion = dateTimePickerFECHAedicion.Value;


            //datagridview

            int n = DGVLibro.Rows.Add(); //adiciona un renglon

            //colocamos la informacion en la tabla

            DGVLibro.Rows[n].Cells[0].Value = a.Título;

            DGVLibro.Rows[n].Cells[1].Value = a.Autor;

            DGVLibro.Rows[n].Cells[2].Value = a.ISBN;

            DGVLibro.Rows[n].Cells[3].Value = a.Cantidad_de_Páginas;

            DGVLibro.Rows[n].Cells[4].Value = a.Edicion;

            DGVLibro.Rows[n].Cells[5].Value = a.Editorial;

            DGVLibro.Rows[n].Cells[6].Value = a.Lugar;

            DGVLibro.Rows[n].Cells[7].Value = a.FechaEdicion;

            SqlCommand Agregar = new SqlCommand("insert into Biblioteca values (@Titulo, @Autor, @ISBN, @Cantidad_de_paginas, @Edicion, @Editorial, @Lugar, @FechaEdicion) ", conexion);
            conexion.Open();

            try
            {
                foreach (DataGridViewRow row in DGVLibro.Rows)
                {
                    Agregar.Parameters.Clear();

                    Agregar.Parameters.AddWithValue("@Titulo",Convert.ToString(row.Cells["Column1"].Value));
                    Agregar.Parameters.AddWithValue("@Autor", Convert.ToString(row.Cells["Column2"].Value));
                    Agregar.Parameters.AddWithValue("@ISBN", Convert.ToInt32(row.Cells["Column3"].Value));
                    Agregar.Parameters.AddWithValue("@Cantidad_de_paginas", Convert.ToInt32(row.Cells["Column4"].Value));
                    Agregar.Parameters.AddWithValue("@Edicion", Convert.ToInt32(row.Cells["Column5"].Value));
                    Agregar.Parameters.AddWithValue("@Editorial", Convert.ToString(row.Cells["Column6"].Value));
                    Agregar.Parameters.AddWithValue("@Lugar", Convert.ToString(row.Cells["Column7"].Value));
                    Agregar.Parameters.AddWithValue("@FechaEdicion", Convert.ToString(row.Cells["Column8"].Value));

                    Agregar.ExecuteNonQuery();

                    MessageBox.Show("Libro agregado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar libro");
            }
            finally
            {
                conexion.Close();
            }

            RefrescarTabla();

            //Limpieza



            textBoxTitulo.Clear ();

            textBoxAutor.Clear ();

            textBoxISBN.Clear();

            textBoxPaginas.Clear();

            textBoxEdicion.Clear();

            textBoxEditorial.Clear();

            textBoxLugar.Clear();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargaLibros_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand update = new SqlCommand("update Biblioteca set Titulo =" +textBoxTitulo+",Autor= "+textBoxAutor+", ISBN="+textBoxISBN + ", Cantidad_de_paginas= "+textBoxPaginas+", Edicion="+textBoxEdicion+", Editorial="+textBoxEditorial+", Lugar= "+textBoxLugar+", FechaEdicion="+dateTimePickerFECHAedicion+") ", conexion);
            

            try
            {
                foreach (DataGridViewRow row in DGVLibro.Rows)
                {
                    update.Parameters.Clear();

                    update.Parameters.AddWithValue("@Titulo", Convert.ToString(row.Cells["Column1"].Value));
                    update.Parameters.AddWithValue("@Autor", Convert.ToString(row.Cells["Column2"].Value));
                    update.Parameters.AddWithValue("@ISBN", Convert.ToInt32(row.Cells["Column3"].Value));
                    update.Parameters.AddWithValue("@Cantidad_de_paginas", Convert.ToInt32(row.Cells["Column4"].Value));
                    update.Parameters.AddWithValue("@Edicion", Convert.ToInt32(row.Cells["Column5"].Value));
                    update.Parameters.AddWithValue("@Editorial", Convert.ToString(row.Cells["Column6"].Value));
                    update.Parameters.AddWithValue("@Lugar", Convert.ToString(row.Cells["Column7"].Value));
                    update.Parameters.AddWithValue("@FechaEdicion", Convert.ToString(row.Cells["Column8"].Value));

                    update.ExecuteNonQuery();

                    MessageBox.Show("Libro modificado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar libro");
            }
            finally
            {
                conexion.Close();
            }

            RefrescarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand borrar = new SqlCommand("delete from Biblioteca where Titulo =" + textBoxTitulo + ",Autor= " + textBoxAutor + ", ISBN=" + textBoxISBN + ", Cantidad_de_paginas= " + textBoxPaginas + ", Edicion=" + textBoxEdicion + ", Editorial=" + textBoxEditorial + ", Lugar= " + textBoxLugar + ", FechaEdicion=" + dateTimePickerFECHAedicion + ") ", conexion);
            RefrescarTabla();
            conexion.Close();

        }
    }
}
