using GenericParsing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LicenseCalculator
{
    public partial class LicenseCalculator : Form
    {
        string appName = "Licence Calculator";
        public LicenseCalculator()
        {
            InitializeComponent();
        }

        private void LicenseCalculator_Load(object sender, EventArgs e)
        {
            lblLicenseRequired.Visible = false;
            lblResult.Visible = false;
            lblResult.Text = "";
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV (Comma Delimited)|*.csv" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {   
                    txtFileName.Text = openFileDialog.FileName;
                    lblResult.Text = String.Format("(Calculate the license from file {0})", openFileDialog.SafeFileName);
                    lblLicenseRequired.Visible = true;
                    lblResult.Visible = true;

                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;

            if(txtFileName.Text == String.Empty)
            {
                MessageBox.Show("Please select a filename", appName , MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCalculate.Enabled = true;
                return;
            }
            if (!File.Exists(txtFileName.Text))
            {
                MessageBox.Show("Selected file doesn't exists. Please select a valid file", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCalculate.Enabled = true;
                return;
            }

            if (txtApplicationID.Text == String.Empty)
            {
                MessageBox.Show("Please enter an Application ID", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCalculate.Enabled = true;
                return;
            }

            CsvProcessor csvProcessor = new CsvProcessor();
            List<LicenseDetails> lstLicenseData;

            try
            {
                lstLicenseData = csvProcessor.loadCSV(txtFileName.Text, txtApplicationID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCalculate.Enabled = true;
                return;
            }

            if(lstLicenseData.Count == 0)
            {
                MessageBox.Show("Could not find any record for application ID - " + txtApplicationID.Text, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var totalLicense = csvProcessor.processRecords(lstLicenseData);

            lblResult.Text = totalLicense.ToString();
            btnCalculate.Enabled = true;
        }
    }
}
