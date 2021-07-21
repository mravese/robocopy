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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RobocopyWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSourceDirectory_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dialogResult = fbd.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                tbSourceDirectory.Text = fbd.SelectedPath;
                string sourceDirectory = tbSourceDirectory.Text;
            }
        }

        private void btnTargetDirectory_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbTargetDirectory.Text = fbd.SelectedPath;
                string destinationDirectory = tbTargetDirectory.Text;
            }
        }

        private bool cmdIsActive = false;
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            string copyOption = "";

            //Copy options
            if (rbS.IsChecked == true)
            {
                copyOption = "/S";
            }
            if (rbE.IsChecked == true)
            {
                copyOption = "/E";
            }

            //Empty both source and destination
            if (tbSourceDirectory.Text == "" && tbTargetDirectory.Text == "")
            {
                System.Windows.MessageBox.Show("Error: Enter source and destination.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            //Empty only one of them
            else if (tbSourceDirectory.Text == "" || tbTargetDirectory.Text == "")
            {
                if (tbSourceDirectory.Text == "")
                {
                    System.Windows.MessageBox.Show("Error: Enter source.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                if (tbTargetDirectory.Text == "")
                {
                    System.Windows.MessageBox.Show("Error: Enter destination.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            //Not selected copy option
            else if (rbS.IsChecked == false && rbE.IsChecked == false)
            {
                System.Windows.MessageBox.Show("Error: Select copy option.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            //Run robocopy
            else
            {
                string cmdRobocopy = (@"robocopy " + '"' + tbSourceDirectory.Text + '"' + " " + '"' + tbTargetDirectory.Text + '"' + " " + copyOption);                
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd.exe";
                ps.WindowStyle = ProcessWindowStyle.Normal;
                ps.Arguments = "/c " + cmdRobocopy;
                cmdIsActive = true;
                Process.Start(ps);

                tbSourceDirectory.Text = "";
                tbTargetDirectory.Text = "";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmdIsActive == true)
            {
                if (System.Windows.MessageBox.Show("There is a process running. Do you really want to close?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                {
                    System.Windows.Application.Current.Shutdown();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
