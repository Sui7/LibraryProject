﻿using LibraryForm.Class;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
        // initialize tables by first run
        LibraryDB libraryDB = new LibraryDB();
        libraryDB.InitializeConnetion();
				if (! libraryDB.ExistTables()) libraryDB.CreateAllTables();
        libraryDB.CloseConnection();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());


    }

		

  }
}


 