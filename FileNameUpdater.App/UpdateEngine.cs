using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FileNameUpdater.App
{
    class UpdateEngine
    {

        public string Path { get; set; }
        private Thread thread;
        private bool threadRunning = false;

        public UpdateEngine()
        {
        }

        public void Start()
        {
            this.threadRunning = true;
            //Initialize Thread
            if (null == this.thread)
            {
                this.thread = new Thread(new ThreadStart(this.Run));
            }

            this.thread.Start();
        }

        public void Stop()
        {
            this.threadRunning = false;
            if (this.thread != null)
            {
                this.thread.Abort();
            }
        }

        private void Run()
        {
        }

        // Event code

        public delegate void FileUpdateEvent(string oldFileName, string newFileName);

        public event FileUpdateEvent FileNameChanged;

        private void OnFileNameChanged(string oldFileName, string newFileName)
        {
            if (this.FileNameChanged != null)
            {
                this.FileNameChanged(oldFileName, newFileName);
            }
        }

    }
}
