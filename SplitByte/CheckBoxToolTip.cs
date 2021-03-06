using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SplitByte
{
    public class CheckBoxToolTip : System.Windows.Forms.CheckBox
    {
        ToolTip tooltip = new ToolTip();

        public CheckBoxToolTip()
            : base()
        {

        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);

            if (!ChildReallyVisible(this))
            {
                tooltip.Show(this.Text, this, 3000);
            }
        }


        public bool ChildReallyVisible(Control child)
        {
            var pos = this.Parent.PointToClient(child.PointToScreen(Point.Empty));

            if ((this.Parent.GetChildAtPoint(pos) == child) && (this.Parent.GetChildAtPoint(new Point(pos.X + child.Width - 1, pos.Y)) == child)
            && (this.Parent.GetChildAtPoint(new Point(pos.X, pos.Y + child.Height - 1)) == child)
            && (this.Parent.GetChildAtPoint(new Point(pos.X + child.Width - 1, pos.Y + child.Height - 1)) == child))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
