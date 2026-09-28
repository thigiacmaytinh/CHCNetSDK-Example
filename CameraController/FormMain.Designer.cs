using TGMTcontrols;

namespace CameraController
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxChannel = new TGMTcontrols.RoundedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new TGMTcontrols.RoundedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new TGMTcontrols.PasswordBox();
            this.txt_username = new TGMTcontrols.RoundedTextBox();
            this.txt_port = new TGMTcontrols.RoundedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ip = new TGMTcontrols.RoundedTextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.circle1 = new TGMTcontrols.ProcessingControl();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_connect = new TGMTcontrols.DefaultButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gradientTab1 = new TGMTcontrols.GradientTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_right = new TGMTcontrols.DefaultButton();
            this.btn_left = new TGMTcontrols.DefaultButton();
            this.btn_down = new TGMTcontrols.DefaultButton();
            this.btn_up = new TGMTcontrols.DefaultButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_setImageConfig = new TGMTcontrols.DefaultButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_hue = new TGMTcontrols.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_saturation = new TGMTcontrols.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_contrast = new TGMTcontrols.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_brightness = new TGMTcontrols.NumericUpDown();
            this.btn_getImageConfig = new TGMTcontrols.DefaultButton();
            this.btn_flip = new TGMTcontrols.DefaultButton();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ipAddress = new TGMTcontrols.RoundedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_gateway = new TGMTcontrols.RoundedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_subnetMask = new TGMTcontrols.RoundedTextBox();
            this.btn_setIP = new TGMTcontrols.DefaultButton();
            this.rd_dynamicIP = new System.Windows.Forms.RadioButton();
            this.rd_staticIP = new System.Windows.Forms.RadioButton();
            this.btn_getIP = new TGMTcontrols.DefaultButton();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gradientTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(103)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.textBoxChannel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_port);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_ip);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.circle1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_connect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 182);
            this.panel1.TabIndex = 1;
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.BackColor = System.Drawing.Color.Transparent;
            this.textBoxChannel.BackgroundColor = System.Drawing.Color.White;
            this.textBoxChannel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.textBoxChannel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxChannel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxChannel.Location = new System.Drawing.Point(149, 124);
            this.textBoxChannel.Multiline = false;
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.NumberOnly = false;
            this.textBoxChannel.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxChannel.Radius = 4;
            this.textBoxChannel.Size = new System.Drawing.Size(163, 30);
            this.textBoxChannel.TabIndex = 54;
            this.textBoxChannel.TabStop = false;
            this.textBoxChannel.Text = "1";
            this.textBoxChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Channel";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Transparent;
            this.textBoxID.BackgroundColor = System.Drawing.Color.White;
            this.textBoxID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxID.Location = new System.Drawing.Point(469, 128);
            this.textBoxID.Multiline = false;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.NumberOnly = false;
            this.textBoxID.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxID.Radius = 4;
            this.textBoxID.Size = new System.Drawing.Size(163, 30);
            this.textBoxID.TabIndex = 52;
            this.textBoxID.TabStop = false;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Stream ID";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.BackgroundColor = System.Drawing.Color.White;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_password.Location = new System.Drawing.Point(414, 53);
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(5);
            this.txt_password.Radius = 6;
            this.txt_password.Size = new System.Drawing.Size(163, 33);
            this.txt_password.TabIndex = 49;
            this.txt_password.TabStop = false;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.BackgroundColor = System.Drawing.Color.White;
            this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_username.Location = new System.Drawing.Point(152, 56);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.NumberOnly = false;
            this.txt_username.Padding = new System.Windows.Forms.Padding(5);
            this.txt_username.Radius = 4;
            this.txt_username.Size = new System.Drawing.Size(160, 30);
            this.txt_username.TabIndex = 48;
            this.txt_username.TabStop = false;
            this.txt_username.Text = "admin";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_port
            // 
            this.txt_port.BackColor = System.Drawing.Color.Transparent;
            this.txt_port.BackgroundColor = System.Drawing.Color.White;
            this.txt_port.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_port.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_port.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_port.Location = new System.Drawing.Point(414, 16);
            this.txt_port.Multiline = false;
            this.txt_port.Name = "txt_port";
            this.txt_port.NumberOnly = false;
            this.txt_port.Padding = new System.Windows.Forms.Padding(5);
            this.txt_port.Radius = 4;
            this.txt_port.Size = new System.Drawing.Size(163, 30);
            this.txt_port.TabIndex = 47;
            this.txt_port.TabStop = false;
            this.txt_port.Text = "8000";
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(362, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Port";
            // 
            // txt_ip
            // 
            this.txt_ip.BackColor = System.Drawing.Color.Transparent;
            this.txt_ip.BackgroundColor = System.Drawing.Color.White;
            this.txt_ip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_ip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_ip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ip.Location = new System.Drawing.Point(153, 16);
            this.txt_ip.Multiline = false;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.NumberOnly = false;
            this.txt_ip.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ip.Radius = 4;
            this.txt_ip.Size = new System.Drawing.Size(160, 30);
            this.txt_ip.TabIndex = 45;
            this.txt_ip.TabStop = false;
            this.txt_ip.Text = "192.168.1.148";
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(629, 67);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(53, 20);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Status";
            // 
            // circle1
            // 
            this.circle1.BackColor = System.Drawing.Color.Transparent;
            this.circle1.IndexColor = System.Drawing.Color.Turquoise;
            this.circle1.Interval = 50;
            this.circle1.Location = new System.Drawing.Point(768, 24);
            this.circle1.Name = "circle1";
            this.circle1.NCircle = 8;
            this.circle1.Others = System.Drawing.Color.LightGray;
            this.circle1.Radius = 4;
            this.circle1.Size = new System.Drawing.Size(39, 34);
            this.circle1.TabIndex = 16;
            this.circle1.Text = "processingControl1";
            this.circle1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // btn_connect
            // 
            this.btn_connect.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btn_connect.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Icon = null;
            this.btn_connect.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_connect.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_connect.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btn_connect.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btn_connect.Location = new System.Drawing.Point(629, 23);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Radius = 6;
            this.btn_connect.Size = new System.Drawing.Size(137, 38);
            this.btn_connect.Stroke = 0;
            this.btn_connect.StrokeColor = System.Drawing.Color.Gray;
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.Transparency = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message,
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1041, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 17);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // gradientTab1
            // 
            this.gradientTab1.Controls.Add(this.tabPage1);
            this.gradientTab1.Controls.Add(this.tabPage2);
            this.gradientTab1.Controls.Add(this.tabPage3);
            this.gradientTab1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.gradientTab1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gradientTab1.ImageLocation = new System.Drawing.Point(0, 0);
            this.gradientTab1.ImageSize = new System.Drawing.Size(0, 0);
            this.gradientTab1.ItemSize = new System.Drawing.Size(100, 30);
            this.gradientTab1.Location = new System.Drawing.Point(449, 182);
            this.gradientTab1.Name = "gradientTab1";
            this.gradientTab1.SelectedIndex = 0;
            this.gradientTab1.Size = new System.Drawing.Size(592, 472);
            this.gradientTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.gradientTab1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxSpeed);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btn_right);
            this.tabPage1.Controls.Add(this.btn_left);
            this.tabPage1.Controls.Add(this.btn_down);
            this.tabPage1.Controls.Add(this.btn_up);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 434);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "PTZ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(228, 267);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(83, 28);
            this.comboBoxSpeed.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "speed：";
            // 
            // btn_right
            // 
            this.btn_right.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_right.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_right.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_right.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_right.ForeColor = System.Drawing.Color.White;
            this.btn_right.Icon = null;
            this.btn_right.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_right.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_right.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_right.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_right.Location = new System.Drawing.Point(290, 106);
            this.btn_right.Name = "btn_right";
            this.btn_right.Radius = 6;
            this.btn_right.Size = new System.Drawing.Size(74, 30);
            this.btn_right.Stroke = 0;
            this.btn_right.StrokeColor = System.Drawing.Color.Gray;
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Right";
            this.btn_right.Transparency = false;
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseDown);
            this.btn_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseUp);
            // 
            // btn_left
            // 
            this.btn_left.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_left.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_left.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_left.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_left.ForeColor = System.Drawing.Color.White;
            this.btn_left.Icon = null;
            this.btn_left.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_left.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_left.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_left.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_left.Location = new System.Drawing.Point(82, 106);
            this.btn_left.Name = "btn_left";
            this.btn_left.Radius = 6;
            this.btn_left.Size = new System.Drawing.Size(74, 30);
            this.btn_left.Stroke = 0;
            this.btn_left.StrokeColor = System.Drawing.Color.Gray;
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "Left";
            this.btn_left.Transparency = false;
            this.btn_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseDown);
            this.btn_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseUp);
            // 
            // btn_down
            // 
            this.btn_down.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_down.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_down.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_down.ForeColor = System.Drawing.Color.White;
            this.btn_down.Icon = null;
            this.btn_down.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_down.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_down.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_down.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_down.Location = new System.Drawing.Point(180, 149);
            this.btn_down.Name = "btn_down";
            this.btn_down.Radius = 6;
            this.btn_down.Size = new System.Drawing.Size(74, 30);
            this.btn_down.Stroke = 0;
            this.btn_down.StrokeColor = System.Drawing.Color.Gray;
            this.btn_down.TabIndex = 1;
            this.btn_down.Text = "Down";
            this.btn_down.Transparency = false;
            this.btn_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_down_MouseDown);
            this.btn_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_down_MouseUp);
            // 
            // btn_up
            // 
            this.btn_up.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_up.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_up.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_up.ForeColor = System.Drawing.Color.White;
            this.btn_up.Icon = null;
            this.btn_up.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_up.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_up.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_up.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_up.Location = new System.Drawing.Point(180, 63);
            this.btn_up.Name = "btn_up";
            this.btn_up.Radius = 6;
            this.btn_up.Size = new System.Drawing.Size(74, 30);
            this.btn_up.Stroke = 0;
            this.btn_up.StrokeColor = System.Drawing.Color.Gray;
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "Up";
            this.btn_up.Transparency = false;
            this.btn_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_up_MouseDown);
            this.btn_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_up_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_getIP);
            this.tabPage2.Controls.Add(this.rd_staticIP);
            this.tabPage2.Controls.Add(this.rd_dynamicIP);
            this.tabPage2.Controls.Add(this.btn_setIP);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_subnetMask);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txt_gateway);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_ipAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 434);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Network";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_setImageConfig);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt_hue);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_saturation);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt_contrast);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt_brightness);
            this.tabPage3.Controls.Add(this.btn_getImageConfig);
            this.tabPage3.Controls.Add(this.btn_flip);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(584, 434);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Image";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_setImageConfig
            // 
            this.btn_setImageConfig.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_setImageConfig.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_setImageConfig.BackColor = System.Drawing.Color.Transparent;
            this.btn_setImageConfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_setImageConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_setImageConfig.ForeColor = System.Drawing.Color.White;
            this.btn_setImageConfig.Icon = null;
            this.btn_setImageConfig.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_setImageConfig.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_setImageConfig.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_setImageConfig.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_setImageConfig.Location = new System.Drawing.Point(280, 330);
            this.btn_setImageConfig.Name = "btn_setImageConfig";
            this.btn_setImageConfig.Radius = 6;
            this.btn_setImageConfig.Size = new System.Drawing.Size(110, 36);
            this.btn_setImageConfig.Stroke = 0;
            this.btn_setImageConfig.StrokeColor = System.Drawing.Color.Gray;
            this.btn_setImageConfig.TabIndex = 30;
            this.btn_setImageConfig.Text = "Set config";
            this.btn_setImageConfig.Transparency = false;
            this.btn_setImageConfig.Click += new System.EventHandler(this.btn_setImageConfig_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label11.Location = new System.Drawing.Point(36, 367);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hue";
            // 
            // txt_hue
            // 
            this.txt_hue.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_hue.Location = new System.Drawing.Point(124, 360);
            this.txt_hue.MaxValue = 10D;
            this.txt_hue.MinValue = 0D;
            this.txt_hue.Name = "txt_hue";
            this.txt_hue.SignColor = System.Drawing.Color.White;
            this.txt_hue.Size = new System.Drawing.Size(105, 31);
            this.txt_hue.TabIndex = 28;
            this.txt_hue.Text = "numericUpDown4";
            this.txt_hue.Value = 0D;
            this.txt_hue.ValueChanged += new System.EventHandler(this.txt_hue_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label10.Location = new System.Drawing.Point(36, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Saturation";
            // 
            // txt_saturation
            // 
            this.txt_saturation.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_saturation.Location = new System.Drawing.Point(124, 323);
            this.txt_saturation.MaxValue = 10D;
            this.txt_saturation.MinValue = 0D;
            this.txt_saturation.Name = "txt_saturation";
            this.txt_saturation.SignColor = System.Drawing.Color.White;
            this.txt_saturation.Size = new System.Drawing.Size(105, 31);
            this.txt_saturation.TabIndex = 26;
            this.txt_saturation.Text = "numericUpDown3";
            this.txt_saturation.Value = 0D;
            this.txt_saturation.ValueChanged += new System.EventHandler(this.txt_saturation_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label9.Location = new System.Drawing.Point(36, 293);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Contrast";
            // 
            // txt_contrast
            // 
            this.txt_contrast.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_contrast.Location = new System.Drawing.Point(124, 286);
            this.txt_contrast.MaxValue = 10D;
            this.txt_contrast.MinValue = 0D;
            this.txt_contrast.Name = "txt_contrast";
            this.txt_contrast.SignColor = System.Drawing.Color.White;
            this.txt_contrast.Size = new System.Drawing.Size(105, 31);
            this.txt_contrast.TabIndex = 24;
            this.txt_contrast.Text = "numericUpDown2";
            this.txt_contrast.Value = 0D;
            this.txt_contrast.ValueChanged += new System.EventHandler(this.txt_contrast_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label8.Location = new System.Drawing.Point(36, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Brightness";
            // 
            // txt_brightness
            // 
            this.txt_brightness.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_brightness.Location = new System.Drawing.Point(124, 249);
            this.txt_brightness.MaxValue = 10D;
            this.txt_brightness.MinValue = 0D;
            this.txt_brightness.Name = "txt_brightness";
            this.txt_brightness.SignColor = System.Drawing.Color.White;
            this.txt_brightness.Size = new System.Drawing.Size(105, 31);
            this.txt_brightness.TabIndex = 2;
            this.txt_brightness.Text = "numericUpDown1";
            this.txt_brightness.Value = 0D;
            this.txt_brightness.ValueChanged += new System.EventHandler(this.txt_brightness_ValueChanged);
            // 
            // btn_getImageConfig
            // 
            this.btn_getImageConfig.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_getImageConfig.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_getImageConfig.BackColor = System.Drawing.Color.Transparent;
            this.btn_getImageConfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_getImageConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_getImageConfig.ForeColor = System.Drawing.Color.White;
            this.btn_getImageConfig.Icon = null;
            this.btn_getImageConfig.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_getImageConfig.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_getImageConfig.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_getImageConfig.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_getImageConfig.Location = new System.Drawing.Point(280, 269);
            this.btn_getImageConfig.Name = "btn_getImageConfig";
            this.btn_getImageConfig.Radius = 6;
            this.btn_getImageConfig.Size = new System.Drawing.Size(110, 36);
            this.btn_getImageConfig.Stroke = 0;
            this.btn_getImageConfig.StrokeColor = System.Drawing.Color.Gray;
            this.btn_getImageConfig.TabIndex = 1;
            this.btn_getImageConfig.Text = "Get config";
            this.btn_getImageConfig.Transparency = false;
            this.btn_getImageConfig.Click += new System.EventHandler(this.btn_getImageConfig_Click);
            // 
            // btn_flip
            // 
            this.btn_flip.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_flip.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_flip.BackColor = System.Drawing.Color.Transparent;
            this.btn_flip.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_flip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_flip.ForeColor = System.Drawing.Color.White;
            this.btn_flip.Icon = null;
            this.btn_flip.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_flip.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_flip.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_flip.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_flip.Location = new System.Drawing.Point(13, 52);
            this.btn_flip.Name = "btn_flip";
            this.btn_flip.Radius = 6;
            this.btn_flip.Size = new System.Drawing.Size(110, 30);
            this.btn_flip.Stroke = 0;
            this.btn_flip.StrokeColor = System.Drawing.Color.Gray;
            this.btn_flip.TabIndex = 0;
            this.btn_flip.Text = "Flip image";
            this.btn_flip.Transparency = false;
            this.btn_flip.Click += new System.EventHandler(this.btn_flip_Click);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.pictureBox1);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(0, 182);
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(449, 472);
            this.panelCamera.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 266);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_ipAddress
            // 
            this.txt_ipAddress.BackColor = System.Drawing.Color.Transparent;
            this.txt_ipAddress.BackgroundColor = System.Drawing.Color.White;
            this.txt_ipAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_ipAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_ipAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ipAddress.Location = new System.Drawing.Point(200, 146);
            this.txt_ipAddress.Multiline = false;
            this.txt_ipAddress.Name = "txt_ipAddress";
            this.txt_ipAddress.NumberOnly = false;
            this.txt_ipAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ipAddress.Radius = 4;
            this.txt_ipAddress.Size = new System.Drawing.Size(163, 30);
            this.txt_ipAddress.TabIndex = 55;
            this.txt_ipAddress.TabStop = false;
            this.txt_ipAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label12.Location = new System.Drawing.Point(92, 152);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "IP address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label13.Location = new System.Drawing.Point(92, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "Gateway";
            // 
            // txt_gateway
            // 
            this.txt_gateway.BackColor = System.Drawing.Color.Transparent;
            this.txt_gateway.BackgroundColor = System.Drawing.Color.White;
            this.txt_gateway.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_gateway.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_gateway.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_gateway.Location = new System.Drawing.Point(200, 182);
            this.txt_gateway.Multiline = false;
            this.txt_gateway.Name = "txt_gateway";
            this.txt_gateway.NumberOnly = false;
            this.txt_gateway.Padding = new System.Windows.Forms.Padding(5);
            this.txt_gateway.Radius = 4;
            this.txt_gateway.Size = new System.Drawing.Size(163, 30);
            this.txt_gateway.TabIndex = 57;
            this.txt_gateway.TabStop = false;
            this.txt_gateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label14.Location = new System.Drawing.Point(92, 224);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 60;
            this.label14.Text = "Subnet mask";
            // 
            // txt_subnetMask
            // 
            this.txt_subnetMask.BackColor = System.Drawing.Color.Transparent;
            this.txt_subnetMask.BackgroundColor = System.Drawing.Color.White;
            this.txt_subnetMask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_subnetMask.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_subnetMask.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_subnetMask.Location = new System.Drawing.Point(200, 218);
            this.txt_subnetMask.Multiline = false;
            this.txt_subnetMask.Name = "txt_subnetMask";
            this.txt_subnetMask.NumberOnly = false;
            this.txt_subnetMask.Padding = new System.Windows.Forms.Padding(5);
            this.txt_subnetMask.Radius = 4;
            this.txt_subnetMask.Size = new System.Drawing.Size(163, 30);
            this.txt_subnetMask.TabIndex = 59;
            this.txt_subnetMask.TabStop = false;
            this.txt_subnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_setIP
            // 
            this.btn_setIP.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_setIP.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_setIP.BackColor = System.Drawing.Color.Transparent;
            this.btn_setIP.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_setIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_setIP.ForeColor = System.Drawing.Color.White;
            this.btn_setIP.Icon = null;
            this.btn_setIP.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_setIP.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_setIP.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_setIP.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_setIP.Location = new System.Drawing.Point(244, 272);
            this.btn_setIP.Name = "btn_setIP";
            this.btn_setIP.Radius = 6;
            this.btn_setIP.Size = new System.Drawing.Size(110, 36);
            this.btn_setIP.Stroke = 0;
            this.btn_setIP.StrokeColor = System.Drawing.Color.Gray;
            this.btn_setIP.TabIndex = 61;
            this.btn_setIP.Text = "Set IP";
            this.btn_setIP.Transparency = false;
            this.btn_setIP.Click += new System.EventHandler(this.btn_setIP_Click);
            // 
            // rd_dynamicIP
            // 
            this.rd_dynamicIP.AutoSize = true;
            this.rd_dynamicIP.Checked = true;
            this.rd_dynamicIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.rd_dynamicIP.Location = new System.Drawing.Point(53, 38);
            this.rd_dynamicIP.Name = "rd_dynamicIP";
            this.rd_dynamicIP.Size = new System.Drawing.Size(154, 24);
            this.rd_dynamicIP.TabIndex = 62;
            this.rd_dynamicIP.Text = "Dynamic IP (DHCP)";
            this.rd_dynamicIP.UseVisualStyleBackColor = true;
            // 
            // rd_staticIP
            // 
            this.rd_staticIP.AutoSize = true;
            this.rd_staticIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.rd_staticIP.Location = new System.Drawing.Point(238, 38);
            this.rd_staticIP.Name = "rd_staticIP";
            this.rd_staticIP.Size = new System.Drawing.Size(80, 24);
            this.rd_staticIP.TabIndex = 63;
            this.rd_staticIP.Text = "Static IP";
            this.rd_staticIP.UseVisualStyleBackColor = true;
            // 
            // btn_getIP
            // 
            this.btn_getIP.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_getIP.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_getIP.BackColor = System.Drawing.Color.Transparent;
            this.btn_getIP.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_getIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_getIP.ForeColor = System.Drawing.Color.White;
            this.btn_getIP.Icon = null;
            this.btn_getIP.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_getIP.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_getIP.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_getIP.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_getIP.Location = new System.Drawing.Point(128, 272);
            this.btn_getIP.Name = "btn_getIP";
            this.btn_getIP.Radius = 6;
            this.btn_getIP.Size = new System.Drawing.Size(110, 36);
            this.btn_getIP.Stroke = 0;
            this.btn_getIP.StrokeColor = System.Drawing.Color.Gray;
            this.btn_getIP.TabIndex = 64;
            this.btn_getIP.Text = "Get IP";
            this.btn_getIP.Transparency = false;
            this.btn_getIP.Click += new System.EventHandler(this.btn_getIP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 676);
            this.Controls.Add(this.panelCamera);
            this.Controls.Add(this.gradientTab1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "CHCNetSDK-Example";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gradientTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DefaultButton btn_connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private ProcessingControl circle1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.Label lbl_status;
        private GradientTab gradientTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private RoundedTextBox txt_ip;
        private System.Windows.Forms.Label label6;
        private RoundedTextBox txt_port;
        private RoundedTextBox txt_username;
        private PasswordBox txt_password;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedTextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private RoundedTextBox textBoxChannel;
        private System.Windows.Forms.Label label5;
        private DefaultButton btn_down;
        private DefaultButton btn_up;
        private DefaultButton btn_left;
        private DefaultButton btn_right;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label label7;
        private DefaultButton btn_flip;
        private DefaultButton btn_getImageConfig;
        private NumericUpDown txt_brightness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private NumericUpDown txt_hue;
        private System.Windows.Forms.Label label10;
        private NumericUpDown txt_saturation;
        private System.Windows.Forms.Label label9;
        private NumericUpDown txt_contrast;
        private DefaultButton btn_setImageConfig;
        private System.Windows.Forms.Label label12;
        private RoundedTextBox txt_ipAddress;
        private System.Windows.Forms.Label label14;
        private RoundedTextBox txt_subnetMask;
        private System.Windows.Forms.Label label13;
        private RoundedTextBox txt_gateway;
        private DefaultButton btn_setIP;
        private System.Windows.Forms.RadioButton rd_dynamicIP;
        private System.Windows.Forms.RadioButton rd_staticIP;
        private DefaultButton btn_getIP;
    }
}

