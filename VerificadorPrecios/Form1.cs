using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VerificadorPrecios
{
    
    public partial class Form1 : Form
    {
        private int segundos = 0;
        private String codigo = "";
        private Point label1OriginalLocation;
        private Point picturebox2OriginalLocation;

        private bool pEncontrado = true;

        private MySqlDataReader result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width / 2, 
                Screen.PrimaryScreen.WorkingArea.Height / 2);

            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2,
                this.Height / 4 - pictureBox1.Height);

            picturebox2OriginalLocation = new Point(this.Width / 2 - pictureBox2.Width / 2,
                this.Height / 2 - pictureBox2.Height / 2);
            pictureBox2.Location = picturebox2OriginalLocation;

            label1OriginalLocation = new Point(this.Width / 2 - (label1.Width / 2),
                this.Height / 2 + pictureBox2.Height + 20);
            label1.Location = label1OriginalLocation;

            precio.Visible = false;
            
            stock.Visible = false;
            
            pImagen.Visible = false;

            barcode.Visible = false;
           

            pCodigo.Visible = false;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                //database connection
                try
                {
                    MySqlConnection server;
                    server = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL Mode=None;");
                    server.Open();
                    String queryString = "SELECT producto_codigo, producto_nombre, producto_cantidad_disponible, producto_precio, producto_imagen " +
                        "FROM productos WHERE producto_codigo = " + codigo + ";";
                    MySqlCommand query = new MySqlCommand(queryString, server);
                    result = query.ExecuteReader();

                    if (result.HasRows)
                    {

                        label1.Text = "Cargando la información del producto";
                        label1.Location = new Point(this.Width / 2 - (label1.Width / 2),
                            this.Height / 4 + label1.Height + 30);

                        pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.loading_56;
                        pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2,
                            this.Height / 2 + pictureBox2.Height / 2);
                        pictureBox2.Visible = true;

                        segundos = 0;
                        timer1.Enabled = true;

                        precio.Visible = false;
                        stock.Visible = false;
                        pImagen.Visible = false;
                        barcode.Visible = false;
                        pCodigo.Visible = false;
                    }
                    else
                    {
                        pEncontrado = false;

                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));

                        label1.Text = "Producto no encontrado";
                        label1.Location = new Point(this.Width / 2 - (label1.Width / 2),
                            this.Height / 4 + label1.Height + 30);

                        pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.error;
                        pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2,
                            this.Height / 2 + pictureBox2.Height / 2);
                        pictureBox2.Visible = true;

                        segundos = 0;
                        timer1.Enabled = true;

                        precio.Visible = false;
                        stock.Visible = false;
                        pImagen.Visible = false;
                        barcode.Visible = false;
                        pCodigo.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 2 && pEncontrado)
            {
                result.Read();

                label1.Text = result.GetString(1);
                label1.Location = new Point((this.Width / 4)*3 - (label1.Width / 2), 
                    this.Height / 4 + label1.Height);

                precio.Text = "$" + result.GetString(3);
                precio.Location = new Point((this.Width / 4) * 3 - (precio.Width / 2),
                    this.Height / 4 + label1.Height + precio.Height + 30);
                precio.Visible = true;

                stock.Text = "Stock: " + result.GetString(2);
                stock.Location = new Point((this.Width / 4) * 3 - (stock.Width / 4),
                    (this.Height / 4) * 3 - stock.Height);
                stock.Visible = true;

                pImagen.ImageLocation = result.GetString(4);
                pImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pImagen.Location = new Point((this.Width / 4) - (pImagen.Width / 2),
                    (this.Height / 2) - pImagen.Height / 2 + 30);
                pImagen.Visible = true;

                barcode.Visible = true;
                barcode.Location = new Point((this.Width / 4) * 3 - (barcode.Width / 2),
                    stock.Location.Y + 50);

                pCodigo.Text = result.GetString(0);
                pCodigo.Location = new Point(barcode.Location.X,
                    barcode.Location.Y + barcode.Height - 5);
                pCodigo.Visible = true;

                pictureBox2.Visible = false;
            }
            else if (segundos == 2 && !pEncontrado)
            {
                timer1.Enabled = false;
                returnToOriginal();
            }
            if (segundos == 10)
            {
                timer1.Enabled = false;
                returnToOriginal();
            }
        }
        private void returnToOriginal()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            pictureBox2.Visible = true;
            label1.Text = "Por favor pase el código de barra debajo del escáner";
            label1.Visible = true;
            label1.Location = label1OriginalLocation;
            precio.Visible = false;
            stock.Visible = false;
            barcode.Visible = false;
            pCodigo.Visible = false;
            pictureBox2.Location = picturebox2OriginalLocation;
            pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.barcode_scan;
            pImagen.Visible = false;
            pImagen.ImageLocation = null;

            pEncontrado = true;
        }
    }
}
