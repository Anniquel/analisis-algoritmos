using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmpleados
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public double sueldo { get; set; }
        public double afp { get; set; }
        public double sfs { get; set; }
        public double descuento { get; set; }
        public double sueldoNeto { get; set; }

        public List<Empleado> empleados = new List<Empleado>();




        public void AgregarEmpleado(string id, string nombre, string cargo, string sueldo)
        {
            Empleado emp = new Empleado();

            emp.id = Convert.ToInt32(id);
            emp.nombre = nombre;
            emp.cargo = cargo;
            emp.sueldo = Convert.ToDouble(sueldo);
            emp.afp = emp.sueldo * 2.87 / 100;
            emp.sfs = emp.sueldo * 3.04 / 100;
            emp.descuento = emp.afp + emp.sfs;
            emp.sueldoNeto = emp.sueldo - emp.descuento;

            empleados.Add(emp);
        }


        public Empleado BuscarEmpleado(string nombre)
        {
            Empleado emple=null;
            foreach (var emp in empleados)
            {
                if (emp.nombre == nombre)
                {
                    emple = emp;
                }
            }
            return emple;
        }

        public void EliminarEmpleado(string nombre)
        {
            foreach (var emp in empleados)
            {
                if (emp.nombre == nombre)
                {
                    empleados.Remove(emp);

                }
            }
        }

    }
}
