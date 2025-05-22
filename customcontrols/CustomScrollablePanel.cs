namespace VeterinaryClinicApp
{
    public class CustomScrollablePanel : ScrollableControl
    {
        public CustomScrollablePanel()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            this.AutoScroll = true;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCPAINT = 0x85;
            const int WM_HSCROLL = 0x114; 
            const int WM_VSCROLL = 0x115; 
            if (m.Msg == WM_NCPAINT || m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
    }
