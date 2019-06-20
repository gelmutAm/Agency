using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency.WinFormsPL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Agent_Click(object sender, EventArgs e)
        {
            Form agentForm = new AgentForm();
            agentForm.Show();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Form clientForm = new ClientForm();
            clientForm.Show();
        }

        private void btn_City_Click(object sender, EventArgs e)
        {
            Form cityForm = new CityForm();
            cityForm.Show();
        }

        private void btn_Area_Click(object sender, EventArgs e)
        {
            Form areaForm = new AreaForm();
            areaForm.Show();
        }

        private void btn_Street_Click(object sender, EventArgs e)
        {
            Form streetForm = new StreetForm();
            streetForm.Show();
        }

        private void btn_House_Click(object sender, EventArgs e)
        {
            Form houseForm = new HouseForm();
            houseForm.Show();
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            Form saleForm = new SaleForm();
            saleForm.Show();
        }

        private void btn_RentSale_Click(object sender, EventArgs e)
        {
            Form rentSaleForm = new RentSaleForm();
            rentSaleForm.Show();
        }
    }
}
