using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementQuizKuvaiev
{
    internal class Question
    {
        public string? QuestionText { get; set; }
        public string? AnswerA { get; set; }
        public string? AnswerB { get; set; }
        public string? AnswerC { get; set; }
        public string? AnswerD { get; set; }
        public int? CorrectAnswerIndex { get; set; }

        public Question(string? QuestionText, string? AnswerA, string? AnswerB, string? AnswerC, string? AnswerD, int? CorrectAnswerIndex)
        {
            this.QuestionText = QuestionText;
            this.AnswerA = AnswerA;
            this.AnswerB = AnswerB;
            this.AnswerC = AnswerC;
            this.AnswerD = AnswerD;
            this.CorrectAnswerIndex = CorrectAnswerIndex;
        }
    }
}
