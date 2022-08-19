﻿namespace OOPQuiz.Business.Tests.Models
{
    public class OpenEndedQuestionTests
    {
        [Theory]
        [InlineData("Lorem ipsum dolor sit amet?", "Lorem ipsum dolor sit amet?")]
        public void TestQuestion(string expected, string input)
        {
            // Should be the same as what was specified upon instantiation.
            var openEndedQuestion = new OpenEndedQuestion(input, "", "");

            var actual = openEndedQuestion.Question;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Answer", "Answer")]
        public void TestAnswer(string expected, string input)
        {
            // Should be the same as what was specified upon instantiation.
            var openEndedQuestion = new OpenEndedQuestion("", input, "");

            var actual = openEndedQuestion.Answer;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"test\uri\image.png", @"test\uri\image.png")]
        public void TestImageURI(string expected, string input)
        {
            // Should be the same as what was specified upon instantiation.
            var openEndedQuestion = new OpenEndedQuestion("", "", input);

            var actual = openEndedQuestion.ImageURI;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestFeedbackDefaultBehaviour()
        {
            // Should return an empty string.
            var openEndedQuestion = new OpenEndedQuestion("", "", "");

            var actual = openEndedQuestion.Feedback;

            Assert.Equal(string.Empty, actual);
        }

        [Theory]
        [InlineData("Feedback", "Feedback")]
        public void TestFeedbackSetUponInstantiation(string expected, string input)
        {
            // Should be the same as what was specified upon instantiation.
            var openEndedQuestion = new OpenEndedQuestion("", "", "", input);

            var actual = openEndedQuestion.Feedback;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChoices()
        {
            // Should always return an empty dictionary.
            var openEndedQuestion = new OpenEndedQuestion("", "", "");

            var actual = openEndedQuestion.ChoicesWithFeedback;

            Assert.Empty(actual);
            Assert.IsType<Dictionary<string, string>>(actual);
        }
    }
}
