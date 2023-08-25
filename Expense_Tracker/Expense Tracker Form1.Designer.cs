namespace Expense_Tracker
{
    partial class Expense_Tracker
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
            this.title = new System.Windows.Forms.Label();
            this.expense = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ExpenseTrackerView = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseTrackerView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1234, 28);
            this.title.TabIndex = 0;
            this.title.Text = "Expense Tracker";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.UseWaitCursor = true;
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // expense
            // 
            this.expense.Location = new System.Drawing.Point(16, 75);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(464, 20);
            this.expense.TabIndex = 1;
            this.expense.UseWaitCursor = true;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(486, 75);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(233, 20);
            this.amount.TabIndex = 3;
            this.amount.UseWaitCursor = true;
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseLabel.Location = new System.Drawing.Point(12, 59);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(48, 13);
            this.expenseLabel.TabIndex = 5;
            this.expenseLabel.Text = "Expense";
            this.expenseLabel.UseWaitCursor = true;
            this.expenseLabel.Click += new System.EventHandler(this.expenseLabel_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(483, 59);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(47, 13);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount";
            this.amountLabel.UseWaitCursor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(1039, 59);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 13);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date";
            this.dateLabel.UseWaitCursor = true;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(725, 75);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(298, 20);
            this.notes.TabIndex = 8;
            this.notes.UseWaitCursor = true;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(722, 59);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(37, 13);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Notes";
            this.notesLabel.UseWaitCursor = true;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(16, 101);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(302, 23);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.UseWaitCursor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(324, 101);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(302, 23);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.UseWaitCursor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(632, 101);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(302, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.UseWaitCursor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(940, 101);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(302, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.UseWaitCursor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ExpenseTrackerView
            // 
            this.ExpenseTrackerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpenseTrackerView.BackgroundColor = System.Drawing.Color.White;
            this.ExpenseTrackerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseTrackerView.GridColor = System.Drawing.Color.Black;
            this.ExpenseTrackerView.Location = new System.Drawing.Point(16, 130);
            this.ExpenseTrackerView.Name = "ExpenseTrackerView";
            this.ExpenseTrackerView.Size = new System.Drawing.Size(1226, 437);
            this.ExpenseTrackerView.TabIndex = 14;
            this.ExpenseTrackerView.UseWaitCursor = true;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(1043, 75);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 15;
            this.date.Value = new System.DateTime(2023, 8, 24, 0, 0, 0, 0);
            // 
            // Expense_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1258, 579);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ExpenseTrackerView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.expenseLabel);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.expense);
            this.Controls.Add(this.title);
            this.Name = "Expense_Tracker";
            this.Text = "Expense Tracker";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseTrackerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox expense;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView ExpenseTrackerView;
        private System.Windows.Forms.DateTimePicker date;
    }
}

