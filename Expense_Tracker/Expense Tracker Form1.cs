using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class Expense_Tracker : Form
    {
        public Expense_Tracker()
        {
            InitializeComponent();
        }

        DataTable expenseTracker = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            //create columns
            expenseTracker.Columns.Add("Expense");
            expenseTracker.Columns.Add("Amount");
            expenseTracker.Columns.Add("Notes");
            expenseTracker.Columns.Add("Date");

            //point our datagridview to datasource
            ExpenseTrackerView.DataSource = expenseTracker;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            expense.Text = "";
            amount.Text = "";
            notes.Text = "";
            date.Value = DateTime.Now;
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // fill text fields with data from table
            expense.Text = expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex].ItemArray[0].ToString();
            amount.Text = expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex].ItemArray[1].ToString();
            notes.Text = expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex].ItemArray[2].ToString();
            date.Value = Convert.ToDateTime(expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex].ItemArray[3]);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex]["Expense"] = expense.Text;
                expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex]["Amount"] = amount.Text;
                expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex]["Notes"] = notes.Text;
                expenseTracker.Rows[ExpenseTrackerView.CurrentCell.RowIndex]["Date"] = date.Value;

            }
            else
            {
                expenseTracker.Rows.Add(expense.Text, amount.Text, notes.Text, date.Value);
            }
            // clear fields
            expense.Text = "";
            amount.Text = "";
            notes.Text = "";
            date.Value = DateTime.Now;
            isEditing = false;
        }
    }
}
