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
using System.IO;
using Microsoft.Win32;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for RichTextWindow.xaml
    /// </summary>
    public partial class RichTextWindow : Window
    {
        OpenFileDialog _openFileDialog;
        SaveFileDialog _saveFileDialog;
        string _content = string.Empty;
        string _filename =string.Empty;
        TextRange _range;
        

        public RichTextWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("La version 1.0 du logiciel bloc note");
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Text files (*.txt)|*.txt";
            _openFileDialog.DefaultExt = ".txt";
            if (_openFileDialog.ShowDialog() == true)
            {
                 _content = File.ReadAllText(_openFileDialog.FileName);
                _filename = _openFileDialog.FileName;
                rtb.Selection.Text = _content;
            }
            infoText.Text = _filename + $" File open at {now.Day}/{now.Month}/{now.Year} - {now.Hour}:{now.Minute} ";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            _saveFileDialog = new SaveFileDialog();
            _saveFileDialog.DefaultExt = ".txt";
            _saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if(_saveFileDialog.ShowDialog()==true)
            {
                _range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
                _content = _range.Text;
                _filename = _saveFileDialog.FileName;
                File.WriteAllText(_filename, _content);
            }
            infoText.Text = _filename + $" File saved at {now.Day}/{now.Month}/{now.Year} - {now.Hour}:{now.Minute} ";
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBoxResult result;
            _range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            if (_range.Text!= string.Empty)
            {
                result = MessageBox.Show("Save the aleardy open file", _filename, MessageBoxButton.YesNoCancel);
                if(result == MessageBoxResult.Yes)
                {
                    Save_Click(sender, e);
                    rtb.Document.Blocks.Clear();
                    rtb.Focus();
                }
                else if(result == MessageBoxResult.No)
                {
                    rtb.Document.Blocks.Clear();
                    rtb.Focus();
                }
                else
                {
                    return;
                }
            }
            if(now.Minute<10)
              infoText.Text = $" File created at {now.Day}/{now.Month}/{now.Year} - {now.Hour}:0{now.Minute} ";
            else
              infoText.Text = $" File created at {now.Day}/{now.Month}/{now.Year} - {now.Hour}:{now.Minute} ";

        }
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            _range = new TextRange(rtb.Selection.Start, rtb.Selection.End);
            Clipboard.SetText(_range.Text, TextDataFormat.Text);
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            _content = Clipboard.GetText();
            rtb.Paste();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            Copy_Click(sender,e);
            rtb.Selection.Text = String.Empty;
        }

        private void rtb_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            int level = e.Delta;
             
            if(level>0)
            {
                if (rtb.FontSize < 200)
                    rtb.FontSize+=1;
            }
            else
            {
                if(rtb.FontSize>7)
                rtb.FontSize -= 1;
            }
        }
    }
}
