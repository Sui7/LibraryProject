namespace LibraryForm
{
  partial class Form_Customer
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
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_personName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_books = new System.Windows.Forms.TabPage();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.column_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_availible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_bookSearch = new System.Windows.Forms.GroupBox();
            this.rb_bookTitle = new System.Windows.Forms.RadioButton();
            this.rb_bookAuthor = new System.Windows.Forms.RadioButton();
            this.btn_bookSearch = new System.Windows.Forms.Button();
            this.btn_clearBookSearch = new System.Windows.Forms.Button();
            this.tb_bookSearch = new System.Windows.Forms.TextBox();
            this.tp_personalInfo = new System.Windows.Forms.TabPage();
            this.gb_chargeAccount = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_payIn = new System.Windows.Forms.Label();
            this.tb_payIn = new System.Windows.Forms.TextBox();
            this.btn_payIn = new System.Windows.Forms.Button();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.tb_charges = new System.Windows.Forms.TextBox();
            this.lbl_currentCharge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_preorderAccount = new System.Windows.Forms.ListBox();
            this.lb_loanAccount = new System.Windows.Forms.ListBox();
            this.gb_customerData = new System.Windows.Forms.GroupBox();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_lastnameTag = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_birthdayTag = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_firstnameTag = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_idTag = new System.Windows.Forms.Label();
            this.tp_messages = new System.Windows.Forms.TabPage();
            this.dgv_messages = new System.Windows.Forms.DataGridView();
            this.Column_message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_header.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.gb_bookSearch.SuspendLayout();
            this.tp_personalInfo.SuspendLayout();
            this.gb_chargeAccount.SuspendLayout();
            this.gb_customerData.SuspendLayout();
            this.tp_messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_messages)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_header
            // 
            this.gb_header.Controls.Add(this.btn_logout);
            this.gb_header.Controls.Add(this.lbl_personName);
            this.gb_header.Location = new System.Drawing.Point(12, 12);
            this.gb_header.Name = "gb_header";
            this.gb_header.Size = new System.Drawing.Size(561, 54);
            this.gb_header.TabIndex = 2;
            this.gb_header.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(476, 18);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_books);
            this.tabControl1.Controls.Add(this.tp_personalInfo);
            this.tabControl1.Controls.Add(this.tp_messages);
            this.tabControl1.Location = new System.Drawing.Point(13, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 297);
            this.tabControl1.TabIndex = 3;
            // 
            // tp_books
            // 
            this.tp_books.Controls.Add(this.dgv_books);
            this.tp_books.Controls.Add(this.gb_bookSearch);
            this.tp_books.Location = new System.Drawing.Point(4, 22);
            this.tp_books.Name = "tp_books";
            this.tp_books.Padding = new System.Windows.Forms.Padding(3);
            this.tp_books.Size = new System.Drawing.Size(552, 271);
            this.tp_books.TabIndex = 1;
            this.tp_books.Text = "Bücher";
            this.tp_books.UseVisualStyleBackColor = true;
            // 
            // dgv_books
            // 
            this.dgv_books.AllowUserToAddRows = false;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_author,
            this.column_title,
            this.column_genre,
            this.column_count,
            this.column_availible});
            this.dgv_books.Location = new System.Drawing.Point(3, 82);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.Size = new System.Drawing.Size(543, 183);
            this.dgv_books.TabIndex = 5;
            // 
            // column_author
            // 
            this.column_author.FillWeight = 120F;
            this.column_author.HeaderText = "Author";
            this.column_author.Name = "column_author";
            this.column_author.Width = 120;
            // 
            // column_title
            // 
            this.column_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_title.FillWeight = 170F;
            this.column_title.HeaderText = "Titel";
            this.column_title.Name = "column_title";
            // 
            // column_genre
            // 
            this.column_genre.FillWeight = 80F;
            this.column_genre.HeaderText = "Genre";
            this.column_genre.Name = "column_genre";
            this.column_genre.Width = 80;
            // 
            // column_count
            // 
            this.column_count.FillWeight = 60F;
            this.column_count.HeaderText = "Anzahl";
            this.column_count.Name = "column_count";
            this.column_count.Width = 60;
            // 
            // column_availible
            // 
            this.column_availible.FillWeight = 60F;
            this.column_availible.HeaderText = "verfügbar";
            this.column_availible.Name = "column_availible";
            this.column_availible.Width = 60;
            // 
            // gb_bookSearch
            // 
            this.gb_bookSearch.Controls.Add(this.rb_bookTitle);
            this.gb_bookSearch.Controls.Add(this.rb_bookAuthor);
            this.gb_bookSearch.Controls.Add(this.btn_bookSearch);
            this.gb_bookSearch.Controls.Add(this.btn_clearBookSearch);
            this.gb_bookSearch.Controls.Add(this.tb_bookSearch);
            this.gb_bookSearch.Location = new System.Drawing.Point(6, 7);
            this.gb_bookSearch.Name = "gb_bookSearch";
            this.gb_bookSearch.Size = new System.Drawing.Size(376, 69);
            this.gb_bookSearch.TabIndex = 4;
            this.gb_bookSearch.TabStop = false;
            this.gb_bookSearch.Text = "Bücher-Suche";
            // 
            // rb_bookTitle
            // 
            this.rb_bookTitle.AutoSize = true;
            this.rb_bookTitle.Location = new System.Drawing.Point(8, 45);
            this.rb_bookTitle.Name = "rb_bookTitle";
            this.rb_bookTitle.Size = new System.Drawing.Size(45, 17);
            this.rb_bookTitle.TabIndex = 7;
            this.rb_bookTitle.TabStop = true;
            this.rb_bookTitle.Text = "Titel";
            this.rb_bookTitle.UseVisualStyleBackColor = true;
            // 
            // rb_bookAuthor
            // 
            this.rb_bookAuthor.AutoSize = true;
            this.rb_bookAuthor.Location = new System.Drawing.Point(59, 45);
            this.rb_bookAuthor.Name = "rb_bookAuthor";
            this.rb_bookAuthor.Size = new System.Drawing.Size(56, 17);
            this.rb_bookAuthor.TabIndex = 6;
            this.rb_bookAuthor.TabStop = true;
            this.rb_bookAuthor.Text = "Author";
            this.rb_bookAuthor.UseVisualStyleBackColor = true;
            // 
            // btn_bookSearch
            // 
            this.btn_bookSearch.Enabled = false;
            this.btn_bookSearch.Location = new System.Drawing.Point(202, 17);
            this.btn_bookSearch.Name = "btn_bookSearch";
            this.btn_bookSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_bookSearch.TabIndex = 5;
            this.btn_bookSearch.Text = "Suche";
            this.btn_bookSearch.UseVisualStyleBackColor = true;
            this.btn_bookSearch.Click += new System.EventHandler(this.btn_bookSearch_Click);
            // 
            // btn_clearBookSearch
            // 
            this.btn_clearBookSearch.Location = new System.Drawing.Point(293, 17);
            this.btn_clearBookSearch.Name = "btn_clearBookSearch";
            this.btn_clearBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_clearBookSearch.TabIndex = 4;
            this.btn_clearBookSearch.Text = "Säubern";
            this.btn_clearBookSearch.UseVisualStyleBackColor = true;
            this.btn_clearBookSearch.Click += new System.EventHandler(this.btn_clearBookSearch_Click);
            // 
            // tb_bookSearch
            // 
            this.tb_bookSearch.Location = new System.Drawing.Point(8, 19);
            this.tb_bookSearch.Name = "tb_bookSearch";
            this.tb_bookSearch.Size = new System.Drawing.Size(176, 20);
            this.tb_bookSearch.TabIndex = 0;
            // 
            // tp_personalInfo
            // 
            this.tp_personalInfo.Controls.Add(this.gb_chargeAccount);
            this.tp_personalInfo.Controls.Add(this.label2);
            this.tp_personalInfo.Controls.Add(this.label1);
            this.tp_personalInfo.Controls.Add(this.lb_preorderAccount);
            this.tp_personalInfo.Controls.Add(this.lb_loanAccount);
            this.tp_personalInfo.Controls.Add(this.gb_customerData);
            this.tp_personalInfo.Location = new System.Drawing.Point(4, 22);
            this.tp_personalInfo.Name = "tp_personalInfo";
            this.tp_personalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_personalInfo.Size = new System.Drawing.Size(552, 271);
            this.tp_personalInfo.TabIndex = 0;
            this.tp_personalInfo.Text = "Persönliche Informationen";
            this.tp_personalInfo.UseVisualStyleBackColor = true;
            // 
            // gb_chargeAccount
            // 
            this.gb_chargeAccount.Controls.Add(this.label3);
            this.gb_chargeAccount.Controls.Add(this.lbl_payIn);
            this.gb_chargeAccount.Controls.Add(this.tb_payIn);
            this.gb_chargeAccount.Controls.Add(this.btn_payIn);
            this.gb_chargeAccount.Controls.Add(this.lbl_euro);
            this.gb_chargeAccount.Controls.Add(this.tb_charges);
            this.gb_chargeAccount.Controls.Add(this.lbl_currentCharge);
            this.gb_chargeAccount.Location = new System.Drawing.Point(283, 6);
            this.gb_chargeAccount.Name = "gb_chargeAccount";
            this.gb_chargeAccount.Size = new System.Drawing.Size(263, 119);
            this.gb_chargeAccount.TabIndex = 13;
            this.gb_chargeAccount.TabStop = false;
            this.gb_chargeAccount.Text = "Gebührenkonto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "€";
            // 
            // lbl_payIn
            // 
            this.lbl_payIn.AutoSize = true;
            this.lbl_payIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payIn.Location = new System.Drawing.Point(6, 62);
            this.lbl_payIn.Name = "lbl_payIn";
            this.lbl_payIn.Size = new System.Drawing.Size(73, 13);
            this.lbl_payIn.TabIndex = 12;
            this.lbl_payIn.Text = "Einzahlung:";
            // 
            // tb_payIn
            // 
            this.tb_payIn.Location = new System.Drawing.Point(132, 59);
            this.tb_payIn.Name = "tb_payIn";
            this.tb_payIn.Size = new System.Drawing.Size(100, 20);
            this.tb_payIn.TabIndex = 11;
            // 
            // btn_payIn
            // 
            this.btn_payIn.Enabled = false;
            this.btn_payIn.Location = new System.Drawing.Point(146, 86);
            this.btn_payIn.Name = "btn_payIn";
            this.btn_payIn.Size = new System.Drawing.Size(75, 23);
            this.btn_payIn.TabIndex = 10;
            this.btn_payIn.Text = "Einzahlen";
            this.btn_payIn.UseVisualStyleBackColor = true;
            this.btn_payIn.Click += new System.EventHandler(this.btn_payIn_Click);
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(236, 16);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(13, 13);
            this.lbl_euro.TabIndex = 8;
            this.lbl_euro.Text = "€";
            // 
            // tb_charges
            // 
            this.tb_charges.Enabled = false;
            this.tb_charges.Location = new System.Drawing.Point(132, 13);
            this.tb_charges.Name = "tb_charges";
            this.tb_charges.Size = new System.Drawing.Size(100, 20);
            this.tb_charges.TabIndex = 9;
            this.tb_charges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_currentCharge
            // 
            this.lbl_currentCharge.AutoSize = true;
            this.lbl_currentCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentCharge.Location = new System.Drawing.Point(6, 16);
            this.lbl_currentCharge.Name = "lbl_currentCharge";
            this.lbl_currentCharge.Size = new System.Drawing.Size(107, 13);
            this.lbl_currentCharge.TabIndex = 8;
            this.lbl_currentCharge.Text = "Fällige Gebühren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vorbestellkonto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ausleihkonto";
            // 
            // lb_preorderAccount
            // 
            this.lb_preorderAccount.FormattingEnabled = true;
            this.lb_preorderAccount.Location = new System.Drawing.Point(283, 158);
            this.lb_preorderAccount.Name = "lb_preorderAccount";
            this.lb_preorderAccount.Size = new System.Drawing.Size(263, 95);
            this.lb_preorderAccount.TabIndex = 10;
            // 
            // lb_loanAccount
            // 
            this.lb_loanAccount.FormattingEnabled = true;
            this.lb_loanAccount.Location = new System.Drawing.Point(7, 158);
            this.lb_loanAccount.Name = "lb_loanAccount";
            this.lb_loanAccount.Size = new System.Drawing.Size(263, 95);
            this.lb_loanAccount.TabIndex = 9;
            // 
            // gb_customerData
            // 
            this.gb_customerData.Controls.Add(this.lbl_number);
            this.gb_customerData.Controls.Add(this.lbl_lastnameTag);
            this.gb_customerData.Controls.Add(this.lbl_lastname);
            this.gb_customerData.Controls.Add(this.lbl_birthdayTag);
            this.gb_customerData.Controls.Add(this.lbl_firstname);
            this.gb_customerData.Controls.Add(this.lbl_firstnameTag);
            this.gb_customerData.Controls.Add(this.lbl_birthday);
            this.gb_customerData.Controls.Add(this.lbl_idTag);
            this.gb_customerData.Location = new System.Drawing.Point(6, 6);
            this.gb_customerData.Name = "gb_customerData";
            this.gb_customerData.Size = new System.Drawing.Size(264, 119);
            this.gb_customerData.TabIndex = 8;
            this.gb_customerData.TabStop = false;
            this.gb_customerData.Text = "Daten";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(6, 16);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(97, 13);
            this.lbl_number.TabIndex = 2;
            this.lbl_number.Text = "Kundennummer:";
            // 
            // lbl_lastnameTag
            // 
            this.lbl_lastnameTag.AutoSize = true;
            this.lbl_lastnameTag.Location = new System.Drawing.Point(120, 41);
            this.lbl_lastnameTag.Name = "lbl_lastnameTag";
            this.lbl_lastnameTag.Size = new System.Drawing.Size(55, 13);
            this.lbl_lastnameTag.TabIndex = 7;
            this.lbl_lastnameTag.Text = "$lastname";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(6, 41);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(71, 13);
            this.lbl_lastname.TabIndex = 0;
            this.lbl_lastname.Text = "Nachname:";
            // 
            // lbl_birthdayTag
            // 
            this.lbl_birthdayTag.AutoSize = true;
            this.lbl_birthdayTag.Location = new System.Drawing.Point(120, 91);
            this.lbl_birthdayTag.Name = "lbl_birthdayTag";
            this.lbl_birthdayTag.Size = new System.Drawing.Size(50, 13);
            this.lbl_birthdayTag.TabIndex = 6;
            this.lbl_birthdayTag.Text = "$birthday";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(6, 66);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(60, 13);
            this.lbl_firstname.TabIndex = 1;
            this.lbl_firstname.Text = "Vorname:";
            // 
            // lbl_firstnameTag
            // 
            this.lbl_firstnameTag.AutoSize = true;
            this.lbl_firstnameTag.Location = new System.Drawing.Point(120, 66);
            this.lbl_firstnameTag.Name = "lbl_firstnameTag";
            this.lbl_firstnameTag.Size = new System.Drawing.Size(55, 13);
            this.lbl_firstnameTag.TabIndex = 5;
            this.lbl_firstnameTag.Text = "$firstname";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday.Location = new System.Drawing.Point(6, 91);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(73, 13);
            this.lbl_birthday.TabIndex = 3;
            this.lbl_birthday.Text = "Geburtstag:";
            // 
            // lbl_idTag
            // 
            this.lbl_idTag.AutoSize = true;
            this.lbl_idTag.Location = new System.Drawing.Point(120, 16);
            this.lbl_idTag.Name = "lbl_idTag";
            this.lbl_idTag.Size = new System.Drawing.Size(21, 13);
            this.lbl_idTag.TabIndex = 4;
            this.lbl_idTag.Text = "$id";
            // 
            // tp_messages
            // 
            this.tp_messages.Controls.Add(this.dgv_messages);
            this.tp_messages.Location = new System.Drawing.Point(4, 22);
            this.tp_messages.Name = "tp_messages";
            this.tp_messages.Size = new System.Drawing.Size(552, 271);
            this.tp_messages.TabIndex = 2;
            this.tp_messages.Text = "Nachrichten";
            this.tp_messages.UseVisualStyleBackColor = true;
            // 
            // dgv_messages
            // 
            this.dgv_messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_messages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_message,
            this.Column_date});
            this.dgv_messages.Location = new System.Drawing.Point(14, 13);
            this.dgv_messages.Name = "dgv_messages";
            this.dgv_messages.Size = new System.Drawing.Size(521, 239);
            this.dgv_messages.TabIndex = 0;
            // 
            // Column_message
            // 
            this.Column_message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_message.HeaderText = "Nachricht";
            this.Column_message.Name = "Column_message";
            // 
            // Column_date
            // 
            this.Column_date.FillWeight = 120F;
            this.Column_date.HeaderText = "Datum";
            this.Column_date.Name = "Column_date";
            this.Column_date.Width = 120;
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gb_header);
            this.Name = "Form_Customer";
            this.Text = "Bibliothek - Kundenzentrum";
            this.gb_header.ResumeLayout(false);
            this.gb_header.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.gb_bookSearch.ResumeLayout(false);
            this.gb_bookSearch.PerformLayout();
            this.tp_personalInfo.ResumeLayout(false);
            this.tp_personalInfo.PerformLayout();
            this.gb_chargeAccount.ResumeLayout(false);
            this.gb_chargeAccount.PerformLayout();
            this.gb_customerData.ResumeLayout(false);
            this.gb_customerData.PerformLayout();
            this.tp_messages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_messages)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gb_header;
    private System.Windows.Forms.Button btn_logout;
    private System.Windows.Forms.Label lbl_personName;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tp_books;
    private System.Windows.Forms.TabPage tp_personalInfo;
    private System.Windows.Forms.DataGridView dgv_books;
    private System.Windows.Forms.GroupBox gb_bookSearch;
    private System.Windows.Forms.Button btn_bookSearch;
    private System.Windows.Forms.Button btn_clearBookSearch;
    private System.Windows.Forms.TextBox tb_bookSearch;
    private System.Windows.Forms.TabPage tp_messages;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_author;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_title;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_genre;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_count;
    private System.Windows.Forms.DataGridViewTextBoxColumn column_availible;
    private System.Windows.Forms.Label lbl_birthday;
    private System.Windows.Forms.Label lbl_number;
    private System.Windows.Forms.Label lbl_firstname;
    private System.Windows.Forms.Label lbl_lastname;
    private System.Windows.Forms.DataGridView dgv_messages;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_message;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
    private System.Windows.Forms.GroupBox gb_chargeAccount;
    private System.Windows.Forms.Label lbl_payIn;
    private System.Windows.Forms.TextBox tb_payIn;
    private System.Windows.Forms.Button btn_payIn;
    private System.Windows.Forms.Label lbl_euro;
    private System.Windows.Forms.TextBox tb_charges;
    private System.Windows.Forms.Label lbl_currentCharge;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lb_preorderAccount;
    private System.Windows.Forms.ListBox lb_loanAccount;
    private System.Windows.Forms.GroupBox gb_customerData;
    private System.Windows.Forms.Label lbl_lastnameTag;
    private System.Windows.Forms.Label lbl_birthdayTag;
    private System.Windows.Forms.Label lbl_firstnameTag;
    private System.Windows.Forms.Label lbl_idTag;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton rb_bookTitle;
    private System.Windows.Forms.RadioButton rb_bookAuthor;

  }
}