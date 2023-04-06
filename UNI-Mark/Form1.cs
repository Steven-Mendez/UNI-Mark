using System.ComponentModel;
using System.Diagnostics;
using UNI_Mark.Services;

namespace UNI_Mark
{
    public partial class Form1 : Form
    {
        private CPUService _cpuService { get; set; }
        private BenchMarkService? _benchMarkService { get; set; }

        public Form1()
        {
            InitializeComponent();
            _cpuService = new CPUService();
            _benchMarkService = null;

            BackgroundWorker = new BackgroundWorker();
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.WorkerSupportsCancellation = true;
            BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged!);
            BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Completed!);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Operative System
            OSName.Text += _cpuService.OSVersion;
            OSVersion.Text += _cpuService.Version;

            // Processor
            ProcessorModel.Text += _cpuService.ProcessorName;
            ProcessorArchitecture.Text += _cpuService.ProcessorArchitecture;
            ProcessorSpeed.Text += $"{_cpuService.ProcessorMaxClockSpeed} Mhz";

            // Disk
            DiskType.Text += _cpuService.LogicalDiskDescription;
            DiskFreeSpace.Text += $"{_cpuService.LogicalDiskFreeSpace} GB";

            // RAM
            var length = _cpuService.PhysicalMemory.Count;

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    RAMCapacity.Text += $"{_cpuService.PhysicalMemory.ElementAt(i).Item1} GB ";
                    RAMSpeed.Text += $"{_cpuService.PhysicalMemory.ElementAt(i).Item2} Mhz ";
                }
                else
                {
                    RAMCapacity.Text += $"+ {_cpuService.PhysicalMemory.ElementAt(i).Item1} GB";
                    RAMSpeed.Text += $"+ {_cpuService.PhysicalMemory.ElementAt(i).Item2} Mhz";
                }
            }
        }

        private void StartBenchmark_Click(object sender, EventArgs e)
        {
            Cancel.Enabled = true;
            int[] arr = new int[1_500];
            var rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10000);
            }

            _benchMarkService = new BenchMarkService(arr, BackgroundWorker);
            BackgroundWorker.DoWork += new DoWorkEventHandler(_benchMarkService.Play!);
            BackgroundWorker.RunWorkerAsync();
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Tarea cancelada");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                var message = new
                {
                    Caption = "Resultado",
                    Text = "El benchmarck finalizó con exito"
                };

                Cancel.Enabled = false;

                MessageBox.Show(message.Text, message.Caption);

                Score.Text = $"Puntuación: {_benchMarkService!.Score: #,##0.00}pp";
                Performance.Text = $"Rendimiento: {_benchMarkService.Performance: #,##0.00}";
                Elapsed.Text = $"Tiempo Transcurrido: {_benchMarkService.Elapsed}";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (BackgroundWorker.WorkerSupportsCancellation == true)
            {
                BackgroundWorker.CancelAsync();
            }
        }
    }
}
