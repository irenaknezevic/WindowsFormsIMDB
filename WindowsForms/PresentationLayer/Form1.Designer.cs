namespace PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePretraga = new System.Windows.Forms.TabPage();
            this.textBoxGodina = new System.Windows.Forms.TextBox();
            this.labelGodinaFilma = new System.Windows.Forms.Label();
            this.labelNazivFilma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.tabPageMojiFilmovi = new System.Windows.Forms.TabPage();
            this.dataGridViewFilmovi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPagePretraga.SuspendLayout();
            this.tabPageMojiFilmovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePretraga);
            this.tabControl1.Controls.Add(this.tabPageMojiFilmovi);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePretraga
            // 
            this.tabPagePretraga.BackColor = System.Drawing.Color.White;
            this.tabPagePretraga.Controls.Add(this.textBoxGodina);
            this.tabPagePretraga.Controls.Add(this.labelGodinaFilma);
            this.tabPagePretraga.Controls.Add(this.labelNazivFilma);
            this.tabPagePretraga.Controls.Add(this.label1);
            this.tabPagePretraga.Controls.Add(this.textBoxPretraga);
            this.tabPagePretraga.Controls.Add(this.buttonPretraga);
            this.tabPagePretraga.Location = new System.Drawing.Point(4, 24);
            this.tabPagePretraga.Name = "tabPagePretraga";
            this.tabPagePretraga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePretraga.Size = new System.Drawing.Size(846, 398);
            this.tabPagePretraga.TabIndex = 0;
            this.tabPagePretraga.Text = "Search";
            // 
            // textBoxGodina
            // 
            this.textBoxGodina.Location = new System.Drawing.Point(269, 225);
            this.textBoxGodina.Name = "textBoxGodina";
            this.textBoxGodina.Size = new System.Drawing.Size(139, 24);
            this.textBoxGodina.TabIndex = 5;
            // 
            // labelGodinaFilma
            // 
            this.labelGodinaFilma.AutoSize = true;
            this.labelGodinaFilma.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGodinaFilma.Location = new System.Drawing.Point(132, 229);
            this.labelGodinaFilma.Name = "labelGodinaFilma";
            this.labelGodinaFilma.Size = new System.Drawing.Size(50, 20);
            this.labelGodinaFilma.TabIndex = 4;
            this.labelGodinaFilma.Text = "Year:";
            // 
            // labelNazivFilma
            // 
            this.labelNazivFilma.AutoSize = true;
            this.labelNazivFilma.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivFilma.Location = new System.Drawing.Point(132, 186);
            this.labelNazivFilma.Name = "labelNazivFilma";
            this.labelNazivFilma.Size = new System.Drawing.Size(50, 20);
            this.labelNazivFilma.TabIndex = 3;
            this.labelNazivFilma.Text = "Title:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(269, 182);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(362, 24);
            this.textBoxPretraga.TabIndex = 1;
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.AutoSize = true;
            this.buttonPretraga.BackColor = System.Drawing.Color.Teal;
            this.buttonPretraga.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPretraga.Location = new System.Drawing.Point(269, 302);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(140, 35);
            this.buttonPretraga.TabIndex = 0;
            this.buttonPretraga.Text = "Search";
            this.buttonPretraga.UseVisualStyleBackColor = false;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // tabPageMojiFilmovi
            // 
            this.tabPageMojiFilmovi.BackColor = System.Drawing.Color.White;
            this.tabPageMojiFilmovi.Controls.Add(this.dataGridViewFilmovi);
            this.tabPageMojiFilmovi.Location = new System.Drawing.Point(4, 24);
            this.tabPageMojiFilmovi.Name = "tabPageMojiFilmovi";
            this.tabPageMojiFilmovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMojiFilmovi.Size = new System.Drawing.Size(846, 398);
            this.tabPageMojiFilmovi.TabIndex = 1;
            this.tabPageMojiFilmovi.Text = "My movies";
            // 
            // dataGridViewFilmovi
            // 
            this.dataGridViewFilmovi.AllowUserToAddRows = false;
            this.dataGridViewFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Year,
            this.Genre,
            this.Director});
            this.dataGridViewFilmovi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFilmovi.Name = "dataGridViewFilmovi";
            this.dataGridViewFilmovi.Size = new System.Drawing.Size(860, 380);
            this.dataGridViewFilmovi.TabIndex = 0;
            this.dataGridViewFilmovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilmovi_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Director
            // 
            this.Director.DataPropertyName = "Director";
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(882, 472);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePretraga.ResumeLayout(false);
            this.tabPagePretraga.PerformLayout();
            this.tabPageMojiFilmovi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePretraga;
        private System.Windows.Forms.TabPage tabPageMojiFilmovi;
        private System.Windows.Forms.TextBox textBoxPretraga;
        private System.Windows.Forms.Button buttonPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFilmovi;
        private System.Windows.Forms.TextBox textBoxGodina;
        private System.Windows.Forms.Label labelGodinaFilma;
        private System.Windows.Forms.Label labelNazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
    }
}

