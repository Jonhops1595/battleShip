using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Jonathan Hopkins
 * 10/8/2020
 * Form1 is the form that is displayed for the BattleShipGUi
 * It is the View in the Model-Controller-View model
 */


namespace BattleShipGUIVersion
{
    public partial class BattleShip : Form
    {
        //Instance vars
        private Control controller;
        private Graphics drawBoard;

        //Constructor
        public BattleShip()
        {
            InitializeComponent();
            controller = new Control();
            panel1.BackColor = Color.Aqua;
            drawBoard = panel1.CreateGraphics();
            statLbl.Visible = false;
        }

        //Updates the prompt at the top of the form
        private void updatePrompt()
        {
            
            if(controller.getStateOfMain() == "diff")
            {
                promptLbl.Text = "Enter Difficulty Setting \n" +
                                 "Easy, Medium, or Hard";
                userLbl.Text = "Enter Difficulty Setting";
            }
            else
            {
                promptLbl.Text = "Enter Location [LetterNumber]\n" +
                                 "Or Press Locaion on Board\n" +
                                 "Then Press Fire!";
                userLbl.Text = "";
            }
        }

        //Updates the board where the game and stats are located
        private void updateBoard()
        {
            turnPB.Value = controller.game.NumTurns;
            if (controller.getStateOfMain() == "play")
            {
                panel1.BackColor = Color.Aqua;
                letterLbl.Visible = true;
                numLbl.Visible = true;
                statLbl.Visible = false;
                Pen pen = new Pen(Color.Black, 2);
                int y = 30; int x = 27;
                while (y < 340)
                {
                    drawBoard.DrawLine(pen, 0, y, 380, y);
                    drawBoard.DrawLine(pen, x, 0, x, 360);
                    y += 30;
                    x += 27;
                }
                Board board = controller.game.GameBoard;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (board.charBoard[i,j] == '0')
                        {
                            drawBoard.DrawEllipse(pen, j * 27, i * 30, 27, 30);
                        }
                        else if(board.charBoard[i,j] == 'X')
                        {
                            drawBoard.DrawLine(pen, j * 27, i * 30, (j + 1) * 27, (i + 1) * 30);
                            drawBoard.DrawLine(pen, (j + 1) * 27, i * 30, j * 27, (i + 1) * 30);
                        }
                    }
                }
                displayBtn.Text = "Stat Display";
            }


            else if(controller.getStateOfMain() == "stat")
            {
                statLbl.Visible = true;
                letterLbl.Visible = false;
                numLbl.Visible = false;
                drawBoard.Clear(Color.Aqua);
                statLbl.Text = controller.getStatText();
                displayBtn.Text = "Game Display";
            }

            if(controller.getStateOfBattleShip() == "end")
            {
                drawBoard.Clear(Color.Aqua);
                statLbl.Visible = true;
                if(controller.game.Status == "Victory")
                {
                    statLbl.Text = "Congrats on Winning BattleShip!";
                }
                else
                {
                    statLbl.Text = "You Lost! Try Again!";
                }
            }
        }

        //Event when the user button is clicked
        private void userBtn_Click(object sender, EventArgs e)
        {
            controller.prompt_Inputed(userTB.Text);
            updatePrompt();
            updateBoard();
            if (controller.getStateOfMain() == "play")
                turnPB.Maximum = controller.game.TurnLimit;
            userTB.Text = "";
        }

        //Event when the fire button is clicked
        private void fireBtn_Click(object sender, EventArgs e)
        {
            controller.enter_Location(targetTB.Text);
            updateBoard();
            targetTB.Text = "";
        }

        //Event when the save button is clicked
        private void saveBtn_Click(object sender, EventArgs e)
        {
            controller.save_button();
        }

        //Event when the quit button is clicked
        private void quitBtn_Click(object sender, EventArgs e)
        {
            controller.quit_button();
            System.Windows.Forms.Application.Exit();
        }

        //Event when the display button is clicked
        private void displayBtn_Click(object sender, EventArgs e)
        {
            controller.display_button();
            updateBoard();
        }

        //Updates the target based on where the user pressed on the panel
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (controller.getStateOfMain() == "play")
            {
                string clickedTarget;
                int x_value = e.X / 27;
                int y_value = e.Y / 30;
                char charTarget = 'N';
                switch (y_value)
                {
                    case 0: charTarget = 'A'; break;
                    case 1: charTarget = 'B'; break;
                    case 2: charTarget = 'C'; break;
                    case 3: charTarget = 'D'; break;
                    case 4: charTarget = 'E'; break;
                    case 5: charTarget = 'F'; break;
                    case 6: charTarget = 'G'; break;
                    case 7: charTarget = 'H'; break;
                    case 8: charTarget = 'I'; break;
                    case 9: charTarget = 'J'; break;
                }
                clickedTarget = (charTarget.ToString() + (x_value + 1));
                targetTB.Text = clickedTarget;
            }
        }
    }
}
