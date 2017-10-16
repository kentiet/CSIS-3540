using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AS1ProjectTeam02.Entities;


namespace AS1ProjectTeam02
{
    public partial class salesDatabase : Form
    {
        // Global Scope

        List<string> fileContents = new List<string>(); // filecontents to store the parsed record from the PSV file
        PSVParser myParser = new PSVParser(); 
        List<Transaction> myTransaction = new List<Transaction>(); // Transaction list to store the converted record into the right type

        List<string> selectedProSubCategory = new List<string>(); // string list - store to the selected product subcategory 
        List<string> selectedProCategory = new List<string>();   // string list - store the selected product category
        List<string> selectedShippingMode = new List<string>(); // string list - store the selected shipping mode
        List<string> selectedProvince = new List<string>();     // string list - store the selected province

        public salesDatabase()
        {
            InitializeComponent();
        }

        private void salesDatabase_Load(object sender, EventArgs e)
        {
            fileContents = AskUsersForFile(); // Prompt the user for PSV file
            myTransaction = myParser.Parser(fileContents); // Parse the given file

            SetUpSaleGrid(); // Set up the sale grid with proper column
            PopulateSaleGrid(); // Populate the parsed value from the PSV into the correct column from the set sale grid

            totalTrans.Text = myParser.transCounter.ToString(); // Result of the parse counter = total transaction - increase 1 when parse successfully 
            avgTransAmt.Text = CalculateAvgTransAmt().ToString("C"); // call the method to calculate the avaerage transaction amount

            // Populate the List View for: 
            PopulateProductSubCategoryListView();   // <----- Product Subcategory
            PopulateProductCategoryListView();      // <----- Product category
            PopulateShippingModeListView();         // <----- Shipping Mode
            PopulateProvinceListView();             // <----- Province

            SetItemCheck(); // Call method to set the item in specific listview check (Product Category and Shipping Mode)

            // Get the checked value in Product Category and Shipping Mode list views
            selectedProCategory = GetListViewValue(lvProductCategory);  
            selectedShippingMode = GetListViewValue(lvShippingMode); 

            SetUpResultGridView(); // Set up the columns for result grid view

            ToggleEvents(true); 

        }


        // This methis is used to toggle the filter event handlers 
        private void ToggleEvents(bool trigger)
        {
            if (trigger == true) // true -- trun on events
            {

                lvProductSubCategory.ItemChecked += lvProductSubCategory_SelectedIndexChanged;
                lvProvince.ItemChecked += lvProvince_SelectedIndexChanged;
                lvProductCategory.ItemChecked += lvProductCategory_SelectedIndexChanged;
                lvShippingMode.ItemChecked += lvShippingMode_SelectedIndexChanged;

                lvProductSubCategory.ItemChecked += Filter;
                lvProvince.ItemChecked += Filter;
                lvProductCategory.ItemChecked += Filter;
                lvShippingMode.ItemChecked += Filter;
                profitMarginFilter.CheckedChanged += Filter;
                tbProfitMargin.TextChanged += Filter;
                
            }
            else
            {

                lvProductSubCategory.ItemChecked -= lvProductSubCategory_SelectedIndexChanged;
                lvProvince.ItemChecked -= lvProvince_SelectedIndexChanged;
                lvProductCategory.ItemChecked -= lvProductCategory_SelectedIndexChanged;
                lvShippingMode.ItemChecked -= lvShippingMode_SelectedIndexChanged;

                lvProductSubCategory.ItemChecked -= Filter;
                lvProvince.ItemChecked -= Filter;
                lvProductCategory.ItemChecked -= Filter;
                lvShippingMode.ItemChecked -= Filter;
                profitMarginFilter.CheckedChanged -= Filter;
                tbProfitMargin.TextChanged -= Filter;

            }
        }

        // This method is used to calculate the average transaction amount initially when the form load
        private decimal CalculateAvgTransAmt()
        {
            var allSales = from t in myTransaction  
                           select t.sales;

            decimal totalSales = 0;

            foreach (var sale in allSales)
            {
                totalSales += sale;
            }

            return totalSales / Convert.ToInt32(totalTrans.Text);  // totalTrans is the total transaction in the PSV file 
        }

        //This method is used to populate the sale grid originally
        private void PopulateSaleGrid()
        {
            foreach (Transaction t in myTransaction)
            {
                salesGridView.Rows.Add(
                    t.productCategory,
                    t.productSubCategory,
                    t.productName,
                    t.orderQuantity,
                    t.unitPrice.ToString("c"),
                    t.sales.ToString("c"),
                    t.shippingMode,
                    t.profits.ToString("c"),
                    t.customerName,
                    t.customerSegment,
                    t.province
                );
            }

        }

