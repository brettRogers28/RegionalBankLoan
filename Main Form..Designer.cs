namespace Project2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.aprComboBox = new System.Windows.Forms.ComboBox();
            this.amortizationListView = new System.Windows.Forms.ListView();
            this.columnHeader0 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.interestTotalLabel = new System.Windows.Forms.Label();
            this.loanTotalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thirtyRadioButton = new System.Windows.Forms.RadioButton();
            this.fifteenRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyRadioButton = new System.Windows.Forms.RadioButton();
            this.tenRadioButton = new System.Windows.Forms.RadioButton();
            this.loanAmtTextBox = new System.Windows.Forms.TextBox();
            this.purposeTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.displayTotalButton = new System.Windows.Forms.Button();
            this.displayLoanButton = new System.Windows.Forms.Button();
            this.loanListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.avgLoanListLabel = new System.Windows.Forms.Label();
            this.totalLoanListLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1466, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rebateTextBox);
            this.tabPage1.Controls.Add(this.aprComboBox);
            this.tabPage1.Controls.Add(this.amortizationListView);
            this.tabPage1.Controls.Add(this.interestTotalLabel);
            this.tabPage1.Controls.Add(this.loanTotalLabel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rebateCheckBox);
            this.tabPage1.Controls.Add(this.exitButton);
            this.tabPage1.Controls.Add(this.displayButton);
            this.tabPage1.Controls.Add(this.acceptButton);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.loanAmtTextBox);
            this.tabPage1.Controls.Add(this.purposeTextBox);
            this.tabPage1.Controls.Add(this.dateTextBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1450, 806);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amortization Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Location = new System.Drawing.Point(663, 173);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(200, 39);
            this.rebateTextBox.TabIndex = 12;
            this.rebateTextBox.Click += new System.EventHandler(this.rebateTextBox_Click);
            this.rebateTextBox.TextChanged += new System.EventHandler(this.rebateTextBox_TextChanged);
            this.rebateTextBox.Enter += new System.EventHandler(this.rebateTextBox_Enter);
            this.rebateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebateTextBox_KeyPress);
            // 
            // aprComboBox
            // 
            this.aprComboBox.FormattingEnabled = true;
            this.aprComboBox.Items.AddRange(new object[] {
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0"});
            this.aprComboBox.Location = new System.Drawing.Point(663, 112);
            this.aprComboBox.Name = "aprComboBox";
            this.aprComboBox.Size = new System.Drawing.Size(200, 40);
            this.aprComboBox.TabIndex = 8;
            this.aprComboBox.TextChanged += new System.EventHandler(this.aprComboBox_TextChanged);
            this.aprComboBox.Click += new System.EventHandler(this.aprComboBox_Click);
            this.aprComboBox.Enter += new System.EventHandler(this.aprComboBox_Enter);
            this.aprComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aprComboBox_KeyPress);
            // 
            // amortizationListView
            // 
            this.amortizationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.amortizationListView.Location = new System.Drawing.Point(82, 250);
            this.amortizationListView.Name = "amortizationListView";
            this.amortizationListView.Size = new System.Drawing.Size(1094, 447);
            this.amortizationListView.TabIndex = 13;
            this.amortizationListView.UseCompatibleStateImageBehavior = false;
            this.amortizationListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Month";
            this.columnHeader0.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Beginning Balance";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Interest";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Principal";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payment";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ending Balance";
            this.columnHeader5.Width = 210;
            // 
            // interestTotalLabel
            // 
            this.interestTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interestTotalLabel.Location = new System.Drawing.Point(768, 723);
            this.interestTotalLabel.Name = "interestTotalLabel";
            this.interestTotalLabel.Size = new System.Drawing.Size(170, 48);
            this.interestTotalLabel.TabIndex = 21;
            // 
            // loanTotalLabel
            // 
            this.loanTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanTotalLabel.Location = new System.Drawing.Point(294, 723);
            this.loanTotalLabel.Name = "loanTotalLabel";
            this.loanTotalLabel.Size = new System.Drawing.Size(184, 48);
            this.loanTotalLabel.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(608, 723);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "Interest total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 723);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Today\'s loan total:";
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.Location = new System.Drawing.Point(497, 171);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(135, 36);
            this.rebateCheckBox.TabIndex = 11;
            this.rebateCheckBox.Text = "Rebate?:";
            this.rebateCheckBox.UseVisualStyleBackColor = true;
            this.rebateCheckBox.CheckedChanged += new System.EventHandler(this.rebateCheckBox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1250, 610);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 114);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(1250, 490);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(150, 114);
            this.displayButton.TabIndex = 16;
            this.displayButton.Text = "&Display Accepted Amounts";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(1250, 370);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(150, 114);
            this.acceptButton.TabIndex = 15;
            this.acceptButton.Text = "&Accept Loan";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(1250, 250);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 114);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "&Calculate Loan";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project2.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(1220, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thirtyRadioButton);
            this.groupBox1.Controls.Add(this.fifteenRadioButton);
            this.groupBox1.Controls.Add(this.twentyRadioButton);
            this.groupBox1.Controls.Add(this.tenRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(922, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Years";
            // 
            // thirtyRadioButton
            // 
            this.thirtyRadioButton.AutoSize = true;
            this.thirtyRadioButton.Location = new System.Drawing.Point(130, 103);
            this.thirtyRadioButton.Name = "thirtyRadioButton";
            this.thirtyRadioButton.Size = new System.Drawing.Size(71, 36);
            this.thirtyRadioButton.TabIndex = 3;
            this.thirtyRadioButton.Text = "30";
            this.thirtyRadioButton.UseVisualStyleBackColor = true;
            this.thirtyRadioButton.CheckedChanged += new System.EventHandler(this.thirtyRadioButton_CheckedChanged);
            // 
            // fifteenRadioButton
            // 
            this.fifteenRadioButton.AutoSize = true;
            this.fifteenRadioButton.Location = new System.Drawing.Point(17, 103);
            this.fifteenRadioButton.Name = "fifteenRadioButton";
            this.fifteenRadioButton.Size = new System.Drawing.Size(71, 36);
            this.fifteenRadioButton.TabIndex = 2;
            this.fifteenRadioButton.Text = "15";
            this.fifteenRadioButton.UseVisualStyleBackColor = true;
            this.fifteenRadioButton.CheckedChanged += new System.EventHandler(this.fifteenRadioButton_CheckedChanged);
            // 
            // twentyRadioButton
            // 
            this.twentyRadioButton.AutoSize = true;
            this.twentyRadioButton.Location = new System.Drawing.Point(130, 45);
            this.twentyRadioButton.Name = "twentyRadioButton";
            this.twentyRadioButton.Size = new System.Drawing.Size(71, 36);
            this.twentyRadioButton.TabIndex = 1;
            this.twentyRadioButton.Text = "20";
            this.twentyRadioButton.UseVisualStyleBackColor = true;
            this.twentyRadioButton.CheckedChanged += new System.EventHandler(this.twentyRadioButton_CheckedChanged);
            // 
            // tenRadioButton
            // 
            this.tenRadioButton.AutoSize = true;
            this.tenRadioButton.Checked = true;
            this.tenRadioButton.Location = new System.Drawing.Point(17, 45);
            this.tenRadioButton.Name = "tenRadioButton";
            this.tenRadioButton.Size = new System.Drawing.Size(71, 36);
            this.tenRadioButton.TabIndex = 0;
            this.tenRadioButton.TabStop = true;
            this.tenRadioButton.Text = "10";
            this.tenRadioButton.UseVisualStyleBackColor = true;
            this.tenRadioButton.CheckedChanged += new System.EventHandler(this.tenRadioButton_CheckedChanged);
            // 
            // loanAmtTextBox
            // 
            this.loanAmtTextBox.Location = new System.Drawing.Point(663, 44);
            this.loanAmtTextBox.Name = "loanAmtTextBox";
            this.loanAmtTextBox.Size = new System.Drawing.Size(200, 39);
            this.loanAmtTextBox.TabIndex = 3;
            this.loanAmtTextBox.Click += new System.EventHandler(this.loanAmtTextBox_Click);
            this.loanAmtTextBox.TextChanged += new System.EventHandler(this.loanAmtTextBox_TextChanged);
            this.loanAmtTextBox.Enter += new System.EventHandler(this.loanAmtTextBox_Enter);
            this.loanAmtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanAmtTextBox_KeyPress);
            // 
            // purposeTextBox
            // 
            this.purposeTextBox.Location = new System.Drawing.Point(187, 169);
            this.purposeTextBox.Name = "purposeTextBox";
            this.purposeTextBox.Size = new System.Drawing.Size(200, 39);
            this.purposeTextBox.TabIndex = 10;
            this.purposeTextBox.Click += new System.EventHandler(this.purposeTextBox_Click);
            this.purposeTextBox.TextChanged += new System.EventHandler(this.purposeTextBox_TextChanged);
            this.purposeTextBox.Enter += new System.EventHandler(this.purposeTextBox_Enter);
            this.purposeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purposeTextBox_KeyPress);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(187, 107);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(200, 39);
            this.dateTextBox.TabIndex = 6;
            this.dateTextBox.Click += new System.EventHandler(this.dateTextBox_Click);
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            this.dateTextBox.Enter += new System.EventHandler(this.dateTextBox_Enter);
            this.dateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(187, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(281, 39);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Annual APR%:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loan amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Purpose:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exitButton2);
            this.tabPage2.Controls.Add(this.displayTotalButton);
            this.tabPage2.Controls.Add(this.displayLoanButton);
            this.tabPage2.Controls.Add(this.loanListView);
            this.tabPage2.Controls.Add(this.avgLoanListLabel);
            this.tabPage2.Controls.Add(this.totalLoanListLabel);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1450, 806);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loan List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exitButton2
            // 
            this.exitButton2.Location = new System.Drawing.Point(1245, 480);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(150, 131);
            this.exitButton2.TabIndex = 3;
            this.exitButton2.Text = "&Exit";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // displayTotalButton
            // 
            this.displayTotalButton.Location = new System.Drawing.Point(1245, 299);
            this.displayTotalButton.Name = "displayTotalButton";
            this.displayTotalButton.Size = new System.Drawing.Size(150, 131);
            this.displayTotalButton.TabIndex = 2;
            this.displayTotalButton.Text = "Display &Total and Average";
            this.displayTotalButton.UseVisualStyleBackColor = true;
            this.displayTotalButton.Click += new System.EventHandler(this.displayTotalButton_Click);
            // 
            // displayLoanButton
            // 
            this.displayLoanButton.Location = new System.Drawing.Point(1245, 115);
            this.displayLoanButton.Name = "displayLoanButton";
            this.displayLoanButton.Size = new System.Drawing.Size(150, 131);
            this.displayLoanButton.TabIndex = 1;
            this.displayLoanButton.Text = "Display &Loans";
            this.displayLoanButton.UseVisualStyleBackColor = true;
            this.displayLoanButton.Click += new System.EventHandler(this.displayLoanButton_Click);
            // 
            // loanListView
            // 
            this.loanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.loanListView.Location = new System.Drawing.Point(79, 33);
            this.loanListView.Name = "loanListView";
            this.loanListView.Size = new System.Drawing.Size(1126, 665);
            this.loanListView.TabIndex = 0;
            this.loanListView.UseCompatibleStateImageBehavior = false;
            this.loanListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loan Date";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Purpose";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Years";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "APR";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rebate";
            this.columnHeader12.Width = 150;
            // 
            // avgLoanListLabel
            // 
            this.avgLoanListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgLoanListLabel.Location = new System.Drawing.Point(608, 714);
            this.avgLoanListLabel.Name = "avgLoanListLabel";
            this.avgLoanListLabel.Size = new System.Drawing.Size(187, 53);
            this.avgLoanListLabel.TabIndex = 7;
            // 
            // totalLoanListLabel
            // 
            this.totalLoanListLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoanListLabel.Location = new System.Drawing.Point(155, 714);
            this.totalLoanListLabel.Name = "totalLoanListLabel";
            this.totalLoanListLabel.Size = new System.Drawing.Size(187, 54);
            this.totalLoanListLabel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 725);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Average:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 725);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1478, 884);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Regional Bank Loan";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button exitButton;
        private Button displayButton;
        private Button acceptButton;
        private Button calculateButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox loanAmtTextBox;
        private TextBox purposeTextBox;
        private TextBox dateTextBox;
        private TextBox nameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView amortizationListView;
        private Label interestTotalLabel;
        private Label loanTotalLabel;
        private Label label7;
        private Label label6;
        private CheckBox rebateCheckBox;
        private TextBox rebateTextBox;
        private ComboBox aprComboBox;
        private RadioButton thirtyRadioButton;
        private RadioButton fifteenRadioButton;
        private RadioButton twentyRadioButton;
        private RadioButton tenRadioButton;
        private Button displayLoanButton;
        private ListView loanListView;
        private Label avgLoanListLabel;
        private Label totalLoanListLabel;
        private Label label9;
        private Label label8;
        private Button exitButton2;
        private Button displayTotalButton;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}