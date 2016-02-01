using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NeuralNetwork;

namespace NNTest
{
    class Program
    {
        static NN nn;

        static void Main(string[] args)
        {
            nn = new NN(2, 1, 1, 4, 1);

            int count = 0;

            double[,] bits = new double[4, 2];
            for (byte b = 0; b < 4; b++)
            {
                bits[b, 0] = GetBit(b, 0) ? 1 : -1;
                bits[b, 1] = GetBit(b, 1) ? 1 : -1;
            }
                        
            double[] input = new double[2];
            
            while (count < 10000)
            {
                input[0] = bits[count%4, 0];
                input[1] = bits[count%4, 1];
                                
                double xor = (input[0] > 0 ^ input[1] > 0) ? 1 : 0;

                double[] answer = nn.FeedForward(input);

                double[] err = { xor - answer[0] };

                nn.BackProp(err);

                Console.WriteLine(xor + "\t" + answer[0].ToString("#.###") + "\t" + err[0].ToString("#.###"));

                count++;
            }
            
            Console.ReadKey();
        }

        public static bool GetBit(byte b, int bitIndex)
        {
            return (b & (1 << bitIndex)) != 0;
        }
    }
}
