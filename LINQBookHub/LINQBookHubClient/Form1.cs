using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using LINQBookHubClient.StockServiceRef;

namespace LINQBookHubClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductServiceClient client = new ProductServiceClient();
            string result = "";
        }
    }
}
//try
//{
//int productID = Int32.Parse(txtProductID.Text.ToString());
//Product product = client.GetProduct(productID);
//StringBuilder sb = new StringBuilder();
//sb.Append("ProductID:" +
//product.ProductID.ToString() + "\r\n");
//sb.Append("ProductName:" +
//product.ProductName + "\r\n");
//sb.Append("QuantityPerUnit:" +
//product.QuantityPerUnit + "\r\n");
//sb.Append("UnitPrice:" +
//product.UnitPrice.ToString() + "\r\n");
//sb.Append("Discontinued:" +
//product.Discontinued.ToString() + "\r\n");
//sb.Append("RowVersion:");
////foreach (var x in product)
////{
////sb.Append(x.ToString());
////sb.Append(" ");
////}
////result = sb.ToString();
////}
//catch (TimeoutException ex)
//{
//result = "The service operation timed out. " +
//ex.Message;
//}
////catch (FaultException<ProductFault> ex)
////{
////result = "ProductFault returned: " +
////ex.Detail.FaultMessage;
////}
//catch (FaultException ex)
//{
//result = "Unknown Fault: " +
//ex.ToString();
//}
//catch (CommunicationException ex)
//{
//result = "There was a communication problem. " +
//ex.Message + ex.StackTrace;
//}
//catch (Exception ex)
//{
//result = "Other excpetion: " +
//ex.Message + ex.StackTrace;
//}
//txtProductDetails.Text = result;
//}
//        }
//    }
//}
