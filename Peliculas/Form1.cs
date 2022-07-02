using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosForms
{
    public partial class Form1 : Form
    {
        int index = 0;

        public Form1[] Peliculas = new Form1[20];

        public string titulo { get; set; }
        public string director { get; set; }
        public string escritor { get; set; }
        public string genero { get; set; }
        public string duracion { get; set; }
        public string clasificacion { get; set; }
        public string productora { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 pelicula = new Form1();
            pelicula.titulo = textBox1.Text;
            pelicula.director = textBox2.Text;
            pelicula.escritor = textBox3.Text;
            pelicula.genero = textBox4.Text;
            pelicula.duracion = textBox5.Text;
            pelicula.clasificacion = textBox6.Text;
            pelicula.productora = textBox7.Text;

           Peliculas[index] = pelicula;

            dataGridView1.Rows.Add(
            Peliculas[index].titulo,
            Peliculas[index].director,
            Peliculas[index].escritor,
            Peliculas[index].genero,
            Peliculas[index].duracion,
            Peliculas[index].clasificacion,
            Peliculas[index].productora);

             index ++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("C:/Users/HP/OneDrive - Universidad Central del Este/Contenido y Asignaciones/9no Semestre/Optimización de Algoritmos/prueba.txt", false))
            {
                int i = 0;

                foreach(var el in Peliculas)          
                {
                    writer.WriteLine(
                        "Listado de peliculas \n\n"+
                        $"Pelicula  {i + 1}:\n\n"
                    + $"{el.titulo}\n"
                    + $"{el.director}\n"
                    + $"{el.escritor}\n"
                    + $"{el.genero}\n"
                    + $"{el.duracion}\n"
                    + $"{el.clasificacion}\n"
                    + $"{el.productora}\n"
                    );

                    i++;
                }

                writer.Close();
            }
        }
    }
}