        // This method is used to set up the sale grid
        private void SetUpSaleGrid()
        {
            // Configuration for Sale Grid View
            salesGridView.ReadOnly = true;
            salesGridView.AllowUserToAddRows = false;
            salesGridView.AllowUserToDeleteRows = false;
            salesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            salesGridView.RowHeadersWidth = 30;
            salesGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            salesGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewTextBoxColumn[] c = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Product Category" },
                new DataGridViewTextBoxColumn() {Name = "Product SubCategory" },
                new DataGridViewTextBoxColumn() {Name = "Product Name" },
                new DataGridViewTextBoxColumn() {Name = "Order Quantity" },
                new DataGridViewTextBoxColumn() {Name = "Unit Price" },
                new DataGridViewTextBoxColumn() {Name = "Sales" },
                new DataGridViewTextBoxColumn() {Name = "Shipping Mode" },
                new DataGridViewTextBoxColumn() {Name = "Profit" },
                new DataGridViewTextBoxColumn() {Name = "Customer Name" },
                new DataGridViewTextBoxColumn() {Name = "Customer Segment" },
                new DataGridViewTextBoxColumn() {Name = "Province" }
            };

            salesGridView.Columns.AddRange(c);
        }

        //  Method to set up the columns for the result grid view
        private void SetUpResultGridView()
        {
            // Configuration for result Grid View
            resultGridView.ReadOnly = true;
            resultGridView.AllowUserToAddRows = false;
            resultGridView.AllowUserToDeleteRows = false;
            resultGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            resultGridView.RowHeadersWidth = 30;
            resultGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            resultGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() { Name = "Customer Name" },
                new DataGridViewTextBoxColumn() { Name = "Order Quantity" },
                new DataGridViewTextBoxColumn() { Name = "Unit Price" },
                new DataGridViewTextBoxColumn() { Name = "Sub Total" },
                new DataGridViewTextBoxColumn() { Name = "Profit" },
                new DataGridViewTextBoxColumn() { Name = "Customer Segment" },
            };

