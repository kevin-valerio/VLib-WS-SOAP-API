using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VLib_Client.VLibSoapService;

namespace VLib_Client {
    public partial class Form1 : Form {
        VLibSoapServiceClient SOAPClient = new VLibSoapServiceClient();
        RESTClient rESTClient = new RESTClient();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            if (isSOAP.Checked) {
                SOAPClient.fullFeed();
            } else {
                rESTClient.fullFeed();
            }
        }

        private void xylosButton1_Click(object sender, EventArgs e) {
            Station[] allStations;
            if (isSOAP.Checked) {
                allStations = SOAPClient.getAllStationsIn(xylosTextBox2.Text);
            } else {
                allStations = rESTClient.getAllStationsIn(xylosTextBox2.Text);
            }

            foreach (Station item in allStations) {
                xylosCombobox1.Items.Add(item.StationName);
                showItinaryComponents();
            }

            if (allStations.Length.Equals(0)) { 
                MessageBox.Show("No stations found in " + xylosTextBox2.Text, "No stations found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  

        }

        private void showItinaryComponents() {
            groupBox1.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            label7.Visible = true;
            xylosButton2.Visible = true;
            xylosCombobox1.Visible = true;
        }

        private void xylosCombobox1_SelectedIndexChanged(object sender, EventArgs e) {
            lblStationName.Text = xylosCombobox1.SelectedItem.ToString();

            if (isSOAP.Checked) {
                lblAddress.Text = SOAPClient.getStationByName(xylosCombobox1.SelectedItem.ToString()).Address;
            } else {
                lblAddress.Text = rESTClient.getStationByName(xylosCombobox1.SelectedItem.ToString()).Address;
            }
            label1.Visible = true;
        }

        private void xylosButton2_Click(object sender, EventArgs e) {
            if (isSOAP.Checked) {
                SOAPClient.fullFeed();
            } else {
                rESTClient.fullFeed();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Mail adress has been copied to clipboard ! ", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetData(DataFormats.Text, linkLabel1.Text);
        }

        private void xylosButton3_Click(object sender, EventArgs e) {

            listView1.Visible = false;
            pictureBox1.Visible = true;

            try {
                pictureBox1.Image = SOAPClient.getStaticMapImage(radioPedestrian.Checked ? true : false,
                xylosTextBox2.Text, xylosTextBox1.Text, true);
            } catch (Exception vertexError) {
                if(vertexError.Message.Contains("Failed. URL")) {
                    MessageBox.Show("The addresses you provided are too far away from each other. Google Static Maps provides a limited" +
                   " number of vertex to draw lines. We'll still provide you the informations about the route, and the details",
                   "No vertexes provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 
                }               
            }            
        } 

        private void xylosButton5_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            listView1.Visible = true;
            pictureBox1.Visible = false;
            Step[] instructions;
            if (isSOAP.Checked) {
                instructions = SOAPClient.getInstructions(radioPedestrian.Checked ? true : false, xylosTextBox2.Text, xylosTextBox1.Text);
            } else {
                instructions = rESTClient.getInstructions(radioPedestrian.Checked ? true : false, xylosTextBox2.Text, xylosTextBox1.Text);
            }

            foreach (Step instruction in instructions) {
                listView1.Items.Add(new ListViewItem(
                    new[] {
                        Regex.Replace(instruction.html_instructions, "<.*?>", String.Empty),
                        instruction.distance.text,
                        instruction.duration.text 
                    } )); 
            }
        }

        private void isSOAP_CheckedChanged(object sender, EventArgs e) {
            if(isSOAP.Checked)
                 label8.Text = "Current used protocol : REST";
            else
                label8.Text = "Current used protocol : SOAP";
        }
    }
     
}
