using System;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using System.Management;

namespace course_work_3
{
    enum State
    {
        CPU,MEMORY,GPU
    }
    
    public partial class Form1 : Form
    {
        private State state;
        static System.Timers.Timer _timer;
        static readonly PerformanceCounter memory = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        static readonly PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        static readonly PerformanceCounter gpu = new PerformanceCounter("GPU Local Adapter Memory", "Local Usage", "luid_0x00000000_0x0000F973_phys_0");
        static readonly ManagementObjectSearcher searcherCPU = new ManagementObjectSearcher("select * from win32_processor");
        static readonly ManagementObjectSearcher searcherMemory = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
        static readonly ManagementObjectSearcher searcherGPU = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
        public Form1()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += OnTimeEvent;
            CheckForIllegalCrossThreadCalls = false;
            _timer.Start();          
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            int cpu = GetCpuValue();
            int memory = GetMemValue();
            int gpu = GetGpuMemValue() / 20000000;
;
            ManagementObjectCollection objects = null;
            switch (state)
            {
                case State.CPU:
                    objects = searcherCPU.Get();
                    foreach (var item in objects)
                    {
                        lName.Text = item.GetPropertyValue("Name").ToString();
                        lClock.Text = "Maximum clock speed: " + item.GetPropertyValue("MaxClockSpeed").ToString() + " MHz";
                        lAmount.Text = "Total cores/threads: " + item.GetPropertyValue("NumberOfCores").ToString()+ "/" +item.GetPropertyValue("ThreadCount").ToString();
                        lCache.Text = "L2 cache size: " + int.Parse(item.GetPropertyValue("L2CacheSize").ToString())/1000 + " Mbytes";
                        lCache.Text += "\nL3 cache size: " + int.Parse(item.GetPropertyValue("L3CacheSize").ToString()) / 1000 + " Mbytes";
                    }
                    
                    ProgressBarInvoke(pbar, cpu);
                    LabelInvoke(lCPU, $"{cpu}%");
                    break;
                case State.MEMORY:
                    objects = searcherMemory.Get();
                    long amount = 0;
                    foreach (var item in objects)
                    {
                        lName.Text = item.GetPropertyValue("Manufacturer").ToString();
                        lClock.Text = "Current clock speed: " + item.GetPropertyValue("ConfiguredClockSpeed").ToString() + " MHz";
                        amount += long.Parse(item.GetPropertyValue("Capacity").ToString());
                    }
                    lAmount.Text = "Total: " + String.Format($"{(amount / 1000000000).ToString():F4}") + "GB";
                    lCache.Text = "";
                    ProgressBarInvoke(pbar, memory);
                    LabelInvoke(lCPU, $"{memory}%");
                    break;
                case State.GPU:
                    objects = searcherGPU.Get();
                    foreach (var item in objects)
                    {
                        lName.Text = item.GetPropertyValue("Name").ToString();
                        lClock.Text = "Video Processor: " + item.GetPropertyValue("VideoProcessor");
                        lAmount.Text = "Total Adapter RAM: " + long.Parse(item.GetPropertyValue("AdapterRAM").ToString())/1000000000 + " GB";                        
                    }
                    lCache.Text = "";
                   

                    ProgressBarInvoke(pbar, gpu);
                    LabelInvoke(lCPU, $"{gpu}%");
                    break;
                default:
                    break;
            }
        }
        void LabelInvoke(Label l, string value)
        {
            if (l.InvokeRequired) l.Invoke(new Action(() => l.Text = value));
            else l.Text = value;
        }
        void ProgressBarInvoke(ProgressBar p, int value)
        {
            if (p.InvokeRequired) p.Invoke(new Action(() => p.Value = value));
            else p.Value = value;
        }
        private static int GetCpuValue()
        {            
            cpu.NextValue();
            System.Threading.Thread.Sleep(1000);
            return (int)cpu.NextValue(); 
        }
        private static int GetMemValue()
        {            
            memory.NextValue();            
            return (int)memory.NextValue(); 
        }
        private static int GetGpuMemValue()
        {            
            gpu.NextValue();            
            return (int)gpu.NextValue(); 
        }
        private void btCPU_Click(object sender, EventArgs e)
        {
            state = State.CPU;
        }
        private void btMemory_Click(object sender, EventArgs e)
        {
            state = State.MEMORY;
        }
        private void btGPU_Click(object sender, EventArgs e)
        {
            state = State.GPU;
        }
    }
}
