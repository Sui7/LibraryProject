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

      List<Book> bookList = new List<Book>();

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
      lbl_birthdayTag.Text = loggedCustomer.Birthday.ToShortDateString();

      // get book list
      RefreshBookList();

      // get account infos
      RefreshChargeAccount();
      RefreshLoanAccount();
      RefreshPreorderAccount();
      RefreshMessageAccount();
    }


    private void RefreshBookList()
    {
        // Book infos
        bookList = libraryDB.GetBookList();

        if (bookList.Count() != 0)
        {
            foreach (Book book in bookList)
            {
                // count free samples
                int freeSamples = libraryDB.CountFreeSamplesByBookId(book.Id);

                dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, freeSamples);                
            }
        }

        dgv_books.ClearSelection();
    }


    private void RefreshChargeAccount()
    {
        // ChargeAccount infos
        loggedCustomer.ChargeAccount = libraryDB.GetChargeAccountByPersonId(loggedCustomer.Id);
        tb_charges.Text = loggedCustomer.ChargeAccount.Charges.ToString();
    }


    private void RefreshLoanAccount()
    {
        // LoanAccount infos
        loggedCustomer.LoanAccount = new LoanAccount(libraryDB.GetSampleListByPersonId(loggedCustomer.Id));

        if (loggedCustomer.LoanAccount.SampleList.Count() != 0)
        {
            foreach (Sample sample in loggedCustomer.LoanAccount.SampleList)
            {
                string loanSample = sample.Id.ToString() + " - " + getBookBySample(sample).Title.ToString() + " - " + sample.EndOfLoan.ToString();
                lb_loanAccount.Items.Add(loanSample);
            }
        }
    }

    Book getBookBySample(Sample searchedSample)
    {
        foreach (var book in bookList)                     // Durchläuft die Bücherliste
        {
            foreach (var sample in book.Sample)            // Durchläuft die Exemplarliste die in dem Buch steckt
            {
                if (sample.Equals(searchedSample))         // Überprüft ob das gesuchte Exemplar in der Exemplarliste des Buches steckt
                {
                    return book;                           // Gibt das Buch zurück
                }
            }
        }

        return null;
    }



    private void RefreshPreorderAccount()
    {
        // PreorderAccount infos
        loggedCustomer.PreorderAccount = new PreorderAccount(libraryDB.GetSampleListByPersonId(loggedCustomer.Id));

        if (loggedCustomer.PreorderAccount.SampleList.Count() != 0)
        {
            foreach (Sample sample in loggedCustomer.PreorderAccount.SampleList)
            {
                string preorderSample = sample.Id.ToString() + " - " + sample.Book.Title.ToString();
                lb_loanAccount.Items.Add(preorderSample);
            }
        }
    }


    private void RefreshMessageAccount()
    {
        // messageAccount infos
        loggedCustomer.MessageAccount = new MessageAccount(libraryDB.GetMessageDictByPersonId(loggedCustomer.Id));

        if (loggedCustomer.MessageAccount.MessageDict.Count != 0)
        {
            foreach (KeyValuePair<int, bibliothek.Message> entry in loggedCustomer.MessageAccount.MessageDict)
            {
                dgv_messages.Rows.Add(entry.Value.MessageText, entry.Value.CreationDate.ToShortDateString());
            }
        }

        dgv_messages.ClearSelection();
    }


    private void btn_bookSearch_Click(object sender, EventArgs e)
    {
        bool bookFound = false;

        if (rb_bookTitle.Checked)
        {
            dgv_books.Rows.Clear();

            foreach (Book book in bookList)
            {
                if (book.Title.ToLower().Contains(tb_bookSearch.Text.ToLower()))
                {
                    // count free samples
                    int freeSamples = libraryDB.CountFreeSamplesByBookId(book.Id);

                    // add book to dgv_books
                    dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, freeSamples);

                    // book found
                    bookFound = true;
                }
            }
        }
        else if (rb_bookAuthor.Checked) 
        {
            dgv_books.Rows.Clear();

            foreach (Book book in bookList)
            {
                if (book.Author.ToLower().Contains(tb_bookSearch.Text.ToLower()))
                {
                    // count free samples
                    int freeSamples = libraryDB.CountFreeSamplesByBookId(book.Id);

                    // add book to dgv_books
                    dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, freeSamples);

                    // book found
                    bookFound = true;
                }
            }
        }
        else {
            MessageBox.Show("Bitte wählen Sie Titel oder Author.");
        }

        if (! bookFound)
        {
            MessageBox.Show("Keinen Treffer.");
        }
    }


    private void tb_bookSearch_TextChanged(object sender, EventArgs e)
    {
        // enabled the btn_bookSearch, if text inside the tb_bookSearch
        if (!string.IsNullOrWhiteSpace(tb_bookSearch.Text))
        {
            btn_bookSearch.Enabled = true;
        }
        // disabled
        else
        {
            btn_bookSearch.Enabled = false;
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
            dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, freeCounter);
        }
    }


    private void tb_payIn_TextChanged(object sender, EventArgs e)
    {
        // enabled the payIn button, if text inside the tb_payIn
        if (!string.IsNullOrWhiteSpace(tb_payIn.Text))
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
        double realPayIn;

        if (double.TryParse(tb_payIn.Text, out realPayIn)) {

        // check 2 decimal places
        if (realPayIn * 100 == Math.Floor(realPayIn * 100))
        {
            // payIn more than charges 
            if (realPayIn >= loggedCustomer.ChargeAccount.Charges)
                {
                    // clear charges and send message
                    loggedCustomer.ChargeAccount.clearChargeAccount();
                    libraryDB.ClearCharges(loggedCustomer.Id);
                    tb_charges.Text = "0";
                }
                else
                {
                    // pay in charges
                    double newCharges = loggedCustomer.ChargeAccount.payIn(realPayIn);
                    libraryDB.PayInCharges(loggedCustomer.Id, newCharges);
                    tb_charges.Text = loggedCustomer.ChargeAccount.Charges.ToString();
                }

                // clear textbox payIn
                tb_payIn.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Nur zwei Nachkommastellen beachten!");
            }
        }

        MessageBox.Show("Korrekten Betrag angeben (Bsp.: 12.75)!");        
    }

    private void btn_logout_Click(object sender, EventArgs e)
    {
        // return to login form
        this.Close();
    }

    private void btn_loanBook_Click(object sender, EventArgs e)
    {
        int id = int.Parse(dgv_books.SelectedRows[0].Cells["Id"].Value.ToString());
        int count = int.Parse(dgv_books.SelectedRows[0].Cells["Anzahl"].Value.ToString());
        int freeBooks = int.Parse(dgv_books.SelectedRows[0].Cells["verfügbar"].Value.ToString());

        if (count != 0)
        {
            if (freeBooks != 0)
            {
								//DateTime endOfLoan = DateTime.Now.AddDays(Libary);
								//libraryDB.UpdateSampleToCustomer(id, loggedCustomer.Id, endOfLoan, "ausgeliehen");
            }
            else
            {
                MessageBox.Show("Derzeit keine freien Exemplare verfügbar.");
            }
        }
        else
        {
            MessageBox.Show("Derzeit verfügen wir über keine Exemplare.");
        }
    }
  }
}
