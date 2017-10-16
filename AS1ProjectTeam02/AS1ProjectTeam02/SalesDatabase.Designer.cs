namespace AS1ProjectTeam02
{
    partial class salesDatabase
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
            this.openPSVDialog = new System.Windows.Forms.OpenFileDialog();
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.lTotalTransaction = new System.Windows.Forms.Label();
            this.totalTrans = new System.Windows.Forms.Label();
            this.avgTransAmt = new System.Windows.Forms.Label();
            this.lAvgTransAmt = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lvProvince = new System.Windows.Forms.ListView();
            this.lvShippingMode = new System.Windows.Forms.ListView();
            this.lvProductCategory = new System.Windows.Forms.ListView();
            this.lvProductSubCategory = new System.Windows.Forms.ListView();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.totalProfits = new System.Windows.Forms.Label();
            this.lTotalProfits = new System.Windows.Forms.Label();
            this.totalOrders = new System.Windows.Forms.Label();
            this.lTotalOrders = new System.Windows.Forms.Label();
            this.totalCustomer = new System.Windows.Forms.Label();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.lTotalCustomer = new System.Windows.Forms.Label();
            this.profitMarginFilter = new System.Windows.Forms.CheckBox();
            this.tbProfitMargin = new System.Windows.Forms.TextBox();
            this.bReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openPSVDialog
            // 
            this.openPSVDialog.FileName = "openPSVDialog";
            // 
            // salesGridView
            // 
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Location = new System.Drawing.Point(12, 12);
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.Size = new System.Drawing.Size(1087, 150);
            this.salesGridView.TabIndex = 0;
            // 
            // lTotalTransaction
            // 
            this.lTotalTransaction.AutoSize = true;
            this.lTotalTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalTransaction.Location = new System.Drawing.Point(785, 179);
            this.lTotalTransaction.Name = "lTotalTransaction";
            this.lTotalTransaction.Size = new System.Drawing.Size(107, 15);
            this.lTotalTransaction.TabIndex = 1;
            this.lTotalTransaction.Text = "Total Transactions";
            // 
            // totalTrans
            // 
            this.totalTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTrans.Location = new System.Drawing.Point(898, 179);
            this.totalTrans.Name = "totalTrans";
            this.totalTrans.Size = new System.Drawing.Size(133, 20);
            this.totalTrans.TabIndex = 2;
            // 
            // avgTransAmt
            // 
            this.avgTransAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgTransAmt.Location = new System.Drawing.Point(187, 179);
            this.avgTransAmt.Name = "avgTransAmt";
            this.avgTransAmt.Size = new System.Drawing.Size(133, 20);
            this.avgTransAmt.TabIndex = 4;
            // 
            // lAvgTransAmt
            // 
            this.lAvgTransAmt.AutoSize = true;
            this.lAvgTransAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvgTransAmt.Location = new System.Drawing.Point(12, 179);
            this.lAvgTransAmt.Name = "lAvgTransAmt";
            this.lAvgTransAmt.Size = new System.Drawing.Size(169, 15);
            this.lAvgTransAmt.TabIndex = 3;
            this.lAvgTransAmt.Text = "Average Transactions Amount";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.lvProvince);
            this.gbFilter.Controls.Add(this.lvShippingMode);
            this.gbFilter.Controls.Add(this.lvProductCategory);
            this.gbFilter.Controls.Add(this.lvProductSubCategory);
            this.gbFilter.Location = new System.Drawing.Point(15, 216);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(433, 257);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filters";
            // 
            // lvProvince
            // 
            this.lvProvince.CheckBoxes = true;
            this.lvProvince.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProvince.Location = new System.Drawing.Point(275, 16);
            this.lvProvince.Name = "lvProvince";
            this.lvProvince.Size = new System.Drawing.Size(148, 235);
            this.lvProvince.TabIndex = 3;
            this.lvProvince.UseCompatibleStateImageBehavior = false;
            this.lvProvince.View = System.Windows.Forms.View.Details;
            // 
            // lvShippingMode
            // 
            this.lvShippingMode.CheckBoxes = true;
            this.lvShippingMode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvShippingMode.Location = new System.Drawing.Point(150, 139);
            this.lvShippingMode.Name = "lvShippingMode";
            this.lvShippingMode.Size = new System.Drawing.Size(119, 112);
            this.lvShippingMode.TabIndex = 2;
            this.lvShippingMode.UseCompatibleStateImageBehavior = false;
            this.lvShippingMode.View = System.Windows.Forms.View.Details;
            // 
            // lvProductCategory
            // 
            this.lvProductCategory.CheckBoxes = true;
            this.lvProductCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProductCategory.Location = new System.Drawing.Point(150, 16);
            this.lvProductCategory.Name = "lvProductCategory";
            this.lvProductCategory.Size = new System.Drawing.Size(119, 117);
            this.lvProductCategory.TabIndex = 1;
            this.lvProductCategory.UseCompatibleStateImageBehavior = false;
            this.lvProductCategory.View = System.Windows.Forms.View.Details;
            // 
            // lvProductSubCategory
            // 
            this.lvProductSubCategory.CheckBoxes = true;
            this.lvProductSubCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProductSubCategory.LabelEdit = true;
            this.lvProductSubCategory.Location = new System.Drawing.Point(6, 16);
            this.lvProductSubCategory.Name = "lvProductSubCategory";
            this.lvProductSubCategory.Size = new System.Drawing.Size(138, 235);
            this.lvProductSubCategory.TabIndex = 0;
            this.lvProductSubCategory.UseCompatibleStateImageBehavior = false;
            this.lvProductSubCategory.View = System.Windows.Forms.View.Details;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.totalProfits);
            this.gbResult.Controls.Add(this.lTotalProfits);
            this.gbResult.Controls.Add(this.totalOrders);
            this.gbResult.Controls.Add(this.lTotalOrders);
            this.gbResult.Controls.Add(this.totalCustomer);
            this.gbResult.Controls.Add(this.resultGridView);
            this.gbResult.Controls.Add(this.lTotalCustomer);
            this.gbResult.Location = new System.Drawing.Point(454, 216);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(645, 320);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // totalProfits
            // 
            this.totalProfits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalProfits.Location = new System.Drawing.Point(510, 286);
            this.totalProfits.Name = "totalProfits";
            this.totalProfits.Size = new System.Drawing.Size(104, 20);
            this.totalProfits.TabIndex = 12;
            this.totalProfits.Text = "$0.00";
            // 
            // lTotalProfits
            // 
            this.lTotalProfits.AutoSize = true;
            this.lTotalProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalProfits.Location = new System.Drawing.Point(441, 290);
            this.lTotalProfits.Name = "lTotalProfits";
            this.lTotalProfits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTotalProfits.Size = new System.Drawing.Size(66, 13);
            this.lTotalProfits.TabIndex = 11;
            this.lTotalProfits.Text = "Total Profits:";
            // 
            // totalOrders
            // 
            this.totalOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOrders.Location = new System.Drawing.Point(303, 287);
            this.totalOrders.Name = "totalOrders";
            this.totalOrders.Size = new System.Drawing.Size(104, 20);
            this.totalOrders.TabIndex = 10;
            this.totalOrders.Text = "0";
            // 
            // lTotalOrders
            // 
            this.lTotalOrders.AutoSize = true;
            this.lTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalOrders.Location = new System.Drawing.Point(229, 291);
            this.lTotalOrders.Name = "lTotalOrders";
            this.lTotalOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTotalOrders.Size = new System.Drawing.Size(68, 13);
            this.lTotalOrders.TabIndex = 9;
            this.lTotalOrders.Text = "Total Orders:";
            // 
            // totalCustomer
            // 
            this.totalCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCustomer.Location = new System.Drawing.Point(93, 287);
            this.totalCustomer.Name = "totalCustomer";
            this.totalCustomer.Size = new System.Drawing.Size(104, 20);
            this.totalCustomer.TabIndex = 8;
            this.totalCustomer.Text = "0";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(0, 16);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.Size = new System.Drawing.Size(620, 264);
            this.resultGridView.TabIndex = 0;
            // 
            // lTotalCustomer
            // 
            this.lTotalCustomer.AutoSize = true;
            this.lTotalCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalCustomer.Location = new System.Drawing.Point(7, 291);
            this.lTotalCustomer.Name = "lTotalCustomer";
            this.lTotalCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTotalCustomer.Size = new System.Drawing.Size(81, 13);
            this.lTotalCustomer.TabIndex = 7;
            this.lTotalCustomer.Text = "Total Customer:";
            // 
            // profitMarginFilter
            // 
            this.profitMarginFilter.AutoSize = true;
            this.profitMarginFilter.Location = new System.Drawing.Point(165, 479);
            this.profitMarginFilter.Name = "profitMarginFilter";
            this.profitMarginFilter.Size = new System.Drawing.Size(104, 17);
            this.profitMarginFilter.TabIndex = 8;
            this.profitMarginFilter.Text = "ProfitMarginFilter";
            this.profitMarginFilter.UseVisualStyleBackColor = true;
            // 
            // tbProfitMargin
            // 
            this.tbProfitMargin.Location = new System.Drawing.Point(290, 475);
            this.tbProfitMargin.Name = "tbProfitMargin";
            this.tbProfitMargin.Size = new System.Drawing.Size(30, 20);
            this.tbProfitMargin.TabIndex = 9;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(21, 512);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(90, 23);
            this.bReset.TabIndex = 10;
            this.bReset.Text = "Reset Filter";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // salesDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 548);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.tbProfitMargin);
            this.Controls.Add(this.profitMarginFilter);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.avgTransAmt);
            this.Controls.Add(this.lAvgTransAmt);
            this.Controls.Add(this.totalTrans);
            this.Controls.Add(this.lTotalTransaction);
            this.Controls.Add(this.salesGridView);
            this.Name = "salesDatabase";
            this.Text = "Sales Database";
            this.Load += new System.EventHandler(this.salesDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPSVDialog;
        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.Label lTotalTransaction;
        private System.Windows.Forms.Label totalTrans;
        private System.Windows.Forms.Label avgTransAmt;
        private System.Windows.Forms.Label lAvgTransAmt;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label totalProfits;
        private System.Windows.Forms.Label lTotalProfits;
        private System.Windows.Forms.Label totalOrders;
        private System.Windows.Forms.Label lTotalOrders;
        private System.Windows.Forms.Label totalCustomer;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.Label lTotalCustomer;
        private System.Windows.Forms.ListView lvProvince;
        private System.Windows.Forms.ListView lvShippingMode;
        private System.Windows.Forms.ListView lvProductCategory;
        private System.Windows.Forms.ListView lvProductSubCategory;
        private System.Windows.Forms.CheckBox profitMarginFilter;
        private System.Windows.Forms.TextBox tbProfitMargin;
        private System.Windows.Forms.Button bReset;
    }
}

