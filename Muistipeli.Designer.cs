using System.Collections;

namespace Muisti
{
    partial class frmMuistipeli
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
            this.components = new System.ComponentModel.Container();
            this.tlpPeli = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.btnPelaa = new System.Windows.Forms.Button();
            this.lblPelaaja2Pisteet = new System.Windows.Forms.Label();
            this.tbPelaaja2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.msPeli = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbPelaaja2Vuoro = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbPelaaja1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblPelaaja1Pisteet = new System.Windows.Forms.Label();
            this.rbPelaaja1Vuoro = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblPelaaja1VT = new System.Windows.Forms.Label();
            this.lblPelaaja2VT = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.numPelaaja1V = new System.Windows.Forms.NumericUpDown();
            this.numPelaaja1H = new System.Windows.Forms.NumericUpDown();
            this.numPelaaja2H = new System.Windows.Forms.NumericUpDown();
            this.numPelaaja2V = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnPelaaja1Tuo = new System.Windows.Forms.Button();
            this.btnPelaaja1Tal = new System.Windows.Forms.Button();
            this.btnPelaaja2Tuo = new System.Windows.Forms.Button();
            this.btnPelaaja2Tal = new System.Windows.Forms.Button();
            this.epPeli = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUudestaan = new System.Windows.Forms.Label();
            this.tlpPeli.SuspendLayout();
            this.msPeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja1V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja1H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja2H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja2V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPeli)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPeli
            // 
            this.tlpPeli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlpPeli.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpPeli.ColumnCount = 4;
            this.tlpPeli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.Controls.Add(this.label16, 3, 3);
            this.tlpPeli.Controls.Add(this.label15, 2, 3);
            this.tlpPeli.Controls.Add(this.label14, 1, 3);
            this.tlpPeli.Controls.Add(this.label13, 0, 3);
            this.tlpPeli.Controls.Add(this.label12, 3, 2);
            this.tlpPeli.Controls.Add(this.label11, 2, 2);
            this.tlpPeli.Controls.Add(this.label10, 1, 2);
            this.tlpPeli.Controls.Add(this.label9, 0, 2);
            this.tlpPeli.Controls.Add(this.label8, 3, 1);
            this.tlpPeli.Controls.Add(this.label7, 2, 1);
            this.tlpPeli.Controls.Add(this.label6, 1, 1);
            this.tlpPeli.Controls.Add(this.label5, 0, 1);
            this.tlpPeli.Controls.Add(this.label4, 3, 0);
            this.tlpPeli.Controls.Add(this.label3, 2, 0);
            this.tlpPeli.Controls.Add(this.label2, 1, 0);
            this.tlpPeli.Controls.Add(this.label1, 0, 0);
            this.tlpPeli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tlpPeli.Location = new System.Drawing.Point(266, 150);
            this.tlpPeli.Name = "tlpPeli";
            this.tlpPeli.RowCount = 4;
            this.tlpPeli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPeli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPeli.Size = new System.Drawing.Size(619, 531);
            this.tlpPeli.TabIndex = 0;
            this.tlpPeli.Visible = false;
            this.tlpPeli.Click += new System.EventHandler(this.label_Click);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Location = new System.Drawing.Point(467, 398);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 131);
            this.label16.TabIndex = 15;
            this.label16.Text = "c";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Location = new System.Drawing.Point(313, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 131);
            this.label15.TabIndex = 14;
            this.label15.Text = "c";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(159, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 131);
            this.label14.TabIndex = 13;
            this.label14.Text = "c";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(5, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 131);
            this.label13.TabIndex = 12;
            this.label13.Text = "c";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(467, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 130);
            this.label12.TabIndex = 11;
            this.label12.Text = "c";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(313, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 130);
            this.label11.TabIndex = 10;
            this.label11.Text = "c";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(159, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 130);
            this.label10.TabIndex = 9;
            this.label10.Text = "c";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(5, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 130);
            this.label9.TabIndex = 8;
            this.label9.Text = "c";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(467, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 130);
            this.label8.TabIndex = 7;
            this.label8.Text = "c";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(313, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 130);
            this.label7.TabIndex = 6;
            this.label7.Text = "c";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(159, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 130);
            this.label6.TabIndex = 5;
            this.label6.Text = "c";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(5, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 130);
            this.label5.TabIndex = 4;
            this.label5.Text = "c";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(467, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 130);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(313, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 130);
            this.label3.TabIndex = 2;
            this.label3.Text = "c";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(159, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 130);
            this.label2.TabIndex = 1;
            this.label2.Text = "c";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "c";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(415, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(310, 69);
            this.label17.TabIndex = 1;
            this.label17.Text = "Muistipeli";
            // 
            // btnPelaa
            // 
            this.btnPelaa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPelaa.Enabled = false;
            this.btnPelaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelaa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPelaa.Location = new System.Drawing.Point(530, 106);
            this.btnPelaa.Name = "btnPelaa";
            this.btnPelaa.Size = new System.Drawing.Size(90, 38);
            this.btnPelaa.TabIndex = 6;
            this.btnPelaa.Text = "Pelaa!";
            this.btnPelaa.UseVisualStyleBackColor = false;
            this.btnPelaa.Click += new System.EventHandler(this.btnPelaa_Click);
            // 
            // lblPelaaja2Pisteet
            // 
            this.lblPelaaja2Pisteet.AutoSize = true;
            this.lblPelaaja2Pisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2Pisteet.Location = new System.Drawing.Point(990, 345);
            this.lblPelaaja2Pisteet.Name = "lblPelaaja2Pisteet";
            this.lblPelaaja2Pisteet.Size = new System.Drawing.Size(29, 31);
            this.lblPelaaja2Pisteet.TabIndex = 10;
            this.lblPelaaja2Pisteet.Text = "0";
            // 
            // tbPelaaja2
            // 
            this.tbPelaaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPelaaja2.Location = new System.Drawing.Point(968, 149);
            this.tbPelaaja2.Name = "tbPelaaja2";
            this.tbPelaaja2.Size = new System.Drawing.Size(100, 23);
            this.tbPelaaja2.TabIndex = 3;
            this.tbPelaaja2.Text = "Nimi";
            this.tbPelaaja2.TextChanged += new System.EventHandler(this.tbPelaaja1_TextChanged);
            this.tbPelaaja2.Validating += new System.ComponentModel.CancelEventHandler(this.tbPelaaja2_Validating);
            this.tbPelaaja2.Validated += new System.EventHandler(this.tbPelaaja1_Validated);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(974, 312);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 25);
            this.label25.TabIndex = 9;
            this.label25.Text = "Pisteet:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(988, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 25);
            this.label20.TabIndex = 3;
            this.label20.Text = "Nimi:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(962, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 31);
            this.label21.TabIndex = 2;
            this.label21.Text = "Pelaaja 2:";
            // 
            // msPeli
            // 
            this.msPeli.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.msPeli.Location = new System.Drawing.Point(0, 0);
            this.msPeli.Name = "msPeli";
            this.msPeli.Size = new System.Drawing.Size(1165, 24);
            this.msPeli.TabIndex = 6;
            this.msPeli.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // rbPelaaja2Vuoro
            // 
            this.rbPelaaja2Vuoro.AutoSize = true;
            this.rbPelaaja2Vuoro.Location = new System.Drawing.Point(1005, 431);
            this.rbPelaaja2Vuoro.Name = "rbPelaaja2Vuoro";
            this.rbPelaaja2Vuoro.Size = new System.Drawing.Size(14, 13);
            this.rbPelaaja2Vuoro.TabIndex = 7;
            this.rbPelaaja2Vuoro.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(41, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 31);
            this.label18.TabIndex = 2;
            this.label18.Text = "Pelaaja 1:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(62, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "Nimi:";
            // 
            // tbPelaaja1
            // 
            this.tbPelaaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPelaaja1.Location = new System.Drawing.Point(47, 149);
            this.tbPelaaja1.Name = "tbPelaaja1";
            this.tbPelaaja1.Size = new System.Drawing.Size(100, 23);
            this.tbPelaaja1.TabIndex = 0;
            this.tbPelaaja1.Text = "Nimi";
            this.tbPelaaja1.TextChanged += new System.EventHandler(this.tbPelaaja1_TextChanged);
            this.tbPelaaja1.Validating += new System.ComponentModel.CancelEventHandler(this.tbPelaaja1_Validating);
            this.tbPelaaja1.Validated += new System.EventHandler(this.tbPelaaja1_Validated);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(53, 312);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 25);
            this.label22.TabIndex = 7;
            this.label22.Text = "Pisteet:";
            // 
            // lblPelaaja1Pisteet
            // 
            this.lblPelaaja1Pisteet.AutoSize = true;
            this.lblPelaaja1Pisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1Pisteet.Location = new System.Drawing.Point(69, 345);
            this.lblPelaaja1Pisteet.Name = "lblPelaaja1Pisteet";
            this.lblPelaaja1Pisteet.Size = new System.Drawing.Size(29, 31);
            this.lblPelaaja1Pisteet.TabIndex = 8;
            this.lblPelaaja1Pisteet.Text = "0";
            // 
            // rbPelaaja1Vuoro
            // 
            this.rbPelaaja1Vuoro.AutoSize = true;
            this.rbPelaaja1Vuoro.Checked = true;
            this.rbPelaaja1Vuoro.Location = new System.Drawing.Point(78, 432);
            this.rbPelaaja1Vuoro.Name = "rbPelaaja1Vuoro";
            this.rbPelaaja1Vuoro.Size = new System.Drawing.Size(14, 13);
            this.rbPelaaja1Vuoro.TabIndex = 7;
            this.rbPelaaja1Vuoro.TabStop = true;
            this.rbPelaaja1Vuoro.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(53, 404);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 25);
            this.label23.TabIndex = 11;
            this.label23.Text = "Vuoro:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(974, 404);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 25);
            this.label24.TabIndex = 12;
            this.label24.Text = "Vuoro:";
            // 
            // lblPelaaja1VT
            // 
            this.lblPelaaja1VT.AutoSize = true;
            this.lblPelaaja1VT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1VT.Location = new System.Drawing.Point(49, 486);
            this.lblPelaaja1VT.Name = "lblPelaaja1VT";
            this.lblPelaaja1VT.Size = new System.Drawing.Size(216, 31);
            this.lblPelaaja1VT.TabIndex = 14;
            this.lblPelaaja1VT.Text = "Voittaja/Tasapeli";
            this.lblPelaaja1VT.Visible = false;
            // 
            // lblPelaaja2VT
            // 
            this.lblPelaaja2VT.AutoSize = true;
            this.lblPelaaja2VT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2VT.Location = new System.Drawing.Point(945, 486);
            this.lblPelaaja2VT.Name = "lblPelaaja2VT";
            this.lblPelaaja2VT.Size = new System.Drawing.Size(216, 31);
            this.lblPelaaja2VT.TabIndex = 15;
            this.lblPelaaja2VT.Text = "Voittaja/Tasapeli";
            this.lblPelaaja2VT.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(47, 185);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 17);
            this.label26.TabIndex = 22;
            this.label26.Text = "Voitot:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(43, 212);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 17);
            this.label29.TabIndex = 23;
            this.label29.Text = "Häviöt:";
            // 
            // numPelaaja1V
            // 
            this.numPelaaja1V.Location = new System.Drawing.Point(101, 182);
            this.numPelaaja1V.Name = "numPelaaja1V";
            this.numPelaaja1V.Size = new System.Drawing.Size(46, 20);
            this.numPelaaja1V.TabIndex = 1;
            this.numPelaaja1V.ValueChanged += new System.EventHandler(this.numPelaaja1V_ValueChanged);
            // 
            // numPelaaja1H
            // 
            this.numPelaaja1H.Location = new System.Drawing.Point(101, 212);
            this.numPelaaja1H.Name = "numPelaaja1H";
            this.numPelaaja1H.Size = new System.Drawing.Size(46, 20);
            this.numPelaaja1H.TabIndex = 2;
            // 
            // numPelaaja2H
            // 
            this.numPelaaja2H.Location = new System.Drawing.Point(1015, 212);
            this.numPelaaja2H.Name = "numPelaaja2H";
            this.numPelaaja2H.Size = new System.Drawing.Size(46, 20);
            this.numPelaaja2H.TabIndex = 5;
            // 
            // numPelaaja2V
            // 
            this.numPelaaja2V.Location = new System.Drawing.Point(1015, 182);
            this.numPelaaja2V.Name = "numPelaaja2V";
            this.numPelaaja2V.Size = new System.Drawing.Size(46, 20);
            this.numPelaaja2V.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(961, 212);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 17);
            this.label30.TabIndex = 27;
            this.label30.Text = "Häviöt:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(965, 185);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 17);
            this.label31.TabIndex = 26;
            this.label31.Text = "Voitot:";
            // 
            // btnPelaaja1Tuo
            // 
            this.btnPelaaja1Tuo.Location = new System.Drawing.Point(46, 238);
            this.btnPelaaja1Tuo.Name = "btnPelaaja1Tuo";
            this.btnPelaaja1Tuo.Size = new System.Drawing.Size(117, 23);
            this.btnPelaaja1Tuo.TabIndex = 28;
            this.btnPelaaja1Tuo.Text = "Tuo vanha pelaaja";
            this.btnPelaaja1Tuo.UseVisualStyleBackColor = true;
            this.btnPelaaja1Tuo.Click += new System.EventHandler(this.btnPelaaja1Tuo_Click);
            // 
            // btnPelaaja1Tal
            // 
            this.btnPelaaja1Tal.Location = new System.Drawing.Point(58, 267);
            this.btnPelaaja1Tal.Name = "btnPelaaja1Tal";
            this.btnPelaaja1Tal.Size = new System.Drawing.Size(75, 23);
            this.btnPelaaja1Tal.TabIndex = 29;
            this.btnPelaaja1Tal.Text = "Tallenna";
            this.btnPelaaja1Tal.UseVisualStyleBackColor = true;
            this.btnPelaaja1Tal.Visible = false;
            this.btnPelaaja1Tal.Click += new System.EventHandler(this.btnPelaaja1Tal_Click);
            // 
            // btnPelaaja2Tuo
            // 
            this.btnPelaaja2Tuo.Location = new System.Drawing.Point(964, 238);
            this.btnPelaaja2Tuo.Name = "btnPelaaja2Tuo";
            this.btnPelaaja2Tuo.Size = new System.Drawing.Size(108, 23);
            this.btnPelaaja2Tuo.TabIndex = 30;
            this.btnPelaaja2Tuo.Text = "Tuo vanha pelaaja";
            this.btnPelaaja2Tuo.UseVisualStyleBackColor = true;
            this.btnPelaaja2Tuo.Click += new System.EventHandler(this.btnPelaaja2Tuo_Click);
            // 
            // btnPelaaja2Tal
            // 
            this.btnPelaaja2Tal.Location = new System.Drawing.Point(976, 267);
            this.btnPelaaja2Tal.Name = "btnPelaaja2Tal";
            this.btnPelaaja2Tal.Size = new System.Drawing.Size(75, 23);
            this.btnPelaaja2Tal.TabIndex = 31;
            this.btnPelaaja2Tal.Text = "Tallenna";
            this.btnPelaaja2Tal.UseVisualStyleBackColor = true;
            this.btnPelaaja2Tal.Visible = false;
            this.btnPelaaja2Tal.Click += new System.EventHandler(this.btnPelaaja2Tal_Click);
            // 
            // epPeli
            // 
            this.epPeli.ContainerControl = this;
            // 
            // lblUudestaan
            // 
            this.lblUudestaan.AutoSize = true;
            this.lblUudestaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUudestaan.Location = new System.Drawing.Point(386, 127);
            this.lblUudestaan.Name = "lblUudestaan";
            this.lblUudestaan.Size = new System.Drawing.Size(392, 20);
            this.lblUudestaan.TabIndex = 32;
            this.lblUudestaan.Text = "Käynnistä sovellus uudestaan pelataksesi uuden pelin!";
            this.lblUudestaan.Visible = false;
            // 
            // frmMuistipeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 684);
            this.Controls.Add(this.lblUudestaan);
            this.Controls.Add(this.btnPelaaja2Tal);
            this.Controls.Add(this.btnPelaaja2Tuo);
            this.Controls.Add(this.btnPelaaja1Tal);
            this.Controls.Add(this.btnPelaaja1Tuo);
            this.Controls.Add(this.numPelaaja2H);
            this.Controls.Add(this.numPelaaja2V);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.numPelaaja1H);
            this.Controls.Add(this.numPelaaja1V);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblPelaaja2VT);
            this.Controls.Add(this.lblPelaaja1VT);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.rbPelaaja2Vuoro);
            this.Controls.Add(this.rbPelaaja1Vuoro);
            this.Controls.Add(this.lblPelaaja2Pisteet);
            this.Controls.Add(this.tbPelaaja2);
            this.Controls.Add(this.btnPelaa);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblPelaaja1Pisteet);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tlpPeli);
            this.Controls.Add(this.msPeli);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbPelaaja1);
            this.MainMenuStrip = this.msPeli;
            this.MinimumSize = new System.Drawing.Size(1181, 723);
            this.Name = "frmMuistipeli";
            this.Text = "Muistipeli";
            this.tlpPeli.ResumeLayout(false);
            this.msPeli.ResumeLayout(false);
            this.msPeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja1V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja1H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja2H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPelaaja2V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPeli;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnPelaa;
        private System.Windows.Forms.TextBox tbPelaaja2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPelaaja2Pisteet;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MenuStrip msPeli;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbPelaaja2Vuoro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbPelaaja1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblPelaaja1Pisteet;
        private System.Windows.Forms.RadioButton rbPelaaja1Vuoro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblPelaaja1VT;
        private System.Windows.Forms.Label lblPelaaja2VT;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown numPelaaja1V;
        private System.Windows.Forms.NumericUpDown numPelaaja1H;
        private System.Windows.Forms.NumericUpDown numPelaaja2H;
        private System.Windows.Forms.NumericUpDown numPelaaja2V;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnPelaaja1Tuo;
        private System.Windows.Forms.Button btnPelaaja1Tal;
        private System.Windows.Forms.Button btnPelaaja2Tuo;
        private System.Windows.Forms.Button btnPelaaja2Tal;
        private System.Windows.Forms.ErrorProvider epPeli;
        private System.Windows.Forms.Label lblUudestaan;
    }
}

