using ECTurbo_Framework.Controles;
using System.Drawing;
using System.Windows.Forms;

namespace ECTurbo_Framework.Codigos
{

    public class Funcoes
    {

        public static void CriarLabel(Control ctr, string texto)
        {

            Label lbl = new Label()
            {

                Text = texto,
                ForeColor = Color.Crimson,
                BackColor = Color.Transparent,
                Font = new Font("Century Gothic", 9F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(ctr.Location.X, ctr.Location.Y + ctr.Height)

            };

            ctr.Parent.Controls.Add(lbl);

        }

    }

}
