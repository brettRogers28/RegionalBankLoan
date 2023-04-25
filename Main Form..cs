namespace Project2
{

    // Carter Jones and Brett Rogers
    // BUS442 Project 2 Pair Programming
    // Date: 3/30/23

    //System.IO Statment
    using System.IO;
    using System;
    using System.Reflection.Metadata;
    using System.Security.Cryptography;
    using System.Reflection;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rebateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enabling the rebate text box if the rebate checkbox is selected
            rebateTextBox.Enabled = rebateCheckBox.Checked;
            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
            rebateTextBox.Clear();
            rebate = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit with confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?",
           this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
            {
                this.AutoValidate = AutoValidate.Disable;
                this.Close();
            }
        }
        private void exitButton2_Click(object sender, EventArgs e)
        {
            //exit with confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?",
           this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
            {
                this.AutoValidate = AutoValidate.Disable;
                this.Close();
            }
        }

        //Declaring the global variables
        double loan, rate, rebate, total, average, todayTotal, interestTotal, overallInterest, overallPrincipal, overallPayment;
        double beginningBalance, interest, principalPayment, pmt, endingBalance, apr, amount;
        int month, loanYears;
        string name, purpose, date;
        //Declaring the arrays and lists necessary
        private List<string[]> loans = new List<string[]>();
        string[] fields = new string[0];
        string[] items = new string[50];
        string[] overall = new string[50];

        //Selecting the respective Textboxes when Clicked.
        private void loanAmtTextBox_Click(object sender, EventArgs e)
        {
            //Selecting the TextBox
            loanAmtTextBox.SelectAll();
        }
        private void aprComboBox_Click(object sender, EventArgs e)
        {
            //Selecting the Combo Box
            aprComboBox.SelectAll();
        }
        private void rebateTextBox_Click(object sender, EventArgs e)
        {
            //Selecting the TextBox
            rebateTextBox.SelectAll();
        }
        private void nameTextBox_Click(object sender, EventArgs e)
        {
            //Selecting the TextBox
            nameTextBox.SelectAll();
        }
        private void dateTextBox_Click(object sender, EventArgs e)
        {
            //Selecting the TextBox
            dateTextBox.SelectAll();
        }
        private void purposeTextBox_Click(object sender, EventArgs e)
        {
            //Selecting the TextBox
            purposeTextBox.SelectAll();
        }

        //Selecting the respective Textboxes when entered.
        private void loanAmtTextBox_Enter(object sender, EventArgs e)
        {
            loanAmtTextBox.SelectAll();
        }
        private void aprComboBox_Enter(object sender, EventArgs e)
        {
            aprComboBox.SelectAll();
        }
        private void rebateTextBox_Enter(object sender, EventArgs e)
        {
            rebateTextBox.SelectAll();
        }
        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.SelectAll();
        }
        private void dateTextBox_Enter(object sender, EventArgs e)
        {
            dateTextBox.SelectAll();
        }
        private void purposeTextBox_Enter(object sender, EventArgs e)
        {
            purposeTextBox.SelectAll();
        }

        //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void purposeTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void loanAmtTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void aprComboBox_TextChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void rebateTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void tenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void fifteenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void twentyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }
        private void thirtyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clearing the List View if any of the textboxes are changed so no incorrect data is shown.

            amortizationListView.Items.Clear();
            loanListView.Items.Clear();
            loanTotalLabel.Text = null;
            interestTotalLabel.Text = null;
            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            acceptButton.Enabled = false;
        }

        //Below are the various KeyPress for the textboxes.
        private void rebateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing certain key characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }
        private void loanAmtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing certain key characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }
        private void purposeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing certain key characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' 
                && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }
        private void dateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing certain key characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
                return;
            }
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing certain key characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.'
                && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
        }
        private void aprComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing certain key characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !='.')
            {
                e.Handled = true;
                return;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declaring all local constants needed.
            const int tenYears = 10;
            const int fifteenYears = 15;
            const int twentyYears = 20;
            const int thirtyYears = 30;
            const int numberOfMonths = 12;

            
            try
            {
                //Clearing and resetting outputs and values.
                amortizationListView.Items.Clear();
                loanListView.Items.Clear();
                loanTotalLabel.Text = null;
                interestTotalLabel.Text = null;
                overallInterest = 0;
                overallPayment = 0;
                overallPrincipal = 0;

                // Parsing the numerical data 
                double.TryParse(loanAmtTextBox.Text, out loan);
                double.TryParse(aprComboBox.Text, out rate);
                // Grabbing the string data
                name = nameTextBox.Text;
                date = dateTextBox.Text;
                purpose = purposeTextBox.Text;

                //Grabbing the Amount and APR for StreamWriter later
                apr = rate;
                amount = loan;

                //Parsing rebate and adjusting loan accordingly
                if (rebateCheckBox.Checked)
                {
                    rebateTextBox.Focus();
                    double.TryParse(rebateTextBox.Text, out rebate);
                }

                //Creating error messages if a value is not entered
                if (name == string.Empty)
                {
                    MessageBox.Show("Please enter a name.", "Error Message", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                }

                else if (loan == 0)
                {
                    MessageBox.Show("Please enter a loan amount.", "Error Message", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                    loanAmtTextBox.Focus();
                }

                else if (date == string.Empty)
                {
                    MessageBox.Show("Please enter a date.", "Error Message", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Warning);
                    dateTextBox.Focus();
                }
                else if (rate == 0)
                {
                    MessageBox.Show("Please choose a rate.", "Error Message", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Warning);
                    aprComboBox.Focus();
                }

                else if (purpose == string.Empty)
                {
                    MessageBox.Show("Please enter a purpose.", "Error Message", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Warning);
                    purposeTextBox.Focus();
                }

                else if (rebateCheckBox.Checked && rebate == 0)
                {
                    MessageBox.Show("You must enter a rebate.", "Error Message", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning);
                    rebateTextBox.Focus();
                }

                else 
                {

                    // Getting the loan years and months through conditional logic
                    if (tenRadioButton.Checked)
                    {
                        loanYears = tenYears;
                        month = tenYears * numberOfMonths;
                    }
                    else if (fifteenRadioButton.Checked)
                    {
                        loanYears = fifteenYears;
                        month = fifteenYears * numberOfMonths;
                    }
                    else if (twentyRadioButton.Checked)
                    {
                        loanYears = twentyYears;
                        month = twentyYears * numberOfMonths;
                    }
                    else
                    {
                        loanYears = thirtyYears;
                        month = thirtyYears * numberOfMonths;
                    }

                    //Calculating potential rebate
                    loan = loan - rebate;

                    //Converting rate to a percentage
                    rate = rate / 100;

                    //Calculating principal payment with given formula
                    principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, month))
                        / ((Math.Pow(1 + rate / 12, month) - 1) * (1 + rate / 12 * 0));

                    //Calculating interest with given formula
                    interest = loan * rate / 12;



                    // THE LOOP
                    int monthsCounter;
                    for (monthsCounter = 1; monthsCounter <= month; monthsCounter = monthsCounter + 1)
                    {
                        //Calculating some of the columns
                        if (monthsCounter == 1)
                            beginningBalance = loan;
                        else
                            beginningBalance = endingBalance;
                        pmt = principalPayment + interest;
                        loan = loan - principalPayment;
                        endingBalance = beginningBalance - principalPayment;


                        //Displaying the columns
                        string[] items = {monthsCounter.ToString(), beginningBalance.ToString("C2"), interest.ToString("C2"),
                        principalPayment.ToString("C2"), pmt.ToString("C2"), endingBalance.ToString("C2")};
                        ListViewItem AmortizationLVI = new ListViewItem(items);
                        amortizationListView.Items.Add(AmortizationLVI);


                        // Getting the Overall's for the columns
                        overallInterest = overallInterest + interest;
                        overallPrincipal = overallPrincipal + principalPayment;
                        overallPayment = overallPayment + pmt;

                        // Updating values for new loan amount
                        interest = loan * rate / 12;
                        principalPayment = pmt - interest;

                    }
                    //Showcasing the overall totals as the last row of the list view
                    overall[0] = "";
                    overall[1] = "";
                    overall[2] = overallInterest.ToString("C2");
                    overall[3] = overallPrincipal.ToString("C2");
                    overall[4] = overallPayment.ToString("C2");
                    overall[5] = "";

                    ListViewItem OverallLVI = new ListViewItem(overall);
                    amortizationListView.Items.Add(OverallLVI);

                    //Enabling Accept Button
                    acceptButton.Enabled = true;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message");
            }
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            //if (loan!=0 && rate !=0 && name!=string.Empty && date!=string.Empty && purpose!=string.Empty)
            //{ 

            //Creating error messages if a value is not entered
            if (checkforDuplicates() == false)
            {
                MessageBox.Show("Please re-enter another name.  This name already exists in the text file.",
                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               nameTextBox.Focus();
            }
            else
            {

             //Creating the StreamWriter
             StreamWriter LoansWriter = new StreamWriter("Loans.txt", true);

                LoansWriter.WriteLine(name + "," + date + "," + purpose + "," + amount + "," + loanYears + "," +
                    apr + "," + rebate);

                MessageBox.Show("Loan Accepted", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (LoansWriter != null)
                    LoansWriter.Close();

                // Reset the radio buttons and checkbox
                tenRadioButton.Checked = true;
                fifteenRadioButton.Checked = false;
                twentyRadioButton.Checked = false;
                thirtyRadioButton.Checked = false;
                rebateCheckBox.Checked = false;

                //Resetting the textboxes, combobox and listview
                nameTextBox.Clear();
                dateTextBox.Clear();
                purposeTextBox.Clear();
                loanAmtTextBox.Clear();
                rebateTextBox.Clear();
                aprComboBox.Text = null;
                loanTotalLabel.Text = null;
                interestTotalLabel.Text = null;
                totalLoanListLabel.Text = null;
                avgLoanListLabel.Text = null;
                amortizationListView.Items.Clear();
                loanListView.Items.Clear();

                // Accumulating the variables
                todayTotal += overallPrincipal;
                interestTotal += overallInterest;

                // Resetting values
                loan = 0;
                beginningBalance = 0;
                pmt = 0;
                rate = 0;
                month = 0;
                interest = 0;
                endingBalance = 0;
                principalPayment = 0;
                overallInterest = 0;
                overallPayment = 0;
                overallPrincipal = 0;
                rebate = 0;
                total = 0;
                average = 0;

                //Setting the focus
                nameTextBox.Focus();

                //Resetting button
                acceptButton.Enabled = false;
            }

        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            //Displaying the loan and interest total for today.
            loanTotalLabel.Text = todayTotal.ToString("C2");
            interestTotalLabel.Text = interestTotal.ToString("C2");
        }

        // LOAN LIST TAB CODE:
        string currentLine;
        private void displayLoanButton_Click(object sender, EventArgs e)
        {
            try
            {
            loanListView.Items.Clear();
            total = 0;
            average = 0;

            //Create StreamReader
            StreamReader LoanReader = new StreamReader("Loans.txt");
            int count = 0;
            while (LoanReader.EndOfStream == false)
            {
                currentLine = LoanReader.ReadLine();
                fields = currentLine.Split(',');

                loans.Add(fields);

                ListViewItem LoansLVI = new ListViewItem(fields);
                loanListView.Items.Add(LoansLVI);

                //Getting the accumulator variable
                total += double.Parse(fields[3]);

                //Using this variable to how many times this runs.
                count += 1;
            }
            LoanReader.Close();

            // Calculating the average
            average = total / count;

            totalLoanListLabel.Text = null;
            avgLoanListLabel.Text = null;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message");
            }
        }
        string distinct;
        private List<string> listOfSavedNames = new List<string>();
        private bool checkforDuplicates()
        {

            StreamReader LoanReader = new StreamReader("Loans.txt");
            while (LoanReader.EndOfStream == false)
            {
                currentLine = LoanReader.ReadLine();
                fields = currentLine.Split(',');
                distinct = fields[0];
                listOfSavedNames.Add(distinct);
            }

            LoanReader.Close();

            //if (duplicates.Distinct().Count() != duplicates.Count())
            if (listOfSavedNames.Contains(name))
                return false;
            else
                return true;
        }

        private void displayTotalButton_Click(object sender, EventArgs e)
        {
            //Displaying the Total and Avergae Loan Labels
            totalLoanListLabel.Text = total.ToString("C2");
            avgLoanListLabel.Text = average.ToString("C2");
        }
    }
}