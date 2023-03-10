using System;
using System.Drawing;
using System.Windows.Forms;

namespace PDV.Componentes
{
    public class Numero : TextBox
    {
        public int ValorInteiro { get; set; }

        protected override void OnCreateControl()
        {
            if (string.IsNullOrEmpty(this.Text))
                this.Text = "0";
            this.TextAlign = HorizontalAlignment.Center;
            this.BorderStyle = BorderStyle.FixedSingle;
            base.OnCreateControl();
        }

        protected override void OnEnter(EventArgs e)
        {
            ValorInteiro = 0;
            if (!string.IsNullOrEmpty(this.Text))
            {
                if (this.Text != "0")
                {
                    this.SelectAll();
                }
                else
                {
                    this.Clear();
                    this.Focus();
                }
            }
            this.BackColor = Color.LightBlue;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                ValorInteiro = Convert.ToInt32(this.Text);
                this.Text = ValorInteiro.ToString();
            }

            this.BackColor = Color.White;
            base.OnLeave(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "\b")
                base.OnKeyPress(e);
            else
                e.Handled = true;

            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{Tab}");
            }
            base.OnKeyDown(e);
        }


    }
}
