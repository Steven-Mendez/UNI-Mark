using System.Management;

namespace UNI_Mark.Services
{
    public class CPUService
    {
        public string? OSVersion { get; }
        public string? Version { get; }
        public string? ProcessorArchitecture { get; }
        public string? ProcessorName { get; }
        public string? ProcessorMaxClockSpeed { get; }
        public string? ComputerSystemTotalPhysicalMemory { get; }
        public string? LogicalDiskDescription { get; }
        public string? LogicalDiskFreeSpace { get; }
        public List<(string, string)> PhysicalMemory { get; set; } = new List<(string, string)> ();

        public CPUService()
        {
            ManagementObjectSearcher searcher;
            OSVersion = Environment.OSVersion.ToString();
            Version = Environment.Version.ToString();
            ProcessorArchitecture = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")!;

            searcher = new("SELECT * FROM Win32_Processor");
            foreach (var queryObj in searcher.Get().Cast<ManagementObject>())
            {
                ProcessorName = queryObj["Name"].ToString();
                ProcessorMaxClockSpeed = queryObj["MaxClockSpeed"].ToString();
            }

            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (var queryObj in searcher.Get().Cast<ManagementObject>())
            {
                ComputerSystemTotalPhysicalMemory = queryObj["TotalPhysicalMemory"].ToString();
            }

            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID='C:'");
            foreach (var queryObj in searcher.Get().Cast<ManagementObject>())
            {
                LogicalDiskDescription = queryObj["Description"].ToString();
                LogicalDiskFreeSpace = Math.Round(Convert.ToDouble(queryObj["FreeSpace"]) / (1024 * 1024 * 1024), 2).ToString();
            }

            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (var obj in searcher.Get().Cast<ManagementObject>())
            {
                var capity = Math.Round(Convert.ToDouble(obj["Capacity"]) / (1024 * 1024 * 1024), 2).ToString();
                var speed = obj["Speed"].ToString();
                var physicalMemory = (capity, speed);
                PhysicalMemory.Add(physicalMemory!);
            }
        }
    }
}
