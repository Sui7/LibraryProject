namespace LibraryForm
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_loginName = new System.Windows.Forms.TextBox();
            this.gb_header = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_login.SuspendLayout();
            this.gb_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.btn_close);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.btn_login);
            this.gb_login.Controls.Add(this.label1);
            this.gb_login.Controls.Add(this.lb_password);
            this.gb_login.Controls.Add(this.tb_loginName);
            this.gb_login.Location = new System.Drawing.Point(153, 144);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(288, 98);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Anmeldung";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(191, 57);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(65, 59);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(191, 22);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(6, 62);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Passwort:";
            // 
            // tb_loginName
            // 
            this.tb_loginName.Location = new System.Drawing.Point(65, 24);
            this.tb_loginName.Name = "tb_loginName";
            this.tb_loginName.Size = new System.Drawing.Size(100, 20);
            this.tb_loginName.TabIndex = 1;
            // 
            // gb_header
            // 
            this.gb_header.Controls.Add(this.label2);
            this.gb_header.Location = new System.Drawing.Point(12, 12);
            this.gb_header.Name = "gb_header";
            this.gb_header.Size = new System.Drawing.Size(564, 54);
            this.gb_header.TabIndex = 1;
            this.gb_header.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Willkommen in Ihrer Wellensteyn Blibliothek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.gb_header);
            this.Controls.Add(this.gb_login);
            this.Name = "Form1";
            this.Text = "Bibliothek";
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.gb_header.ResumeLayout(false);
            this.gb_header.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gb_login;
    private System.Windows.Forms.TextBox tb_password;
    private System.Windows.Forms.Button btn_login;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lb_password;
    private System.Windows.Forms.TextBox tb_loginName;
    private System.Windows.Forms.Button btn_close;
    private System.Windows.Forms.GroupBox gb_header;
    private System.Windows.Forms.Label label2;
  }
}

