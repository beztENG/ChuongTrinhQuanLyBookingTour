using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_CompanyTourProvider;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class CompanyTourProviderDashboard : Form
    {
        private int companyid;
        public CompanyTourProviderDashboard(int companyid)
        {
            InitializeComponent();
            this.companyid = companyid;
        }
        private void TourProviderDashboard_Load(object sender, EventArgs e)
        {
            btnAddNewTour.PerformClick();
        }

        private void btnAddNewTour_Click(object sender, EventArgs e)
        {
            uC_AddNewTour2.BringToFront();
            uC_AddNewTour2.Visible = true;
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            uC_EditTour1.SetCompanyID(companyid);
            uC_EditTour1.BringToFront();
            uC_EditTour1.Visible = true;
        }

        private void btnDisableTour_Click(object sender, EventArgs e)
        {
            uC_DisableTour1.SetCompanyID(companyid);
            uC_DisableTour1.BringToFront();
            uC_DisableTour1.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_HotelProviderInformation1.BringToFront();
            uC_HotelProviderInformation1.Visible = true;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
