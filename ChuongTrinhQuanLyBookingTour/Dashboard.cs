using System;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyBookingTour
{
    public partial class Dashboard : Form
    {
        internal static Dashboard ds;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddHotelRoom2.Visible = false;
            uC_AddFlight1.Visible = false;
            btnAddHotel.PerformClick();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddHotel.Left;
            uC_AddHotelRoom2.Visible = true;
            uC_AddHotelRoom2.BringToFront();
        }

        private void btnAddFilght_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddFilght.Left;
            uC_AddFlight1.Visible = true;
            uC_AddFlight1.BringToFront();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddTour.Left;
            uC_AddTour1.Visible = true;
            uC_AddTour1.BringToFront();
        }

        private void btnHistoryTransaction_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnHistoryTransaction.Left;
            uC_HistoryTransaction1.Visible = true;
            uC_HistoryTransaction1.BringToFront();
            uC_HistoryTransaction1.LoadBookingHistory();
        }

        private void btnSelfInformation_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnSelfInformation.Left;
            uC_SelfInformation1.Visible = true;
            uC_SelfInformation1.BringToFront();
        }

        private void uC_SelfInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}
