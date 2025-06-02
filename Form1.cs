using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class Form1 : Form {
        Random rnd = new Random();
        byte lblP1ScoreVal = 0, lblP2ScoreVal = 0;
        int playerTurn;
        string btnClicked = "";
        bool hasWinner = false;

        public Form1() {
            InitializeComponent();
            playerTurn = rnd.Next(0, 2); // Generate a random number so that the player turn will be randomized
            initializePlayerTurn(playerTurn);
        }

        /*
         // Clears the text of all tile button
         */
        private void clearBtnTile() {
            this.btnTile1.Text = string.Empty;
            this.btnTile2.Text = string.Empty;
            this.btnTile3.Text = string.Empty;
            this.btnTile4.Text = string.Empty;
            this.btnTile5.Text = string.Empty;
            this.btnTile6.Text = string.Empty;
            this.btnTile7.Text = string.Empty;
            this.btnTile8.Text = string.Empty;
            this.btnTile9.Text = string.Empty;
            hasWinner = false;
        }

        /*
         // Initializes the player turn value
         */
        private void initializePlayerTurn(int playerTurn) {
            if (playerTurn % 2 == 0) {
                this.lblPlayerTurnValue.Text = "X";
            } else {
                this.lblPlayerTurnValue.Text = "O";
            }
        }

        /*
         // Returns a string of player turn
         // If it is player 1 turn, then X will be returned
         // If it is player 2 turn, then O will be returned
         // Sets the text value of player turn to the current player who will move
         */
        private string checkTurn() {
            string pTurn = "";
            string p1 = "X";
            string p2 = "O";

            if (playerTurn % 2 == 0) {
                pTurn = p1;
                this.lblPlayerTurnValue.Text = p2;
            } else {
                pTurn = p2;
                this.lblPlayerTurnValue.Text = p1;
            }
            return pTurn;
        }

        /*
         // Check if the turn is for player 1 or player 2
         // Check if there is already a winner
         // Check if there is a draw
         */
        private void checkPlayerTurn(string btnClicked) {

            switch (btnClicked) {
                case "btnTile1": {
                    this.btnTile1.Text = checkTurn();
                    break;
                }
                case "btnTile2": {
                    this.btnTile2.Text = checkTurn();
                    break;
                }
                case "btnTile3": {
                    this.btnTile3.Text = checkTurn();
                    break;
                }
                case "btnTile4": {
                    this.btnTile4.Text = checkTurn();
                    break;
                }
                case "btnTile5": {
                    this.btnTile5.Text = checkTurn();
                    break;
                }
                case "btnTile6": {
                    this.btnTile6.Text = checkTurn();
                    break;
                }
                case "btnTile7": {
                    this.btnTile7.Text = checkTurn();
                    break;
                }
                case "btnTile8": {
                    this.btnTile8.Text = checkTurn();
                    break;
                }
                case "btnTile9": {
                    this.btnTile9.Text = checkTurn();
                    break;
                }
                default:
                break;
            }
            playerTurn++;
            checkWinner();
            checkDraw();
        }

        private void checkWinner() {
            string p1Win = "XXX";
            string p2Win = "OOO";

            // Array of winning condition
            string[] playerWin = { $"{this.btnTile1.Text}{this.btnTile2.Text}{this.btnTile3.Text}", $"{this.btnTile4.Text}{this.btnTile5.Text}{this.btnTile6.Text}", $"{this.btnTile7.Text}{this.btnTile8.Text}{this.btnTile9.Text}", $"{this.btnTile1.Text}{this.btnTile4.Text}{this.btnTile7.Text}", $"{this.btnTile2.Text}{this.btnTile5.Text}{this.btnTile8.Text}", $"{this.btnTile3.Text}{this.btnTile6.Text}{this.btnTile9.Text}", $"{this.btnTile1.Text}{this.btnTile5.Text}{this.btnTile9.Text}", $"{this.btnTile3.Text}{this.btnTile5.Text}{this.btnTile7.Text}" };

            for (int i = 0; i < playerWin.Length; i++) {
                if (playerWin[i].Equals(p1Win)) {
                    hasWinner = true;
                    lblP1ScoreVal++;
                    MessageBox.Show("PLAYER 1 WIN!");
                    this.lblP1ScoreValue.Text = lblP1ScoreVal.ToString();
                    clearBtnTile();

                } else if (playerWin[i].Equals(p2Win)) {
                    hasWinner = true;
                    lblP2ScoreVal++;
                    MessageBox.Show("PLAYER 2 WIN!");
                    this.lblP2ScoreValue.Text = lblP2ScoreVal.ToString();
                    clearBtnTile();
                }
            }
        }

        private void checkDraw() {
            string btnText = this.btnTile1.Text + this.btnTile2.Text + this.btnTile3.Text + this.btnTile4.Text + this.btnTile5.Text + this.btnTile6.Text + this.btnTile7.Text + this.btnTile8.Text + this.btnTile9.Text;
            if (btnText.Length == 9 && !hasWinner) {
                MessageBox.Show("DRAW!");
                clearBtnTile();
            }
        }

       

        private void btnReset_Click(object sender, EventArgs e) {
            DialogResult choice = MessageBox.Show("Are you sure that you want to play a new game? This will reset both players score back to 0.", "New Game", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes) {
                this.lblP1ScoreValue.Text = "0";
                this.lblP2ScoreValue.Text = "0";
                lblP1ScoreVal = Convert.ToByte(this.lblP1ScoreValue.Text);
                lblP2ScoreVal = Convert.ToByte(this.lblP2ScoreValue.Text);
                clearBtnTile();
            }
        }

        private void btnTile1_Click(object sender, EventArgs e) {
            btnClicked = "btnTile1";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile2_Click(object sender, EventArgs e) {
            btnClicked = "btnTile2";
            checkPlayerTurn(btnClicked);

        }

        private void btnTile3_Click(object sender, EventArgs e) {
            btnClicked = "btnTile3";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile4_Click(object sender, EventArgs e) {
            btnClicked = "btnTile4";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile5_Click(object sender, EventArgs e) {
            btnClicked = "btnTile5";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile6_Click(object sender, EventArgs e) {
            btnClicked = "btnTile6";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile7_Click(object sender, EventArgs e) {
            btnClicked = "btnTile7";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile8_Click(object sender, EventArgs e) {
            btnClicked = "btnTile8";
            checkPlayerTurn(btnClicked);
        }

        private void btnTile9_Click(object sender, EventArgs e) {
            btnClicked = "btnTile9";
            checkPlayerTurn(btnClicked);
        }
    }
}