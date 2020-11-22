using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using UspsValidation.Properties;

namespace UspsValidation
{
    public partial class frm_addressValidation : Form
    {
        public frm_addressValidation()
        {
            InitializeComponent();
            ListBoxWriter _writer = new ListBoxWriter(listBox1);
            Console.SetOut(_writer);
        }

        private static void errorMsg (string body,string title)
        {
            MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtAdd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorMsg("This field accepts only numbers", "Numbers Only");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                if (!openFile.FileName.EndsWith(".csv"))
                    errorMsg("You have to choose a csv file", "No file selected");
                else
                {
                    txtFileName.Text = openFile.FileName;
                }
            }
        }

        private void frm_addressValidation_Load(object sender, EventArgs e)
        {
            txtUserId.Text = "669EMAGI1041";
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtFileName.Text) || String.IsNullOrEmpty(txtUserId.Text) ||
               String.IsNullOrEmpty(txtAdd1.Text) || String.IsNullOrEmpty(txtAdd2.Text) ||
               String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtState.Text) ||
               String.IsNullOrEmpty(txtZip.Text))
                errorMsg("You have to fill all the fields", "Empty Fields");
            else
            {
                using (var reader = new StreamReader(txtFileName.Text))
                {
                    var csv = new StringBuilder();
                    int counter = 1;
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        string[] result = values[0].Split(',');

                        var validated = validate(txtUserId.Text,
                            result[Convert.ToInt32(txtAdd1.Text)],
                            result[Convert.ToInt32(txtAdd2.Text)],
                            result[Convert.ToInt32(txtCity.Text)],
                            result[Convert.ToInt32(txtState.Text)],
                            result[Convert.ToInt32(txtZip.Text)]);

                        
                        var newLine = string.Format("{0},{1}", line, validated);
                        if (counter == 1)
                        {
                            csv.AppendLine(string.Format("{0},{1}", line, "Valid,Address1,Address2,City,State,Zip5,Zip4"));
                            counter++;
                        }
                        else
                            csv.AppendLine(newLine);
                    }

                    string newFileName = txtFileName.Text.Substring(0, txtFileName.Text.IndexOf(".csv"));
                    newFileName += "Validated.csv";
                    File.WriteAllText(newFileName, csv.ToString());
                    Console.WriteLine("validated file name : " + newFileName);
                    MessageBox.Show("you will find the validated file next to the original", "Validation Done");
                }
            }
        }

        private static string validate (string userId,string address1,string address2,string city,string state,
            string zip)
        {
            string zip5 = "", zip4 = "";
            if (zip.IndexOf('-') == -1)
                zip5 = zip;
            else
            {
                zip5 = zip.Substring(0, 5);
                zip4 = zip.Substring(6);
            }

            XDocument requestDoc = new XDocument(
                    new XElement("AddressValidateRequest", new XAttribute("USERID",userId),
                    new XElement("Revision", "1"),
                    new XElement("Address",
                        new XAttribute("ID", "0"),
                        new XElement("Address1", address2),
                        new XElement("Address2", address1),
                        new XElement("City", city),
                        new XElement("State", state),
                        new XElement("Zip5", zip5),
                        new XElement("Zip4", zip4))
                    )
                );

            try
            {
                var url = "https://secure.shippingapis.com/ShippingAPI.dll?API=Verify&XML=" + requestDoc;
                Console.WriteLine(url);
                
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var client = new WebClient();
                var response = client.DownloadString(url);

                var xdoc = XDocument.Parse(response.ToString());
                Console.WriteLine(xdoc.ToString());

                foreach (XElement element in xdoc.Descendants("Address"))
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Address ID:" + GetXmlAttribute(element, "ID"));
                    Console.WriteLine("Address1:" + GetXmlElement(element, "Address1"));
                    Console.WriteLine("Address2:" + GetXmlElement(element, "Address2"));
                    Console.WriteLine("City:" + GetXmlElement(element, "City"));
                    Console.WriteLine("State:" + GetXmlElement(element, "State"));
                    Console.WriteLine("Zip5:" + GetXmlElement(element, "Zip5"));
                    Console.WriteLine("Zip4:" + GetXmlElement(element, "Zip4"));

                    if (!GetXmlElement(element, "Address2").ToString().Equals(""))
                        return "true," + GetXmlElement(element, "Address1") + "," +
                        GetXmlElement(element, "Address2") + "," + GetXmlElement(element, "City") + "," +
                        GetXmlElement(element, "State") + "," + GetXmlElement(element, "Zip5") + "," +
                        GetXmlElement(element, "Zip4");
                    else
                        return "false,,,,,,,";
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return "false,,,,,,,";
            }
            return "false,,,,,,,";
        }

        private static string GetXmlElement(XElement element, string name)
        {
            var el = element.Element(name);
            if (el != null)
            {
                return el.Value;
            }
            return "";
        }

        private static string GetXmlAttribute(XElement element, string name)
        {
            var el = element.Attribute(name);
            if (el != null)
            {
                return el.Value;
            }
            return "";
        }
    }

    public class ListBoxWriter : TextWriter //this class redirects console.writeline to debug listbox
    {
        private readonly ListBox _list;
        private StringBuilder _content = new StringBuilder();

        public ListBoxWriter(ListBox list)
        {
            _list = list;
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
        public override void Write(char value)
        {
            base.Write(value);
            _content.Append(value);

            if (value != '\n') return;
            if (_list.InvokeRequired)
            {
                try
                {
                    _list.Invoke(new MethodInvoker(() => _list.Items.Add(_content.ToString())));
                    _list.Invoke(new MethodInvoker(() => _list.SelectedIndex = _list.Items.Count - 1));
                    _list.Invoke(new MethodInvoker(() => _list.SelectedIndex = -1));
                }
                catch (ObjectDisposedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                _list.Items.Add(_content.ToString());
                _list.SelectedIndex = _list.Items.Count - 1;
                _list.SelectedIndex = -1;
            }
            _content = new StringBuilder();
        }
    }
}
