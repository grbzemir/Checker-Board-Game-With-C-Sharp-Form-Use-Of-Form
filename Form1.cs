using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi

{
    public partial class Form1 : Form

    {
        public Form1()

        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;


            Button[,] buttons = new Button[8, 8];

            int top;
            int left;

            left = 0;
            top = 0;

            int i;

            for (i = 0; i < buttons.GetUpperBound(0); i++) // 0. Boyutun Son Elemanı

            {

                int j;

                for (j = 0; j <= buttons.GetUpperBound(1); j++)  // 1.Boyutun Son Elemanı



                {

                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;

                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;

                    left = left + 50;

                    if ((i + j) % 2 == 0)

                    {


                        buttons[i, j].BackColor = Color.Black;
                    }


                    else

                    {


                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]);


                }

                top = top + 50;
                left = 0;


            }


        }


    }



}