            resultGridView.Columns.AddRange(columns);
        }

        // Filter Method 
        private void Filter(object sender, EventArgs e)
        {
            
            resultGridView.Rows.Clear(); // Clear the list view each time filter method invoked

            List<string> filterTotalCustomer = new List<string>(); // List to store the data of total customer of the filtered result
            int filterTotalOrders = 0;
            decimal filterTotalProfits = 0;

            var testedFilter = from t in myTransaction
                               join sc in selectedProSubCategory on t.productSubCategory equals sc
                               join p in selectedProCategory on t.productCategory equals p
                               join s in selectedShippingMode on t.shippingMode equals s
                               join pv in selectedProvince on t.province equals pv
                               select new
                               {
                                   cusName = t.customerName,
                                   orderQ = t.orderQuantity,
                                   uPrice = t.unitPrice,
                                   sTotal = t.orderQuantity * t.unitPrice,
                                   profit = t.profits,
                                   cusSeg = t.customerSegment,
                                   profitMargin = (t.profits/(t.orderQuantity * t.unitPrice)) * 100
                               };

            if (profitMarginFilter.Checked == false)  // When the profit margin filter is UNCHECKED
            {
                foreach (var trans in testedFilter)
                {
                    filterTotalOrders++;
                    filterTotalProfits += trans.profit;
                    filterTotalCustomer.Add(trans.cusName);
                    resultGridView.Rows.Add(
                            trans.cusName,
                            trans.orderQ,
                            trans.uPrice.ToString("c"),
                            trans.sTotal.ToString("c"),
                            trans.profit.ToString("c"),
                            trans.cusSeg
                        );
                }

                totalOrders.Text = filterTotalOrders.ToString();
                totalProfits.Text = filterTotalProfits.ToString("C");
                totalCustomer.Text = filterTotalCustomer.Distinct().Count().ToString();
            }
            else // when profit margin filter is CHECKED
            {

                try
                {
                    decimal userProfitMarginFilter = 0; 

                    if (!string.IsNullOrWhiteSpace(tbProfitMargin.Text))  // verify to ensure there is values put in the textbox
                    {
                        try
                        {
                            userProfitMarginFilter = Convert.ToDecimal(tbProfitMargin.Text); // Parse the user input to decimal type
                        } catch
                        {
                            MessageBox.Show("You must enter an integer for the Profit Margin Filter");
                        }

                        foreach (var trans in testedFilter)
                        {
                            if (trans.profitMargin >= userProfitMarginFilter) // Populate the result if the profit margin is equal or greater than 
                                                                              // user requirement.
                            {
                                filterTotalOrders++;
                                filterTotalProfits += trans.profit;
                                filterTotalCustomer.Add(trans.cusName);
                                resultGridView.Rows.Add(
                                        trans.cusName,
                                        trans.orderQ,
                                        trans.uPrice.ToString("c"),
                                        trans.sTotal.ToString("c"),
                                        trans.profit.ToString("c"),
                                        trans.cusSeg
                                    );
                            }
                        }

                        totalOrders.Text = filterTotalOrders.ToString();
                        totalProfits.Text = filterTotalProfits.ToString("C");
                        totalCustomer.Text = filterTotalCustomer.Distinct().Count().ToString();
                    } else
                    {
                        MessageBox.Show("You should give the Profit Margin Filter a value");
                    }
                } catch (Exception fe)
                {
                    MessageBox.Show(fe.StackTrace);
                }
            }
        }

        // Method to get the checked items in list view and populate it into the string list
        List<string> GetListViewValue(ListView lv)
        {
            List<string> tempList = new List<string>();
            foreach (ListViewItem lvItem in lv.CheckedItems)
            {
                tempList.Add(lvItem.Text);
            }

            return tempList;
        }

        #region Populate ListView

        // Populate the Product SubCategory list view
        private void PopulateProductSubCategoryListView()
        {
            lvProductSubCategory.Items.Clear();

            lvProductSubCategory.Columns.Add("Product SubCategory");

            var productSubCategoryItem = from pSubCate in myTransaction
                                         orderby pSubCate.productSubCategory
                                         select new
                                         {
                                             pSubCate.productSubCategory
                                         };
            
            foreach (var item in productSubCategoryItem.Distinct())
            {
                lvProductSubCategory.Items.Add(new ListViewItem(item.productSubCategory.ToString()));
            }

            lvProductSubCategory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        // Populate the Product Category list view
        private void PopulateProductCategoryListView()
        {
            lvProductCategory.Items.Clear();

            lvProductCategory.Columns.Add("Product Category");

            var productCategoryItem = from pC in myTransaction
                                      select new { pC.productCategory };

            foreach (var item in productCategoryItem.Distinct())
            {
                lvProductCategory.Items.Add(new ListViewItem(item.productCategory.ToString()));
            }

            lvProductCategory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        // Populate the shipping mode list view
        private void PopulateShippingModeListView()
        {
            lvShippingMode.Items.Clear();

            lvShippingMode.Columns.Add("Shipping Mode");

            var shippingModeItem = from sM in myTransaction
                                   select new { sM.shippingMode };

            foreach (var item in shippingModeItem.Distinct())
            {
                lvShippingMode.Items.Add(new ListViewItem(item.shippingMode.ToString()));
            }

            lvShippingMode.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        // Populate the province list view
        private void PopulateProvinceListView()
        {
            lvProvince.Items.Clear();

            lvProvince.Columns.Add("Province");

            var provinceItem = from p in myTransaction
                               orderby p.province
                               select new { p.province };

            foreach (var item in provinceItem.Distinct())
            {
                lvProvince.Items.Add(new ListViewItem(item.province.ToString()));
            }

            lvProvince.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        #endregion

        // Method to set the items to be checked by default 
        private void SetItemCheck()
        {
            for(int i = 0; i < lvProductCategory.Items.Count; i++) // for product category
            {
                lvProductCategory.Items[i].Checked = true;
            }

            for (int a = 0; a < lvShippingMode.Items.Count; a++) // for shipping mode
            {
                lvShippingMode.Items[a].Checked = true;
            }
        }

        #region List View Event Handlers
        // Event handlers to gather the selected item in list view

        // event for product subcategory list view
        private void lvProductSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProSubCategory.Clear();

            if(lvProductSubCategory.CheckedItems.Count > 0) 
            {
                selectedProSubCategory = GetListViewValue(lvProductSubCategory);
            }
        }
            // Event for province list view
        private void lvProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProvince.Clear();

            if (lvProvince.CheckedItems.Count > 0)
            {
                selectedProvince = GetListViewValue(lvProvince);
            }
        }

            // Event for product category list view
        private void lvProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProCategory.Clear();
            if (lvProductCategory.CheckedItems.Count > 0)
            {
                selectedProCategory = GetListViewValue(lvProductCategory);
            }
        }
            // Event for shipping mode list view
        private void lvShippingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShippingMode.Clear();
            if (lvShippingMode.CheckedItems.Count > 0)
            {
                selectedShippingMode = GetListViewValue(lvShippingMode);
            }
        }
        #endregion

        // Reset button method
        private void bReset_Click(object sender, EventArgs e)
        {
            SetItemCheck();
            resultGridView.Rows.Clear();
            profitMarginFilter.Checked = false;
            tbProfitMargin.Text = null;
            totalCustomer.Text = "0";
            totalOrders.Text = "0";
            totalProfits.Text = "$0.00";

            for (int x = 0; x < lvProductSubCategory.Items.Count; x++)
            {
                if (lvProductSubCategory.Items[x].Checked == true)
                {
                    lvProductSubCategory.Items[x].Checked = false;
                }
            }

            for (int y = 0; y < lvProvince.Items.Count; y++)
            {
                if (lvProvince.Items[y].Checked == true)
                {
                    lvProvince.Items[y].Checked = false;
                }
            }
        }

        // Method to prompt for the PSV file
        List<string> AskUsersForFile()
        {
            openPSVDialog.InitialDirectory = @"..\..";

            openPSVDialog.Filter = "PSV File (*.psv) | *.psv";

            StreamReader inputFile;

            if (openPSVDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openPSVDialog.FileName);

                while (inputFile.EndOfStream == false)
                {
                    string line = inputFile.ReadLine();
                    fileContents.Add(line);
                }
            }
            return fileContents;
        }
    }
}


