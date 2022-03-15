namespace COMPX323_APP
{
    partial class LoginPage
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
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPerfUsing = new System.Windows.Forms.GroupBox();
            this.radioButtonSQL = new System.Windows.Forms.RadioButton();
            this.radioButtonMongoDB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBoxPerfUsing.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(64, 194);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(237, 36);
            this.buttonClearAll.TabIndex = 15;
            this.buttonClearAll.Text = "Clear";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(64, 80);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(237, 36);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(129, 44);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(236, 22);
            this.textBoxPassword.TabIndex = 12;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(129, 15);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(236, 22);
            this.textBoxUserName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Location = new System.Drawing.Point(35, 23);
            this.radioButtonStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(58, 21);
            this.radioButtonStaff.TabIndex = 16;
            this.radioButtonStaff.TabStop = true;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Location = new System.Drawing.Point(105, 23);
            this.radioButtonCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(89, 21);
            this.radioButtonCustomer.TabIndex = 17;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Customer";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonStaff);
            this.groupBox1.Controls.Add(this.radioButtonCustomer);
            this.groupBox1.Location = new System.Drawing.Point(64, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(237, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LoginPage";
            // 
            // groupBoxPerfUsing
            // 
            this.groupBoxPerfUsing.Controls.Add(this.radioButtonSQL);
            this.groupBoxPerfUsing.Controls.Add(this.radioButtonMongoDB);
            this.groupBoxPerfUsing.Location = new System.Drawing.Point(64, 123);
            this.groupBoxPerfUsing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPerfUsing.Name = "groupBoxPerfUsing";
            this.groupBoxPerfUsing.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPerfUsing.Size = new System.Drawing.Size(237, 64);
            this.groupBoxPerfUsing.TabIndex = 19;
            this.groupBoxPerfUsing.TabStop = false;
            this.groupBoxPerfUsing.Text = "Perform Using";
            // 
            // radioButtonSQL
            // 
            this.radioButtonSQL.AutoSize = true;
            this.radioButtonSQL.Location = new System.Drawing.Point(35, 23);
            this.radioButtonSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSQL.Name = "radioButtonSQL";
            this.radioButtonSQL.Size = new System.Drawing.Size(57, 21);
            this.radioButtonSQL.TabIndex = 16;
            this.radioButtonSQL.TabStop = true;
            this.radioButtonSQL.Text = "SQL";
            this.radioButtonSQL.UseVisualStyleBackColor = true;
            // 
            // radioButtonMongoDB
            // 
            this.radioButtonMongoDB.AutoSize = true;
            this.radioButtonMongoDB.Location = new System.Drawing.Point(105, 23);
            this.radioButtonMongoDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMongoDB.Name = "radioButtonMongoDB";
            this.radioButtonMongoDB.Size = new System.Drawing.Size(91, 21);
            this.radioButtonMongoDB.TabIndex = 17;
            this.radioButtonMongoDB.TabStop = true;
            this.radioButtonMongoDB.Text = "MongoDB";
            this.radioButtonMongoDB.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 236);
            this.Controls.Add(this.groupBoxPerfUsing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPerfUsing.ResumeLayout(false);
            this.groupBoxPerfUsing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonStaff;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPerfUsing;
        private System.Windows.Forms.RadioButton radioButtonSQL;
        private System.Windows.Forms.RadioButton radioButtonMongoDB;
    }
}

