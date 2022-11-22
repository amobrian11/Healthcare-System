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
    public partial class PolicyMaintenanceForm : Form
    {
        public PolicyMaintenanceForm()
        {
            InitializeComponent();
        }

        Datahandler handler = new Datahandler();

        private void btnPolicyMaintAdd_Click(object sender, EventArgs e)
        {
            int PolicyID = int.Parse(txtPolicyMaintPolicyID.Text);
            string PackageTear = txtPolicyMaintPackageTear.Text;
            string PackageType = txtPolicyMaintPackageType.Text;
            string PackageStatus = txtPolicyMaintPackageStatus.Text;
            double Price = double.Parse(txtPolicyMaintPrice.Text);

            Policy policy = new Policy(PolicyID, PackageTear, PackageType, PackageStatus, Price);

            if(handler.InsertPolicy(policy))
            {
                MessageBox.Show("Policy successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnPolicyMaintUpdate_Click(object sender, EventArgs e)
        {
            int PolicyID = int.Parse(txtPolicyMaintPolicyID.Text);
            string PackageTear = txtPolicyMaintPackageTear.Text;
            string PackageType = txtPolicyMaintPackageType.Text;
            string PackageStatus = txtPolicyMaintPackageStatus.Text;
            double Price = double.Parse(txtPolicyMaintPrice.Text);

            Policy policy = new Policy(PolicyID, PackageTear, PackageType, PackageStatus, Price);

            if (handler.UpdatePolicy(policy))
            {
                MessageBox.Show("Policy successfully updated");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnPolicyMaintDelete_Click(object sender, EventArgs e)
        {
            int PolicyID = int.Parse(txtPolicyMaintPolicyID.Text);
            string PackageTear = txtPolicyMaintPackageTear.Text;
            string PackageType = txtPolicyMaintPackageType.Text;
            string PackageStatus = txtPolicyMaintPackageStatus.Text;
            double Price = double.Parse(txtPolicyMaintPrice.Text);

            Policy policy = new Policy(PolicyID, PackageTear, PackageType, PackageStatus, Price);

            if (handler.DeletePolicy(policy))
            {
                MessageBox.Show("Policy successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnPolicyMaintViewAllPolicies_Click(object sender, EventArgs e)
        {
            dgvPolicyMaintViewAll.DataSource = handler.ViewAllPolicies();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPolicyMaintSearch_Click(object sender, EventArgs e)
        {
            int policyID = int.Parse(txtSearchPolicyID.Text);

            dgvPolicyMaintSearchPolicy.DataSource = handler.SearchPolicy(policyID);
        }

        private void dgvPolicyMaintViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPolicyMaintViewAll.Rows[e.RowIndex];

                txtPolicyMaintPolicyID.Text = row.Cells["Policy_ID"].Value.ToString();
                txtPolicyMaintPackageTear.Text = row.Cells["Package_tear"].Value.ToString();
                txtPolicyMaintPackageType.Text = row.Cells["Package_type"].Value.ToString();
                txtPolicyMaintPackageStatus.Text = row.Cells["Package_Status"].Value.ToString();
                txtPolicyMaintPrice.Text = row.Cells["Price"].Value.ToString();

            }
        }

        private void dgvPolicyMaintSearchPolicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPolicyMaintSearchPolicy.Rows[e.RowIndex];

                txtPolicyMaintPolicyID.Text = row.Cells["Policy_ID"].Value.ToString();
                txtPolicyMaintPackageTear.Text = row.Cells["Package_tear"].Value.ToString();
                txtPolicyMaintPackageType.Text = row.Cells["Package_type"].Value.ToString();
                txtPolicyMaintPackageStatus.Text = row.Cells["Package_Status"].Value.ToString();
                txtPolicyMaintPrice.Text = row.Cells["Price"].Value.ToString();

            }
        }
    }
}
