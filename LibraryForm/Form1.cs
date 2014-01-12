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

      libraryDB.CreateAllTables();

      this.personList = libraryDB.GetPersonList();
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
        // textbox input check
        if (!string.IsNullOrWhiteSpace(tb_loginName.Text) && !string.IsNullOrWhiteSpace(tb_password.Text))
        {
            foreach (Person person in personList)
            {
                //MessageBox.Show(person.Lastname + " - " + person.Pw);

                // check if name and pw is in person list
                if (tb_loginName.Text.Equals(person.Lastname) && tb_password.Text.Equals(person.Pw))
                {
                    // rank 1 = employee
                    if (person.Rank == 1)
                    {
                        //TODO: employee aus datenbank holen
                        Form_Employee form_employee = new Form_Employee(libraryDB, person);
                        form_employee.ShowDialog();
                    }
                    // rank 2 = customer
                    else if (person.Rank == 2)
                    {
                        //TODO: customer aus datenbank holen
                        Form_Customer form_customer = new Form_Customer(libraryDB, person);
                        form_customer.ShowDialog();
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

  }
}
