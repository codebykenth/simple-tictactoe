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
        public Form1() {
            InitializeComponent();
        }

       

        public void newGame() {
            DialogResult choice = MessageBox.Show("Are you sure that you want to play a new game? This will reset both players score back to 0.", "New Game", MessageBoxButtons.YesNo);

            if (choice == DialogResult.OK) { 
                
            }
        }

        private void btnTile1_Click(object sender, EventArgs e) {

        }
    }
}
