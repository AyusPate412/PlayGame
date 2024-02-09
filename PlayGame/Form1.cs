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

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameStarting.Hide();
            loadingBar.Hide();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer loadingSound = new SoundPlayer(Properties.Resources.interface_124464);
            loadingBar.Minimum = 0;
            loadingBar.Maximum = 100;

            playButton.Hide();  
            gameStarting.Show();
            loadingBar.Show();

            Refresh();
            this.Text = "Waiting";
            loadingSound.Play();

            gameStarting.Text = "Game Starts in: 3";
            loadingBar.Value = 20;
            Refresh();
            Thread.Sleep(1000);

            loadingSound.Stop();
            gameStarting.Text = "Game Starts in: 2";
            loadingBar.Value = 70;
            loadingSound.Play();
            Refresh();
            Thread.Sleep(1000);

            loadingSound.Stop();
            gameStarting.Text = "Game Starts in: 1";
            loadingBar.Value = 100;
            loadingSound.Play();
            Refresh();
            Thread.Sleep(1000);

            Refresh();
            this.Text = "Playing";
            loadingBar.Hide();
            loadingSound.Stop();
            this.BackColor = Color.Green;
            Refresh();
            gameStarting.Text = "Go";
            gameStarting.BackColor = Color.Green;
            gameStarting.ForeColor = Color.White;
        }
    }
}
