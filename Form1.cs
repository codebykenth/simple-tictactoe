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
        public Form1() {
            InitializeComponent();
            playerTurn = rnd.Next(0, 2);
            checkPlayerTurn(playerTurn);
        }

        private void btnTile1_Click(object sender, EventArgs e) {

        }

        private void resetScore() {
            this.lblP1ScoreValue.Text = "0";
            this.lblP2ScoreValue.Text = "0";
            
        }
        private void checkPlayerTurn(int playerTurn) {
            if (playerTurn % 2 == 0) { 
                this.lblPlayerTurnValue.Text = "X";
            } else {
                this.lblPlayerTurnValue.Text = "O";
            }
        }
        private void btnNewGame_Click(object sender, EventArgs e) {
            DialogResult choice = MessageBox.Show("Are you sure that you want to play a new game? This will reset both players score back to 0.", "New Game", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes) {
                lblP1ScoreVal = Convert.ToByte(this.lblP1ScoreValue.Text);
                lblP2ScoreVal = Convert.ToByte(this.lblP2ScoreValue.Text);
                resetScore();
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            resetScore();
        }
    }
}
