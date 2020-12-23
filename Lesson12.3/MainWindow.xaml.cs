using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson12._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public EventHandler start;
        public EventHandler reset;
        public EventHandler stop;


        #region События
        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }
        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }
        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }
        #endregion
        #region Обработчики событий
        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            start(sender, e);
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            reset(sender, e);
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            stop(sender, e);
        }
        #endregion
    }
}
