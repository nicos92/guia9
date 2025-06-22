using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace Guia_9
{
    public class BackWork : BackgroundWorker
    {
        private ProgressBar _progress;
        private Action _action;
        public BackWork(ProgressBar bar, Action action)
        {
            _progress = bar;
            _action = action;
            this.WorkerReportsProgress = true;
            
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            base.OnDoWork(e);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(4);
                this.ReportProgress(i);
            }
        }

        protected override void OnProgressChanged(ProgressChangedEventArgs e)
        {
            base.OnProgressChanged(e);
            _progress.Value = e.ProgressPercentage;
        }
        protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            base.OnRunWorkerCompleted(e);
            _progress.Visible = false;
            _action();
        }
    }
}
