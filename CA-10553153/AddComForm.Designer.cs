namespace CA_10553153
{
    partial class AddComForm
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBuildingNumber = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.ddlCounty = new System.Windows.Forms.ComboBox();
            this.lblSquareFootage = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.lblIntendedPurpose = new System.Windows.Forms.Label();
            this.txtSquareFootage = new System.Windows.Forms.TextBox();
            this.txtRates = new System.Windows.Forms.TextBox();
            this.ddlIntendedPurpose = new System.Windows.Forms.ComboBox();
            this.epValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBuildNumErr = new System.Windows.Forms.Label();
            this.lblAddLine1Err = new System.Windows.Forms.Label();
            this.lblAddLine2Err = new System.Windows.Forms.Label();
            this.lblTownErr = new System.Windows.Forms.Label();
            this.lblCountyErr = new System.Windows.Forms.Label();
            this.lblEircodeErr = new System.Windows.Forms.Label();
            this.lblSqreFootErr = new System.Windows.Forms.Label();
            this.lblRatesErr = new System.Windows.Forms.Label();
            this.lblIntPurpErr = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(275, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Commercial Building";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBuildingNumber
            // 
            this.lblBuildingNumber.AutoSize = true;
            this.lblBuildingNumber.Location = new System.Drawing.Point(28, 71);
            this.lblBuildingNumber.Name = "lblBuildingNumber";
            this.lblBuildingNumber.Size = new System.Drawing.Size(117, 13);
            this.lblBuildingNumber.TabIndex = 3;
            this.lblBuildingNumber.Text = "Building Name/Number";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(28, 106);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 4;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(28, 141);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 5;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(29, 173);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 6;
            this.lblTown.Text = "Town";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(29, 207);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 7;
            this.lblCounty.Text = "County";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(29, 238);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(43, 13);
            this.lblEircode.TabIndex = 8;
            this.lblEircode.Text = "Eircode";
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(151, 68);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBuildingNumber.TabIndex = 1;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(151, 103);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(100, 20);
            this.txtAddressLine1.TabIndex = 2;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(151, 138);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(100, 20);
            this.txtAddressLine2.TabIndex = 3;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(151, 170);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 4;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(151, 235);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(100, 20);
            this.txtEircode.TabIndex = 6;
            // 
            // ddlCounty
            // 
            this.ddlCounty.FormattingEnabled = true;
            this.ddlCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.ddlCounty.Location = new System.Drawing.Point(151, 204);
            this.ddlCounty.Name = "ddlCounty";
            this.ddlCounty.Size = new System.Drawing.Size(121, 21);
            this.ddlCounty.TabIndex = 5;
            // 
            // lblSquareFootage
            // 
            this.lblSquareFootage.AutoSize = true;
            this.lblSquareFootage.Location = new System.Drawing.Point(29, 315);
            this.lblSquareFootage.Name = "lblSquareFootage";
            this.lblSquareFootage.Size = new System.Drawing.Size(83, 13);
            this.lblSquareFootage.TabIndex = 15;
            this.lblSquareFootage.Text = "Square Footage";
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Location = new System.Drawing.Point(29, 348);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(35, 13);
            this.lblRates.TabIndex = 16;
            this.lblRates.Text = "Rates";
            // 
            // lblIntendedPurpose
            // 
            this.lblIntendedPurpose.AutoSize = true;
            this.lblIntendedPurpose.Location = new System.Drawing.Point(28, 382);
            this.lblIntendedPurpose.Name = "lblIntendedPurpose";
            this.lblIntendedPurpose.Size = new System.Drawing.Size(91, 13);
            this.lblIntendedPurpose.TabIndex = 17;
            this.lblIntendedPurpose.Text = "Intended Purpose";
            // 
            // txtSquareFootage
            // 
            this.txtSquareFootage.Location = new System.Drawing.Point(150, 312);
            this.txtSquareFootage.Name = "txtSquareFootage";
            this.txtSquareFootage.Size = new System.Drawing.Size(100, 20);
            this.txtSquareFootage.TabIndex = 7;
            this.txtSquareFootage.Text = "0.00";
            // 
            // txtRates
            // 
            this.txtRates.Location = new System.Drawing.Point(151, 345);
            this.txtRates.Name = "txtRates";
            this.txtRates.Size = new System.Drawing.Size(100, 20);
            this.txtRates.TabIndex = 8;
            this.txtRates.Text = "0.00";
            // 
            // ddlIntendedPurpose
            // 
            this.ddlIntendedPurpose.FormattingEnabled = true;
            this.ddlIntendedPurpose.Items.AddRange(new object[] {
            "Retail",
            "Industrial",
            "Office"});
            this.ddlIntendedPurpose.Location = new System.Drawing.Point(150, 379);
            this.ddlIntendedPurpose.Name = "ddlIntendedPurpose";
            this.ddlIntendedPurpose.Size = new System.Drawing.Size(121, 21);
            this.ddlIntendedPurpose.TabIndex = 9;
            // 
            // epValidate
            // 
            this.epValidate.ContainerControl = this;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(62, 387);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 21;
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.Location = new System.Drawing.Point(359, 106);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(410, 199);
            this.lstShow.TabIndex = 22;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(91, 33);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(50, 273);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(170, 20);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Building Information";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(434, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 23);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(624, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblBuildNumErr
            // 
            this.lblBuildNumErr.AutoSize = true;
            this.lblBuildNumErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildNumErr.ForeColor = System.Drawing.Color.Red;
            this.lblBuildNumErr.Location = new System.Drawing.Point(257, 75);
            this.lblBuildNumErr.Name = "lblBuildNumErr";
            this.lblBuildNumErr.Size = new System.Drawing.Size(0, 9);
            this.lblBuildNumErr.TabIndex = 27;
            // 
            // lblAddLine1Err
            // 
            this.lblAddLine1Err.AutoSize = true;
            this.lblAddLine1Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLine1Err.ForeColor = System.Drawing.Color.Red;
            this.lblAddLine1Err.Location = new System.Drawing.Point(256, 106);
            this.lblAddLine1Err.Name = "lblAddLine1Err";
            this.lblAddLine1Err.Size = new System.Drawing.Size(0, 9);
            this.lblAddLine1Err.TabIndex = 28;
            // 
            // lblAddLine2Err
            // 
            this.lblAddLine2Err.AutoSize = true;
            this.lblAddLine2Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLine2Err.ForeColor = System.Drawing.Color.Red;
            this.lblAddLine2Err.Location = new System.Drawing.Point(255, 141);
            this.lblAddLine2Err.Name = "lblAddLine2Err";
            this.lblAddLine2Err.Size = new System.Drawing.Size(0, 9);
            this.lblAddLine2Err.TabIndex = 29;
            // 
            // lblTownErr
            // 
            this.lblTownErr.AutoSize = true;
            this.lblTownErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownErr.ForeColor = System.Drawing.Color.Red;
            this.lblTownErr.Location = new System.Drawing.Point(254, 173);
            this.lblTownErr.Name = "lblTownErr";
            this.lblTownErr.Size = new System.Drawing.Size(0, 9);
            this.lblTownErr.TabIndex = 30;
            // 
            // lblCountyErr
            // 
            this.lblCountyErr.AutoSize = true;
            this.lblCountyErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyErr.ForeColor = System.Drawing.Color.Red;
            this.lblCountyErr.Location = new System.Drawing.Point(279, 207);
            this.lblCountyErr.Name = "lblCountyErr";
            this.lblCountyErr.Size = new System.Drawing.Size(0, 9);
            this.lblCountyErr.TabIndex = 31;
            // 
            // lblEircodeErr
            // 
            this.lblEircodeErr.AutoSize = true;
            this.lblEircodeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircodeErr.ForeColor = System.Drawing.Color.Red;
            this.lblEircodeErr.Location = new System.Drawing.Point(253, 235);
            this.lblEircodeErr.Name = "lblEircodeErr";
            this.lblEircodeErr.Size = new System.Drawing.Size(0, 9);
            this.lblEircodeErr.TabIndex = 32;
            // 
            // lblSqreFootErr
            // 
            this.lblSqreFootErr.AutoSize = true;
            this.lblSqreFootErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqreFootErr.ForeColor = System.Drawing.Color.Red;
            this.lblSqreFootErr.Location = new System.Drawing.Point(252, 312);
            this.lblSqreFootErr.Name = "lblSqreFootErr";
            this.lblSqreFootErr.Size = new System.Drawing.Size(0, 9);
            this.lblSqreFootErr.TabIndex = 33;
            // 
            // lblRatesErr
            // 
            this.lblRatesErr.AutoSize = true;
            this.lblRatesErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatesErr.ForeColor = System.Drawing.Color.Red;
            this.lblRatesErr.Location = new System.Drawing.Point(255, 348);
            this.lblRatesErr.Name = "lblRatesErr";
            this.lblRatesErr.Size = new System.Drawing.Size(0, 9);
            this.lblRatesErr.TabIndex = 34;
            // 
            // lblIntPurpErr
            // 
            this.lblIntPurpErr.AutoSize = true;
            this.lblIntPurpErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntPurpErr.ForeColor = System.Drawing.Color.Red;
            this.lblIntPurpErr.Location = new System.Drawing.Point(278, 381);
            this.lblIntPurpErr.Name = "lblIntPurpErr";
            this.lblIntPurpErr.Size = new System.Drawing.Size(0, 9);
            this.lblIntPurpErr.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(176, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Property List";
            // 
            // AddComForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblIntPurpErr);
            this.Controls.Add(this.lblRatesErr);
            this.Controls.Add(this.lblSqreFootErr);
            this.Controls.Add(this.lblEircodeErr);
            this.Controls.Add(this.lblCountyErr);
            this.Controls.Add(this.lblTownErr);
            this.Controls.Add(this.lblAddLine2Err);
            this.Controls.Add(this.lblAddLine1Err);
            this.Controls.Add(this.lblBuildNumErr);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.ddlIntendedPurpose);
            this.Controls.Add(this.txtRates);
            this.Controls.Add(this.txtSquareFootage);
            this.Controls.Add(this.lblIntendedPurpose);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.lblSquareFootage);
            this.Controls.Add(this.ddlCounty);
            this.Controls.Add(this.txtEircode);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.txtBuildingNumber);
            this.Controls.Add(this.lblEircode);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblBuildingNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Name = "AddComForm";
            this.Text = "AddComForm";
            ((System.ComponentModel.ISupportInitialize)(this.epValidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBuildingNumber;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtBuildingNumber;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.ComboBox ddlCounty;
        private System.Windows.Forms.Label lblSquareFootage;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label lblIntendedPurpose;
        private System.Windows.Forms.TextBox txtSquareFootage;
        private System.Windows.Forms.TextBox txtRates;
        private System.Windows.Forms.ComboBox ddlIntendedPurpose;
        private System.Windows.Forms.ErrorProvider epValidate;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblBuildNumErr;
        private System.Windows.Forms.Label lblAddLine1Err;
        private System.Windows.Forms.Label lblAddLine2Err;
        private System.Windows.Forms.Label lblTownErr;
        private System.Windows.Forms.Label lblCountyErr;
        private System.Windows.Forms.Label lblEircodeErr;
        private System.Windows.Forms.Label lblSqreFootErr;
        private System.Windows.Forms.Label lblRatesErr;
        private System.Windows.Forms.Label lblIntPurpErr;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}