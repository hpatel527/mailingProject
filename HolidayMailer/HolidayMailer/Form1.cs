using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net.Mail;

/* Hari Patel
 * CSCD 371 
 * Summer 16    
 * Holiday Mailer - Program that allows a user to create and populate a SQLITE database with user information and emails.
 * Program also allows the user to email a cover letter(with/without an attachment) to the emails stored in the database.
 * Shortcomings - Design/GUI is lacking and I plan to revist the program by adding seperate forms for adding/database control and allowing users to customize the email they wish to send.
 */


namespace HolidayMailer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("database.db")) // database exists - Fill Grid
            {

                SQLiteConnection m_dbConnection;
                SQLiteCommand command;
                SQLiteDataReader sqlite_datareader;

                try
                {
                    m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                    m_dbConnection.Open();

                    string sql = "select * from mailer order by lastname asc ";

                    command = new SQLiteCommand(sql, m_dbConnection);
                    sqlite_datareader = command.ExecuteReader();

                    while (sqlite_datareader.Read())
                    {

                        string firstName = sqlite_datareader["firstname"].ToString();
                        string lastName = sqlite_datareader["lastname"].ToString();
                        string email = sqlite_datareader["email"].ToString();
                        string previousEmail = sqlite_datareader["previoussent"].ToString();
                        dataGridDatabase.Rows.Add(firstName, lastName, email, previousEmail);

                    }

                    m_dbConnection.Close();
                }
                catch (SQLiteException sqle)
                {
                    Console.WriteLine("SQLiteException source: {0}", sqle.Source);
                }

            }
            else // Database doesn't exist - Create one
            {
                SQLiteConnection m_dbConnection;
                SQLiteCommand command;



                try
                {
                    m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                    m_dbConnection.Open();

                    string sql = "CREATE TABLE IF NOT EXISTS mailer (firstname VARCHAR(100), lastname VARCHAR(100), email VARCHAR(100), previoussent VARCHAR(100) )";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();

                    m_dbConnection.Close();
                }

                catch (SQLiteException sqle)
                {
                    Console.WriteLine("SQLiteException source: {0}", sqle.Source);
                }


            }


        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (((string.IsNullOrEmpty(txtFName.Text)) || (string.IsNullOrEmpty(txtLName.Text)) || ((string.IsNullOrEmpty(txtEmail.Text)))))
            {
                MessageBox.Show("Please fill out all the required forms");

            }

            
            else
            {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                    if ((addr.Address == txtEmail.Text) == false)
                    {
                        MessageBox.Show("Please enter a valid email address");
                    }

                    else
                    {

                        string fName = txtFName.Text;
                        string lName = txtLName.Text;
                        string email = txtEmail.Text;
                        string previousEmail;
                        if (radioPrevious.Checked == true)
                        {
                            previousEmail = "yes";
                        }
                        else
                        {
                            previousEmail = "no";
                        }
                        SQLiteConnection m_dbConnection;
                        SQLiteCommand command;
                        SQLiteDataReader sqlite_datareader;

                        try
                        {
                            m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                            m_dbConnection.Open();

                            string sql = "CREATE TABLE IF NOT EXISTS mailer (firstname VARCHAR(100), lastname VARCHAR(100), email VARCHAR(100), previoussent VARCHAR(100) )";

                            command = new SQLiteCommand(sql, m_dbConnection);
                            command.ExecuteNonQuery();

                            command.CommandText = "INSERT INTO mailer (firstname,lastname,email,previoussent) VALUES(@var1,@var2,@var3,@var4)";
                            command.Parameters.AddWithValue("@var1", fName);
                            command.Parameters.AddWithValue("@var2", lName);
                            command.Parameters.AddWithValue("@var3", email);
                            command.Parameters.AddWithValue("@var4", previousEmail);
                            command.ExecuteNonQuery();

                            m_dbConnection.Close();
                        }
                        catch (SQLiteException sqle)
                        {
                            Console.WriteLine("SQLiteException source: {0}", sqle.Source);
                        }


                        dataGridDatabase.DataSource = null;
                        dataGridDatabase.Rows.Clear();
                        txtFName.Text = "";
                        txtLName.Text = "";
                        txtEmail.Text = "";
                        radioPrevious.Checked = false;


                        try
                        {
                            m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                            m_dbConnection.Open();

                            string sql = "select * from mailer order by lastname asc ";

                            command = new SQLiteCommand(sql, m_dbConnection);
                            sqlite_datareader = command.ExecuteReader();

                            while (sqlite_datareader.Read())
                            {

                                string firstName = sqlite_datareader["firstname"].ToString();
                                string lastName = sqlite_datareader["lastname"].ToString();
                                string strEmail = sqlite_datareader["email"].ToString();
                                string previousEmaill = sqlite_datareader["previoussent"].ToString();
                                dataGridDatabase.Rows.Add(firstName, lastName, strEmail, previousEmaill);

                            }

                            m_dbConnection.Close();
                        }
                        catch (SQLiteException sqle)
                        {
                            Console.WriteLine("SQLiteException source: {0}", sqle.Source);
                        }
                    }

            }




        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridDatabase.DataSource = null;
            dataGridDatabase.Rows.Clear();
            string letter = txtLetter.Text;

            SQLiteConnection m_dbConnection;
            SQLiteCommand command;
            SQLiteDataReader sqlite_datareader;

            try
            {
                m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                m_dbConnection.Open();
                string sql = "select * from mailer order by lastname asc ";

                command = new SQLiteCommand(sql, m_dbConnection);
                sqlite_datareader = command.ExecuteReader();

                while (sqlite_datareader.Read())
                {

                    string firstName = sqlite_datareader["firstname"].ToString();
                    string lastName = sqlite_datareader["lastname"].ToString();
                    string email = sqlite_datareader["email"].ToString();
                    string previousEmail = sqlite_datareader["previoussent"].ToString();

                    if (lastName.StartsWith(letter))
                    {
                        dataGridDatabase.Rows.Add(firstName, lastName, email, previousEmail);
                    }
                }

                m_dbConnection.Close();
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine("SQLiteException source: {0}", sqle.Source);
            }






        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string choice = comboEmail.SelectedItem.ToString();
            string a = "All People";
            string b = "People that sent previous email";
            string attach = txtAttach.Text;
            

            if (choice.Equals(a)) // All people in the database
            {
                SQLiteConnection m_dbConnection;
                SQLiteCommand command;
                SQLiteDataReader sqlite_datareader;

                try
                {
                    m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                    m_dbConnection.Open();

                    string sql = "select * from mailer";

                    command = new SQLiteCommand(sql, m_dbConnection);
                    sqlite_datareader = command.ExecuteReader();
        
                        while (sqlite_datareader.Read())
                        {
                            
                            string userEmail = sqlite_datareader["email"].ToString();

                            try
                            {
                                SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
                                mailServer.EnableSsl = true;

                                mailServer.Credentials = new System.Net.NetworkCredential("minidude6@gmail.com", "Minifire23@#");

                                string from = "minidude6@gmail.com";
                                string to = userEmail;
                                MailMessage msg = new MailMessage(from, to);
                                msg.Subject = "Happy Holidays from Hari";
                                msg.Body = "Enjoy the holidays!";
                                if (txtAttach.Text != "")
                                {
                                    if (File.Exists(@txtAttach.Text))
                                    {
                                        msg.Attachments.Add(new Attachment(@txtAttach.Text));
                                    }
                                }
                                mailServer.Send(msg);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Unable to send email. Error : " + ex);
                            }

                            userEmail = "";
                        }               
                    m_dbConnection.Close();
                    MessageBox.Show("Emails successfully sent");
                }
                catch (SQLiteException sqle)
                {
                    Console.WriteLine("SQLiteException source: {0}", sqle.Source);
                }

            }
            else if (choice.Equals(b)) // People that have sent a previous email
            {
                SQLiteConnection m_dbConnection;
                SQLiteCommand command;
                SQLiteDataReader sqlite_datareader;

                try
                {
                    m_dbConnection = new SQLiteConnection("Data Source=database.db;New=True;Version=3;");
                    m_dbConnection.Open();

                    string sql = "select email,previoussent from mailer";

                    command = new SQLiteCommand(sql, m_dbConnection);
                    sqlite_datareader = command.ExecuteReader();


                    while (sqlite_datareader.Read())
                    {

                        string userEmail = sqlite_datareader["email"].ToString();
                        string previousSent = sqlite_datareader["previoussent"].ToString();
                        if(previousSent.Equals("yes"))
                        {
                            try
                            {
                                SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
                                mailServer.EnableSsl = true;

                                mailServer.Credentials = new System.Net.NetworkCredential("minidude6@gmail.com", "Minifire23@#");

                                string from = "minidude6@gmail.com";
                                string to = userEmail;
                                MailMessage msg = new MailMessage(from, to);
                                msg.Subject = "Happy Holidays from Hari";
                                msg.Body = "Enjoy the holidays!";
                                if (txtAttach.Text != "")
                                {
                                    if (File.Exists(txtAttach.Text))
                                    {
                                        msg.Attachments.Add(new Attachment(txtAttach.Text));
                                    }
                                }                             
                                mailServer.Send(msg);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Unable to send email. Error : " + ex);
                            }

                            userEmail = "";
                        }
                        
                    }
                    m_dbConnection.Close();
                    MessageBox.Show("Emails successfully sent");
                    
                }   
                    catch (SQLiteException sqle)
                    {
                        Console.WriteLine("SQLiteException source: {0}", sqle.Source);
                    }
            }
            

            
        
            
        }//end Method
    

        private void comboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hari Patel \n Summer 16 \n Holiday Mailer");
        }
        
    }


}
