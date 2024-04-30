using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Игра_в_15__пятнашки_
{
    internal class RoundedButton : Button
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundButton(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            IntPtr ptr = RoundButton(0, 0, Width, Height, 20, 20);
            Region = Region.FromHrgn(ptr);
        }
    }
}
