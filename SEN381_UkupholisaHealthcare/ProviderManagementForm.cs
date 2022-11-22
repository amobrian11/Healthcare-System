using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa_Healthcare
{
    public partial class ProviderManagementForm : Form
    {
        public ProviderManagementForm()
        {
            InitializeComponent();
        }

        Datahandler handler = new Datahandler();
        private void btnProviderInfoAdd_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtProviderInfoProviderID.Text);
            string providerName = txtProviderInfoProviderName.Text;
            string status = txtProviderInfoProviderStatus.Text;
            string city = txtProviderCity.Text;
            string streetNumberAndName = txtProviderStreetNumAndName.Text;
            string postalCode = txtProviderPostalCode.Text;

            MedicalProvider provider = new MedicalProvider(providerID, providerName, status, city, streetNumberAndName, postalCode);

            if (handler.InsertProvider(provider))
            {
                MessageBox.Show("Provider successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnProviderInfoUpdate_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtProviderInfoProviderID.Text);
            string providerName = txtProviderInfoProviderName.Text;
            string status = txtProviderInfoProviderStatus.Text;
            string city = txtProviderCity.Text;
            string streetNumberAndName = txtProviderStreetNumAndName.Text;
            string postalCode = txtProviderPostalCode.Text;

            MedicalProvider provider = new MedicalProvider(providerID, providerName, status, city, streetNumberAndName, postalCode);

            if (handler.UpdateProvider(provider))
            {
                MessageBox.Show("Provider successfully updated");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnProviderInfoDelete_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtProviderInfoProviderID.Text);
            string providerName = txtProviderInfoProviderName.Text;
            string status = txtProviderInfoProviderStatus.Text;
            string city = txtProviderCity.Text;
            string streetNumberAndName = txtProviderStreetNumAndName.Text;
            string postalCode = txtProviderPostalCode.Text;

            MedicalProvider provider = new MedicalProvider(providerID, providerName, status, city, streetNumberAndName, postalCode);

            if (handler.DeleteProvider(provider))
            {
                MessageBox.Show("Provider successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnProviderIDSearch_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtSearchProviderID.Text);
            dgvSearchedProvider.DataSource = handler.SearchProvider(providerID);
        }

        private void btnViewAllProviders_Click(object sender, EventArgs e)
        {
            dgvViewAllProviders.DataSource = handler.ViewAllProviders();
        }

        private void dgvSearchedProvider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSearchedProvider.Rows[e.RowIndex];
             
                txtProviderInfoProviderID.Text = row.Cells["Provider_ID"].Value.ToString();
                txtProviderInfoProviderName.Text = row.Cells["Provider_Name"].Value.ToString();
                txtProviderInfoProviderStatus.Text = row.Cells["Provider_Status"].Value.ToString();
                txtProviderCity.Text = row.Cells["City"].Value.ToString();
                txtProviderStreetNumAndName.Text = row.Cells["Street_Number_Name"].Value.ToString();
                txtProviderPostalCode.Text = row.Cells["Postal_Code"].Value.ToString();


            }
        }

        private void dgvViewAllProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvViewAllProviders.Rows[e.RowIndex];

                txtProviderInfoProviderID.Text = row.Cells["Provider_ID"].Value.ToString();
                txtProviderInfoProviderName.Text = row.Cells["Provider_Name"].Value.ToString();
                txtProviderInfoProviderStatus.Text = row.Cells["Provider_Status"].Value.ToString();
                txtProviderCity.Text = row.Cells["City"].Value.ToString();
                txtProviderStreetNumAndName.Text = row.Cells["Street_Number_Name"].Value.ToString();
                txtProviderPostalCode.Text = row.Cells["Postal_Code"].Value.ToString();


            }
        }

        private void btnTreatmentProviderAdd_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtTreatmentProviderProviderID.Text);
            int treatmentID = int.Parse(txtTreatmentProviderTreatmentID.Text);

            TreatmentProvider treatmentProvider = new TreatmentProvider(providerID, treatmentID);

            if (handler.InsertTreatmentProvider(treatmentProvider))
            {
                MessageBox.Show("Treatment provider successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnTreatmentProviderDelete_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtTreatmentProviderProviderID.Text);
            int treatmentID = int.Parse(txtTreatmentProviderTreatmentID.Text);

            TreatmentProvider treatmentProvider = new TreatmentProvider(providerID, treatmentID);

            if (handler.DeleteTreatmentProvider(treatmentProvider))
            {
                MessageBox.Show("Treatment provider successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnViewAllProvidersAndTreatments_Click(object sender, EventArgs e)
        {
            dgvProvidersAndTreatments.DataSource = handler.ViewAllTreatmentProviders();
            this.dgvProvidersAndTreatments.Columns["Provider_ID"].Visible = false;
            this.dgvProvidersAndTreatments.Columns["Treatment_ID"].Visible = false;
        }
    }
}
