using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Xml;

/// <summary>
/// The main class that processes all information
/// </summary>
/// 
namespace XMLAnalysis
{
    public class Analysis
    {
        /// <summary>
        /// Takes in a xml file in order to check that there are not multiple columns in the same row with data, as well as checking that 
        /// the only data inputted is '1'.
        /// </summary>
        /// <param name="table"></param>
        /// The data in an xml document
        /// <returns></returns>
        public List<int> validateTable(XmlDocument data)
        {
            XmlNodeList tableNodes = data.SelectNodes("//NewDataSet/Table1");
            int count = 0;
            List<int> invalidNodes = new List<int>();
            foreach (XmlNode itemNode in tableNodes)
            {
                count++;
                Boolean conc1 = checkNode(itemNode.SelectSingleNode("Conc1Default"));
                Boolean conc2 = checkNode(itemNode.SelectSingleNode("Conc2Default"));
                Boolean conc3 = checkNode(itemNode.SelectSingleNode("Conc3Default"));
                int testInt = boolToInt(conc1) + boolToInt(conc2) + boolToInt(conc3);
                if (testInt != 1)
                {
                    invalidNodes.Add(count);
                }
            }
            return invalidNodes;
        }
        private Boolean checkNode(XmlNode itemNode)
        {
            String data = itemNode.SelectSingleNode("/text()").Value;
            int dataTest;
            if(Int32.TryParse(data, out dataTest))
            {
                if (dataTest == 1)
                    return true;
            }
            return false;
        }

        private int boolToInt(Boolean t)
        {
            int i = t ? 1 : 0;
            return i;
        }
    }

}
