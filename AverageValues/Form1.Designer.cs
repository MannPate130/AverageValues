
namespace AverageValues
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
            this.averageNumbertitle = new System.Windows.Forms.Label();
            this.enterNumberlabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averageNumbertitle
            // 
            this.averageNumbertitle.BackColor = System.Drawing.Color.DarkRed;
            this.averageNumbertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageNumbertitle.ForeColor = System.Drawing.Color.White;
            this.averageNumbertitle.Location = new System.Drawing.Point(1, -3);
            this.averageNumbertitle.Name = "averageNumbertitle";
            this.averageNumbertitle.Size = new System.Drawing.Size(799, 69);
            this.averageNumbertitle.TabIndex = 0;
            this.averageNumbertitle.Text = "Average Number Solver";
            this.averageNumbertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterNumberlabel
            // 
            this.enterNumberlabel.AutoSize = true;
            this.enterNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNumberlabel.ForeColor = System.Drawing.Color.White;
            this.enterNumberlabel.Location = new System.Drawing.Point(177, 117);
            this.enterNumberlabel.Name = "enterNumberlabel";
            this.enterNumberlabel.Size = new System.Drawing.Size(412, 32);
            this.enterNumberlabel.TabIndex = 1;
            this.enterNumberlabel.Text = "Enter a Number and Press Add ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(211, 174);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(322, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "(enter 0 and press Add to calculate average)";
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(311, 235);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(69, 26);
            this.inputTextbox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(386, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(217, 292);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(316, 64);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(686, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.enterNumberlabel);
            this.Controls.Add(this.averageNumbertitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label averageNumbertitle;
        private System.Windows.Forms.Label enterNumberlabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button button1;
    }
}

