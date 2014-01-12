using LibraryForm.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryForm
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
        LibraryDB libraryDB = new LibraryDB();
        libraryDB.InitializeConnetion();
        libraryDB.CreateAllTables();

      //Application.EnableVisualStyles();
      //Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new Form1());
    }
  }
}
