namespace COMPX323_APP
{
    partial class StaffActions
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonAddViewUser = new System.Windows.Forms.Button();
            this.buttonAddViewRepairs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOldestServed = new System.Windows.Forms.Button();
            this.buttonNewestServed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserNameResult = new System.Windows.Forms.TextBox();
            this.buttonLargestRepairServed = new System.Windows.Forms.Button();
            this.buttonAddViewDevices = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUserNoYet = new System.Windows.Forms.Button();
            this.buttonUserSingularModel = new System.Windows.Forms.Button();
            this.buttonBrandSelect = new System.Windows.Forms.Button();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.buttonBeforeID = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAfterID = new System.Windows.Forms.Button();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.buttonMostServed = new System.Windows.Forms.Button();
            this.buttonUserHasPrev = new System.Windows.Forms.Button();
            this.buttonUserMultipleModels = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShowRepairsMongoDB = new System.Windows.Forms.Button();
            this.buttonUsersAssignedMongoDB = new System.Windows.Forms.Button();
            this.buttonMostServedMongo = new System.Windows.Forms.Button();
            this.buttonAddUserMongo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(7, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(411, 25);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Hello <Name> What would you like to do?";
            this.labelLogin.UseMnemonic = false;
            // 
            // buttonAddViewUser
            // 
            this.buttonAddViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddViewUser.Location = new System.Drawing.Point(203, 195);
            this.buttonAddViewUser.Name = "buttonAddViewUser";
            this.buttonAddViewUser.Size = new System.Drawing.Size(93, 36);
            this.buttonAddViewUser.TabIndex = 2;
            this.buttonAddViewUser.Text = "Users";
            this.buttonAddViewUser.UseVisualStyleBackColor = true;
            this.buttonAddViewUser.Click += new System.EventHandler(this.buttonAddViewUser_Click);
            // 
            // buttonAddViewRepairs
            // 
            this.buttonAddViewRepairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddViewRepairs.Location = new System.Drawing.Point(302, 195);
            this.buttonAddViewRepairs.Name = "buttonAddViewRepairs";
            this.buttonAddViewRepairs.Size = new System.Drawing.Size(93, 36);
            this.buttonAddViewRepairs.TabIndex = 3;
            this.buttonAddViewRepairs.Text = "Repairs";
            this.buttonAddViewRepairs.UseVisualStyleBackColor = true;
            this.buttonAddViewRepairs.Click += new System.EventHandler(this.buttonAddViewRepairs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add New Data for:";
            this.label1.UseMnemonic = false;
            // 
            // buttonOldestServed
            // 
            this.buttonOldestServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOldestServed.Location = new System.Drawing.Point(88, 108);
            this.buttonOldestServed.Name = "buttonOldestServed";
            this.buttonOldestServed.Size = new System.Drawing.Size(85, 57);
            this.buttonOldestServed.TabIndex = 6;
            this.buttonOldestServed.Text = "Oldest Signup";
            this.buttonOldestServed.UseVisualStyleBackColor = true;
            this.buttonOldestServed.Click += new System.EventHandler(this.buttonOldestServed_Click);
            // 
            // buttonNewestServed
            // 
            this.buttonNewestServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewestServed.Location = new System.Drawing.Point(1, 108);
            this.buttonNewestServed.Name = "buttonNewestServed";
            this.buttonNewestServed.Size = new System.Drawing.Size(83, 57);
            this.buttonNewestServed.TabIndex = 5;
            this.buttonNewestServed.Text = "Newest Signup";
            this.buttonNewestServed.UseVisualStyleBackColor = true;
            this.buttonNewestServed.Click += new System.EventHandler(this.buttonNewestServed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Find Username of members:";
            this.label2.UseMnemonic = false;
            // 
            // textBoxUserNameResult
            // 
            this.textBoxUserNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameResult.Location = new System.Drawing.Point(292, 66);
            this.textBoxUserNameResult.Name = "textBoxUserNameResult";
            this.textBoxUserNameResult.Size = new System.Drawing.Size(223, 29);
            this.textBoxUserNameResult.TabIndex = 9;
            // 
            // buttonLargestRepairServed
            // 
            this.buttonLargestRepairServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLargestRepairServed.Location = new System.Drawing.Point(175, 108);
            this.buttonLargestRepairServed.Name = "buttonLargestRepairServed";
            this.buttonLargestRepairServed.Size = new System.Drawing.Size(174, 57);
            this.buttonLargestRepairServed.TabIndex = 10;
            this.buttonLargestRepairServed.Text = "Your Least Served Member";
            this.buttonLargestRepairServed.UseVisualStyleBackColor = true;
            this.buttonLargestRepairServed.Click += new System.EventHandler(this.buttonLargestRepairServed_Click);
            // 
            // buttonAddViewDevices
            // 
            this.buttonAddViewDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddViewDevices.Location = new System.Drawing.Point(401, 196);
            this.buttonAddViewDevices.Name = "buttonAddViewDevices";
            this.buttonAddViewDevices.Size = new System.Drawing.Size(93, 36);
            this.buttonAddViewDevices.TabIndex = 12;
            this.buttonAddViewDevices.Text = "Devices";
            this.buttonAddViewDevices.UseVisualStyleBackColor = true;
            this.buttonAddViewDevices.Click += new System.EventHandler(this.buttonAddViewDevices_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(716, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "*********************************************************************************" +
    "*******";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(716, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "*********************************************************************************" +
    "*******";
            this.label5.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-13, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(700, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "*********************************************************************************" +
    "*****";
            this.label6.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Find Group of Results for users:";
            this.label7.UseMnemonic = false;
            // 
            // buttonUserNoYet
            // 
            this.buttonUserNoYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserNoYet.Location = new System.Drawing.Point(12, 282);
            this.buttonUserNoYet.Name = "buttonUserNoYet";
            this.buttonUserNoYet.Size = new System.Drawing.Size(251, 36);
            this.buttonUserNoYet.TabIndex = 17;
            this.buttonUserNoYet.Text = "You Havent Been Assigned";
            this.buttonUserNoYet.UseVisualStyleBackColor = true;
            this.buttonUserNoYet.Click += new System.EventHandler(this.buttonUserNoYet_Click);
            // 
            // buttonUserSingularModel
            // 
            this.buttonUserSingularModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserSingularModel.Location = new System.Drawing.Point(21, 324);
            this.buttonUserSingularModel.Name = "buttonUserSingularModel";
            this.buttonUserSingularModel.Size = new System.Drawing.Size(242, 36);
            this.buttonUserSingularModel.TabIndex = 18;
            this.buttonUserSingularModel.Text = "Bought in singular model";
            this.buttonUserSingularModel.UseVisualStyleBackColor = true;
            this.buttonUserSingularModel.Click += new System.EventHandler(this.buttonUserSingularModel_Click);
            // 
            // buttonBrandSelect
            // 
            this.buttonBrandSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrandSelect.Location = new System.Drawing.Point(19, 439);
            this.buttonBrandSelect.Name = "buttonBrandSelect";
            this.buttonBrandSelect.Size = new System.Drawing.Size(306, 36);
            this.buttonBrandSelect.TabIndex = 19;
            this.buttonBrandSelect.Text = "Users who have booked repairs of brand:";
            this.buttonBrandSelect.UseVisualStyleBackColor = true;
            this.buttonBrandSelect.Click += new System.EventHandler(this.buttonBrandSelect_Click);
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Location = new System.Drawing.Point(331, 443);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(337, 32);
            this.comboBoxBrands.TabIndex = 21;
            // 
            // buttonBeforeID
            // 
            this.buttonBeforeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeforeID.Location = new System.Drawing.Point(334, 401);
            this.buttonBeforeID.Name = "buttonBeforeID";
            this.buttonBeforeID.Size = new System.Drawing.Size(160, 36);
            this.buttonBeforeID.TabIndex = 24;
            this.buttonBeforeID.Text = "Before";
            this.buttonBeforeID.UseVisualStyleBackColor = true;
            this.buttonBeforeID.Click += new System.EventHandler(this.buttonBeforeID_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID:";
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(453, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "All repair jobs before or after a given repair ID:";
            // 
            // buttonAfterID
            // 
            this.buttonAfterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfterID.Location = new System.Drawing.Point(500, 401);
            this.buttonAfterID.Name = "buttonAfterID";
            this.buttonAfterID.Size = new System.Drawing.Size(168, 36);
            this.buttonAfterID.TabIndex = 28;
            this.buttonAfterID.Text = "After";
            this.buttonAfterID.UseVisualStyleBackColor = true;
            this.buttonAfterID.Click += new System.EventHandler(this.buttonAfterID_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownID.Location = new System.Drawing.Point(55, 403);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(210, 29);
            this.numericUpDownID.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(270, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Time:";
            this.label11.UseMnemonic = false;
            // 
            // listViewResults
            // 
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(3, 481);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(668, 292);
            this.listViewResults.TabIndex = 31;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // buttonMostServed
            // 
            this.buttonMostServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostServed.Location = new System.Drawing.Point(351, 108);
            this.buttonMostServed.Name = "buttonMostServed";
            this.buttonMostServed.Size = new System.Drawing.Size(164, 57);
            this.buttonMostServed.TabIndex = 32;
            this.buttonMostServed.Text = "Your Most Served Member";
            this.buttonMostServed.UseVisualStyleBackColor = true;
            this.buttonMostServed.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUserHasPrev
            // 
            this.buttonUserHasPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserHasPrev.Location = new System.Drawing.Point(269, 283);
            this.buttonUserHasPrev.Name = "buttonUserHasPrev";
            this.buttonUserHasPrev.Size = new System.Drawing.Size(242, 36);
            this.buttonUserHasPrev.TabIndex = 33;
            this.buttonUserHasPrev.Text = "You Have Been Assigned";
            this.buttonUserHasPrev.UseVisualStyleBackColor = true;
            this.buttonUserHasPrev.Click += new System.EventHandler(this.buttonUserHasPrev_Click);
            // 
            // buttonUserMultipleModels
            // 
            this.buttonUserMultipleModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserMultipleModels.Location = new System.Drawing.Point(269, 324);
            this.buttonUserMultipleModels.Name = "buttonUserMultipleModels";
            this.buttonUserMultipleModels.Size = new System.Drawing.Size(242, 36);
            this.buttonUserMultipleModels.TabIndex = 34;
            this.buttonUserMultipleModels.Text = "Bought in multiple models";
            this.buttonUserMultipleModels.UseVisualStyleBackColor = true;
            this.buttonUserMultipleModels.Click += new System.EventHandler(this.buttonUserMultipleModels_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.Location = new System.Drawing.Point(13, 779);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(213, 36);
            this.buttonShowAll.TabIndex = 35;
            this.buttonShowAll.Text = "Show All Your Repairs:";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(574, 779);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(89, 36);
            this.buttonLogout.TabIndex = 36;
            this.buttonLogout.Text = "Logout:";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShowRepairsMongoDB
            // 
            this.buttonShowRepairsMongoDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowRepairsMongoDB.Location = new System.Drawing.Point(241, 779);
            this.buttonShowRepairsMongoDB.Name = "buttonShowRepairsMongoDB";
            this.buttonShowRepairsMongoDB.Size = new System.Drawing.Size(317, 36);
            this.buttonShowRepairsMongoDB.TabIndex = 37;
            this.buttonShowRepairsMongoDB.Text = "Show All Your Repairs (MongoDB):";
            this.buttonShowRepairsMongoDB.UseVisualStyleBackColor = true;
            this.buttonShowRepairsMongoDB.Click += new System.EventHandler(this.buttonShowRepairsMongoDB_Click);
            // 
            // buttonUsersAssignedMongoDB
            // 
            this.buttonUsersAssignedMongoDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersAssignedMongoDB.Location = new System.Drawing.Point(521, 282);
            this.buttonUsersAssignedMongoDB.Name = "buttonUsersAssignedMongoDB";
            this.buttonUsersAssignedMongoDB.Size = new System.Drawing.Size(150, 113);
            this.buttonUsersAssignedMongoDB.TabIndex = 40;
            this.buttonUsersAssignedMongoDB.Text = "You Have Been Assigned (MongoDB)";
            this.buttonUsersAssignedMongoDB.UseVisualStyleBackColor = true;
            this.buttonUsersAssignedMongoDB.Click += new System.EventHandler(this.buttonUsersAssignedMongoDB_Click);
            // 
            // buttonMostServedMongo
            // 
            this.buttonMostServedMongo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostServedMongo.Location = new System.Drawing.Point(521, 53);
            this.buttonMostServedMongo.Name = "buttonMostServedMongo";
            this.buttonMostServedMongo.Size = new System.Drawing.Size(164, 112);
            this.buttonMostServedMongo.TabIndex = 41;
            this.buttonMostServedMongo.Text = "Your Most Served Member (MongoDB)";
            this.buttonMostServedMongo.UseVisualStyleBackColor = true;
            this.buttonMostServedMongo.Click += new System.EventHandler(this.buttonMostServedMongo_Click);
            // 
            // buttonAddUserMongo
            // 
            this.buttonAddUserMongo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUserMongo.Location = new System.Drawing.Point(500, 196);
            this.buttonAddUserMongo.Name = "buttonAddUserMongo";
            this.buttonAddUserMongo.Size = new System.Drawing.Size(168, 36);
            this.buttonAddUserMongo.TabIndex = 42;
            this.buttonAddUserMongo.Text = "Users (MongoDB)";
            this.buttonAddUserMongo.UseVisualStyleBackColor = true;
            this.buttonAddUserMongo.Click += new System.EventHandler(this.buttonAddUserMongo_Click);
            // 
            // StaffActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 821);
            this.Controls.Add(this.buttonAddUserMongo);
            this.Controls.Add(this.buttonMostServedMongo);
            this.Controls.Add(this.buttonUsersAssignedMongoDB);
            this.Controls.Add(this.buttonShowRepairsMongoDB);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonUserMultipleModels);
            this.Controls.Add(this.buttonUserHasPrev);
            this.Controls.Add(this.buttonMostServed);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.buttonAfterID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonBeforeID);
            this.Controls.Add(this.comboBoxBrands);
            this.Controls.Add(this.buttonBrandSelect);
            this.Controls.Add(this.buttonUserSingularModel);
            this.Controls.Add(this.buttonUserNoYet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddViewDevices);
            this.Controls.Add(this.buttonLargestRepairServed);
            this.Controls.Add(this.textBoxUserNameResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOldestServed);
            this.Controls.Add(this.buttonNewestServed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddViewRepairs);
            this.Controls.Add(this.buttonAddViewUser);
            this.Controls.Add(this.labelLogin);
            this.Name = "StaffActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffActions";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonAddViewUser;
        private System.Windows.Forms.Button buttonAddViewRepairs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOldestServed;
        private System.Windows.Forms.Button buttonNewestServed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserNameResult;
        private System.Windows.Forms.Button buttonLargestRepairServed;
        private System.Windows.Forms.Button buttonAddViewDevices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUserNoYet;
        private System.Windows.Forms.Button buttonUserSingularModel;
        private System.Windows.Forms.Button buttonBrandSelect;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Button buttonBeforeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAfterID;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.Button buttonMostServed;
        private System.Windows.Forms.Button buttonUserHasPrev;
        private System.Windows.Forms.Button buttonUserMultipleModels;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShowRepairsMongoDB;
        private System.Windows.Forms.Button buttonUsersAssignedMongoDB;
        private System.Windows.Forms.Button buttonMostServedMongo;
        private System.Windows.Forms.Button buttonAddUserMongo;
    }
}