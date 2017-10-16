using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam02.Entities
{
    /*
     * This is the class used to parse the file contents from users in to the Transaction type
    */
    class PSVParser
    {
        List<Transaction> transactions = new List<Transaction>(); // Instantiate the transaction object to carry the contents when parse

        public int transCounter { get; set; } // transaction counter 
                                              // this will increase each time when the parser is called
        public List<Transaction> Parser(List<string> fileContents)
        {
            try
            {
                for (int i = 1; i < fileContents.Count; i++)
                {
                    string[] fields = fileContents.ElementAt(i).Split('|'); // Split eachline of the content by '|'

                    transCounter++;

                    if (fields.Length != 12)
                    {
                        break;
                    }
                    else
                    {
                        Transaction t = new Transaction();

                        // Allocate each splited value to the actually property it's supposed to be
                        t.id = Convert.ToInt16(fields[0].Trim());
                        t.orderQuantity = Convert.ToInt32(fields[1].Trim());
                        t.sales = Convert.ToDecimal(fields[2].Trim());
                        t.shippingMode = fields[3].Trim();
                        t.profits = Convert.ToDecimal(fields[4].Trim());
                        t.unitPrice = Convert.ToDecimal(fields[5].Trim());
                        t.customerName = fields[6].Trim();
                        t.province = fields[7].Trim();
                        t.customerSegment = fields[8].Trim();
                        t.productCategory = fields[9].Trim();
                        t.productSubCategory = fields[10].Trim();
                        t.productName = fields[11].Trim();

                        transactions.Add(t);
                    }
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return transactions; // Return the transcaction list
        }
    }
}
