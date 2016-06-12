using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;

namespace Expense_App
{
    public class Infomation
    {
        public XmlDocument XmlDoc = new XmlDocument();
        public string filePath = ConfigurationManager.AppSettings["filePathXml"];
        public void AddInfo(string strCategory)
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);
            XmlNodeList cateNodetemp = XmlDoc.GetElementsByTagName("category");

            bool checkDupCate = isDuplicateCateNode(strCategory);
            if (checkDupCate == true)
            {
                MessageBox.Show("Duplicate category.");
            }
            else
            {
                XmlNode infoNode = XmlDoc.CreateElement("information");
                XmlNode cateNode = XmlDoc.CreateElement("category");
                cateNode.InnerText = strCategory;
                infoNode.AppendChild(cateNode);

                XmlNodeList rootNode = XmlDoc.GetElementsByTagName("root");
                rootNode.Item(0).AppendChild(infoNode);
                XmlDoc.Save(filePath);
                MessageBox.Show("Create category successful.");
            }
        }

        public void DeleteInfor(string strCate)
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);

            foreach (XmlNode infoNode in XmlDoc.SelectNodes("root/information"))
                if (infoNode.SelectSingleNode("category").InnerText == strCate)
                {
                    infoNode.ParentNode.RemoveChild(infoNode);
                    XmlDoc.Save(filePath);
                    break;
                }

            MessageBox.Show("Delete category successful.");
        }

        public void EditInfor(string strCateOld, string strCateNew)
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);
            strCateNew = ExtraWhiteSpace(strCateNew);

            bool checkDupCate = isDuplicateCateNode(strCateNew);
            XmlNodeList infoNode = XmlDoc.GetElementsByTagName("information");

            for (int i = 0; i < infoNode.Count; i++)
            {
                if (checkDupCate == true)
                {
                    MessageBox.Show("Duplicate category !!!");
                    break;
                }
                else
                    if (infoNode[i].SelectSingleNode("category").InnerText == strCateOld)
                    {
                        infoNode[i].SelectSingleNode("category").InnerText = strCateNew;

                        XmlNodeList prodNode = infoNode[i].SelectNodes("product");
                        for (int j = 0; j < prodNode.Count; j++)
                        {
                            prodNode[j].SelectSingleNode("categorymain").InnerText = infoNode[i].SelectSingleNode("category").InnerText;
                        }
                        XmlDoc.Save(filePath);
                        MessageBox.Show("Edit category successful.");
                        break;
                    }
            }
           
        }

        private bool isDuplicateCateNode(string strCateOld)
        {
            bool flag = false;
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlDoc.Load("data.xml");
            XmlDoc.Load(filePath);
            strCateOld = ExtraWhiteSpace(strCateOld);
            XmlNodeList cateNodetemp = XmlDoc.GetElementsByTagName("category");

            for (int i = 0; i < cateNodetemp.Count; i++)
            {
                if (cateNodetemp[i].InnerText.ToLower() == strCateOld.ToLower())
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private string ExtraWhiteSpace(string input)
        {
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }

    }
}
