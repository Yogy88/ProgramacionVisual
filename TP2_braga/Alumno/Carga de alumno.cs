using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno
{
    public partial class CargaAlumnos : Form
    {
        List<Alumno> alumnos = new List<Alumno>();

        public CargaAlumnos()
        {
            InitializeComponent();
        }

        private void botonguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Alumno a = new Alumno();

                a.Nombre = ingresoNombre.Text;

                a.Apellido = ingresoApellido.Text;

                a.DNI = ingresoDNI.Text;

                a.Legajo = ingresoLegajo.Text;

                a.Carrera = (String)comboCarrera.SelectedItem;

                a.añoInscrip = PickerAñoInscripcion.Value;

                alumnos.Add(a);

                MessageBox.Show("Alumno " + a.Nombre + " " + a.Apellido + "agregado correctamente");

                Mostrar_cantidad();

                Limpiar_box();
            }
            else
            {
                MessageBox.Show("Error en el ingreso de los datos");
            }
        }

       public bool Validar ()
        {
            //valida si los datos ingresados por el usuario son correctos
            bool datovalido;
            datovalido = true;

            if (ingresoNombre.Text.Trim() == "")
            {
                MessageBox.Show(ingresoNombre,"Nombre Vacio") ;
                ingresoNombre.Focus();
                datovalido = false;
            }

            if (ingresoApellido.Text.Trim() == "")
            {
                MessageBox.Show(ingresoApellido,"Apellido Vacio");
                ingresoApellido.Focus();
                datovalido = false;
            }

            if (ingresoDNI.Text.Trim() == "")
            {
                MessageBox.Show(ingresoDNI, "DNI Vacio");
                ingresoDNI.Focus();
                datovalido = false;
            }

            if (ingresoLegajo.Text.Trim() == "")
            {
                MessageBox.Show(ingresoLegajo, "Legajo Vacio");
                ingresoLegajo.Focus();
                datovalido = false;
            }

            return datovalido;
        }

        private void CargaAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CargaAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar_box();
        }

        public void Limpiar_box ()
        {
            //para limpiar el texto despues de guardar

            ingresoNombre.Clear();
            ingresoApellido.Clear();
            ingresoDNI.Clear();
            ingresoLegajo.Clear();
            
        }

        public void Mostrar_cantidad()
        {
            MessageBox.Show("Total de alumnos ingresados: " + alumnos.Count);
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_cantidad();
        }

        private void comboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
