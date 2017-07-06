using CSOpenXmlExcelToXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initializes a OpenFileDialog instance  
            using (OpenFileDialog openfileDialog = new OpenFileDialog())
            {
                openfileDialog.RestoreDirectory = true;
                openfileDialog.Filter = "Excel files(*.xlsx;*.xls)|*.xlsx;*.xls";

                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Displays the file path on the pathtxb textboxs
                    pathtxb.Text = openfileDialog.FileName;
                }
            } 
        }

        private void saveAsxml()
        {
            // Initializes a SaveFileDialog instance  
            using (SaveFileDialog savefiledialog = new SaveFileDialog())
            {
                savefiledialog.RestoreDirectory = true;
                savefiledialog.DefaultExt = "xml";
                savefiledialog.Filter = "All Files(*.xml)|*.xml";
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    Stream filestream = savefiledialog.OpenFile();
                    StreamWriter streamwriter = new StreamWriter(filestream);
                    streamwriter.Write("<?xml version='1.0'?>" +
                        Environment.NewLine + tbXmlView.Text);
                    streamwriter.Close();
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbXmlView.Clear();
            string excelfileName = pathtxb.Text;

            if (string.IsNullOrEmpty(excelfileName) || !File.Exists(excelfileName))
            {
                MessageBox.Show("The Excel file is invalid! Please select a valid file.");
                return;
            }

            try
            {
                string xmlFormatstring = new ConvertExcelToXml().GetXML(excelfileName);
                if (string.IsNullOrEmpty(xmlFormatstring))
                {
                    MessageBox.Show("The content of Excel file is Empty!");
                    return;
                }

                tbXmlView.Text = xmlFormatstring;
                var confirmResult = MessageBox.Show("Would you like to save?",
                                     "Save file?",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    saveAsxml();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs! The error message is: " + ex.Message);
            }
        }
    }
}
