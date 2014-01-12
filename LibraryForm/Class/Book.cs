using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibliothek
{
  public class Book
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
          set { this.id = Id; }
      }


      public string Title
      {
          get { return title; }
          set { this.title = Title; }
      }


      public string Access
      {
          get { return access; }
          set { this.access = Access; }
      }


      public string Author
      {
          get { return author; }
          set { this.author = Author; }
      }


      public string Genre
      {
          get { return genre; }
          set { this.genre = Genre; }
      }


      public int Count
      {
          get { return count; }
          set { this.count = Count; }
      }


      public List<Sample> Sample
      {
          get { return sample; }
          set { this.sample = Sample; }
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


      public void AddSample(int id, Book book, string status)
      {
          this.sample.Add(new Sample(id, book, status));
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

          return bookGenreList;
      }
  }


}
