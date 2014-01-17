using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bibliothek;
using System.Globalization;
using LibraryForm.Class;

namespace LibraryForm
{
	partial class Form_Employee : Form
	{
		LibraryDB libraryDB;

		Employee loggedEmployee;

		List<Employee> employeeList;
		List<Customer> customerList;
		List<String> bookGenreList;
		List<String> bookAccessList;
		List<Book> bookList;
		List<Sample> sampleList = new List<Sample>();
		List<String> bookStatus;


		public Form_Employee(LibraryDB libraryDB, Person person)
		{
			InitializeComponent();

			this.libraryDB = libraryDB;
			this.loggedEmployee = libraryDB.GetEmployeeById(person.Id);

			employeeList = libraryDB.GetEmployeeList();
			customerList = libraryDB.GetCustomerList();

			bookGenreList = new Book().GetBookGenreList();
			bookAccessList = new Sample().GetSampleAccessList();
			bookStatus = new Sample().GetSampleStatusList();


			loadPersonList();
			loadBookList();
			loadBookAccessList();
			loadBookGenreList();
			loadBookStatusList();
			loadSampleList();
		}


		public void refreshCustomerList()
		{
			dgv_customerList.DataSource = null;
			dgv_customerList.DataSource = libraryDB.GetCustomerList();
		}

		public void refreshStaffList()
		{
			dgv_employeeList.DataSource = null;
			dgv_employeeList.DataSource = libraryDB.GetEmployeeList();
		}

		public void refreshSampleList()
		{
			dgv_Sample.DataSource = null;
			dgv_Sample.DataSource = libraryDB.GetSampleList();
		}

		public void refreshBookList()
		{
			dgv_Book.DataSource = null;
			dgv_Book.DataSource = libraryDB.GetBookList();

			foreach (var item in bookList)
			{
				ComboboxItem comboItem = new ComboboxItem();
				comboItem.Text = item.Author + " / " + item.Title;
				comboItem.Value = item;

				cbo_BookList.Items.Add(comboItem);
			}

		}


		public void resetTextBoxes()
		{
			namePerson.Text = "";
			lastnamePerson.Text = "";
			idPerson.Text = "";
			pwPerson.Text = "";
			chkCustomer.Checked = false;
			bdayPerson.Text = DateTime.Now.ToString();
		}


		public void chkBookAccessList(string accessEntry)
		{
			string accessExist = bookAccessList.Find(delegate(String access) { return access == accessEntry; });

			if (accessExist == null)
			{
				bookAccessList.Add(accessEntry);
				loadBookAccessList();
			}

		}


		public void chkBookGenreList(string genreEntry)
		{
			string genreExist = bookGenreList.Find(delegate(String genre) { return genre == genreEntry; });

			if (genreExist == null)
			{
				bookGenreList.Add(genreEntry);
				loadBookGenreList();
			}

		}


		public void loadBookAccessList()
		{
			cbo_access.Items.Clear();

			foreach (var item in bookAccessList)
			{
				cbo_access.Items.Add(item);
			}
		}


		public void loadBookGenreList()
		{
			cbo_BookGenre.Items.Clear();

			foreach (var item in bookGenreList)
			{
				cbo_BookGenre.Items.Add(item);
			}
		}


		public void loadPersonList()
		{
			// load customer and employee list from db
			customerList = libraryDB.GetCustomerList();
			employeeList = libraryDB.GetEmployeeList();

			// refresh customer view
			dgv_customerList.AutoGenerateColumns = false;
			refreshCustomerList();

			// refresh employee view
			dgv_employeeList.AutoGenerateColumns = false;
			refreshStaffList();
		}

		public void loadBookList()
		{
			// load book list from db
			bookList = libraryDB.GetBookList();

			// refresh
			dgv_Book.AutoGenerateColumns = false;
			refreshBookList();
		}

		public void loadBookStatusList()
		{
			cbo_bookStatus.Items.Clear();
			foreach (var item in bookStatus)
			{
				cbo_bookStatus.Items.Add(item);
			}
		}

		public void loadSampleList()
		{
			sampleList.Clear();
			foreach (var book in bookList)
			{
				foreach (var Sample in book.Sample)
				{
					sampleList.Add(Sample);
				}
			}

			dgv_Sample.AutoGenerateColumns = false;
			dgv_Sample.DataSource = null;
			dgv_Sample.DataSource = sampleList;
		}


		private void IdPerson_TextChanged(object sender, EventArgs e)
		{
			// enabled the create Person button, if text inside the idPerson
			if (!string.IsNullOrWhiteSpace(idPerson.Text))
			{
				idPerson.Enabled = false;
			}
			// disabled
			else
			{
				idPerson.Enabled = true;
			}
		}


