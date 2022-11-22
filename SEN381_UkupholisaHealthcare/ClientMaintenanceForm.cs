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
    public partial class ClientMaintenanceForm : Form
    {
        public ClientMaintenanceForm()
        {
            InitializeComponent();
        }

        Datahandler handler = new Datahandler();
        private void btnClientMAdd_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientMaintClientID.Text);
            string nationalID = txtClientMNationalID.Text;
            string memberSatus = txtClientMMemberStatus.Text;
            string firstName = txtClientMaintFirstName.Text;
            string lastName = txtClientMaintLastName.Text;
            string dob = txtClientMDOB.Text;
            string streetNumberAndName = txtClientStreetNameAndNumber.Text;
            string cityName = txtClientCity.Text;
            string postalCode = txtClientPostalCode.Text;
            string cellNumber = txtClientMCellNum.Text;
            string email = txtClientMEmail.Text;
            int policyID = int.Parse(txtClientMPolicyID.Text);

            Client client = new Client(clientID, nationalID, memberSatus, firstName, lastName, dob, streetNumberAndName, cityName, postalCode, cellNumber, email, policyID);

            if (handler.InsertClient(client))
            {
                MessageBox.Show("Client successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientMUpdate_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientMaintClientID.Text);
            string nationalID = txtClientMNationalID.Text;
            string memberSatus = txtClientMMemberStatus.Text;
            string firstName = txtClientMaintFirstName.Text;
            string lastName = txtClientMaintLastName.Text;
            string dob = txtClientMDOB.Text;
            string streetNumberAndName = txtClientStreetNameAndNumber.Text;
            string cityName = txtClientCity.Text;
            string postalCode = txtClientPostalCode.Text;
            string cellNumber = txtClientMCellNum.Text;
            string email = txtClientMEmail.Text;
            int policyID = int.Parse(txtClientMPolicyID.Text);

            Client client = new Client(clientID, nationalID, memberSatus, firstName, lastName, dob, streetNumberAndName, cityName, postalCode, cellNumber, email, policyID);

            if (handler.UpdateClient(client))
            {
                MessageBox.Show("Client successfully updated");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientMDelete_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientMaintClientID.Text);
            string nationalID = txtClientMNationalID.Text;
            string memberSatus = txtClientMMemberStatus.Text;
            string firstName = txtClientMaintFirstName.Text;
            string lastName = txtClientMaintLastName.Text;
            string dob = txtClientMDOB.Text;
            string streetNumberAndName = txtClientStreetNameAndNumber.Text;
            string cityName = txtClientCity.Text;
            string postalCode = txtClientPostalCode.Text;
            string cellNumber = txtClientMCellNum.Text;
            string email = txtClientMEmail.Text;
            int policyID = int.Parse(txtClientMPolicyID.Text);

            Client client = new Client(clientID, nationalID, memberSatus, firstName, lastName, dob, streetNumberAndName, cityName, postalCode, cellNumber, email, policyID);

            if (handler.DeleteClient(client))
            {
                MessageBox.Show("Client successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientMSearchID_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtSearchClientID.Text);

            dgvClientMSearchClient.DataSource = handler.SearchClient(clientID);
        }

        private void btnViewAllClients_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.ViewAllClients();
        }

        private void dgvClientMSearchClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClientMSearchClient.Rows[e.RowIndex];

                
                txtClientMaintClientID.Text = row.Cells["Client_ID"].Value.ToString();
                txtClientMNationalID.Text = row.Cells["National_ID"].Value.ToString();
                txtClientMMemberStatus.Text = row.Cells["Member_Status"].Value.ToString();
                txtClientMaintFirstName.Text = row.Cells["First_Name"].Value.ToString();
                txtClientMaintLastName.Text = row.Cells["Last_Name"].Value.ToString();
                txtClientMDOB.Text = row.Cells["DOB"].Value.ToString();
                txtClientStreetNameAndNumber.Text = row.Cells["Street_Number_Name"].Value.ToString();
                txtClientCity.Text = row.Cells["City"].Value.ToString();
                txtClientPostalCode.Text = row.Cells["Postal_Code"].Value.ToString();
                txtClientMCellNum.Text = row.Cells["Cell_Number"].Value.ToString();
                txtClientMEmail.Text = row.Cells["Email"].Value.ToString();
                txtClientMPolicyID.Text = row.Cells["Policy_ID"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


                txtClientMaintClientID.Text = row.Cells["Client_ID"].Value.ToString();
                txtClientMNationalID.Text = row.Cells["National_ID"].Value.ToString();
                txtClientMMemberStatus.Text = row.Cells["Member_Status"].Value.ToString();
                txtClientMaintFirstName.Text = row.Cells["First_Name"].Value.ToString();
                txtClientMaintLastName.Text = row.Cells["Last_Name"].Value.ToString();
                txtClientMDOB.Text = row.Cells["DOB"].Value.ToString();
                txtClientStreetNameAndNumber.Text = row.Cells["Street_Number_Name"].Value.ToString();
                txtClientCity.Text = row.Cells["City"].Value.ToString();
                txtClientPostalCode.Text = row.Cells["Postal_Code"].Value.ToString();
                txtClientMCellNum.Text = row.Cells["Cell_Number"].Value.ToString();
                txtClientMEmail.Text = row.Cells["Email"].Value.ToString();
                txtClientMPolicyID.Text = row.Cells["Policy_ID"].Value.ToString();

            }
        }

        private void btnProviderClientAdd_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtProviderClientProviderID.Text);
            int clientID = int.Parse(txtProviderClientClientID.Text);

            ProviderForClient providerForClient = new ProviderForClient(providerID, clientID);

            if (handler.InsertProviderClient(providerForClient))
            {
                MessageBox.Show("Provider for client successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnProviderClientDelete_Click(object sender, EventArgs e)
        {
            int providerID = int.Parse(txtProviderClientProviderID.Text);
            int clientID = int.Parse(txtProviderClientClientID.Text);

            ProviderForClient providerForClient = new ProviderForClient(providerID, clientID);

            if (handler.DeleteProviderClient(providerForClient))
            {
                MessageBox.Show("Provider for client successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientConditionAdd_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientConditionClientID.Text);
            int conditionID = int.Parse(txtClientConditionConditionID.Text);

            ClientCondition clientCondition = new ClientCondition(clientID, conditionID);

            if (handler.InsertClientCondition(clientCondition))
            {
                MessageBox.Show("Client condition successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientConditionDelete_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientConditionClientID.Text);
            int conditionID = int.Parse(txtClientConditionConditionID.Text);

            ClientCondition clientCondition = new ClientCondition(clientID, conditionID);

            if (handler.DeleteClientCondition(clientCondition))
            {
                MessageBox.Show("Client condition successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientTreatmentAdd_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientTreatmentClientID.Text);
            int treatmentID = int.Parse(txtClientTreatmentTreatmentID.Text);

            ClientTreatment clientTreatment = new ClientTreatment(clientID, treatmentID);

            if (handler.InsertClientTreatment(clientTreatment))
            {
                MessageBox.Show("Client treatment successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnClientTreatmentDelete_Click(object sender, EventArgs e)
        {
            int clientID = int.Parse(txtClientTreatmentClientID.Text);
            int treatmentID = int.Parse(txtClientTreatmentTreatmentID.Text);

            ClientTreatment clientTreatment = new ClientTreatment(clientID, treatmentID);

            if (handler.DeleteClientTreatment(clientTreatment))
            {
                MessageBox.Show("Client treatment successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnViewAllClientsAndConditions_Click(object sender, EventArgs e)
        {
            dgvClientsAndConditions.DataSource = handler.ViewAllClientsAndConditions();
            this.dgvClientsAndConditions.Columns["Client_ID"].Visible = false;
            this.dgvClientsAndConditions.Columns["Condition_ID"].Visible = false;
            this.dgvClientsAndConditions.Columns["National_ID"].Visible = false;
            this.dgvClientsAndConditions.Columns["Member_Status"].Visible = false;
            this.dgvClientsAndConditions.Columns["DOB"].Visible = false;
            this.dgvClientsAndConditions.Columns["Email"].Visible = false;
            this.dgvClientsAndConditions.Columns["Policy_ID"].Visible = false;
            this.dgvClientsAndConditions.Columns["Street_Number_Name"].Visible = false;
            this.dgvClientsAndConditions.Columns["Cell_Number"].Visible = false;
            this.dgvClientsAndConditions.Columns["Postal_Code"].Visible = false;
        }

        private void btnViewAllClientsAndProviders_Click(object sender, EventArgs e)
        {
            dgvViewClientsAndProviders.DataSource = handler.ViewAllClientsAndProviders();
            this.dgvViewClientsAndProviders.Columns["Client_ID"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Provider_ID"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["National_ID"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Member_Status"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["DOB"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Email"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Policy_ID"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Street_Number_Name"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Cell_Number"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Postal_Code"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Street_Number_Name1"].Visible = false;
            this.dgvViewClientsAndProviders.Columns["Postal_Code1"].Visible = false;
        }

        private void btnViewAllClientsAndTreatments_Click(object sender, EventArgs e)
        {
            dgvClientsAndTreatments.DataSource = handler.ViewAllClientsAndTreatments();
            this.dgvClientsAndTreatments.Columns["Client_ID"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Treatment_ID"].Visible = false;
            this.dgvClientsAndTreatments.Columns["National_ID"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Member_Status"].Visible = false;
            this.dgvClientsAndTreatments.Columns["DOB"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Email"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Policy_ID"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Street_Number_Name"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Cell_Number"].Visible = false;
            this.dgvClientsAndTreatments.Columns["Postal_Code"].Visible = false;
           
        }

        private void btnViewAllClientsAndPolicies_Click(object sender, EventArgs e)
        {
            dgvClientsAndPolicies.DataSource = handler.ViewAllClientsAndPolicies();                 
            this.dgvClientsAndPolicies.Columns["National_ID"].Visible = false;
            this.dgvClientsAndPolicies.Columns["Member_Status"].Visible = false;
            this.dgvClientsAndPolicies.Columns["DOB"].Visible = false;
            this.dgvClientsAndPolicies.Columns["Email"].Visible = false;            
            this.dgvClientsAndPolicies.Columns["Street_Number_Name"].Visible = false;
            this.dgvClientsAndPolicies.Columns["Cell_Number"].Visible = false;
            this.dgvClientsAndPolicies.Columns["Postal_Code"].Visible = false;
            this.dgvClientsAndPolicies.Columns["City"].Visible = false;
            this.dgvClientsAndPolicies.Columns["Policy_ID"].Visible = false;
        }
    }
}
