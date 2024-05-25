namespace SQLPermTester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ServerHostnameTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.QueryTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExeBtn = new System.Windows.Forms.Button();
            this.DBTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TableTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.LoadDefBtn = new System.Windows.Forms.Button();
            this.SelectTestBtn = new System.Windows.Forms.Button();
            this.InsertTestBtn = new System.Windows.Forms.Button();
            this.ColNamesText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TestDBListBtn = new System.Windows.Forms.Button();
            this.TestTableListBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DelTestBtn = new System.Windows.Forms.Button();
            this.AlterTestBtn = new System.Windows.Forms.Button();
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshProfilesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS SQLServer Hostname/ip";
            // 
            // ServerHostnameTxt
            // 
            this.ServerHostnameTxt.Location = new System.Drawing.Point(181, 25);
            this.ServerHostnameTxt.Name = "ServerHostnameTxt";
            this.ServerHostnameTxt.Size = new System.Drawing.Size(240, 20);
            this.ServerHostnameTxt.TabIndex = 1;
            this.ServerHostnameTxt.Text = "localhost";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(181, 51);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(240, 20);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(181, 77);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(240, 20);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(29, 191);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(101, 31);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(26, 172);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(106, 16);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(237, 191);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(101, 31);
            this.DisconnectBtn.TabIndex = 8;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // QueryTxt
            // 
            this.QueryTxt.Location = new System.Drawing.Point(190, 243);
            this.QueryTxt.Name = "QueryTxt";
            this.QueryTxt.Size = new System.Drawing.Size(583, 20);
            this.QueryTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Free Query";
            // 
            // ExeBtn
            // 
            this.ExeBtn.Location = new System.Drawing.Point(136, 191);
            this.ExeBtn.Name = "ExeBtn";
            this.ExeBtn.Size = new System.Drawing.Size(101, 31);
            this.ExeBtn.TabIndex = 11;
            this.ExeBtn.Text = "Run Query";
            this.ExeBtn.UseVisualStyleBackColor = true;
            this.ExeBtn.Click += new System.EventHandler(this.ExeBtn_Click);
            // 
            // DBTxt
            // 
            this.DBTxt.Location = new System.Drawing.Point(181, 103);
            this.DBTxt.Name = "DBTxt";
            this.DBTxt.Size = new System.Drawing.Size(240, 20);
            this.DBTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DB Name";
            // 
            // TableTxt
            // 
            this.TableTxt.Location = new System.Drawing.Point(181, 129);
            this.TableTxt.Name = "TableTxt";
            this.TableTxt.Size = new System.Drawing.Size(240, 20);
            this.TableTxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Table Name";
            // 
            // ResultTxt
            // 
            this.ResultTxt.Location = new System.Drawing.Point(56, 275);
            this.ResultTxt.Multiline = true;
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTxt.Size = new System.Drawing.Size(717, 163);
            this.ResultTxt.TabIndex = 16;
            // 
            // LoadDefBtn
            // 
            this.LoadDefBtn.Location = new System.Drawing.Point(344, 191);
            this.LoadDefBtn.Name = "LoadDefBtn";
            this.LoadDefBtn.Size = new System.Drawing.Size(101, 31);
            this.LoadDefBtn.TabIndex = 17;
            this.LoadDefBtn.Text = "Load Default";
            this.LoadDefBtn.UseVisualStyleBackColor = true;
            this.LoadDefBtn.Click += new System.EventHandler(this.LoadDefBtn_Click);
            // 
            // SelectTestBtn
            // 
            this.SelectTestBtn.Location = new System.Drawing.Point(822, 121);
            this.SelectTestBtn.Name = "SelectTestBtn";
            this.SelectTestBtn.Size = new System.Drawing.Size(101, 31);
            this.SelectTestBtn.TabIndex = 18;
            this.SelectTestBtn.Text = "Test Select";
            this.SelectTestBtn.UseVisualStyleBackColor = true;
            this.SelectTestBtn.Click += new System.EventHandler(this.SelectTestBtn_Click);
            // 
            // InsertTestBtn
            // 
            this.InsertTestBtn.Location = new System.Drawing.Point(822, 158);
            this.InsertTestBtn.Name = "InsertTestBtn";
            this.InsertTestBtn.Size = new System.Drawing.Size(101, 31);
            this.InsertTestBtn.TabIndex = 19;
            this.InsertTestBtn.Text = "Test Insert";
            this.InsertTestBtn.UseVisualStyleBackColor = true;
            this.InsertTestBtn.Click += new System.EventHandler(this.InsertTestBtn_Click);
            // 
            // ColNamesText
            // 
            this.ColNamesText.Location = new System.Drawing.Point(646, 66);
            this.ColNamesText.Multiline = true;
            this.ColNamesText.Name = "ColNamesText";
            this.ColNamesText.Size = new System.Drawing.Size(127, 151);
            this.ColNamesText.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Col Names";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(860, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tests";
            // 
            // TestDBListBtn
            // 
            this.TestDBListBtn.Location = new System.Drawing.Point(822, 48);
            this.TestDBListBtn.Name = "TestDBListBtn";
            this.TestDBListBtn.Size = new System.Drawing.Size(101, 31);
            this.TestDBListBtn.TabIndex = 23;
            this.TestDBListBtn.Text = "Test DB list";
            this.TestDBListBtn.UseVisualStyleBackColor = true;
            this.TestDBListBtn.Click += new System.EventHandler(this.TestDBListBtn_Click);
            // 
            // TestTableListBtn
            // 
            this.TestTableListBtn.Location = new System.Drawing.Point(822, 85);
            this.TestTableListBtn.Name = "TestTableListBtn";
            this.TestTableListBtn.Size = new System.Drawing.Size(101, 31);
            this.TestTableListBtn.TabIndex = 24;
            this.TestTableListBtn.Text = "Test Table list";
            this.TestTableListBtn.UseVisualStyleBackColor = true;
            this.TestTableListBtn.Click += new System.EventHandler(this.TestTableListBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGreen;
            this.label9.Location = new System.Drawing.Point(489, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Access with Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(489, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Access with No Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Pink;
            this.label11.Location = new System.Drawing.Point(489, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "No Access";
            // 
            // DelTestBtn
            // 
            this.DelTestBtn.Location = new System.Drawing.Point(822, 195);
            this.DelTestBtn.Name = "DelTestBtn";
            this.DelTestBtn.Size = new System.Drawing.Size(101, 31);
            this.DelTestBtn.TabIndex = 28;
            this.DelTestBtn.Text = "Test Delete";
            this.DelTestBtn.UseVisualStyleBackColor = true;
            this.DelTestBtn.Click += new System.EventHandler(this.DelTestBtn_Click);
            // 
            // AlterTestBtn
            // 
            this.AlterTestBtn.Location = new System.Drawing.Point(822, 232);
            this.AlterTestBtn.Name = "AlterTestBtn";
            this.AlterTestBtn.Size = new System.Drawing.Size(101, 31);
            this.AlterTestBtn.TabIndex = 29;
            this.AlterTestBtn.Text = "Test Alter";
            this.AlterTestBtn.UseVisualStyleBackColor = true;
            this.AlterTestBtn.Click += new System.EventHandler(this.AlterTestBtn_Click);
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(467, 193);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(143, 21);
            this.ProfileComboBox.TabIndex = 30;
            // 
            // RefreshProfilesBtn
            // 
            this.RefreshProfilesBtn.Location = new System.Drawing.Point(487, 158);
            this.RefreshProfilesBtn.Name = "RefreshProfilesBtn";
            this.RefreshProfilesBtn.Size = new System.Drawing.Size(108, 30);
            this.RefreshProfilesBtn.TabIndex = 31;
            this.RefreshProfilesBtn.Text = "Refresh Profiles";
            this.RefreshProfilesBtn.UseVisualStyleBackColor = true;
            this.RefreshProfilesBtn.Click += new System.EventHandler(this.RefreshProfilesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.RefreshProfilesBtn);
            this.Controls.Add(this.ProfileComboBox);
            this.Controls.Add(this.AlterTestBtn);
            this.Controls.Add(this.DelTestBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TestTableListBtn);
            this.Controls.Add(this.TestDBListBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ColNamesText);
            this.Controls.Add(this.InsertTestBtn);
            this.Controls.Add(this.SelectTestBtn);
            this.Controls.Add(this.LoadDefBtn);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.TableTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DBTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExeBtn);
            this.Controls.Add(this.QueryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerHostnameTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQL Permissions Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerHostnameTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.TextBox QueryTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExeBtn;
        private System.Windows.Forms.TextBox DBTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TableTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.Button LoadDefBtn;
        private System.Windows.Forms.Button SelectTestBtn;
        private System.Windows.Forms.Button InsertTestBtn;
        private System.Windows.Forms.TextBox ColNamesText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button TestDBListBtn;
        private System.Windows.Forms.Button TestTableListBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DelTestBtn;
        private System.Windows.Forms.Button AlterTestBtn;
        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.Button RefreshProfilesBtn;
    }
}

