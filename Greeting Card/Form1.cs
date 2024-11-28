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
using System.Media;

namespace Greeting_Card
{
    public partial class Birthday : Form
    {
        public Birthday()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush grayBrush = new SolidBrush(Color.Silver);
            Font greet = new Font("Goudy Stout", 22, FontStyle.Bold);

            g.Clear(Color.PaleGoldenrod);

            // First Present
            g.FillRectangle(redBrush, 200, 150, 100, 75);
            g.FillRectangle(blueBrush, 200, 180, 100, 20);
            g.DrawRectangle(blackPen, 200, 150, 100, 75);
            g.FillRectangle(redBrush, 190, 140, 120, 30);
            g.FillRectangle(blueBrush, 240, 140, 20, 85);
            g.DrawRectangle(blackPen, 190, 140, 120, 30);
            g.DrawString("Happy Birthday", greet, blackBrush, 30, 50);
            g.DrawEllipse(bluePen, 230, 125, 20, 15);
            g.DrawEllipse(bluePen, 250, 125, 20, 15);
            g.DrawLine(bluePen, 250, 135, 230, 160);
            g.DrawLine(bluePen, 250, 135, 270, 160);

            // Second Present
            g.FillRectangle(yellowBrush, 275, 200, 100, 75);
            g.FillRectangle(blueBrush, 275, 230, 100, 20);
            g.DrawRectangle(blackPen, 275, 200, 100, 75);
            g.FillRectangle(yellowBrush, 265, 190, 120, 30);
            g.FillRectangle(blueBrush, 315, 190, 20, 85);
            g.DrawRectangle(blackPen, 265, 190, 120, 30);
            g.DrawEllipse(bluePen, 305, 175, 20, 15);
            g.DrawEllipse(bluePen, 325, 175, 20, 15);
            g.DrawLine(bluePen, 325, 185, 305, 210);
            g.DrawLine(bluePen, 325, 185, 345, 210);

            // Third Present
            g.FillRectangle(greenBrush, 170, 225, 100, 75);
            g.FillRectangle(blueBrush, 170, 255, 100, 20);
            g.DrawRectangle(blackPen, 170, 225, 100, 75);
            g.FillRectangle(greenBrush, 160, 215, 120, 30);
            g.FillRectangle(blueBrush, 210, 215, 20, 85);
            g.DrawRectangle(blackPen, 160, 215, 120, 30);
            g.DrawEllipse(bluePen, 200, 200, 20, 15);
            g.DrawEllipse(bluePen, 220, 200, 20, 15);
            g.DrawLine(bluePen, 220, 210, 200, 235);
            g.DrawLine(bluePen, 220, 210, 240, 235);
            g.DrawString("Brian", greet, blackBrush, 200, 350);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer cheer = new SoundPlayer(Properties.Resources.cheer);
            SoundPlayer geese = new SoundPlayer(Properties.Resources.geese);
            SoundPlayer bday = new SoundPlayer(Properties.Resources.bday);
            SoundPlayer wind = new SoundPlayer(Properties.Resources.wind);
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Pen lblackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush grayBrush = new SolidBrush(Color.Silver);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Font greet = new Font("Goudy Stout", 22, FontStyle.Bold);

            bday.Play();
            for (int i = 0; i <= 2; i++)
            {
               
                Refresh(); 
                g.Clear(Color.Red);
                DrawScreen();
                Thread.Sleep(600);
                Refresh();
                g.Clear(Color.Blue);
                DrawScreen();
                Thread.Sleep(600);
                Refresh(); 
                g.Clear(Color.Green);
                DrawScreen();
                Thread.Sleep(600);
                Refresh(); 
                g.Clear(Color.Yellow);
                DrawScreen();
                Thread.Sleep(600);

            }
            g.Clear(Color.PaleGoldenrod);
            DrawScreen();

