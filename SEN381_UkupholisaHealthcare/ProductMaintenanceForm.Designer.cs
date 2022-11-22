
namespace Ukupholisa_Healthcare
{
    partial class ProductMaintenanceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTreatmentInfoDelete = new System.Windows.Forms.Button();
            this.btnTreatmentInfoUpdate = new System.Windows.Forms.Button();
            this.btnTreatmentInfoAdd = new System.Windows.Forms.Button();
            this.txtTreatmentInfoTreatmentName = new System.Windows.Forms.TextBox();
            this.txtTreatmentInfoTreatmentID = new System.Windows.Forms.TextBox();
            this.lblTreatmentInfoTreatmentName = new System.Windows.Forms.Label();
            this.lblTreatmentInfoTreatmentID = new System.Windows.Forms.Label();
            this.lblTreatmentInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSearchedTreatment = new System.Windows.Forms.DataGridView();
            this.btnTreatmentIDSearch = new System.Windows.Forms.Button();
            this.txtSearchTreatmentID = new System.Windows.Forms.TextBox();
            this.lblEnterTreatmentID = new System.Windows.Forms.Label();
            this.lblSearchTreatment = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvViewAllTreatments = new System.Windows.Forms.DataGridView();
            this.btnViewAllTreatments = new System.Windows.Forms.Button();
            this.lblViewAllTreatments = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTreatmentPolicyDelete = new System.Windows.Forms.Button();
            this.btnTreatmentPolicyAdd = new System.Windows.Forms.Button();
            this.txtTreatmentPolicyPolicyID = new System.Windows.Forms.TextBox();
            this.txtTreatmentPolicyTreatmentID = new System.Windows.Forms.TextBox();
            this.lblTreatmentPolicyPolicyID = new System.Windows.Forms.Label();
            this.lblTreatmentPolicyTreatmentID = new System.Windows.Forms.Label();
            this.lblConditionTreatment = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvTreatmentsAndPolicies = new System.Windows.Forms.DataGridView();
            this.btnViewAllTreatmentsAndPolicies = new System.Windows.Forms.Button();
            this.lblViewAllConditionsTreatments = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedTreatment)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllTreatments)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentsAndPolicies)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnTreatmentInfoDelete);
            this.panel1.Controls.Add(this.btnTreatmentInfoUpdate);
            this.panel1.Controls.Add(this.btnTreatmentInfoAdd);
            this.panel1.Controls.Add(this.txtTreatmentInfoTreatmentName);
            this.panel1.Controls.Add(this.txtTreatmentInfoTreatmentID);
            this.panel1.Controls.Add(this.lblTreatmentInfoTreatmentName);
            this.panel1.Controls.Add(this.lblTreatmentInfoTreatmentID);
            this.panel1.Controls.Add(this.lblTreatmentInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 174);
            this.panel1.TabIndex = 3;
            // 
            // btnTreatmentInfoDelete
            // 
            this.btnTreatmentInfoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentInfoDelete.Location = new System.Drawing.Point(247, 114);
            this.btnTreatmentInfoDelete.Name = "btnTreatmentInfoDelete";
            this.btnTreatmentInfoDelete.Size = new System.Drawing.Size(82, 32);
            this.btnTreatmentInfoDelete.TabIndex = 13;
            this.btnTreatmentInfoDelete.Text = "DELETE";
            this.btnTreatmentInfoDelete.UseVisualStyleBackColor = true;
            this.btnTreatmentInfoDelete.Click += new System.EventHandler(this.btnTreatmentInfoDelete_Click);
            // 
            // btnTreatmentInfoUpdate
            // 
            this.btnTreatmentInfoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentInfoUpdate.Location = new System.Drawing.Point(132, 114);
            this.btnTreatmentInfoUpdate.Name = "btnTreatmentInfoUpdate";
            this.btnTreatmentInfoUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnTreatmentInfoUpdate.TabIndex = 12;
            this.btnTreatmentInfoUpdate.Text = "UPDATE";
            this.btnTreatmentInfoUpdate.UseVisualStyleBackColor = true;
            this.btnTreatmentInfoUpdate.Click += new System.EventHandler(this.btnTreatmentInfoUpdate_Click);
            // 
            // btnTreatmentInfoAdd
            // 
            this.btnTreatmentInfoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentInfoAdd.Location = new System.Drawing.Point(18, 114);
            this.btnTreatmentInfoAdd.Name = "btnTreatmentInfoAdd";
            this.btnTreatmentInfoAdd.Size = new System.Drawing.Size(82, 32);
            this.btnTreatmentInfoAdd.TabIndex = 11;
            this.btnTreatmentInfoAdd.Text = "ADD";
            this.btnTreatmentInfoAdd.UseVisualStyleBackColor = true;
            this.btnTreatmentInfoAdd.Click += new System.EventHandler(this.btnTreatmentInfoAdd_Click);
            // 
            // txtTreatmentInfoTreatmentName
            // 
            this.txtTreatmentInfoTreatmentName.Location = new System.Drawing.Point(132, 65);
            this.txtTreatmentInfoTreatmentName.Name = "txtTreatmentInfoTreatmentName";
            this.txtTreatmentInfoTreatmentName.Size = new System.Drawing.Size(167, 20);
            this.txtTreatmentInfoTreatmentName.TabIndex = 7;
            // 
            // txtTreatmentInfoTreatmentID
            // 
            this.txtTreatmentInfoTreatmentID.Location = new System.Drawing.Point(132, 37);
            this.txtTreatmentInfoTreatmentID.Name = "txtTreatmentInfoTreatmentID";
            this.txtTreatmentInfoTreatmentID.Size = new System.Drawing.Size(167, 20);
            this.txtTreatmentInfoTreatmentID.TabIndex = 6;
            // 
            // lblTreatmentInfoTreatmentName
            // 
            this.lblTreatmentInfoTreatmentName.AutoSize = true;
            this.lblTreatmentInfoTreatmentName.Location = new System.Drawing.Point(13, 68);
            this.lblTreatmentInfoTreatmentName.Name = "lblTreatmentInfoTreatmentName";
            this.lblTreatmentInfoTreatmentName.Size = new System.Drawing.Size(89, 13);
            this.lblTreatmentInfoTreatmentName.TabIndex = 4;
            this.lblTreatmentInfoTreatmentName.Text = "Treatment Name:";
            // 
            // lblTreatmentInfoTreatmentID
            // 
            this.lblTreatmentInfoTreatmentID.AutoSize = true;
            this.lblTreatmentInfoTreatmentID.Location = new System.Drawing.Point(13, 40);
            this.lblTreatmentInfoTreatmentID.Name = "lblTreatmentInfoTreatmentID";
            this.lblTreatmentInfoTreatmentID.Size = new System.Drawing.Size(72, 13);
            this.lblTreatmentInfoTreatmentID.TabIndex = 1;
            this.lblTreatmentInfoTreatmentID.Text = "Treatment ID:";
            // 
            // lblTreatmentInfo
            // 
            this.lblTreatmentInfo.AutoSize = true;
            this.lblTreatmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentInfo.Location = new System.Drawing.Point(13, 9);
            this.lblTreatmentInfo.Name = "lblTreatmentInfo";
            this.lblTreatmentInfo.Size = new System.Drawing.Size(174, 18);
            this.lblTreatmentInfo.TabIndex = 0;
            this.lblTreatmentInfo.Text = "Treatment Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.dgvSearchedTreatment);
            this.panel2.Controls.Add(this.btnTreatmentIDSearch);
            this.panel2.Controls.Add(this.txtSearchTreatmentID);
            this.panel2.Controls.Add(this.lblEnterTreatmentID);
            this.panel2.Controls.Add(this.lblSearchTreatment);
            this.panel2.Location = new System.Drawing.Point(374, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 137);
            this.panel2.TabIndex = 4;
            // 
            // dgvSearchedTreatment
            // 
            this.dgvSearchedTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedTreatment.Location = new System.Drawing.Point(3, 75);
            this.dgvSearchedTreatment.Name = "dgvSearchedTreatment";
            this.dgvSearchedTreatment.Size = new System.Drawing.Size(453, 53);
            this.dgvSearchedTreatment.TabIndex = 15;
            this.dgvSearchedTreatment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchedTreatment_CellContentClick);
            // 
            // btnTreatmentIDSearch
            // 
            this.btnTreatmentIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentIDSearch.Location = new System.Drawing.Point(330, 30);
            this.btnTreatmentIDSearch.Name = "btnTreatmentIDSearch";
            this.btnTreatmentIDSearch.Size = new System.Drawing.Size(82, 32);
            this.btnTreatmentIDSearch.TabIndex = 14;
            this.btnTreatmentIDSearch.Text = "SEARCH";
            this.btnTreatmentIDSearch.UseVisualStyleBackColor = true;
            this.btnTreatmentIDSearch.Click += new System.EventHandler(this.btnTreatmentIDSearch_Click);
            // 
            // txtSearchTreatmentID
            // 
            this.txtSearchTreatmentID.Location = new System.Drawing.Point(119, 37);
            this.txtSearchTreatmentID.Name = "txtSearchTreatmentID";
            this.txtSearchTreatmentID.Size = new System.Drawing.Size(167, 20);
            this.txtSearchTreatmentID.TabIndex = 14;
            // 
            // lblEnterTreatmentID
            // 
            this.lblEnterTreatmentID.AutoSize = true;
            this.lblEnterTreatmentID.Location = new System.Drawing.Point(14, 40);
            this.lblEnterTreatmentID.Name = "lblEnterTreatmentID";
            this.lblEnterTreatmentID.Size = new System.Drawing.Size(100, 13);
            this.lblEnterTreatmentID.TabIndex = 14;
            this.lblEnterTreatmentID.Text = "Enter Treatment ID:";
            // 
            // lblSearchTreatment
            // 
            this.lblSearchTreatment.AutoSize = true;
            this.lblSearchTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTreatment.Location = new System.Drawing.Point(14, 9);
            this.lblSearchTreatment.Name = "lblSearchTreatment";
            this.lblSearchTreatment.Size = new System.Drawing.Size(168, 18);
            this.lblSearchTreatment.TabIndex = 1;
            this.lblSearchTreatment.Text = "Search for Treatment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.dgvViewAllTreatments);
            this.panel4.Controls.Add(this.btnViewAllTreatments);
            this.panel4.Controls.Add(this.lblViewAllTreatments);
            this.panel4.Location = new System.Drawing.Point(374, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 161);
            this.panel4.TabIndex = 7;
            // 
            // dgvViewAllTreatments
            // 
            this.dgvViewAllTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllTreatments.Location = new System.Drawing.Point(3, 66);
            this.dgvViewAllTreatments.Name = "dgvViewAllTreatments";
            this.dgvViewAllTreatments.Size = new System.Drawing.Size(453, 89);
            this.dgvViewAllTreatments.TabIndex = 16;
            this.dgvViewAllTreatments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAllTreatments_CellContentClick);
            // 
            // btnViewAllTreatments
            // 
            this.btnViewAllTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTreatments.Location = new System.Drawing.Point(182, 28);
            this.btnViewAllTreatments.Name = "btnViewAllTreatments";
            this.btnViewAllTreatments.Size = new System.Drawing.Size(82, 32);
            this.btnViewAllTreatments.TabIndex = 16;
            this.btnViewAllTreatments.Text = "VIEW";
            this.btnViewAllTreatments.UseVisualStyleBackColor = true;
            this.btnViewAllTreatments.Click += new System.EventHandler(this.btnViewAllTreatments_Click);
            // 
            // lblViewAllTreatments
            // 
            this.lblViewAllTreatments.AutoSize = true;
            this.lblViewAllTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllTreatments.Location = new System.Drawing.Point(14, 7);
            this.lblViewAllTreatments.Name = "lblViewAllTreatments";
            this.lblViewAllTreatments.Size = new System.Drawing.Size(156, 18);
            this.lblViewAllTreatments.TabIndex = 16;
            this.lblViewAllTreatments.Text = "View All Treatments";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.btnTreatmentPolicyDelete);
            this.panel3.Controls.Add(this.btnTreatmentPolicyAdd);
            this.panel3.Controls.Add(this.txtTreatmentPolicyPolicyID);
            this.panel3.Controls.Add(this.txtTreatmentPolicyTreatmentID);
            this.panel3.Controls.Add(this.lblTreatmentPolicyPolicyID);
            this.panel3.Controls.Add(this.lblTreatmentPolicyTreatmentID);
            this.panel3.Controls.Add(this.lblConditionTreatment);
            this.panel3.Location = new System.Drawing.Point(12, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 124);
            this.panel3.TabIndex = 8;
            // 
            // btnTreatmentPolicyDelete
            // 
            this.btnTreatmentPolicyDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentPolicyDelete.Location = new System.Drawing.Point(247, 80);
            this.btnTreatmentPolicyDelete.Name = "btnTreatmentPolicyDelete";
            this.btnTreatmentPolicyDelete.Size = new System.Drawing.Size(96, 25);
            this.btnTreatmentPolicyDelete.TabIndex = 28;
            this.btnTreatmentPolicyDelete.Text = "DELETE";
            this.btnTreatmentPolicyDelete.UseVisualStyleBackColor = true;
            this.btnTreatmentPolicyDelete.Click += new System.EventHandler(this.btnTreatmentPolicyDelete_Click);
            // 
            // btnTreatmentPolicyAdd
            // 
            this.btnTreatmentPolicyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentPolicyAdd.Location = new System.Drawing.Point(247, 41);
            this.btnTreatmentPolicyAdd.Name = "btnTreatmentPolicyAdd";
            this.btnTreatmentPolicyAdd.Size = new System.Drawing.Size(96, 25);
            this.btnTreatmentPolicyAdd.TabIndex = 24;
            this.btnTreatmentPolicyAdd.Text = "ADD";
            this.btnTreatmentPolicyAdd.UseVisualStyleBackColor = true;
            this.btnTreatmentPolicyAdd.Click += new System.EventHandler(this.btnTreatmentPolicyAdd_Click);
            // 
            // txtTreatmentPolicyPolicyID
            // 
            this.txtTreatmentPolicyPolicyID.Location = new System.Drawing.Point(97, 83);
            this.txtTreatmentPolicyPolicyID.Name = "txtTreatmentPolicyPolicyID";
            this.txtTreatmentPolicyPolicyID.Size = new System.Drawing.Size(117, 20);
            this.txtTreatmentPolicyPolicyID.TabIndex = 26;
            // 
            // txtTreatmentPolicyTreatmentID
            // 
            this.txtTreatmentPolicyTreatmentID.Location = new System.Drawing.Point(97, 44);
            this.txtTreatmentPolicyTreatmentID.Name = "txtTreatmentPolicyTreatmentID";
            this.txtTreatmentPolicyTreatmentID.Size = new System.Drawing.Size(117, 20);
            this.txtTreatmentPolicyTreatmentID.TabIndex = 24;
            // 
            // lblTreatmentPolicyPolicyID
            // 
            this.lblTreatmentPolicyPolicyID.AutoSize = true;
            this.lblTreatmentPolicyPolicyID.Location = new System.Drawing.Point(13, 86);
            this.lblTreatmentPolicyPolicyID.Name = "lblTreatmentPolicyPolicyID";
            this.lblTreatmentPolicyPolicyID.Size = new System.Drawing.Size(52, 13);
            this.lblTreatmentPolicyPolicyID.TabIndex = 25;
            this.lblTreatmentPolicyPolicyID.Text = "Policy ID:";
            // 
            // lblTreatmentPolicyTreatmentID
            // 
            this.lblTreatmentPolicyTreatmentID.AutoSize = true;
            this.lblTreatmentPolicyTreatmentID.Location = new System.Drawing.Point(15, 51);
            this.lblTreatmentPolicyTreatmentID.Name = "lblTreatmentPolicyTreatmentID";
            this.lblTreatmentPolicyTreatmentID.Size = new System.Drawing.Size(72, 13);
            this.lblTreatmentPolicyTreatmentID.TabIndex = 24;
            this.lblTreatmentPolicyTreatmentID.Text = "Treatment ID:";
            // 
            // lblConditionTreatment
            // 
            this.lblConditionTreatment.AutoSize = true;
            this.lblConditionTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionTreatment.Location = new System.Drawing.Point(13, 9);
            this.lblConditionTreatment.Name = "lblConditionTreatment";
            this.lblConditionTreatment.Size = new System.Drawing.Size(248, 18);
            this.lblConditionTreatment.TabIndex = 24;
            this.lblConditionTreatment.Text = "Treatments Covered by Policies";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.dgvTreatmentsAndPolicies);
            this.panel5.Controls.Add(this.btnViewAllTreatmentsAndPolicies);
            this.panel5.Controls.Add(this.lblViewAllConditionsTreatments);
            this.panel5.Location = new System.Drawing.Point(10, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(820, 157);
            this.panel5.TabIndex = 19;
            // 
            // dgvTreatmentsAndPolicies
            // 
            this.dgvTreatmentsAndPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatmentsAndPolicies.Location = new System.Drawing.Point(3, 66);
            this.dgvTreatmentsAndPolicies.Name = "dgvTreatmentsAndPolicies";
            this.dgvTreatmentsAndPolicies.Size = new System.Drawing.Size(814, 88);
            this.dgvTreatmentsAndPolicies.TabIndex = 16;
            // 
            // btnViewAllTreatmentsAndPolicies
            // 
            this.btnViewAllTreatmentsAndPolicies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTreatmentsAndPolicies.Location = new System.Drawing.Point(364, 30);
            this.btnViewAllTreatmentsAndPolicies.Name = "btnViewAllTreatmentsAndPolicies";
            this.btnViewAllTreatmentsAndPolicies.Size = new System.Drawing.Size(82, 32);
            this.btnViewAllTreatmentsAndPolicies.TabIndex = 16;
            this.btnViewAllTreatmentsAndPolicies.Text = "VIEW";
            this.btnViewAllTreatmentsAndPolicies.UseVisualStyleBackColor = true;
            this.btnViewAllTreatmentsAndPolicies.Click += new System.EventHandler(this.btnViewAllTreatmentsAndPolicies_Click);
            // 
            // lblViewAllConditionsTreatments
            // 
            this.lblViewAllConditionsTreatments.AutoSize = true;
            this.lblViewAllConditionsTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllConditionsTreatments.Location = new System.Drawing.Point(255, 9);
            this.lblViewAllConditionsTreatments.Name = "lblViewAllConditionsTreatments";
            this.lblViewAllConditionsTreatments.Size = new System.Drawing.Size(307, 18);
            this.lblViewAllConditionsTreatments.TabIndex = 16;
            this.lblViewAllConditionsTreatments.Text = "View all Treatments covered by Policies";
            // 
            // ProductMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 484);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMaintenanceForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedTreatment)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllTreatments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentsAndPolicies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTreatmentInfoDelete;
        private System.Windows.Forms.Button btnTreatmentInfoUpdate;
        private System.Windows.Forms.Button btnTreatmentInfoAdd;
        private System.Windows.Forms.TextBox txtTreatmentInfoTreatmentName;
        private System.Windows.Forms.TextBox txtTreatmentInfoTreatmentID;
        private System.Windows.Forms.Label lblTreatmentInfoTreatmentName;
        private System.Windows.Forms.Label lblTreatmentInfoTreatmentID;
        private System.Windows.Forms.Label lblTreatmentInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSearchedTreatment;
        private System.Windows.Forms.Button btnTreatmentIDSearch;
        private System.Windows.Forms.TextBox txtSearchTreatmentID;
        private System.Windows.Forms.Label lblEnterTreatmentID;
        private System.Windows.Forms.Label lblSearchTreatment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvViewAllTreatments;
        private System.Windows.Forms.Button btnViewAllTreatments;
        private System.Windows.Forms.Label lblViewAllTreatments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTreatmentPolicyDelete;
        private System.Windows.Forms.Button btnTreatmentPolicyAdd;
        private System.Windows.Forms.TextBox txtTreatmentPolicyPolicyID;
        private System.Windows.Forms.TextBox txtTreatmentPolicyTreatmentID;
        private System.Windows.Forms.Label lblTreatmentPolicyPolicyID;
        private System.Windows.Forms.Label lblTreatmentPolicyTreatmentID;
        private System.Windows.Forms.Label lblConditionTreatment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvTreatmentsAndPolicies;
        private System.Windows.Forms.Button btnViewAllTreatmentsAndPolicies;
        private System.Windows.Forms.Label lblViewAllConditionsTreatments;
    }
}