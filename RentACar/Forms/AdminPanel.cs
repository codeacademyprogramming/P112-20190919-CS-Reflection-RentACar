using RentACar.DAL;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class AdminPanel : Form
    {
        private readonly RentContext _dbRent;

        public AdminPanel()
        {
            InitializeComponent();
            _dbRent = new RentContext();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            List<Order> orders = _dbRent.Orders.Include("Car.Model.Manufacturer").Include("User").ToList();

            foreach (Order item in orders)
            {
                dgvOrders.Rows.Add(item.Car.Model.Name);
            }
        }
    }
}