		private void createPerson_Click(object sender, EventArgs e)
		{
			if (namePerson.Text == "" || namePerson.Text.Length < 3)
			{
				MessageBox.Show("Bitte korrekten Vorname eingeben");
				return;
			}

			if (lastnamePerson.Text == "" || lastnamePerson.Text.Length < 3)
			{
				MessageBox.Show("Bitte korrekten Nachname eingeben");
				return;
			}

			if (pwPerson.Text.Length < 4)
			{
				MessageBox.Show("Passwort zu kurz! Bitte min. 4 Zeichen eingeben!");
				return;
			}

			if (chkCustomer.Checked == false)
			{
				try
				{
					DateTime bday = DateTime.ParseExact(bdayPerson.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);

					Employee newEmployee = new Employee();
					newEmployee.Rank = 2;
					newEmployee.Pw = pwPerson.Text;
					newEmployee.Firstname = namePerson.Text;
					newEmployee.Lastname = lastnamePerson.Text;
					newEmployee.Birthday = bday;

					libraryDB.CreateEmployee(newEmployee);

					refreshStaffList();
					resetTextBoxes();
					dgv_persons.SelectedIndex = 1;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
				}
			}
			else if (chkCustomer.Checked == true)
			{
				try
				{
					Customer newCustomer = new Customer();
					newCustomer.Rank = 2;
					newCustomer.Pw = pwPerson.Text;
					newCustomer.Firstname = namePerson.Text;
					newCustomer.Lastname = lastnamePerson.Text;

					DateTime bday = DateTime.ParseExact(bdayPerson.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
					newCustomer.Birthday = bday;
					newCustomer.RegisterDate = DateTime.Now;

					libraryDB.CreateCustomer(newCustomer);

					refreshCustomerList();
					resetTextBoxes();
					dgv_persons.SelectedIndex = 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
				}

			}


		}


		private void deletePersonButton_Click(object sender, EventArgs e)
		{
			if (dgv_persons.SelectedIndex == 0)
			{
				try
				{

					customerList.Remove((Customer)dgv_customerList.SelectedRows[0].DataBoundItem);
					libraryDB.DeletePerson(((bibliothek.Person)(dgv_customerList.SelectedRows[0].DataBoundItem)).Id);
					//customerList.Rows.RemoveAt(this.customerList.SelectedRows[0].Index);
					refreshCustomerList();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
				}
			}
			else if (dgv_persons.SelectedIndex == 1)
			{
				try
				{
					employeeList.Remove((Employee)dgv_employeeList.SelectedRows[0].DataBoundItem);
					libraryDB.DeletePerson(((bibliothek.Person)(dgv_employeeList.SelectedRows[0].DataBoundItem)).Id);
					refreshStaffList();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Fehler: keine Personenliste ausgewählt!");
			}
		}

		private void searchPerson_Click(object sender, EventArgs e)
		{
			if (pwPerson.Text != "")
			{
				MessageBox.Show("Bitte beachten Sie, das Suchen nach Passwörtern,\n ist aus Sicherheitsgründen nicht möglich!");
				pwPerson.Text = "";
			}



			if (dgv_persons.SelectedIndex == 0)
			{
				List<Customer> searchList = new List<Customer>();
				dgv_customerList.DataSource = null;
				customerList = libraryDB.GetCustomerList();
				foreach (var item in customerList)
				{
					if (namePerson.Text.ToUpper() == item.Firstname.ToUpper() || lastnamePerson.Text.ToUpper() == item.Lastname.ToUpper() || idPerson.Text == Convert.ToString(item.Id))
					{
						searchList.Add(item);
					}
				}
				dgv_customerList.DataSource = searchList;
				if (searchList.Count == 0)
				{
					MessageBox.Show("Es wurde keine Übereinstimmung gefunden");
				}
				else
				{
					MessageBox.Show("Es wurden " + searchList.Count + " Übereinstimmungen gefunden");
				}

			}
			else
			{
				List<Employee> searchList = new List<Employee>();
				dgv_employeeList.DataSource = null;
				employeeList = libraryDB.GetEmployeeList();
				foreach (var item in employeeList)
				{
					if (namePerson.Text.ToUpper() == item.Firstname.ToUpper() || lastnamePerson.Text.ToUpper() == item.Lastname.ToUpper())
					{
						searchList.Add(item);
					}
				}
				dgv_employeeList.DataSource = searchList;
				if (searchList.Count == 0)
				{
					MessageBox.Show("Es wurde keine Übereinstimmung gefunden");
				}
				else
				{
					MessageBox.Show("Es wurden " + searchList.Count + " Übereinstimmungen gefunden");
				}

			}
		}

		private void resetSearch_Click(object sender, EventArgs e)
		{
			resetTextBoxes();
			refreshCustomerList();
			refreshStaffList();
		}

		private void chkCustomer_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCustomer.Checked == true)
			{
				dgv_persons.SelectedIndex = 0;
			}
			else
			{
				dgv_persons.SelectedIndex = 1;
			}
		}

