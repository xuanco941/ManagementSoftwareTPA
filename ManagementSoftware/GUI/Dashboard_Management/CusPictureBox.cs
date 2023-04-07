using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware
{
    public class CusPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            int halfWidth = this.Width / 2;
            int halfHeight = this.Height / 2;
            path.AddPolygon(new Point[] {
            new Point(0, halfHeight +halfHeight/3),
            new Point(0, 0),
            new Point(Width, 0),
            new Point(this.Width, halfHeight + halfHeight/3),
            new Point(halfWidth + halfWidth / 2, this.Height),
            new Point(halfWidth / 2, this.Height)


        });

            // Chỉ định khu vực cần vẽ
            this.Region = new Region(path);
        }
    }
}
