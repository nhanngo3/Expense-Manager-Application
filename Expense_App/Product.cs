using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Windows.Forms;
using System.Configuration;
namespace Expense_App
{
    public class Product
    {
        public XmlDocument XmlDoc = new XmlDocument();
        public string filePath = ConfigurationManager.AppSettings["filePathXml"];

        public void AddProduct(string strCate, string strDate, string strUnit, string strItName, string strItQuan, string strAmo)
        {
            XmlDoc.Load(filePath);

            foreach (XmlNode xNode in XmlDoc.SelectNodes("root/information"))
                if (xNode.SelectSingleNode("category").InnerText == strCate)
                {
                    if (strCate == " ")
                    {
                        MessageBox.Show("Pick category, please !!!");
                        break;
                    }
                    else
                    {
                        XmlNode prodNode = XmlDoc.CreateElement("product");

                        XmlNode cateMainNode = XmlDoc.CreateElement("categorymain");
                        cateMainNode.InnerText = strCate;

                        XmlNode dateNode = XmlDoc.CreateElement("date");
                        dateNode.InnerText = strDate;

                        XmlNode unitNode = XmlDoc.CreateElement("unit");
                        unitNode.InnerText = strUnit;

                        XmlNode ItNameNode = XmlDoc.CreateElement("itemname");
                        ItNameNode.InnerText = strItName;

                        XmlNode ItQuanNode = XmlDoc.CreateElement("itemquantity");
                        ItQuanNode.InnerText = strItQuan;

                        XmlNode amoNode = XmlDoc.CreateElement("amount");
                        amoNode.InnerText = strAmo;

                        prodNode.AppendChild(cateMainNode);
                        prodNode.AppendChild(dateNode);
                        prodNode.AppendChild(unitNode);
                        prodNode.AppendChild(ItNameNode);
                        prodNode.AppendChild(ItQuanNode);
                        prodNode.AppendChild(amoNode);

                        xNode.AppendChild(prodNode);
                        XmlDoc.Save(filePath);
                        MessageBox.Show("Add expense successful");

                        break;
                    }

                }
        }

        public void DeleteProduct(string strCate, string strDate, string strItemName, string strItemQuanti, string strUnit, string strAmo)
        {
            XmlDoc.Load(filePath);
            XmlNodeList prodNode = XmlDoc.SelectNodes("root/information/product");

            for (int i = 0; i < prodNode.Count; i++)
            {
                if (prodNode[i].SelectSingleNode("categorymain").InnerText == strCate
                    && prodNode[i].SelectSingleNode("date").InnerText == strDate
                    && prodNode[i].SelectSingleNode("itemname").InnerText == strUnit
                    && prodNode[i].SelectSingleNode("unit").InnerText == strItemName
                    && prodNode[i].SelectSingleNode("itemquantity").InnerText == strItemQuanti
                    && prodNode[i].SelectSingleNode("amount").InnerText == strAmo
                    )
                {
                    prodNode[i].ParentNode.RemoveChild(prodNode[i]);
                    XmlDoc.Save(filePath);
                    MessageBox.Show("Delete successfull.");
                    break;
                }
            }
        }



    }
}


