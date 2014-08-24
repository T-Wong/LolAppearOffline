using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //private void addFirewall(String ip)
        //{
        //    Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
        //    INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
        //    var currentProfiles = fwPolicy2.CurrentProfileTypes;

        //    // Creates a new rule
        //    INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
        //    inboundRule.Enabled = true;
        //    inboundRule.LocalPorts = "1234";
        //    inboundRule.Protocol = 6; // TCP
        //    // ...
        //    inboundRule.Profiles = currentProfiles;

        //    // Add the rule
        //    INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
        //    firewallPolicy.Rules.Add(inboundRule);
        //}
        public Form1()
        {
            // Dictionary used to map region with IP
            Dictionary<string, string> regionsIP = new Dictionary<string, string>();
            regionsIP.Add("North America", "216.133.234.21");
            regionsIP.Add("EU West", "185.40.64.69");
            regionsIP.Add("EU Nordic & East", "0");
            regionsIP.Add("Brazil", "0");
            regionsIP.Add("Latin America North", "0");
            regionsIP.Add("Latin America South", "0");
            regionsIP.Add("Turkey", "0");
            regionsIP.Add("Oceania", "0");
            regionsIP.Add("Russia", "0");
            regionsIP.Add("Republic of Korea", "0");
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(regionComboBox.Text);
        }
    }
}
