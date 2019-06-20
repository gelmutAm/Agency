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
    public partial class RentSaleForm : Form
    {
        IRentSaleLogic rentSaleLogic = DependencyResolver.RentSaleLogic;

        public RentSaleForm()
        {
            InitializeComponent();

            RentSaledataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RentSaledataGridView.AllowUserToAddRows = false;

            RentSaledataGridView.DataSource = rentSaleLogic.GetAll().ToArray();
        }
    }
}
