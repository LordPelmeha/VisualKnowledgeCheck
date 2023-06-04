using Homework10;
using System;
namespace VisualGeometrySimulator
{
    public partial class Form1 : Form
    {
        private TestGenerator _generator { get; set; }
        private List<string> Questions { get; set; }
        private int correctAnswers { get; set; }
        private int wrongAnswers { get; set; }
        private string GoodAnswer { get; set; }
        public Form1()
        {
            InitializeComponent();
            _generator = new TestGenerator();
            Questions = _generator.Shuffle(File.ReadAllLines("questions.txt").ToList());

            correctAnswers = 0;
            wrongAnswers = 0;
            GoodAnswer = Questions[0].Split('|')[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Questions.Count > 0)
            {
                var x = Questions.First().Split('|');
                lblText.Text = Questions.First().ToString();
                btnClickThis.Text = Questions.Count > 1 ? "Следующий вопрос" : "Завершить тест";

                if (GoodAnswer == AnswerBox.Text )
                {
                    correctAnswers++;
                    CorrectOrIncorrectButton.Text = $"Верно! {correctAnswers} {wrongAnswers}    {GoodAnswer} {AnswerBox.Text}";

                }

                else
                {
                    wrongAnswers++;
                    CorrectOrIncorrectButton.Text = $"Неверно! {correctAnswers} {wrongAnswers}";
                }
                AnswerBox.Clear();
                GoodAnswer = x[1].ToString();
                Questions = Questions.Skip(1).ToList();

            }
            else
                ResultBox.Text = $"{correctAnswers} {wrongAnswers}";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}