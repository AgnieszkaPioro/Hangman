using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    
    public partial class frmHangman : Form
    {
        private Bitmap[] hangimages = {Hangman.Properties.Resources.Hangman1, Hangman.Properties.Resources.Hangman2,
                                        Hangman.Properties.Resources.Hangman3, Hangman.Properties.Resources.Hangman4,
                                        Hangman.Properties.Resources.Hangman5, Hangman.Properties.Resources.Hangman6,
                                        Hangman.Properties.Resources.Hangman7};
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;
        private string[] hint;
        
        
        private int randomIndex;
        

        public frmHangman()
        {
            InitializeComponent();
            

        }
        private void loadwords()
        {
            char[] delimiterChars = { '|' };
            string[] readText = File.ReadAllLines("countries_and_capitals.txt");
            words = new string[readText.Length];
            hint = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];
                hint[index++] = line[0];
                
             
            }
            
        }

        private void setupWordChoice()
        {
            wrongGuesses = 0;
            hangmanImage.Image = hangimages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];
            randomIndex = new Random().Next(words.Length);
            
            labelHint.Text = "The capital of " + hint[randomIndex];

            
            copyCurrent = "";
            for(int index = 0; index < current.Length; index++ )
            {
                copyCurrent += "_";
            }
            displayCopy();
        }
        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < current.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
            }
        }

        private void updateCopy(char guess)
        {

        }

        private void guessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (current.Contains(choice.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar )
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();


            }
            else
            {
                wrongGuesses++;
            }
            if (wrongGuesses < 7)
            {
                hangmanImage.Image = hangimages[wrongGuesses];
                


            }
            else
            {
                lblResult.Text = "You Lose!!!";
                
                cmdA.Enabled = false;
                cmdB.Enabled = false;
                cmdC.Enabled = false;
                cmdD.Enabled = false;
                cmdE.Enabled = false;
                cmdF.Enabled = false;
                cmdG.Enabled = false;
                cmdH.Enabled = false;
                cmdI.Enabled = false;
                cmdJ.Enabled = false;
                cmdK.Enabled = false;
                cmdL.Enabled = false;
                cmdM.Enabled = false;
                cmdN.Enabled = false;
                cmdO.Enabled = false;
                cmdP.Enabled = false;
                cmdQ.Enabled = false;
                cmdR.Enabled = false;
                cmdS.Enabled = false;
                cmdT.Enabled = false;
                cmdU.Enabled = false;
                cmdV.Enabled = false;
                cmdW.Enabled = false;
                cmdX.Enabled = false;
                cmdY.Enabled = false;
                cmdZ.Enabled = false;
            }
            if (copyCurrent.Equals(current))
            {
                lblResult.Text = "You Win!!!";
                cmdA.Enabled = false;
                cmdB.Enabled = false;
                cmdC.Enabled = false;
                cmdD.Enabled = false;
                cmdE.Enabled = false;
                cmdF.Enabled = false;
                cmdG.Enabled = false;
                cmdH.Enabled = false;
                cmdI.Enabled = false;
                cmdJ.Enabled = false;
                cmdK.Enabled = false;
                cmdL.Enabled = false;
                cmdM.Enabled = false;
                cmdN.Enabled = false;
                cmdO.Enabled = false;
                cmdP.Enabled = false;
                cmdQ.Enabled = false;
                cmdR.Enabled = false;
                cmdS.Enabled = false;
                cmdT.Enabled = false;
                cmdU.Enabled = false;
                cmdV.Enabled = false;
                cmdW.Enabled = false;
                cmdX.Enabled = false;
                cmdY.Enabled = false;
                cmdZ.Enabled = false;
            }

        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setupWordChoice();
            lblResult.Text = "";
            cmdA.Enabled = true;
            cmdB.Enabled = true;
            cmdC.Enabled = true;
            cmdD.Enabled = true;
            cmdE.Enabled = true;
            cmdF.Enabled = true;
            cmdG.Enabled = true;
            cmdH.Enabled = true;
            cmdI.Enabled = true;
            cmdJ.Enabled = true;
            cmdK.Enabled = true;
            cmdL.Enabled = true;
            cmdM.Enabled = true;
            cmdN.Enabled = true;
            cmdO.Enabled = true;
            cmdP.Enabled = true;
            cmdQ.Enabled = true;
            cmdR.Enabled = true;
            cmdS.Enabled = true;
            cmdT.Enabled = true;
            cmdU.Enabled = true;
            cmdV.Enabled = true;
            cmdW.Enabled = true;
            cmdX.Enabled = true;
            cmdY.Enabled = true;
            cmdZ.Enabled = true;
        }

        
    }
}
