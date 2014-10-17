namespace Bank_Account_App
{
    partial class PersonUIForm
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
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.widthdrawButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.accountCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.transectionGroupBox = new System.Windows.Forms.GroupBox();
            this.accountCreationGroupBox.SuspendLayout();
            this.transectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(8, 26);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "Account Number";
            this.accountNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(13, 61);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(37, 35);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(101, 23);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(227, 20);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(101, 58);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(101, 32);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(193, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(253, 91);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(113, 72);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // widthdrawButton
            // 
            this.widthdrawButton.Location = new System.Drawing.Point(207, 72);
            this.widthdrawButton.Name = "widthdrawButton";
            this.widthdrawButton.Size = new System.Drawing.Size(75, 23);
            this.widthdrawButton.TabIndex = 6;
            this.widthdrawButton.Text = "Widthdraw";
            this.widthdrawButton.UseVisualStyleBackColor = true;
            this.widthdrawButton.Click += new System.EventHandler(this.widthdraw_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(167, 272);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 7;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // accountCreationGroupBox
            // 
            this.accountCreationGroupBox.Controls.Add(this.customerNameTextBox);
            this.accountCreationGroupBox.Controls.Add(this.accountNumberLabel);
            this.accountCreationGroupBox.Controls.Add(this.customerNameLabel);
            this.accountCreationGroupBox.Controls.Add(this.createButton);
            this.accountCreationGroupBox.Controls.Add(this.accountNumberTextBox);
            this.accountCreationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.accountCreationGroupBox.Name = "accountCreationGroupBox";
            this.accountCreationGroupBox.Size = new System.Drawing.Size(359, 131);
            this.accountCreationGroupBox.TabIndex = 12;
            this.accountCreationGroupBox.TabStop = false;
            this.accountCreationGroupBox.Text = "Account Creation";
            // 
            // transectionGroupBox
            // 
            this.transectionGroupBox.Controls.Add(this.depositButton);
            this.transectionGroupBox.Controls.Add(this.amountLabel);
            this.transectionGroupBox.Controls.Add(this.widthdrawButton);
            this.transectionGroupBox.Controls.Add(this.amountTextBox);
            this.transectionGroupBox.Location = new System.Drawing.Point(12, 149);
            this.transectionGroupBox.Name = "transectionGroupBox";
            this.transectionGroupBox.Size = new System.Drawing.Size(359, 117);
            this.transectionGroupBox.TabIndex = 0;
            this.transectionGroupBox.TabStop = false;
            this.transectionGroupBox.Text = "Transection";
            // 
            // PersonUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 307);
            this.Controls.Add(this.transectionGroupBox);
            this.Controls.Add(this.accountCreationGroupBox);
            this.Controls.Add(this.reportButton);
            this.Name = "PersonUIForm";
            this.Text = "Person UI";
            this.accountCreationGroupBox.ResumeLayout(false);
            this.accountCreationGroupBox.PerformLayout();
            this.transectionGroupBox.ResumeLayout(false);
            this.transectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button widthdrawButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.GroupBox accountCreationGroupBox;
        private System.Windows.Forms.GroupBox transectionGroupBox;
    }
}

