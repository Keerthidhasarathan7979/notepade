using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using forms=System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            txtNotepad.Text = "hi keerthi";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog ks = new SaveFileDialog();
            ks.Title = "keerthi save";
            ks.ShowDialog();
            string filename = ks.FileName + ".doc";
            File.WriteAllText(filename, txtNotepad.Text);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            forms.ColorDialog ks = new forms.ColorDialog();
            ks.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            forms.FontDialog sk = new forms.FontDialog();
            sk.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
           forms. OpenFileDialog sk = new forms. OpenFileDialog();
            sk.Title = "keerthi open";
            sk.Filter = "TextFile|*.txt|Document|*.doc";
            sk.ShowDialog();
            string filename = sk.FileName;
            txtNotepad.Text = File.ReadAllText(filename);
        }
    }
}
