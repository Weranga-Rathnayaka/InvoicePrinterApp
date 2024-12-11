using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePrinterAppNew
{
    public partial class MainForm : Form
    {
        private string customerName, itemName;
        private string quantity;
        private DateTime purchaseDate, warrantyEndDate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            customerName = txtCustomerName.Text;
            itemName = txtItemName.Text;
            quantity = txtQuantity.Text;
            purchaseDate = dtpPurchaseDate.Value;
            warrantyEndDate = purchaseDate.AddYears(1);

            // Preview and print the invoice
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument1,
                Width = 800,
                Height = 600
            };
            previewDialog.ShowDialog();
        }




        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // A6 Page Dimensions (in pixels at 96 DPI)
            int pageWidth = 413; // 105mm in pixels
            int pageHeight = 583; // 148mm in pixels

            // Set a margin for the content
            int margin = 15;
            int yPosition = margin;

            // Fonts and Brushes
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);
            Font footerFont = new Font("Arial", 10, FontStyle.Italic);
            Brush textBrush = Brushes.Black;
            Pen linePen = new Pen(Color.Black, 1);

            // Add Multiple Small Watermarks Vertically
            Font watermarkFont = new Font("Arial", 10, FontStyle.Bold); // Small font size for watermarks
            Brush watermarkBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)); // Light gray with opacity
            int watermarkSpacing = 50; // Spacing between watermarks

            for (int y = margin; y < pageHeight; y += watermarkSpacing)
            {
                g.DrawString("Tech Rev Solutions", watermarkFont, watermarkBrush, new PointF(pageWidth / 2 - 70, y));
            }

            // Draw the Header (Company Name Box)
            g.DrawRectangle(linePen, margin, yPosition, pageWidth - 2 * margin, 50);
            g.DrawString("Tech Rev Solutions", headerFont, textBrush, new PointF(pageWidth / 2 - 120, yPosition + 15));
            yPosition += 55;

            // Invoice Title
            g.DrawString("INVOICE", subHeaderFont, textBrush, new PointF(pageWidth / 2 - 65, yPosition));
            yPosition += 35;

            // Draw a Separator Line
            g.DrawLine(linePen, margin, yPosition, pageWidth - margin, yPosition);
            yPosition += 15;

            // Invoice Information Section
            g.DrawString($"Date: {DateTime.Now:dd/MM/yyyy}", bodyFont, textBrush, margin, yPosition);
            yPosition += 20;

            g.DrawString($"Invoice No: {Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}", bodyFont, textBrush, margin, yPosition);
            yPosition += 25;

            // Draw Customer Details Box
            g.DrawRectangle(linePen, margin, yPosition, pageWidth - 2 * margin, 70);
            g.DrawString("Customer Details", subHeaderFont, textBrush, new PointF(margin + 5, yPosition + 5));
            yPosition += 25;

            g.DrawString($"Name: {customerName}", bodyFont, textBrush, new PointF(margin + 5, yPosition + 5));
            yPosition += 25;

            // Item Details Section
            g.DrawString("Item Details", subHeaderFont, textBrush, margin, yPosition + 20);
            yPosition += 40;

            g.DrawString($"Item: {itemName}", bodyFont, textBrush, margin, yPosition);
            yPosition += 20;

            g.DrawString($"EMEI No: {quantity}", bodyFont, textBrush, margin, yPosition);
            yPosition += 20;

            g.DrawString($"Purchase Date: {purchaseDate:dd/MM/yyyy}", bodyFont, textBrush, margin, yPosition);
            yPosition += 20;

            g.DrawString($"Warranty End Date: {warrantyEndDate:dd/MM/yyyy}", bodyFont, textBrush, margin, yPosition);
            yPosition += 25;

            // Draw Separator Line
            g.DrawLine(linePen, margin, yPosition, pageWidth - margin, yPosition);
            yPosition += 15;

            // Footer Section
            g.DrawString("Thank you for your purchase!", footerFont, textBrush, new PointF(pageWidth / 2 - 100, yPosition));
            yPosition += 20;

            g.DrawString("For support, call: 0779488546", footerFont, textBrush, new PointF(pageWidth / 2 - 90, yPosition));

            // Draw Border Around Entire Content
            g.DrawRectangle(linePen, margin, margin, pageWidth - 2 * margin, yPosition - margin);
        }







        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpPurchaseDate.Value = DateTime.Now;
        }
    }
}
