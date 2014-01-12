using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bibliothek;
using LibraryForm.Class;

namespace LibraryForm
{
  partial class Form_Customer : Form
  {
      // customer infos
      Customer loggedCustomer;

      LibraryDB libraryDB;

      List<Book> bookList;

    public Form_Customer(LibraryDB libraryDB, Person person)
    {
      InitializeComponent();

      this.libraryDB = libraryDB;
      this.loggedCustomer = libraryDB.GetCustomerById(person.Id);

      // welcome text
      lbl_personName.Text = "Hallo " + loggedCustomer.Firstname + " " + loggedCustomer.Lastname;

      // customer infos
      lbl_idTag.Text = loggedCustomer.Id.ToString();
      lbl_lastnameTag.Text = loggedCustomer.Lastname;
      lbl_firstnameTag.Text = loggedCustomer.Firstname;
      lbl_birthdayTag.Text = loggedCustomer.Birthday.ToString();

      // ChargeAccount infos
      loggedCustomer.ChargeAccount = libraryDB.GetChargeAccountByPersonId(person.Id);
      tb_charges.Text = loggedCustomer.ChargeAccount.Charges.ToString();

      // LoanAccount infos
      loggedCustomer.LoanAccount.SampleList = libraryDB.GetSampleListByPersonId(person.Id);

      foreach (Sample sample in loggedCustomer.LoanAccount.SampleList)
      {
          string loanSample = sample.Id.ToString() + " - " + sample.Book.Title.ToString() + " - " + sample.EndOfLoan.ToString();
          lb_loanAccount.Items.Add(loanSample);
      }

      // PreorderAccount infos
      foreach (Sample sample in loggedCustomer.PreorderAccount.SampleList)
      {
          string preorderSample = sample.Id.ToString() + " - " + sample.Book.Title.ToString();
          lb_loanAccount.Items.Add(preorderSample);
      }

      // messageAccount infos
      loggedCustomer.MessageAccount = libraryDB.GetMessageAccountByPersonId(person.Id);

      foreach (KeyValuePair<int, bibliothek.Message> entry in loggedCustomer.MessageAccount.MessageDict)
      {
          dgv_messages.Rows.Add(entry.Key.ToString() + " - " + entry.Value.MessageText + " - " + entry.Value.CreationDate.ToString());
      }
    }

    private void tb_bookSearch_TextChanged(object sender, EventArgs e)
    {
        // enabled the search button, if text inside the tb_bookSearch
        btn_bookSearch.Enabled = ! string.IsNullOrWhiteSpace(this.tb_bookSearch.Text);
    }

    private void btn_bookSearch_Click(object sender, EventArgs e)
    {
        // list for founded books
        List<Book> foundBookList = libraryDB.GetBookList();

        // search for title
        if (rb_bookTitle.Checked)
        {
            foreach (Book book in bookList) {
                if (book.Title.Contains(tb_bookSearch.Text)) {
                    foundBookList.Add(book);
                }
            }
        }
        // search for author
        else if (rb_bookAuthor.Checked)
        {
            // fill dgv_books with all books
            foreach (Book book in bookList)
            {
                if (book.Author.Contains(tb_bookSearch.Text))
                {
                    foundBookList.Add(book);
                }
            }
        }

        // show all search results
        if (foundBookList.Count > 0)
        {
            foreach (Book book in foundBookList)
            {
                int freeCounter = 0;

                // count the free books
                foreach (Sample sample in book.Sample)
                {
                    if (sample.Status == "frei")
                    {
                        freeCounter++;
                    }
                }

                dgv_books.Rows.Add(book.Author, book.Title, book.Genre, book.Count, freeCounter); 
            }
        }
    }

    private void btn_clearBookSearch_Click(object sender, EventArgs e)
    {
        // cleared the book search
        tb_bookSearch.Text = "";
        rb_bookTitle.Checked = true;
        rb_bookAuthor.Checked = false;

        // reset the dgv_books
        dgv_books.Rows.Clear();

        // fill dgv_books with all books
        foreach (Book book in bookList)
        {
            int freeCounter = 0;

            // count books that are free to order
            foreach (Sample sample in book.Sample)
            {
                if (sample.Status == "frei")
                {
                    freeCounter++;
                }
            }

            // add new result into single row
            dgv_books.Rows.Add(book.Author, book.Title, book.Genre, book.Count, freeCounter);
        }
    }

    private void tb_payIn_TextChanged(object sender, EventArgs e)
    {
        string payInString = tb_bookSearch.Text;

        // enabled the payIn button, if text inside the tb_payIn
        if (!string.IsNullOrWhiteSpace(payInString))
        {
            btn_payIn.Enabled = true;
        }
        // disabled
        else
        {
            btn_payIn.Enabled = false;
        }
    }

    private void btn_payIn_Click(object sender, EventArgs e)
    {
        string payInString = tb_bookSearch.Text;

        // replace comma with point
        payInString = payInString.Replace(",", ".");

        double realPayIn;

        // check if string a double
        if (double.TryParse(payInString, out realPayIn))
        {
            // check 2 decimal places
            if (realPayIn * 100 == Math.Floor(realPayIn * 100))
            {
                // payIn more than charges 
                if (realPayIn > loggedCustomer.ChargeAccount.Charges)
                {
                    // clear charges and send message
                    loggedCustomer.ChargeAccount.clearChargeAccount();
                    tb_charges.Text = "0";
                }
                else
                {
                    // pay in charges
                    loggedCustomer.ChargeAccount.payIn(realPayIn);
                    tb_charges.Text = loggedCustomer.ChargeAccount.Charges.ToString();
                }

                // clear textbox payIn
                tb_payIn.Text = "";
            }
            else
            {
                MessageBox.Show("Nur zwei Nachkommastellen beachten!");
            }
        }
        else
        {
            MessageBox.Show("Korrekten Betrag angeben (Bsp.: 12.75)!");
        }
    }

    private void btn_logout_Click(object sender, EventArgs e)
    {
        // return to login form
        Form1 loginForm = new Form1();
        loginForm.ShowDialog();
    }
  }
}
