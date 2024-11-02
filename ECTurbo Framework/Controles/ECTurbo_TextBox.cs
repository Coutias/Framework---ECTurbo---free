using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECTurbo_Framework.Controles
{

    public class ECTurbo_TextBox : TextBox
    {

        protected override void OnCreateControl()
        {

            base.OnCreateControl();
            ForeColor = Color.FromArgb(64, 64, 64);
            Font = new Font("Century Gothic", 12F);

        }

        protected override void OnEnter(EventArgs e)
        {

            base.OnEnter(e);
            BackColor = Color.AliceBlue;

        }

        protected override void OnLeave(EventArgs e)
        {

            base.OnLeave(e);
            BackColor = Color.White;

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

            }

        }

    }

}
