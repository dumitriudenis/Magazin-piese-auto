namespace WindowsFormsApp2
{
    partial class Client_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.albToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esteticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaPretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descrescatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaNumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descrescatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ssdsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.Product_name_TextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 277);
            this.dataGridView1.TabIndex = 59;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albToolStripMenuItem,
            this.rotiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // albToolStripMenuItem
            // 
            this.albToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spateToolStripMenuItem,
            this.motorToolStripMenuItem,
            this.esteticaToolStripMenuItem,
            this.confortToolStripMenuItem});
            this.albToolStripMenuItem.Name = "albToolStripMenuItem";
            this.albToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.albToolStripMenuItem.Text = "Categorie";
            this.albToolStripMenuItem.Click += new System.EventHandler(this.albToolStripMenuItem_Click);
            // 
            // spateToolStripMenuItem
            // 
            this.spateToolStripMenuItem.Name = "spateToolStripMenuItem";
            this.spateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.spateToolStripMenuItem.Text = "caroserie";
            this.spateToolStripMenuItem.Click += new System.EventHandler(this.spateToolStripMenuItem_Click);
            // 
            // motorToolStripMenuItem
            // 
            this.motorToolStripMenuItem.Name = "motorToolStripMenuItem";
            this.motorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.motorToolStripMenuItem.Text = "motor";
            this.motorToolStripMenuItem.Click += new System.EventHandler(this.motorToolStripMenuItem_Click);
            // 
            // esteticaToolStripMenuItem
            // 
            this.esteticaToolStripMenuItem.Name = "esteticaToolStripMenuItem";
            this.esteticaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.esteticaToolStripMenuItem.Text = "estetica";
            this.esteticaToolStripMenuItem.Click += new System.EventHandler(this.esteticaToolStripMenuItem_Click);
            // 
            // confortToolStripMenuItem
            // 
            this.confortToolStripMenuItem.Name = "confortToolStripMenuItem";
            this.confortToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.confortToolStripMenuItem.Text = "confort";
            this.confortToolStripMenuItem.Click += new System.EventHandler(this.confortToolStripMenuItem_Click);
            // 
            // rotiToolStripMenuItem
            // 
            this.rotiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dupaPretToolStripMenuItem,
            this.dupaNumeToolStripMenuItem});
            this.rotiToolStripMenuItem.Name = "rotiToolStripMenuItem";
            this.rotiToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.rotiToolStripMenuItem.Text = "Ordonare";
            // 
            // dupaPretToolStripMenuItem
            // 
            this.dupaPretToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescatorToolStripMenuItem,
            this.descrescatorToolStripMenuItem});
            this.dupaPretToolStripMenuItem.Name = "dupaPretToolStripMenuItem";
            this.dupaPretToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dupaPretToolStripMenuItem.Text = "Dupa pret";
            // 
            // crescatorToolStripMenuItem
            // 
            this.crescatorToolStripMenuItem.Name = "crescatorToolStripMenuItem";
            this.crescatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crescatorToolStripMenuItem.Text = "crescator";
            this.crescatorToolStripMenuItem.Click += new System.EventHandler(this.crescatorToolStripMenuItem_Click);
            // 
            // descrescatorToolStripMenuItem
            // 
            this.descrescatorToolStripMenuItem.Name = "descrescatorToolStripMenuItem";
            this.descrescatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descrescatorToolStripMenuItem.Text = "descrescator";
            this.descrescatorToolStripMenuItem.Click += new System.EventHandler(this.descrescatorToolStripMenuItem_Click);
            // 
            // dupaNumeToolStripMenuItem
            // 
            this.dupaNumeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescatorToolStripMenuItem1,
            this.descrescatorToolStripMenuItem1});
            this.dupaNumeToolStripMenuItem.Name = "dupaNumeToolStripMenuItem";
            this.dupaNumeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dupaNumeToolStripMenuItem.Text = "Dupa nume";
            // 
            // crescatorToolStripMenuItem1
            // 
            this.crescatorToolStripMenuItem1.Name = "crescatorToolStripMenuItem1";
            this.crescatorToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.crescatorToolStripMenuItem1.Text = "crescator";
            this.crescatorToolStripMenuItem1.Click += new System.EventHandler(this.crescatorToolStripMenuItem1_Click);
            // 
            // descrescatorToolStripMenuItem1
            // 
            this.descrescatorToolStripMenuItem1.Name = "descrescatorToolStripMenuItem1";
            this.descrescatorToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.descrescatorToolStripMenuItem1.Text = "descrescator";
            this.descrescatorToolStripMenuItem1.Click += new System.EventHandler(this.descrescatorToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssdsdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // ssdsdToolStripMenuItem
            // 
            this.ssdsdToolStripMenuItem.Name = "ssdsdToolStripMenuItem";
            this.ssdsdToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ssdsdToolStripMenuItem.Text = "ssdsd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 62;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Pentru a adauga un produs in cosul de cumparaturi, trebuie sa notati id-ul produs" +
    "ului si sa dati click pe Adaugati in Cos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 64;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 13);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inserati ID-ul Produsului";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 66;
            this.button2.Text = "Adaugare Cos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Product_name_TextBox
            // 
            this.Product_name_TextBox.Location = new System.Drawing.Point(739, 80);
            this.Product_name_TextBox.Name = "Product_name_TextBox";
            this.Product_name_TextBox.Size = new System.Drawing.Size(114, 20);
            this.Product_name_TextBox.TabIndex = 70;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(739, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 69;
            this.button6.Text = "Search product";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 514);
            this.Controls.Add(this.Product_name_TextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client_form";
            this.Text = "Client_form";
            this.Load += new System.EventHandler(this.Client_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem albToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ssdsdToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem spateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esteticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaPretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descrescatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaNumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descrescatorToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Product_name_TextBox;
        private System.Windows.Forms.Button button6;
    }
}