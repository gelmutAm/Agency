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
    public partial class SaleForm : Form
    {
        ISaleLogic saleLogic = DependencyResolver.SaleLogic;

        public SaleForm()
        {
            InitializeComponent();

            SaledataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SaledataGridView.AllowUserToAddRows = false;

            SaledataGridView.DataSource = saleLogic.GetAll().ToArray();
        }
    }
}
