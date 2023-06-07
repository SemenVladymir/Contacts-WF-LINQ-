namespace Contacts_WF_LINQ_
{
    partial class Form2
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lBirthdate = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 33);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(144, 124);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(133, 33);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 75);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 22);
            this.txtPhone.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(425, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 42);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 22);
            this.txtAddress.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 17;
            // 
            // lBirthdate
            // 
            this.lBirthdate.AutoSize = true;
            this.lBirthdate.Location = new System.Drawing.Point(321, 48);
            this.lBirthdate.Name = "lBirthdate";
            this.lBirthdate.Size = new System.Drawing.Size(60, 16);
            this.lBirthdate.TabIndex = 16;
            this.lBirthdate.Text = "Birthdate";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(321, 18);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(41, 16);
            this.lEmail.TabIndex = 15;
            this.lEmail.Text = "Email";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(16, 75);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(46, 16);
            this.lPhone.TabIndex = 14;
            this.lPhone.Text = "Phone";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(16, 42);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(58, 16);
            this.lAddress.TabIndex = 13;
            this.lAddress.Text = "Address";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(16, 12);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(65, 16);
            this.lName.TabIndex = 12;
            this.lName.Text = "Full name";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(425, 48);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(186, 22);
            this.Date.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 180);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lBirthdate);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.lName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lBirthdate;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.DateTimePicker Date;
    }
}