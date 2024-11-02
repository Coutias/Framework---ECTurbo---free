using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ECTurbo_Framework.Controles
{

    public class ECTurbo_Datas : ECTurbo_TextBox
    {

        protected override void OnValidating(CancelEventArgs e)
        {

            base.OnValidating(e);

            if (Text == string.Empty)
            {

                return;

            }

            try
            {

                Text = Convert.ToDateTime(Text).ToShortDateString();

            }

            catch (Exception)
            {

                MessageBox.Show("Data Inválida");
                e.Cancel = true;
                base.Focus();

            }

        }

    }

}
