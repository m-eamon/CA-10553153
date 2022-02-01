using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_10553153
{
    public partial class AddResForm : Form
    {

        Rentals rentalsList = new Rentals();
        SalesS salesList = new SalesS();

        public AddResForm()
        {
            InitializeComponent();
            pnlRent.Visible = false;
            pnlSales.Visible = false;

            // create test data here - Add 3 items to the list and call ShowForm()
            Address addr1 = new Address("123", "The Grove", "Main Street", "Dundalk", CountyEnum.Louth, "123 AAA");
            Address addr2 = new Address("234", "The Square", "Main Street", "Baltinglass", CountyEnum.Wicklow, "234 BBB");
            Address addr3 = new Address("345", "The Avenue", "Main Street", "Newbridge", CountyEnum.Kildare, "456 CCC");

            Rental build1 = new Rental(addr1, 1345.00, 250000.00, "Mary Jones", "mary.jones@gmail.com", 1200.00);
            Sales build2 = new Sales(addr2, 2500.00, 400000.00, "John Smyth", "john.symth@hello.ie", StatusEnum.ForSale, 425000.00, DateTime.Now);
            Sales build3 = new Sales(addr3, 3000.00, 600000.00, "Mary Kennedy", "mary.kennedy@hello.ie", StatusEnum.ForSale, 605000.00, DateTime.Now);


            rentalsList.AddBuilding(build1);
            salesList.AddBuilding(build2);
            salesList.AddBuilding(build3);


            ClearForm();
            ShowListInForm();
        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {
            pnlSales.Visible = true;
            pnlRent.Visible = false;
            lblSalesRentalErr.Text = string.Empty;
        }

        private void rbRental_CheckedChanged(object sender, EventArgs e)
        {
            pnlRent.Visible = true;
            pnlSales.Visible = false;
            lblSalesRentalErr.Text = string.Empty;
        }

        
        private void ClearForm()
        {
            txtBuildingNumber.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtTown.Clear();
            ddlCounty.Text = string.Empty;
            txtEircode.Clear();
            txtSquareFootage.Text = "0.00";
            txtOwnerName.Clear();
            txtOwnerEmail.Clear();
            txtValuation.Text = "0.00";
            txtRent.Text = "0.00";
            dtpDateEntered.Text = DateTime.Now.ToString();
            txtAskingPrice.Text = "0.00";
            ddlStatus.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearForm();

            Form openOriginalForm = Application.OpenForms["MainForm"];
            openOriginalForm.Show();
            this.Close();
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


            if (string.IsNullOrEmpty(ddlCounty.Text))
            {
                lblCountyErr.Text = "County must be selected";
                proceed = false;
            }
            else
            {
                lblCountyErr.Text = string.Empty;
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
            // Asking Price text box
            if (double.TryParse(txtSquareFootage.Text, out squareFootage))
            {
                if (squareFootage <= 0)
                {
                    lblSqreFootErr.Text = "Square footage be > 0";
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

            if (string.IsNullOrEmpty(txtOwnerName.Text))
            {
                lblOwnerNameErr.Text = "Owner name required";
                proceed = false;
            }
            else
            {
                lblOwnerNameErr.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtOwnerEmail.Text))
            {
                lblOwnerEmailErr.Text = "Owner email required";
                proceed = false;
            }
            else
            {
                lblOwnerEmailErr.Text = string.Empty;
            }

            double valuation;

            if (double.TryParse(txtValuation.Text, out valuation))
            {
                if (valuation <= 0)
                {
                    lblValuationErr.Text = "Valuation be > 0";
                    proceed = false;
                }
                else
                {
                    lblValuationErr.Text = string.Empty;
                }
            }
            else
            {
                lblValuationErr.Text = "Valuation must be a number";
                proceed = false;
            }

            if (!(rbSales.Checked || rbRental.Checked))
            {
                lblSalesRentalErr.Text = "Type must be chosen";
            }
            else
            {
                lblSalesRentalErr.Text = string.Empty;
            }

            if (rbSales.Checked)
            {
                if (string.IsNullOrEmpty(txtEircode.Text))
                {
                    lblEircodeErr.Text = "Eircode required";
                    proceed = false;
                }
                else
                {
                    lblEircodeErr.Text = string.Empty;
                }

                if (string.IsNullOrEmpty(dtpDateEntered.Value.ToShortDateString()))
                {
                    lblDateEnteredErr.Text = "Date Entered required";
                }
                else
                {
                    lblDateEnteredErr.Text = string.Empty;
                }

                double askingPrice = 0;

                // Check that the user enters a positive number > 0 in the 
                // Asking Price text box
                if (double.TryParse(txtAskingPrice.Text, out askingPrice))
                {
                    if (askingPrice <= 0)
                    {
                        lblAskingPriceErr.Text = "Asking price be > 0";
                        proceed = false;
                    }
                    else
                    {
                        lblAskingPriceErr.Text = string.Empty;
                    }
                }
                else
                {
                    lblAskingPriceErr.Text = "Asking price must be a number";
                    proceed = false;
                }

                if (string.IsNullOrEmpty(ddlStatus.Text))
                {
                    lblStatusErr.Text = "A status must be selected";
                    proceed = false;
                }
                else
                {
                    lblStatusErr.Text = string.Empty;
                }

            }

            if (rbRental.Checked)
            {
                double rent = 0;

                if (double.TryParse(txtRent.Text, out rent))
                {
                    if (rent <= 0)
                    {
                        lblRentErr.Text = "Rent must be > 0";
                        proceed = false;
                    }
                    else
                    {
                        lblRentErr.Text = string.Empty;
                    }
                }
                else
                {
                    lblRentErr.Text = "Rent must be a number";
                    proceed = false;
                }


            }

            return proceed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFormFields())
            {
                //build the address object
                Address buildingAddress = CreateAddress();

                if(rbRental.Checked)
                {
                    // build the rental object
                    Rental building = CreateRentalBuilding(buildingAddress);

                    if (rentalsList.AddBuilding(building))
                    {
                        MessageBox.Show("Rental has been added");
                    }
                    else MessageBox.Show("Rental cannot be added.  Already in list");                    
                }
                else if(rbSales.Checked)
                {
                    // build the sales object
                    Sales building = CreateSalesBuilding(buildingAddress);

                    if (salesList.AddBuilding(building))
                    {
                        MessageBox.Show("Sales building has been added");
                    }
                    else
                        MessageBox.Show("Sales building cannot be added.  Already in list");
                }

                // need to clear out the entries on the form
                ClearForm();

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

        private Sales CreateSalesBuilding(Address buildingAddress)
        {
            double.TryParse(txtSquareFootage.Text, out double squareFootage);
            string name = txtOwnerName.Text;
            string email = txtOwnerEmail.Text;
            double.TryParse(txtValuation.Text, out double valuation);

            DateTime dt = dtpDateEntered.Value;
            double.TryParse(txtAskingPrice.Text, out double askingPrice);
            StatusEnum status = Utilities.GetStatus(ddlStatus.SelectedItem.ToString());

            Sales building = new Sales(buildingAddress, squareFootage, valuation, name, email, status, askingPrice, dt);

            return building;
        }


        private Rental CreateRentalBuilding(Address buildingAddress)
        {
            double.TryParse(txtSquareFootage.Text, out double squareFootage);
            string name = txtOwnerName.Text;
            string email = txtOwnerEmail.Text;
            double.TryParse(txtValuation.Text, out double valuation);
            double.TryParse(txtRent.Text, out double rent);

            Rental building = new Rental(buildingAddress, squareFootage, valuation, name, email, rent);

            return building;
        }

        public void ShowListInForm()
        {
            lstShow.Items.Clear();

            foreach (var rl in rentalsList)
            {
                lstShow.Items.Add(rl.ToString());
            }

            foreach (var sl in salesList)
            {
                lstShow.Items.Add(sl.ShowBuilding());
            }

        }
    }
}
