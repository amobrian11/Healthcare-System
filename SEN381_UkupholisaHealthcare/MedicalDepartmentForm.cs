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
    public partial class MedicalDepartmentForm : Form
    {
        public MedicalDepartmentForm()
        {
            InitializeComponent();
        }

        Datahandler handler = new Datahandler();
        private void btnConditionInfoAdd_Click(object sender, EventArgs e)
        {
            int conditionID = int.Parse(txtConditionInfoConditionID.Text);
            string conditionName = txtConditionInfoConditionName.Text;


            MedicalCondition condition = new MedicalCondition(conditionID, conditionName);

            if (handler.InsertCondition(condition)) 
            {
                MessageBox.Show("Condition successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnConditionInfoUpdate_Click(object sender, EventArgs e)
        {
            int conditionID = int.Parse(txtConditionInfoConditionID.Text);
            string conditionName = txtConditionInfoConditionName.Text;


            MedicalCondition condition = new MedicalCondition(conditionID, conditionName);

            if (handler.UpdateCondition(condition))
            {
                MessageBox.Show("Condition successfully updated");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnConditionInfoDelete_Click(object sender, EventArgs e)
        {
            int conditionID = int.Parse(txtConditionInfoConditionID.Text);
            string conditionName = txtConditionInfoConditionName.Text;


            MedicalCondition condition = new MedicalCondition(conditionID, conditionName);

            if (handler.DeleteCondition(condition))
            {
                MessageBox.Show("Condition successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnViewAllConditions_Click(object sender, EventArgs e)
        {
            dgvViewAllConditions.DataSource = handler.ViewAllConditions();
        }

        private void btnConditionIDSearch_Click(object sender, EventArgs e)
        {
            int conditionID = int.Parse(txtSearchConditionID.Text);

            dgvSearchedCondition.DataSource = handler.SearchCondition(conditionID);
        }

        private void dgvSearchedCondition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSearchedCondition.Rows[e.RowIndex];

                txtConditionInfoConditionID.Text = row.Cells["Condition_ID"].Value.ToString();
                txtConditionInfoConditionName.Text = row.Cells["Condition_name"].Value.ToString();

            }
        }

        private void dgvViewAllConditions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvViewAllConditions.Rows[e.RowIndex];

                txtConditionInfoConditionID.Text = row.Cells["Condition_ID"].Value.ToString();
                txtConditionInfoConditionName.Text = row.Cells["Condition_name"].Value.ToString();

            }
        }

        private void btnConditionTreatmentAdd_Click(object sender, EventArgs e)
        {
            int treatmentID1 = int.Parse(txtConditionTreatmentTreatmentID.Text);
            int conditionID1 = int.Parse(txtConditionTreatmentConditionID.Text);

            ConditionTreatment conditionTreatment = new ConditionTreatment(treatmentID1, conditionID1);

            if (handler.InsertConditionTreatment(conditionTreatment))
            {
                MessageBox.Show("Condition and its Treatment successfully added");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void btnViewAllConditionsAndTreatments_Click(object sender, EventArgs e)
        {
            dgvConditionsAndTreatments.DataSource = handler.ViewAllConditionsAndTreatments();
            this.dgvConditionsAndTreatments.Columns["Condition_ID"].Visible = false;
            this.dgvConditionsAndTreatments.Columns["Treatment_ID"].Visible = false;
        }

        private void btnConditionTreatmentDelete_Click(object sender, EventArgs e)
        {
            int treatmentID1 = int.Parse(txtConditionTreatmentTreatmentID.Text);
            int conditionID1 = int.Parse(txtConditionTreatmentConditionID.Text);

            ConditionTreatment conditionTreatment = new ConditionTreatment(treatmentID1, conditionID1);

            if (handler.DeleteConditionTreatment(conditionTreatment))
            {
                MessageBox.Show("Condition and Treatment successfully deleted");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }


        private void dgvConditionsAndTreatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
