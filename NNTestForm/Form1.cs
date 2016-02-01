using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuralNetwork;
using Genepool;

namespace NNTestForm
{
    public partial class Form1 : Form
    {
        NN nn;

        GP pool;

        int poolSize = 1000;
                
        double[,] bits = new double[4, 2];

        public Form1()
        {            
            InitializeComponent();

            nn = new NN(2, 1, 1, 4, 1);
            pool = new GP(poolSize, nn.weightCount());
            
            for (byte b = 0; b < 4; b++)
            {
                bits[b, 0] = GetBit(b, 0) ? 1 : -1;
                bits[b, 1] = GetBit(b, 1) ? 1 : -1;
            }
        }

        public static bool GetBit(byte b, int bitIndex)
        {
            return (b & (1 << bitIndex)) != 0;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            double totalError = 0;

            chart1.Series[0].Points.Clear();
            int count = 0;
            
            double[] input = new double[2];

            while (count < 10000)
            {
                input[0] = bits[count % 4, 0];
                input[1] = bits[count % 4, 1];

                double xor = (input[0] > 0 ^ input[1] > 0) ? 1 : 0;

                double[] answer = nn.FeedForward(input);

                double[] err = { xor - answer[0] };

                totalError += Math.Abs(err[0]);

                nn.BackProp(err);

                chart1.Series[0].Points.Add(err[0]);

                count++;
            }

            labelTotalError.Text = totalError.ToString("#.##");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            nn = new NN(2, 1, 1, 4, 1);
            pool = new GP(poolSize, nn.weightCount());
        }

        private void buttonGenetic_Click(object sender, EventArgs e)
        {
            double[] input = new double[2];
            int count;

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < poolSize; i++)
            {
                nn.SetWeights(pool.IndividualToDoubles(i));

                count = 0;

                double totalError = 0;

                while (count < 4)
                {
                    input[0] = bits[count % 4, 0];
                    input[1] = bits[count % 4, 1];

                    double xor = (input[0] > 0 ^ input[1] > 0) ? 1 : 0;

                    double[] answer = nn.FeedForward(input);

                    double[] err = { xor - answer[0] };

                    totalError += Math.Abs(err[0]);
                    
                    count++;
                }
                pool.SetIndividualScore(i, totalError);
                chart1.Series[0].Points.Add(totalError);
            }

            labelTotalError.Text = pool.BestScore().ToString();
        }

        private void buttonSexyTime_Click(object sender, EventArgs e)
        {
            pool.SexyTime();
        }
    }
}
