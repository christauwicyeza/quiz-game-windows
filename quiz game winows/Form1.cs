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
    /// <summary>
    /// Form for the quiz game.
    /// </summary>
    public partial class Form1 : Form
    {
        // Quiz game variables
        private int correctAnswer;
        private int questionNumber = 1;
        private int score;
        private int percentage;
        private int totalQuestions;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Assign the event handler to the "Submit" button
            button5.Click += submitButton_Click;

            totalQuestions = 7;
            askQuestion(questionNumber);
        }

        /// <summary>
        /// Event handler for the submit button click event.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Proceed to the next question
            questionNumber++;
            if (questionNumber > totalQuestions)
            {
                // Calculate percentage and display results when all questions are answered
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    $"Your total weighted score is " + score + " out of " + totalQuestions + Environment.NewLine +
                    "Click OK to play again" + Environment.NewLine +
                    " " + Environment.NewLine +
                    " Close tab to go back"
                );

                // Reset score and question number for next round
                score = 0;
                questionNumber = 1;
            }

            // Ask the next question
            askQuestion(questionNumber);
        }

        /// <summary>
        /// Event handler for the answer button click event.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var selectedButton = (Button)sender;
            int selectedAnswer = Convert.ToInt32(selectedButton.Tag);

            // Check if the selected answer is correct
            if (selectedAnswer == correctAnswer)
            {
                score++;
                ShowNotification("Correct");
            }
            else
            {
                ShowNotification("Wrong");
            }

            // Disable all answer buttons after selection
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            // Enable the "Submit" button
            button5.Enabled = true;
        }

        /// <summary>
        /// Displays the specified message as a notification.
        /// </summary>
        /// <param name="message">The message to display.</param>
        private void ShowNotification(string message)
        {
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Displays the question based on the question number.
        /// </summary>
        /// <param name="qnum">The question number.</param>
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.QUESRION;
                    lblQuestion.Text = "What is the color of water?";
                    button1.Text = "White";
                    button2.Text = "None";
                    button3.Text = "Red";
                    button4.Text = "Blue";
                    correctAnswer = 4;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.FRANCE;
                    lblQuestion.Text = "What is the capital of France?";
                    button1.Text = "Paris";
                    button2.Text = "Rome";
                    button3.Text = "Berlin";
                    button4.Text = "Madrid";
                    correctAnswer = 1;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.HAPPY;
                    lblQuestion.Text = "What emotion is displayed above?";
                    button1.Text = "Sad";
                    button2.Text = "Angry";
                    button3.Text = "Happy";
                    button4.Text = "Surprised";
                    correctAnswer = 3;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.PARAMOUNT;
                    lblQuestion.Text = "What production firm is shown above?";
                    button1.Text = "Paramount Pictures";
                    button2.Text = "Universal Studios";
                    button3.Text = "Warner Bros.";
                    button4.Text = "20th Century Fox";
                    correctAnswer = 1;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.PEACOCK;
                    lblQuestion.Text = "What bird is shown above?";
                    button1.Text = "Zebra";
                    button2.Text = "Lion";
                    button3.Text = "Peacock";
                    button4.Text = "Eagle";
                    correctAnswer = 3;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.DOLLARS;
                    lblQuestion.Text = "What currency is shown here?";
                    button1.Text = "US Dollars";
                    button2.Text = "British Pounds";
                    button3.Text = "Euros";
                    button4.Text = "Japanese Yen";
                    correctAnswer = 1;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.PHOTOGRAPHY;
                    lblQuestion.Text = "What profession is shown here?";
                    button1.Text = "Doctor";
                    button2.Text = "Nurse";
                    button3.Text = "Photographer";
                    button4.Text = "Chef";
                    correctAnswer = 3;
                    // Enable answer buttons
                    enableAnswerButtons();
                    break;
            }
        }

        /// <summary>
        /// Enables all answer buttons.
        /// </summary>
        private void enableAnswerButtons()
        {
            // Enable all answer buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            // Disable the "Submit" button
            button5.Enabled = false;
        }
    }
}
