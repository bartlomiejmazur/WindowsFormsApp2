using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Snake_W60140 : Form
    {
        private bool czy_gra_aktywna;
        private Waz snake;
        private Owoc owoc;
       

        
        public Snake_W60140()
        {
            InitializeComponent();
            czy_gra_aktywna = false;
            timer1.Enabled = true;
            new Wynik();




        }

        private void Snake_W60140_Load(object sender, EventArgs e)
        {

        }




        private void Snake_W60140_AutoValidateChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            if (czy_gra_aktywna)
            {

                
                label2.Text = Wynik.Score.ToString();
                pole_gry.CreateGraphics().Clear(Color.Black);
                snake.move();
                snake.rysuj(pole_gry.CreateGraphics(), new SolidBrush(Color.White));
                owoc.rysuj_owoc(pole_gry.CreateGraphics(), new SolidBrush(Color.Green));
                
                if (owoc.czy_nowy_owoc(snake.x[0], snake.y[0]))
                {
                    Wynik.Score += Wynik.Points;
                    
                    snake.dodaj();

                 
                        label2.Text = Wynik.Score.ToString();
                    }

                else if (snake.czy_waz_zyje() == false)
                {
                    
                    FontFamily fontfamily1 = new FontFamily("Arial");
                    Font z = new Font(fontfamily1, 40);
                    Brush x = new SolidBrush(Color.Red);
                    Brush h = new SolidBrush(Color.Green);
                    czy_gra_aktywna = false;
                    pole_gry.CreateGraphics().Clear(Color.Black);
                    pole_gry.CreateGraphics().DrawString("Game Over", z, x, 90, 230);
                    pole_gry.CreateGraphics().DrawString("Score: "+ Wynik.Score.ToString(), z, h, 100, 330);
                    new Wynik();
                }
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 40);
                Font g = new Font(fontFamily1, 16);
                Brush b = new SolidBrush(Color.White);
                pole_gry.CreateGraphics().DrawString("Snake W60140", f, b, 50, 100);
                 }

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_gra_aktywna = true;
            if (czy_gra_aktywna)
            {
                pole_gry.CreateGraphics().Clear(Color.Black);
                snake = new Waz(pole_gry.Width, pole_gry.Height);
                owoc = new Owoc(snake.segment);
                }
           
        }

        private void Snake_W60140_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) snake.ruch = "gora";
            if (e.KeyCode == Keys.Down) snake.ruch = "dol";
            if (e.KeyCode == Keys.Right) snake.ruch = "prawo";
            if (e.KeyCode == Keys.Left) snake.ruch = "lewo";
        }

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                czy_gra_aktywna = false;
                pauzaToolStripMenuItem.Text = "Wznów";
                pole_gry.CreateGraphics().Clear(Color.Black);
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 40);
                Font g = new Font(fontFamily1, 40);
                Brush b = new SolidBrush(Color.Yellow);
                Brush c = new SolidBrush(Color.White);
                pole_gry.CreateGraphics().DrawString("Snake W60140", f, c, 50, 100);
                pole_gry.CreateGraphics().DrawString("Pauza", g, b, 150, 230);

            }
            else
            {
                czy_gra_aktywna = true;
                pauzaToolStripMenuItem.Text = "Pauza";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Snake_W60140_Load_1(object sender, EventArgs e)
        {

        }
    }
}
