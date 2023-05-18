﻿namespace WindowsFormsApp1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Addbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Maximax = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimax = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Minmaxbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MinimaxRegert = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Minimaxregertbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Equallylike = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Equallybtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(16, 15);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroup1.Panel.Controls.Add(this.textBox4);
            this.kryptonGroup1.Panel.Controls.Add(this.textBox3);
            this.kryptonGroup1.Panel.Controls.Add(this.textBox2);
            this.kryptonGroup1.Panel.Controls.Add(this.Addbtn);
            this.kryptonGroup1.Size = new System.Drawing.Size(375, 442);
            this.kryptonGroup1.TabIndex = 3;
            this.kryptonGroup1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup1_Paint);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(27, 193);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(54, 24);
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "Boom";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(27, 138);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(66, 24);
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Normal";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(27, 82);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 24);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Recession";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 193);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 138);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 6;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(99, 359);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(120, 31);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Values.Text = "Add";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(537, 226);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(120, 31);
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Text = "Maximax";
            this.kryptonButton1.Click += new System.EventHandler(this.MaxiMaxbtn);
            // 
            // Maximax
            // 
            this.Maximax.Location = new System.Drawing.Point(765, 226);
            this.Maximax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Maximax.Name = "Maximax";
            this.Maximax.Size = new System.Drawing.Size(208, 27);
            this.Maximax.TabIndex = 6;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(537, 11);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(505, 185);
            this.kryptonDataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Recession";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Normal";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Boom";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Minimax
            // 
            this.Minimax.Location = new System.Drawing.Point(765, 284);
            this.Minimax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minimax.Name = "Minimax";
            this.Minimax.Size = new System.Drawing.Size(208, 27);
            this.Minimax.TabIndex = 9;
            // 
            // Minmaxbtn
            // 
            this.Minmaxbtn.Location = new System.Drawing.Point(537, 284);
            this.Minmaxbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minmaxbtn.Name = "Minmaxbtn";
            this.Minmaxbtn.Size = new System.Drawing.Size(120, 31);
            this.Minmaxbtn.TabIndex = 8;
            this.Minmaxbtn.Values.Text = "Minmax";
            this.Minmaxbtn.Click += new System.EventHandler(this.Minmaxbtn_Click);
            // 
            // MinimaxRegert
            // 
            this.MinimaxRegert.Location = new System.Drawing.Point(765, 394);
            this.MinimaxRegert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimaxRegert.Name = "MinimaxRegert";
            this.MinimaxRegert.Size = new System.Drawing.Size(212, 27);
            this.MinimaxRegert.TabIndex = 11;
            // 
            // Minimaxregertbtn
            // 
            this.Minimaxregertbtn.Location = new System.Drawing.Point(537, 391);
            this.Minimaxregertbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minimaxregertbtn.Name = "Minimaxregertbtn";
            this.Minimaxregertbtn.Size = new System.Drawing.Size(140, 31);
            this.Minimaxregertbtn.TabIndex = 10;
            this.Minimaxregertbtn.Values.Text = "MinimaxRegret";
            this.Minimaxregertbtn.Click += new System.EventHandler(this.MinimaxRegretbtn_Click);
            // 
            // Equallylike
            // 
            this.Equallylike.Location = new System.Drawing.Point(765, 337);
            this.Equallylike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Equallylike.Name = "Equallylike";
            this.Equallylike.Size = new System.Drawing.Size(212, 27);
            this.Equallylike.TabIndex = 13;
            // 
            // Equallybtn
            // 
            this.Equallybtn.Location = new System.Drawing.Point(537, 337);
            this.Equallybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Equallybtn.Name = "Equallybtn";
            this.Equallybtn.Size = new System.Drawing.Size(120, 31);
            this.Equallybtn.TabIndex = 12;
            this.Equallybtn.Values.Text = "Equally likely";
            this.Equallybtn.Click += new System.EventHandler(this.Equallybtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1192, 519);
            this.Controls.Add(this.Equallylike);
            this.Controls.Add(this.Equallybtn);
            this.Controls.Add(this.MinimaxRegert);
            this.Controls.Add(this.Minimaxregertbtn);
            this.Controls.Add(this.Minimax);
            this.Controls.Add(this.Minmaxbtn);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.Maximax);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonGroup1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Addbtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Maximax;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Minimax;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Minmaxbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox MinimaxRegert;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Minimaxregertbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Equallylike;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Equallybtn;
    }
}

