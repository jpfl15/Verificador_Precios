
namespace VerificadorPrecios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.precio = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.pCodigo = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VerificadorPrecios.Properties.Resources.Icon_Placeholder_1;
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VerificadorPrecios.Properties.Resources.barcode_scan;
            this.pictureBox2.Location = new System.Drawing.Point(300, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pImagen
            // 
            this.pImagen.Location = new System.Drawing.Point(533, 110);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(218, 240);
            this.pImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImagen.TabIndex = 2;
            this.pImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Por favor pase el código de barra debajo del escáner";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.precio.Location = new System.Drawing.Point(49, 190);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(106, 40);
            this.precio.TabIndex = 4;
            this.precio.Text = "label2";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stock.Location = new System.Drawing.Point(49, 233);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(74, 26);
            this.stock.TabIndex = 5;
            this.stock.Text = "label3";
            // 
            // pCodigo
            // 
            this.pCodigo.AutoSize = true;
            this.pCodigo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pCodigo.Location = new System.Drawing.Point(49, 279);
            this.pCodigo.Name = "pCodigo";
            this.pCodigo.Size = new System.Drawing.Size(59, 22);
            this.pCodigo.TabIndex = 6;
            this.pCodigo.Text = "label4";
            // 
            // barcode
            // 
            this.barcode.Image = global::VerificadorPrecios.Properties.Resources.barcode;
            this.barcode.Location = new System.Drawing.Point(116, 218);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(95, 51);
            this.barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcode.TabIndex = 7;
            this.barcode.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.pCodigo);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label pCodigo;
        private System.Windows.Forms.PictureBox barcode;
    }
}

