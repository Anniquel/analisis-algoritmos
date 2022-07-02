
namespace PilasYColas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 212);
            this.listBox1.TabIndex = 14;
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEliminarPila.Location = new System.Drawing.Point(27, 338);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(239, 23);
            this.btnEliminarPila.TabIndex = 13;
            this.btnEliminarPila.Text = "Eliminar de la lista pila";
            this.btnEliminarPila.UseVisualStyleBackColor = false;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 28);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Inserte el elmento para la acción";
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPila.Location = new System.Drawing.Point(27, 309);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(239, 23);
            this.btnAgregarPila.TabIndex = 11;
            this.btnAgregarPila.Text = "Añadir a la lista de pila";
            this.btnAgregarPila.UseVisualStyleBackColor = false;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEliminarCola.Location = new System.Drawing.Point(27, 396);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(239, 23);
            this.btnEliminarCola.TabIndex = 16;
            this.btnEliminarCola.Text = "Eliminar de la lista cola";
            this.btnEliminarCola.UseVisualStyleBackColor = false;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarCola.Location = new System.Drawing.Point(27, 367);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(239, 23);
            this.btnAgregarCola.TabIndex = 15;
            this.btnAgregarCola.Text = "Añadir a la lista de cola";
            this.btnAgregarCola.UseVisualStyleBackColor = false;
            this.btnAgregarCola.Click += new System.EventHandler(this.btnAgregarCola_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 152);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(151, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(121, 212);
            this.listBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnEliminarCola);
            this.Controls.Add(this.btnAgregarCola);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEliminarPila);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAgregarPila);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Button btnAgregarCola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

