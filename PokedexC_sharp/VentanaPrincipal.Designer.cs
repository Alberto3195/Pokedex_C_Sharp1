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
            this.izq = new System.Windows.Forms.Button();
            this.der = new System.Windows.Forms.Button();
            this.tipo1 = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NombrePokemon = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izq
            // 
            this.izq.BackColor = System.Drawing.Color.Transparent;
            this.izq.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izq.Location = new System.Drawing.Point(35, 260);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(64, 45);
            this.izq.TabIndex = 1;
            this.izq.Text = "<";
            this.izq.UseVisualStyleBackColor = false;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.BackColor = System.Drawing.Color.Transparent;
            this.der.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.der.Location = new System.Drawing.Point(250, 260);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(64, 45);
            this.der.TabIndex = 2;
            this.der.Text = ">";
            this.der.UseVisualStyleBackColor = false;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.Color.Transparent;
            this.tipo1.Location = new System.Drawing.Point(320, 66);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(122, 30);
            this.tipo1.TabIndex = 5;
            this.tipo1.Text = "Tipo";
            this.tipo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.Color.Transparent;
            this.habitat.Location = new System.Drawing.Point(320, 162);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(122, 30);
            this.habitat.TabIndex = 8;
            this.habitat.Text = "Habitat";
            this.habitat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Transparent;
            this.especie.Location = new System.Drawing.Point(320, 194);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(122, 30);
            this.especie.TabIndex = 9;
            this.especie.Text = "Especie";
            this.especie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.Color.Transparent;
            this.habilidad.Location = new System.Drawing.Point(320, 130);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(122, 30);
            this.habilidad.TabIndex = 10;
            this.habilidad.Text = "Habilidad";
            this.habilidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(105, 260);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(139, 45);
            this.X.TabIndex = 11;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 188);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(320, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "POKEDEX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Transparent;
            this.peso.Location = new System.Drawing.Point(226, 33);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(88, 30);
            this.peso.TabIndex = 15;
            this.peso.Text = "Peso";
            this.peso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.Color.Transparent;
            this.altura.Location = new System.Drawing.Point(320, 226);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(122, 30);
            this.altura.TabIndex = 16;
            this.altura.Text = "Altura";
            this.altura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.Color.Transparent;
            this.tipo2.Location = new System.Drawing.Point(320, 98);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(122, 30);
            this.tipo2.TabIndex = 17;
            this.tipo2.Text = "Tipo2";
            this.tipo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "BUSCAR";
            // 
            // NombrePokemon
            // 
            this.NombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.NombrePokemon.Location = new System.Drawing.Point(132, 33);
            this.NombrePokemon.Name = "NombrePokemon";
            this.NombrePokemon.Size = new System.Drawing.Size(88, 30);
            this.NombrePokemon.TabIndex = 19;
            this.NombrePokemon.Text = "Nombre";
            this.NombrePokemon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Location = new System.Drawing.Point(38, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(88, 30);
            this.id.TabIndex = 20;
            this.id.Text = "ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(485, 347);
            this.Controls.Add(this.id);
            this.Controls.Add(this.NombrePokemon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label habilidad;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NombrePokemon;
        private System.Windows.Forms.Label id;
    }
}

