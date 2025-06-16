namespace telephone_number
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
            label1 = new Label();
            txtTelephoneNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtShop = new TextBox();
            txtSubdivision = new TextBox();
            label4 = new Label();
            txtWhoOwns = new TextBox();
            txtBoxNumber = new TextBox();
            txtPairNumber = new TextBox();
            label5 = new Label();
            label6 = new Label();
            telephoneList = new ListBox();
            butAdd = new Button();
            butnRemove = new Button();
            label7 = new Label();
            txtSearch = new TextBox();
            butnSearch = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 49);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер телефона - ";
            // 
            // txtTelephoneNumber
            // 
            txtTelephoneNumber.Location = new Point(149, 41);
            txtTelephoneNumber.Name = "txtTelephoneNumber";
            txtTelephoneNumber.Size = new Size(253, 23);
            txtTelephoneNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 94);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Цех -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 131);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 3;
            label3.Text = "Подразделение -";
            // 
            // txtShop
            // 
            txtShop.Location = new Point(149, 86);
            txtShop.Name = "txtShop";
            txtShop.Size = new Size(253, 23);
            txtShop.TabIndex = 4;
            // 
            // txtSubdivision
            // 
            txtSubdivision.Location = new Point(149, 123);
            txtSubdivision.Name = "txtSubdivision";
            txtSubdivision.Size = new Size(253, 23);
            txtSubdivision.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 174);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 6;
            label4.Text = "Кому принадлежит - ";
            // 
            // txtWhoOwns
            // 
            txtWhoOwns.Location = new Point(149, 171);
            txtWhoOwns.Multiline = true;
            txtWhoOwns.Name = "txtWhoOwns";
            txtWhoOwns.Size = new Size(253, 29);
            txtWhoOwns.TabIndex = 7;
            // 
            // txtBoxNumber
            // 
            txtBoxNumber.Location = new Point(149, 228);
            txtBoxNumber.Name = "txtBoxNumber";
            txtBoxNumber.Size = new Size(253, 23);
            txtBoxNumber.TabIndex = 8;
            // 
            // txtPairNumber
            // 
            txtPairNumber.Location = new Point(149, 283);
            txtPairNumber.Name = "txtPairNumber";
            txtPairNumber.Size = new Size(253, 23);
            txtPairNumber.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 231);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "Номер бокса - ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 286);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "Номер пары -";
            // 
            // telephoneList
            // 
            telephoneList.FormattingEnabled = true;
            telephoneList.Location = new Point(497, 32);
            telephoneList.Name = "telephoneList";
            telephoneList.Size = new Size(434, 274);
            telephoneList.TabIndex = 12;
            // 
            // butAdd
            // 
            butAdd.Location = new Point(19, 403);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(146, 23);
            butAdd.TabIndex = 13;
            butAdd.Text = "Добавить номер";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += ButAdd_Click;
            // 
            // butnRemove
            // 
            butnRemove.Location = new Point(197, 403);
            butnRemove.Name = "butnRemove";
            butnRemove.Size = new Size(162, 23);
            butnRemove.TabIndex = 14;
            butnRemove.Text = "Удалить номер";
            butnRemove.UseVisualStyleBackColor = true;
            butnRemove.Click += ButnRemove_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 335);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 15;
            label7.Text = "Поиск - ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(149, 332);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 23);
            txtSearch.TabIndex = 16;
            // 
            // butnSearch
            // 
            butnSearch.Location = new Point(396, 403);
            butnSearch.Name = "butnSearch";
            butnSearch.Size = new Size(136, 23);
            butnSearch.TabIndex = 17;
            butnSearch.Text = "Поиск";
            butnSearch.UseVisualStyleBackColor = true;
            butnSearch.Click += ButnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(554, 403);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(675, 403);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(butnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(butnRemove);
            Controls.Add(butAdd);
            Controls.Add(telephoneList);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPairNumber);
            Controls.Add(txtBoxNumber);
            Controls.Add(txtWhoOwns);
            Controls.Add(label4);
            Controls.Add(txtSubdivision);
            Controls.Add(txtShop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelephoneNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Telephone_numbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelephoneNumber;
        private Label label2;
        private Label label3;
        private TextBox txtShop;
        private TextBox txtSubdivision;
        private Label label4;
        private TextBox txtWhoOwns;
        private TextBox txtBoxNumber;
        private TextBox txtPairNumber;
        private Label label5;
        private Label label6;
        private ListBox telephoneList;
        private Button butAdd;
        private Button butnRemove;
        private Label label7;
        private TextBox txtSearch;
        private Button butnSearch;
        private Button btnSave;
        private Button btnLoad;
    }
}
