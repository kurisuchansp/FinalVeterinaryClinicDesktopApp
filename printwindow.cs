using System;
using System.IO;
using System.Threading.Tasks;
using Firebase.Storage;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Auth;
using Firebase.Auth.Providers;
using FireSharp.Config;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace VeterinaryClinicApp
{
    public partial class printwindow : Form
    {
        private Transaction currentTransaction;
        private System.Drawing.Image logoImage;
        public printwindow()
        {
            InitializeComponent();
            logoImage = System.Drawing.Image.FromFile("D:\\capstone2\\codings\\netcore\\VeterinaryClinicApp\\Resources\\printlogo.png");
        }
        public void SetTransactionDetails(Transaction transaction)
        {
            currentTransaction = transaction;
            lblTransactionID.Text = transaction.DocumentID;
            lblAmountPaid.Text = transaction.AmountPaid.ToString("C");
            lblDate.Text = transaction.Date;
            lblService.Text = transaction.Service;
            lblProduct.Text = transaction.Product;
            lblPaymentMethod.Text = transaction.PaymentMethod;
            lblAnimal.Text = transaction.Animal;
            lblDate.Text = transaction.Date;
            lblReferenceID.Text = transaction.ReferenceID.ToString();
            lblCreatedAt.Text = transaction.CreatedAt.ToString();
            lblTotalPrice.Text = transaction.TotalPrice.ToString("C");
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (currentTransaction == null)
            {
                MessageBox.Show("No transaction details available for printing.");
                return;
            }
            Font font = new Font("Courier New", 8);
            float lineHeight = font.GetHeight(e.Graphics) + 2;
            float x = 10;
            float y = 10;
            if (logoImage != null)
            {
                e.Graphics.DrawImage(logoImage, x, y, 200, 100);
                y += 120;
            }
            string[] receiptLines = {
                    "        Veterinary Clinic",
                    "    -----------------------",
                    $"Transaction ID: ",
                    $"{currentTransaction.DocumentID}",
                    $"Date: {DateTime.Now.ToShortDateString()}",
                    $"Time: {DateTime.Now.ToShortTimeString()}",
                    $"Created:         {currentTransaction.Animal}",
                    "",
                    "Service Details:",
                    "-----------------------",
                    $"Service:      {currentTransaction.Service}",
                    $"Product:      {currentTransaction.Product}",
                    "",
                    $"Payment Method: {currentTransaction.PaymentMethod}",
                    $"Animal:       {currentTransaction.Animal}",
                    $"Reference ID:",
                    $"{currentTransaction.ReferenceID}",
                    "",
                    "-----------------------",
                    $"Total Price:    {currentTransaction.TotalPrice:C}",
                    $"Amount Paid:    {currentTransaction.AmountPaid:C}",
                    "-----------------------",
                    "Thank you for your visit!"
             };
            foreach (string line in receiptLines)
            {
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineHeight;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

    }
}
