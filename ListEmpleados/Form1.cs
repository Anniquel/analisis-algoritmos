using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEmpleados
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.AgregarEmpleado(txtId.Text, txtName.Text, txtPosition.Text, txtSalary.Text);

            dataGridView1.Rows.Clear();
            foreach (var i in emp.empleados )
            {
                dataGridView1.Rows.Add(
                  i.id,
                  i.nombre,
                  i.cargo,
                  i.sueldo,
                  i.afp,
                  i.sfs,
                  i.descuento,
                  i.sueldoNeto
                  );
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            try
            {
                var em = emp.BuscarEmpleado(txtBusqueda.Text);
                dataGridView1.Rows.Clear();

                dataGridView1.Rows.Add(
              em.id,
              em.nombre,
              em.cargo,
              em.sueldo,
              em.afp,
              em.sfs,
              em.descuento,
              em.sueldoNeto);
            }
            catch
            {
                MessageBox.Show("No se ha podido encontrar el empleado");
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            var lista = emp.empleados;
            dataGridView1.Rows.Clear();

            foreach (var list in lista)
            {
                dataGridView1.Rows.Add(
                list.id,
                list.nombre,
                list.cargo,
                list.sueldo,
                list.afp,
                list.sfs,
                list.descuento,
                list.sueldoNeto);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            try
            {
                emp.EliminarEmpleado(txtBusqueda.Text);
            }
            catch
            {
                MessageBox.Show("No se ha podido encontrar el empleado");
            }
        }
    }
}
