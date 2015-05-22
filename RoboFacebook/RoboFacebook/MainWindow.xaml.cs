using System;
using System.Diagnostics;
using System.Windows;

namespace RoboFacebook
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnviarMensagem_Click(object sender, RoutedEventArgs e)
        {
            string robo = @"C:\RoboFace.rob";
            ProcessStartInfo startInfo = new ProcessStartInfo("TASKEXEC.EXE");

            startInfo.Arguments = String.Format(" \"{0}\"  \"{1}\" \"{2}\" \"{3}\"", robo, txtEmail.Text, txtSenha.Password, txtMensagem.Text);
            Process.Start(startInfo);    
        }
    }
}

