using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JavaStarter
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = txt_javaPath.Text;
            p.StartInfo.Arguments = txt_argumentos.Text;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();
            txt_salida.Text = p.StandardOutput.ReadToEnd();
            txt_salida.Text += p.StandardError.ReadToEnd();
            p.Close(); 
        }
    }
}
