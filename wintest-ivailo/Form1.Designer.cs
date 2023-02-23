namespace wintest_ivailo
{
    partial class knijarnica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtavtor = new System.Windows.Forms.TextBox();
            this.txtzaglavie = new System.Windows.Forms.TextBox();
            this.gbJanr = new System.Windows.Forms.GroupBox();
            this.rbhudojestvena = new System.Windows.Forms.RadioButton();
            this.rbnauchno = new System.Windows.Forms.RadioButton();
            this.rbspravochna = new System.Windows.Forms.RadioButton();
            this.cbtvurda = new System.Windows.Forms.CheckBox();
            this.cmbizdatelstvo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuy = new System.Windows.Forms.Button();
            this.gbJanr.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "novi knigi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "vid korica";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "vuvedi avtor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "vuvedi zaglavie";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "izberi izdatelstvo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "izberi janr";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtavtor
            // 
            this.txtavtor.Location = new System.Drawing.Point(159, 68);
            this.txtavtor.Name = "txtavtor";
            this.txtavtor.Size = new System.Drawing.Size(118, 22);
            this.txtavtor.TabIndex = 9;
            // 
            // txtzaglavie
            // 
            this.txtzaglavie.Location = new System.Drawing.Point(159, 96);
            this.txtzaglavie.Name = "txtzaglavie";
            this.txtzaglavie.Size = new System.Drawing.Size(118, 22);
            this.txtzaglavie.TabIndex = 10;
            // 
            // gbJanr
            // 
            this.gbJanr.Controls.Add(this.rbspravochna);
            this.gbJanr.Controls.Add(this.rbhudojestvena);
            this.gbJanr.Controls.Add(this.rbnauchno);
            this.gbJanr.Controls.Add(this.label6);
            this.gbJanr.Location = new System.Drawing.Point(55, 156);
            this.gbJanr.Name = "gbJanr";
            this.gbJanr.Size = new System.Drawing.Size(168, 110);
            this.gbJanr.TabIndex = 13;
            this.gbJanr.TabStop = false;
            // 
            // rbhudojestvena
            // 
            this.rbhudojestvena.AutoSize = true;
            this.rbhudojestvena.Location = new System.Drawing.Point(0, 24);
            this.rbhudojestvena.Name = "rbhudojestvena";
            this.rbhudojestvena.Size = new System.Drawing.Size(109, 20);
            this.rbhudojestvena.TabIndex = 14;
            this.rbhudojestvena.TabStop = true;
            this.rbhudojestvena.Text = "hudojestvena";
            this.rbhudojestvena.UseVisualStyleBackColor = true;
            this.rbhudojestvena.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnauchno
            // 
            this.rbnauchno.AutoSize = true;
            this.rbnauchno.Location = new System.Drawing.Point(0, 50);
            this.rbnauchno.Name = "rbnauchno";
            this.rbnauchno.Size = new System.Drawing.Size(144, 20);
            this.rbnauchno.TabIndex = 15;
            this.rbnauchno.TabStop = true;
            this.rbnauchno.Text = "nauchno-populqrna";
            this.rbnauchno.UseVisualStyleBackColor = true;
            // 
            // rbspravochna
            // 
            this.rbspravochna.AutoSize = true;
            this.rbspravochna.Location = new System.Drawing.Point(0, 76);
            this.rbspravochna.Name = "rbspravochna";
            this.rbspravochna.Size = new System.Drawing.Size(99, 20);
            this.rbspravochna.TabIndex = 16;
            this.rbspravochna.TabStop = true;
            this.rbspravochna.Text = "spravochna";
            this.rbspravochna.UseVisualStyleBackColor = true;
            // 
            // cbtvurda
            // 
            this.cbtvurda.AutoSize = true;
            this.cbtvurda.Location = new System.Drawing.Point(11, 37);
            this.cbtvurda.Name = "cbtvurda";
            this.cbtvurda.Size = new System.Drawing.Size(66, 20);
            this.cbtvurda.TabIndex = 15;
            this.cbtvurda.Text = "tvurda";
            this.cbtvurda.UseVisualStyleBackColor = true;
            // 
            // cmbizdatelstvo
            // 
            this.cmbizdatelstvo.FormattingEnabled = true;
            this.cmbizdatelstvo.Items.AddRange(new object[] {
            "anubis",
            "prosveta",
            "arihmed",
            "bulvest 2000",
            "pedagog 6",
            "riva",
            "atlasi",
            "domino i vedi"});
            this.cmbizdatelstvo.Location = new System.Drawing.Point(159, 124);
            this.cmbizdatelstvo.Name = "cmbizdatelstvo";
            this.cmbizdatelstvo.Size = new System.Drawing.Size(118, 24);
            this.cmbizdatelstvo.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtvurda);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(55, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 85);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(555, 428);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(192, 156);
            this.btnbuy.TabIndex = 18;
            this.btnbuy.Text = "poruchai";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btn1_Click);
            // 
            // knijarnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 596);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbizdatelstvo);
            this.Controls.Add(this.gbJanr);
            this.Controls.Add(this.txtzaglavie);
            this.Controls.Add(this.txtavtor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "knijarnica";
            this.Text = "Knijarnica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbJanr.ResumeLayout(false);
            this.gbJanr.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtavtor;
        private System.Windows.Forms.TextBox txtzaglavie;
        private System.Windows.Forms.GroupBox gbJanr;
        private System.Windows.Forms.RadioButton rbspravochna;
        private System.Windows.Forms.RadioButton rbhudojestvena;
        private System.Windows.Forms.RadioButton rbnauchno;
        private System.Windows.Forms.CheckBox cbtvurda;
        private System.Windows.Forms.ComboBox cmbizdatelstvo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbuy;
    }
}

