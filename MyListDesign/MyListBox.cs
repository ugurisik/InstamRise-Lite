using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyListDesign
{
    public class MyListBox : ListBox
    {
        private bool mShowScroll;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!mShowScroll)
                    cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar
        {
            get { return mShowScroll; }
            set
            {
                if (value != mShowScroll)
                {
                    mShowScroll = value;
                    if (IsHandleCreated)
                        RecreateHandle();
                }
            }
        }
    }
}
