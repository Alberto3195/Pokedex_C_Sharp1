namespace PokedexC_sharp
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.izq = new System.Windows.Forms.Button();
            this.der = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izq
            // 
            this.izq.BackColor = System.Drawing.Color.Transparent;
            this.izq.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izq.Location = new System.Drawing.Point(257, 448);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(34, 29);
            this.izq.TabIndex = 1;
            this.izq.Text = "<";
            this.izq.UseVisualStyleBackColor = false;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.BackColor = System.Drawing.Color.Transparent;
            this.der.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.der.Location = new System.Drawing.Point(317, 447);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(34, 29);
            this.der.TabIndex = 2;
            this.der.Text = ">";
            this.der.UseVisualStyleBackColor = false;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.Location = new System.Drawing.Point(33, 409);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(115, 30);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "nombre";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Cursor = System.Windows.Forms.Cursors.Default;
            this.id.Location = new System.Drawing.Point(51, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(48, 30);
            this.id.TabIndex = 4;
            this.id.Text = "id";
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Transparent;
            this.tipo.Location = new System.Drawing.Point(157, 410);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(119, 30);
            this.tipo.TabIndex = 5;
            this.tipo.Text = "tipo";
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.Color.Transparent;
            this.altura.Location = new System.Drawing.Point(32, 447);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(115, 30);
            this.altura.TabIndex = 6;
            this.altura.Text = "altura";
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Transparent;
            this.peso.Location = new System.Drawing.Point(155, 482);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(122, 30);
            this.peso.TabIndex = 7;
            this.peso.Text = "peso";
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.Color.Transparent;
            this.habitat.Location = new System.Drawing.Point(32, 483);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(115, 30);
            this.habitat.TabIndex = 8;
            this.habitat.Text = "habitat";
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Transparent;
            this.especie.Location = new System.Drawing.Point(32, 515);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(115, 30);
            this.especie.TabIndex = 9;
            this.especie.Text = "especie";
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.Color.Transparent;
            this.habilidad.Location = new System.Drawing.Point(155, 515);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(122, 30);
            this.habilidad.TabIndex = 10;
            this.habilidad.Text = "habilidad";
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(158, 447);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(94, 32);
            this.X.TabIndex = 11;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 565);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 188);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(425, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.pictureBox2);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label habilidad;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

