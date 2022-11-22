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
    public partial class ProductMaintenanceForm : Form
    {
        public ProductMaintenanceForm()
        {
            InitializeComponent();
        }

        Datahandler handler = new Datahandler();
        private void btnTreatmentInfoAdd_Click(object sender, EventArgs e)
        {
            int treatmentID = int.Parse(txtTreatmentInfoTreatmentID.Text);
            string treatmentName = txtTreatmentInfoTreatmentName.Text;


            Treatment treatment = new Treatment(treatmentID, treatmentName);

            if (handler.InsertTreatment(treatment))
            {
                MessageBox.Show("Treatment successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnTreatmentInfoUpdate_Click(object sender, EventArgs e)
        {
            int treatmentID = int.Parse(txtTreatmentInfoTreatmentID.Text);
            string treatmentName = txtTreatmentInfoTreatmentName.Text;


            Treatment treatment = new Treatment(treatmentID, treatmentName);

            if (handler.UpdateTreatment(treatment))
            {
                MessageBox.Show("Treatment successfully updated");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnTreatmentInfoDelete_Click(object sender, EventArgs e)
        {
            int treatmentID = int.Parse(txtTreatmentInfoTreatmentID.Text);
            string treatmentName = txtTreatmentInfoTreatmentName.Text;


            Treatment treatment = new Treatment(treatmentID, treatmentName);

            if (handler.DeleteTreatment(treatment))
            {
                MessageBox.Show("Treatment successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnTreatmentIDSearch_Click(object sender, EventArgs e)
        {
            int treatmentID = int.Parse(txtSearchTreatmentID.Text);

            dgvSearchedTreatment.DataSource = handler.SearchTreatment(treatmentID);
        }

        private void btnViewAllTreatments_Click(object sender, EventArgs e)
        {
            dgvViewAllTreatments.DataSource = handler.ViewAllTreatments();
        }

        private void dgvSearchedTreatment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSearchedTreatment.Rows[e.RowIndex];

                txtTreatmentInfoTreatmentID.Text = row.Cells["Treatment_ID"].Value.ToString();
                txtTreatmentInfoTreatmentName.Text = row.Cells["Treatment_name"].Value.ToString();

            }
        }

        private void dgvViewAllTreatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvViewAllTreatments.Rows[e.RowIndex];

                txtTreatmentInfoTreatmentID.Text = row.Cells["Treatment_ID"].Value.ToString();
                txtTreatmentInfoTreatmentName.Text = row.Cells["Treatment_name"].Value.ToString();

            }
        }

        private void btnTreatmentPolicyAdd_Click(object sender, EventArgs e)
        {
            int policyID = int.Parse(txtTreatmentPolicyPolicyID.Text);
            int treatmentID = int.Parse(txtTreatmentPolicyTreatmentID.Text);

            PolicyTreatmentPackage policyTreatment = new PolicyTreatmentPackage(policyID, treatmentID);

            if (handler.InsertTreatmentPolicy(policyTreatment))
            {
                MessageBox.Show("Policy treatment successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnTreatmentPolicyDelete_Click(object sender, EventArgs e)
        {
            int policyID = int.Parse(txtTreatmentPolicyPolicyID.Text);
            int treatmentID = int.Parse(txtTreatmentPolicyTreatmentID.Text);

            PolicyTreatmentPackage policyTreatment = new PolicyTreatmentPackage(policyID, treatmentID);

            if (handler.DeletePolicyTreatments(policyTreatment))
            {
                MessageBox.Show("Policy treatment successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnViewAllTreatmentsAndPolicies_Click(object sender, EventArgs e)
        {
            dgvTreatmentsAndPolicies.DataSource = handler.ViewAllPolicyTreatments();
            this.dgvTreatmentsAndPolicies.Columns["Policy_ID"].Visible = false;
            this.dgvTreatmentsAndPolicies.Columns["Treatment_ID"].Visible = false;
        }
    }
}
