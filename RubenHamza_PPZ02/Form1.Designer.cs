namespace RubenHamza_PPZ02
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
            this.lblNazivPića = new System.Windows.Forms.Label();
            this.txtNazivPića = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.lblPakiranje = new System.Windows.Forms.Label();
            this.cmbPakiranje = new System.Windows.Forms.ComboBox();
            this.trckPostoAlkohola = new System.Windows.Forms.TrackBar();
            this.lblPostotakAlkohola = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.gbPića = new System.Windows.Forms.GroupBox();
            this.rdbAlkoholna = new System.Windows.Forms.RadioButton();
            this.rdbGazirana = new System.Windows.Forms.RadioButton();
            this.rdbNegazirana = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trckPostoAlkohola)).BeginInit();
            this.gbPića.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazivPića
            // 
            this.lblNazivPića.AutoSize = true;
            this.lblNazivPića.Location = new System.Drawing.Point(36, 137);
            this.lblNazivPića.Name = "lblNazivPića";
            this.lblNazivPića.Size = new System.Drawing.Size(57, 13);
            this.lblNazivPića.TabIndex = 4;
            this.lblNazivPića.Text = "Naziv pića";
            // 
            // txtNazivPića
            // 
            this.txtNazivPića.Location = new System.Drawing.Point(39, 153);
            this.txtNazivPića.Name = "txtNazivPića";
            this.txtNazivPića.Size = new System.Drawing.Size(136, 20);
            this.txtNazivPića.TabIndex = 5;
            this.txtNazivPića.TextChanged += new System.EventHandler(this.txtNazivPića_TextChanged);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(36, 201);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Količina";
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbKolicina.Location = new System.Drawing.Point(36, 218);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(139, 21);
            this.cmbKolicina.TabIndex = 7;
            // 
            // lblPakiranje
            // 
            this.lblPakiranje.AutoSize = true;
            this.lblPakiranje.Location = new System.Drawing.Point(36, 266);
            this.lblPakiranje.Name = "lblPakiranje";
            this.lblPakiranje.Size = new System.Drawing.Size(51, 13);
            this.lblPakiranje.TabIndex = 8;
            this.lblPakiranje.Text = "Pakiranje";
            // 
            // cmbPakiranje
            // 
            this.cmbPakiranje.FormattingEnabled = true;
            this.cmbPakiranje.Items.AddRange(new object[] {
            "0.5 L",
            "1 L",
            "1.5 L",
            "2 L"});
            this.cmbPakiranje.Location = new System.Drawing.Point(36, 282);
            this.cmbPakiranje.Name = "cmbPakiranje";
            this.cmbPakiranje.Size = new System.Drawing.Size(139, 21);
            this.cmbPakiranje.TabIndex = 9;
            // 
            // trckPostoAlkohola
            // 
            this.trckPostoAlkohola.Location = new System.Drawing.Point(183, 51);
            this.trckPostoAlkohola.Maximum = 80;
            this.trckPostoAlkohola.Name = "trckPostoAlkohola";
            this.trckPostoAlkohola.Size = new System.Drawing.Size(194, 45);
            this.trckPostoAlkohola.TabIndex = 10;
            this.trckPostoAlkohola.Scroll += new System.EventHandler(this.trckPostoAlkohola_Scroll);
            // 
            // lblPostotakAlkohola
            // 
            this.lblPostotakAlkohola.AutoSize = true;
            this.lblPostotakAlkohola.Location = new System.Drawing.Point(232, 27);
            this.lblPostotakAlkohola.Name = "lblPostotakAlkohola";
            this.lblPostotakAlkohola.Size = new System.Drawing.Size(109, 13);
            this.lblPostotakAlkohola.TabIndex = 11;
            this.lblPostotakAlkohola.Text = "Postotak alkohola (%)";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(36, 344);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(67, 20);
            this.txtCijena.TabIndex = 12;
            this.txtCijena.TextChanged += new System.EventHandler(this.txtCijena_TextChanged);
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(39, 325);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(36, 13);
            this.lblCijena.TabIndex = 13;
            this.lblCijena.Text = "Cijena";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(220, 150);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 89);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(396, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(369, 328);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // btnIspis
            // 
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspis.Location = new System.Drawing.Point(220, 266);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(121, 89);
            this.btnIspis.TabIndex = 16;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // gbPića
            // 
            this.gbPića.Controls.Add(this.rdbAlkoholna);
            this.gbPića.Controls.Add(this.rdbGazirana);
            this.gbPića.Controls.Add(this.rdbNegazirana);
            this.gbPića.Location = new System.Drawing.Point(36, 27);
            this.gbPića.Name = "gbPića";
            this.gbPića.Size = new System.Drawing.Size(113, 91);
            this.gbPića.TabIndex = 17;
            this.gbPića.TabStop = false;
            this.gbPića.Text = "Vrsta pića";
            // 
            // rdbAlkoholna
            // 
            this.rdbAlkoholna.AutoSize = true;
            this.rdbAlkoholna.Location = new System.Drawing.Point(6, 65);
            this.rdbAlkoholna.Name = "rdbAlkoholna";
            this.rdbAlkoholna.Size = new System.Drawing.Size(72, 17);
            this.rdbAlkoholna.TabIndex = 20;
            this.rdbAlkoholna.TabStop = true;
            this.rdbAlkoholna.Text = "Alkoholna";
            this.rdbAlkoholna.UseVisualStyleBackColor = true;
            this.rdbAlkoholna.CheckedChanged += new System.EventHandler(this.rdbAlkoholna_CheckedChanged);
            // 
            // rdbGazirana
            // 
            this.rdbGazirana.AutoSize = true;
            this.rdbGazirana.Location = new System.Drawing.Point(6, 19);
            this.rdbGazirana.Name = "rdbGazirana";
            this.rdbGazirana.Size = new System.Drawing.Size(67, 17);
            this.rdbGazirana.TabIndex = 18;
            this.rdbGazirana.TabStop = true;
            this.rdbGazirana.Text = "Gazirana";
            this.rdbGazirana.UseVisualStyleBackColor = true;
            this.rdbGazirana.CheckedChanged += new System.EventHandler(this.rdbGazirana_CheckedChanged);
            // 
            // rdbNegazirana
            // 
            this.rdbNegazirana.AutoSize = true;
            this.rdbNegazirana.Location = new System.Drawing.Point(6, 42);
            this.rdbNegazirana.Name = "rdbNegazirana";
            this.rdbNegazirana.Size = new System.Drawing.Size(79, 17);
            this.rdbNegazirana.TabIndex = 19;
            this.rdbNegazirana.TabStop = true;
            this.rdbNegazirana.Text = "Negazirana";
            this.rdbNegazirana.UseVisualStyleBackColor = true;
            this.rdbNegazirana.CheckedChanged += new System.EventHandler(this.rdbNegazirana_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.gbPića);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblPostotakAlkohola);
            this.Controls.Add(this.trckPostoAlkohola);
            this.Controls.Add(this.cmbPakiranje);
            this.Controls.Add(this.lblPakiranje);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtNazivPića);
            this.Controls.Add(this.lblNazivPića);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckPostoAlkohola)).EndInit();
            this.gbPića.ResumeLayout(false);
            this.gbPića.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNazivPića;
        private System.Windows.Forms.TextBox txtNazivPića;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.Label lblPakiranje;
        private System.Windows.Forms.ComboBox cmbPakiranje;
        private System.Windows.Forms.TrackBar trckPostoAlkohola;
        private System.Windows.Forms.Label lblPostotakAlkohola;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.GroupBox gbPića;
        private System.Windows.Forms.RadioButton rdbAlkoholna;
        private System.Windows.Forms.RadioButton rdbGazirana;
        private System.Windows.Forms.RadioButton rdbNegazirana;
    }
}

