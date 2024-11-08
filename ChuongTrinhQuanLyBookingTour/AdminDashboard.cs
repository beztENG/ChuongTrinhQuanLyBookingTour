using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            btnUserList.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUsers1.BringToFront();
            uC_AddUsers1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            uC_ListUsers1.BringToFront();
            uC_ListUsers1.Visible = true;
        }

        private void btnManageHotelBrand_Click(object sender, EventArgs e)
        {
            uC_ManageHotelBrand1.BringToFront();
            uC_ManageHotelBrand1.Visible = true;
        }
    }
}
