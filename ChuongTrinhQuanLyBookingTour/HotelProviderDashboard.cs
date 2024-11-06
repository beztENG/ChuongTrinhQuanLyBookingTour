using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ChuongTrinhQuanLyBookingTour.All_Users_Control.UC_HotelProvider;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class HotelProviderDashboard : Form
    {
        private int hotelId;

        public HotelProviderDashboard(int hotelId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
        }
        private void HotelProviderDashboard_Load(object sender, EventArgs e)
        {
            btnAddRoom.PerformClick();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.BringToFront();
            uC_AddRoom1.Visible = true;
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            uC_EditRoom1.LoadRoomData();
            uC_EditRoom1.BringToFront();
            uC_EditRoom1.Visible = true;
        }

        private void btnDisableRoom_Click(object sender, EventArgs e)
        {
            uC_DisableRoom1.BringToFront();
            uC_DisableRoom1.Visible = true;
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
