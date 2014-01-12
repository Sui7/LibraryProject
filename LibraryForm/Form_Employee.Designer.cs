namespace LibraryForm
{
  partial class Form_Employee
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_PersonManagement = new System.Windows.Forms.TabPage();
            this.dgv_persons = new System.Windows.Forms.TabControl();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.dgv_customerList = new System.Windows.Forms.DataGridView();
            this.column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Staff = new System.Windows.Forms.TabPage();
            this.dgv_employeeList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetSearch = new System.Windows.Forms.Button();
            this.pwPerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bdayPerson = new System.Windows.Forms.DateTimePicker();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idPerson = new System.Windows.Forms.TextBox();
            this.searchPerson = new System.Windows.Forms.Button();
            this.createPerson = new System.Windows.Forms.Button();
            this.namePerson = new System.Windows.Forms.TextBox();
            this.lastnamePerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tp_books = new System.Windows.Forms.TabPage();
            this.dgv_Book = new System.Windows.Forms.DataGridView();
            this.column_BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_BookGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_bookSearch = new System.Windows.Forms.GroupBox();
            this.cbo_access = new System.Windows.Forms.ComboBox();
            this.tbx_access = new System.Windows.Forms.Label();
            this.btn_BookSearch = new System.Windows.Forms.Button();
            this.btn_DelBook = new System.Windows.Forms.Button();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.cbo_BookGenre = new System.Windows.Forms.ComboBox();
            this.tbx_BookTitle = new System.Windows.Forms.TextBox();
            this.btn_BookAdd = new System.Windows.Forms.Button();
            this.tbx_BookAuthor = new System.Windows.Forms.TextBox();
            this.tp_Samples = new System.Windows.Forms.TabPage();
            this.dgv_Sample = new System.Windows.Forms.DataGridView();
            this.column_SampleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_SampleCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_SampleBeginOfLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_SampleEndOfLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_SampleState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_bookStatus = new System.Windows.Forms.ComboBox();
            this.cbo_BookList = new System.Windows.Forms.ComboBox();
            this.tb_SampleID = new System.Windows.Forms.TextBox();
            this.btn_SampleSearch = new System.Windows.Forms.Button();
            this.btn_AddSample = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_DelSample = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_personName = new System.Windows.Forms.Label();
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tp_PersonManagement.SuspendLayout();
            this.dgv_persons.SuspendLayout();
            this.tab_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerList)).BeginInit();
            this.tab_Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tp_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            this.gb_bookSearch.SuspendLayout();
            this.tp_Samples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sample)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_PersonManagement);
            this.tabControl1.Controls.Add(this.tp_books);
            this.tabControl1.Controls.Add(this.tp_Samples);
            this.tabControl1.Location = new System.Drawing.Point(13, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 382);
            this.tabControl1.TabIndex = 7;
            // 
            // tp_PersonManagement
            // 
            this.tp_PersonManagement.Controls.Add(this.dgv_persons);
            this.tp_PersonManagement.Controls.Add(this.groupBox2);
            this.tp_PersonManagement.Location = new System.Drawing.Point(4, 22);
            this.tp_PersonManagement.Name = "tp_PersonManagement";
            this.tp_PersonManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PersonManagement.Size = new System.Drawing.Size(552, 356);
            this.tp_PersonManagement.TabIndex = 0;
            this.tp_PersonManagement.Text = "Personenverwaltung";
            this.tp_PersonManagement.UseVisualStyleBackColor = true;
            // 
            // dgv_persons
            // 
            this.dgv_persons.Controls.Add(this.tab_Customer);
            this.dgv_persons.Controls.Add(this.tab_Staff);
            this.dgv_persons.Location = new System.Drawing.Point(3, 133);
            this.dgv_persons.Name = "dgv_persons";
            this.dgv_persons.SelectedIndex = 0;
            this.dgv_persons.Size = new System.Drawing.Size(543, 217);
            this.dgv_persons.TabIndex = 12;
            this.dgv_persons.SelectedIndexChanged += new System.EventHandler(this.chkPersonTab_ChangedSelectedIndex);
            // 
            // tab_Customer
            // 
            this.tab_Customer.Controls.Add(this.dgv_customerList);
            this.tab_Customer.Location = new System.Drawing.Point(4, 22);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customer.Size = new System.Drawing.Size(535, 191);
            this.tab_Customer.TabIndex = 0;
            this.tab_Customer.Text = "Kunden";
            this.tab_Customer.UseVisualStyleBackColor = true;
            // 
            // dgv_customerList
            // 
            this.dgv_customerList.AllowUserToAddRows = false;
            this.dgv_customerList.AllowUserToDeleteRows = false;
            this.dgv_customerList.AllowUserToOrderColumns = true;
            this.dgv_customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ID,
            this.column_Lastname,
            this.column_Firstname,
            this.column_Birthday});
            this.dgv_customerList.Location = new System.Drawing.Point(0, 0);
            this.dgv_customerList.Name = "dgv_customerList";
            this.dgv_customerList.ReadOnly = true;
            this.dgv_customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customerList.Size = new System.Drawing.Size(535, 188);
            this.dgv_customerList.TabIndex = 12;
            this.dgv_customerList.VirtualMode = true;
            // 
            // column_ID
            // 
            this.column_ID.DataPropertyName = "Id";
            this.column_ID.FillWeight = 40F;
            this.column_ID.HeaderText = "Kundennr";
            this.column_ID.Name = "column_ID";
            this.column_ID.ReadOnly = true;
            this.column_ID.Width = 60;
            // 
            // column_Lastname
            // 
            this.column_Lastname.DataPropertyName = "Lastname";
            this.column_Lastname.FillWeight = 120F;
            this.column_Lastname.HeaderText = "Nachname";
            this.column_Lastname.Name = "column_Lastname";
            this.column_Lastname.ReadOnly = true;
            this.column_Lastname.Width = 120;
            // 
            // column_Firstname
            // 
            this.column_Firstname.DataPropertyName = "Firstname";
            this.column_Firstname.FillWeight = 120F;
            this.column_Firstname.HeaderText = "Vorname";
            this.column_Firstname.Name = "column_Firstname";
            this.column_Firstname.ReadOnly = true;
            this.column_Firstname.Width = 120;
            // 
            // column_Birthday
            // 
            this.column_Birthday.DataPropertyName = "Birthday";
            this.column_Birthday.FillWeight = 120F;
            this.column_Birthday.HeaderText = "Geburtstag";
            this.column_Birthday.Name = "column_Birthday";
            this.column_Birthday.ReadOnly = true;
            this.column_Birthday.Width = 120;
            // 
            // tab_Staff
            // 
            this.tab_Staff.Controls.Add(this.dgv_employeeList);
            this.tab_Staff.Location = new System.Drawing.Point(4, 22);
            this.tab_Staff.Name = "tab_Staff";
            this.tab_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Staff.Size = new System.Drawing.Size(535, 191);
            this.tab_Staff.TabIndex = 1;
            this.tab_Staff.Text = "Mitarbeiter";
            this.tab_Staff.UseVisualStyleBackColor = true;
            // 
            // dgv_employeeList
            // 
            this.dgv_employeeList.AllowUserToAddRows = false;
            this.dgv_employeeList.AllowUserToDeleteRows = false;
            this.dgv_employeeList.AllowUserToOrderColumns = true;
            this.dgv_employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_employeeList.Location = new System.Drawing.Point(0, 1);
            this.dgv_employeeList.Name = "dgv_employeeList";
            this.dgv_employeeList.ReadOnly = true;
            this.dgv_employeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeeList.Size = new System.Drawing.Size(535, 188);
            this.dgv_employeeList.TabIndex = 13;
            this.dgv_employeeList.VirtualMode = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn3.FillWeight = 120F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Geburtstag";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetSearch);
            this.groupBox2.Controls.Add(this.pwPerson);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.bdayPerson);
            this.groupBox2.Controls.Add(this.chkCustomer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.idPerson);
            this.groupBox2.Controls.Add(this.searchPerson);
            this.groupBox2.Controls.Add(this.createPerson);
            this.groupBox2.Controls.Add(this.namePerson);
            this.groupBox2.Controls.Add(this.lastnamePerson);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.deletePersonButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exemplare-Mangement";
            // 
            // resetSearch
            // 
            this.resetSearch.Location = new System.Drawing.Point(451, 56);
            this.resetSearch.Name = "resetSearch";
            this.resetSearch.Size = new System.Drawing.Size(75, 23);
            this.resetSearch.TabIndex = 27;
            this.resetSearch.Text = "Reset";
            this.resetSearch.UseVisualStyleBackColor = true;
            this.resetSearch.Click += new System.EventHandler(this.resetSearch_Click);
            // 
            // pwPerson
            // 
            this.pwPerson.Location = new System.Drawing.Point(250, 45);
            this.pwPerson.Name = "pwPerson";
            this.pwPerson.Size = new System.Drawing.Size(100, 20);
            this.pwPerson.TabIndex = 26;
            this.pwPerson.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Passwort:";
            // 
            // bdayPerson
            // 
            this.bdayPerson.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdayPerson.Location = new System.Drawing.Point(83, 78);
            this.bdayPerson.Name = "bdayPerson";
            this.bdayPerson.Size = new System.Drawing.Size(91, 20);
            this.bdayPerson.TabIndex = 24;
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Location = new System.Drawing.Point(223, 80);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(57, 17);
            this.chkCustomer.TabIndex = 23;
            this.chkCustomer.Text = "Kunde";
            this.chkCustomer.UseVisualStyleBackColor = true;
            this.chkCustomer.CheckedChanged += new System.EventHandler(this.chkCustomer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Geburtsdatum:";
            // 
            // idPerson
            // 
            this.idPerson.Location = new System.Drawing.Point(250, 20);
            this.idPerson.Name = "idPerson";
            this.idPerson.Size = new System.Drawing.Size(100, 20);
            this.idPerson.TabIndex = 20;
            // 
            // searchPerson
            // 
            this.searchPerson.Location = new System.Drawing.Point(370, 56);
            this.searchPerson.Name = "searchPerson";
            this.searchPerson.Size = new System.Drawing.Size(75, 23);
            this.searchPerson.TabIndex = 10;
            this.searchPerson.Text = "Suchen";
            this.searchPerson.UseVisualStyleBackColor = true;
            this.searchPerson.Click += new System.EventHandler(this.searchPerson_Click);
            // 
            // createPerson
            // 
            this.createPerson.Location = new System.Drawing.Point(370, 18);
            this.createPerson.Name = "createPerson";
            this.createPerson.Size = new System.Drawing.Size(75, 23);
            this.createPerson.TabIndex = 18;
            this.createPerson.Text = "Hinzufügen";
            this.createPerson.UseVisualStyleBackColor = true;
            this.createPerson.Click += new System.EventHandler(this.createPerson_Click);
            // 
            // namePerson
            // 
            this.namePerson.Location = new System.Drawing.Point(74, 49);
            this.namePerson.Name = "namePerson";
            this.namePerson.Size = new System.Drawing.Size(100, 20);
            this.namePerson.TabIndex = 16;
            // 
            // lastnamePerson
            // 
            this.lastnamePerson.Location = new System.Drawing.Point(74, 20);
            this.lastnamePerson.Name = "lastnamePerson";
            this.lastnamePerson.Size = new System.Drawing.Size(100, 20);
            this.lastnamePerson.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(451, 18);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(75, 23);
            this.deletePersonButton.TabIndex = 13;
            this.deletePersonButton.Text = "Entfernen";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vorname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nachname:";
            // 
            // tp_books
            // 
            this.tp_books.Controls.Add(this.dgv_Book);
            this.tp_books.Controls.Add(this.gb_bookSearch);
            this.tp_books.Location = new System.Drawing.Point(4, 22);
            this.tp_books.Name = "tp_books";
            this.tp_books.Padding = new System.Windows.Forms.Padding(3);
            this.tp_books.Size = new System.Drawing.Size(552, 356);
            this.tp_books.TabIndex = 1;
            this.tp_books.Text = "Bücher";
            this.tp_books.UseVisualStyleBackColor = true;
            // 
            // dgv_Book
            // 
            this.dgv_Book.AllowUserToAddRows = false;
            this.dgv_Book.AllowUserToDeleteRows = false;
            this.dgv_Book.AllowUserToOrderColumns = true;
            this.dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_BookTitle,
            this.column_BookAuthor,
            this.column_BookGenre,
            this.column_BookCount});
            this.dgv_Book.Location = new System.Drawing.Point(5, 94);
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.ReadOnly = true;
            this.dgv_Book.Size = new System.Drawing.Size(543, 170);
            this.dgv_Book.TabIndex = 7;
            // 
            // column_BookTitle
            // 
            this.column_BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_BookTitle.DataPropertyName = "title";
            this.column_BookTitle.FillWeight = 170F;
            this.column_BookTitle.HeaderText = "Titel";
            this.column_BookTitle.Name = "column_BookTitle";
            this.column_BookTitle.ReadOnly = true;
            // 
            // column_BookAuthor
            // 
            this.column_BookAuthor.DataPropertyName = "author";
            this.column_BookAuthor.FillWeight = 120F;
            this.column_BookAuthor.HeaderText = "Author";
            this.column_BookAuthor.Name = "column_BookAuthor";
            this.column_BookAuthor.ReadOnly = true;
            this.column_BookAuthor.Width = 120;
            // 
            // column_BookGenre
            // 
            this.column_BookGenre.DataPropertyName = "genre";
            this.column_BookGenre.FillWeight = 80F;
            this.column_BookGenre.HeaderText = "Genre";
            this.column_BookGenre.Name = "column_BookGenre";
            this.column_BookGenre.ReadOnly = true;
            this.column_BookGenre.Width = 80;
            // 
            // column_BookCount
            // 
            this.column_BookCount.DataPropertyName = "count";
            this.column_BookCount.FillWeight = 60F;
            this.column_BookCount.HeaderText = "Anzahl";
            this.column_BookCount.Name = "column_BookCount";
            this.column_BookCount.ReadOnly = true;
            this.column_BookCount.Width = 60;
            // 
            // gb_bookSearch
            // 
            this.gb_bookSearch.Controls.Add(this.cbo_access);
            this.gb_bookSearch.Controls.Add(this.tbx_access);
            this.gb_bookSearch.Controls.Add(this.btn_BookSearch);
            this.gb_bookSearch.Controls.Add(this.btn_DelBook);
            this.gb_bookSearch.Controls.Add(this.lbl_Genre);
            this.gb_bookSearch.Controls.Add(this.lbl_Title);
            this.gb_bookSearch.Controls.Add(this.lbl_Author);
            this.gb_bookSearch.Controls.Add(this.cbo_BookGenre);
            this.gb_bookSearch.Controls.Add(this.tbx_BookTitle);
            this.gb_bookSearch.Controls.Add(this.btn_BookAdd);
            this.gb_bookSearch.Controls.Add(this.tbx_BookAuthor);
            this.gb_bookSearch.Location = new System.Drawing.Point(8, 6);
            this.gb_bookSearch.Name = "gb_bookSearch";
            this.gb_bookSearch.Size = new System.Drawing.Size(538, 82);
            this.gb_bookSearch.TabIndex = 6;
            this.gb_bookSearch.TabStop = false;
            this.gb_bookSearch.Text = "Bücher-Mangement";
            // 
            // cbo_access
            // 
            this.cbo_access.FormattingEnabled = true;
            this.cbo_access.Location = new System.Drawing.Point(238, 52);
            this.cbo_access.Name = "cbo_access";
            this.cbo_access.Size = new System.Drawing.Size(121, 21);
            this.cbo_access.TabIndex = 17;
            // 
            // tbx_access
            // 
            this.tbx_access.AutoSize = true;
            this.tbx_access.Location = new System.Drawing.Point(194, 56);
            this.tbx_access.Name = "tbx_access";
            this.tbx_access.Size = new System.Drawing.Size(44, 13);
            this.tbx_access.TabIndex = 16;
            this.tbx_access.Text = "Zugang";
            // 
            // btn_BookSearch
            // 
            this.btn_BookSearch.Location = new System.Drawing.Point(457, 18);
            this.btn_BookSearch.Name = "btn_BookSearch";
            this.btn_BookSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_BookSearch.TabIndex = 14;
            this.btn_BookSearch.Text = "Suchen";
            this.btn_BookSearch.UseVisualStyleBackColor = true;
            // 
            // btn_DelBook
            // 
            this.btn_DelBook.Location = new System.Drawing.Point(376, 48);
            this.btn_DelBook.Name = "btn_DelBook";
            this.btn_DelBook.Size = new System.Drawing.Size(75, 23);
            this.btn_DelBook.TabIndex = 13;
            this.btn_DelBook.Text = "Entfernen";
            this.btn_DelBook.UseVisualStyleBackColor = true;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(193, 23);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(39, 13);
            this.lbl_Genre.TabIndex = 11;
            this.lbl_Genre.Text = "Genre:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(6, 53);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 10;
            this.lbl_Title.Text = "Titel:";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(6, 23);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(41, 13);
            this.lbl_Author.TabIndex = 9;
            this.lbl_Author.Text = "Author:";
            // 
            // cbo_BookGenre
            // 
            this.cbo_BookGenre.FormattingEnabled = true;
            this.cbo_BookGenre.Location = new System.Drawing.Point(238, 20);
            this.cbo_BookGenre.Name = "cbo_BookGenre";
            this.cbo_BookGenre.Size = new System.Drawing.Size(121, 21);
            this.cbo_BookGenre.TabIndex = 7;
            // 
            // tbx_BookTitle
            // 
            this.tbx_BookTitle.Location = new System.Drawing.Point(53, 50);
            this.tbx_BookTitle.Name = "tbx_BookTitle";
            this.tbx_BookTitle.Size = new System.Drawing.Size(134, 20);
            this.tbx_BookTitle.TabIndex = 6;
            // 
            // btn_BookAdd
            // 
            this.btn_BookAdd.Location = new System.Drawing.Point(376, 18);
            this.btn_BookAdd.Name = "btn_BookAdd";
            this.btn_BookAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_BookAdd.TabIndex = 5;
            this.btn_BookAdd.Text = "Hinzufügen";
            this.btn_BookAdd.UseVisualStyleBackColor = true;
            this.btn_BookAdd.Click += new System.EventHandler(this.btn_BookAdd_Click);
            // 
            // tbx_BookAuthor
            // 
            this.tbx_BookAuthor.Location = new System.Drawing.Point(53, 20);
            this.tbx_BookAuthor.Name = "tbx_BookAuthor";
            this.tbx_BookAuthor.Size = new System.Drawing.Size(134, 20);
            this.tbx_BookAuthor.TabIndex = 0;
            // 
            // tp_Samples
            // 
            this.tp_Samples.Controls.Add(this.dgv_Sample);
            this.tp_Samples.Controls.Add(this.groupBox1);
            this.tp_Samples.Location = new System.Drawing.Point(4, 22);
            this.tp_Samples.Name = "tp_Samples";
            this.tp_Samples.Size = new System.Drawing.Size(552, 356);
            this.tp_Samples.TabIndex = 2;
            this.tp_Samples.Text = "Exemplare";
            this.tp_Samples.UseVisualStyleBackColor = true;
            // 
            // dgv_Sample
            // 
            this.dgv_Sample.AllowUserToAddRows = false;
            this.dgv_Sample.AllowUserToDeleteRows = false;
            this.dgv_Sample.AllowUserToOrderColumns = true;
            this.dgv_Sample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_SampleID,
            this.column_SampleCustomer,
            this.column_SampleBeginOfLoan,
            this.column_SampleEndOfLoan,
            this.column_SampleState});
            this.dgv_Sample.Location = new System.Drawing.Point(5, 94);
            this.dgv_Sample.Name = "dgv_Sample";
            this.dgv_Sample.ReadOnly = true;
            this.dgv_Sample.Size = new System.Drawing.Size(543, 170);
            this.dgv_Sample.TabIndex = 9;
            // 
            // column_SampleID
            // 
            this.column_SampleID.DataPropertyName = "Id";
            this.column_SampleID.FillWeight = 40F;
            this.column_SampleID.HeaderText = "ID";
            this.column_SampleID.Name = "column_SampleID";
            this.column_SampleID.ReadOnly = true;
            this.column_SampleID.Width = 80;
            // 
            // column_SampleCustomer
            // 
            this.column_SampleCustomer.FillWeight = 120F;
            this.column_SampleCustomer.HeaderText = "Kunde";
            this.column_SampleCustomer.Name = "column_SampleCustomer";
            this.column_SampleCustomer.ReadOnly = true;
            this.column_SampleCustomer.Width = 120;
            // 
            // column_SampleBeginOfLoan
            // 
            this.column_SampleBeginOfLoan.FillWeight = 120F;
            this.column_SampleBeginOfLoan.HeaderText = "Verleihbeginn";
            this.column_SampleBeginOfLoan.Name = "column_SampleBeginOfLoan";
            this.column_SampleBeginOfLoan.ReadOnly = true;
            this.column_SampleBeginOfLoan.Width = 120;
            // 
            // column_SampleEndOfLoan
            // 
            this.column_SampleEndOfLoan.FillWeight = 120F;
            this.column_SampleEndOfLoan.HeaderText = "Verleihende";
            this.column_SampleEndOfLoan.Name = "column_SampleEndOfLoan";
            this.column_SampleEndOfLoan.ReadOnly = true;
            this.column_SampleEndOfLoan.Width = 120;
            // 
            // column_SampleState
            // 
            this.column_SampleState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_SampleState.DataPropertyName = "Status";
            this.column_SampleState.FillWeight = 60F;
            this.column_SampleState.HeaderText = "Status";
            this.column_SampleState.Name = "column_SampleState";
            this.column_SampleState.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_bookStatus);
            this.groupBox1.Controls.Add(this.cbo_BookList);
            this.groupBox1.Controls.Add(this.tb_SampleID);
            this.groupBox1.Controls.Add(this.btn_SampleSearch);
            this.groupBox1.Controls.Add(this.btn_AddSample);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.btn_DelSample);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplare-Mangement";
            // 
            // cbo_bookStatus
            // 
            this.cbo_bookStatus.FormattingEnabled = true;
            this.cbo_bookStatus.Location = new System.Drawing.Point(54, 47);
            this.cbo_bookStatus.Name = "cbo_bookStatus";
            this.cbo_bookStatus.Size = new System.Drawing.Size(121, 21);
            this.cbo_bookStatus.TabIndex = 22;
            // 
            // cbo_BookList
            // 
            this.cbo_BookList.FormattingEnabled = true;
            this.cbo_BookList.Location = new System.Drawing.Point(54, 20);
            this.cbo_BookList.Name = "cbo_BookList";
            this.cbo_BookList.Size = new System.Drawing.Size(306, 21);
            this.cbo_BookList.TabIndex = 21;
            this.cbo_BookList.SelectedIndexChanged += new System.EventHandler(this.cbo_BookList_ChangedSelectedIndex);
            // 
            // tb_SampleID
            // 
            this.tb_SampleID.Location = new System.Drawing.Point(260, 47);
            this.tb_SampleID.Name = "tb_SampleID";
            this.tb_SampleID.Size = new System.Drawing.Size(100, 20);
            this.tb_SampleID.TabIndex = 20;
            // 
            // btn_SampleSearch
            // 
            this.btn_SampleSearch.Location = new System.Drawing.Point(463, 18);
            this.btn_SampleSearch.Name = "btn_SampleSearch";
            this.btn_SampleSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_SampleSearch.TabIndex = 10;
            this.btn_SampleSearch.Text = "Suchen";
            this.btn_SampleSearch.UseVisualStyleBackColor = true;
            // 
            // btn_AddSample
            // 
            this.btn_AddSample.Location = new System.Drawing.Point(382, 18);
            this.btn_AddSample.Name = "btn_AddSample";
            this.btn_AddSample.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSample.TabIndex = 18;
            this.btn_AddSample.Text = "Hinzufügen";
            this.btn_AddSample.UseVisualStyleBackColor = true;
            this.btn_AddSample.Click += new System.EventHandler(this.btn_AddSample_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(233, 50);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "ID:";
            // 
            // btn_DelSample
            // 
            this.btn_DelSample.Location = new System.Drawing.Point(382, 47);
            this.btn_DelSample.Name = "btn_DelSample";
            this.btn_DelSample.Size = new System.Drawing.Size(75, 23);
            this.btn_DelSample.TabIndex = 13;
            this.btn_DelSample.Text = "Entfernen";
            this.btn_DelSample.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buch:";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(476, 18);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // lbl_personName
            // 
            this.lbl_personName.AutoSize = true;
            this.lbl_personName.Location = new System.Drawing.Point(16, 23);
            this.lbl_personName.Name = "lbl_personName";
            this.lbl_personName.Size = new System.Drawing.Size(68, 13);
            this.lbl_personName.TabIndex = 0;
            this.lbl_personName.Text = "Hallo $Name";
            // 
            // gb_header
            // 
            this.gb_header.Controls.Add(this.btn_logout);
            this.gb_header.Controls.Add(this.lbl_personName);
            this.gb_header.Location = new System.Drawing.Point(12, 12);
            this.gb_header.Name = "gb_header";
            this.gb_header.Size = new System.Drawing.Size(561, 54);
            this.gb_header.TabIndex = 6;
            this.gb_header.TabStop = false;
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 466);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gb_header);
            this.Name = "Form_Employee";
            this.Text = "Bibliothek-Mitarbeiterportal";
            this.tabControl1.ResumeLayout(false);
            this.tp_PersonManagement.ResumeLayout(false);
            this.dgv_persons.ResumeLayout(false);
            this.tab_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerList)).EndInit();
            this.tab_Staff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.gb_bookSearch.ResumeLayout(false);
            this.gb_bookSearch.PerformLayout();
            this.tp_Samples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sample)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_header.ResumeLayout(false);
            this.gb_header.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tp_books;
    private System.Windows.Forms.TabPage tp_PersonManagement;
    private System.Windows.Forms.Button btn_logout;
    private System.Windows.Forms.Label lbl_personName;
    private System.Windows.Forms.GroupBox gb_header;
    private System.Windows.Forms.DataGridView dgv_Book;
    private System.Windows.Forms.GroupBox gb_bookSearch;
    private System.Windows.Forms.Button btn_DelBook;
    private System.Windows.Forms.Label lbl_Genre;
    private System.Windows.Forms.Label lbl_Title;
    private System.Windows.Forms.Label lbl_Author;
    private System.Windows.Forms.ComboBox cbo_BookGenre;
    private System.Windows.Forms.TextBox tbx_BookTitle;
    private System.Windows.Forms.Button btn_BookAdd;
    private System.Windows.Forms.TextBox tbx_BookAuthor;
    private System.Windows.Forms.TabPage tp_Samples;
    private System.Windows.Forms.DataGridView dgv_Sample;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lbl_ID;
    private System.Windows.Forms.Button btn_DelSample;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btn_BookSearch;
    private System.Windows.Forms.Button btn_SampleSearch;
    private System.Windows.Forms.Button btn_AddSample;
    private System.Windows.Forms.TextBox tb_SampleID;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox idPerson;
    private System.Windows.Forms.Button searchPerson;
    private System.Windows.Forms.Button createPerson;
    private System.Windows.Forms.TextBox namePerson;
    private System.Windows.Forms.TextBox lastnamePerson;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button deletePersonButton;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox chkCustomer;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker bdayPerson;
    private System.Windows.Forms.TextBox pwPerson;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TabControl dgv_persons;
    private System.Windows.Forms.TabPage tab_Customer;
    private System.Windows.Forms.DataGridView dgv_customerList;
    private System.Windows.Forms.TabPage tab_Staff;
    private System.Windows.Forms.DataGridView dgv_employeeList;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_Lastname;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_Firstname;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_Birthday;
    private System.Windows.Forms.Button resetSearch;
    private System.Windows.Forms.Label tbx_access;
    private System.Windows.Forms.ComboBox cbo_access;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_BookTitle;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_BookAuthor;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_BookGenre;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_BookCount;
    private System.Windows.Forms.ComboBox cbo_bookStatus;
    private System.Windows.Forms.ComboBox cbo_BookList;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_SampleID;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_SampleCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_SampleBeginOfLoan;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_SampleEndOfLoan;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_SampleState;

  }
}