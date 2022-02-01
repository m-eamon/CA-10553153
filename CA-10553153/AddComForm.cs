using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_10553153
{
    public partial class AddComForm : Form
    {
        CommercialBuilds commercialBuildsList = new CommercialBuilds();
        public AddComForm()
        {
            InitializeComponent();
            btnUpdate.Visible = false;

            // create test data here - Add 3 items to the list and call ShowForm()
            Address addr1 = new Address("123", "The Grove", "Main Street", "Dundalk", CountyEnum.Louth, "123 AAA");
            Address addr2 = new Address("234", "The Square", "Main Street", "Baltinglass", CountyEnum.Wicklow, "234 BBB");
            Address addr3 = new Address("456", "Main Street", "NA", "Clonakilty", CountyEnum.Cork, "456 CCC");

            CommercialBuild build1 = new CommercialBuild(addr1, 123.45, 1000.00, IntendedPurposeEnum.Industrial);
            CommercialBuild build2 = new CommercialBuild(addr2, 234.56, 2000.00, IntendedPurposeEnum.Retail);
            CommercialBuild build3 = new CommercialBuild(addr3, 345.67, 3000.00, IntendedPurposeEnum.Office);

            commercialBuildsList.AddBuilding(build1);
            commercialBuildsList.AddBuilding(build2);
            commercialBuildsList.AddBuilding(build3);

            
            ClearForm();
            ShowListInForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearForm();

            Form openOriginalForm = Application.OpenForms["MainForm"];
            openOriginalForm.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (CheckFormFields())
            {
                // build the address object
                Address buildingAddress = CreateAddress();

                // build the CommerialBuild object
                CommercialBuild building = CreateCommercialBuilding(buildingAddress);
            
                if (commercialBuildsList.AddBuilding(building))
                {
                    MessageBox.Show("Commerical Building has been added");
                }
                else MessageBox.Show("Cannot add building.  Already in list");

                // need to clear out the entries on the form
                ClearForm();

                // show commercialBuildsList
                ShowListInForm();

            }
        }

       
        private Address CreateAddress()
        {
            string buildingNumber = txtBuildingNumber.Text;
            string addressLine1 = txtAddressLine1.Text;
            string addressLine2 = txtAddressLine2.Text;
            string town = txtTown.Text;
            CountyEnum county = Utilities.GetCounty(ddlCounty.SelectedItem.ToString());
            string eircode = txtEircode.Text;
            Address address = new Address(buildingNumber, addressLine1, addressLine2, town, county, eircode);
            return address;
        }

        private CommercialBuild CreateCommercialBuilding(Address buildingAddress)
        {
            double.TryParse(txtSquareFootage.Text, out double squareFootage);
            double.TryParse(txtRates.Text, out double rates);
            IntendedPurposeEnum intendedPurpose = Utilities.GetIntendedPurpose(ddlIntendedPurpose.SelectedItem.ToString());
            CommercialBuild building = new CommercialBuild(buildingAddress, squareFootage, rates, intendedPurpose);
            return building;
        }


        public void ShowListInForm()
        {
            lstShow.Items.Clear();

            foreach (var cbl in commercialBuildsList)
            {
                lstShow.Items.Add(cbl.ShowBuilding());
            }
        }

        private void ClearForm()
        {
            txtBuildingNumber.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtTown.Clear();
            txtEircode.Clear();
            txtSquareFootage.Text = "0.00";
            txtRates.Clear();
            ddlCounty.Text = String.Empty;
            ddlIntendedPurpose.Text = String.Empty;
        }

       
        private bool CheckFormFields()
        {
            bool proceed = true;
            // check that the user has populated this field
            if (string.IsNullOrEmpty(txtBuildingNumber.Text))
            {
                
                lblBuildNumErr.Text = "Building Name/Number required";
                proceed = false;
            }
            else
            {
                lblBuildNumErr.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtAddressLine1.Text))
            {
                lblAddLine1Err.Text = "Address Line 1 required";
                proceed = false;
                
            }
            else
            {
                lblAddLine1Err.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtAddressLine2.Text))
            {
                lblAddLine2Err.Text = "Address Line 2 required";
                proceed = false;
            }
            else
            {
                lblAddLine2Err.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtTown.Text))
            {
                lblTownErr.Text = "Town required";
                proceed = false;
            }
            else
            {
                lblTownErr.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtEircode.Text))
            {
                lblEircodeErr.Text = "Eircode required";
                proceed = false;
            }
            else
            {
                lblEircodeErr.Text = string.Empty;
            }           

            double squareFootage = 0;

            // Check that the user enters a positive number > 0 in the 
            // Square Footage text box
            if (double.TryParse(txtSquareFootage.Text, out squareFootage))
            {
                if (squareFootage <= 0)
                {
                    lblSqreFootErr.Text = "Square footage must be > 0";
                    proceed = false;
                }
                else
                {
                    lblSqreFootErr.Text = string.Empty;
                }
            }
            else
            {
                lblSqreFootErr.Text = "Square footage must be a number";
                proceed = false;
            }

            double rates = 0;

            if (double.TryParse(txtRates.Text, out rates))
            {
                if (rates <= 0)
                {
                    lblRatesErr.Text = "Rates must be > 0";
                    proceed = false;
                }
                else
                {
                    lblRatesErr.Text = string.Empty;
                }
            }
            else
            {
                lblRatesErr.Text = "Rates must be a number";
                proceed = false;
            }

            if (string.IsNullOrEmpty(ddlCounty.Text))
            {
                lblCountyErr.Text = "County must be selected";
                proceed = false;
            }
            else
            {
                lblCountyErr.Text = string.Empty;
            }


            if (string.IsNullOrEmpty(ddlIntendedPurpose.Text))
            {
                lblIntPurpErr.Text = "A purpose must be selected";
                proceed = false;
            }
            else
            {
                lblIntPurpErr.Text = string.Empty;
            }

            return proceed;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
 
            try
            {
                string selItem = lstShow.SelectedItem.ToString();
                // Extract the unique eircode from the selected item in the list
                // This is what will be used to finding the building to delete
                string[] eircodeArr = selItem.Split(',');
                string eircode = eircodeArr[0].Substring(9, (eircodeArr[0].Length) - 9);

                bool result = commercialBuildsList.RemoveByEircode(eircode);

                if (result)
                {
                    MessageBox.Show("Building was deleted from the list");
                }
                else
                    MessageBox.Show("Could not remove building from the list");
                
                ClearForm();
                ShowListInForm();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("A building must be selected");
            }
                                   
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string selItem = lstShow.SelectedItem.ToString();
                // Extract the unique eircode from the selected item in the list
                // This is what will be used to finding the building to delete
                string[] eircodeArr = selItem.Split(',');
                string eircode = eircodeArr[0].Substring(9, (eircodeArr[0].Length) - 9);

                CommercialBuild cb = commercialBuildsList.GetCommercialBuild(eircode);

                txtBuildingNumber.Text = cb.BuildingAddress.BuildingNumber;
                txtAddressLine1.Text = cb.BuildingAddress.AddressLine1;
                txtAddressLine2.Text = cb.BuildingAddress.AddressLine2;
                txtTown.Text = cb.BuildingAddress.Town;
                ddlCounty.Text = cb.BuildingAddress.County.ToString();
                txtEircode.Text = cb.BuildingAddress.Eircode;
                txtSquareFootage.Text = cb.SquareFootage.ToString();
                txtRates.Text = cb.Rates.ToString();
                ddlIntendedPurpose.Text = cb.IntendedPurpose.ToString();
                txtEircode.ReadOnly = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("A building must be selected");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // delete building from list and add it again with changed information

            bool result = commercialBuildsList.RemoveByEircode(txtEircode.Text);

            if (result)
            {
                if (CheckFormFields())
                {
                    // build the address object
                    Address buildingAddress = CreateAddress();

                    // build the CommerialBuild object
                    CommercialBuild building = CreateCommercialBuilding(buildingAddress);

                    if (commercialBuildsList.AddBuilding(building))
                    {
                        MessageBox.Show("Commerical Building has been updated.");
                    }
                    else MessageBox.Show("Could not update Commmercial Building");

                    // need to clear out the entries on the form
                    ClearForm();

                    txtEircode.ReadOnly = false;
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    // show commercialBuildsList
                    ShowListInForm();
                }
            }
            else
                MessageBox.Show("Could not update Commercial Building");
        }
    }

}
