namespace Anket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.man = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.woman = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(156, 362);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(49, 19);
            this.man.TabIndex = 8;
            this.man.Text = "Man";
            this.man.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Father name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "City*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(156, 323);
            this.birthday.MaxDate = new System.DateTime(2022, 5, 26, 13, 3, 10, 0);
            this.birthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 23);
            this.birthday.TabIndex = 6;
            this.birthday.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birthday";
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(256, 362);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(67, 19);
            this.woman.TabIndex = 9;
            this.woman.Text = "Woman";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Gender";
            // 
            // surname
            // 
            this.surname.AcceptsTab = true;
            this.surname.HideSelection = false;
            this.surname.Location = new System.Drawing.Point(156, 59);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(200, 23);
            this.surname.TabIndex = 11;
            this.surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.AcceptsTab = true;
            this.name.HideSelection = false;
            this.name.Location = new System.Drawing.Point(156, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 23);
            this.name.TabIndex = 12;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fname
            // 
            this.fname.AcceptsTab = true;
            this.fname.HideSelection = false;
            this.fname.Location = new System.Drawing.Point(156, 117);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(200, 23);
            this.fname.TabIndex = 13;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // country
            // 
            this.country.AcceptsTab = true;
            this.country.HideSelection = false;
            this.country.Location = new System.Drawing.Point(156, 182);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(200, 23);
            this.country.TabIndex = 14;
            this.country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // city
            // 
            this.city.AcceptsTab = true;
            this.city.HideSelection = false;
            this.city.Location = new System.Drawing.Point(156, 211);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(200, 23);
            this.city.TabIndex = 15;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // number
            // 
            this.number.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.number.Location = new System.Drawing.Point(156, 242);
            this.number.Mask = "(999) 000-0000";
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(200, 23);
            this.number.TabIndex = 16;
            this.number.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(123, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(233, 23);
            this.search.TabIndex = 19;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker birthday;
        private Label label7;
        private RadioButton man;
        private RadioButton woman;
        private Label label8;
        private TextBox surname;
        private TextBox name;
        private TextBox fname;
        private TextBox country;
        private TextBox city;
        private MaskedTextBox number;
        private Button button1;
        private TextBox search;
        private Label label9;
    }
}