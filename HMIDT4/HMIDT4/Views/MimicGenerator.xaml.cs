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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using HMIDT4.Views;
using Ookii.Dialogs;
using System.Threading;


namespace HMIDT4.Views
{
    /// <summary>
    /// Interaction logic for MimicGenerator.xaml
    /// </summary>
    /// 




    public partial class MimicGenerator : Page
    {
        public MimicGenerator()
        {
            InitializeComponent();
           

        }
        private void bt_cancel_Click(object sender, RoutedEventArgs e)
        {
            textbox_inputdata.Text = "";
            textbox_mimic.Text = "";
            
        }

        private void bt_gen_Click(object sender, RoutedEventArgs e)
        {

        
            string mimicname = textbox_mimic.Text;
            if (mimicname != "" && textbox_inputdata.Text != "")

            {
                
                string gen =  txtbox_path.Content +"\\" + mimicname + ".mimic";

            XmlDocument doc2 = new XmlDocument();
                doc2.Load("tpt_start.xml");

            doc2.Save(gen);

                lbl_progress.Content = mimicname + ".mimic has been created successfully!";


        }

        }

        private void Bt_explorer_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog(); if (openFileDialog.ShowDialog() == true) textbox_inputdata.Text = openFileDialog.FileName;
            var dialog = new Ookii.Dialogs.Wpf.VistaOpenFileDialog();
            dialog.ShowDialog();

            Console.WriteLine(dialog.FileName);
        }

        private void bt_explorer_path_Click(object sender, RoutedEventArgs e)
        {

            var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();

            dialog.ShowDialog();

            Console.WriteLine(dialog.SelectedPath);
            txtbox_path.Content = dialog.SelectedPath;
        }
    }
}
