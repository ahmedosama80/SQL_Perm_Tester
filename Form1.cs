// ver 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.IO;

namespace SQLPermTester
{
    public partial class Form1 : Form
    {


        SqlConnection m_SQLConnector;
        //SqlDataAdapter ;
        SqlCommand QueryCmd;

        string server;
        string user;
        string password;
        string DB;
        string Table;
        List<string> ColNames;
        int LastQuery = -1;
        Color BtnColor;

        int RowsAffectedCount =0;
        int RowsCount = 0;

        private Dictionary<string, string[]> profiles;

        public Form1()
        {
            InitializeComponent();
            ColNames = new List<string>();
            BtnColor = SelectTestBtn.BackColor;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
             server = ServerHostnameTxt.Text;
             user = UsernameTxt.Text;
             password = PasswordTxt.Text;
             DB = DBTxt.Text;
             Table = TableTxt.Text;
            QueryTxt.Text = "use " + DB + ";" + "select top 5 * from " + Table;

            // m_SQLConnector = new SqlConnection(("Server=localhost;Database=SQLShackDemo;User Id=SuperHero;Password=1pass;"))

                m_SQLConnector = new SqlConnection(("Server=" + server + ";Database=" + DB + ";User Id=" + user + ";Password=" + password + "; "));
            try
            {
                m_SQLConnector.Open();
                StatusLabel.Text = "Connected";


                ResultTxt.AppendText("Connected");
                ResultTxt.AppendText(Environment.NewLine);


                ConnectBtn.BackColor = Color.LightGreen;
            }
            
            catch (Exception ex)
            {
                ResultTxt.AppendText(ex.Message);
                ResultTxt.AppendText(Environment.NewLine);


                ConnectBtn.BackColor = Color.Pink;



            }



        }


        private void LoadDefBtn_Click(object sender, EventArgs e)
        {
            

            if (ProfileComboBox.SelectedItem != null)
            {
                string selectedProfile = ProfileComboBox.SelectedItem.ToString();
                if (profiles.ContainsKey(selectedProfile))
                {
                    string[] lines = profiles[selectedProfile];
                    if (lines.Length == 5)
                    {
                        ServerHostnameTxt.Text = lines[0];
                        UsernameTxt.Text = lines[1];
                        PasswordTxt.Text = lines[2];
                        DBTxt.Text = lines[3];
                        TableTxt.Text = lines[4];
                    }
                    else
                    {
                        MessageBox.Show("The selected profile does not contain enough lines.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a profile.");
            }

         


        }


        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                m_SQLConnector.Close();
                StatusLabel.Text = "Disconnected";

                ConnectBtn.BackColor = SystemColors.Control;
               // DisconnectBtn.BackColor = Color.Pink;


            }
            catch
            {
                StatusLabel.Text = "Err";

                DisconnectBtn.BackColor = Color.Pink;

            }

        }

        private void ExeBtn_Click(object sender, EventArgs e)
        {
            ResultTxt.AppendText(Environment.NewLine);
            ResultTxt.AppendText(" ************** ");
            ResultTxt.AppendText(Environment.NewLine);
            ResultTxt.AppendText(QueryTxt.Text);
            ResultTxt.AppendText(Environment.NewLine);

            LastQuery = -1;

            QueryCmd = new SqlCommand(QueryTxt.Text, m_SQLConnector);
            RowsAffectedCount = 0;
             RowsCount = 0;

            try
            {

              
                //  QueryCmd.CommandText = QueryTxt.Text;

                SqlDataReader reader = QueryCmd.ExecuteReader();
                int ColCount = reader.FieldCount;

                 RowsAffectedCount = reader.RecordsAffected;
                 RowsCount = 0;
                int r = -1;
              


                while (reader.Read())
                {
                    // Create a list to hold column values
                     
                    r++;
                    if (r == 0)
                    {
                        ColNames.Clear();
                        ColNamesText.Text = "";
                        for (int i = 0; i < ColCount; i++)
                        {

                            {
                                ColNames.Add(reader.GetName(i));
                               // ColNamesText.Text = reader.GetName(i);

                                ColNamesText.AppendText(reader.GetName(i));
                                ColNamesText.AppendText(Environment.NewLine);
                            }
                        }

                        string ColNamesTxt = string.Join("   ,   ", ColNames.ToArray());

                        // Append the result to the ResultTxt 
                        ResultTxt.AppendText(" -- " +ColNamesTxt +" -- ");
                        ResultTxt.AppendText(Environment.NewLine);
                        
                    }

                    List<string> columnValues = new List<string>();

                    // Iterate over all columns
                    for (int i = 0; i < ColCount; i++)
                    {
                       if (i==0)
                        {
                            columnValues.Add("    "+reader[i].ToString());

                        }



                    else
                        {
                            columnValues.Add(reader[i].ToString());
                        }
                       
                    }

                    RowsCount++;

                    // Join column values into a single string separated by commas
                    string QueryReply = string.Join("   ,   ", columnValues.ToArray());

                    // Append the result to the ResultTxt
                    ResultTxt.AppendText(QueryReply);
                    ResultTxt.AppendText(Environment.NewLine);
                }

                ResultTxt.AppendText(Environment.NewLine);
                ResultTxt.AppendText("Rows :"+ RowsCount);
                ResultTxt.AppendText(Environment.NewLine);
                ResultTxt.AppendText("Rows Affected:"+ RowsAffectedCount);
                ResultTxt.AppendText(Environment.NewLine);
                


                reader.Close();
                ResultTxt.AppendText(" --- Done --- ");
                LastQuery = 1;
            }

            catch (Exception ex)
            {
                ResultTxt.AppendText(ex.Message);
                ResultTxt.AppendText(Environment.NewLine);
                LastQuery = 0;

            }

        }

      

