using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public LinkedList<Form1> alumnos = new LinkedList<Form1>();
        public string Nombre { get; set; }
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Mostrar()
        {
            dataGridView1.Rows.Clear();
            foreach (var i in alumnos)
            {
                dataGridView1.Rows.Add(
                  i.Nombre
                  );
            }
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnAgregarPrimero_Click(object sender, EventArgs e)
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;
            alumnos.AddFirst(alumno);
            Mostrar();
        }



        private void btnAgregarUltimo_Click(object sender, EventArgs e)
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;
            alumnos.AddLast(alumno);

            dataGridView1.Rows.Add(alumno.Nombre);
        }


        private void btnMover_Click(object sender, EventArgs e)
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;

            try
            {
                var alumnoAMover = alumnos.FirstOrDefault(a => a.Nombre.Equals(alumno.Nombre));
                alumnos.Remove(alumnoAMover);
                alumnos.AddLast(alumnoAMover);
            }
            catch
            {
                MessageBox.Show("No se ha podido encontrar el alumno");
            }
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;

            try
            {
                var alumnoAEliminar = alumnos.FirstOrDefault(a => a.Nombre.Equals(alumno.Nombre));
                alumnos.Remove(alumnoAEliminar);
            }
            catch
            {
                MessageBox.Show("No se ha podido encontrar el alumno");
            }

            Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Nombre = txtName.Text;
            bool exito = false;
            foreach (var i in alumnos)
            {
                if (Nombre == i.Nombre)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(
                    i.Nombre
                    );
                    exito = true;
                    break;
                }
            }

            if (!exito)
            {
                MessageBox.Show("No se ha podido encontrar el alumno");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
