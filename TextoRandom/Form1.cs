using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextoRandom
{
    public partial class Form1 : Form
    {
        public int finalSentenceWidth = 21;
        public int locationX = 0;
        private static Utils utils = new Utils();

        // We can change it to random sentence. The second node is for now.

        private static string[] sentenceSplit = utils.GetASplitedSentence(2);
        private string[] userAnswer = new string[sentenceSplit.Length];
        private int counter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] randomSentenceOrder = utils.GetRandomOrder(sentenceSplit.Length);

            locationX = labelInstructions.Location.Y;
            int locationY = labelInstructions.Location.Y;

            CreateDisorderLabels();
            CreateDisplayLabels();

            void CreateDisorderLabels()
            {
                int positionX = labelInstructions.Location.X;

                foreach (var item in randomSentenceOrder)
                {
                    Label label = new Label
                    {
                        Size = new System.Drawing.Size(1, 30),
                        Name = "label" + item,
                        Location = new System.Drawing.Point(positionX, locationY)
                    };

                    splitMain.Panel2.Controls.Add(label);

                    label.AutoSize = true;
                    label.Text = sentenceSplit[item];
                    label.BackColor = Color.LightGray;
                    label.Click += new EventHandler(ToggleLabelsWidth); //assign click handler

                    positionX += label.Width + 14;
                }
            }

            // Creating labels with size 0 in order to catch the index of both places options and answer

            void CreateDisplayLabels()
            {
                foreach (var item in randomSentenceOrder)
                {
                    Label label = new Label
                    {
                        Size = new System.Drawing.Size(1, 30),
                        Name = "label" + item + "Display",
                        Location = new System.Drawing.Point(0, locationY)
                    };

                    this.splitDisplay.Panel2.Controls.Add(label);

                    label.AutoSize = true;
                    label.Visible = false;
                    label.Text = sentenceSplit[item];
                    label.BackColor = Color.LightGray;

                    label.Click += new EventHandler(RemoveLabel); //assign click handler
                }
            }
        }

        protected void ToggleLabelsWidth(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            lbl.BackColor = Color.Gray;
           // lbl.ForeColor = Color.Gray;

            int index = splitMain.Panel2.Controls.IndexOf(lbl);

            splitDisplay.Panel2.Controls[index].Location = new System.Drawing.Point(locationX, 0);
            splitDisplay.Panel2.Controls[index].Visible = true;
            locationX += lbl.Width + 14;

            userAnswer[counter] = lbl.Text;
            counter++;

            CheckAnswer(ref userAnswer);
        }

        protected void RemoveLabel(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            locationX -= lbl.Width;
            locationX -= 14;

            lbl.Visible = false;

            int index = splitDisplay.Panel2.Controls.IndexOf(lbl);

            splitMain.Panel2.Controls[index].BackColor = Color.LightGray;
            splitMain.Panel2.Controls[index].ForeColor = Color.Black;

            counter--;
            userAnswer[counter] = String.Empty;
        }

        protected void CheckAnswer(ref string[] finalanswer)
        {
            string rightAnswer = String.Empty;
            string finalanswerString = String.Empty;

            foreach (string item in sentenceSplit)
            {
                rightAnswer += item;
            }

            foreach (string item in finalanswer)
            {
                finalanswerString += item;
            }

            if (finalanswerString == rightAnswer)
            {
                ShowWinMessage();
            }
        }

        protected void ShowWinMessage()
        {
            labelInstructions.Text = "Great Job!!";
        }
    }
}
