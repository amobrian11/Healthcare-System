
namespace Ukupholisa_Healthcare
{
    partial class ProviderManagementForm
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
            this.txtProviderPostalCode = new System.Windows.Forms.TextBox();
            this.txtProviderStreetNumAndName = new System.Windows.Forms.TextBox();
            this.txtProviderCity = new System.Windows.Forms.TextBox();
            this.lblPostalCodeProvider = new System.Windows.Forms.Label();
            this.lblProviderStreetName = new System.Windows.Forms.Label();
            this.lblProviderCity = new System.Windows.Forms.Label();
            this.btnProviderInfoDelete = new System.Windows.Forms.Button();
            this.btnProviderInfoUpdate = new System.Windows.Forms.Button();
            this.btnProviderInfoAdd = new System.Windows.Forms.Button();
            this.txtProviderInfoProviderStatus = new System.Windows.Forms.TextBox();
            this.txtProviderInfoProviderName = new System.Windows.Forms.TextBox();
            this.txtProviderInfoProviderID = new System.Windows.Forms.TextBox();
            this.lblProviderInfoProviderName = new System.Windows.Forms.Label();
            this.lblProviderInfoProviderStatus = new System.Windows.Forms.Label();
            this.lblProviderInfoProviderID = new System.Windows.Forms.Label();
            this.lblProviderInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSearchedProvider = new System.Windows.Forms.DataGridView();
            this.btnProviderIDSearch = new System.Windows.Forms.Button();
            this.txtSearchProviderID = new System.Windows.Forms.TextBox();
            this.lblEnterPolicyID = new System.Windows.Forms.Label();
            this.lblSearchProvider = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTreatmentProviderDelete = new System.Windows.Forms.Button();
            this.btnTreatmentProviderAdd = new System.Windows.Forms.Button();
            this.txtTreatmentProviderTreatmentID = new System.Windows.Forms.TextBox();
            this.txtTreatmentProviderProviderID = new System.Windows.Forms.TextBox();
            this.lblTreatmentProviderTreatmentID = new System.Windows.Forms.Label();
            this.lblTreatmentProviderProviderID = new System.Windows.Forms.Label();
            this.lblTreatmentProvider = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvViewAllProviders = new System.Windows.Forms.DataGridView();
            this.btnViewAllProviders = new System.Windows.Forms.Button();
            this.lblViewAllProviders = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProvidersAndTreatments = new System.Windows.Forms.DataGridView();
            this.btnViewAllProvidersAndTreatments = new System.Windows.Forms.Button();
            this.lblAllProvidersAndTreatments = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedProvider)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllProviders)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvidersAndTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.txtProviderPostalCode);
            this.panel1.Controls.Add(this.txtProviderStreetNumAndName);
            this.panel1.Controls.Add(this.txtProviderCity);
            this.panel1.Controls.Add(this.lblPostalCodeProvider);
            this.panel1.Controls.Add(this.lblProviderStreetName);
            this.panel1.Controls.Add(this.lblProviderCity);
            this.panel1.Controls.Add(this.btnProviderInfoDelete);
            this.panel1.Controls.Add(this.btnProviderInfoUpdate);
            this.panel1.Controls.Add(this.btnProviderInfoAdd);
            this.panel1.Controls.Add(this.txtProviderInfoProviderStatus);
            this.panel1.Controls.Add(this.txtProviderInfoProviderName);
            this.panel1.Controls.Add(this.txtProviderInfoProviderID);
            this.panel1.Controls.Add(this.lblProviderInfoProviderName);
            this.panel1.Controls.Add(this.lblProviderInfoProviderStatus);
            this.panel1.Controls.Add(this.lblProviderInfoProviderID);
            this.panel1.Controls.Add(this.lblProviderInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 253);
            this.panel1.TabIndex = 1;
            // 
            // txtProviderPostalCode
            // 
            this.txtProviderPostalCode.Location = new System.Drawing.Point(132, 187);
            this.txtProviderPostalCode.Name = "txtProviderPostalCode";
            this.txtProviderPostalCode.Size = new System.Drawing.Size(167, 20);
            this.txtProviderPostalCode.TabIndex = 19;
            // 
            // txtProviderStreetNumAndName
            // 
            this.txtProviderStreetNumAndName.Location = new System.Drawing.Point(132, 158);
            this.txtProviderStreetNumAndName.Name = "txtProviderStreetNumAndName";
            this.txtProviderStreetNumAndName.Size = new System.Drawing.Size(167, 20);
            this.txtProviderStreetNumAndName.TabIndex = 18;
            // 
            // txtProviderCity
            // 
            this.txtProviderCity.Location = new System.Drawing.Point(132, 126);
            this.txtProviderCity.Name = "txtProviderCity";
            this.txtProviderCity.Size = new System.Drawing.Size(167, 20);
            this.txtProviderCity.TabIndex = 17;
            // 
            // lblPostalCodeProvider
            // 
            this.lblPostalCodeProvider.AutoSize = true;
            this.lblPostalCodeProvider.Location = new System.Drawing.Point(13, 187);
            this.lblPostalCodeProvider.Name = "lblPostalCodeProvider";
            this.lblPostalCodeProvider.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCodeProvider.TabIndex = 16;
            this.lblPostalCodeProvider.Text = "Postal Code:";
            // 
            // lblProviderStreetName
            // 
            this.lblProviderStreetName.AutoSize = true;
            this.lblProviderStreetName.Location = new System.Drawing.Point(13, 158);
            this.lblProviderStreetName.Name = "lblProviderStreetName";
            this.lblProviderStreetName.Size = new System.Drawing.Size(104, 13);
            this.lblProviderStreetName.TabIndex = 15;
            this.lblProviderStreetName.Text = "Street Nr and Name:";
            // 
            // lblProviderCity
            // 
            this.lblProviderCity.AutoSize = true;
            this.lblProviderCity.Location = new System.Drawing.Point(13, 126);
            this.lblProviderCity.Name = "lblProviderCity";
            this.lblProviderCity.Size = new System.Drawing.Size(27, 13);
            this.lblProviderCity.TabIndex = 14;
            this.lblProviderCity.Text = "City:";
            // 
            // btnProviderInfoDelete
            // 
            this.btnProviderInfoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProviderInfoDelete.Location = new System.Drawing.Point(247, 218);
            this.btnProviderInfoDelete.Name = "btnProviderInfoDelete";
            this.btnProviderInfoDelete.Size = new System.Drawing.Size(82, 32);
            this.btnProviderInfoDelete.TabIndex = 13;
            this.btnProviderInfoDelete.Text = "DELETE";
            this.btnProviderInfoDelete.UseVisualStyleBackColor = true;
            this.btnProviderInfoDelete.Click += new System.EventHandler(this.btnProviderInfoDelete_Click);
            // 
            // btnProviderInfoUpdate
            // 
            this.btnProviderInfoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProviderInfoUpdate.Location = new System.Drawing.Point(132, 218);
            this.btnProviderInfoUpdate.Name = "btnProviderInfoUpdate";
            this.btnProviderInfoUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnProviderInfoUpdate.TabIndex = 12;
            this.btnProviderInfoUpdate.Text = "UPDATE";
            this.btnProviderInfoUpdate.UseVisualStyleBackColor = true;
            this.btnProviderInfoUpdate.Click += new System.EventHandler(this.btnProviderInfoUpdate_Click);
            // 
            // btnProviderInfoAdd
            // 
            this.btnProviderInfoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProviderInfoAdd.Location = new System.Drawing.Point(18, 218);
            this.btnProviderInfoAdd.Name = "btnProviderInfoAdd";
            this.btnProviderInfoAdd.Size = new System.Drawing.Size(82, 32);
            this.btnProviderInfoAdd.TabIndex = 11;
            this.btnProviderInfoAdd.Text = "ADD";
            this.btnProviderInfoAdd.UseVisualStyleBackColor = true;
            this.btnProviderInfoAdd.Click += new System.EventHandler(this.btnProviderInfoAdd_Click);
            // 
            // txtProviderInfoProviderStatus
            // 
            this.txtProviderInfoProviderStatus.Location = new System.Drawing.Point(132, 94);
            this.txtProviderInfoProviderStatus.Name = "txtProviderInfoProviderStatus";
            this.txtProviderInfoProviderStatus.Size = new System.Drawing.Size(167, 20);
            this.txtProviderInfoProviderStatus.TabIndex = 8;
            // 
            // txtProviderInfoProviderName
            // 
            this.txtProviderInfoProviderName.Location = new System.Drawing.Point(132, 65);
            this.txtProviderInfoProviderName.Name = "txtProviderInfoProviderName";
            this.txtProviderInfoProviderName.Size = new System.Drawing.Size(167, 20);
            this.txtProviderInfoProviderName.TabIndex = 7;
            // 
            // txtProviderInfoProviderID
            // 
            this.txtProviderInfoProviderID.Location = new System.Drawing.Point(132, 37);
            this.txtProviderInfoProviderID.Name = "txtProviderInfoProviderID";
            this.txtProviderInfoProviderID.Size = new System.Drawing.Size(167, 20);
            this.txtProviderInfoProviderID.TabIndex = 6;
            // 
            // lblProviderInfoProviderName
            // 
            this.lblProviderInfoProviderName.AutoSize = true;
            this.lblProviderInfoProviderName.Location = new System.Drawing.Point(13, 68);
            this.lblProviderInfoProviderName.Name = "lblProviderInfoProviderName";
            this.lblProviderInfoProviderName.Size = new System.Drawing.Size(80, 13);
            this.lblProviderInfoProviderName.TabIndex = 4;
            this.lblProviderInfoProviderName.Text = "Provider Name:";
            // 
            // lblProviderInfoProviderStatus
            // 
            this.lblProviderInfoProviderStatus.AutoSize = true;
            this.lblProviderInfoProviderStatus.Location = new System.Drawing.Point(13, 97);
            this.lblProviderInfoProviderStatus.Name = "lblProviderInfoProviderStatus";
            this.lblProviderInfoProviderStatus.Size = new System.Drawing.Size(82, 13);
            this.lblProviderInfoProviderStatus.TabIndex = 3;
            this.lblProviderInfoProviderStatus.Text = "Provider Status:";
            // 
            // lblProviderInfoProviderID
            // 
            this.lblProviderInfoProviderID.AutoSize = true;
            this.lblProviderInfoProviderID.Location = new System.Drawing.Point(13, 40);
            this.lblProviderInfoProviderID.Name = "lblProviderInfoProviderID";
            this.lblProviderInfoProviderID.Size = new System.Drawing.Size(63, 13);
            this.lblProviderInfoProviderID.TabIndex = 1;
            this.lblProviderInfoProviderID.Text = "Provider ID:";
            // 
            // lblProviderInfo
            // 
            this.lblProviderInfo.AutoSize = true;
            this.lblProviderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviderInfo.Location = new System.Drawing.Point(13, 9);
            this.lblProviderInfo.Name = "lblProviderInfo";
            this.lblProviderInfo.Size = new System.Drawing.Size(161, 18);
            this.lblProviderInfo.TabIndex = 0;
            this.lblProviderInfo.Text = "Provider Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.dgvSearchedProvider);
            this.panel2.Controls.Add(this.btnProviderIDSearch);
            this.panel2.Controls.Add(this.txtSearchProviderID);
            this.panel2.Controls.Add(this.lblEnterPolicyID);
            this.panel2.Controls.Add(this.lblSearchProvider);
            this.panel2.Location = new System.Drawing.Point(371, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 146);
            this.panel2.TabIndex = 2;
            // 
            // dgvSearchedProvider
            // 
            this.dgvSearchedProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedProvider.Location = new System.Drawing.Point(3, 75);
            this.dgvSearchedProvider.Name = "dgvSearchedProvider";
            this.dgvSearchedProvider.Size = new System.Drawing.Size(453, 68);
            this.dgvSearchedProvider.TabIndex = 15;
            this.dgvSearchedProvider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchedProvider_CellContentClick);
            // 
            // btnProviderIDSearch
            // 
            this.btnProviderIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProviderIDSearch.Location = new System.Drawing.Point(330, 30);
            this.btnProviderIDSearch.Name = "btnProviderIDSearch";
            this.btnProviderIDSearch.Size = new System.Drawing.Size(82, 32);
            this.btnProviderIDSearch.TabIndex = 14;
            this.btnProviderIDSearch.Text = "SEARCH";
            this.btnProviderIDSearch.UseVisualStyleBackColor = true;
            this.btnProviderIDSearch.Click += new System.EventHandler(this.btnProviderIDSearch_Click);
            // 
            // txtSearchProviderID
            // 
            this.txtSearchProviderID.Location = new System.Drawing.Point(119, 37);
            this.txtSearchProviderID.Name = "txtSearchProviderID";
            this.txtSearchProviderID.Size = new System.Drawing.Size(167, 20);
            this.txtSearchProviderID.TabIndex = 14;
            // 
            // lblEnterPolicyID
            // 
            this.lblEnterPolicyID.AutoSize = true;
            this.lblEnterPolicyID.Location = new System.Drawing.Point(14, 40);
            this.lblEnterPolicyID.Name = "lblEnterPolicyID";
            this.lblEnterPolicyID.Size = new System.Drawing.Size(91, 13);
            this.lblEnterPolicyID.TabIndex = 14;
            this.lblEnterPolicyID.Text = "Enter Provider ID:";
            // 
            // lblSearchProvider
            // 
            this.lblSearchProvider.AutoSize = true;
            this.lblSearchProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProvider.Location = new System.Drawing.Point(14, 9);
            this.lblSearchProvider.Name = "lblSearchProvider";
            this.lblSearchProvider.Size = new System.Drawing.Size(155, 18);
            this.lblSearchProvider.TabIndex = 1;
            this.lblSearchProvider.Text = "Search for Provider";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.btnTreatmentProviderDelete);
            this.panel3.Controls.Add(this.btnTreatmentProviderAdd);
            this.panel3.Controls.Add(this.txtTreatmentProviderTreatmentID);
            this.panel3.Controls.Add(this.txtTreatmentProviderProviderID);
            this.panel3.Controls.Add(this.lblTreatmentProviderTreatmentID);
            this.panel3.Controls.Add(this.lblTreatmentProviderProviderID);
            this.panel3.Controls.Add(this.lblTreatmentProvider);
            this.panel3.Location = new System.Drawing.Point(12, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 124);
            this.panel3.TabIndex = 4;
            // 
            // btnTreatmentProviderDelete
            // 
            this.btnTreatmentProviderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentProviderDelete.Location = new System.Drawing.Point(247, 80);
            this.btnTreatmentProviderDelete.Name = "btnTreatmentProviderDelete";
            this.btnTreatmentProviderDelete.Size = new System.Drawing.Size(96, 25);
            this.btnTreatmentProviderDelete.TabIndex = 28;
            this.btnTreatmentProviderDelete.Text = "DELETE";
            this.btnTreatmentProviderDelete.UseVisualStyleBackColor = true;
            this.btnTreatmentProviderDelete.Click += new System.EventHandler(this.btnTreatmentProviderDelete_Click);
            // 
            // btnTreatmentProviderAdd
            // 
            this.btnTreatmentProviderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatmentProviderAdd.Location = new System.Drawing.Point(247, 41);
            this.btnTreatmentProviderAdd.Name = "btnTreatmentProviderAdd";
            this.btnTreatmentProviderAdd.Size = new System.Drawing.Size(96, 25);
            this.btnTreatmentProviderAdd.TabIndex = 24;
            this.btnTreatmentProviderAdd.Text = "ADD";
            this.btnTreatmentProviderAdd.UseVisualStyleBackColor = true;
            this.btnTreatmentProviderAdd.Click += new System.EventHandler(this.btnTreatmentProviderAdd_Click);
            // 
            // txtTreatmentProviderTreatmentID
            // 
            this.txtTreatmentProviderTreatmentID.Location = new System.Drawing.Point(97, 83);
            this.txtTreatmentProviderTreatmentID.Name = "txtTreatmentProviderTreatmentID";
            this.txtTreatmentProviderTreatmentID.Size = new System.Drawing.Size(117, 20);
            this.txtTreatmentProviderTreatmentID.TabIndex = 26;
            // 
            // txtTreatmentProviderProviderID
            // 
            this.txtTreatmentProviderProviderID.Location = new System.Drawing.Point(97, 44);
            this.txtTreatmentProviderProviderID.Name = "txtTreatmentProviderProviderID";
            this.txtTreatmentProviderProviderID.Size = new System.Drawing.Size(117, 20);
            this.txtTreatmentProviderProviderID.TabIndex = 24;
            // 
            // lblTreatmentProviderTreatmentID
            // 
            this.lblTreatmentProviderTreatmentID.AutoSize = true;
            this.lblTreatmentProviderTreatmentID.Location = new System.Drawing.Point(13, 86);
            this.lblTreatmentProviderTreatmentID.Name = "lblTreatmentProviderTreatmentID";
            this.lblTreatmentProviderTreatmentID.Size = new System.Drawing.Size(72, 13);
            this.lblTreatmentProviderTreatmentID.TabIndex = 25;
            this.lblTreatmentProviderTreatmentID.Text = "Treatment ID:";
            // 
            // lblTreatmentProviderProviderID
            // 
            this.lblTreatmentProviderProviderID.AutoSize = true;
            this.lblTreatmentProviderProviderID.Location = new System.Drawing.Point(15, 51);
            this.lblTreatmentProviderProviderID.Name = "lblTreatmentProviderProviderID";
            this.lblTreatmentProviderProviderID.Size = new System.Drawing.Size(63, 13);
            this.lblTreatmentProviderProviderID.TabIndex = 24;
            this.lblTreatmentProviderProviderID.Text = "Provider ID:";
            // 
            // lblTreatmentProvider
            // 
            this.lblTreatmentProvider.AutoSize = true;
            this.lblTreatmentProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentProvider.Location = new System.Drawing.Point(13, 9);
            this.lblTreatmentProvider.Name = "lblTreatmentProvider";
            this.lblTreatmentProvider.Size = new System.Drawing.Size(254, 18);
            this.lblTreatmentProvider.TabIndex = 24;
            this.lblTreatmentProvider.Text = "Treatments Provided by Provider";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.dgvViewAllProviders);
            this.panel4.Controls.Add(this.btnViewAllProviders);
            this.panel4.Controls.Add(this.lblViewAllProviders);
            this.panel4.Location = new System.Drawing.Point(371, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 231);
            this.panel4.TabIndex = 5;
            // 
            // dgvViewAllProviders
            // 
            this.dgvViewAllProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllProviders.Location = new System.Drawing.Point(3, 66);
            this.dgvViewAllProviders.Name = "dgvViewAllProviders";
            this.dgvViewAllProviders.Size = new System.Drawing.Size(453, 159);
            this.dgvViewAllProviders.TabIndex = 16;
            this.dgvViewAllProviders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAllProviders_CellContentClick);
            // 
            // btnViewAllProviders
            // 
            this.btnViewAllProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllProviders.Location = new System.Drawing.Point(182, 28);
            this.btnViewAllProviders.Name = "btnViewAllProviders";
            this.btnViewAllProviders.Size = new System.Drawing.Size(82, 32);
            this.btnViewAllProviders.TabIndex = 16;
            this.btnViewAllProviders.Text = "VIEW";
            this.btnViewAllProviders.UseVisualStyleBackColor = true;
            this.btnViewAllProviders.Click += new System.EventHandler(this.btnViewAllProviders_Click);
            // 
            // lblViewAllProviders
            // 
            this.lblViewAllProviders.AutoSize = true;
            this.lblViewAllProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllProviders.Location = new System.Drawing.Point(14, 9);
            this.lblViewAllProviders.Name = "lblViewAllProviders";
            this.lblViewAllProviders.Size = new System.Drawing.Size(143, 18);
            this.lblViewAllProviders.TabIndex = 16;
            this.lblViewAllProviders.Text = "View All Providers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.dgvProvidersAndTreatments);
            this.panel5.Controls.Add(this.btnViewAllProvidersAndTreatments);
            this.panel5.Controls.Add(this.lblAllProvidersAndTreatments);
            this.panel5.Location = new System.Drawing.Point(12, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(815, 163);
            this.panel5.TabIndex = 17;
            // 
            // dgvProvidersAndTreatments
            // 
            this.dgvProvidersAndTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvidersAndTreatments.Location = new System.Drawing.Point(3, 66);
            this.dgvProvidersAndTreatments.Name = "dgvProvidersAndTreatments";
            this.dgvProvidersAndTreatments.Size = new System.Drawing.Size(809, 88);
            this.dgvProvidersAndTreatments.TabIndex = 16;
            // 
            // btnViewAllProvidersAndTreatments
            // 
            this.btnViewAllProvidersAndTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllProvidersAndTreatments.Location = new System.Drawing.Point(359, 30);
            this.btnViewAllProvidersAndTreatments.Name = "btnViewAllProvidersAndTreatments";
            this.btnViewAllProvidersAndTreatments.Size = new System.Drawing.Size(82, 32);
            this.btnViewAllProvidersAndTreatments.TabIndex = 16;
            this.btnViewAllProvidersAndTreatments.Text = "VIEW";
            this.btnViewAllProvidersAndTreatments.UseVisualStyleBackColor = true;
            this.btnViewAllProvidersAndTreatments.Click += new System.EventHandler(this.btnViewAllProvidersAndTreatments_Click);
            // 
            // lblAllProvidersAndTreatments
            // 
            this.lblAllProvidersAndTreatments.AutoSize = true;
            this.lblAllProvidersAndTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProvidersAndTreatments.Location = new System.Drawing.Point(209, 9);
            this.lblAllProvidersAndTreatments.Name = "lblAllProvidersAndTreatments";
            this.lblAllProvidersAndTreatments.Size = new System.Drawing.Size(376, 18);
            this.lblAllProvidersAndTreatments.TabIndex = 16;
            this.lblAllProvidersAndTreatments.Text = "View All Providers and the Treatments they cover";
            // 
            // ProviderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 567);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProviderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedProvider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllProviders)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvidersAndTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProviderInfoDelete;
        private System.Windows.Forms.Button btnProviderInfoUpdate;
        private System.Windows.Forms.Button btnProviderInfoAdd;
        private System.Windows.Forms.TextBox txtProviderInfoProviderStatus;
        private System.Windows.Forms.TextBox txtProviderInfoProviderName;
        private System.Windows.Forms.TextBox txtProviderInfoProviderID;
        private System.Windows.Forms.Label lblProviderInfoProviderName;
        private System.Windows.Forms.Label lblProviderInfoProviderStatus;
        private System.Windows.Forms.Label lblProviderInfoProviderID;
        private System.Windows.Forms.Label lblProviderInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSearchedProvider;
        private System.Windows.Forms.Button btnProviderIDSearch;
        private System.Windows.Forms.TextBox txtSearchProviderID;
        private System.Windows.Forms.Label lblEnterPolicyID;
        private System.Windows.Forms.Label lblSearchProvider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTreatmentProviderDelete;
        private System.Windows.Forms.Button btnTreatmentProviderAdd;
        private System.Windows.Forms.TextBox txtTreatmentProviderTreatmentID;
        private System.Windows.Forms.TextBox txtTreatmentProviderProviderID;
        private System.Windows.Forms.Label lblTreatmentProviderTreatmentID;
        private System.Windows.Forms.Label lblTreatmentProviderProviderID;
        private System.Windows.Forms.Label lblTreatmentProvider;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvViewAllProviders;
        private System.Windows.Forms.Button btnViewAllProviders;
        private System.Windows.Forms.Label lblViewAllProviders;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvProvidersAndTreatments;
        private System.Windows.Forms.Button btnViewAllProvidersAndTreatments;
        private System.Windows.Forms.Label lblAllProvidersAndTreatments;
        private System.Windows.Forms.TextBox txtProviderPostalCode;
        private System.Windows.Forms.TextBox txtProviderStreetNumAndName;
        private System.Windows.Forms.TextBox txtProviderCity;
        private System.Windows.Forms.Label lblPostalCodeProvider;
        private System.Windows.Forms.Label lblProviderStreetName;
        private System.Windows.Forms.Label lblProviderCity;
    }
}