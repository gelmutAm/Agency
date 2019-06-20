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
    public partial class HouseForm : Form
    {
        IHouseLogic houseLogic = DependencyResolver.HouseLogic;

        public HouseForm()
        {
            InitializeComponent();

            HousedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HousedataGridView.AllowUserToAddRows = false;

            HousedataGridView.DataSource = houseLogic.GetAll().ToArray();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            HousedataGridView.DataSource = houseLogic.GetAll().ToArray();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            House temp = new House(textBoxName.Text);

            houseLogic.Add(temp);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            houseLogic.DeleteById(int.Parse(textBoxId.Text));
        }
    }
}
