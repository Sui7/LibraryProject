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
        LibraryInfo libraryInfo;

        List<Book> bookList = new List<Book>();


        public Form_Customer(LibraryDB libraryDB, Person person)
        {
            InitializeComponent();

            this.libraryDB = libraryDB;
            this.loggedCustomer = libraryDB.GetCustomerById(person.Id);

            // welcome text
            lbl_personName.Text = "Hallo " + loggedCustomer.Firstname + " " + loggedCustomer.Lastname;

            // library infos
            this.libraryInfo = libraryDB.GetLibraryInfo();
            tb_library_name.Text = libraryInfo.Name;
            tb_library_address.Text = libraryInfo.Address;
            tb_library_charge.Text = libraryInfo.Charge.ToString() + " €";
            tb_library_loan_period.Text = libraryInfo.PeriodOfLoan.ToString() + " Tage";
            tb_library_overdrow_charge.Text = libraryInfo.OverdrowCharge.ToString() + " €";
            tb_library_times.Text = libraryInfo.OpeningTime.ToString() + " - " + libraryInfo.ClosingTime.ToString() + " Uhr";
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

            // reset the dgv_books
            dgv_books.Rows.Clear();

            if (bookList.Count() != 0)
            {
                foreach (Book book in bookList)
                {
                    // get all samples of this book
                    book.Sample = libraryDB.GetSamplesByBookId(book.Id);

                    // add new row with book
                    dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, GetFreeSampleList(book.Sample).Count);                
                }
            }

            dgv_books.ClearSelection();
        }


            private List<Sample> GetFreeSampleList(List<Sample> sampleList) {
                // loop all samples
                for (int i = sampleList.Count - 1; i >= 0; i--)
                {
                    // remove only samples with status != "frei" or reserved_by_customer != 0 
                    if (! sampleList[i].Status.Equals("frei") || sampleList[i].ReservedByCustomerId != 0)
                    {
                        sampleList.RemoveAt(i);
                    }
                }

                return sampleList;
            }


        private void RefreshChargeAccount()
        {
            // ChargeAccount infos
            loggedCustomer.ChargeAccount = libraryDB.GetChargeAccountByPersonId(loggedCustomer.Id);
            tb_charges.Text = loggedCustomer.ChargeAccount.Charges.ToString();
        }


        private Book getBookBySample(Sample sample)
        {
            foreach (var book in bookList)
            {
                if (book.Id.Equals(sample.BookId))
                {
                    return book;
                }
            }

            return null;
        }


        private void RefreshLoanAccount()
        {
            // LoanAccount infos
            loggedCustomer.LoanAccount = new LoanAccount(libraryDB.GetSampleListByPersonId(loggedCustomer.Id));

            // clear listbox
            lb_loanAccount.Items.Clear();

            if (loggedCustomer.LoanAccount.SampleList.Count() != 0)
            {
                // loop all samples
                foreach (Sample sample in loggedCustomer.LoanAccount.SampleList)
                {
                    // get book
                    Book book = getBookBySample(sample);
                    string loanSample = sample.Id.ToString() + " - " + book.Title + " - " + book.Author + " - "  + sample.EndOfLoan.ToShortDateString();
                
                    // add new listbox entry with sample
                    lb_loanAccount.Items.Add(loanSample);
                }
            }
        }


        private void RefreshPreorderAccount()
        {
            // PreorderAccount infos
            loggedCustomer.PreorderAccount = new PreorderAccount(libraryDB.GetSampleList());

            // clear listbox
            lb_preorderAccount.Items.Clear();

            if (loggedCustomer.PreorderAccount.SampleList.Count() != 0)
            {
                // loop all samples
                foreach (Sample sample in loggedCustomer.PreorderAccount.SampleList)
                {
                    // get reserved sample
                    if (sample.ReservedByCustomerId.Equals(loggedCustomer.Id)) 
                    {
                        // get book
                        Book book = getBookBySample(sample);
                        string loanSample = sample.Id.ToString() + " - " + book.Title + " - " + book.Author;

                        // add new listbox entry with sample
                        lb_preorderAccount.Items.Add(loanSample);
                    }
                }
            }
        }


        private void RefreshMessageAccount()
        {
            // messageAccount infos
            loggedCustomer.MessageAccount = new MessageAccount(libraryDB.GetMessageDictByPersonId(loggedCustomer.Id));

            // reset the dgv_books
            dgv_messages.Rows.Clear();

            if (loggedCustomer.MessageAccount.MessageDict.Count != 0)
            {
                // loop messages
                foreach (KeyValuePair<int, bibliothek.Message> entry in loggedCustomer.MessageAccount.MessageDict)
                {
                    // add new row with message
                    dgv_messages.Rows.Add(entry.Value.MessageText, entry.Value.CreationDate.ToShortDateString());
                }
            }

            dgv_messages.ClearSelection();
        }


        private void btn_bookSearch_Click(object sender, EventArgs e)
        {
            bool bookFound = false;

            // search for book title
            if (rb_bookTitle.Checked)
            {
                dgv_books.Rows.Clear();

                foreach (Book book in bookList)
                {
                    // compare title by lower strings
                    if (book.Title.ToLower().Contains(tb_bookSearch.Text.ToLower()))
                    {
                        // add book to dgv_books
                        dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, GetFreeSampleList(book.Sample).Count);

                        // book found
                        bookFound = true;
                    }
                }
            }
            // search for book author
            else if (rb_bookAuthor.Checked) 
            {
                dgv_books.Rows.Clear();

                foreach (Book book in bookList)
                {
                    // compare author by lower strings
                    if (book.Author.ToLower().Contains(tb_bookSearch.Text.ToLower()))
                    {
                        // add book to dgv_books
                        dgv_books.Rows.Add(book.Id, book.Author, book.Title, book.Genre, book.Count, GetFreeSampleList(book.Sample).Count);

                        // book found
                        bookFound = true;
                    }
                }
            }
            else {
                MessageBox.Show("Bitte wählen Sie Titel oder Author.");
                return;
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

            RefreshBookList();
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

                        MessageBox.Show("Neuer Kontostand lautet 0 Euro.");
                    }
                    else
                    {
                        // pay in charges
                        double newCharges = loggedCustomer.ChargeAccount.payIn(realPayIn);
                        libraryDB.UpdateCharges(loggedCustomer.Id, newCharges);
                        tb_charges.Text = loggedCustomer.ChargeAccount.Charges.ToString();
                    }

                    // clear textbox payIn
                    tb_payIn.Text = "";

                    MessageBox.Show("Neuer Kontostand lautet " + tb_charges.Text + " Euro.");

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
            // get book infos from row
            int bookId = int.Parse(dgv_books.SelectedRows[0].Cells["book_id"].Value.ToString());
            string title = dgv_books.SelectedRows[0].Cells["book_title"].Value.ToString();
            string author = dgv_books.SelectedRows[0].Cells["book_author"].Value.ToString();
            int count = int.Parse(dgv_books.SelectedRows[0].Cells["book_count"].Value.ToString());
            int freeBooks = int.Parse(dgv_books.SelectedRows[0].Cells["book_availible"].Value.ToString());

            if (count != 0)
            {
                // get list of sample only from this person
                List<Sample> personSampleList = libraryDB.GetSampleListByPersonId(loggedCustomer.Id);

                foreach (Sample sample in personSampleList)
                {
                    // check if book already exist as loaned
                    if (sample.BookId.Equals(bookId)) {
                        MessageBox.Show("Sie haben dieses Buch schon ausgeliehen.");
                        return;
                    }
                }

                if (freeBooks != 0)
                {
                    // get list of sample for this book
                    List<Sample> sampleList = libraryDB.GetSamplesByBookId(bookId);

                    foreach (Sample sample in sampleList)
                    {
                        // check if book already exist as reserved
                        if (sample.ReservedByCustomerId.Equals(loggedCustomer.Id))
                        {
                            MessageBox.Show("Sie haben dieses Buch schon ausgeliehen.");
                            return;
                        }
                    }

                    // get first free sample from this book
                    Sample freeSample = GetFreeSampleList(sampleList)[0];

                    // create date and update sample
			        DateTime endOfLoan = DateTime.Now.AddDays(libraryInfo.PeriodOfLoan);
                    libraryDB.UpdateSample(freeSample.Id, loggedCustomer.Id, endOfLoan, "ausgeliehen", 0);

                    // add new charge for this person
                    loggedCustomer.ChargeAccount.addCharges(libraryInfo.Charge);
                    libraryDB.UpdateCharges(loggedCustomer.Id, loggedCustomer.ChargeAccount.Charges);

                    MessageBox.Show("Ihre vorbestelltes Buch " + title + " von " + author + " wurde soebend Ihnen bis " + endOfLoan.ToShortDateString() +
                        " zugewiesen und ihr Konto mit " + loggedCustomer.ChargeAccount.Charges + " belastet.");

                    // refresh lists
                    RefreshBookList();
                    RefreshLoanAccount();
                    RefreshChargeAccount();
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


        private void btn_preorderBook_Click(object sender, EventArgs e)
        {
            // get book infos from row
            int bookId = int.Parse(dgv_books.SelectedRows[0].Cells["book_id"].Value.ToString());
            string title = dgv_books.SelectedRows[0].Cells["book_title"].Value.ToString();
            string author = dgv_books.SelectedRows[0].Cells["book_author"].Value.ToString();
            int count = int.Parse(dgv_books.SelectedRows[0].Cells["book_count"].Value.ToString());
            int freeBooks = int.Parse(dgv_books.SelectedRows[0].Cells["book_availible"].Value.ToString());

            if (count != 0)
            {
                // get list of sample only from this person
                List<Sample> personSampleList = libraryDB.GetSampleListByPersonId(loggedCustomer.Id);

                foreach (Sample sample in personSampleList)
                {
                    // check if book already exist as loaned
                    if (sample.BookId.Equals(bookId))
                    {
                        MessageBox.Show("Sie haben dieses Buch schon ausgeliehen.");
                        return;
                    }
                }

                // get list of sample for this book
                List<Sample> sampleList = libraryDB.GetSampleList();

                foreach (Sample sample in sampleList)
                {
                    // check if book already exist as reserved
                    if (sample.BookId.Equals(bookId) && sample.ReservedByCustomerId.Equals(loggedCustomer.Id))
                    {
                        MessageBox.Show("Sie haben dieses Buch schon vorbestellt.");
                        return;
                    }
                }

                if (freeBooks == 0)
                {
                    // reserve first sample
                    libraryDB.ReservedFirstLoanedSampleByBookId(bookId, loggedCustomer.Id);

                    // refresh lists
                    RefreshBookList();
                    RefreshPreorderAccount();

                    MessageBox.Show("Das Buch " + title + " von " + author + " wurde für Sie reserviert.");
                }
                else
                {
                    MessageBox.Show("Dieses Buch steht zum sofortigen Verleih zur Verfügung.");
                }
            }
            else
            {
                MessageBox.Show("Derzeit verfügen wir über keine Exemplare.");
            }
        }


        private void BringBackLoanedBooks()
        {
            foreach (Sample sample in loggedCustomer.LoanAccount.SampleList)
            {
                if (sample.Status.Equals("ausgeliehen")) {
                    if (DateTime.Now >= sample.EndOfLoan)
                    {
                        MessageBox.Show("Ihre geliehene Bücher werden zurückgegeben.");

                        // calculate overdrowed days
                        int overdrowedDays = (DateTime.Now - sample.EndOfLoan).Days;

                        // mark sample as free
                        libraryDB.UpdateSample(sample.Id, loggedCustomer.Id, "frei");

                        if (overdrowedDays != 0)
                        {
                            // add new charges  and update because sample was overdrowed
                            double overdrowResult = overdrowedDays * libraryInfo.OverdrowCharge;
                            loggedCustomer.ChargeAccount.Charges = overdrowResult;
                            libraryDB.UpdateCharges(loggedCustomer.Id, overdrowResult);

                            MessageBox.Show("Ihr Konto wurde mit " + overdrowResult  + " Euro Überziehungsgebühr belastet.");
                        }

                        RefreshLoanAccount();
                    }
                }
            }
        }


        private void GetReservedBook()
        {
            // get list of samples which is reserved from this customer
            List<Sample> reservedSampleList = libraryDB.GetReservedFreeSamples(loggedCustomer.Id);

            // loop sample list
            foreach (Sample sample in reservedSampleList)
            {
                int bookId = sample.BookId;

                // create new date and update sample as loaned
                DateTime endOfLoan = DateTime.Now.AddDays(libraryInfo.PeriodOfLoan);
                libraryDB.UpdateSample(sample.Id, loggedCustomer.Id, endOfLoan, "ausgeliehen", 0);

                // add and update new charges 
                loggedCustomer.ChargeAccount.addCharges(libraryInfo.Charge);
                libraryDB.UpdateCharges(loggedCustomer.Id, loggedCustomer.ChargeAccount.Charges);

                Book book = libraryDB.GetBookBySampleId(sample.Id);

                MessageBox.Show("Ihre vorbestelltes Buch " + book.Title + " von " + book.Author + " wurde soebend Ihnen bis " + endOfLoan.ToShortDateString() + 
                    " zugewiesen und ihr Konto mit " + loggedCustomer.ChargeAccount.Charges + " belastet.");
            }
        }
    }
}
