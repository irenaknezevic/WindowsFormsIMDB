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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePretraga = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.tabPageMojiFilmovi = new System.Windows.Forms.TabPage();
            this.dataGridViewFilmovi = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePretraga
            // 
            this.tabPagePretraga.BackColor = System.Drawing.Color.White;
            this.tabPagePretraga.Controls.Add(this.label1);
            this.tabPagePretraga.Controls.Add(this.textBoxPretraga);
            this.tabPagePretraga.Controls.Add(this.buttonPretraga);
            this.tabPagePretraga.Location = new System.Drawing.Point(4, 22);
            this.tabPagePretraga.Name = "tabPagePretraga";
            this.tabPagePretraga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePretraga.Size = new System.Drawing.Size(749, 343);
            this.tabPagePretraga.TabIndex = 0;
            this.tabPagePretraga.Text = "Pretraživanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upišite naziv filma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(68, 162);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(534, 20);
            this.textBoxPretraga.TabIndex = 1;
            this.textBoxPretraga.TextChanged += new System.EventHandler(this.textBoxPretraga_TextChanged);
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.AutoSize = true;
            this.buttonPretraga.BackColor = System.Drawing.Color.Teal;
            this.buttonPretraga.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPretraga.Location = new System.Drawing.Point(608, 158);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(75, 26);
            this.buttonPretraga.TabIndex = 0;
            this.buttonPretraga.Text = "Pretraži";
            this.buttonPretraga.UseVisualStyleBackColor = false;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // tabPageMojiFilmovi
            // 
            this.tabPageMojiFilmovi.BackColor = System.Drawing.Color.White;
            this.tabPageMojiFilmovi.Controls.Add(this.dataGridViewFilmovi);
            this.tabPageMojiFilmovi.Location = new System.Drawing.Point(4, 22);
            this.tabPageMojiFilmovi.Name = "tabPageMojiFilmovi";
            this.tabPageMojiFilmovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMojiFilmovi.Size = new System.Drawing.Size(749, 343);
            this.tabPageMojiFilmovi.TabIndex = 1;
            this.tabPageMojiFilmovi.Text = "Moji filmovi";
            // 
            // dataGridViewFilmovi
            // 
            this.dataGridViewFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Year,
            this.Genre,
            this.Director});
            this.dataGridViewFilmovi.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFilmovi.Name = "dataGridViewFilmovi";
            this.dataGridViewFilmovi.Size = new System.Drawing.Size(737, 331);
            this.dataGridViewFilmovi.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Naziv filma";
            this.Title.Name = "Title";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Godina";
            this.Year.Name = "Year";
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Žanr";
            this.Genre.Name = "Genre";
            // 
            // Director
            // 
            this.Director.DataPropertyName = "Director";
            this.Director.HeaderText = "Režiser";
            this.Director.Name = "Director";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(781, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Filmovi";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
    }
}

