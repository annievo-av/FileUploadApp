using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUploadApp
{
    public partial class FileUploadAppForm : Form
    {
        public FileUploadAppForm()
        {
            InitializeComponent();
        }

        private void FileUploadAppForm_Load(object sender, EventArgs e)
        {

        }

        private void processing_Click(object sender, EventArgs e)
        {
            link1.Visible = link2.Visible = link3.Visible = link4.Visible =
                link5.Visible = link6.Visible = true;

            link7.Visible = link8.Visible = false;
        }

        private void reporting_Click(object sender, EventArgs e)
        {
            link1.Visible = link2.Visible = link3.Visible = link4.Visible =
                link5.Visible = link6.Visible = link8.Visible = false;

            link7.Visible = true;

            // must be link6 - verified
            if (link6.Enabled)
            {
                link7.Enabled = true;
            }
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            link1.Visible = link2.Visible = link3.Visible = link4.Visible =
                link5.Visible = link6.Visible = link7.Visible = false;

            link8.Visible = true;

            // must be link6 - verified
            if (link6.Enabled)
            {
                link8.Enabled = true;
            }
        }

        private void setUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link2.Enabled = link2.Visible;
            link3.Enabled = link3.Visible;
        }

        private void buildVendor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void reviewVendor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VendorInformation vendorInformation = new VendorInformation();
            vendorInformation.ShowDialog();

            // if (vendorInformation Validated)
            link4.Enabled = link4.Visible;
            link5.Enabled = link5.Visible;
            link6.Enabled = link6.Visible;
        }

        private void printTnn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void uploadTnn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessingForm processingForm = new ProcessingForm();
            processingForm.Show();
        }

        private void update_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link7.Enabled = link7.Visible;
            link8.Enabled = link8.Visible;
        }

        private void storeTnn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportingForm reportingForm = new ReportingForm();
            reportingForm.ShowDialog();
        }

        private void exportTnn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
