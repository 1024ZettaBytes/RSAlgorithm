using System;
using System.IO;
using System.Windows.Forms;

namespace RSAlgorithm
{
    public partial class Form1 : Form
    {
        // Se crea una instancia de la clase "RSA" al inicio del programa.
        RSA algoritmo;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            algoritmo = new RSA(); 
        }

        // Se ejecuta cuando se da click en "Generar claves" en la barra de menu. Genera claves de cifrado nuevas. 
        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Calcula las claves.
            algoritmo.calcularClaves();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void clavesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Se ejecuta cuando se da click en "Exportar" en la barra de menu. Guarda el archivo de claves
        // con extensión ".Akeys".
        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guarda = new SaveFileDialog();
            guarda.Title = "Guardar archivo de claves";
            guarda.Filter= "Archivos de claves de RSAlgorithm|*.Akeys|Todos los archivos|*.*";
            
         
            
            guarda.DefaultExt = "Akeys";
            guarda.AddExtension = true;
            if (guarda.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(guarda.FileName))
                {
                    File.Delete(guarda.FileName);
                }
                FileStream fs = new FileStream(guarda.FileName, FileMode.CreateNew);
                BinaryWriter archivo = new BinaryWriter(fs);
                archivo.Write("ES VALIDO");
                archivo.Write(algoritmo.getE());
                archivo.Write(algoritmo.getD());
                archivo.Write(algoritmo.getN());
                archivo.Flush();
                archivo.Close();
            }


        }
        // Habilitan los botones para cifrar y descifrar mientras los campos de texto no estén vacios.
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            botonCifrar.Enabled = !(textBoxACifrar.Text == "");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            botonDescifrar.Enabled = !(textBoxADescifrar.Text == "");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////


        // Se ejecuta cuando se da click en el boton "Cifrar". Manda llamar al método para cifrar la cadena ingresada
        // y la muestra.
        private void botonCifrar_Click(object sender, EventArgs e)
        {
            textBoxCifrado.Text = algoritmo.cifrar(textBoxACifrar.Text);
        }
        // Se ejecuta cuando se da click en el boton "Descifrar". Manda llamar al método para descifrar la cadena ingresada
        // y la muestra.
        private void botonDescifrar_Click(object sender, EventArgs e)
        {
            textBoxDescifrado.Text = algoritmo.descifrar(textBoxADescifrar.Text);
        }
        // Se ejecuta cuando se da click en "Importar" en la barra de menu. Permite al usuario seleccionar el archivo de claves.
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog importa = new OpenFileDialog();
            FileStream fs;
            importa.Title = "Abrir archivo de claves";
            importa.Filter= "Archivos de claves de RSAlgorithm|*.Akeys|Todos los archivos|*.*";
            
            if (importa.ShowDialog() == DialogResult.OK)
            {
                
                fs = new FileStream(importa.FileName, FileMode.Open, FileAccess.Read) ;
                BinaryReader br = new BinaryReader(fs);
                try
                {
                    if (br.ReadString() == "ES VALIDO")
                    {
                        algoritmo.setE(br.ReadInt32());
                        algoritmo.setD(br.ReadInt32());
                        algoritmo.setN(br.ReadInt32());

                        textBoxACifrar.Enabled = true;
                        textBoxADescifrar.Enabled = true;
                        exportarToolStripMenuItem.Enabled = true;
                    }
                    else
                        MessageBox.Show("ERROR. No es un archivo de claves válido.");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("ERROR. No es un archivo de claves válido.");
                }
                br.Close();
            }
            

        }
        // Se ejecuta cuando se da click en "Acerca de" en la barra de menu.
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tJesús Eduardo Ramírez Cota ISW\r\n\r\n\tSeguridad informática 3:00 PM");
        }

        // Se ejecuta cuando se da click en el boton de la pantalla inicial. Genera claves de cifrado nuevas y habilita los campos de texto. 
        private void botonInicial_Click(object sender, EventArgs e)
        {
            botonInicial.Visible = false;
            panel1.Visible = false;
            // Calcula las calves.
            algoritmo.calcularClaves();
            // Habilita los campos de texto y la opción para exportar las claves generadas.
            exportarToolStripMenuItem.Enabled = true;
            textBoxACifrar.Enabled = true;
            textBoxADescifrar.Enabled = true;
        }
    }
}
