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
using CaptainsLog.Core;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<LogEntry> logEntries;
        public static int value = 0;
        public static int viewValue = 0;

        public MainWindow()
        {
            InitializeComponent();

            logEntries = new ObservableCollection<LogEntry>();
            gridLogEntries.ItemsSource = logEntries;
            gridLogEntries.MouseDoubleClick += new MouseButtonEventHandler(grid_doubleClick);
        }

        private void buttonAddEntry_Click(object sender, RoutedEventArgs e)
        {
            NewEntry window = new NewEntry();
            window.ShowDialog();
        }

        public void EditDetails(object sender, RoutedEventArgs e)
        {
            EditEntry edit = new EditEntry();
            LogEntry toEdit = ((FrameworkElement)sender).DataContext as LogEntry;
            value = logEntries.IndexOf(toEdit);
            edit.passEntryText();
            edit.ShowDialog();
        }

       public void grid_doubleClick(object sender, MouseEventArgs e)
        {
            ViewEntry view = new ViewEntry();
            viewValue = gridLogEntries.SelectedIndex;
            if (viewValue >= 0)
            {
                view.viewEntryInfo();
                view.ShowDialog();
            }
        }

        private void buttonDelete(object sender, RoutedEventArgs e)
        {
            LogEntry obj = ((Button)sender).DataContext as LogEntry;
            int toDelete = logEntries.IndexOf(obj);
            if (toDelete >= 0)
            {
                logEntries.RemoveAt(toDelete);
            }
        }
    }
}
