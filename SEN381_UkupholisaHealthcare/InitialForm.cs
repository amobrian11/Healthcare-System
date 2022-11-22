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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void btnPolicyMaintenance_Click(object sender, EventArgs e)
        {
           PolicyMaintenanceForm policyForm = new PolicyMaintenanceForm();
           policyForm.Show();
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMedicalDepartment_Click(object sender, EventArgs e)
        {
            MedicalDepartmentForm conditionForm = new MedicalDepartmentForm();
            conditionForm.Show();
        }

        private void btnProductMaintenance_Click(object sender, EventArgs e)
        {
            ProductMaintenanceForm prodForm = new ProductMaintenanceForm();
            prodForm.Show();
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            ClaimForm claimForm = new ClaimForm();
            claimForm.Show();
        }

        private void btnClientMaintenance_Click(object sender, EventArgs e)
        {
            ClientMaintenanceForm clientMaintenanceForm = new ClientMaintenanceForm();
            clientMaintenanceForm.Show();
        }

        private void btnProviderManagement_Click(object sender, EventArgs e)
        {
            ProviderManagementForm providerManagementForm = new ProviderManagementForm();
            providerManagementForm.Show();
        }
    }
}
