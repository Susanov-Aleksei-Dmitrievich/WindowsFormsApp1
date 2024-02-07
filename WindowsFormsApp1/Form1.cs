using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        DataSet ds;

        void PolH()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-LJ3RRK0; Initial Catalog=ToursBase; Integrated Security=True");
            da = new SqlDataAdapter("Select Name AS [Отели], CountOfStars AS [Звёзды], CountryCode AS [Страны] From Hotel", con);

            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Hotel");
            dataGridView1.DataSource = ds.Tables["Hotel"];
            con.Close();

        }
        

        
        
        
        

       
        
           

            

            
            
            
            
            

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PolH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }
    }
}
