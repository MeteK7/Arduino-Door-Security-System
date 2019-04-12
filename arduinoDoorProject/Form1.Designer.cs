namespace arduinoDoorProject
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
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPortName = new System.Windows.Forms.Label();
            this.port_name_tb = new System.Windows.Forms.TextBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.txtPersonAvail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_tb = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnManagePerson = new System.Windows.Forms.Button();
            this.cboPerson = new System.Windows.Forms.ComboBox();
            this.lblChsPerson = new System.Windows.Forms.Label();
            this.lvPerson = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntrance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tabPage1);
            this.tbMain.Controls.Add(this.tabPage2);
            this.tbMain.Location = new System.Drawing.Point(12, 12);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(1076, 811);
            this.tbMain.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.lblPortName);
            this.tabPage1.Controls.Add(this.port_name_tb);
            this.tabPage1.Controls.Add(this.stop_btn);
            this.tabPage1.Controls.Add(this.start_btn);
            this.tabPage1.Controls.Add(this.txtPersonAvail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.data_tb);
            this.tabPage1.Controls.Add(this.btnAdmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 782);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(18, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(307, 33);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status: Door is closed.";
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortName.Location = new System.Drawing.Point(835, 370);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(89, 20);
            this.lblPortName.TabIndex = 14;
            this.lblPortName.Text = "Port Name";
            // 
            // port_name_tb
            // 
            this.port_name_tb.Location = new System.Drawing.Point(930, 370);
            this.port_name_tb.Name = "port_name_tb";
            this.port_name_tb.Size = new System.Drawing.Size(101, 22);
            this.port_name_tb.TabIndex = 13;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(836, 574);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(195, 73);
            this.stop_btn.TabIndex = 12;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(836, 495);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(195, 73);
            this.start_btn.TabIndex = 11;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // txtPersonAvail
            // 
            this.txtPersonAvail.Location = new System.Drawing.Point(452, 239);
            this.txtPersonAvail.Multiline = true;
            this.txtPersonAvail.Name = "txtPersonAvail";
            this.txtPersonAvail.Size = new System.Drawing.Size(354, 516);
            this.txtPersonAvail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(342, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Real Time Events";
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(24, 239);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.Size = new System.Drawing.Size(422, 516);
            this.data_tb.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(836, 653);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(195, 73);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnManagePerson);
            this.tabPage2.Controls.Add(this.cboPerson);
            this.tabPage2.Controls.Add(this.lblChsPerson);
            this.tabPage2.Controls.Add(this.lvPerson);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 782);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LOG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnManagePerson
            // 
            this.btnManagePerson.Location = new System.Drawing.Point(807, 29);
            this.btnManagePerson.Name = "btnManagePerson";
            this.btnManagePerson.Size = new System.Drawing.Size(134, 73);
            this.btnManagePerson.TabIndex = 3;
            this.btnManagePerson.Text = "MANAGE";
            this.btnManagePerson.UseVisualStyleBackColor = true;
            this.btnManagePerson.Click += new System.EventHandler(this.btnManagePerson_Click);
            // 
            // cboPerson
            // 
            this.cboPerson.FormattingEnabled = true;
            this.cboPerson.Location = new System.Drawing.Point(203, 26);
            this.cboPerson.Name = "cboPerson";
            this.cboPerson.Size = new System.Drawing.Size(154, 24);
            this.cboPerson.TabIndex = 2;
            this.cboPerson.DropDownClosed += new System.EventHandler(this.cboPerson_DropDownClosed);
            // 
            // lblChsPerson
            // 
            this.lblChsPerson.AutoSize = true;
            this.lblChsPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChsPerson.Location = new System.Drawing.Point(14, 24);
            this.lblChsPerson.Name = "lblChsPerson";
            this.lblChsPerson.Size = new System.Drawing.Size(183, 26);
            this.lblChsPerson.TabIndex = 1;
            this.lblChsPerson.Text = "Choose a person:";
            // 
            // lvPerson
            // 
            this.lvPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chEntrance,
            this.chExit,
            this.chAvailability});
            this.lvPerson.Location = new System.Drawing.Point(17, 136);
            this.lvPerson.Name = "lvPerson";
            this.lvPerson.Size = new System.Drawing.Size(761, 640);
            this.lvPerson.TabIndex = 0;
            this.lvPerson.UseCompatibleStateImageBehavior = false;
            this.lvPerson.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 140;
            // 
            // chName
            // 
            this.chName.Text = "Full Name";
            this.chName.Width = 140;
            // 
            // chEntrance
            // 
            this.chEntrance.Text = "Entrance";
            this.chEntrance.Width = 140;
            // 
            // chExit
            // 
            this.chExit.Text = "Exit";
            this.chExit.Width = 140;
            // 
            // chAvailability
            // 
            this.chAvailability.Text = "Availability";
            this.chAvailability.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 835);
            this.Controls.Add(this.tbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox data_tb;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.TextBox port_name_tb;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox txtPersonAvail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPerson;
        private System.Windows.Forms.Label lblChsPerson;
        private System.Windows.Forms.ListView lvPerson;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chEntrance;
        private System.Windows.Forms.ColumnHeader chExit;
        private System.Windows.Forms.ColumnHeader chAvailability;
        private System.Windows.Forms.Button btnManagePerson;
    }
}

