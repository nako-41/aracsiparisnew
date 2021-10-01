
namespace aracsiparis
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbyakittipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbkasatipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbvitestipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnrenk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpyil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbmotortipi = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARKA";
            // 
            // cmbmarka
            // 
            this.cmbmarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Items.AddRange(new object[] {
            "VOLKSWAGEN",
            "AUDİ",
            "BMW",
            "MERCEDES",
            "VOLVO",
            "HONDA"});
            this.cmbmarka.Location = new System.Drawing.Point(26, 25);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(121, 21);
            this.cmbmarka.TabIndex = 1;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.cmbmarka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MODEL";
            // 
            // cmbmodel
            // 
            this.cmbmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Location = new System.Drawing.Point(153, 25);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(121, 21);
            this.cmbmodel.TabIndex = 1;
            this.cmbmodel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "YAKIT TIİPİ";
            // 
            // cmbyakittipi
            // 
            this.cmbyakittipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyakittipi.FormattingEnabled = true;
            this.cmbyakittipi.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "LPG"});
            this.cmbyakittipi.Location = new System.Drawing.Point(280, 25);
            this.cmbyakittipi.Name = "cmbyakittipi";
            this.cmbyakittipi.Size = new System.Drawing.Size(121, 21);
            this.cmbyakittipi.TabIndex = 1;
            this.cmbyakittipi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "KASA TİPİ";
            // 
            // cmbkasatipi
            // 
            this.cmbkasatipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkasatipi.FormattingEnabled = true;
            this.cmbkasatipi.Items.AddRange(new object[] {
            "SEDAN",
            "VAGON",
            "HATCHBACK",
            "SUV"});
            this.cmbkasatipi.Location = new System.Drawing.Point(407, 25);
            this.cmbkasatipi.Name = "cmbkasatipi";
            this.cmbkasatipi.Size = new System.Drawing.Size(121, 21);
            this.cmbkasatipi.TabIndex = 1;
            this.cmbkasatipi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "VİTES TİPİ";
            // 
            // cmbvitestipi
            // 
            this.cmbvitestipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvitestipi.FormattingEnabled = true;
            this.cmbvitestipi.Items.AddRange(new object[] {
            "MANUEL",
            "OTOMATİK",
            "YARIOTOMATİK"});
            this.cmbvitestipi.Location = new System.Drawing.Point(26, 72);
            this.cmbvitestipi.Name = "cmbvitestipi";
            this.cmbvitestipi.Size = new System.Drawing.Size(121, 21);
            this.cmbvitestipi.TabIndex = 1;
            this.cmbvitestipi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "RENK";
            // 
            // btnrenk
            // 
            this.btnrenk.BackColor = System.Drawing.Color.Salmon;
            this.btnrenk.Location = new System.Drawing.Point(284, 70);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(117, 23);
            this.btnrenk.TabIndex = 3;
            this.btnrenk.UseVisualStyleBackColor = false;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "YILI";
            // 
            // dtpyil
            // 
            this.dtpyil.CustomFormat = "yyyy";
            this.dtpyil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpyil.Location = new System.Drawing.Point(407, 73);
            this.dtpyil.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpyil.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpyil.Name = "dtpyil";
            this.dtpyil.Size = new System.Drawing.Size(108, 20);
            this.dtpyil.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "MOTOR TİPİ";
            // 
            // cmbmotortipi
            // 
            this.cmbmotortipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmotortipi.FormattingEnabled = true;
            this.cmbmotortipi.Items.AddRange(new object[] {
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "3.0",
            "3.5",
            "4.0"});
            this.cmbmotortipi.Location = new System.Drawing.Point(153, 72);
            this.cmbmotortipi.Name = "cmbmotortipi";
            this.cmbmotortipi.Size = new System.Drawing.Size(121, 21);
            this.cmbmotortipi.TabIndex = 1;
            this.cmbmotortipi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Coral;
            this.btnekle.Location = new System.Drawing.Point(521, 52);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 44);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(648, 297);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MARKA";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MODEL";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "YAKIT TİPİ";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KASA TİPİ";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "VİTES TİPİ";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MOTOR TİPİ";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "RENK";
            this.columnHeader7.Width = 83;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "URETİM YILI";
            this.columnHeader8.Width = 112;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Brown;
            this.btnsil.Location = new System.Drawing.Point(603, 53);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 43);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "TEMİZLE";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.BackColor = System.Drawing.Color.Orange;
            this.btnduzenle.Location = new System.Drawing.Point(684, 53);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(78, 40);
            this.btnduzenle.TabIndex = 9;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.UseVisualStyleBackColor = false;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.btnkaydet.Location = new System.Drawing.Point(687, 110);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 44);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 402);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dtpyil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnrenk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbvitestipi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbkasatipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbyakittipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbmotortipi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbmodel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbyakittipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbkasatipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbvitestipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpyil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbmotortipi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

