using System;
using System.Linq;
using System.Windows.Forms;

namespace TextoRandom
{
    public sealed class Utils
    {
        public string[] Sentences =
        {
            "There is a class called 'Filosofia de Mises'",
            "John does not work at a hospital",
            "Now the variable can be used",
            "The party is over"
        };

        public string GetASentence(int index)
        {
            if (index < Sentences.Length + 1)
            {
                return Sentences[index];
            }

            throw new IndexOutOfRangeException("Index exceeds the sentences available");
        }

        public string[] GetASplitedSentence(int index)
        {
            if (index < Sentences.Length)
            {
                return Sentences[index].Split();
            }

            throw new IndexOutOfRangeException("Index exceeds the sentences available");
        }

        public int[] GetRandomOrder(int maxIndex)
        {
            var random = new Random();
            int index = random.Next(maxIndex);

            int[] array = new int[maxIndex];
            int[] disorder = new int[maxIndex];

            for (int i = 0; i < disorder.Length; i++)
            {
                AsignIndex(i, index, maxIndex);
            }

            void AsignIndex(int j, int ind, int max)
            {
                if (disorder.Contains(ind))
                {
                    int newIndex = random.Next(max);

                    AsignIndex(j, newIndex, max);
                }

                else
                {
                    if (j != 0)
                    {
                        disorder[j] = ind;
                    }
                }
            }

            return disorder;
        }
    }
}
