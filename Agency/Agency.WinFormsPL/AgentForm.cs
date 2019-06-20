using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency.BLL.Interface;
using Agency.BLL;
using Agency.Entities;
using Agency.Common;

namespace Agency.WinFormsPL
{
    public partial class AgentForm : Form
    {
        IAgentLogic agentLogic = DependencyResolver.AgentLogic;

        public AgentForm()
        {
            InitializeComponent();

            AgentdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AgentdataGridView.AllowUserToAddRows = true;

            AgentdataGridView.DataSource = agentLogic.GetAll().ToArray();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Agent temp = new Agent(textBoxFio.Text, textBoxPhoneNumber.Text);

            agentLogic.Add(temp);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            agentLogic.DeleteById(int.Parse(textBoxId.Text));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            var temp = agentLogic.GetAll().ToArray();
            AgentdataGridView.DataSource = agentLogic.GetAll().ToArray();
        }
    }
}