		private void chkPersonTab_ChangedSelectedIndex(object sender, EventArgs e)
		{
			if (dgv_persons.SelectedIndex == 0)
			{
				chkCustomer.Checked = true;
			}
			else
			{
				chkCustomer.Checked = false;
			}

		}

		private void btn_BookAdd_Click(object sender, EventArgs e)
		{
			if (tbx_BookTitle.Text == "")
			{
				MessageBox.Show("Bitte einen Buchtitel vergeben!");
				return;
			}
			if (tbx_BookAuthor.Text == "")
			{
				MessageBox.Show("Bitte einen Buchauthor vergeben!");
				return;
			}
			if (cbo_access.Text == "")
			{
				MessageBox.Show("Bitte einen Zugang auswählen oder einen neuen eingeben!");
				return;
			}
			if (cbo_BookGenre.Text == "")
			{
				MessageBox.Show("Bitte eine Genre auswählen oder eine neue eingeben!");
				return;
			}

			try
			{
				chkBookAccessList(cbo_access.Text);
				chkBookGenreList(cbo_BookGenre.Text);

				Book book = new Book();
				book.Title = tbx_BookTitle.Text;
				book.Author = tbx_BookAuthor.Text;
				book.Access = cbo_access.Text;
				book.Genre = cbo_BookGenre.Text;

				libraryDB.CreateBook(book);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
			}
			finally
			{
				refreshBookList();
			}




		}

		private void cbo_BookList_ChangedSelectedIndex(object sender, EventArgs e)
		{

			try
			{
				Book book = (Book)((LibraryForm.ComboboxItem)(cbo_BookList.SelectedItem)).Value;

				char genreStamp = book.Genre.Substring(0, 1)[0];
				char authorStamp = book.Author.Substring(0, 1)[0];

				string Rand = RandomString(10);

				tb_SampleID.Text = genreStamp.ToString() + authorStamp.ToString() + "-" + Rand;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
			}
		}
		private string RandomString(int size)
		{
			var chars = "ABCDEFG0123456789";
			var stringChars = new char[size];
			var random = new Random();

			for (int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = chars[random.Next(chars.Length)];
			}

			var finalString = new String(stringChars);

			return finalString;
		}

		private void btn_AddSample_Click(object sender, EventArgs e)
		{
			if (cbo_BookList.Text == "")
			{
				MessageBox.Show("Bitte Buch auswählen!");
				return;
			}
			if (cbo_bookStatus.Text == "")
			{
				MessageBox.Show("Bitte Status auswählen!");
				return;
			}

			try
			{
				Book book = (Book)((LibraryForm.ComboboxItem)(cbo_BookList.SelectedItem)).Value;
				//book.AddSample(tb_SampleID.Text, book, cbo_bookStatus.Text);
				libraryDB.CreateSample(new Sample(tb_SampleID.Text, cbo_bookStatus.Text), book.Id);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
			}
			finally
			{
				refreshSampleList();
			}

		}

		private void btn_DelBook_Click(object sender, EventArgs e)
		{
			bookList.Remove((Book)dgv_Book.SelectedRows[0].DataBoundItem);
			libraryDB.DeleteBook(((Book)dgv_Book.SelectedRows[0].DataBoundItem).Id);
			refreshBookList();
			refreshSampleList();

		}

		private void btn_BookSearch_Click(object sender, EventArgs e)
		{


			List<Book> searchList = new List<Book>();
			dgv_Book.DataSource = null;
			bookList = libraryDB.GetBookList();
			foreach (var item in bookList)
			{
				if (tbx_BookAuthor.Text.ToUpper() == item.Author.ToUpper() || cbo_BookGenre.Text.ToUpper() == item.Genre.ToUpper() || tbx_BookTitle.Text == item.Title.ToUpper() || tbx_access.Text == item.Access.ToUpper())
				{
					searchList.Add(item);
				}
			}
			dgv_Book.DataSource = searchList;
			if (searchList.Count == 0)
			{
				MessageBox.Show("Es wurde keine Übereinstimmung gefunden");
			}
			else
			{
				MessageBox.Show("Es wurden " + searchList.Count + " Übereinstimmungen gefunden");
			}
		}




		
	}
	public class ComboboxItem
	{
		public string Text { get; set; }
		public object Value { get; set; }

		public override string ToString()
		{
			return Text;
		}
	}
}

