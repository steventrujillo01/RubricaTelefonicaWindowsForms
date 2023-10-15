namespace RubricaTelefonicaWPF
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonCancella = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ricerca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ricerca_button = new System.Windows.Forms.Button();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aggiungi contatto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cognome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero di telefono:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(187, 77);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 4;
            // 
            // Cognome
            // 
            this.Cognome.Location = new System.Drawing.Point(187, 115);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(100, 20);
            this.Cognome.TabIndex = 5;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(187, 152);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(100, 20);
            this.Numero.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalva
            // 
            this.buttonSalva.BackColor = System.Drawing.Color.Lime;
            this.buttonSalva.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalva.Location = new System.Drawing.Point(229, 190);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(75, 23);
            this.buttonSalva.TabIndex = 8;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancella
            // 
            this.buttonCancella.BackColor = System.Drawing.Color.Red;
            this.buttonCancella.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancella.Location = new System.Drawing.Point(48, 190);
            this.buttonCancella.Name = "buttonCancella";
            this.buttonCancella.Size = new System.Drawing.Size(75, 23);
            this.buttonCancella.TabIndex = 9;
            this.buttonCancella.Text = "Cancella";
            this.buttonCancella.UseVisualStyleBackColor = false;
            this.buttonCancella.Click += new System.EventHandler(this.buttonCancella_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(139, 190);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(75, 23);
            this.buttonModifica.TabIndex = 10;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.numeroTelefonicoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contattoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(362, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ricerca
            // 
            this.Ricerca.Location = new System.Drawing.Point(441, 31);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(230, 20);
            this.Ricerca.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cerca :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ricerca_button
            // 
            this.ricerca_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ricerca_button.BackgroundImage")));
            this.ricerca_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ricerca_button.Location = new System.Drawing.Point(677, 22);
            this.ricerca_button.Name = "ricerca_button";
            this.ricerca_button.Size = new System.Drawing.Size(37, 35);
            this.ricerca_button.TabIndex = 14;
            this.ricerca_button.UseVisualStyleBackColor = true;
            this.ricerca_button.Click += new System.EventHandler(this.ricerca_button_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // numeroTelefonicoDataGridViewTextBoxColumn
            // 
            this.numeroTelefonicoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefonico";
            this.numeroTelefonicoDataGridViewTextBoxColumn.HeaderText = "NumeroTelefonico";
            this.numeroTelefonicoDataGridViewTextBoxColumn.Name = "numeroTelefonicoDataGridViewTextBoxColumn";
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataSource = typeof(RubricaTelefonicaWPF.Contatto);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RubricaTelefonicaWPF.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 255);
            this.Controls.Add(this.ricerca_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonCancella);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Cognome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rubrica Telefonica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Cognome;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonCancella;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefonicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daiNominativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daiDettaglioContattoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TextBox Ricerca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ricerca_button;
    }
}

