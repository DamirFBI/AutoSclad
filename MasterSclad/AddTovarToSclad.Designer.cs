﻿namespace AutoSclad.MasterSclad
{
    partial class AddTovarToSclad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddTovarToScladTapContorl = new System.Windows.Forms.TabPage();
            this.DeleteTovarToScladTapControl = new System.Windows.Forms.TabPage();
            this.CallGoScladTapControl = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.AddTovarToScladTapContorl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Закрыть";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddTovarToScladTapContorl);
            this.tabControl1.Controls.Add(this.DeleteTovarToScladTapControl);
            this.tabControl1.Controls.Add(this.CallGoScladTapControl);
            this.tabControl1.Location = new System.Drawing.Point(13, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 439);
            this.tabControl1.TabIndex = 1;
            // 
            // AddTovarToScladTapContorl
            // 
            this.AddTovarToScladTapContorl.Controls.Add(this.textBox3);
            this.AddTovarToScladTapContorl.Controls.Add(this.textBox2);
            this.AddTovarToScladTapContorl.Controls.Add(this.textBox1);
            this.AddTovarToScladTapContorl.Controls.Add(this.comboBox1);
            this.AddTovarToScladTapContorl.Controls.Add(this.label6);
            this.AddTovarToScladTapContorl.Controls.Add(this.label5);
            this.AddTovarToScladTapContorl.Controls.Add(this.label4);
            this.AddTovarToScladTapContorl.Controls.Add(this.label3);
            this.AddTovarToScladTapContorl.Controls.Add(this.label2);
            this.AddTovarToScladTapContorl.Location = new System.Drawing.Point(4, 22);
            this.AddTovarToScladTapContorl.Name = "AddTovarToScladTapContorl";
            this.AddTovarToScladTapContorl.Padding = new System.Windows.Forms.Padding(3);
            this.AddTovarToScladTapContorl.Size = new System.Drawing.Size(556, 413);
            this.AddTovarToScladTapContorl.TabIndex = 0;
            this.AddTovarToScladTapContorl.Text = "Добавление на склад товара";
            this.AddTovarToScladTapContorl.UseVisualStyleBackColor = true;
            // 
            // DeleteTovarToScladTapControl
            // 
            this.DeleteTovarToScladTapControl.Location = new System.Drawing.Point(4, 22);
            this.DeleteTovarToScladTapControl.Name = "DeleteTovarToScladTapControl";
            this.DeleteTovarToScladTapControl.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteTovarToScladTapControl.Size = new System.Drawing.Size(556, 413);
            this.DeleteTovarToScladTapControl.TabIndex = 1;
            this.DeleteTovarToScladTapControl.Text = "Списание товара";
            this.DeleteTovarToScladTapControl.UseVisualStyleBackColor = true;
            // 
            // CallGoScladTapControl
            // 
            this.CallGoScladTapControl.Location = new System.Drawing.Point(4, 22);
            this.CallGoScladTapControl.Name = "CallGoScladTapControl";
            this.CallGoScladTapControl.Size = new System.Drawing.Size(556, 413);
            this.CallGoScladTapControl.TabIndex = 2;
            this.CallGoScladTapControl.Text = "Запросы работника";
            this.CallGoScladTapControl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование склада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Размеры товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Глубина";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ширина";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // AddTovarToSclad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTovarToSclad";
            this.Text = "AddTovarToSclad";
            this.tabControl1.ResumeLayout(false);
            this.AddTovarToScladTapContorl.ResumeLayout(false);
            this.AddTovarToScladTapContorl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddTovarToScladTapContorl;
        private System.Windows.Forms.TabPage DeleteTovarToScladTapControl;
        private System.Windows.Forms.TabPage CallGoScladTapControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}