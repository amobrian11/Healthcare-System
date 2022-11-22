
namespace Ukupholisa_Healthcare
{
    partial class InitialForm
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
            this.lblSelectNavOption = new System.Windows.Forms.Label();
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btnClientMaintenance = new System.Windows.Forms.Button();
            this.btnPolicyMaintenance = new System.Windows.Forms.Button();
            this.btnProductMaintenance = new System.Windows.Forms.Button();
            this.btnMedicalDepartment = new System.Windows.Forms.Button();
            this.btnProviderManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectNavOption
            // 
            this.lblSelectNavOption.AutoSize = true;
            this.lblSelectNavOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectNavOption.Location = new System.Drawing.Point(52, 25);
            this.lblSelectNavOption.Name = "lblSelectNavOption";
            this.lblSelectNavOption.Size = new System.Drawing.Size(343, 25);
            this.lblSelectNavOption.TabIndex = 0;
            this.lblSelectNavOption.Text = "Select Navigation Option Below";
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallCentre.Location = new System.Drawing.Point(79, 77);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(275, 43);
            this.btnCallCentre.TabIndex = 1;
            this.btnCallCentre.Text = "Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click);
            // 
            // btnClientMaintenance
            // 
            this.btnClientMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientMaintenance.Location = new System.Drawing.Point(79, 140);
            this.btnClientMaintenance.Name = "btnClientMaintenance";
            this.btnClientMaintenance.Size = new System.Drawing.Size(275, 43);
            this.btnClientMaintenance.TabIndex = 2;
            this.btnClientMaintenance.Text = "Client Maintenance";
            this.btnClientMaintenance.UseVisualStyleBackColor = true;
            this.btnClientMaintenance.Click += new System.EventHandler(this.btnClientMaintenance_Click);
            // 
            // btnPolicyMaintenance
            // 
            this.btnPolicyMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolicyMaintenance.Location = new System.Drawing.Point(79, 205);
            this.btnPolicyMaintenance.Name = "btnPolicyMaintenance";
            this.btnPolicyMaintenance.Size = new System.Drawing.Size(275, 43);
            this.btnPolicyMaintenance.TabIndex = 3;
            this.btnPolicyMaintenance.Text = "Policy Maintenance";
            this.btnPolicyMaintenance.UseVisualStyleBackColor = true;
            this.btnPolicyMaintenance.Click += new System.EventHandler(this.btnPolicyMaintenance_Click);
            // 
            // btnProductMaintenance
            // 
            this.btnProductMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductMaintenance.Location = new System.Drawing.Point(79, 273);
            this.btnProductMaintenance.Name = "btnProductMaintenance";
            this.btnProductMaintenance.Size = new System.Drawing.Size(275, 43);
            this.btnProductMaintenance.TabIndex = 4;
            this.btnProductMaintenance.Text = "Product Maintenance";
            this.btnProductMaintenance.UseVisualStyleBackColor = true;
            this.btnProductMaintenance.Click += new System.EventHandler(this.btnProductMaintenance_Click);
            // 
            // btnMedicalDepartment
            // 
            this.btnMedicalDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalDepartment.Location = new System.Drawing.Point(79, 339);
            this.btnMedicalDepartment.Name = "btnMedicalDepartment";
            this.btnMedicalDepartment.Size = new System.Drawing.Size(275, 43);
            this.btnMedicalDepartment.TabIndex = 5;
            this.btnMedicalDepartment.Text = "Medical Department";
            this.btnMedicalDepartment.UseVisualStyleBackColor = true;
            this.btnMedicalDepartment.Click += new System.EventHandler(this.btnMedicalDepartment_Click);
            // 
            // btnProviderManagement
            // 
            this.btnProviderManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProviderManagement.Location = new System.Drawing.Point(79, 404);
            this.btnProviderManagement.Name = "btnProviderManagement";
            this.btnProviderManagement.Size = new System.Drawing.Size(275, 43);
            this.btnProviderManagement.TabIndex = 6;
            this.btnProviderManagement.Text = "Provider Management";
            this.btnProviderManagement.UseVisualStyleBackColor = true;
            this.btnProviderManagement.Click += new System.EventHandler(this.btnProviderManagement_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 478);
            this.Controls.Add(this.btnProviderManagement);
            this.Controls.Add(this.btnMedicalDepartment);
            this.Controls.Add(this.btnProductMaintenance);
            this.Controls.Add(this.btnPolicyMaintenance);
            this.Controls.Add(this.btnClientMaintenance);
            this.Controls.Add(this.btnCallCentre);
            this.Controls.Add(this.lblSelectNavOption);
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectNavOption;
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Button btnClientMaintenance;
        private System.Windows.Forms.Button btnPolicyMaintenance;
        private System.Windows.Forms.Button btnProductMaintenance;
        private System.Windows.Forms.Button btnMedicalDepartment;
        private System.Windows.Forms.Button btnProviderManagement;
    }
}

