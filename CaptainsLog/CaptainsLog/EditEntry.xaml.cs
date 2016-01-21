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
    /// Interaction logic for EditEntry.xaml
    /// </summary>
    public partial class EditEntry : Window
    {
        private int EntryID = MainWindow.value;
        public string titleText;
        public string theText;

        public EditEntry()
        {
            InitializeComponent();
        }

        public void passEntryText()
        {
            textBoxEditTitle.Text = MainWindow.logEntries[EntryID].Title;
            textBox.Text = MainWindow.logEntries[EntryID].Text;
        }

        public void buttonSaveEdit_Click(object sender, RoutedEventArgs e)
        {
            // update info -- doesn't work yet
            MainWindow.logEntries[EntryID].Title = textBoxEditTitle.Text;
            MessageBox.Show(MainWindow.logEntries[EntryID].Title);
        }
    }
}
