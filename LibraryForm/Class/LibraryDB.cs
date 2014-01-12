using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bibliothek;
using System.Data.SQLite;

namespace LibraryForm.Class
{
    class LibraryDB
    {
        // sqlite connection
        SQLiteConnection connection;

        // database
        string datasource = "SQLiteLibrary.db";

        // open a sqlite connection
        public void InitializeConnetion()
        {
            this.connection = new SQLiteConnection();
            this.connection.ConnectionString = "Data Source=" + datasource;
            this.connection.Open();
        }


        public void CloseConnection()
        {
            // close and dispose connection
            this.connection.Close();
            this.connection.Dispose();
        }


        public List<Person> GetPersonList()
        {
            List<Person> personList = new List<Person>();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM persons";
            
            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Person person = new Person();

                person.Id = int.Parse(reader["id"].ToString());
                person.Rank = int.Parse(reader["rank"].ToString());
                person.Pw = reader["pw"].ToString();
                person.Firstname = reader["firstname"].ToString();
                person.Lastname = reader["lastname"].ToString();
                person.Birthday = DateTime.Parse(reader["birthday"].ToString());

                personList.Add(person);                
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return personList;
        }


        public void CreateEmployee(Employee employee)
        {
            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "INSERT INTO persons(id, rank, pw, firstname, lastname, birthday) VALUES (NULL, 1, '" + employee.Pw + "', '" + employee.Firstname + "', '" + employee.Lastname + "', '" + employee.Birthday + "');";
            command.ExecuteNonQuery();

            // create query
            command.CommandText = "SELECT id FROM persons WHERE firstname = " + employee.Firstname + " AND lastname = " + employee.Lastname;
            SQLiteDataReader reader = command.ExecuteReader();

            int newId = 0;

            if (reader.Read())
            {
                newId = int.Parse(reader["id"].ToString());
            }

            reader.Close();
            reader.Dispose();

            // create query
            command.CommandText = "INSERT INTO employees(person_id) VALUES (" + newId + ");";
            command.ExecuteNonQuery();

            command.Dispose();
        }


        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM persons WHERE id = " + id + " AND rank = 1";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                employee.Id = int.Parse(reader["id"].ToString());
                employee.Rank = int.Parse(reader["rank"].ToString());
                employee.Pw = reader["pw"].ToString();
                employee.Firstname = reader["firstname"].ToString();
                employee.Lastname = reader["lastname"].ToString();
                employee.Birthday = DateTime.Parse(reader["birthday"].ToString());
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return employee;
        }


        public List<Employee> GetEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM persons WHERE rank = 1";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Employee employee = new Employee();

                employee.Id = int.Parse(reader["id"].ToString());
                employee.Rank = int.Parse(reader["rank"].ToString());
                employee.Pw = reader["pw"].ToString();
                employee.Firstname = reader["firstname"].ToString();
                employee.Lastname = reader["lastname"].ToString();
                employee.Birthday = DateTime.Parse(reader["birthday"].ToString());

