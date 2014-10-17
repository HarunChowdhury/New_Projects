namespace ResultCalculationApp
{
    partial class ResultCalculationAppUI
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
            this.PhysicsTextBox = new System.Windows.Forms.TextBox();
            this.MathTextBox = new System.Windows.Forms.TextBox();
            this.ChemistryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgMarkTexBox = new System.Windows.Forms.TextBox();
            this.greadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhysicsTextBox
            // 
            this.PhysicsTextBox.Location = new System.Drawing.Point(69, 41);
            this.PhysicsTextBox.Name = "PhysicsTextBox";
            this.PhysicsTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhysicsTextBox.TabIndex = 0;
            // 
            // MathTextBox
            // 
            this.MathTextBox.Location = new System.Drawing.Point(69, 121);
            this.MathTextBox.Name = "MathTextBox";
            this.MathTextBox.Size = new System.Drawing.Size(100, 20);
            this.MathTextBox.TabIndex = 1;
            // 
            // ChemistryTextBox
            // 
            this.ChemistryTextBox.Location = new System.Drawing.Point(69, 80);
            this.ChemistryTextBox.Name = "ChemistryTextBox";
            this.ChemistryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChemistryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chemistry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Math";
            // 
            // avgMarkTexBox
            // 
            this.avgMarkTexBox.Location = new System.Drawing.Point(69, 169);
            this.avgMarkTexBox.Name = "avgMarkTexBox";
            this.avgMarkTexBox.Size = new System.Drawing.Size(100, 20);
            this.avgMarkTexBox.TabIndex = 6;
            // 
            // greadTextBox
            // 
            this.greadTextBox.Location = new System.Drawing.Point(69, 213);
            this.greadTextBox.Name = "greadTextBox";
            this.greadTextBox.Size = new System.Drawing.Size(100, 20);
            this.greadTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Avg Mark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gread";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(197, 117);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // ResultCalculationAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.greadTextBox);
            this.Controls.Add(this.avgMarkTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChemistryTextBox);
            this.Controls.Add(this.MathTextBox);
            this.Controls.Add(this.PhysicsTextBox);
            this.Name = "ResultCalculationAppUI";
            this.Text = "ResultCalculationAppUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhysicsTextBox;
        private System.Windows.Forms.TextBox MathTextBox;
        private System.Windows.Forms.TextBox ChemistryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avgMarkTexBox;
        private System.Windows.Forms.TextBox greadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showButton;
    }
}

