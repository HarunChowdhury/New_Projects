namespace PersonApps
{
    partial class PersonForm
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
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.lastTextBox = new System.Windows.Forms.TextBox();
            this.fullTextBox = new System.Windows.Forms.TextBox();
            this.reverseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "first name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "middle name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(97, 25);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(144, 20);
            this.firstTextBox.TabIndex = 3;
            // 
            // middleTextBox
            // 
            this.middleTextBox.Location = new System.Drawing.Point(97, 59);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(144, 20);
            this.middleTextBox.TabIndex = 4;
            // 
            // lastTextBox
            // 
            this.lastTextBox.Location = new System.Drawing.Point(97, 95);
            this.lastTextBox.Name = "lastTextBox";
            this.lastTextBox.Size = new System.Drawing.Size(144, 20);
            this.lastTextBox.TabIndex = 5;
            // 
            // fullTextBox
            // 
            this.fullTextBox.Location = new System.Drawing.Point(107, 140);
            this.fullTextBox.Name = "fullTextBox";
            this.fullTextBox.Size = new System.Drawing.Size(228, 20);
            this.fullTextBox.TabIndex = 6;
            // 
            // reverseTextBox
            // 
            this.reverseTextBox.Location = new System.Drawing.Point(107, 168);
            this.reverseTextBox.Name = "reverseTextBox";
            this.reverseTextBox.Size = new System.Drawing.Size(228, 20);
            this.reverseTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Full name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reverse Name";
            // 
            // fullButton
            // 
            this.fullButton.Location = new System.Drawing.Point(247, 36);
            this.fullButton.Name = "fullButton";
            this.fullButton.Size = new System.Drawing.Size(88, 35);
            this.fullButton.TabIndex = 10;
            this.fullButton.Text = "Full name";
            this.fullButton.UseVisualStyleBackColor = true;
            this.fullButton.Click += new System.EventHandler(this.fullButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(247, 82);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(88, 33);
            this.reverseButton.TabIndex = 11;
            this.reverseButton.Text = "Reverse name";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reverseButton);
            this.groupBox1.Controls.Add(this.fullButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.reverseTextBox);
            this.groupBox1.Controls.Add(this.fullTextBox);
            this.groupBox1.Controls.Add(this.lastTextBox);
            this.groupBox1.Controls.Add(this.middleTextBox);
            this.groupBox1.Controls.Add(this.firstTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name Information";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 255);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonForm";
            this.Text = "Person App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox middleTextBox;
        private System.Windows.Forms.TextBox lastTextBox;
        private System.Windows.Forms.TextBox fullTextBox;
        private System.Windows.Forms.TextBox reverseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fullButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

