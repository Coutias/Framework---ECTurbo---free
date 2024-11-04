﻿using ECTurbo_Framework.Controles;
using System.Drawing;
using System.Windows.Forms;

namespace ECTurbo_Framework.Codigos
{

    public class Funcoes
    {

        public static void CriarLabel(Control ctr, string texto, string tipo = "erro", Color cor = "Default")
        {

            Label lbl = new Label()
            {

                Text = texto,
                BackColor = Color.Transparent,
                Font = new Font("Century Gothic", 9F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(ctr.Location.X, ctr.Location.Y + ctr.Height)

            };

            if (cor == default)
            {

                if (tipo == "erro")
                {

                    lbl.ForeColor = Color.Crimson;

                }

                else if (tipo == "info")
                {

                    lbl.ForeColor = Color.CornflowerBlue;

                }

                else if (tipo == "alerta")
                {

                    lbl.ForeColor = Color.DarkOrange;

                }

            }

            else
            {

                lbl.ForeColor = Color.Crimson;

            }

            ctr.Parent.Controls.Add(lbl);

        }

    }

}
