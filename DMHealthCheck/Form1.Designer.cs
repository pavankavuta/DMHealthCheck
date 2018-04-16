namespace DMHealthCheck
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
            this.chkAmendDefaultData = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtFlatNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtHouseName = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIDCheckStatus = new System.Windows.Forms.Label();
            this.lblBankCheckStatus = new System.Windows.Forms.Label();
            this.lblSIRACheckStatus = new System.Windows.Forms.Label();
            this.lblOverallDecision = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblApplicationNo = new System.Windows.Forms.Label();
            this.chkEnfBankChk = new System.Windows.Forms.CheckBox();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.lblErrMsgText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAD = new System.Windows.Forms.Label();
            this.cmbDecision = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAmendDefaultData
            // 
            this.chkAmendDefaultData.AutoSize = true;
            this.chkAmendDefaultData.Location = new System.Drawing.Point(23, 44);
            this.chkAmendDefaultData.Name = "chkAmendDefaultData";
            this.chkAmendDefaultData.Size = new System.Drawing.Size(122, 17);
            this.chkAmendDefaultData.TabIndex = 0;
            this.chkAmendDefaultData.Text = "Amend Default Data";
            this.chkAmendDefaultData.UseVisualStyleBackColor = true;
            this.chkAmendDefaultData.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.cmbTitle);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(91, 101);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(116, 20);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.Value = new System.DateTime(1970, 8, 1, 0, 0, 0, 0);
            // 
            // cmbTitle
            // 
            this.cmbTitle.Enabled = false;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Items.AddRange(new object[] {
            "Ms",
            "Mrs",
            "Mr"});
            this.cmbTitle.Location = new System.Drawing.Point(91, 23);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(116, 21);
            this.cmbTitle.TabIndex = 1;
            this.cmbTitle.Text = "Ms";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(91, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(116, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Text = "Seal";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(91, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(116, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Text = "Sally";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.txtFlatNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPostCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTown);
            this.groupBox2.Controls.Add(this.txtHouseName);
            this.groupBox2.Controls.Add(this.txtHouseNo);
            this.groupBox2.Location = new System.Drawing.Point(23, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Post Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Town";
            // 
            // txtStreet
            // 
            this.txtStreet.Enabled = false;
            this.txtStreet.Location = new System.Drawing.Point(91, 96);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(116, 20);
            this.txtStreet.TabIndex = 8;
            this.txtStreet.Text = "ZOOFIELD GROVE";
            // 
            // txtFlatNo
            // 
            this.txtFlatNo.Enabled = false;
            this.txtFlatNo.Location = new System.Drawing.Point(91, 19);
            this.txtFlatNo.Name = "txtFlatNo";
            this.txtFlatNo.Size = new System.Drawing.Size(116, 20);
            this.txtFlatNo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Flat No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "House Name";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Enabled = false;
            this.txtPostCode.Location = new System.Drawing.Point(91, 148);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(116, 20);
            this.txtPostCode.TabIndex = 10;
            this.txtPostCode.Text = "X9 9AD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "House No";
            // 
            // txtTown
            // 
            this.txtTown.Enabled = false;
            this.txtTown.Location = new System.Drawing.Point(91, 123);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(116, 20);
            this.txtTown.TabIndex = 9;
            this.txtTown.Text = "TEST TOWN";
            // 
            // txtHouseName
            // 
            this.txtHouseName.Enabled = false;
            this.txtHouseName.Location = new System.Drawing.Point(91, 71);
            this.txtHouseName.Name = "txtHouseName";
            this.txtHouseName.Size = new System.Drawing.Size(116, 20);
            this.txtHouseName.TabIndex = 7;
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Enabled = false;
            this.txtHouseNo.Location = new System.Drawing.Point(91, 46);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(116, 20);
            this.txtHouseNo.TabIndex = 6;
            this.txtHouseNo.Text = "24";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtAcctNo);
            this.groupBox3.Controls.Add(this.txtSortCode);
            this.groupBox3.Location = new System.Drawing.Point(23, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bank Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Acct No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sort Code";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Enabled = false;
            this.txtAcctNo.Location = new System.Drawing.Point(91, 44);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(116, 20);
            this.txtAcctNo.TabIndex = 12;
            this.txtAcctNo.Text = "29250201";
            // 
            // txtSortCode
            // 
            this.txtSortCode.Enabled = false;
            this.txtSortCode.Location = new System.Drawing.Point(91, 19);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(116, 20);
            this.txtSortCode.TabIndex = 11;
            this.txtSortCode.Text = "999998";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(242, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(458, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIDCheckStatus
            // 
            this.lblIDCheckStatus.AutoSize = true;
            this.lblIDCheckStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCheckStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIDCheckStatus.Location = new System.Drawing.Point(487, 83);
            this.lblIDCheckStatus.Name = "lblIDCheckStatus";
            this.lblIDCheckStatus.Size = new System.Drawing.Size(0, 19);
            this.lblIDCheckStatus.TabIndex = 5;
            // 
            // lblBankCheckStatus
            // 
            this.lblBankCheckStatus.AutoSize = true;
            this.lblBankCheckStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankCheckStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBankCheckStatus.Location = new System.Drawing.Point(487, 149);
            this.lblBankCheckStatus.Name = "lblBankCheckStatus";
            this.lblBankCheckStatus.Size = new System.Drawing.Size(0, 19);
            this.lblBankCheckStatus.TabIndex = 6;
            // 
            // lblSIRACheckStatus
            // 
            this.lblSIRACheckStatus.AutoSize = true;
            this.lblSIRACheckStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIRACheckStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSIRACheckStatus.Location = new System.Drawing.Point(487, 209);
            this.lblSIRACheckStatus.Name = "lblSIRACheckStatus";
            this.lblSIRACheckStatus.Size = new System.Drawing.Size(0, 19);
            this.lblSIRACheckStatus.TabIndex = 7;
            // 
            // lblOverallDecision
            // 
            this.lblOverallDecision.AutoSize = true;
            this.lblOverallDecision.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallDecision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOverallDecision.Location = new System.Drawing.Point(487, 305);
            this.lblOverallDecision.Name = "lblOverallDecision";
            this.lblOverallDecision.Size = new System.Drawing.Size(0, 26);
            this.lblOverallDecision.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Purple;
            this.label17.Location = new System.Drawing.Point(308, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 26);
            this.label17.TabIndex = 12;
            this.label17.Text = "Overall Decision";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(320, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 11;
            this.label18.Text = "SIRA Check ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(320, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 19);
            this.label19.TabIndex = 10;
            this.label19.Text = "Bank Check";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkBlue;
            this.label20.Location = new System.Drawing.Point(320, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 19);
            this.label20.TabIndex = 9;
            this.label20.Text = "ID Check";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Purple;
            this.label21.Location = new System.Drawing.Point(308, 374);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 26);
            this.label21.TabIndex = 14;
            this.label21.Text = "Application No";
            // 
            // lblApplicationNo
            // 
            this.lblApplicationNo.AutoSize = true;
            this.lblApplicationNo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblApplicationNo.Location = new System.Drawing.Point(486, 374);
            this.lblApplicationNo.Name = "lblApplicationNo";
            this.lblApplicationNo.Size = new System.Drawing.Size(0, 26);
            this.lblApplicationNo.TabIndex = 13;
            // 
            // chkEnfBankChk
            // 
            this.chkEnfBankChk.AutoSize = true;
            this.chkEnfBankChk.Enabled = false;
            this.chkEnfBankChk.Location = new System.Drawing.Point(23, 395);
            this.chkEnfBankChk.Name = "chkEnfBankChk";
            this.chkEnfBankChk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEnfBankChk.Size = new System.Drawing.Size(125, 17);
            this.chkEnfBankChk.TabIndex = 13;
            this.chkEnfBankChk.Text = "Enforce Bank Check";
            this.chkEnfBankChk.UseVisualStyleBackColor = true;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMsg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblErrMsg.Location = new System.Drawing.Point(320, 259);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(106, 19);
            this.lblErrMsg.TabIndex = 16;
            this.lblErrMsg.Text = "Error Message";
            this.lblErrMsg.Visible = false;
            // 
            // lblErrMsgText
            // 
            this.lblErrMsgText.AutoSize = true;
            this.lblErrMsgText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMsgText.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsgText.Location = new System.Drawing.Point(487, 259);
            this.lblErrMsgText.MaximumSize = new System.Drawing.Size(224, 19);
            this.lblErrMsgText.Name = "lblErrMsgText";
            this.lblErrMsgText.Size = new System.Drawing.Size(0, 13);
            this.lblErrMsgText.TabIndex = 15;
            this.lblErrMsgText.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(242, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(458, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(4, 15);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(104, 13);
            this.lblAD.TabIndex = 19;
            this.lblAD.Text = "Anticipated Decision";
            // 
            // cmbDecision
            // 
            this.cmbDecision.FormattingEnabled = true;
            this.cmbDecision.Items.AddRange(new object[] {
            "Accept",
            "Refer",
            "Decline"});
            this.cmbDecision.Location = new System.Drawing.Point(114, 12);
            this.cmbDecision.Name = "cmbDecision";
            this.cmbDecision.Size = new System.Drawing.Size(116, 21);
            this.cmbDecision.TabIndex = 18;
            this.cmbDecision.Text = "Accept";
            this.cmbDecision.SelectedIndexChanged += new System.EventHandler(this.cmbDecision_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(712, 498);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.cmbDecision);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblErrMsg);
            this.Controls.Add(this.lblErrMsgText);
            this.Controls.Add(this.chkEnfBankChk);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblApplicationNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblOverallDecision);
            this.Controls.Add(this.lblSIRACheckStatus);
            this.Controls.Add(this.lblBankCheckStatus);
            this.Controls.Add(this.lblIDCheckStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAmendDefaultData);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Decision Metrics Service Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAmendDefaultData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtFlatNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtHouseName;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIDCheckStatus;
        private System.Windows.Forms.Label lblBankCheckStatus;
        private System.Windows.Forms.Label lblSIRACheckStatus;
        private System.Windows.Forms.Label lblOverallDecision;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblApplicationNo;
        private System.Windows.Forms.CheckBox chkEnfBankChk;
        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.Label lblErrMsgText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.ComboBox cmbDecision;
    }
}