        private void SelectTestBtn_Click(object sender, EventArgs e)
        {

            QueryTxt.Text = "use " + DB + ";" + "select top 5 * from " + Table;
            ExeBtn_Click(null, null);
            if (LastQuery == 1)
            {
                SelectTestBtn.BackColor = Color.LightGreen;
            }
            else
            {
                SelectTestBtn.BackColor = Color.LightPink;

            }

        }

        private void InsertTestBtn_Click(object sender, EventArgs e)
        {
            QueryTxt.Text = "use " + DB + ";" + "INSERT INTO " + Table + " DEFAULT VALUES " ;
            ExeBtn_Click(null, null);

            if (LastQuery == 1)
            {
                InsertTestBtn.BackColor = Color.LightGreen;
            }
            else
            {
                InsertTestBtn.BackColor = Color.LightPink;

            }
        }

        private void TestDBListBtn_Click(object sender, EventArgs e)
        {
           


            QueryTxt.Text = "use " + DB + ";" + " SELECT name FROM sys.databases";
            ExeBtn_Click(null, null);

            if (LastQuery == 1)
            {
                TestDBListBtn.BackColor = Color.LightGreen;
            }
            else
            {
                TestDBListBtn.BackColor = Color.LightPink;

            }


        }

        private void TestTableListBtn_Click(object sender, EventArgs e)
        {


            QueryTxt.Text = "use "+DB+";"+ "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            ExeBtn_Click(null, null);

            if (LastQuery == 1)
            {
                if (RowsCount==0)
                {
                    TestTableListBtn.BackColor = Color.Orange;
                    return;
                }
                TestTableListBtn.BackColor = Color.LightGreen;
            }
            else
            {
                TestTableListBtn.BackColor = Color.LightPink;

            }


        }

        private void DelTestBtn_Click(object sender, EventArgs e)
        {

            QueryTxt.Text = "use " + DB + ";" + "DELETE FROM " + Table +" WHERE 1=2;";
            ExeBtn_Click(null, null);

            if (LastQuery == 1)
            {
                DelTestBtn.BackColor = Color.LightGreen;
            }
            else
            {
                DelTestBtn.BackColor = Color.LightPink;

            }


            
        }

        private void AlterTestBtn_Click(object sender, EventArgs e)
        {
            QueryTxt.Text = "use " + DB + ";" + "ALTER TABLE " +Table + " ADD TestColCol123 varchar(255)";
            ExeBtn_Click(null, null);

            if (LastQuery == 1)
            {
                QueryTxt.Text = "use " + DB + ";" + "ALTER TABLE " + Table + " DROP COLUMN  TestColCol123 ";
                ExeBtn_Click(null, null);
            }

                if (LastQuery == 1)
            {
                
                AlterTestBtn.BackColor = Color.LightGreen;
            }
            else
            {
                AlterTestBtn.BackColor = Color.LightPink;

            }



        }



        private void RefreshProfilesBtn_Click(object sender, EventArgs e)
        {
            LoadProfilesFromFile("def.txt");
        }



        private void LoadProfilesFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    profiles = new Dictionary<string, string[]>();
                    List<string> currentProfile = null;
                    string currentProfileName = null;

                    foreach (var line in lines)
                    {
                        if (line.StartsWith("##") && line.EndsWith("##"))
                        {
                            if (currentProfile != null && currentProfileName != null)
                            {
                                profiles[currentProfileName] = currentProfile.ToArray();
                            }
                            currentProfileName = line.Trim('#').Trim();
                            currentProfile = new List<string>();
                        }
                        else if (!IsNullOrWhiteSpace(line))
                        {
                            currentProfile?.Add(line);
                        }
                    }

                    if (currentProfile != null && currentProfileName != null)
                    {
                        profiles[currentProfileName] = currentProfile.ToArray();
                    }

                    // Populate the ProfileComboBox with profile names
                    ProfileComboBox.Items.Clear();
                    ProfileComboBox.Items.AddRange(GetProfileNames(profiles));
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        private string[] GetProfileNames(Dictionary<string, string[]> profiles)
        {
            string[] profileNames = new string[profiles.Keys.Count];
            profiles.Keys.CopyTo(profileNames, 0);
            return profileNames;
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrEmpty(value) || value.Trim().Length == 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Warning: This application is potentially dangerous and should be used with caution. It is strongly recommended to use a test database, as data loss may occur.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }










        // End
    }
}
