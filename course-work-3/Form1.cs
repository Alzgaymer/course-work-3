using System;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace course_work_3
{
    public partial class Form1 : Form
    {
        static System.Timers.Timer _timer;
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
            pCPU.Value = cpu;
            pMemory.Value = memory;
            
            ProgressBarInvoke(pCPU, cpu);
            ProgressBarInvoke(pMemory, memory);

            ChartInvoke(chart1, "CPU", cpu);
            ChartInvoke(chart1, "Memory", memory);
            
        }
        void ChartInvoke(Chart c, string category, int value)
        {
            if (chart1.InvokeRequired) chart1.Invoke(new Action(() => c.Series[category].Points.AddY(value)));
            else c.Series[category].Points.AddY(value);
        }
        void ProgressBarInvoke(ProgressBar p, int value)
        {
            if (p.InvokeRequired) p.Invoke(new Action(() => p.Value = value));
            else p.Value = value;
        }
        private static int GetCpuValue()
        {
            var cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpu.NextValue();
            System.Threading.Thread.Sleep(1000);
            return (int)cpu.NextValue(); 
        }
        private static int GetMemValue()
        {
            var memory = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            memory.NextValue();
            
            return (int)memory.NextValue(); 
        }
    }
}
