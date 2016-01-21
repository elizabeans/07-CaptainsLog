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
using System.Windows.Shapes;
using CaptainsLog.Core;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for NewEntry.xaml
    /// </summary>
    public partial class NewEntry : Window
    {
        public NewEntry()
        {
            InitializeComponent();
        }

        public void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            LogEntry log = new LogEntry();
            log.Title = textBoxTitle.Text;
            log.Text = textBoxMainText.Text;
            log.EntryDate = DateTime.Now;
            log.Id = MainWindow.logEntries.Count + 1;
            MainWindow.logEntries.Add(log);
            Close();
        }
    }
}
