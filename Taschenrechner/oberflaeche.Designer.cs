namespace Taschenrechner
{
    partial class oberflaeche
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taschenrechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verlaufLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verlaufLöschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verlaufLöschenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn1 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.RichTextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnsln = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taschenrechnerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taschenrechnerToolStripMenuItem
            // 
            this.taschenrechnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verlaufLöschenToolStripMenuItem,
            this.verlaufLöschenToolStripMenuItem1,
            this.verlaufLöschenToolStripMenuItem2});
            this.taschenrechnerToolStripMenuItem.Name = "taschenrechnerToolStripMenuItem";
            this.taschenrechnerToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.taschenrechnerToolStripMenuItem.Text = "Taschenrechner";
            // 
            // verlaufLöschenToolStripMenuItem
            // 
            this.verlaufLöschenToolStripMenuItem.Name = "verlaufLöschenToolStripMenuItem";
            this.verlaufLöschenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verlaufLöschenToolStripMenuItem.Text = "Verlauf speichern";
            this.verlaufLöschenToolStripMenuItem.Click += new System.EventHandler(this.verlaufLöschenToolStripMenuItem_Click);
            // 
            // verlaufLöschenToolStripMenuItem1
            // 
            this.verlaufLöschenToolStripMenuItem1.Name = "verlaufLöschenToolStripMenuItem1";
            this.verlaufLöschenToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.verlaufLöschenToolStripMenuItem1.Text = "Verlauf laden";
            this.verlaufLöschenToolStripMenuItem1.Click += new System.EventHandler(this.verlaufLöschenToolStripMenuItem1_Click);
            // 
            // verlaufLöschenToolStripMenuItem2
            // 
            this.verlaufLöschenToolStripMenuItem2.Name = "verlaufLöschenToolStripMenuItem2";
            this.verlaufLöschenToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.verlaufLöschenToolStripMenuItem2.Text = "Verlauf löschen";
            this.verlaufLöschenToolStripMenuItem2.Click += new System.EventHandler(this.verlaufLöschenToolStripMenuItem2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 168);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 27);
            this.display.Name = "display";
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(371, 123);
            this.display.TabIndex = 2;
            this.display.Text = "";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(104, 168);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(192, 168);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 197);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(104, 197);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(192, 197);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 226);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(104, 226);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(192, 226);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(104, 255);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(294, 168);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(294, 197);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 23);
            this.btnminus.TabIndex = 13;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(294, 226);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 23);
            this.btnmul.TabIndex = 14;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(294, 255);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 15;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnsln
            // 
            this.btnsln.Location = new System.Drawing.Point(294, 364);
            this.btnsln.Name = "btnsln";
            this.btnsln.Size = new System.Drawing.Size(75, 23);
            this.btnsln.TabIndex = 16;
            this.btnsln.Text = "=";
            this.btnsln.UseVisualStyleBackColor = true;
            this.btnsln.Click += new System.EventHandler(this.btnsln_Click);
            // 
            // oberflaeche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 399);
            this.Controls.Add(this.btnsln);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "oberflaeche";
            this.Text = "Sprung\'scher Taschenrechner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taschenrechnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verlaufLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verlaufLöschenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verlaufLöschenToolStripMenuItem2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnsln;
    }
}