            geese.Play();
            for (int i = 0; i <= 19; i++)
            {
                int yO = 75 - i * 20;
                int xO = 420 + i * 10;
                int lineyO = 175 - i * 20;
                int linexO = 458 + (i * 10);
                int yR = 75 - i * 20;
                int xR = 20 + i * 10;
                int linexR = 58 + (i * 10);
                int lineyR = 175 - (i * 20);
                int xG = 75 + (i * 10);
                int yG = 200 - i * 20;
                int linexG = 113 + i * 10;
                int lineyG = 300 - (i * 20);
                int xC = 475 + (i * 10);
                int yC = 200 - i * 20;
                int linexC = 513 + i * 10;
                int lineyC = 300 - i * 20;
                Refresh();
                BalloonFlying();

                g.FillEllipse(orangeBrush, xO, yO, 75, 100);
                g.DrawEllipse(blackPen, xO, yO, 75, 100);
                g.DrawLine(blackPen, linexO, lineyO, linexO - 15, lineyO + 65);
                g.DrawEllipse(blackPen, xR, yR, 75, 100);
                g.FillEllipse(redBrush, xR, yR, 75, 100);
                g.DrawLine(blackPen, linexR, lineyR, linexR - 15, lineyR + 65);
                g.DrawEllipse(blackPen, xG, yG, 75, 100);
                g.FillEllipse(greenBrush, xG, yG, 75, 100);
                g.DrawLine(blackPen, linexG, lineyG, linexG - 15, lineyG + 65);
                g.DrawEllipse(blackPen, xC, yC, 75, 100);
                g.FillEllipse(yellowBrush, xC, yC, 75, 100);
                g.DrawLine(blackPen, linexC, lineyC, linexC - 15, lineyC + 65);

                Thread.Sleep(400);
                if(i == 6 || i == 12)
                {
                    geese.Play();
                }
            }

            Refresh();
            wind.Play();
            BlowFire(); 
            g.FillPie(orangeBrush, 215, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 315, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 285, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 270, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 215, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 315, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 285, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 270, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(500);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 315, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 285, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 270, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 315, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 285, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 270, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(400);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 285, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 270, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 285, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 270, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(300);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 270, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 270, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(200);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(150);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(150);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);

