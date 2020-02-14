using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Multi-Dimensional TicTacToe - Nicholas Taylor
/// Purpose is to make a Multi-Dimensional Tic Tac Toe Game with a GUI
/// 12/11/2018
/// </summary>
namespace MultiDimensionalTicTacToe
{
    public partial class Form1 : Form
    {

        GameMechanics Gameplay = new GameMechanics();
        public int turnSequence = 0;

        /// <summary>
        /// Form1 Initialization
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroZeroZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroZeroZero, turnLabel, 0);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroZeroOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroZeroOne, turnLabel, 1);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroZeroTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroZeroTwo, turnLabel, 2);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroOneZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroOneZero, turnLabel, 3);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroOneOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroOneOne, turnLabel, 4);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroOneTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroOneTwo, turnLabel, 5);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroTwoZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroTwoZero, turnLabel, 6);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroTwoOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroTwoOne, turnLabel, 7);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonZeroTwoTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonZeroTwoTwo, turnLabel, 8);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneZeroZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneZeroZero, turnLabel, 9);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneZeroOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneZeroOne, turnLabel, 10);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneZeroTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneZeroTwo, turnLabel, 11);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneOneZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneOneZero, turnLabel, 12);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneOneOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneOneOne, turnLabel, 13);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneOneTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneOneTwo, turnLabel, 14);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneTwoZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneTwoZero, turnLabel, 15);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneTwoOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneTwoOne, turnLabel, 16);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonOneTwoTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonOneTwoTwo, turnLabel, 17);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoZeroZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoZeroZero, turnLabel, 18);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoZeroOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoZeroOne, turnLabel, 19);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoZeroTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoZeroTwo, turnLabel, 20);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoOneZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoOneZero, turnLabel, 21);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoOneOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoOneOne, turnLabel, 22);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoOneTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoOneTwo, turnLabel, 23);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoTwoZero_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoTwoZero, turnLabel, 24);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoTwoOne_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoTwoOne, turnLabel, 25);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Play Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButtonTwoTwoTwo_Click(object sender, EventArgs e)
        {
            int swap = Gameplay.Start(turnSequence, playButtonTwoTwoTwo, turnLabel, 26);
            turnSequence = swap; // swaps turn
        }

        /// <summary>
        /// Restarts Application to reset everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Program.RestartForm();
        }

    } // End Class

    /// <summary>
    /// Class used for the mechanics of tic tac toe game such as Play and DetectWin
    /// </summary>
    public class GameMechanics
    {

        //Declares storage variables for each button
        public int playZeroZeroZero = 2;
        public int playZeroZeroOne = 3;
        public int playZeroZeroTwo = 4;
        public int playZeroOneZero = 5;
        public int playZeroOneOne = 6;
        public int playZeroOneTwo = 7;
        public int playZeroTwoZero = 8;
        public int playZeroTwoOne = 9;
        public int playZeroTwoTwo = 10;
        public int playOneZeroZero = 11;
        public int playOneZeroOne = 12;
        public int playOneZeroTwo = 13;
        public int playOneOneZero = 14;
        public int playOneOneOne = 15;
        public int playOneOneTwo = 16;
        public int playOneTwoZero = 17;
        public int playOneTwoOne = 18;
        public int playOneTwoTwo = 19;
        public int playTwoZeroZero = 20;
        public int playTwoZeroOne = 21;
        public int playTwoZeroTwo = 22;
        public int playTwoOneZero = 23;
        public int playTwoOneOne = 24;
        public int playTwoOneTwo = 25;
        public int playTwoTwoZero = 26;
        public int playTwoTwoOne = 27;
        public int playTwoTwoTwo = 28;

        /// <summary>
        /// Play Method 
        /// Used for actual user X's and O's
        /// </summary>
        /// <param name="TurnSequence"></param>
        /// <param name="ButtonName"></param>
        public void Play(int TurnSequence, Button ButtonName)
        {
            
            if (TurnSequence == 0)
            {
                string turn = "X";
                ButtonName.Text = turn;
            }
            else if (TurnSequence == 1)
            {
                string turn = "O";
                ButtonName.Text = turn;
            }

            ButtonName.Enabled = false; // Disables reusage of a button

        } // End Play Method

        /// <summary>
        /// DetectWin Method
        /// Used to find combinations
        /// </summary>
        /// <param name="TurnSequence"></param>
        /// <param name="Identification"></param>
        /// <returns></returns>
        public int DetectWin(int TurnSequence, int Identification)
        {
            
            int ret = 2;

            //Stores an int for each button
            switch (Identification)
            {
                case 0:
                    playZeroZeroZero = TurnSequence;
                    break;
                case 1:
                    playZeroZeroOne = TurnSequence;
                    break;
                case 2:
                    playZeroZeroTwo = TurnSequence;
                    break;
                case 3:
                    playZeroOneZero = TurnSequence;
                    break;
                case 4:
                    playZeroOneOne = TurnSequence;
                    break;
                case 5:
                    playZeroOneTwo = TurnSequence;
                    break;
                case 6:
                    playZeroTwoZero = TurnSequence;
                    break;
                case 7:
                    playZeroTwoOne = TurnSequence;
                    break;
                case 8:
                    playZeroTwoTwo = TurnSequence;
                    break;
                case 9:
                    playOneZeroZero = TurnSequence;
                    break;
                case 10:
                    playOneZeroOne = TurnSequence;
                    break;
                case 11:
                    playOneZeroTwo = TurnSequence;
                    break;
                case 12:
                    playOneOneZero = TurnSequence;
                    break;
                case 13:
                    playOneOneOne = TurnSequence;
                    break;
                case 14:
                    playOneOneTwo = TurnSequence;
                    break;
                case 15:
                    playOneTwoZero = TurnSequence;
                    break;
                case 16:
                    playOneTwoOne = TurnSequence;
                    break;
                case 17:
                    playOneTwoTwo = TurnSequence;
                    break;
                case 18:
                    playTwoZeroZero = TurnSequence;
                    break;
                case 19:
                    playTwoZeroOne = TurnSequence;
                    break;
                case 20:
                    playTwoZeroTwo = TurnSequence;
                    break;
                case 21:
                    playTwoOneZero = TurnSequence;
                    break;
                case 22:
                    playTwoOneOne = TurnSequence;
                    break;
                case 23:
                    playTwoOneTwo = TurnSequence;
                    break;
                case 24:
                    playTwoTwoZero = TurnSequence;
                    break;
                case 25:
                    playTwoTwoOne = TurnSequence;
                    break;
                case 26:
                    playTwoTwoTwo = TurnSequence;
                    break;
                default:
                    break;
            }

            //All possible winning combinations
            List<List<int>> combinations = new List<List<int>>
            {
                new List<int>(){ playZeroZeroZero, playZeroZeroOne, playZeroZeroTwo}, //Level 1
                new List<int>(){ playZeroZeroZero, playZeroOneOne, playZeroTwoTwo},
                new List<int>(){ playZeroZeroZero, playZeroOneZero, playZeroTwoZero},
                new List<int>(){ playZeroOneZero, playZeroOneOne, playZeroOneTwo},
                new List<int>(){ playZeroTwoZero, playZeroTwoOne, playZeroTwoTwo},
                new List<int>(){ playZeroZeroOne, playZeroOneOne, playZeroTwoOne},
                new List<int>(){ playZeroZeroTwo, playZeroOneTwo, playZeroTwoTwo},
                new List<int>(){ playZeroZeroTwo, playZeroOneOne, playZeroTwoZero},
                new List<int>(){ playOneZeroZero, playOneZeroOne, playOneZeroTwo}, //Level 2
                new List<int>(){ playOneZeroZero, playOneOneOne, playOneTwoTwo},
                new List<int>(){ playOneZeroZero, playOneOneZero, playOneTwoZero},
                new List<int>(){ playOneOneZero, playOneOneOne, playOneOneTwo},
                new List<int>(){ playOneTwoZero, playOneTwoOne, playOneTwoTwo},
                new List<int>(){ playOneZeroOne, playOneOneOne, playOneTwoOne},
                new List<int>(){ playOneZeroTwo, playOneOneTwo, playOneTwoTwo},
                new List<int>(){ playOneZeroTwo, playOneOneOne, playOneTwoZero},
                new List<int>(){ playTwoZeroZero, playTwoZeroOne, playTwoZeroTwo}, //Level 3
                new List<int>(){ playTwoZeroZero, playTwoOneOne, playTwoTwoTwo},
                new List<int>(){ playTwoZeroZero, playTwoOneZero, playTwoTwoZero},
                new List<int>(){ playTwoOneZero, playTwoOneOne, playTwoOneTwo},
                new List<int>(){ playTwoTwoZero, playTwoTwoOne, playTwoTwoTwo},
                new List<int>(){ playTwoZeroOne, playTwoOneOne, playTwoTwoOne},
                new List<int>(){ playTwoZeroTwo, playTwoOneTwo, playTwoTwoTwo},
                new List<int>(){ playTwoZeroTwo, playTwoOneOne, playTwoTwoZero},
                new List<int>(){ playZeroZeroZero, playOneZeroZero, playTwoZeroZero}, //Vertical
                new List<int>(){ playZeroOneZero, playOneOneZero, playTwoOneZero},
                new List<int>(){ playZeroTwoZero, playOneTwoZero, playTwoTwoZero},
                new List<int>(){ playZeroZeroOne, playOneZeroOne, playTwoZeroOne},
                new List<int>(){ playZeroOneOne, playOneOneOne, playTwoOneOne},
                new List<int>(){ playZeroTwoOne, playOneTwoOne, playTwoTwoOne},
                new List<int>(){ playZeroZeroTwo, playOneZeroTwo, playTwoZeroTwo},
                new List<int>(){ playZeroOneTwo, playOneOneTwo, playTwoOneTwo},
                new List<int>(){ playZeroTwoTwo, playOneTwoTwo, playTwoTwoTwo},
                new List<int>(){ playZeroZeroZero, playOneOneOne, playTwoTwoTwo}, //Vertex Diagonals
                new List<int>(){ playZeroTwoZero, playOneOneOne, playTwoZeroTwo},
                new List<int>(){ playZeroZeroTwo, playOneOneOne, playTwoTwoZero},
                new List<int>(){ playZeroTwoTwo, playOneOneOne, playTwoZeroZero},
                new List<int>(){ playZeroZeroZero, playOneZeroOne, playTwoTwoTwo}, //Front to Back Vertical Diagonals
                new List<int>(){ playZeroZeroTwo, playOneZeroOne, playTwoZeroZero},
                new List<int>(){ playZeroOneZero, playOneOneOne, playTwoOneTwo},
                new List<int>(){ playZeroOneTwo, playOneOneOne, playTwoOneZero},
                new List<int>(){ playZeroTwoTwo, playOneTwoOne, playTwoTwoZero},
                new List<int>(){ playZeroTwoZero, playOneTwoOne, playTwoTwoTwo},
                new List<int>(){ playZeroZeroZero, playOneOneZero, playTwoTwoZero}, //Front to Back Horizontal Diagonals
                new List<int>(){ playZeroTwoZero, playOneOneZero, playTwoZeroZero},
                new List<int>(){ playZeroZeroOne, playOneOneOne, playTwoTwoOne},
                new List<int>(){ playZeroTwoOne, playOneOneOne, playTwoZeroOne},
                new List<int>(){ playZeroZeroTwo, playOneOneTwo, playTwoTwoTwo},
                new List<int>(){ playZeroTwoTwo, playOneOneTwo, playTwoZeroTwo},
            };

            foreach(List<int> check in combinations)
            {
                if(TestCombination(check)) // Returns boolean testing each combination to find at least one applicable solution
                {
                    ret = TurnSequence;        
                } 
            }

            return ret; // Always will return something

        } // End DetectWin Method

        /// <summary>
        /// TestCombination Method
        /// Tests a combination list to check if all values are equal
        /// </summary>
        /// <param name="group"></param>
        /// <returns>boolean</returns>
        public bool TestCombination(List<int> group)
        {
            int value1 = group.ElementAt<int>(0);
            int value2 = group.ElementAt<int>(1);
            int value3 = group.ElementAt<int>(2);
            bool allThreeAreEqual = false; // defaults value to false
            allThreeAreEqual = value1 == value2 && value2 == value3;
            return allThreeAreEqual;
        }

        /// <summary>
        /// Start Method
        /// Does Core work of program
        /// </summary>
        /// <param name="turnSequence"></param>
        /// <param name="ButtonName"></param>
        /// <param name="turnLabel"></param>
        /// <param name="Identification"></param>
        /// <returns></returns>
        public int Start(int turnSequence, Button ButtonName, Label turnLabel, int Identification)
        {
            Play(turnSequence, ButtonName); // Plays Turn
            int winCheck = DetectWin(turnSequence, Identification); // Checks for possibilities of winning and also stores database of turns taken

            turnSequence = LabelChange(turnLabel, turnSequence);
            if (winCheck == 0)
            {
                MessageBox.Show("Player 1 - X's Win!");
                
            }
            else if (winCheck == 1)
            {
                MessageBox.Show("Player 2 - O's Win!");
                
            }
            return turnSequence;
        }

        /// <summary>
        /// Label Change
        /// Toggles Turn Sequences and Swaps Label from O to X
        /// </summary>
        /// <param name="turnLabel"></param>
        /// <param name="turnSequence"></param>
        /// <returns></returns>
        public int LabelChange(Label turnLabel, int turnSequence)
        {
            if (turnSequence == 0)
            {
                turnLabel.Text = "Turn: O";
                turnSequence = 1;
            }
            else if (turnSequence == 1)
            {
                turnSequence = 0;
                turnLabel.Text = "Turn: X";
            }
            return turnSequence;
        }
       
        public void HideButton(Button button)
        {
            button.Visible = false;
        }
        
    } // End GameMechanics Class

} // End Namespace
