using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Process[] process;

        void GetAllProcess()
        {
            process = Process.GetProcesses();
            listBox.Items.Clear();
            foreach (Process pr in process)
            {
                if (pr.MainWindowHandle.ToInt32() > 0)
                {
                    listBox1.Items.Add(pr.MainWindowTitle);
                }
                listBox.Items.Add(pr.ProcessName);

            }
            
             
        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                process[listBox.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
                if (listBox.SelectedItem.ToString() == p.ProcessName || listBox1.SelectedItem.ToString() == p.p)
                {
                    string temp = string.Empty;

                    temp += "\n Name : " + p.ProcessName + ".exe";

                    temp += "\n LifeTime : " + p.GetLifetimeService();

                    MessageBox.Show(temp);
                    break;
                }

                //else if (listBox1.SelectedItem.ToString() == p.MainWindowTitle)
                //{
                //    string temp = string.Empty;

                //    temp += "\n Name : " + p.ProcessName + ".exe";

                //    temp += "\n LifeTime : " + p.GetLifetimeService();

                //    MessageBox.Show(temp);
                //    break;
                //}
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRunNew_Click(object sender, EventArgs e)
        {
            using (Form2 frm = new Form2())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
