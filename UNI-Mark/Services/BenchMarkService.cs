using System.ComponentModel;
using System.Diagnostics;

namespace UNI_Mark.Services
{
    public class BenchMarkService
    {
        private readonly Stopwatch _stopwatch;
        private BackgroundWorker _backgroundWorker;

        public TimeSpan Elapsed { get; private set; }
        public double Performance { get; private set; }
        public double Score { get; private set; }
        private readonly int[] _array;

        public BenchMarkService(int[] Array, BackgroundWorker backgroundWorker)
        {
            _stopwatch = new Stopwatch();
            _array = Array;
            _backgroundWorker = backgroundWorker;
        }

        public void Play(object sender, DoWorkEventArgs e)
        {
            _stopwatch.Reset();
            _stopwatch.Start();

            SelectionSort(_array, e);

            _stopwatch.Stop();
            Elapsed = _stopwatch.Elapsed;
            Score = _array.Length / Elapsed.TotalSeconds * 1_000;
            Performance = 1 / Elapsed.TotalSeconds;
            e.Result = "Tarea completada";
        }

        private void SelectionSort(int[] arr, DoWorkEventArgs e)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (_backgroundWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                    int progress = (count + 1) * 100 / (arr.Length * (arr.Length - 1) / 2);
                    _backgroundWorker.ReportProgress(progress);
                    count++;
                }

                if (minIndex != i)
                {
                    (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
                }
            }
        }
    }
}
