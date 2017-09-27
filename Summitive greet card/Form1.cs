//Creator: Carter Neeb
//Date: Wed, Sept 27, 2017
//This program simulates a greeting card

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

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
            //sets the orignal text to invisible
            greetTitleLabel.Visible = false;
            nameLabel.Visible = false;
            skipButton.Visible = false;

            //sets up the graphics and sounds

            Graphics gemini = this.CreateGraphics();
            SolidBrush starDots = new SolidBrush(Color.White);
            Pen starLines = new Pen(Color.White, 1);
            SoundPlayer ding2 = new SoundPlayer(Properties.Resources.mode);
            SoundPlayer ding1 = new SoundPlayer(Properties.Resources.money);

            //turns the screen black, and draws the star dots

            gemini.Clear(Color.Black);
            gemini.FillEllipse(starDots, 67, 63, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 99, 64, 8, 8);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 80, 42, 16, 16);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 118, 33, 8, 8);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 133, 46, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 156, 81, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 209, 92, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 101, 118, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 186, 158, 6, 6);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 123, 153, 6, 6);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 214, 209, 5, 5);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 192, 215, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 229, 223, 4, 4);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 122, 228, 6, 6);
            ding1.PlaySync();
            gemini.FillEllipse(starDots, 155, 220, 8, 8);
            ding1.PlaySync();

            //draws the lines between the stars to form the constellation

            gemini.DrawLine(starLines, 67, 65, 99, 67);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 88, 48, 102, 67);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 102, 67, 102, 122);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 102, 67, 158, 84);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 158, 82, 134, 47);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 134, 47, 122, 37);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 158, 84, 211, 94);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 158, 84, 188, 160);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 103, 121, 124, 153);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 125, 154, 125, 230);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 125, 154, 159, 226);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 190, 160, 193, 216);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 188, 160, 214, 209);
            ding2.PlaySync();
            gemini.DrawLine(starLines, 214, 209, 229, 223);
            ding2.PlaySync();

            //draws the paragraph about the gemini

            Font paragraph = new Font("Arial", 8);
            starDots.Color = Color.Yellow;
            gemini.DrawString("Gemini is the third sign of the zodiac, and those born under this sign will be quick", paragraph, starDots, 25, 300);
            starDots.Color = Color.Blue;
            gemini.DrawString("to tell you all about it. That's because they love to talk! It's not just idle chatter with", paragraph, starDots, 25, 312);
            starDots.Color = Color.Green;
            gemini.DrawString("these folks, either. The driving force behind a Gemini's conversation is their mind.", paragraph, starDots, 25, 324);
        }

        private void greetingCardForm_Leave(object sender, EventArgs e)
        {
            //setup code
            Graphics gemini = this.CreateGraphics();
            skipButton.Visible = false;
            SolidBrush starDots = new SolidBrush(Color.White);
            SolidBrush errorBrush = new SolidBrush(Color.Black);
            Font warning = new Font("Arial", 10);
            Font errorFont = new Font("Arial", 50);
            int x = -4;
            int y = -4;
            int loopNumber = 0;
            Random random = new Random();

            //this happens if you leave the screen w/ mouse (or touch the skip button)

            gemini.DrawString("HEY! What are you doing!?!?!", warning, starDots, 20, 200);
            Thread.Sleep(1000);
            gemini.DrawString("COMPUTER ERROR LOG: ERROR!", warning, starDots, 20, 220);
            Thread.Sleep(1000);
            gemini.DrawString("COMPUTER ERROR LOG: FATAL ERROR!", warning, starDots, 20, 240);
            Thread.Sleep(1000);
            gemini.DrawString("COMPUTER ERROR LOG: CANNOT COMPUTE!", warning, starDots, 20, 260);
            Thread.Sleep(1000);

            while (loopNumber < 50000)
            {
                loopNumber = loopNumber + 1;
                gemini.DrawString("ERROR", warning, starDots, x, y);
                x = random.Next(0, 1500);
                y = random.Next(0, 1500);
            }

            loopNumber = 0;

            while (loopNumber < 1000)
            {
                loopNumber = loopNumber + 1;
                gemini.DrawString("ERROR!", errorFont, errorBrush, x, y);
                x = random.Next(0, 1500);
                y = random.Next(0, 1500);
                Thread.Sleep(1);
            }
            Thread.Sleep(5000);
            this.Close();
        }
    }
}
