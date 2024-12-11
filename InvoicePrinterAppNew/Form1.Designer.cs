using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace InvoicePrinterAppNew
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCustomerName;
        private Label lblItemName;
        private Label lblQuantity;
        private Label lblPurchaseDate;
        private TextBox txtCustomerName;
        private TextBox txtItemName;
        private TextBox txtQuantity;
        private DateTimePicker dtpPurchaseDate;
        private Button btnPrint;
        private PrintDocument printDocument1;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(50, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Invoice Printer";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 60);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(120, 25);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblItemName.Location = new System.Drawing.Point(20, 100);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(120, 25);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(20, 140);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(120, 25);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "EMEI No:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPurchaseDate.Location = new System.Drawing.Point(20, 180);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(120, 25);
            this.lblPurchaseDate.TabIndex = 7;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(150, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItemName.Location = new System.Drawing.Point(150, 100);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 23);
            this.txtItemName.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(150, 140);
            this.txtQuantity.MaxLength = 3276759;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpPurchaseDate.Location = new System.Drawing.Point(150, 180);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 23);
            this.dtpPurchaseDate.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(150, 230);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 40);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Printer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
