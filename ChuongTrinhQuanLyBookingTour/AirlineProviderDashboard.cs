using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_AirlineProvider;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class AirlineProviderDashboard : Form
    {
        private int airlineID;
        public AirlineProviderDashboard(int airlineID)
        {
            InitializeComponent();
            this.airlineID = airlineID;
        }

        private void FlightProviderDashboard_Load(object sender, EventArgs e)
        {
            btnAddFlight.PerformClick();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            uC_AddNewFlight1.BringToFront();
            uC_AddNewFlight1.Visible = true;
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            uC_EditFlight2.SetAirlineID(this.airlineID);
            uC_EditFlight2.BringToFront();
            uC_EditFlight2.Visible = true;
        }

        private void btnDisableFlight_Click(object sender, EventArgs e)
        {
            uC_DisableFlight1.SetAirlineID(this.airlineID) ;
            uC_DisableFlight1.BringToFront();
            uC_DisableFlight1.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_HotelProviderInformation1.BringToFront();
            uC_HotelProviderInformation1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
