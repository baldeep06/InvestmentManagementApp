using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq; // For JSON parsing

namespace InvestmentManagementApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Investment fd = new Investment();
            fd.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // API key for Alpha Vantage
            string apiKey = "F62G7MD74SJY2AXC";

            // Get the stock ticker from a TextBox or any input field
            string ticker = textBox1.Text; // Assuming you have a TextBox named textBox1

            string shares = textBox2.Text;

            if (string.IsNullOrEmpty(ticker))
            {
                MessageBox.Show("Please enter a stock ticker in the text box below and then click this button again.");
                return;
            }

            // Build the API request URL
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={ticker}&interval=1min&apikey={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Fetch the data
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    JObject json = JObject.Parse(responseBody);
                    var timeSeries = json["Time Series (1min)"];
                    if (timeSeries != null)
                    {
                        // Get the most recent data point
                        var mostRecentTime = timeSeries.First.First;
                        var latestClose = mostRecentTime["4. close"].ToString();
                        var latestOpen = mostRecentTime["1. open"].ToString(); // Get the opening price
                        var latestTime = timeSeries.First.Path.Split(':')[1];

                        // Add data to the DataGridView
                        dataGridViewStocks.Rows.Add(shares, ticker, latestOpen, latestClose);
                    }
                    else
                    {
                        MessageBox.Show("Error fetching data. Please check the ticker and/or amount of shares.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddtoPort_Click(object sender, EventArgs e)
        {
            // API key for Alpha Vantage
            string apiKey = "F62G7MD74SJY2AXC";

            // Get the stock ticker from a TextBox or any input field
            string ticker = textBox1.Text; // Assuming you have a TextBox named textBox1

            if (string.IsNullOrEmpty(ticker))
            {
                MessageBox.Show("Please enter a stock ticker in the text box below and then click this button again.");
                return;
            }

            // Build the API request URL
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={ticker}&interval=1min&apikey={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Fetch the data
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    JObject json = JObject.Parse(responseBody);
                    var timeSeries = json["Time Series (1min)"];
                    if (timeSeries != null)
                    {
                        // Get the most recent data point
                        var mostRecentTime = timeSeries.First.First;
                        var latestClose = mostRecentTime["4. close"].ToString();
                        var latestOpen = mostRecentTime["1. open"].ToString(); // Get the opening price

                        // Show stock ticker, open price, and close price in a MessageBox
                        MessageBox.Show($"Ticker: {ticker}\nLast Close Price: {latestClose}\nLast Open Price: {latestOpen}");
                    }
                    else
                    {
                        MessageBox.Show("Error fetching data. Please check the ticker and try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridViewStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridViewStocks.SelectedRows.Count > 0)
            {
                // Confirm the deletion action
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected stock?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected row
                    foreach (DataGridViewRow row in dataGridViewStocks.SelectedRows)
                    {
                        dataGridViewStocks.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a stock to delete.");
            }
        }

        private void btnDelete2_Click_1(object sender, EventArgs e)
        {
            // Ensure that the DataGridView is not empty
            if (dataGridViewStocks.Rows.Count > 0)
            {
                // Ensure a row is selected
                if (dataGridViewStocks.SelectedRows.Count > 0)
                {
                    // Confirm deletion from the user
                    DialogResult result = MessageBox.Show("Are you sure you want to sell the selected stock?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Remove the selected row(s)
                        foreach (DataGridViewRow row in dataGridViewStocks.SelectedRows)
                        {
                            // Ensure row index is valid
                            if (!row.IsNewRow)
                            {
                                dataGridViewStocks.Rows.Remove(row);
                            }
                        }

                        // If using a DataSource, you may need to update it here
                        // Example: ((BindingList<YourDataType>)dataGridViewStocks.DataSource).Remove((YourDataType)row.DataBoundItem);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete and then click on the Sell Stock button again.");
                }
            }
            else
            {
                MessageBox.Show("The DataGridView is empty.");
            }
        }
    }
}