            Thread.Sleep(100);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(100);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(100);
            Refresh();
            BlowFire();
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60); 
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);
            Thread.Sleep(400);
            Refresh();
            BlowFire();
            Thread.Sleep(1000);
            MoveCake();
            for (int i = 0; i < 22; i++)
            {
                int layer = 210 + i * 20;
                int other = 210 - i * 20;
                Refresh();
                MoveCake();
                g.DrawEllipse(blackPen, other, 200, 200, 100);
                g.DrawEllipse(blackPen, other, 170, 180, 80);
                g.DrawEllipse(blackPen, layer, 150, 180, 80);
                g.FillEllipse(grayBrush, other, 200, 200, 100);
                g.DrawEllipse(blackPen, layer, 190, 180, 80);
                g.FillEllipse(whiteBrush, layer, 190, 180, 80);
                g.FillEllipse(redBrush, other, 170, 180, 80);
                g.FillEllipse(whiteBrush, layer, 150, 180, 80);
                Thread.Sleep(100);

            }
            Refresh();
            g.Clear(Color.White);
            MoveCake();
            Thread.Sleep(1000);
            Refresh();
            g.Clear(Color.White);
            MoveCake();
            g.FillRectangle(whiteBrush, 70, 20, 435, 10);
            Thread.Sleep(500);
            Refresh();
            g.Clear(Color.White);
            MoveCake();
            g.FillRectangle(whiteBrush, 70, 20, 435, 23);
            Thread.Sleep(500);
            Refresh();
            g.Clear(Color.White);
            MoveCake();
            g.FillRectangle(whiteBrush, 70, 20, 435, 36);
            Thread.Sleep(500);
            Refresh();
            g.Clear(Color.White);
            MoveCake();
            g.FillRectangle(whiteBrush, 70, 20, 435, 50);
            Thread.Sleep(1000);

            g.DrawString("From Lucas", greet, blackBrush, 100, 200);
            g.TranslateTransform(200, 100);
            g.RotateTransform(90);
            g.DrawString(":)", greet, blueBrush, 0, 0);
            g.ResetTransform();
            cheer.Play();
        }
        private void MoveCake()
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Pen lblackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush grayBrush = new SolidBrush(Color.Silver);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Font greet = new Font("Goudy Stout", 22, FontStyle.Bold);

            g.DrawRectangle(blackPen, 75, 25, 425, 40);
            g.FillRectangle(whiteBrush, 75, 25, 425, 40);
            g.DrawString("Brian's B-Day!", greet, blackBrush, 75, 25);
        }

        private void BlowFire()
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Pen lblackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush grayBrush = new SolidBrush(Color.Silver);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Font greet = new Font("Goudy Stout", 22, FontStyle.Bold);
            g.DrawEllipse(blackPen, 200, 200, 200, 100);
            g.DrawEllipse(blackPen, 210, 170, 180, 80);
            g.DrawEllipse(blackPen, 210, 150, 180, 80);
            g.FillEllipse(grayBrush, 200, 200, 200, 100);
            g.DrawEllipse(blackPen, 210, 190, 180, 80);
            g.FillEllipse(whiteBrush, 210, 190, 180, 80);
            g.FillEllipse(redBrush, 210, 170, 180, 80);
            g.FillEllipse(whiteBrush, 210, 150, 180, 80);

            g.DrawRectangle(lblackPen, 330, 180, 5, 20);
            g.DrawRectangle(lblackPen, 300, 150, 5, 20);
            g.DrawRectangle(lblackPen, 285, 160, 5, 20);
            g.DrawRectangle(lblackPen, 350, 170, 5, 20);
            g.DrawRectangle(lblackPen, 270, 150, 5, 20);
            g.DrawRectangle(lblackPen, 260, 170, 5, 20);
            g.DrawRectangle(lblackPen, 310, 160, 5, 20);
            g.DrawRectangle(lblackPen, 230, 175, 5, 20);
            g.DrawRectangle(lblackPen, 340, 165, 5, 20);
            g.DrawRectangle(lblackPen, 290, 190, 5, 20);

            g.FillRectangle(pinkBrush, 330, 180, 5, 20);
            g.FillRectangle(pinkBrush, 300, 150, 5, 20);
            g.FillRectangle(pinkBrush, 285, 160, 5, 20);
            g.FillRectangle(pinkBrush, 350, 170, 5, 20);
            g.FillRectangle(blueBrush, 270, 150, 5, 20);
            g.FillRectangle(blueBrush, 260, 170, 5, 20);
            g.FillRectangle(blueBrush, 310, 160, 5, 20);
            g.FillRectangle(redBrush, 230, 175, 5, 20);
            g.FillRectangle(redBrush, 340, 165, 5, 20);
            g.FillRectangle(redBrush, 290, 190, 5, 20);

            g.DrawRectangle(blackPen, 75, 25, 425, 40);
            g.FillRectangle(whiteBrush, 75, 25, 425, 40);
            g.DrawString("Brian's B-Day!", greet, blackBrush, 75, 25);
        }
        private void BalloonFlying()
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Pen lblackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush grayBrush = new SolidBrush(Color.Silver);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Font greet = new Font("Goudy Stout", 22, FontStyle.Bold);
            g.DrawEllipse(blackPen, 200, 200, 200, 100);
            g.DrawEllipse(blackPen, 210, 170, 180, 80);
            g.DrawEllipse(blackPen, 210, 150, 180, 80);
            g.FillEllipse(grayBrush, 200, 200, 200, 100);
            g.DrawEllipse(blackPen, 210, 190, 180, 80);
            g.FillEllipse(whiteBrush, 210, 190, 180, 80);
            g.FillEllipse(redBrush, 210, 170, 180, 80);
            g.FillEllipse(whiteBrush, 210, 150, 180, 80);

            g.DrawRectangle(lblackPen, 330, 180, 5, 20);
            g.DrawRectangle(lblackPen, 300, 150, 5, 20);
            g.DrawRectangle(lblackPen, 285, 160, 5, 20);
            g.DrawRectangle(lblackPen, 350, 170, 5, 20);
            g.DrawRectangle(lblackPen, 270, 150, 5, 20);
            g.DrawRectangle(lblackPen, 260, 170, 5, 20);
            g.DrawRectangle(lblackPen, 310, 160, 5, 20);
            g.DrawRectangle(lblackPen, 230, 175, 5, 20);
            g.DrawRectangle(lblackPen, 340, 165, 5, 20);
            g.DrawRectangle(lblackPen, 290, 190, 5, 20);

            g.FillRectangle(pinkBrush, 330, 180, 5, 20);
            g.FillRectangle(pinkBrush, 300, 150, 5, 20);
            g.FillRectangle(pinkBrush, 285, 160, 5, 20);
            g.FillRectangle(pinkBrush, 350, 170, 5, 20);
            g.FillRectangle(blueBrush, 270, 150, 5, 20);
            g.FillRectangle(blueBrush, 260, 170, 5, 20);
            g.FillRectangle(blueBrush, 310, 160, 5, 20);
            g.FillRectangle(redBrush, 230, 175, 5, 20);
            g.FillRectangle(redBrush, 340, 165, 5, 20);
            g.FillRectangle(redBrush, 290, 190, 5, 20);

            g.DrawPie(lblackPen, 215, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 315, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 285, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 270, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);

            // Flames
            g.FillPie(orangeBrush, 215, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 315, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 285, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 270, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60);

            g.DrawRectangle(blackPen, 75, 25, 425, 40);
            g.FillRectangle(whiteBrush, 75, 25, 425, 40);
            g.DrawString("Brian's B-Day!", greet, blackBrush, 75, 25);

        }
        private void DrawScreen()
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Pen lblackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush grayBrush = new SolidBrush(Color.Silver);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Font greet = new Font("Goudy Stout", 22, FontStyle.Bold);

            g.DrawEllipse(blackPen, 200, 200, 200, 100);
            g.DrawEllipse(blackPen, 210, 170, 180, 80);
            g.DrawEllipse(blackPen, 210, 150, 180, 80);
            g.FillEllipse(grayBrush, 200, 200, 200, 100);
            g.DrawEllipse(blackPen, 210, 190, 180, 80);
            g.FillEllipse(whiteBrush, 210, 190, 180, 80);
            g.FillEllipse(redBrush, 210, 170, 180, 80);
            g.FillEllipse(whiteBrush, 210, 150, 180, 80);

            g.DrawRectangle(lblackPen, 330, 180, 5, 20);
            g.DrawRectangle(lblackPen, 300, 150, 5, 20);
            g.DrawRectangle(lblackPen, 285, 160, 5, 20);
            g.DrawRectangle(lblackPen, 350, 170, 5, 20);
            g.DrawRectangle(lblackPen, 270, 150, 5, 20);
            g.DrawRectangle(lblackPen, 260, 170, 5, 20);
            g.DrawRectangle(lblackPen, 310, 160, 5, 20);
            g.DrawRectangle(lblackPen, 230, 175, 5, 20);
            g.DrawRectangle(lblackPen, 340, 165, 5, 20);
            g.DrawRectangle(lblackPen, 290, 190, 5, 20);

            g.FillRectangle(pinkBrush, 330, 180, 5, 20);
            g.FillRectangle(pinkBrush, 300, 150, 5, 20);
            g.FillRectangle(pinkBrush, 285, 160, 5, 20);
            g.FillRectangle(pinkBrush, 350, 170, 5, 20);
            g.FillRectangle(blueBrush, 270, 150, 5, 20);
            g.FillRectangle(blueBrush, 260, 170, 5, 20);
            g.FillRectangle(blueBrush, 310, 160, 5, 20);
            g.FillRectangle(redBrush, 230, 175, 5, 20);
            g.FillRectangle(redBrush, 340, 165, 5, 20);
            g.FillRectangle(redBrush, 290, 190, 5, 20);

            g.DrawEllipse(blackPen, 20, 75, 75, 100);
            g.DrawEllipse(blackPen, 75, 200, 75, 100);
            g.DrawEllipse(blackPen, 420, 75, 75, 100);
            g.DrawEllipse(blackPen, 475, 200, 75, 100);
            g.FillEllipse(redBrush, 20, 75, 75, 100);
            g.FillEllipse(greenBrush, 75, 200, 75, 100);
            g.FillEllipse(orangeBrush, 420, 75, 75, 100);
            g.FillEllipse(yellowBrush, 475, 200, 75, 100);
            g.DrawLine(blackPen, 58, 175, 58, 250);
            g.DrawLine(blackPen, 113, 300, 113, 375);
            g.DrawLine(blackPen, 458, 175, 458, 250);
            g.DrawLine(blackPen, 513, 300, 513, 375);

            g.DrawPie(lblackPen, 215, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 315, 140, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 285, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 270, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 335, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 255, 110, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 245, 130, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 295, 120, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 325, 125, 35, 40, 60, 60);
            g.DrawPie(lblackPen, 275, 150, 35, 40, 60, 60);

            // Flames
            g.FillPie(orangeBrush, 215, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 315, 140, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 285, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 270, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 335, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 255, 110, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 245, 130, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 295, 120, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 325, 125, 35, 40, 60, 60);
            g.FillPie(orangeBrush, 275, 150, 35, 40, 60, 60);

            g.DrawRectangle(blackPen, 75, 25, 425, 40);
            g.FillRectangle(whiteBrush, 75, 25, 425, 40);
            g.DrawString("Brian's B-Day!", greet, blackBrush, 75, 25);
        }
    }
}
