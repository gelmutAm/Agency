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
    public partial class ClientForm : Form
    {
        IClientLogic clientLogic = DependencyResolver.ClientLogic;

        public ClientForm()
        {
            InitializeComponent();

            ClientdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientdataGridView.AllowUserToAddRows = false;

            ClientdataGridView.DataSource = clientLogic.GetAll().ToArray();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Client temp = new Client(textBoxFio.Text, textBoxPhoneNumber.Text);

            clientLogic.Add(temp);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            clientLogic.DeleteById(int.Parse(textBoxId.Text));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClientdataGridView.DataSource = clientLogic.GetAll().ToArray();
        }
    }
}
