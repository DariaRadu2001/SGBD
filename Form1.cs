using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laborator1
{
    public partial class Form1 : Form
    {
        string connectionString =
       "Data Source=DARIA\\SQLEXPRESS;Initial Catalog=Labor1;"
       + "Integrated Security=true";

        public Form1()
        {
            InitializeComponent();
            inputReset();
        }

        private void inputReset()
        {
            textBox_CL_ID.Clear();
            textBox_Name.Clear();
            textBoxAdresse_ID.Clear();

            textBox_CL_ID.Enabled = false;
            textBox_Name.Enabled = false;
            textBoxAdresse_ID.Enabled = false;
           
            Insert_button.Enabled = false;
            Update_button.Enabled = false;
            Delete_button.Enabled = false;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            
            DataSet dataSet = new DataSet();
            SqlDataAdapter adresseAdapter = new SqlDataAdapter("select * from Adresa", connectionString);
            SqlDataAdapter kundeAdapter = new SqlDataAdapter("select * from Clienti", connectionString);

            adresseAdapter.Fill(dataSet, "Adresa");
            kundeAdapter.Fill(dataSet, "Clienti");

            //aici fac relatia dintre copil si parinte
            DataRelation dataRelation = new DataRelation("FK_Clienti_Adresa",
                dataSet.Tables["Adresa"].Columns["Ad_ID"],
                dataSet.Tables["Clienti"].Columns["Ad_ID"]
                
               );

            try
            {
                dataSet.Relations.Add(dataRelation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //aici se fac legaturile pt dataGridView
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataSet; 
            bindingSource1.DataMember = "Adresa";

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = bindingSource1;
            bindingSource2.DataMember = "FK_Clienti_Adresa";


            dataGridView_Adresse.DataSource = bindingSource1;
            dataGridView_Kunde.DataSource = bindingSource2;

            
        }

        private void dataGridView_Adresse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                inputReset();

                string ad_ID = this.dataGridView_Adresse[0, this.dataGridView_Adresse.CurrentCell.RowIndex].Value.ToString();

                //le dau enable pt insert
                if (!String.IsNullOrWhiteSpace(ad_ID))
                {
                    textBoxAdresse_ID.Text = ad_ID;
                    textBox_CL_ID.Enabled = true;
                    textBox_Name.Enabled = true;
                    Insert_button.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //iau datele de la fiecare tupel din copil
        private void dataGridView_Kunde_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                inputReset();

                int rowNumber = this.dataGridView_Kunde.CurrentCell.RowIndex;

                string cl_id = this.dataGridView_Kunde[0, rowNumber].Value.ToString();
                string name = this.dataGridView_Kunde[1, rowNumber].Value.ToString();
                string adresse_id = this.dataGridView_Kunde[2, rowNumber].Value.ToString();


                if (!String.IsNullOrWhiteSpace(cl_id))
                {
                    textBoxAdresse_ID.Text = adresse_id;
                    textBox_CL_ID.Text = cl_id;
                    textBox_Name.Text = name;

                    textBox_Name.Enabled = true;
                    textBoxAdresse_ID.Enabled = true;

                    Update_button.Enabled = true;
                    Delete_button.Enabled = true;
                  
                }
                else
                {
                    textBox_CL_ID.Text = cl_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Clienti" +
                " VALUES(@Cl_ID, @Name, @Ad_ID)",
                sqlConnection);


            try
            {
                sqlConnection.Open();
                dataAdapter.InsertCommand.Parameters.Add("@Cl_ID", SqlDbType.Int).Value = Int32.Parse(textBox_CL_ID.Text);
                dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox_Name.Text;
                dataAdapter.InsertCommand.Parameters.Add("@Ad_ID", SqlDbType.Int).Value = Int32.Parse(textBoxAdresse_ID.Text);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted data successfully.");
                sqlConnection.Close();
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Falsches ID.");
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sie haben falsche Daten gegeben.");
                sqlConnection.Close();
            }

            inputReset();
            Connect_Click(sender, e);
            
          
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM Clienti WHERE Cl_ID = @cl_ID", connection);
            dataAdapter.DeleteCommand.Parameters.Add("@cl_ID", SqlDbType.Int).Value = Int32.Parse(textBox_CL_ID.Text);

            try
            {
                connection.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted data successfully.");
                connection.Close();
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("The inserted data are not valid.");
                connection.Close();
            }   
               
            
            inputReset();
            Connect_Click(sender, e);
            
            
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.UpdateCommand = new SqlCommand("UPDATE Clienti" +
                " SET Name = @Name , Ad_ID = @Ad_ID" +
                " WHERE Cl_ID = @Cl_ID",
                connection);

    
            try
            {
                connection.Open();
                dataAdapter.UpdateCommand.Parameters.Add("@Cl_ID", SqlDbType.Int).Value = Int32.Parse(textBox_CL_ID.Text);
                dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox_Name.Text;
                dataAdapter.UpdateCommand.Parameters.Add("@Ad_ID", SqlDbType.Int).Value = Int32.Parse(textBoxAdresse_ID.Text);
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Updated data successfully.");
                connection.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Sie sollen ein valider Integer geben.");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie haben falsche Daten gegeben.");
                connection.Close();
            }
             
            inputReset();
            Connect_Click(sender, e);
        }
            
        
    }
}
