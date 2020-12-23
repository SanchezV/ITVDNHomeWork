using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._2
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.SomeEvent += MainWindow_SomeEvent;
        }

        private void MainWindow_SomeEvent(object sender, EventArgs e)
        {
            mainWindow.textBox1.Text = model.SomeMethod(mainWindow.textBox1.Text);
        }
    }
}
