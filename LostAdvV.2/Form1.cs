using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LostAdvV._2
{
    public partial class Form1 : Form
    {

        Random randNum = new Random();

        int page = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void opt2Button_Click(object sender, EventArgs e)
        {



            if (page == 1)
            {
                page = 3;
                this.BackgroundImage = Properties.Resources.Stairs;
            }
            else if (page == 2)
            {
                page = 1;
                this.BackgroundImage = Properties.Resources.abandoned_house;

            }
            else if (page == 3)
            {
                page = 5;
                this.BackgroundImage = Properties.Resources.Stairs;

            }
            else if (page == 4)
            {
                page = 1;
                this.BackgroundImage = Properties.Resources.abandoned_house;

            }
            else if (page == 5)
            {
                page = 7;
                this.BackgroundImage = Properties.Resources.Map;

            }
            else if (page == 6)
            {
                page = 1;
                this.BackgroundImage = Properties.Resources.abandoned_house;


            }
            else if (page == 7)
            {

                randNum.Next(1, 7);
                int random = randNum.Next();
                if (random == 1)

                {
                    page = 11;
                    this.BackgroundImage = Properties.Resources.abandoned_house;

                }
                else
                {
                    page = 9;
                    this.BackgroundImage = Properties.Resources.Tresure;

                }
            }
            else if (page == 8)
            {
                page = 1;
                this.BackgroundImage = Properties.Resources.abandoned_house;

            }
            else if (page == 9)
            {
                page = 1;
                this.BackgroundImage = Properties.Resources.abandoned_house;

            }
            else if (page == 11)
            {
                page = 1;
                this.BackgroundImage = Properties.Resources.abandoned_house;

            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you are at an abandoned house";
                    option1Label.Text = "leave ";
                    option2Label.Text = "go in";
                    break;
                case 2:
                    outputLabel.Text = " You  turn around and leave. sadly mike tyson is waiting for you and knocks you out. you lose. play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 3:
                    outputLabel.Text = "you go into the house and find a weird flight of stairs. Climb them?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 4:
                    outputLabel.Text = "you decide to not go down the stairs. u turn around and Danial Larusso crane kicks you in the face. you lose. play again? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 5:
                    outputLabel.Text = "You go down the stairs and find a weird looking book. open it?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 6:
                    outputLabel.Text = "You Decide too put the book down and carry on. Conner McGregor is there waiting for you and fly kicks you in the head . You lose. Play again? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 7:
                    outputLabel.Text = "You opened the book. you found a treasure map. follow it? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 8:
                    outputLabel.Text = "You Decide too put the map down and carry on. but, as you put the map down Bruce lee hit u with the one inch punch. You lose. Play again? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 9:
                    outputLabel.Text = "you followed the map and it led you too the most money you would ever need. You win! play again?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 11:
                    outputLabel.Text = "You followed the map and it led you back out of the house. you havent gained anything but atleast you're alive. wanna go back inside?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Thread.Sleep(2000);
                    Refresh();
                    Application.Exit();

                    break;
                default:
                    break;
            }
        }

        private void opt1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
                this.BackgroundImage = Properties.Resources.Mike_Tyson;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 4;
                this.BackgroundImage = Properties.Resources.Danial;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 6;
                this.BackgroundImage = Properties.Resources.connor;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {

                randNum.Next(1, 7);
                int random = randNum.Next();
                if (random == 1)

                {
                    this.BackgroundImage = Properties.Resources.abandoned_house;
                    page = 11;
                }
                else
                {
                    page = 9;
                    this.BackgroundImage = Properties.Resources.Tresure;
                }
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you are at an abandoned house";
                    option1Label.Text = "leave ";
                    option2Label.Text = "go in";
                    break;
                case 2:
                    outputLabel.Text = " You  turn around and leave. sadly mike tyson is waiting for you and knocks you out. you lose. play again?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 3:
                    outputLabel.Text = "you go into the house and find a weird flight of stairs. Climb them?";
                    option1Label.Text = "no";
                    option2Label.Text = "yes";
                    break;
                case 4:
                    outputLabel.Text = "you decide to not go down the stairs. u turn around and Danial Larusso crane kicks you in the face. you lose. play again? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 5:
                    outputLabel.Text = "You go down the stairs and find a weird looking book. open it?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 6:
                    outputLabel.Text = "You Decide too put the book down and carry on. Conner McGregor is there waiting for you and fly kicks you in the head . You lose. Play again? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 7:
                    outputLabel.Text = "You opened the book. you found a treasure map. follow it? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 8:
                    outputLabel.Text = "You Decide too put the map down and carry on. but, as you put the map down Bruce lee hit u with the one inch punch. You lose. Play again? ";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 9:
                    outputLabel.Text = "you followed the map and it led you too the most money you would ever need. You win! play again?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 11:
                    outputLabel.Text = "You followed the map and it led you back out of the house. you havent gained anything but atleast you're alive. wanna go back inside?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    Thread.Sleep(2000);
                        Refresh();
                    Application.Exit();

                    break;
                default:
                    break;


            }
        }

    }
}
