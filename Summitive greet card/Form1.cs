using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summitive_greet_card
{
    public partial class greetingCardForm : Form
    {
        public greetingCardForm()
        {
            InitializeComponent();
        }

        private void greetingCardForm_Click(object sender, EventArgs e)
        {
            greetTitleLabel.Visible = false;
            nameLabel.Visible = false;

            Graphics gemini = this.CreateGraphics();
            SolidBrush starDots = new SolidBrush(Color.White);

            gemini.Clear(Color.Black);
            gemini.FillEllipse(starDots, 67, 63, 4, 4);
            gemini.FillEllipse(starDots, 99, 66, 3, 3);
            gemini.FillEllipse(starDots, 80, 42, 16, 16);
            gemini.FillEllipse(starDots, 118, 33, 8, 8);
            gemini.FillEllipse(starDots, 133, 46, 3, 3);
            gemini.FillEllipse(starDots, 156, 81, 2, 2);
            gemini.FillEllipse(starDots, 209, 92, 4, 4);
            gemini.FillEllipse(starDots, 101, 118, 4, 4);
            gemini.FillEllipse(starDots, 186, 158, 6, 6);
            gemini.FillEllipse(starDots, 123, 153, 3, 3);
            gemini.FillEllipse(starDots, 214, 209, 5, 5);
            gemini.FillEllipse(starDots, 192, 215, 3, 3);
            gemini.FillEllipse(starDots, 229, 223, 2, 2);
            gemini.FillEllipse(starDots, 122, 228, 3, 3);
            gemini.FillEllipse(starDots, 155, 220, 8, 8);

        }
    }
}
