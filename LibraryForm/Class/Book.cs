using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
    class Book
    {
        private int id;
        private string title;
        private string access;
        private string author;
        private string genre;
        private int count;    //Anzahl Sample
        private List<Sample> sample = new List<Sample>();


        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }


        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }


        public string Access
        {
            get { return access; }
            set { this.access = value; }
        }


        public string Author
        {
            get { return author; }
            set { this.author = value; }
        }


        public string Genre
        {
            get { return genre; }
            set { this.genre = value; }
        }


        public int Count
        {
            get { return count; }
            set { this.count = value; }
        }


        public List<Sample> Sample
        {
            get { return sample; }
            set { this.sample = value; }
        }


        public Book() { }


        public Book(int id, string title, string access, string author, string genre, int count)
        {
            this.id = id;
            this.title = title;
            this.access = access;
            this.author = author;
            this.genre = genre;
            this.count = count;
        }


        public void AddSample(Sample sample)
        {
            this.sample.Add(sample);
        }


        public void AddSample(string id, int customerId, DateTime endOfLoan, string status, int reservedByCustomerId)
        {
            this.sample.Add(new Sample(id, customerId, endOfLoan, status, reservedByCustomerId));
        }


        public List<string> GetBookGenreList()
        {
            List<string> bookGenreList = new List<string>();
            bookGenreList.Add("Thriller");
            bookGenreList.Add("Krimi");
            bookGenreList.Add("Drama");
            bookGenreList.Add("Komödie");
            bookGenreList.Add("Dokumentation");
            bookGenreList.Add("Biographie");
            bookGenreList.Add("Fantasy");
            bookGenreList.Add("SciFi");

            return bookGenreList;
        }
    }
}
