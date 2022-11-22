
namespace Ukupholisa_Healthcare
{
    partial class MedicalDepartmentForm
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
            this.btnConditionInfoDelete = new System.Windows.Forms.Button();
            this.btnConditionInfoUpdate = new System.Windows.Forms.Button();
            this.btnConditionInfoAdd = new System.Windows.Forms.Button();
            this.txtConditionInfoConditionName = new System.Windows.Forms.TextBox();
            this.txtConditionInfoConditionID = new System.Windows.Forms.TextBox();
            this.lblConditionInfoConditionName = new System.Windows.Forms.Label();
            this.lblConditionInfoConditionID = new System.Windows.Forms.Label();
            this.lblConditionInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSearchedCondition = new System.Windows.Forms.DataGridView();
            this.btnConditionIDSearch = new System.Windows.Forms.Button();
            this.txtSearchConditionID = new System.Windows.Forms.TextBox();
            this.lblEnterConditionID = new System.Windows.Forms.Label();
            this.lblSearchCondition = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvViewAllConditions = new System.Windows.Forms.DataGridView();
            this.btnViewAllConditions = new System.Windows.Forms.Button();
            this.lblViewAllConditions = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConditionTreatmentDelete = new System.Windows.Forms.Button();
            this.btnConditionTreatmentAdd = new System.Windows.Forms.Button();
            this.txtConditionTreatmentTreatmentID = new System.Windows.Forms.TextBox();
            this.txtConditionTreatmentConditionID = new System.Windows.Forms.TextBox();
            this.lblConditionTreatmentTreatmentID = new System.Windows.Forms.Label();
            this.lblConditionTreatmentConditionID = new System.Windows.Forms.Label();
            this.lblConditionTreatment = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvConditionsAndTreatments = new System.Windows.Forms.DataGridView();
            this.btnViewAllConditionsAndTreatments = new System.Windows.Forms.Button();
            this.lblViewAllConditionsTreatments = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedCondition)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllConditions)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionsAndTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnConditionInfoDelete);
            this.panel1.Controls.Add(this.btnConditionInfoUpdate);
            this.panel1.Controls.Add(this.btnConditionInfoAdd);
            this.panel1.Controls.Add(this.txtConditionInfoConditionName);
            this.panel1.Controls.Add(this.txtConditionInfoConditionID);
            this.panel1.Controls.Add(this.lblConditionInfoConditionName);
            this.panel1.Controls.Add(this.lblConditionInfoConditionID);
            this.panel1.Controls.Add(this.lblConditionInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 174);
            this.panel1.TabIndex = 2;
            // 
            // btnConditionInfoDelete
            // 
            this.btnConditionInfoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionInfoDelete.Location = new System.Drawing.Point(247, 114);
            this.btnConditionInfoDelete.Name = "btnConditionInfoDelete";
            this.btnConditionInfoDelete.Size = new System.Drawing.Size(82, 32);
            this.btnConditionInfoDelete.TabIndex = 13;
            this.btnConditionInfoDelete.Text = "DELETE";
            this.btnConditionInfoDelete.UseVisualStyleBackColor = true;
            this.btnConditionInfoDelete.Click += new System.EventHandler(this.btnConditionInfoDelete_Click);
            // 
            // btnConditionInfoUpdate
            // 
            this.btnConditionInfoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionInfoUpdate.Location = new System.Drawing.Point(132, 114);
            this.btnConditionInfoUpdate.Name = "btnConditionInfoUpdate";
            this.btnConditionInfoUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnConditionInfoUpdate.TabIndex = 12;
            this.btnConditionInfoUpdate.Text = "UPDATE";
            this.btnConditionInfoUpdate.UseVisualStyleBackColor = true;
            this.btnConditionInfoUpdate.Click += new System.EventHandler(this.btnConditionInfoUpdate_Click);
            // 
            // btnConditionInfoAdd
            // 
            this.btnConditionInfoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionInfoAdd.Location = new System.Drawing.Point(18, 114);
            this.btnConditionInfoAdd.Name = "btnConditionInfoAdd";
            this.btnConditionInfoAdd.Size = new System.Drawing.Size(82, 32);
            this.btnConditionInfoAdd.TabIndex = 11;
            this.btnConditionInfoAdd.Text = "ADD";
            this.btnConditionInfoAdd.UseVisualStyleBackColor = true;
            this.btnConditionInfoAdd.Click += new System.EventHandler(this.btnConditionInfoAdd_Click);
            // 
            // txtConditionInfoConditionName
            // 
            this.txtConditionInfoConditionName.Location = new System.Drawing.Point(132, 65);
            this.txtConditionInfoConditionName.Name = "txtConditionInfoConditionName";
            this.txtConditionInfoConditionName.Size = new System.Drawing.Size(167, 20);
            this.txtConditionInfoConditionName.TabIndex = 7;
            // 
            // txtConditionInfoConditionID
            // 
            this.txtConditionInfoConditionID.Location = new System.Drawing.Point(132, 37);
            this.txtConditionInfoConditionID.Name = "txtConditionInfoConditionID";
            this.txtConditionInfoConditionID.Size = new System.Drawing.Size(167, 20);
            this.txtConditionInfoConditionID.TabIndex = 6;
            // 
            // lblConditionInfoConditionName
            // 
            this.lblConditionInfoConditionName.AutoSize = true;
            this.lblConditionInfoConditionName.Location = new System.Drawing.Point(13, 68);
            this.lblConditionInfoConditionName.Name = "lblConditionInfoConditionName";
            this.lblConditionInfoConditionName.Size = new System.Drawing.Size(85, 13);
            this.lblConditionInfoConditionName.TabIndex = 4;
            this.lblConditionInfoConditionName.Text = "Condition Name:";
            // 
            // lblConditionInfoConditionID
            // 
            this.lblConditionInfoConditionID.AutoSize = true;
            this.lblConditionInfoConditionID.Location = new System.Drawing.Point(13, 40);
            this.lblConditionInfoConditionID.Name = "lblConditionInfoConditionID";
            this.lblConditionInfoConditionID.Size = new System.Drawing.Size(68, 13);
            this.lblConditionInfoConditionID.TabIndex = 1;
            this.lblConditionInfoConditionID.Text = "Condition ID:";
            // 
            // lblConditionInfo
            // 
            this.lblConditionInfo.AutoSize = true;
            this.lblConditionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionInfo.Location = new System.Drawing.Point(13, 9);
            this.lblConditionInfo.Name = "lblConditionInfo";
            this.lblConditionInfo.Size = new System.Drawing.Size(233, 18);
            this.lblConditionInfo.TabIndex = 0;
            this.lblConditionInfo.Text = "Medical Condition Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.dgvSearchedCondition);
            this.panel2.Controls.Add(this.btnConditionIDSearch);
            this.panel2.Controls.Add(this.txtSearchConditionID);
            this.panel2.Controls.Add(this.lblEnterConditionID);
            this.panel2.Controls.Add(this.lblSearchCondition);
            this.panel2.Location = new System.Drawing.Point(373, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 137);
            this.panel2.TabIndex = 3;
            // 
            // dgvSearchedCondition
            // 
            this.dgvSearchedCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedCondition.Location = new System.Drawing.Point(3, 75);
            this.dgvSearchedCondition.Name = "dgvSearchedCondition";
            this.dgvSearchedCondition.Size = new System.Drawing.Size(453, 53);
            this.dgvSearchedCondition.TabIndex = 15;
            this.dgvSearchedCondition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchedCondition_CellContentClick);
            // 
            // btnConditionIDSearch
            // 
            this.btnConditionIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionIDSearch.Location = new System.Drawing.Point(330, 30);
            this.btnConditionIDSearch.Name = "btnConditionIDSearch";
            this.btnConditionIDSearch.Size = new System.Drawing.Size(82, 32);
            this.btnConditionIDSearch.TabIndex = 14;
            this.btnConditionIDSearch.Text = "SEARCH";
            this.btnConditionIDSearch.UseVisualStyleBackColor = true;
            this.btnConditionIDSearch.Click += new System.EventHandler(this.btnConditionIDSearch_Click);
            // 
            // txtSearchConditionID
            // 
            this.txtSearchConditionID.Location = new System.Drawing.Point(119, 37);
            this.txtSearchConditionID.Name = "txtSearchConditionID";
            this.txtSearchConditionID.Size = new System.Drawing.Size(167, 20);
            this.txtSearchConditionID.TabIndex = 14;
            // 
            // lblEnterConditionID
            // 
            this.lblEnterConditionID.AutoSize = true;
            this.lblEnterConditionID.Location = new System.Drawing.Point(14, 40);
            this.lblEnterConditionID.Name = "lblEnterConditionID";
            this.lblEnterConditionID.Size = new System.Drawing.Size(96, 13);
            this.lblEnterConditionID.TabIndex = 14;
            this.lblEnterConditionID.Text = "Enter Condition ID:";
            // 
            // lblSearchCondition
            // 
            this.lblSearchCondition.AutoSize = true;
            this.lblSearchCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCondition.Location = new System.Drawing.Point(14, 9);
            this.lblSearchCondition.Name = "lblSearchCondition";
            this.lblSearchCondition.Size = new System.Drawing.Size(227, 18);
            this.lblSearchCondition.TabIndex = 1;
            this.lblSearchCondition.Text = "Search for Medical Condition";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.dgvViewAllConditions);
            this.panel4.Controls.Add(this.btnViewAllConditions);
            this.panel4.Controls.Add(this.lblViewAllConditions);
            this.panel4.Location = new System.Drawing.Point(373, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 161);
            this.panel4.TabIndex = 6;
            // 
            // dgvViewAllConditions
            // 
            this.dgvViewAllConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllConditions.Location = new System.Drawing.Point(3, 66);
            this.dgvViewAllConditions.Name = "dgvViewAllConditions";
            this.dgvViewAllConditions.Size = new System.Drawing.Size(453, 89);
            this.dgvViewAllConditions.TabIndex = 16;
            this.dgvViewAllConditions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAllConditions_CellContentClick);
            // 
            // btnViewAllConditions
            // 
            this.btnViewAllConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllConditions.Location = new System.Drawing.Point(182, 28);
            this.btnViewAllConditions.Name = "btnViewAllConditions";
            this.btnViewAllConditions.Size = new System.Drawing.Size(82, 32);
            this.btnViewAllConditions.TabIndex = 16;
            this.btnViewAllConditions.Text = "VIEW";
            this.btnViewAllConditions.UseVisualStyleBackColor = true;
            this.btnViewAllConditions.Click += new System.EventHandler(this.btnViewAllConditions_Click);
            // 
            // lblViewAllConditions
            // 
            this.lblViewAllConditions.AutoSize = true;
            this.lblViewAllConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllConditions.Location = new System.Drawing.Point(14, 7);
            this.lblViewAllConditions.Name = "lblViewAllConditions";
            this.lblViewAllConditions.Size = new System.Drawing.Size(215, 18);
            this.lblViewAllConditions.TabIndex = 16;
            this.lblViewAllConditions.Text = "View All Medical Conditions";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.btnConditionTreatmentDelete);
            this.panel3.Controls.Add(this.btnConditionTreatmentAdd);
            this.panel3.Controls.Add(this.txtConditionTreatmentTreatmentID);
            this.panel3.Controls.Add(this.txtConditionTreatmentConditionID);
            this.panel3.Controls.Add(this.lblConditionTreatmentTreatmentID);
            this.panel3.Controls.Add(this.lblConditionTreatmentConditionID);
            this.panel3.Controls.Add(this.lblConditionTreatment);
            this.panel3.Location = new System.Drawing.Point(12, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 124);
            this.panel3.TabIndex = 7;
            // 
            // btnConditionTreatmentDelete
            // 
            this.btnConditionTreatmentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionTreatmentDelete.Location = new System.Drawing.Point(247, 80);
            this.btnConditionTreatmentDelete.Name = "btnConditionTreatmentDelete";
            this.btnConditionTreatmentDelete.Size = new System.Drawing.Size(96, 25);
            this.btnConditionTreatmentDelete.TabIndex = 28;
            this.btnConditionTreatmentDelete.Text = "DELETE";
            this.btnConditionTreatmentDelete.UseVisualStyleBackColor = true;
            this.btnConditionTreatmentDelete.Click += new System.EventHandler(this.btnConditionTreatmentDelete_Click);
            // 
            // btnConditionTreatmentAdd
            // 
            this.btnConditionTreatmentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionTreatmentAdd.Location = new System.Drawing.Point(247, 41);
            this.btnConditionTreatmentAdd.Name = "btnConditionTreatmentAdd";
            this.btnConditionTreatmentAdd.Size = new System.Drawing.Size(96, 25);
            this.btnConditionTreatmentAdd.TabIndex = 24;
            this.btnConditionTreatmentAdd.Text = "ADD";
            this.btnConditionTreatmentAdd.UseVisualStyleBackColor = true;
            this.btnConditionTreatmentAdd.Click += new System.EventHandler(this.btnConditionTreatmentAdd_Click);
            // 
            // txtConditionTreatmentTreatmentID
            // 
            this.txtConditionTreatmentTreatmentID.Location = new System.Drawing.Point(97, 83);
            this.txtConditionTreatmentTreatmentID.Name = "txtConditionTreatmentTreatmentID";
            this.txtConditionTreatmentTreatmentID.Size = new System.Drawing.Size(117, 20);
            this.txtConditionTreatmentTreatmentID.TabIndex = 26;
            // 
            // txtConditionTreatmentConditionID
            // 
            this.txtConditionTreatmentConditionID.Location = new System.Drawing.Point(97, 44);
            this.txtConditionTreatmentConditionID.Name = "txtConditionTreatmentConditionID";
            this.txtConditionTreatmentConditionID.Size = new System.Drawing.Size(117, 20);
            this.txtConditionTreatmentConditionID.TabIndex = 24;
            // 
            // lblConditionTreatmentTreatmentID
            // 
            this.lblConditionTreatmentTreatmentID.AutoSize = true;
            this.lblConditionTreatmentTreatmentID.Location = new System.Drawing.Point(13, 86);
            this.lblConditionTreatmentTreatmentID.Name = "lblConditionTreatmentTreatmentID";
            this.lblConditionTreatmentTreatmentID.Size = new System.Drawing.Size(72, 13);
            this.lblConditionTreatmentTreatmentID.TabIndex = 25;
            this.lblConditionTreatmentTreatmentID.Text = "Treatment ID:";
            // 
            // lblConditionTreatmentConditionID
            // 
            this.lblConditionTreatmentConditionID.AutoSize = true;
            this.lblConditionTreatmentConditionID.Location = new System.Drawing.Point(15, 51);
            this.lblConditionTreatmentConditionID.Name = "lblConditionTreatmentConditionID";
            this.lblConditionTreatmentConditionID.Size = new System.Drawing.Size(68, 13);
            this.lblConditionTreatmentConditionID.TabIndex = 24;
            this.lblConditionTreatmentConditionID.Text = "Condition ID:";
            // 
            // lblConditionTreatment
            // 
            this.lblConditionTreatment.AutoSize = true;
            this.lblConditionTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionTreatment.Location = new System.Drawing.Point(13, 9);
            this.lblConditionTreatment.Name = "lblConditionTreatment";
            this.lblConditionTreatment.Size = new System.Drawing.Size(251, 18);
            this.lblConditionTreatment.TabIndex = 24;
            this.lblConditionTreatment.Text = "Condition Treatment Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.dgvConditionsAndTreatments);
            this.panel5.Controls.Add(this.btnViewAllConditionsAndTreatments);
            this.panel5.Controls.Add(this.lblViewAllConditionsTreatments);
            this.panel5.Location = new System.Drawing.Point(12, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(820, 157);
            this.panel5.TabIndex = 18;
            // 
            // dgvConditionsAndTreatments
            // 
            this.dgvConditionsAndTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditionsAndTreatments.Location = new System.Drawing.Point(3, 66);
            this.dgvConditionsAndTreatments.Name = "dgvConditionsAndTreatments";
            this.dgvConditionsAndTreatments.Size = new System.Drawing.Size(814, 88);
            this.dgvConditionsAndTreatments.TabIndex = 16;
            this.dgvConditionsAndTreatments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConditionsAndTreatments_CellContentClick);
            // 
            // btnViewAllConditionsAndTreatments
            // 
            this.btnViewAllConditionsAndTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllConditionsAndTreatments.Location = new System.Drawing.Point(364, 30);
            this.btnViewAllConditionsAndTreatments.Name = "btnViewAllConditionsAndTreatments";
            this.btnViewAllConditionsAndTreatments.Size = new System.Drawing.Size(82, 32);
            this.btnViewAllConditionsAndTreatments.TabIndex = 16;
            this.btnViewAllConditionsAndTreatments.Text = "VIEW";
            this.btnViewAllConditionsAndTreatments.UseVisualStyleBackColor = true;
            this.btnViewAllConditionsAndTreatments.Click += new System.EventHandler(this.btnViewAllConditionsAndTreatments_Click);
            // 
            // lblViewAllConditionsTreatments
            // 
            this.lblViewAllConditionsTreatments.AutoSize = true;
            this.lblViewAllConditionsTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllConditionsTreatments.Location = new System.Drawing.Point(255, 9);
            this.lblViewAllConditionsTreatments.Name = "lblViewAllConditionsTreatments";
            this.lblViewAllConditionsTreatments.Size = new System.Drawing.Size(311, 18);
            this.lblViewAllConditionsTreatments.TabIndex = 16;
            this.lblViewAllConditionsTreatments.Text = "View all Conditions and their Treatments";
            // 
            // MedicalDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MedicalDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalDepartmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedCondition)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllConditions)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionsAndTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConditionInfoDelete;
        private System.Windows.Forms.Button btnConditionInfoUpdate;
        private System.Windows.Forms.Button btnConditionInfoAdd;
        private System.Windows.Forms.TextBox txtConditionInfoConditionName;
        private System.Windows.Forms.TextBox txtConditionInfoConditionID;
        private System.Windows.Forms.Label lblConditionInfoConditionName;
        private System.Windows.Forms.Label lblConditionInfoConditionID;
        private System.Windows.Forms.Label lblConditionInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSearchedCondition;
        private System.Windows.Forms.Button btnConditionIDSearch;
        private System.Windows.Forms.TextBox txtSearchConditionID;
        private System.Windows.Forms.Label lblEnterConditionID;
        private System.Windows.Forms.Label lblSearchCondition;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvViewAllConditions;
        private System.Windows.Forms.Button btnViewAllConditions;
        private System.Windows.Forms.Label lblViewAllConditions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConditionTreatmentDelete;
        private System.Windows.Forms.Button btnConditionTreatmentAdd;
        private System.Windows.Forms.TextBox txtConditionTreatmentTreatmentID;
        private System.Windows.Forms.TextBox txtConditionTreatmentConditionID;
        private System.Windows.Forms.Label lblConditionTreatmentTreatmentID;
        private System.Windows.Forms.Label lblConditionTreatmentConditionID;
        private System.Windows.Forms.Label lblConditionTreatment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvConditionsAndTreatments;
        private System.Windows.Forms.Button btnViewAllConditionsAndTreatments;
        private System.Windows.Forms.Label lblViewAllConditionsTreatments;
    }
}