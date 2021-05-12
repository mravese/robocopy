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

        //Function that checks if string has space in between and removes it
        private void checkSpaces(string path)
        {
            bool hasSpace = path.Contains(" ");
            string pathWithoutSpaces = path.Replace(" ", String.Empty);
            
            if (hasSpace == true)
            {
                if (System.Windows.MessageBox.Show("Error: Found empty space in between folder name. In order to run robocopy, " +
                        "folder names must be written without spaces. We can automatically change that for you. " +
                        "Do you wish to proceed?", "Error", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
                {
                    //Removes spaces in every folder name --> rename folders
                    path = path.TrimEnd(System.IO.Path.DirectorySeparatorChar, System.IO.Path.AltDirectorySeparatorChar);

                    while (path != System.IO.Path.GetPathRoot(path))
                    {
                        string dest = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), System.IO.Path.GetFileName(path.Replace(" ", "")));

                        if (!path.Equals(dest, StringComparison.CurrentCultureIgnoreCase))
                        {
                            Directory.Move(path, dest);
                        }
                        path = System.IO.Path.GetDirectoryName(path);
                    }
                    //Changes source directory in textbox
                    tbSourceDirectory.Text = pathWithoutSpaces;
                }
                else
                {
                    //Makes no changes
                    System.Windows.MessageBox.Show("You must remove any empty space in the folders name in order to continue.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }       
        }

        private void btnSourceDirectory_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dialogResult = fbd.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                tbSourceDirectory.Text = fbd.SelectedPath;
                string sourceDirectory = tbSourceDirectory.Text;
                checkSpaces(sourceDirectory);
            }
        }

        private void btnTargetDirectory_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbTargetDirectory.Text = fbd.SelectedPath;
                string destinationDirectory = tbTargetDirectory.Text;
                checkSpaces(destinationDirectory);
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
                string cmdRobocopy = (@"robocopy " + tbSourceDirectory.Text + " " + tbTargetDirectory.Text + " " + copyOption);
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
