using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_game_winows
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 7;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer) {

                score++;
            }
            if(questionNumber == totalQuestions)
            {
                // percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + "questions correctly" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                     $"Your total weighted score is " + score + " out of " + totalQuestions + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }



            questionNumber++;
            askQuestion(questionNumber);

                   else
            {

                MessageBox.Show("Thank you for playing!");
                this.Close(); // Closes the form or exit the application
            }

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.QUESRION;

                    lblQuestion.Text = "what is the color of water ?";

                    button1.Text = "white";
                    button2.Text = "none";
                    button3.Text = "red";
                    button4.Text = "blue";
                     
                    correctAnswer = 2;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.FRANCE;

                    lblQuestion.Text = "what is the city above ?";

                    button1.Text = "paris";
                    button2.Text = "Rwanda";
                    button3.Text = "lagos";
                    button4.Text = "none of the above";

                    correctAnswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.HAPPY;

                    lblQuestion.Text = "what emotions is displayed above?";

                    button1.Text = "depressed";
                    button2.Text = "sad";
                    button3.Text = "angry";
                    button4.Text = "happy";

                    correctAnswer = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.PARAMOUNT;

                    lblQuestion.Text = "what production firm is shown above ?";

                    button1.Text = "Paramount Pictures";
                    button2.Text = "Netflix";
                    button3.Text = "Amazon";
                    button4.Text = "Disney";

                    correctAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.PEACOCK;

                    lblQuestion.Text = "what animal is shown above ?";

                    button1.Text = "zebra";
                    button2.Text = "lion";
                    button3.Text = "Peacock";
                    button4.Text = "eagle";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.DOLLARS;

                    lblQuestion.Text = "what type of currency is shown here ? ";

                    button1.Text = "Us dollars";
                    button2.Text = "canadian dollars";
                    button3.Text = "Rubles";
                    button4.Text = "Rwandan francs";

                    correctAnswer = 1;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.PHOTOGRAPHY;

                    lblQuestion.Text = "what type of proffesion is shown here ? ";

                    button1.Text = "doctor";
                    button2.Text = "nurse";
                    button3.Text = "photography";
                    button4.Text = "cleaner";

                    correctAnswer = 1;

                    break;





            }
        }
    }
}
