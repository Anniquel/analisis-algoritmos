using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasYColas
{
    public partial class Form1 : Form
    {
        public Stack<string> Pila = new Stack<string>();
        Queue<string> Cola = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }


        public void MostrarPila()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Pila.Count; i++)
            {
                listBox1.Items.Add(Pila.ElementAt(i));
            }
        }

        public void MostrarCola()
        {
            listBox2.Items.Clear();
            for (int i = 0; i < Cola.Count; i++)
            {
                listBox2.Items.Add(Cola.ElementAt(i));
            }
        }


        //METODOS AGREGAR Y ELIMINAR DE LA LISTA DE LA PILA... ELEMENTOS SE REPRESENTAN EN EL LISTBOX1 
        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            Pila.Push(textBox1.Text);
            MostrarPila();
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            Pila.Pop();
            MostrarPila();
        }

        //METODOS AGREGAR Y ELIMINAR DE LA LISTA DE LA COLA.. ELEMENTOS SE REPRESENTAN EN EL LISTBOX2

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            Cola.Enqueue(textBox1.Text);
            MostrarCola();
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            Cola.Dequeue();
            MostrarCola();
        }
    }
}
