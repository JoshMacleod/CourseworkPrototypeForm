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
using Shooter;

namespace FormPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test = new PointTest();
        }

        public int i = 0;

        private PointTest test;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            InputInitialValues();
        }

        private double initialHeight;

        public double InitialHeight
        {
            get { return initialHeight; }
            set { initialHeight = value; }
        }

        private double initialVelocity;

        public double InitialVelocity
        {
            get { return initialVelocity; }
            set { initialVelocity = value; }
        }

        private double initialAngle;

        public double InitialAngle
        {
            get { return initialAngle; }
            set { initialAngle = value; }
        }

        public void InputInitialValues()
        {
            InitialHeight = double.Parse(txtInitialHeight.Text);

            InitialVelocity = double.Parse(txtInitialVelocity.Text);

            InitialAngle = double.Parse(txtInitialAngle.Text);

            double verticalVelocity = VerticalVelocity(InitialVelocity, InitialAngle);
            txtVerticalVelocity.Text = System.Math.Round(verticalVelocity, 2).ToString();

            double horizontalVelocity = HorizontalVelocity(InitialVelocity, InitialAngle);
            txtHorizontalVelocity.Text = System.Math.Round(horizontalVelocity, 2).ToString();

            double timeToPeak = TimeToPeak(verticalVelocity);
            txtTimeToPeak.Text = System.Math.Round(timeToPeak, 2).ToString();

            double distanceToPeak = DistanceToPeak(verticalVelocity, timeToPeak);
            txtDistanceToPeak.Text = System.Math.Round(distanceToPeak, 2).ToString();

            double totalVerticalDistance = TotalVerticalDistance(initialHeight, distanceToPeak);
            txtTotalVerticalDistance.Text = System.Math.Round(totalVerticalDistance, 2).ToString();

            double timeToGround = TimeToGround(totalVerticalDistance);
            txtTimeToGround.Text = System.Math.Round(timeToGround, 2).ToString();

            double totalTime = TotalTime(timeToPeak, timeToGround);
            txtTotalTime.Text = System.Math.Round(totalTime, 2).ToString();

            double totalHorizontalDistance = TotalHorizontalDistance(horizontalVelocity, totalTime);
            txtTotalHorizontalDistance.Text = System.Math.Round(totalHorizontalDistance, 2).ToString();

            for (double i = 0; i <= totalTime; i += 0.01)
            {
                double x = GetXCoordinate(horizontalVelocity, i);
                double y = GetYCoordinate(verticalVelocity, i);
                saveToFileX(x);
                saveToFileY(y);
            }
        }

        public double VerticalVelocity(double initialVelocity, double initialAngle)
        {
            initialAngle = initialAngle * (Math.PI / 180);
            double verticalVelocity = initialVelocity * System.Math.Sin((Double)initialAngle);
            return verticalVelocity;
        }

        public double HorizontalVelocity(double initialVelocity, double initialAngle)
        {
            initialAngle = initialAngle * (Math.PI / 180);
            double horizontalVelocity = initialVelocity * System.Math.Cos((Double)initialAngle);
            return horizontalVelocity;
        }

        public double TimeToPeak(double verticalVelocity)
        {
            double timeToPeak = verticalVelocity / 9.81; // t = u / g
            return timeToPeak;
        }

        public double DistanceToPeak(double verticalVelocity, double timeToPeak)
        {
            double distanceToPeak = (verticalVelocity * timeToPeak) - (0.5 * 9.81 * System.Math.Pow(timeToPeak, 2)); // s = ut + 0.5at^2
            return distanceToPeak;
        }

        public double TotalVerticalDistance(double initialHeight, double distanceToPeak)
        {
            double totalVerticalDistance = initialHeight + distanceToPeak;
            return totalVerticalDistance;
        }

        public double TimeToGround(double totalVerticalDistance)
        {
            double timeToGround = System.Math.Sqrt((2 * totalVerticalDistance) / 9.81);
            return timeToGround;
        }

        public double TotalTime(double timeToPeak, double timeToGround)
        {
            double totalTime = timeToPeak + timeToGround;
            return totalTime;
        }

        public double TotalHorizontalDistance(double horizontalVelocity, double totalTime)
        {
            double totalHorizontalDistance = horizontalVelocity * totalTime;
            return totalHorizontalDistance;
        }

        public double GetXCoordinate(double horizontalVelocity, double time)
        {
            double xCoordinate = horizontalVelocity * time;
            return xCoordinate;
        }

        public double GetYCoordinate(double verticalVelocity, double time)
        {
            double yCoordinate = (verticalVelocity * time) - (0.5 * 9.81 * System.Math.Pow(time, 2));
            return yCoordinate;
        }

        public void saveToFileX(double x)
        {
            StreamWriter file = new StreamWriter("H:\\Computing Coursework\\Code\\FormPrototype\\testX.txt", true);
            file.WriteLine(x);
            file.Close();
        }

        public void saveToFileY(double y)
        {
            StreamWriter file = new StreamWriter("H:\\Computing Coursework\\Code\\FormPrototype\\testY.txt", true);
            file.WriteLine(y);
            file.Close();
        }

        private void btnPlotGraph_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = double.Parse(txtTotalHorizontalDistance.Text);
            chart1.ChartAreas[0].AxisY.Minimum = 0 - double.Parse(txtInitialHeight.Text);
            chart1.ChartAreas[0].AxisY.Maximum = double.Parse(txtTotalVerticalDistance.Text);
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] xStringCoordinates = File.ReadAllLines("H:\\Computing Coursework\\Code\\FormPrototype\\testX.txt");
            double[] xCoordinates = xStringCoordinates.Select(x => Convert.ToDouble(x)).ToArray();

            string[] yStringCoordinates = File.ReadAllLines("H:\\Computing Coursework\\Code\\FormPrototype\\testY.txt");
            double[] yCoordinates = yStringCoordinates.Select(y => Convert.ToDouble(y)).ToArray();

            chart1.Series["Projectile1"].Points.AddXY(xCoordinates[i], yCoordinates[i]);

            test.Update((int)xCoordinates[i], -(int)yCoordinates[i]);

            if (i >= xCoordinates.Length - 1)
            {
                timer1.Stop();
            }
            else
            {
                i++;
            }
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            test.DrawImage(dc);
            base.OnPaint(e);
        }
    }
}