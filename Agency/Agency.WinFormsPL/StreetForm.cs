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
    public partial class StreetForm : Form
    {
        IStreetLogic streetLogic = DependencyResolver.StreetLogic;

        public StreetForm()
        {
            InitializeComponent();

            StreetdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StreetdataGridView.AllowUserToAddRows = false;

            StreetdataGridView.DataSource = streetLogic.GetAll().ToArray();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            StreetdataGridView.DataSource = streetLogic.GetAll().ToArray();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Street temp = new Street(textBoxName.Text);

            streetLogic.Add(temp);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            streetLogic.DeleteById(int.Parse(textBoxId.Text));
        }
    }
}
