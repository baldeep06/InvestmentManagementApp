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

namespace InvestmentManagementApp
{
    public partial class Investment : Form
    {
        public Investment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AADIT-LAPTOP;Initial Catalog=financedb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into investtab values(@investmentid,@stockticker,@price,@shares,@status)", con);
            cmd.Parameters.AddWithValue("@InvestmentId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("StockTicker", textBox2.Text);
            cmd.Parameters.AddWithValue("Price", textBox3.Text);
            cmd.Parameters.AddWithValue("Shares", textBox4.Text);
            cmd.Parameters.AddWithValue("Status", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AADIT-LAPTOP;Initial Catalog=financedb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from investtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AADIT-LAPTOP;Initial Catalog=financedb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update investtab set stockticker=@stockticker,price=@price,shares=@shares,status=@status where investmentid=@investmentid", con);
            cmd.Parameters.AddWithValue("@InvestmentId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("StockTicker", textBox2.Text);
            cmd.Parameters.AddWithValue("Price", textBox3.Text);
            cmd.Parameters.AddWithValue("Shares", textBox4.Text);
            cmd.Parameters.AddWithValue("Status", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AADIT-LAPTOP;Initial Catalog=financedb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete investtab where investmentid=@investmentid", con);
            cmd.Parameters.AddWithValue("@InvestmentId", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AADIT-LAPTOP;Initial Catalog=financedb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from investtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Investment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AADIT-LAPTOP;Initial Catalog=financedb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from investtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
