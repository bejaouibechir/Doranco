using System.Data.SqlClient;
using System.Diagnostics;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {

        int _Delay;
        bool _Stopped;
        ManualResetEvent _ResetEvent;
        public Worker()
        {
            _Delay = 10000;
            _Stopped = false;
            _ResetEvent = new ManualResetEvent(false);
        }

        public bool Stopped
        {
            get
            { lock (_ThreadLock) { return _Stopped; } }
            set
            {
                lock (_ThreadLock)
                {
                    _Stopped = value;
                    _ResetEvent.Set();
                }
            }
        }

        public int Delay
        {
            get { lock (_ThreadLock) { return _Delay; } }
            set
            {
                lock (_ThreadLock) { _Delay = value; }
            }
        }


        private readonly object _ThreadLock = new object();
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                DateTime date = DateTime.Now;
                while (Stopped==false)
                {
                    if (_ResetEvent.WaitOne(Delay))
                    {
                        SqlConnection connection = new SqlConnection("Data Source=PC2022;Initial Catalog=tempdb;Integrated Security=true");

                        try
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("TRUNCATE TABLE #Products", connection);
                            command.ExecuteNonQuery();
                            command.Dispose();
                            Debug.WriteLine("Command executed");
                            Stopped = true;
                        }
                        catch (SqlException caught)
                        {
                            Debug.WriteLine("Somthing abnormal happens");
                            Debug.WriteLine(caught.Message);
                        }
                        break;
                    }
                }
            }
        }
    }
}