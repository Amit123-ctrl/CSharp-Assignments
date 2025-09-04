using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_bill
{
     // Delegate for formatting/output
        public delegate void PrintDelegate(CreditNote note, string filePath);
        public class CreditNote
        {
            // Properties
            public string SellerName { get; set; }
            public string SellerAddress { get; set; }
            public string SellerPAN { get; set; }
            public string SellerGST { get; set; }
            public string ShippingName { get; set; }
            public string ShippingAddress { get; set; }
            public string ShippingStateCode { get; set; }
            public string BillingName { get; set; }
            public string BillingAddress { get; set; }
            public string BillingStateCode { get; set; }
            public string PlaceOfSupply { get; set; }
            public string PlaceOfDelivery { get; set; }
            public string OrderNo { get; set; }
            public string OriginalInvoiceNo { get; set; }
            public DateTime OriginalOrderDate { get; set; }
            public string CreditNoteNo { get; set; }
            public string InvoiceDetails { get; set; }
            public DateTime CreditNoteDate { get; set; }
            public string Description { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal TaxRate { get; set; }
            public decimal TaxAmount { get; private set; }
            public decimal TotalAmount { get; private set; }
            public string AmountInWords { get; set; }
            public string ForEntity { get; set; }
            // Method to calculate net & tax
            public void CalculateAmounts()
            {
                var net = UnitPrice * Quantity;
                TaxAmount = (net * TaxRate) / 100;
                TotalAmount = net + TaxAmount;
            }
        }
    internal  class Program
        {
            static void Main()
            {
                // Delegate instance
                PrintDelegate printNote = SaveNoteToFile;

                // Sample Credit Note
                CreditNote note = new CreditNote
                {
                    SellerName = "SUDHA PRAJAPATI",
                    SellerAddress = "GADDE WALA MOHALLA NEAR MISSION SCHOOL...",
                    SellerPAN = "EDPPP9079E",
                    SellerGST = "23EDPPP9079E1ZY",

                    ShippingName = "Amit Giri",
                    ShippingAddress = "H/0/1417, Shriji Vatika, Vrindavan, UP",
                    ShippingStateCode = "09",

                    BillingName = "Amit Giri",
                    BillingAddress = "H/0/1417, Shriji Vatika, Vrindavan, UP",
                    BillingStateCode = "09",

                    PlaceOfSupply = "UTTAR PRADESH",
                    PlaceOfDelivery = "UTTAR PRADESH",

                    OrderNo = "404-8342683-8477110",
                    OriginalInvoiceNo = "IN-194",
                    OriginalOrderDate = new DateTime(2025, 8, 20),

                    CreditNoteNo = "CN-38",
                    InvoiceDetails = "539125683-2526",
                    CreditNoteDate = new DateTime(2025, 8, 26),

                    Description = "ADVANCED GROWTH POWER AYURVEDIC PROTEIN POWDER NO FLAVOUR 180GM PACK OF 2",
                    UnitPrice = 411.02m,
                    Quantity = 1,
                    TaxRate = 18m,

                    AmountInWords = "Four Hundred Eighty-five only",
                    ForEntity = "SUDHA PRAJAPATI"
                };

                // Calculate totals
                note.CalculateAmounts();

                // Save to text file using delegate
                string filePath = "CreditNote_CN38.txt";
                printNote(note, filePath);

                Console.WriteLine($"Credit Note saved to: {filePath}");
            }

            // Delegate method to write note into text file
            static void SaveNoteToFile(CreditNote note, string filePath)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("===== CREDIT NOTE =====\n");
                    writer.WriteLine($"Seller: {note.SellerName}");
                    writer.WriteLine($"Address: {note.SellerAddress}");
                    writer.WriteLine($"PAN: {note.SellerPAN}, GST: {note.SellerGST}\n");

                    writer.WriteLine($"Buyer: {note.BillingName}");
                    writer.WriteLine($"Address: {note.BillingAddress}");
                    writer.WriteLine($"State Code: {note.BillingStateCode}\n");

                    writer.WriteLine($"Order No: {note.OrderNo}, Invoice No: {note.OriginalInvoiceNo}");
                    writer.WriteLine($"Original Order Date: {note.OriginalOrderDate:dd-MM-yyyy}");
                    writer.WriteLine($"Credit Note No: {note.CreditNoteNo}, Date: {note.CreditNoteDate:dd-MM-yyyy}");
                    writer.WriteLine($"Invoice Details: {note.InvoiceDetails}\n");

                    writer.WriteLine("Item:");
                    writer.WriteLine(note.Description);
                    writer.WriteLine($"Qty: {note.Quantity}, Unit Price: ₹{note.UnitPrice}, Net: ₹{note.UnitPrice * note.Quantity}");
                    writer.WriteLine($"Tax: {note.TaxRate}%, Tax Amt: ₹{note.TaxAmount}, Total: ₹{note.TotalAmount}\n");

                    writer.WriteLine($"Amount in Words: {note.AmountInWords}\n");
                    writer.WriteLine($"For {note.ForEntity}: Authorized Signatory");
                }
            }
        }
    }

