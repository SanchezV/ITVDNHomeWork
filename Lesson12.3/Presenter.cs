using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._3
{
    class Presenter
    {
        private readonly Model model;
        private readonly MainWindow view; 
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            view = mainWindow;
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            view.timer1.Tick += TimerTick;
            view.timer1.Start();
            view.timer1.Enabled = false;
            
        }

        void ViewReset(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.SecondsTextBox.Clear();
            model.Reset();
        }

        public void TimerTick()
        {
            throw new System.NotImplementedException();
        }

        public void ViewReset()
        {
            throw new System.NotImplementedException();
        }

        public void ViewStart()
        {
            throw new System.NotImplementedException();
        }

        public void ViewStop()
        {
            throw new System.NotImplementedException();
        }
    }
}
