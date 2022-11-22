
namespace Ukupholisa_Healthcare
{
    partial class PolicyMaintenanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPolicyMaintSearchPolicy = new System.Windows.Forms.DataGridView();
            this.btnPolicyMaintSearch = new System.Windows.Forms.Button();
            this.txtSearchPolicyID = new System.Windows.Forms.TextBox();
            this.lblEnterPolicyID = new System.Windows.Forms.Label();
            this.lblSearchPolicy = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPolicyMaintViewAll = new System.Windows.Forms.DataGridView();
            this.btnPolicyMaintViewAllPolicies = new System.Windows.Forms.Button();
            this.lblViewAllPolicies = new System.Windows.Forms.Label();
            this.lblPolicyInfor = new System.Windows.Forms.Label();
            this.lblPolicyMaintFPolicyID = new System.Windows.Forms.Label();
            this.lblPolicyMaintFPackageStatus = new System.Windows.Forms.Label();
            this.lblPolicyMainFPackageType = new System.Windows.Forms.Label();
            this.lblPolicyMainPackageTear = new System.Windows.Forms.Label();
            this.lblPolicyMaintFPrice = new System.Windows.Forms.Label();
            this.txtPolicyMaintPolicyID = new System.Windows.Forms.TextBox();
            this.txtPolicyMaintPackageTear = new System.Windows.Forms.TextBox();
            this.txtPolicyMaintPackageType = new System.Windows.Forms.TextBox();
            this.txtPolicyMaintPackageStatus = new System.Windows.Forms.TextBox();
            this.txtPolicyMaintPrice = new System.Windows.Forms.TextBox();
            this.btnPolicyMaintAdd = new System.Windows.Forms.Button();
            this.btnPolicyMaintUpdate = new System.Windows.Forms.Button();
            this.btnPolicyMaintDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyMaintSearchPolicy)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyMaintViewAll)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.dgvPolicyMaintSearchPolicy);
            this.panel2.Controls.Add(this.btnPolicyMaintSearch);
            this.panel2.Controls.Add(this.txtSearchPolicyID);
            this.panel2.Controls.Add(this.lblEnterPolicyID);
            this.panel2.Controls.Add(this.lblSearchPolicy);
            this.panel2.Location = new System.Drawing.Point(369, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 237);
            this.panel2.TabIndex = 1;
            // 
            // dgvPolicyMaintSearchPolicy
            // 
            this.dgvPolicyMaintSearchPolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyMaintSearchPolicy.Location = new System.Drawing.Point(3, 75);
            this.dgvPolicyMaintSearchPolicy.Name = "dgvPolicyMaintSearchPolicy";
            this.dgvPolicyMaintSearchPolicy.Size = new System.Drawing.Size(453, 150);
            this.dgvPolicyMaintSearchPolicy.TabIndex = 15;
            this.dgvPolicyMaintSearchPolicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicyMaintSearchPolicy_CellContentClick);
            // 
            // btnPolicyMaintSearch
            // 
            this.btnPolicyMaintSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyMaintSearch.Location = new System.Drawing.Point(330, 30);
            this.btnPolicyMaintSearch.Name = "btnPolicyMaintSearch";
            this.btnPolicyMaintSearch.Size = new System.Drawing.Size(82, 32);
            this.btnPolicyMaintSearch.TabIndex = 14;
            this.btnPolicyMaintSearch.Text = "SEARCH";
            this.btnPolicyMaintSearch.UseVisualStyleBackColor = true;
            this.btnPolicyMaintSearch.Click += new System.EventHandler(this.btnPolicyMaintSearch_Click);
            // 
            // txtSearchPolicyID
            // 
            this.txtSearchPolicyID.Location = new System.Drawing.Point(119, 37);
            this.txtSearchPolicyID.Name = "txtSearchPolicyID";
            this.txtSearchPolicyID.Size = new System.Drawing.Size(167, 20);
            this.txtSearchPolicyID.TabIndex = 14;
            // 
            // lblEnterPolicyID
            // 
            this.lblEnterPolicyID.AutoSize = true;
            this.lblEnterPolicyID.Location = new System.Drawing.Point(14, 40);
            this.lblEnterPolicyID.Name = "lblEnterPolicyID";
            this.lblEnterPolicyID.Size = new System.Drawing.Size(80, 13);
            this.lblEnterPolicyID.TabIndex = 14;
            this.lblEnterPolicyID.Text = "Enter Policy ID:";
            // 
            // lblSearchPolicy
            // 
            this.lblSearchPolicy.AutoSize = true;
            this.lblSearchPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPolicy.Location = new System.Drawing.Point(14, 9);
            this.lblSearchPolicy.Name = "lblSearchPolicy";
            this.lblSearchPolicy.Size = new System.Drawing.Size(138, 18);
            this.lblSearchPolicy.TabIndex = 1;
            this.lblSearchPolicy.Text = "Search for Policy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.dgvPolicyMaintViewAll);
            this.panel3.Controls.Add(this.btnPolicyMaintViewAllPolicies);
            this.panel3.Controls.Add(this.lblViewAllPolicies);
            this.panel3.Location = new System.Drawing.Point(12, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 227);
            this.panel3.TabIndex = 2;
            // 
            // dgvPolicyMaintViewAll
            // 
            this.dgvPolicyMaintViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyMaintViewAll.Location = new System.Drawing.Point(3, 72);
            this.dgvPolicyMaintViewAll.Name = "dgvPolicyMaintViewAll";
            this.dgvPolicyMaintViewAll.Size = new System.Drawing.Size(810, 146);
            this.dgvPolicyMaintViewAll.TabIndex = 16;
            this.dgvPolicyMaintViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicyMaintViewAll_CellContentClick);
            // 
            // btnPolicyMaintViewAllPolicies
            // 
            this.btnPolicyMaintViewAllPolicies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyMaintViewAllPolicies.Location = new System.Drawing.Point(360, 34);
            this.btnPolicyMaintViewAllPolicies.Name = "btnPolicyMaintViewAllPolicies";
            this.btnPolicyMaintViewAllPolicies.Size = new System.Drawing.Size(82, 32);
            this.btnPolicyMaintViewAllPolicies.TabIndex = 14;
            this.btnPolicyMaintViewAllPolicies.Text = "VIEW";
            this.btnPolicyMaintViewAllPolicies.UseVisualStyleBackColor = true;
            this.btnPolicyMaintViewAllPolicies.Click += new System.EventHandler(this.btnPolicyMaintViewAllPolicies_Click);
            // 
            // lblViewAllPolicies
            // 
            this.lblViewAllPolicies.AutoSize = true;
            this.lblViewAllPolicies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllPolicies.Location = new System.Drawing.Point(342, 13);
            this.lblViewAllPolicies.Name = "lblViewAllPolicies";
            this.lblViewAllPolicies.Size = new System.Drawing.Size(131, 18);
            this.lblViewAllPolicies.TabIndex = 2;
            this.lblViewAllPolicies.Text = "View All Policies";
            // 
            // lblPolicyInfor
            // 
            this.lblPolicyInfor.AutoSize = true;
            this.lblPolicyInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyInfor.Location = new System.Drawing.Point(13, 9);
            this.lblPolicyInfor.Name = "lblPolicyInfor";
            this.lblPolicyInfor.Size = new System.Drawing.Size(144, 18);
            this.lblPolicyInfor.TabIndex = 0;
            this.lblPolicyInfor.Text = "Policy Information";
            // 
            // lblPolicyMaintFPolicyID
            // 
            this.lblPolicyMaintFPolicyID.AutoSize = true;
            this.lblPolicyMaintFPolicyID.Location = new System.Drawing.Point(13, 40);
            this.lblPolicyMaintFPolicyID.Name = "lblPolicyMaintFPolicyID";
            this.lblPolicyMaintFPolicyID.Size = new System.Drawing.Size(52, 13);
            this.lblPolicyMaintFPolicyID.TabIndex = 1;
            this.lblPolicyMaintFPolicyID.Text = "Policy ID:";
            // 
            // lblPolicyMaintFPackageStatus
            // 
            this.lblPolicyMaintFPackageStatus.AutoSize = true;
            this.lblPolicyMaintFPackageStatus.Location = new System.Drawing.Point(13, 129);
            this.lblPolicyMaintFPackageStatus.Name = "lblPolicyMaintFPackageStatus";
            this.lblPolicyMaintFPackageStatus.Size = new System.Drawing.Size(86, 13);
            this.lblPolicyMaintFPackageStatus.TabIndex = 2;
            this.lblPolicyMaintFPackageStatus.Text = "Package Status:";
            // 
            // lblPolicyMainFPackageType
            // 
            this.lblPolicyMainFPackageType.AutoSize = true;
            this.lblPolicyMainFPackageType.Location = new System.Drawing.Point(13, 97);
            this.lblPolicyMainFPackageType.Name = "lblPolicyMainFPackageType";
            this.lblPolicyMainFPackageType.Size = new System.Drawing.Size(80, 13);
            this.lblPolicyMainFPackageType.TabIndex = 3;
            this.lblPolicyMainFPackageType.Text = "Package Type:";
            // 
            // lblPolicyMainPackageTear
            // 
            this.lblPolicyMainPackageTear.AutoSize = true;
            this.lblPolicyMainPackageTear.Location = new System.Drawing.Point(13, 68);
            this.lblPolicyMainPackageTear.Name = "lblPolicyMainPackageTear";
            this.lblPolicyMainPackageTear.Size = new System.Drawing.Size(78, 13);
            this.lblPolicyMainPackageTear.TabIndex = 4;
            this.lblPolicyMainPackageTear.Text = "Package Tear:";
            // 
            // lblPolicyMaintFPrice
            // 
            this.lblPolicyMaintFPrice.AutoSize = true;
            this.lblPolicyMaintFPrice.Location = new System.Drawing.Point(13, 160);
            this.lblPolicyMaintFPrice.Name = "lblPolicyMaintFPrice";
            this.lblPolicyMaintFPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPolicyMaintFPrice.TabIndex = 5;
            this.lblPolicyMaintFPrice.Text = "Price:";
            // 
            // txtPolicyMaintPolicyID
            // 
            this.txtPolicyMaintPolicyID.Location = new System.Drawing.Point(132, 37);
            this.txtPolicyMaintPolicyID.Name = "txtPolicyMaintPolicyID";
            this.txtPolicyMaintPolicyID.Size = new System.Drawing.Size(167, 20);
            this.txtPolicyMaintPolicyID.TabIndex = 6;
            // 
            // txtPolicyMaintPackageTear
            // 
            this.txtPolicyMaintPackageTear.Location = new System.Drawing.Point(132, 65);
            this.txtPolicyMaintPackageTear.Name = "txtPolicyMaintPackageTear";
            this.txtPolicyMaintPackageTear.Size = new System.Drawing.Size(167, 20);
            this.txtPolicyMaintPackageTear.TabIndex = 7;
            // 
            // txtPolicyMaintPackageType
            // 
            this.txtPolicyMaintPackageType.Location = new System.Drawing.Point(132, 94);
            this.txtPolicyMaintPackageType.Name = "txtPolicyMaintPackageType";
            this.txtPolicyMaintPackageType.Size = new System.Drawing.Size(167, 20);
            this.txtPolicyMaintPackageType.TabIndex = 8;
            // 
            // txtPolicyMaintPackageStatus
            // 
            this.txtPolicyMaintPackageStatus.Location = new System.Drawing.Point(132, 126);
            this.txtPolicyMaintPackageStatus.Name = "txtPolicyMaintPackageStatus";
            this.txtPolicyMaintPackageStatus.Size = new System.Drawing.Size(167, 20);
            this.txtPolicyMaintPackageStatus.TabIndex = 9;
            // 
            // txtPolicyMaintPrice
            // 
            this.txtPolicyMaintPrice.Location = new System.Drawing.Point(132, 157);
            this.txtPolicyMaintPrice.Name = "txtPolicyMaintPrice";
            this.txtPolicyMaintPrice.Size = new System.Drawing.Size(167, 20);
            this.txtPolicyMaintPrice.TabIndex = 10;
            // 
            // btnPolicyMaintAdd
            // 
            this.btnPolicyMaintAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyMaintAdd.Location = new System.Drawing.Point(28, 193);
            this.btnPolicyMaintAdd.Name = "btnPolicyMaintAdd";
            this.btnPolicyMaintAdd.Size = new System.Drawing.Size(82, 32);
            this.btnPolicyMaintAdd.TabIndex = 11;
            this.btnPolicyMaintAdd.Text = "ADD";
            this.btnPolicyMaintAdd.UseVisualStyleBackColor = true;
            this.btnPolicyMaintAdd.Click += new System.EventHandler(this.btnPolicyMaintAdd_Click);
            // 
            // btnPolicyMaintUpdate
            // 
            this.btnPolicyMaintUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyMaintUpdate.Location = new System.Drawing.Point(142, 193);
            this.btnPolicyMaintUpdate.Name = "btnPolicyMaintUpdate";
            this.btnPolicyMaintUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnPolicyMaintUpdate.TabIndex = 12;
            this.btnPolicyMaintUpdate.Text = "UPDATE";
            this.btnPolicyMaintUpdate.UseVisualStyleBackColor = true;
            this.btnPolicyMaintUpdate.Click += new System.EventHandler(this.btnPolicyMaintUpdate_Click);
            // 
            // btnPolicyMaintDelete
            // 
            this.btnPolicyMaintDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyMaintDelete.Location = new System.Drawing.Point(257, 193);
            this.btnPolicyMaintDelete.Name = "btnPolicyMaintDelete";
            this.btnPolicyMaintDelete.Size = new System.Drawing.Size(82, 32);
            this.btnPolicyMaintDelete.TabIndex = 13;
            this.btnPolicyMaintDelete.Text = "DELETE";
            this.btnPolicyMaintDelete.UseVisualStyleBackColor = true;
            this.btnPolicyMaintDelete.Click += new System.EventHandler(this.btnPolicyMaintDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnPolicyMaintDelete);
            this.panel1.Controls.Add(this.btnPolicyMaintUpdate);
            this.panel1.Controls.Add(this.btnPolicyMaintAdd);
            this.panel1.Controls.Add(this.txtPolicyMaintPrice);
            this.panel1.Controls.Add(this.txtPolicyMaintPackageStatus);
            this.panel1.Controls.Add(this.txtPolicyMaintPackageType);
            this.panel1.Controls.Add(this.txtPolicyMaintPackageTear);
            this.panel1.Controls.Add(this.txtPolicyMaintPolicyID);
            this.panel1.Controls.Add(this.lblPolicyMaintFPrice);
            this.panel1.Controls.Add(this.lblPolicyMainPackageTear);
            this.panel1.Controls.Add(this.lblPolicyMainFPackageType);
            this.panel1.Controls.Add(this.lblPolicyMaintFPackageStatus);
            this.panel1.Controls.Add(this.lblPolicyMaintFPolicyID);
            this.panel1.Controls.Add(this.lblPolicyInfor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 237);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PolicyMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PolicyMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PolicyMaintenanceForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyMaintSearchPolicy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyMaintViewAll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPolicyMaintSearchPolicy;
        private System.Windows.Forms.Button btnPolicyMaintSearch;
        private System.Windows.Forms.TextBox txtSearchPolicyID;
        private System.Windows.Forms.Label lblEnterPolicyID;
        private System.Windows.Forms.Label lblSearchPolicy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPolicyMaintViewAll;
        private System.Windows.Forms.Button btnPolicyMaintViewAllPolicies;
        private System.Windows.Forms.Label lblViewAllPolicies;
        private System.Windows.Forms.Label lblPolicyInfor;
        private System.Windows.Forms.Label lblPolicyMaintFPolicyID;
        private System.Windows.Forms.Label lblPolicyMaintFPackageStatus;
        private System.Windows.Forms.Label lblPolicyMainFPackageType;
        private System.Windows.Forms.Label lblPolicyMainPackageTear;
        private System.Windows.Forms.Label lblPolicyMaintFPrice;
        private System.Windows.Forms.TextBox txtPolicyMaintPolicyID;
        private System.Windows.Forms.TextBox txtPolicyMaintPackageTear;
        private System.Windows.Forms.TextBox txtPolicyMaintPackageType;
        private System.Windows.Forms.TextBox txtPolicyMaintPackageStatus;
        private System.Windows.Forms.TextBox txtPolicyMaintPrice;
        private System.Windows.Forms.Button btnPolicyMaintAdd;
        private System.Windows.Forms.Button btnPolicyMaintUpdate;
        private System.Windows.Forms.Button btnPolicyMaintDelete;
        private System.Windows.Forms.Panel panel1;
    }
}