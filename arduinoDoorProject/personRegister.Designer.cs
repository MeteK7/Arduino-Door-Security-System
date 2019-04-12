namespace arduinoDoorProject
{
    partial class personRegister
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.btnDelPerson = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(219, 63);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(198, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(219, 128);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(198, 22);
            this.txtCardNumber.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(42, 63);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "FullName:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(42, 128);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(96, 17);
            this.lblCardNumber.TabIndex = 3;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Location = new System.Drawing.Point(125, 227);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(112, 67);
            this.btnSavePerson.TabIndex = 4;
            this.btnSavePerson.Text = "Save";
            this.btnSavePerson.UseVisualStyleBackColor = true;
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // btnDelPerson
            // 
            this.btnDelPerson.Location = new System.Drawing.Point(268, 227);
            this.btnDelPerson.Name = "btnDelPerson";
            this.btnDelPerson.Size = new System.Drawing.Size(112, 67);
            this.btnDelPerson.TabIndex = 5;
            this.btnDelPerson.Text = "Delete";
            this.btnDelPerson.UseVisualStyleBackColor = true;
            this.btnDelPerson.Click += new System.EventHandler(this.btnDelPerson_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(23, 181);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 29);
            this.lblWarning.TabIndex = 6;
            // 
            // personRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 306);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnDelPerson);
            this.Controls.Add(this.btnSavePerson);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtFullName);
            this.Name = "personRegister";
            this.Text = "personRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Button btnSavePerson;
        private System.Windows.Forms.Button btnDelPerson;
        private System.Windows.Forms.Label lblWarning;
    }
}