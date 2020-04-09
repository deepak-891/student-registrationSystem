using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f1 = new Add();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dotbet;";                // using the code here... 

            string query = "INSERT INTO `student` (StudentID, name, fatherName, localAddress, " +
                "permanentAdress, aieeeRank, " +
                "12percentage, sex, course, stream," +
                " RegistrationDate, dobdate, dobmonth, dobyear)" +
                " VALUES ('" + studentID.Text + "'," +
                "'" + name.Text + "'," +
                "'" + fatherName.Text + "'," +
                "'" + localAddress.Text + "'," +
                "'" + permanentAddress.Text + "'," +
                 AIEEE.Text + "," +
                 twelth.Text + ",";
                 if (male.Checked)
                {
                    query = query + "'M',";
                }
                     else if (female.Checked)
                {
                    query = query + "'F',";

                }

            query = query + "'" + course.SelectedItem+ "'," +
                "'" + stream.SelectedItem + "',"+
                "'" + registration.Text + "',"+
                "'" + dobday.SelectedItem + "',"+
                "'" + dobmonth.SelectedItem + "'," +
                "'" + dobyear.SelectedItem + "'" +



                ");";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {

                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        Console.WriteLine(row[i]);
                        i = i + 1;
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                MessageBox.Show("succesfull");


                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.Write(ex.Message);
            }


        }


    }
}
