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
  public partial class Form1 : Form
  {
    LibraryDB libraryDB;
    List<Person> personList;

    public Form1()
    {
        InitializeComponent();

        libraryDB = new LibraryDB();
        libraryDB.InitializeConnetion();

        this.personList = libraryDB.GetPersonList();

        lbl_welcome.Text = "Willkommen in Ihrer " + libraryDB.GetLibraryInfo().Name;

        DeleteOldMessages();
     }

    private void btn_login_Click(object sender, EventArgs e)
    {
        // textbox input check
        if (!string.IsNullOrWhiteSpace(tb_loginName.Text) && !string.IsNullOrWhiteSpace(tb_password.Text))
        {
            foreach (Person person in personList)
            {
                // check if name and pw is in person list
                if (tb_loginName.Text.ToLower().Equals(person.Lastname.ToLower()) && tb_password.Text.Equals(person.Pw))
                {
                    // rank 1 = employee
                    if (person.Rank == 1)
                    {
                        //TODO: employee aus datenbank holen
                        Form_Employee form_employee = new Form_Employee(libraryDB, person);
                        form_employee.ShowDialog();

                        // clear textboxes
                        tb_loginName.Clear();
                        tb_password.Clear();
                        return;
                    }
                    // rank 2 = customer
                    else if (person.Rank == 2)
                    {
                        //TODO: customer aus datenbank holen
                        Form_Customer form_customer = new Form_Customer(libraryDB, person);
                        form_customer.ShowDialog();

                        // clear textboxes
                        tb_loginName.Clear();
                        tb_password.Clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Unbekannter Systemfehler!");
                    }
                }
            }

            MessageBox.Show("Name und/oder Passwort falsch!");
            return;
        }
        else
        {
            MessageBox.Show("Bitte Namen und Passwort eingeben.");
        }
    }


    private void DeleteOldMessages()
    {
        List<bibliothek.Message> messageList = libraryDB.GetMessages();

        DateTime sixtyDays = DateTime.Now.AddDays(-60);

        foreach (bibliothek.Message message in messageList)
        {
            DateTime creationDate = message.CreationDate;

            if (creationDate < sixtyDays)
            {
                libraryDB.DeleteMessage(message.Id);
            }
        }
    }


    private void btn_close_Click(object sender, EventArgs e)
    {
        this.Close();
    }
  }
}
