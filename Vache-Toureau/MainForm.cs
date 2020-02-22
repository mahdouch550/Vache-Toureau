using Newtonsoft.Json;
using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using VT_PCLs;

namespace Vache_Toureau
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            String firstMacAddress = NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback).Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault();
            var Session = new Session
            {
                ID = Guid.NewGuid(),
                Active = true,
                Full = false,
                Players = Tuple.Create(firstMacAddress, "")
            };
            var httpClient = new HttpClient();
            var data = httpClient.PostAsync("http://192.168.1.8:44328/api/values", new ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Session)))).Result.Content.ReadAsStringAsync().Result;
            CreatedSessionID.Text = data;
        }
    }
}