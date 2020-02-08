using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextoRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils utils = new Utils();
            string[] sentenceSplit = utils.GetASplitedSentence(1);
            int[] randomSentenceOrder = utils.GetRandomOrder(sentenceSplit.Length);
            int[] positionsX = new int[sentenceSplit.Length];
            int i = 0;

            labelDisorder.Text = "";

            int locationX = labelDisorder.Location.X;
            int locationY = labelDisorder.Location.Y;

            foreach (var item in randomSentenceOrder)
            {
                Label label = new Label();
                label.Size = new System.Drawing.Size(1, 30);
                label.Name = "label" + item;
                label.Location = new System.Drawing.Point(locationX, locationY);

                positionsX[i] = locationX;
                i++;

                this.Controls.Add(label);
                label.AutoSize = true;
                label.Text = sentenceSplit[item];
                locationX += label.Width + 14;
                label.BackColor = Color.LightGray;
                label.Click += new EventHandler(MoveLabel); //assign click handler
            }
        }

        protected void MoveLabel(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            Label lbl = sender as Label;

            lbl.BackColor = Color.Red;


            int locationX = labelInstructions.Location.X;
            int locationY = labelInstructions.Location.Y + 10;

            lbl.Location = new System.Drawing.Point(locationX, locationY);

        }
    }
}
