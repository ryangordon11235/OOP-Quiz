﻿using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace OOPQuiz.Modules.Quiz.Views
{
    /// <summary>
    /// Interaction logic for BettingPage
    /// </summary>
    public partial class BettingPage : UserControl
    {
        public BettingPage()
        {
            InitializeComponent();
        }

        private static readonly Regex _acceptableBetChars = new("\\d");

        private void BettingInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Bet entered must be less than or equal to the user's score.
            if (_acceptableBetChars.IsMatch(e.Text))
            {
                e.Handled = !(int.Parse(BettingInput.Text + e.Text) <= int.Parse(UserScore.Text.Remove(0, "Score: ".Length)));
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}