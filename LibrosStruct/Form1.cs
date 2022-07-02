using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosStruct
{
    public partial class Form1 : Form
    {
        int index = 0;
        struct Libros
        {
            public string titulo;
            public string autor;
            public string editorial;
            public string año;
            public string categoria;
        }
        Libros[] libros = new Libros[20];


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Libros libro = new Libros();
            libro.titulo = txtTitulo.Text;
            libro.autor = txtAutor.Text;
            libro.editorial = txtEditorial.Text;
            libro.año = txtAño.Text;
            libro.categoria = txtCategoria.Text;

            libros[index] = libro;

            dataGridView1.Rows.Add(
            libros[index].titulo,
            libros[index].autor,
            libros[index].editorial,
            libros[index].año,
            libros[index].categoria
            );

            index++;

        }
    }
}
