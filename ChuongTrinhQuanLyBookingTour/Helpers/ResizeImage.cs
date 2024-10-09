using System.Drawing;

namespace ChuongTrinhQuanLyBookingTour.Helpers
{
    public static class ImageHelper
    {
        // Method to resize an image to a specified width and height
        public static Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
    }
}
