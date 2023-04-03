using System.Diagnostics;

namespace UNI_Mark.Services
{
    public class BenchMark
    {
        private readonly Stopwatch _stopwatch;

        public TimeSpan Elapsed { get; private set; }
        public double Performance { get; private set; }
        public double Punctuation { get; private set; }

        public BenchMark()
        {
            _stopwatch = new Stopwatch();
        }

        public void Play(int[] array)
        {
            _stopwatch.Start();

            SelectionSort(array);

            _stopwatch.Stop();
            Elapsed = _stopwatch.Elapsed;
            Punctuation = array.Length / Elapsed.TotalMilliseconds;
            Performance = 1 / Elapsed.TotalSeconds;
        }

        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
                }
            }
        }
    }
}