                employeeList.Add(employee);
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return employeeList;
        }


        public void CreateCustomer(Customer customer)
        {
            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "INSERT INTO persons(id, rank, pw, firstname, lastname, birthday) VALUES (NULL, 1, '" + customer.Pw + "', '" + customer.Firstname + "', '" + customer.Lastname + "', '" + customer.Birthday + "');";
            command.ExecuteNonQuery();

            // create query
            command.CommandText = "SELECT id FROM persons WHERE firstname = " + customer.Firstname + " AND lastname = " + customer.Lastname;
            SQLiteDataReader reader = command.ExecuteReader();

            int newId = 0;

            if (reader.Read())
            {
                newId = int.Parse(reader["id"].ToString());
            }

            reader.Close();
            reader.Dispose();

            // create query
            command.CommandText = "INSERT INTO customers(person_id, register_date) VALUES (" + newId + ", '" + customer.RegisterDate + "');";
            command.ExecuteNonQuery();

            command.Dispose();
        }


        public Customer GetCustomerById(int id)
        {
            Customer customer = new Customer();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM persons WHERE id = " + id + " AND rank = 2";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                customer.Id = int.Parse(reader["id"].ToString());
                customer.Rank = int.Parse(reader["rank"].ToString());
                customer.Pw = reader["pw"].ToString();
                customer.Firstname = reader["firstname"].ToString();
                customer.Lastname = reader["lastname"].ToString();
                customer.Birthday = DateTime.Parse(reader["birthday"].ToString());
                customer.RegisterDate = DateTime.Parse(reader["register_date"].ToString());
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return customer;
        }


        public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM persons WHERE rank = 2";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer();

                customer.Id = int.Parse(reader["id"].ToString());
                customer.Rank = int.Parse(reader["rank"].ToString());
                customer.Pw = reader["pw"].ToString();
                customer.Firstname = reader["firstname"].ToString();
                customer.Lastname = reader["lastname"].ToString();
                customer.Birthday = DateTime.Parse(reader["birthday"].ToString());
                customer.RegisterDate = DateTime.Parse(reader["register_date"].ToString());

                customerList.Add(customer);
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return customerList;
        }


        public void CreateBook(Book book)
        {
            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "INSERT INTO books(id, title, author, genre, access, count) VALUES (NULL, '" + book.Title + "', '" + book.Author + "', '" + book.Genre + "', '" + book.Access + "', 1);";
            command.ExecuteNonQuery();
            
            command.Dispose();
        }


        public Book GetBookBySampleId(int id)
        {
            Book book = new Book();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM books WHERE id = " + id;

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                book.Id = int.Parse(reader["id"].ToString());
                book.Title = reader["title"].ToString();
                book.Author = reader["author"].ToString();
                book.Genre = reader["genre"].ToString();
                book.Count = int.Parse(reader["count"].ToString());
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return book;
        }


        public List<Book> GetBookList()
        {
            List<Book> bookList = new List<Book>();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM books";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book();

                book.Id = int.Parse(reader["id"].ToString());
                book.Title = reader["title"].ToString();
                book.Author = reader["author"].ToString();
                book.Genre = reader["genre"].ToString();
                book.Count = int.Parse(reader["count"].ToString());

                bookList.Add(book);
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return bookList;
        }


        public void CreateSample(Sample sample)
        {
            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "INSERT INTO samples(id, book_id, customer_id, end_of_loan, status) VALUES (NULL, '" + sample.Book.Id + "', '" + sample.CustomerId + "', '" + sample.EndOfLoan + "', '" + sample.Status + "');";
            command.ExecuteNonQuery();

            command.Dispose();
        }

        public List<Sample> GetSampleList()
        {
            List<Sample> sampleList = new List<Sample>();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM samples";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Sample sample = new Sample();

                sample.Id = int.Parse(reader["id"].ToString());
                sample.CustomerId = int.Parse(reader["customer_id"].ToString());
                sample.EndOfLoan = DateTime.Parse(reader["end_of_loan"].ToString());
                sample.Status = reader["status"].ToString();

                sample.Book = GetBookBySampleId(sample.Id);

                sampleList.Add(sample);
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return sampleList;
        }


        public List<Sample> GetSampleListByPersonId(int personId)
        {
            List<Sample> sampleList = new List<Sample>();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM samples WHERE customer_id =" + personId + " AND status = 'ausgeliehen'";

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Sample sample = new Sample();

                sample.Id = int.Parse(reader["id"].ToString());
                sample.CustomerId = int.Parse(reader["customer_id"].ToString());
                sample.EndOfLoan = DateTime.Parse(reader["end_of_loan"].ToString());
                sample.Status = reader["status"].ToString();

                sample.Book = GetBookBySampleId(sample.Id);

                sampleList.Add(sample);
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return sampleList;
        }


        public ChargeAccount GetChargeAccountByPersonId(int personId)
        {
            ChargeAccount chargeAccount = new ChargeAccount();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT charges FROM persons WHERE person_id =" + personId;

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                chargeAccount.Charges = int.Parse(reader["charges"].ToString());
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return chargeAccount;
        }


        public MessageAccount GetMessageAccountByPersonId(int personId)
        {
            MessageAccount messageAccount = new MessageAccount();

            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create query
            command.CommandText = "SELECT * FROM messages WHERE person_id =" + personId;

            //craete reader
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {  
                Message message = new Message();
                message.Id = int.Parse(reader["id"].ToString());
                message.PersonId = int.Parse(reader["person_id"].ToString());
                message.MessageText = reader["message"].ToString();
                message.CreationDate = DateTime.Parse(reader["creation_date"].ToString());

                messageAccount.MessageDict.Add(message.Id, message);
            }

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return messageAccount;
        }


        public void CreateAllTables()
        {
            // create command
            SQLiteCommand command = new SQLiteCommand(connection);

            // create tables query
            command.CommandText = "CREATE TABLE IF NOT EXISTS persons (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, rank INTEGER NOT NULL, pw VARCHAR(100) NOT NULL, lastname VARCHAR(100) NOT NULL, firstname VARCHAR(100) NOT NULL, birthday VARCHAR(100) NOT NULL, charges DOUBLE NULL);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS employees (person_id INTEGER NOT NULL);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS customers (person_id INTEGER NOT NULL, register_date VARCHAR(100) NOT NULL);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS books (id INTEGER NOT NULL, title VARCHAR(100) NOT NULL, author VARCHAR(100) NOT NULL, genre VARCHAR(100) NOT NULL, access VARCHAR(100) NOT NULL, count INTEGER NOT NULL);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS samples (id INTEGER NOT NULL, book_id INTEGER NOT NULL, customer_id INTEGER NOT NULL, end_of_loan VARCHAR(100) NOT NULL, status VARCHAR(100) NOT NULL);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS samples (id INTEGER NOT NULL, person_id INTEGER NOT NULL, message VARCHAR(100) NOT NULL, creation_date VARCHAR(100) NOT NULL);";
            command.ExecuteNonQuery();

            // admin behrend
            command.CommandText = "INSERT INTO persons(rank, pw, lastname, firstname, birthday, charges) VALUES (1, 'admin', 'behrend', 'mario', '15.09.1989', 0)";
            command.ExecuteNonQuery();

            // admin belger
            command.CommandText = "INSERT INTO persons(rank, pw, lastname, firstname, birthday, charges) VALUES (1, 'admin', 'belger', 'norman', '18.01.1984', 0)";
            command.ExecuteNonQuery();

            command.Dispose();
        }
    }
}
