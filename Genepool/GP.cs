using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genepool
{
    public class Individual
    {
        public List<double> genes = new List<double>();

        public double? score;

        static Random r = new Random();

        public Individual(int length)
        {
            for (int i = 0; i < length; i++)
            {
                genes.Add((r.NextDouble() * 2) - 1);
            }
        }

        public Individual(List<double> _genes)
        {
            genes = _genes;
        }
    }

    public class GP
    {
        List<Individual> pool = new List<Individual>();

        static Random r = new Random();

        int index = 0;
        int indexBest = 0;

        double muteRate = 0.1;
        double crossoverRate = 0.5;

        public GP(int size, int length)
        {
            for (int i = 0; i < size; i++)
            {
                pool.Add(new Individual(length));
            }
        }

        public Individual getIndividual()
        {
            index++;
            index %= pool.Count;
            return pool[index];
        }

        public void AddIndividual(Individual individual)
        {
            index++;
            index %= pool.Count;

            pool[index] = individual;
        }

        public Individual SexyTime(Individual a, Individual b)
        {
            List<double> c = new List<double>();

            bool ab = true;

            for (int i = 0; i < a.genes.Count; i++)
            {
                if (ab)
                    c.Add(a.genes[i]);
                else
                    c.Add(b.genes[i]);

                if (r.NextDouble() < crossoverRate)
                    ab = !ab;
            }

            return new Individual(c);
        }

        public Individual SexyTime(Individual a)
        {
            Individual b = pool[(int)(r.NextDouble() * pool.Count)];

            List<double> c = new List<double>();

            bool ab = true;

            for (int i = 0; i < a.genes.Count; i++)
            {
                if (ab)
                    c.Add(a.genes[i]);
                else
                    c.Add(b.genes[i]);

                if (r.NextDouble() < crossoverRate)
                    ab = !ab;
            }

            return new Individual(c);
        }

        public void SexyTime()
        {
            Individual a = pool[indexBest];
            for (int i = 0; i < pool.Count; i++)
            {
                AddIndividual(SexyTime(a));
            }
        }

        public Individual Mutate(Individual mutee, double magnitude)
        {
            int loci = (int)(r.NextDouble() * mutee.genes.Count);

            mutee.genes[loci] += (r.NextDouble() * magnitude) - (magnitude/2);

            if ((mutee.genes[loci] > 1) || (mutee.genes[loci] < -1))
                mutee.genes[loci] = ((r.NextDouble()*2) -1);

            return mutee;
        }

        public void SolarFlare(double magnitude)
        {
            for (int i = 0; i < pool.Count; i++)
            {
                Mutate(pool[i], magnitude);
            }
        }

        public double? BestScore()
        {
            double? best = 9999999999;
            for (int i = 0; i < pool.Count; i++)
            {
                if (pool[i].score < best)
                {
                    best = pool[i].score;
                    indexBest = i;
                }
            }

            return best;
        }

        public double[] IndividualToDoubles(int i)
        {
            return pool[i].genes.ToArray();
        }

        public double[] GetBestDoubes()
        {
            return pool[indexBest].genes.ToArray();
        }

        public void SetIndividualScore(int i, double? score)
        {
            pool[i].score = score;
        }
    }
}
