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
    public partial class AreaForm : Form
    {
        IAreaLogic areaLogic = DependencyResolver.AreaLogic;

        public AreaForm()
        {
            InitializeComponent();

            AreadataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AreadataGridView.AllowUserToAddRows = false;

            AreadataGridView.DataSource = areaLogic.GetAll().ToArray();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            AreadataGridView.DataSource = areaLogic.GetAll().ToArray();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Area temp = new Area(textBoxName.Text);

            areaLogic.Add(temp);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            areaLogic.DeleteById(int.Parse(textBoxId.Text));
        }
    }
}
