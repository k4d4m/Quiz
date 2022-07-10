using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Security.Cryptography;
using System.Media;

namespace Quiz
{
    public partial class FormQuiz : Form
    {
        public List<QuestionWithAnswers>[] questions { get; set; } = new List<QuestionWithAnswers>[10];
        public string[] filePaths { get; set; } = new string[10];
        public int currentQuestionNo { get; set; } = 0;
        public int currentTopic { get; set; } = 0;
        public int delay { get; set; } = 3000;
        public bool questionsSelected = false;
        public enum enumGameState { nextQuestion, revealAnswer };
        public enumGameState gameState = enumGameState.nextQuestion;
        public SoundPlayer soundPlayer = new SoundPlayer();

        public FormQuiz()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnGame.Location = new Point(
            ClientSize.Width / 2 - pnGame.Size.Width / 2,
            ClientSize.Height / 2 - pnGame.Size.Height / 2);

            pnMenu.Location = new Point(
                Width / 2 - pnMenu.Size.Width / 2,
                Height / 2 - pnMenu.Size.Height / 2);

            if (trySetBackgroundImage("bg.jpg")) { }
            else
            {
                if (trySetBackgroundImage("bg.jpeg")) { }
                else
                {
                    trySetBackgroundImage("bg.png");
                }
            }
        }

        private bool trySetBackgroundImage(string fileName)
        {
            string bgPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quiz");
            bgPath = bgPath.Replace(@"\\\\", @"\\");
            if (Directory.Exists(bgPath))
            {
                bgPath = Path.Combine(bgPath, fileName);
                bgPath = bgPath.Replace(@"\\\\", @"\\");
                if (File.Exists(bgPath))
                {
                    var image = new Bitmap(bgPath);
                    this.BackgroundImage = image;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    return true;
                }
                else return false;
            }
            else
            {
                Directory.CreateDirectory(bgPath);
                return false;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            CheckAnswer('A');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CheckAnswer('B');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CheckAnswer('C');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CheckAnswer('D');
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            soundPlayer.Stream = Properties.Resources.pop;
            soundPlayer.Play();

            if (!questionsSelected)
            {
                resetGame();
                btnSelectQuestions_Click(sender, e);
            }
            if (questionsSelected)
            {
                LoadAllQuestions(filePaths);
                LoadNextQuestion();

                pnMenu.Hide();
                pnGame.Show();
            }
        }

        private void LoadAllQuestions(string[] filePaths)
        {
            //CurrentPlayer = 0;
            questions = new List<QuestionWithAnswers>[10];
            for (int i = 0; i < numTopic.Value; i++)
            {
                if (filePaths[i] != null && filePaths[i] != String.Empty)
                {
                    var streamReader = File.OpenText(filePaths[i]);

                    File.OpenText(filePaths[i]);

                    var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

                    var questions = csvReader.GetRecords<QuestionWithAnswers>();

                    this.questions[i] = new List<QuestionWithAnswers>();

                    foreach (var question in questions)
                    {
                        this.questions[i].Add(question);
                    }
                    Shuffle(this.questions[i]);
                }
            }
        }

        private void LoadNextQuestion()
        {
            lbTopic.Text = filePaths[currentTopic].Split('\\').Last().Substring(0, filePaths[currentTopic].Split('\\').Last().Length - 4);
            lbTopic.Refresh();

            lbQuestion.Text = (currentQuestionNo + 1).ToString() + ".) " + questions[currentTopic][currentQuestionNo].Question;
            lbQuestion.Refresh();

            btnA.Text = questions[currentTopic][currentQuestionNo].A;

            btnB.Text = questions[currentTopic][currentQuestionNo].B;

            btnC.Text = questions[currentTopic][currentQuestionNo].C;

            btnD.Text = questions[currentTopic][currentQuestionNo].D;
        }

        private void CheckAnswer(char userInput)
        {
            soundPlayer.Stream = Properties.Resources.pop;
            soundPlayer.Play();
            colorAnswer(userInput, Color.Orange);
            System.Threading.Thread.Sleep(delay);
            bool fail = false;

            if (questions[currentTopic][currentQuestionNo].Right == userInput)
            {
                soundPlayer.Stream = Properties.Resources.win;
                soundPlayer.Play();
                colorAnswer(userInput, Color.Green);
                System.Threading.Thread.Sleep(delay);
                colorAnswer(userInput, Color.White);
            }
            else
            {

                soundPlayer.Stream = null;
                soundPlayer.Stream = Properties.Resources.fail;
                soundPlayer.Play();
                fail = true;
                colorAnswer(userInput, Color.Red);
                colorAnswer(questions[currentTopic][currentQuestionNo].Right, Color.Green);
                System.Threading.Thread.Sleep(delay);
                colorAnswer(userInput, Color.White);
                colorAnswer(questions[currentTopic][currentQuestionNo].Right, Color.White);
            }

            currentTopic++;
            if (currentTopic >= numTopic.Value)
            {
                currentTopic = 0;
            }

            if (currentQuestionNo < questions[currentTopic].Count - 1 && !fail)
            {
                currentQuestionNo++;
                LoadNextQuestion();
            }
            else
            {
                resetGame();
            }
        }
        private void resetGame()
        {
            questionsSelected = false;
            currentTopic = 0;
            currentQuestionNo = 0;
            questions = new List<QuestionWithAnswers>[10];
            filePaths = new string[10];
            pnGame.Hide();
            pnMenu.Show();
        }
        private void colorAnswer(char option, Color color)
        {
            switch (option)
            {
                case 'A':
                    btnA.BackColor = color;
                    btnA.Refresh();
                    break;
                case 'B':
                    btnB.BackColor = color;
                    btnB.Refresh();
                    break;
                case 'C':
                    btnC.BackColor = color;
                    btnC.Refresh();
                    break;
                case 'D':
                    btnD.BackColor = color;
                    btnD.Refresh();
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectQuestions_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numTopic.Value; i++)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePaths[i] = openFileDialog1.FileName;
                    if (i == 0 && !questionsSelected)
                    {
                        questionsSelected = true;
                    }
                }
                else
                {
                    questionsSelected = false;
                }
            }
        }

        public void Shuffle<QuestionsWithAnswers>(IList<QuestionsWithAnswers> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                QuestionsWithAnswers value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void numTopic_ValueChanged(object sender, EventArgs e)
        {
            resetGame();
        }
    }

    public class QuestionWithAnswers
    {
        public string Question { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public char Right { get; set; }
    }
}

