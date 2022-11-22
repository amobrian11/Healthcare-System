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
    public partial class ClaimForm : Form
    {
        public ClaimForm()
        {
            InitializeComponent();
        }
        Datahandler handler = new Datahandler();
        Claims claims = new Claims();
        private void btnSubmitClaim_Click(object sender, EventArgs e)
        {
            int claimID = int.Parse(txtClaimFClaimID.Text);
            string condition = txtClaimFConditionID.Text;
            string treatment = txtClaimFTreatmentID.Text;
            string provider = txtClaimFProviderID.Text;
            int clientID = int.Parse(txtClaimFClientID.Text);
            string status = txtClaimFStatus.Text;

            Claims claim = new Claims(claimID, condition, treatment, provider, clientID, status);



            if (handler.InsertClaim(claim))
            {
                MessageBox.Show("Claim Approved and successfully added");
            }
            else 
            {
                MessageBox.Show("Unsuccessful");
            }

        }
    }
}
