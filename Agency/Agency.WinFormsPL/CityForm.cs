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
    public partial class CityForm : Form
    {
        ICityLogic cityLogic = DependencyResolver.CityLogic;

        public CityForm()
        {
            InitializeComponent();

            CitydataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CitydataGridView.AllowUserToAddRows = false;

            CitydataGridView.DataSource = cityLogic.GetAll().ToArray();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CitydataGridView.DataSource = cityLogic.GetAll().ToArray();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            City temp = new City(textBoxName.Text);

            cityLogic.Add(temp);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cityLogic.DeleteById(int.Parse(textBoxId.Text));
        }
    }
}
