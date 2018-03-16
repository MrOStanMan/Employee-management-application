namespace COMP2614Assign06
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.labelFirstAddress = new System.Windows.Forms.Label();
            this.labelSecondAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxFirstAddress = new System.Windows.Forms.TextBox();
            this.textBoxSecondAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.labelCompanyCode = new System.Windows.Forms.Label();
            this.textBoxCompanyCode = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(12, 7);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(173, 212);
            this.listBoxCustomers.TabIndex = 0;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // labelFirstAddress
            // 
            this.labelFirstAddress.AutoSize = true;
            this.labelFirstAddress.Location = new System.Drawing.Point(208, 73);
            this.labelFirstAddress.Name = "labelFirstAddress";
            this.labelFirstAddress.Size = new System.Drawing.Size(70, 13);
            this.labelFirstAddress.TabIndex = 4;
            this.labelFirstAddress.Text = "&First Address:";
            // 
            // labelSecondAddress
            // 
            this.labelSecondAddress.AutoSize = true;
            this.labelSecondAddress.Location = new System.Drawing.Point(208, 99);
            this.labelSecondAddress.Name = "labelSecondAddress";
            this.labelSecondAddress.Size = new System.Drawing.Size(88, 13);
            this.labelSecondAddress.TabIndex = 6;
            this.labelSecondAddress.Text = "&Second Address:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(208, 125);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "C&ity:";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(208, 151);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "&Province:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(208, 177);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(64, 13);
            this.labelPostalCode.TabIndex = 12;
            this.labelPostalCode.Text = "P&ostalCode:";
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(208, 203);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(58, 13);
            this.labelYTDSales.TabIndex = 14;
            this.labelYTDSales.Text = "&YTDSales:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(609, 211);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(75, 17);
            this.checkBoxCreditHold.TabIndex = 17;
            this.checkBoxCreditHold.Text = "C&reditHold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(438, 36);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(155, 152);
            this.richTextBoxNotes.TabIndex = 16;
            this.richTextBoxNotes.Text = "";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(435, 15);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 6;
            this.labelNotes.Text = "&Notes:";
            // 
            // textBoxFirstAddress
            // 
            this.textBoxFirstAddress.Location = new System.Drawing.Point(311, 70);
            this.textBoxFirstAddress.Name = "textBoxFirstAddress";
            this.textBoxFirstAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstAddress.TabIndex = 5;
            // 
            // textBoxSecondAddress
            // 
            this.textBoxSecondAddress.Location = new System.Drawing.Point(311, 96);
            this.textBoxSecondAddress.Name = "textBoxSecondAddress";
            this.textBoxSecondAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondAddress.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(311, 122);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(311, 148);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvince.TabIndex = 11;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(311, 174);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 13;
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(311, 200);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxYTDSales.TabIndex = 15;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(609, 153);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(208, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "&Company Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(311, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.Location = new System.Drawing.Point(609, 36);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonNewCustomer.TabIndex = 18;
            this.buttonNewCustomer.Text = "N&ew";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            this.buttonNewCustomer.Click += new System.EventHandler(this.buttonNewCustomer_Click);
            // 
            // labelCompanyCode
            // 
            this.labelCompanyCode.AutoSize = true;
            this.labelCompanyCode.Location = new System.Drawing.Point(208, 21);
            this.labelCompanyCode.Name = "labelCompanyCode";
            this.labelCompanyCode.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyCode.TabIndex = 0;
            this.labelCompanyCode.Text = "Company Co&de:";
            // 
            // textBoxCompanyCode
            // 
            this.textBoxCompanyCode.Location = new System.Drawing.Point(311, 18);
            this.textBoxCompanyCode.Name = "textBoxCompanyCode";
            this.textBoxCompanyCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyCode.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(609, 94);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "De&lete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(718, 260);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxCompanyCode);
            this.Controls.Add(this.labelCompanyCode);
            this.Controls.Add(this.buttonNewCustomer);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxSecondAddress);
            this.Controls.Add(this.textBoxFirstAddress);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.labelYTDSales);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelSecondAddress);
            this.Controls.Add(this.labelFirstAddress);
            this.Controls.Add(this.listBoxCustomers);
            this.Name = "MainForm";
            this.Text = "Assignment 6";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomers;
        
        private System.Windows.Forms.Label labelFirstAddress;
        private System.Windows.Forms.Label labelSecondAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxFirstAddress;
        private System.Windows.Forms.TextBox textBoxSecondAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.Label labelCompanyCode;
        private System.Windows.Forms.TextBox textBoxCompanyCode;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

