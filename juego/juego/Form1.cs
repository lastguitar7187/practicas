using System.Drawing.Text;
using System.Runtime.Intrinsics.X86;

namespace juego
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Piedra");
            comboBox1.Items.Add("Papel");
            comboBox1.Items.Add("Tijeras");
            comboBox1.Items.Add("C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\piedra.jpeg");
            comboBox1.Items.Add("C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\papel.png");
            comboBox1.Items.Add("C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\tijeras.jpg");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Jugador us = new Usuario();
            Jugador pc = new Maquina();

            int seleccion = random.Next(0, 3);
            string rutaimagen = "C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\piedra.jpeg";
            string rutaimagen1 = "C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\papel.png";
            string rutaimagen2 = "C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\tijeras.jpg";

            switch (seleccion)
            {
                case 0:
                    pc.jugar(new Piedra());
                    pictureBox2.Image = Image.FromFile(rutaimagen); 
                    none.Text = "Piedra";break;
                case 1:
                    pc.jugar(new Papel());
                    pictureBox2.Image = Image.FromFile(rutaimagen1);
                    none.Text = "Papel"; break;
                case 2:
                    pc.jugar(new Tijera());
                    pictureBox2.Image = Image.FromFile(rutaimagen2);
                    none.Text = "Tijeras "; break;
            }
            if (comboBox1.Text == "Tijeras" && seleccion==0)
            {
                MessageBox.Show("perdiste");
            }
            if (comboBox1.Text == "Piedra" && seleccion == 0)
            {
                MessageBox.Show("empate");
            }
            if (comboBox1.Text == "Papel" && seleccion == 0)
            {
                MessageBox.Show("ganaste");
            }

            if (comboBox1.Text == "Tijeras" && seleccion == 1)
            {
                MessageBox.Show("ganaste");
            }
            if (comboBox1.Text == "Piedra" && seleccion == 1)
            {
                MessageBox.Show("perdiste");
            }
            if (comboBox1.Text == "Papel" && seleccion == 1)
            {
                MessageBox.Show("empate");
            }

            if (comboBox1.Text == "Tijeras" && seleccion == 2)
            {
                MessageBox.Show("empate");
            }
            if (comboBox1.Text == "Piedra" && seleccion == 2)
            {
                MessageBox.Show("ganaste");
            }
            if (comboBox1.Text == "Papel" && seleccion == 2)
            {
                MessageBox.Show("ganaste");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void none_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar el Label con la selección
            if (comboBox1.SelectedItem != null)
            {
                label1.Text = comboBox1.SelectedItem.ToString();
            }

            string opcionSeleccionada = comboBox1.SelectedItem.ToString();

                switch (opcionSeleccionada)
                {
                    case "Tijeras":
                        pictureBox1.Image = Image.FromFile("C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\tijeras.jpg"); 
                        break;
                    case "Papel":
                        pictureBox1.Image = Image.FromFile("C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\papel.png"); 
                        break;
                    case "Piedra":
                        pictureBox1.Image = Image.FromFile("C:\\Users\\alan3\\OneDrive\\Escritorio\\juego\\piedra.jpeg");
                        break;
                }
       
        }
    }
}
