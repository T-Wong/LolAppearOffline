﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetFwTypeLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Holds region and matching IP address
        Dictionary<string, string> regionsIP = new Dictionary<string, string>();

        public Form1()
        {   
            // Initialize GUI
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dictionary used to map region with IP to block
            regionsIP.Add("North America", "216.133.234.21");
            regionsIP.Add("EU West", "185.40.64.69");
            regionsIP.Add("EU Nordic & East", "66.150.148.21");
            regionsIP.Add("Brazil", "66.151.33.22");
            regionsIP.Add("Latin America North", "66.151.33.248");
            regionsIP.Add("Latin America South", "66.151.33.249");
            regionsIP.Add("Turkey", "95.172.65.28");
            regionsIP.Add("Oceania", "192.64.169.22");
            regionsIP.Add("Russia", "95.172.65.245");
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            removeFirewall(regionComboBox.Text);
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            addFirewall(regionsIP[regionComboBox.Text], regionComboBox.Text);
        }

        // Used to add a rule to the outbound firewall
        private void addFirewall(String ip, String name)
        {
            // Initialize profile and policy variables
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            var currentProfiles = fwPolicy2.CurrentProfileTypes;

            // Creates a new outbound rule for blocking an IP
            INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            inboundRule.Enabled = true;
            inboundRule.Name = String.Format("LoL ({0})", name);
            inboundRule.Description = String.Format("Blocks League of Legends chat service for {0}.", name);
            inboundRule.RemoteAddresses = ip;
            inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;

            inboundRule.Profiles = currentProfiles;

            // Add the rule
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Remove(String.Format("LoL ({0})", name));  // remove before adding just in case of duplicates
            firewallPolicy.Rules.Add(inboundRule);
        }

        // Used to remove a rule from the outbound firewall
        private void removeFirewall(String name)
        {
            // Finds and removes rule
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Remove(String.Format("LoL ({0})", name));
        }
    }
}
