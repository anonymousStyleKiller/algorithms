namespace SortAlgorithms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRandomNubmer = new System.Windows.Forms.TextBox();
            this.addRandomNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.addNumber = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxRandomNubmer);
            this.panel1.Controls.Add(this.addRandomNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNumber);
            this.panel1.Controls.Add(this.addNumber);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 153);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите кол-во случайных чисел:";
            // 
            // textBoxRandomNubmer
            // 
            this.textBoxRandomNubmer.Location = new System.Drawing.Point(10, 101);
            this.textBoxRandomNubmer.Name = "textBoxRandomNubmer";
            this.textBoxRandomNubmer.Size = new System.Drawing.Size(220, 20);
            this.textBoxRandomNubmer.TabIndex = 4;
            // 
            // addRandomNumber
            // 
            this.addRandomNumber.Location = new System.Drawing.Point(244, 99);
            this.addRandomNumber.Name = "addRandomNumber";
            this.addRandomNumber.Size = new System.Drawing.Size(117, 23);
            this.addRandomNumber.TabIndex = 3;
            this.addRandomNumber.Text = "Добавить";
            this.addRandomNumber.UseVisualStyleBackColor = true;
            this.addRandomNumber.Click += new System.EventHandler(this.addRandomNumber_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить числа:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(10, 33);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(220, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(244, 31);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(117, 23);
            this.addNumber.TabIndex = 0;
            this.addNumber.Text = "Добавить";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(382, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 153);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addRandomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxRandomNubmer;

        private System.Windows.Forms.Button addNumber;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}