namespace DeviceExplorer
{
    partial class MainForm
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
            this.tabCallDeviceMethod = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.keyValueTextBox = new System.Windows.Forms.TextBox();
            this.keyNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTTL = new System.Windows.Forms.NumericUpDown();
            this.sasRichTextBox = new System.Windows.Forms.RichTextBox();
            this.generateSASButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dhConStringTextBox = new System.Windows.Forms.ComboBox();
            this.protocolGatewayHost = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateSettingsButton = new System.Windows.Forms.Button();
            this.tabManagement = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.deviceTwinPropertiesBtn = new System.Windows.Forms.Button();
            this.sasTokenButton = new System.Windows.Forms.Button();
            this.createDeviceButton = new System.Windows.Forms.Button();
            this.listDevicesButton = new System.Windows.Forms.Button();
            this.updateDeviceButton = new System.Windows.Forms.Button();
            this.deleteDeviceButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deviceCountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.devicesGridView = new System.Windows.Forms.DataGridView();
            this.devicesGridViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDeviceIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.getDeviceConnectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showDevicePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabData = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enableOperationMonitoring = new System.Windows.Forms.CheckBox();
            this.enableSystemProperties = new System.Windows.Forms.CheckBox();
            this.consumerGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelMonitoringButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.dataMonitorButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.eventHubNameTextBoxForDataTab = new System.Windows.Forms.TextBox();
            this.deviceIDsComboBoxForEvent = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eventHubTextBox = new System.Windows.Forms.RichTextBox();
            this.tabMessagesToDevice = new System.Windows.Forms.TabPage();
            this.messagePropertiesLabel = new System.Windows.Forms.Label();
            this.messagePropertiesGrid = new System.Windows.Forms.DataGridView();
            this.KeyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxMonitorFeedbackEndpoint = new System.Windows.Forms.CheckBox();
            this.messageClearButton = new System.Windows.Forms.Button();
            this.deviceIDsComboBoxForCloudToDeviceMessage = new System.Windows.Forms.ComboBox();
            this.iotHubNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.messagesTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendMessageToDeviceButton = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.tabDeviceMethod = new System.Windows.Forms.TabPage();
            this.callDeviceMethodCancelButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.callDeviceMethodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.returnPayloadTextBox = new System.Windows.Forms.TextBox();
            this.returnStatusTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.callDeviceMethodButton = new System.Windows.Forms.Button();
            this.deviceIDsComboBoxForDeviceMethod = new System.Windows.Forms.ComboBox();
            this.methodPayloadTextBox = new System.Windows.Forms.TextBox();
            this.methodNameTextBox = new System.Windows.Forms.TextBox();
            this.iotHubNameTextBoxForDeviceMethod = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ehStringToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabCallDeviceMethod.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTL)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabManagement.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesGridView)).BeginInit();
            this.devicesGridViewContextMenu.SuspendLayout();
            this.tabData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMessagesToDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagePropertiesGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabDeviceMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callDeviceMethodNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCallDeviceMethod
            // 
            this.tabCallDeviceMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCallDeviceMethod.Controls.Add(this.tabPage2);
            this.tabCallDeviceMethod.Controls.Add(this.tabManagement);
            this.tabCallDeviceMethod.Controls.Add(this.tabData);
            this.tabCallDeviceMethod.Controls.Add(this.tabMessagesToDevice);
            this.tabCallDeviceMethod.Controls.Add(this.tabDeviceMethod);
            this.tabCallDeviceMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCallDeviceMethod.Location = new System.Drawing.Point(24, 23);
            this.tabCallDeviceMethod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCallDeviceMethod.Name = "tabCallDeviceMethod";
            this.tabCallDeviceMethod.SelectedIndex = 0;
            this.tabCallDeviceMethod.Size = new System.Drawing.Size(1518, 1212);
            this.tabCallDeviceMethod.TabIndex = 0;
            this.tabCallDeviceMethod.TabStop = false;
            this.tabCallDeviceMethod.SelectedIndexChanged += new System.EventHandler(this.tabCallDeviceMethod_SelectedIndexChanged);
            this.tabCallDeviceMethod.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(8, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1502, 1160);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.targetTextBox);
            this.groupBox5.Controls.Add(this.keyValueTextBox);
            this.groupBox5.Controls.Add(this.keyNameTextBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.numericUpDownTTL);
            this.groupBox5.Controls.Add(this.sasRichTextBox);
            this.groupBox5.Controls.Add(this.generateSASButton);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(10, 369);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1482, 781);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shared Access Signature";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetTextBox.Enabled = false;
            this.targetTextBox.Location = new System.Drawing.Point(190, 154);
            this.targetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(1252, 37);
            this.targetTextBox.TabIndex = 2;
            // 
            // keyValueTextBox
            // 
            this.keyValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyValueTextBox.Enabled = false;
            this.keyValueTextBox.Location = new System.Drawing.Point(190, 104);
            this.keyValueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyValueTextBox.Name = "keyValueTextBox";
            this.keyValueTextBox.Size = new System.Drawing.Size(1252, 37);
            this.keyValueTextBox.TabIndex = 1;
            // 
            // keyNameTextBox
            // 
            this.keyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyNameTextBox.Enabled = false;
            this.keyNameTextBox.Location = new System.Drawing.Point(190, 54);
            this.keyNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyNameTextBox.Name = "keyNameTextBox";
            this.keyNameTextBox.Size = new System.Drawing.Size(1252, 37);
            this.keyNameTextBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Key Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key Name";
            // 
            // numericUpDownTTL
            // 
            this.numericUpDownTTL.Location = new System.Drawing.Point(190, 208);
            this.numericUpDownTTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownTTL.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownTTL.Name = "numericUpDownTTL";
            this.numericUpDownTTL.Size = new System.Drawing.Size(288, 37);
            this.numericUpDownTTL.TabIndex = 3;
            // 
            // sasRichTextBox
            // 
            this.sasRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sasRichTextBox.Location = new System.Drawing.Point(8, 283);
            this.sasRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sasRichTextBox.Name = "sasRichTextBox";
            this.sasRichTextBox.ReadOnly = true;
            this.sasRichTextBox.Size = new System.Drawing.Size(1460, 487);
            this.sasRichTextBox.TabIndex = 5;
            this.sasRichTextBox.Text = "";
            // 
            // generateSASButton
            // 
            this.generateSASButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSASButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateSASButton.Location = new System.Drawing.Point(1080, 208);
            this.generateSASButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateSASButton.Name = "generateSASButton";
            this.generateSASButton.Size = new System.Drawing.Size(366, 54);
            this.generateSASButton.TabIndex = 4;
            this.generateSASButton.Text = "Generate SAS";
            this.generateSASButton.UseVisualStyleBackColor = true;
            this.generateSASButton.Click += new System.EventHandler(this.generateSASButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "TTL (Days)";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.dhConStringTextBox);
            this.groupBox6.Controls.Add(this.protocolGatewayHost);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.updateSettingsButton);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(10, 46);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1482, 315);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Connection Information";
            // 
            // dhConStringTextBox
            // 
            this.dhConStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dhConStringTextBox.FormattingEnabled = true;
            this.dhConStringTextBox.Location = new System.Drawing.Point(22, 75);
            this.dhConStringTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dhConStringTextBox.Name = "dhConStringTextBox";
            this.dhConStringTextBox.Size = new System.Drawing.Size(1420, 38);
            this.dhConStringTextBox.TabIndex = 0;
            // 
            // protocolGatewayHost
            // 
            this.protocolGatewayHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protocolGatewayHost.Location = new System.Drawing.Point(22, 177);
            this.protocolGatewayHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.protocolGatewayHost.Name = "protocolGatewayHost";
            this.protocolGatewayHost.Size = new System.Drawing.Size(1420, 37);
            this.protocolGatewayHost.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 140);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(351, 30);
            this.label16.TabIndex = 16;
            this.label16.Text = "Protocol Gateway HostName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "IoT Hub Connection String:";
            // 
            // updateSettingsButton
            // 
            this.updateSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updateSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSettingsButton.Location = new System.Drawing.Point(22, 231);
            this.updateSettingsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.updateSettingsButton.Name = "updateSettingsButton";
            this.updateSettingsButton.Size = new System.Drawing.Size(250, 60);
            this.updateSettingsButton.TabIndex = 2;
            this.updateSettingsButton.Text = "Update";
            this.updateSettingsButton.UseVisualStyleBackColor = true;
            this.updateSettingsButton.Click += new System.EventHandler(this.updateSettingsButton_Click);
            // 
            // tabManagement
            // 
            this.tabManagement.Controls.Add(this.groupBox7);
            this.tabManagement.Controls.Add(this.groupBox2);
            this.tabManagement.Location = new System.Drawing.Point(8, 44);
            this.tabManagement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabManagement.Size = new System.Drawing.Size(1502, 1160);
            this.tabManagement.TabIndex = 0;
            this.tabManagement.Text = "Management";
            this.tabManagement.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.deviceTwinPropertiesBtn);
            this.groupBox7.Controls.Add(this.sasTokenButton);
            this.groupBox7.Controls.Add(this.createDeviceButton);
            this.groupBox7.Controls.Add(this.listDevicesButton);
            this.groupBox7.Controls.Add(this.updateDeviceButton);
            this.groupBox7.Controls.Add(this.deleteDeviceButton);
            this.groupBox7.Location = new System.Drawing.Point(12, 35);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox7.Size = new System.Drawing.Size(1468, 113);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Actions";
            // 
            // deviceTwinPropertiesBtn
            // 
            this.deviceTwinPropertiesBtn.Location = new System.Drawing.Point(1252, 40);
            this.deviceTwinPropertiesBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deviceTwinPropertiesBtn.Name = "deviceTwinPropertiesBtn";
            this.deviceTwinPropertiesBtn.Size = new System.Drawing.Size(200, 58);
            this.deviceTwinPropertiesBtn.TabIndex = 5;
            this.deviceTwinPropertiesBtn.Text = "Twin Props.";
            this.deviceTwinPropertiesBtn.UseVisualStyleBackColor = true;
            this.deviceTwinPropertiesBtn.Click += new System.EventHandler(this.deviceTwinPropertiesBtn_Click);
            // 
            // sasTokenButton
            // 
            this.sasTokenButton.Location = new System.Drawing.Point(1004, 40);
            this.sasTokenButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sasTokenButton.Name = "sasTokenButton";
            this.sasTokenButton.Size = new System.Drawing.Size(200, 58);
            this.sasTokenButton.TabIndex = 4;
            this.sasTokenButton.Text = "SAS Token...";
            this.sasTokenButton.UseVisualStyleBackColor = true;
            this.sasTokenButton.Click += new System.EventHandler(this.sasTokenButton_Click);
            // 
            // createDeviceButton
            // 
            this.createDeviceButton.Location = new System.Drawing.Point(12, 40);
            this.createDeviceButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.createDeviceButton.Name = "createDeviceButton";
            this.createDeviceButton.Size = new System.Drawing.Size(200, 58);
            this.createDeviceButton.TabIndex = 0;
            this.createDeviceButton.Text = "Create";
            this.createDeviceButton.UseVisualStyleBackColor = true;
            this.createDeviceButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // listDevicesButton
            // 
            this.listDevicesButton.Location = new System.Drawing.Point(260, 40);
            this.listDevicesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listDevicesButton.Name = "listDevicesButton";
            this.listDevicesButton.Size = new System.Drawing.Size(200, 58);
            this.listDevicesButton.TabIndex = 1;
            this.listDevicesButton.Text = "List";
            this.listDevicesButton.UseVisualStyleBackColor = true;
            this.listDevicesButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // updateDeviceButton
            // 
            this.updateDeviceButton.Location = new System.Drawing.Point(508, 40);
            this.updateDeviceButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.updateDeviceButton.Name = "updateDeviceButton";
            this.updateDeviceButton.Size = new System.Drawing.Size(200, 58);
            this.updateDeviceButton.TabIndex = 2;
            this.updateDeviceButton.Text = "Update";
            this.updateDeviceButton.UseVisualStyleBackColor = true;
            this.updateDeviceButton.Click += new System.EventHandler(this.updateDeviceButton_Click);
            // 
            // deleteDeviceButton
            // 
            this.deleteDeviceButton.Location = new System.Drawing.Point(756, 40);
            this.deleteDeviceButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteDeviceButton.Name = "deleteDeviceButton";
            this.deleteDeviceButton.Size = new System.Drawing.Size(200, 58);
            this.deleteDeviceButton.TabIndex = 3;
            this.deleteDeviceButton.Text = "Delete";
            this.deleteDeviceButton.UseVisualStyleBackColor = true;
            this.deleteDeviceButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.deviceCountLabel);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.devicesGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1478, 985);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devices";
            // 
            // deviceCountLabel
            // 
            this.deviceCountLabel.AutoSize = true;
            this.deviceCountLabel.Location = new System.Drawing.Point(110, 42);
            this.deviceCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.deviceCountLabel.Name = "deviceCountLabel";
            this.deviceCountLabel.Size = new System.Drawing.Size(27, 30);
            this.deviceCountLabel.TabIndex = 12;
            this.deviceCountLabel.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(14, 42);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(77, 30);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // devicesGridView
            // 
            this.devicesGridView.AllowUserToAddRows = false;
            this.devicesGridView.AllowUserToOrderColumns = true;
            this.devicesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesGridView.ContextMenuStrip = this.devicesGridViewContextMenu;
            this.devicesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.devicesGridView.Location = new System.Drawing.Point(10, 94);
            this.devicesGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devicesGridView.MultiSelect = false;
            this.devicesGridView.Name = "devicesGridView";
            this.devicesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devicesGridView.Size = new System.Drawing.Size(1458, 881);
            this.devicesGridView.TabIndex = 0;
            this.devicesGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.devicesGridView_DataBindingComplete);
            // 
            // devicesGridViewContextMenu
            // 
            this.devicesGridViewContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.devicesGridViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAllToolStripMenuItem,
            this.copySelectedToolStripMenuItem,
            this.copyDeviceIdToolStripMenuItem,
            this.toolStripSeparator1,
            this.getDeviceConnectionStringToolStripMenuItem,
            this.toolStripSeparator2,
            this.showDevicePropertiesToolStripMenuItem});
            this.devicesGridViewContextMenu.Name = "devicesGridViewContextMenu";
            this.devicesGridViewContextMenu.Size = new System.Drawing.Size(547, 196);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(546, 36);
            this.copyAllToolStripMenuItem.Text = "Copy data for all device";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(546, 36);
            this.copySelectedToolStripMenuItem.Text = "Copy data for selected device";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // copyDeviceIdToolStripMenuItem
            // 
            this.copyDeviceIdToolStripMenuItem.Name = "copyDeviceIdToolStripMenuItem";
            this.copyDeviceIdToolStripMenuItem.Size = new System.Drawing.Size(546, 36);
            this.copyDeviceIdToolStripMenuItem.Text = "Copy device id";
            this.copyDeviceIdToolStripMenuItem.Click += new System.EventHandler(this.copyDeviceIdToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(543, 6);
            // 
            // getDeviceConnectionStringToolStripMenuItem
            // 
            this.getDeviceConnectionStringToolStripMenuItem.Name = "getDeviceConnectionStringToolStripMenuItem";
            this.getDeviceConnectionStringToolStripMenuItem.Size = new System.Drawing.Size(546, 36);
            this.getDeviceConnectionStringToolStripMenuItem.Text = "Copy connection string for selected device";
            this.getDeviceConnectionStringToolStripMenuItem.Click += new System.EventHandler(this.getDeviceConnectionStringToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(543, 6);
            // 
            // showDevicePropertiesToolStripMenuItem
            // 
            this.showDevicePropertiesToolStripMenuItem.Name = "showDevicePropertiesToolStripMenuItem";
            this.showDevicePropertiesToolStripMenuItem.Size = new System.Drawing.Size(546, 36);
            this.showDevicePropertiesToolStripMenuItem.Text = "Show device properties";
            this.showDevicePropertiesToolStripMenuItem.Click += new System.EventHandler(this.showDevicePropertiesToolStripMenuItem_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.groupBox3);
            this.tabData.Controls.Add(this.groupBox1);
            this.tabData.Location = new System.Drawing.Point(8, 44);
            this.tabData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabData.Size = new System.Drawing.Size(1502, 1160);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.enableOperationMonitoring);
            this.groupBox3.Controls.Add(this.enableSystemProperties);
            this.groupBox3.Controls.Add(this.consumerGroupCheckBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupNameTextBox);
            this.groupBox3.Controls.Add(this.cancelMonitoringButton);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.clearDataButton);
            this.groupBox3.Controls.Add(this.dataMonitorButton);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.eventHubNameTextBoxForDataTab);
            this.groupBox3.Controls.Add(this.deviceIDsComboBoxForEvent);
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(12, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1478, 475);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitoring";
            // 
            // enableOperationMonitoring
            // 
            this.enableOperationMonitoring.AutoSize = true;
            this.enableOperationMonitoring.Location = new System.Drawing.Point(1058, 350);
            this.enableOperationMonitoring.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.enableOperationMonitoring.Name = "enableOperationMonitoring";
            this.enableOperationMonitoring.Size = new System.Drawing.Size(362, 34);
            this.enableOperationMonitoring.TabIndex = 29;
            this.enableOperationMonitoring.Text = "Show operations monitoring";
            this.enableOperationMonitoring.UseVisualStyleBackColor = true;
            // 
            // enableSystemProperties
            // 
            this.enableSystemProperties.AutoSize = true;
            this.enableSystemProperties.Location = new System.Drawing.Point(1058, 400);
            this.enableSystemProperties.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.enableSystemProperties.Name = "enableSystemProperties";
            this.enableSystemProperties.Size = new System.Drawing.Size(319, 34);
            this.enableSystemProperties.TabIndex = 8;
            this.enableSystemProperties.Text = "Show system properties";
            this.enableSystemProperties.UseVisualStyleBackColor = true;
            // 
            // consumerGroupCheckBox
            // 
            this.consumerGroupCheckBox.AutoSize = true;
            this.consumerGroupCheckBox.Checked = true;
            this.consumerGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consumerGroupCheckBox.Location = new System.Drawing.Point(814, 302);
            this.consumerGroupCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.consumerGroupCheckBox.Name = "consumerGroupCheckBox";
            this.consumerGroupCheckBox.Size = new System.Drawing.Size(124, 34);
            this.consumerGroupCheckBox.TabIndex = 4;
            this.consumerGroupCheckBox.Text = "Enable";
            this.consumerGroupCheckBox.UseVisualStyleBackColor = true;
            this.consumerGroupCheckBox.CheckedChanged += new System.EventHandler(this.consumerGroupCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Consumer Group:";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(280, 298);
            this.groupNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(512, 37);
            this.groupNameTextBox.TabIndex = 3;
            // 
            // cancelMonitoringButton
            // 
            this.cancelMonitoringButton.Location = new System.Drawing.Point(364, 388);
            this.cancelMonitoringButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelMonitoringButton.Name = "cancelMonitoringButton";
            this.cancelMonitoringButton.Size = new System.Drawing.Size(266, 58);
            this.cancelMonitoringButton.TabIndex = 6;
            this.cancelMonitoringButton.Text = "Cancel";
            this.cancelMonitoringButton.UseVisualStyleBackColor = true;
            this.cancelMonitoringButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "Event Hub:";
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(706, 388);
            this.clearDataButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(240, 58);
            this.clearDataButton.TabIndex = 7;
            this.clearDataButton.Text = "Clear";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // dataMonitorButton
            // 
            this.dataMonitorButton.Location = new System.Drawing.Point(42, 388);
            this.dataMonitorButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataMonitorButton.Name = "dataMonitorButton";
            this.dataMonitorButton.Size = new System.Drawing.Size(240, 58);
            this.dataMonitorButton.TabIndex = 5;
            this.dataMonitorButton.Text = "Monitor";
            this.dataMonitorButton.UseVisualStyleBackColor = true;
            this.dataMonitorButton.Click += new System.EventHandler(this.dataMonitorButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 233);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 30);
            this.label15.TabIndex = 23;
            this.label15.Text = "Start Time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Device ID:";
            // 
            // eventHubNameTextBoxForDataTab
            // 
            this.eventHubNameTextBoxForDataTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventHubNameTextBoxForDataTab.Location = new System.Drawing.Point(202, 65);
            this.eventHubNameTextBoxForDataTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventHubNameTextBoxForDataTab.Name = "eventHubNameTextBoxForDataTab";
            this.eventHubNameTextBoxForDataTab.ReadOnly = true;
            this.eventHubNameTextBoxForDataTab.Size = new System.Drawing.Size(1240, 37);
            this.eventHubNameTextBoxForDataTab.TabIndex = 0;
            // 
            // deviceIDsComboBoxForEvent
            // 
            this.deviceIDsComboBoxForEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceIDsComboBoxForEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceIDsComboBoxForEvent.FormattingEnabled = true;
            this.deviceIDsComboBoxForEvent.Location = new System.Drawing.Point(202, 140);
            this.deviceIDsComboBoxForEvent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deviceIDsComboBoxForEvent.Name = "deviceIDsComboBoxForEvent";
            this.deviceIDsComboBoxForEvent.Size = new System.Drawing.Size(1240, 38);
            this.deviceIDsComboBoxForEvent.TabIndex = 1;
            this.deviceIDsComboBoxForEvent.SelectionChangeCommitted += new System.EventHandler(this.deviceIDsComboBoxForEvent_SelectionChangeCommitted);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(202, 221);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(1240, 37);
            this.dateTimePicker.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.eventHubTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 562);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1478, 583);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Hub Data";
            // 
            // eventHubTextBox
            // 
            this.eventHubTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventHubTextBox.Location = new System.Drawing.Point(16, 40);
            this.eventHubTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.eventHubTextBox.Name = "eventHubTextBox";
            this.eventHubTextBox.ReadOnly = true;
            this.eventHubTextBox.Size = new System.Drawing.Size(1446, 527);
            this.eventHubTextBox.TabIndex = 0;
            this.eventHubTextBox.Text = "";
            // 
            // tabMessagesToDevice
            // 
            this.tabMessagesToDevice.Controls.Add(this.messagePropertiesLabel);
            this.tabMessagesToDevice.Controls.Add(this.messagePropertiesGrid);
            this.tabMessagesToDevice.Controls.Add(this.checkBoxMonitorFeedbackEndpoint);
            this.tabMessagesToDevice.Controls.Add(this.messageClearButton);
            this.tabMessagesToDevice.Controls.Add(this.deviceIDsComboBoxForCloudToDeviceMessage);
            this.tabMessagesToDevice.Controls.Add(this.iotHubNameTextBox);
            this.tabMessagesToDevice.Controls.Add(this.label2);
            this.tabMessagesToDevice.Controls.Add(this.checkBox1);
            this.tabMessagesToDevice.Controls.Add(this.groupBox4);
            this.tabMessagesToDevice.Controls.Add(this.label8);
            this.tabMessagesToDevice.Controls.Add(this.label7);
            this.tabMessagesToDevice.Controls.Add(this.label5);
            this.tabMessagesToDevice.Controls.Add(this.sendMessageToDeviceButton);
            this.tabMessagesToDevice.Controls.Add(this.textBoxMessage);
            this.tabMessagesToDevice.Location = new System.Drawing.Point(8, 44);
            this.tabMessagesToDevice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabMessagesToDevice.Name = "tabMessagesToDevice";
            this.tabMessagesToDevice.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabMessagesToDevice.Size = new System.Drawing.Size(1502, 1160);
            this.tabMessagesToDevice.TabIndex = 2;
            this.tabMessagesToDevice.Text = "Messages To Device";
            this.tabMessagesToDevice.UseVisualStyleBackColor = true;
            // 
            // messagePropertiesLabel
            // 
            this.messagePropertiesLabel.AutoSize = true;
            this.messagePropertiesLabel.Location = new System.Drawing.Point(42, 360);
            this.messagePropertiesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.messagePropertiesLabel.Name = "messagePropertiesLabel";
            this.messagePropertiesLabel.Size = new System.Drawing.Size(137, 30);
            this.messagePropertiesLabel.TabIndex = 14;
            this.messagePropertiesLabel.Text = "Properties:";
            // 
            // messagePropertiesGrid
            // 
            this.messagePropertiesGrid.AllowUserToResizeColumns = false;
            this.messagePropertiesGrid.AllowUserToResizeRows = false;
            this.messagePropertiesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagePropertiesGrid.BackgroundColor = System.Drawing.Color.White;
            this.messagePropertiesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagePropertiesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.messagePropertiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagePropertiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyColumn,
            this.ValueColumn});
            this.messagePropertiesGrid.Location = new System.Drawing.Point(48, 396);
            this.messagePropertiesGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.messagePropertiesGrid.Name = "messagePropertiesGrid";
            this.messagePropertiesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.messagePropertiesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.messagePropertiesGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagePropertiesGrid.Size = new System.Drawing.Size(1420, 215);
            this.messagePropertiesGrid.TabIndex = 5;
            // 
            // KeyColumn
            // 
            this.KeyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KeyColumn.HeaderText = "Key";
            this.KeyColumn.Name = "KeyColumn";
            this.KeyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KeyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValueColumn
            // 
            this.ValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkBoxMonitorFeedbackEndpoint
            // 
            this.checkBoxMonitorFeedbackEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxMonitorFeedbackEndpoint.AutoSize = true;
            this.checkBoxMonitorFeedbackEndpoint.Location = new System.Drawing.Point(562, 285);
            this.checkBoxMonitorFeedbackEndpoint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxMonitorFeedbackEndpoint.Name = "checkBoxMonitorFeedbackEndpoint";
            this.checkBoxMonitorFeedbackEndpoint.Size = new System.Drawing.Size(357, 34);
            this.checkBoxMonitorFeedbackEndpoint.TabIndex = 4;
            this.checkBoxMonitorFeedbackEndpoint.Text = "Monitor Feedback Endpoint";
            this.checkBoxMonitorFeedbackEndpoint.UseVisualStyleBackColor = true;
            this.checkBoxMonitorFeedbackEndpoint.CheckedChanged += new System.EventHandler(this.checkBoxMonitorFeedbackEndpoint_CheckedChanged);
            // 
            // messageClearButton
            // 
            this.messageClearButton.Location = new System.Drawing.Point(398, 640);
            this.messageClearButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.messageClearButton.MaximumSize = new System.Drawing.Size(290, 58);
            this.messageClearButton.Name = "messageClearButton";
            this.messageClearButton.Size = new System.Drawing.Size(290, 58);
            this.messageClearButton.TabIndex = 7;
            this.messageClearButton.Text = "Clear";
            this.messageClearButton.UseVisualStyleBackColor = true;
            this.messageClearButton.Click += new System.EventHandler(this.messageClearButton_Click);
            // 
            // deviceIDsComboBoxForCloudToDeviceMessage
            // 
            this.deviceIDsComboBoxForCloudToDeviceMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceIDsComboBoxForCloudToDeviceMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceIDsComboBoxForCloudToDeviceMessage.FormattingEnabled = true;
            this.deviceIDsComboBoxForCloudToDeviceMessage.Location = new System.Drawing.Point(208, 156);
            this.deviceIDsComboBoxForCloudToDeviceMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deviceIDsComboBoxForCloudToDeviceMessage.Name = "deviceIDsComboBoxForCloudToDeviceMessage";
            this.deviceIDsComboBoxForCloudToDeviceMessage.Size = new System.Drawing.Size(1256, 38);
            this.deviceIDsComboBoxForCloudToDeviceMessage.TabIndex = 1;
            this.deviceIDsComboBoxForCloudToDeviceMessage.SelectionChangeCommitted += new System.EventHandler(this.deviceIDsComboBoxForMessage_SelectionChangeCommitted);
            // 
            // iotHubNameTextBox
            // 
            this.iotHubNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iotHubNameTextBox.Location = new System.Drawing.Point(208, 102);
            this.iotHubNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iotHubNameTextBox.Name = "iotHubNameTextBox";
            this.iotHubNameTextBox.ReadOnly = true;
            this.iotHubNameTextBox.Size = new System.Drawing.Size(1256, 37);
            this.iotHubNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "IoT Hub:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(208, 285);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(236, 34);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Add Time Stamp";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.messagesTextBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 727);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(1456, 419);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesTextBox.Location = new System.Drawing.Point(12, 40);
            this.messagesTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.Size = new System.Drawing.Size(1428, 364);
            this.messagesTextBox.TabIndex = 0;
            this.messagesTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Message:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Device ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Send Message to Device:";
            // 
            // sendMessageToDeviceButton
            // 
            this.sendMessageToDeviceButton.Location = new System.Drawing.Point(48, 640);
            this.sendMessageToDeviceButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sendMessageToDeviceButton.MaximumSize = new System.Drawing.Size(290, 58);
            this.sendMessageToDeviceButton.Name = "sendMessageToDeviceButton";
            this.sendMessageToDeviceButton.Size = new System.Drawing.Size(290, 58);
            this.sendMessageToDeviceButton.TabIndex = 6;
            this.sendMessageToDeviceButton.Text = "Send";
            this.sendMessageToDeviceButton.UseVisualStyleBackColor = true;
            this.sendMessageToDeviceButton.Click += new System.EventHandler(this.sendMessageToDeviceButton_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(208, 213);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1256, 37);
            this.textBoxMessage.TabIndex = 2;
            // 
            // tabDeviceMethod
            // 
            this.tabDeviceMethod.Controls.Add(this.callDeviceMethodCancelButton);
            this.tabDeviceMethod.Controls.Add(this.label22);
            this.tabDeviceMethod.Controls.Add(this.callDeviceMethodNumericUpDown);
            this.tabDeviceMethod.Controls.Add(this.label21);
            this.tabDeviceMethod.Controls.Add(this.returnPayloadTextBox);
            this.tabDeviceMethod.Controls.Add(this.returnStatusTextBox);
            this.tabDeviceMethod.Controls.Add(this.label20);
            this.tabDeviceMethod.Controls.Add(this.callDeviceMethodButton);
            this.tabDeviceMethod.Controls.Add(this.deviceIDsComboBoxForDeviceMethod);
            this.tabDeviceMethod.Controls.Add(this.methodPayloadTextBox);
            this.tabDeviceMethod.Controls.Add(this.methodNameTextBox);
            this.tabDeviceMethod.Controls.Add(this.iotHubNameTextBoxForDeviceMethod);
            this.tabDeviceMethod.Controls.Add(this.label19);
            this.tabDeviceMethod.Controls.Add(this.label18);
            this.tabDeviceMethod.Controls.Add(this.label17);
            this.tabDeviceMethod.Controls.Add(this.label14);
            this.tabDeviceMethod.Controls.Add(this.label13);
            this.tabDeviceMethod.Location = new System.Drawing.Point(8, 44);
            this.tabDeviceMethod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabDeviceMethod.Name = "tabDeviceMethod";
            this.tabDeviceMethod.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabDeviceMethod.Size = new System.Drawing.Size(1502, 1160);
            this.tabDeviceMethod.TabIndex = 4;
            this.tabDeviceMethod.Text = "Call Method on Device";
            this.tabDeviceMethod.UseVisualStyleBackColor = true;
            // 
            // callDeviceMethodCancelButton
            // 
            this.callDeviceMethodCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.callDeviceMethodCancelButton.Enabled = false;
            this.callDeviceMethodCancelButton.Location = new System.Drawing.Point(1154, 631);
            this.callDeviceMethodCancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.callDeviceMethodCancelButton.Name = "callDeviceMethodCancelButton";
            this.callDeviceMethodCancelButton.Size = new System.Drawing.Size(310, 58);
            this.callDeviceMethodCancelButton.TabIndex = 6;
            this.callDeviceMethodCancelButton.Text = "Cancel";
            this.callDeviceMethodCancelButton.UseVisualStyleBackColor = true;
            this.callDeviceMethodCancelButton.Click += new System.EventHandler(this.callDeviceMethodCancelButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(274, 644);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(233, 30);
            this.label22.TabIndex = 16;
            this.label22.Text = "Timeout (seconds):";
            // 
            // callDeviceMethodNumericUpDown
            // 
            this.callDeviceMethodNumericUpDown.Location = new System.Drawing.Point(532, 640);
            this.callDeviceMethodNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.callDeviceMethodNumericUpDown.Name = "callDeviceMethodNumericUpDown";
            this.callDeviceMethodNumericUpDown.Size = new System.Drawing.Size(106, 37);
            this.callDeviceMethodNumericUpDown.TabIndex = 4;
            this.callDeviceMethodNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, 802);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(193, 30);
            this.label21.TabIndex = 14;
            this.label21.Text = "Return payload:";
            // 
            // returnPayloadTextBox
            // 
            this.returnPayloadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnPayloadTextBox.Location = new System.Drawing.Point(280, 796);
            this.returnPayloadTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.returnPayloadTextBox.Multiline = true;
            this.returnPayloadTextBox.Name = "returnPayloadTextBox";
            this.returnPayloadTextBox.ReadOnly = true;
            this.returnPayloadTextBox.Size = new System.Drawing.Size(1180, 342);
            this.returnPayloadTextBox.TabIndex = 8;
            // 
            // returnStatusTextBox
            // 
            this.returnStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnStatusTextBox.Location = new System.Drawing.Point(280, 742);
            this.returnStatusTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.returnStatusTextBox.Name = "returnStatusTextBox";
            this.returnStatusTextBox.ReadOnly = true;
            this.returnStatusTextBox.Size = new System.Drawing.Size(1180, 37);
            this.returnStatusTextBox.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 748);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 30);
            this.label20.TabIndex = 11;
            this.label20.Text = "Return status:";
            // 
            // callDeviceMethodButton
            // 
            this.callDeviceMethodButton.Location = new System.Drawing.Point(724, 631);
            this.callDeviceMethodButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.callDeviceMethodButton.Name = "callDeviceMethodButton";
            this.callDeviceMethodButton.Size = new System.Drawing.Size(298, 58);
            this.callDeviceMethodButton.TabIndex = 5;
            this.callDeviceMethodButton.Text = "Call Method";
            this.callDeviceMethodButton.UseVisualStyleBackColor = true;
            this.callDeviceMethodButton.Click += new System.EventHandler(this.callDeviceMethodButton_Click);
            // 
            // deviceIDsComboBoxForDeviceMethod
            // 
            this.deviceIDsComboBoxForDeviceMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceIDsComboBoxForDeviceMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceIDsComboBoxForDeviceMethod.FormattingEnabled = true;
            this.deviceIDsComboBoxForDeviceMethod.Location = new System.Drawing.Point(280, 156);
            this.deviceIDsComboBoxForDeviceMethod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deviceIDsComboBoxForDeviceMethod.Name = "deviceIDsComboBoxForDeviceMethod";
            this.deviceIDsComboBoxForDeviceMethod.Size = new System.Drawing.Size(1180, 38);
            this.deviceIDsComboBoxForDeviceMethod.TabIndex = 1;
            this.deviceIDsComboBoxForDeviceMethod.SelectionChangeCommitted += new System.EventHandler(this.deviceIDsComboBoxForDeviceMethod_SelectionChangeCommitted);
            // 
            // methodPayloadTextBox
            // 
            this.methodPayloadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.methodPayloadTextBox.Location = new System.Drawing.Point(280, 271);
            this.methodPayloadTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.methodPayloadTextBox.Multiline = true;
            this.methodPayloadTextBox.Name = "methodPayloadTextBox";
            this.methodPayloadTextBox.Size = new System.Drawing.Size(1180, 342);
            this.methodPayloadTextBox.TabIndex = 3;
            this.methodPayloadTextBox.Text = "{ \"MethodPayload\": \"Payload\" }";
            // 
            // methodNameTextBox
            // 
            this.methodNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.methodNameTextBox.Location = new System.Drawing.Point(280, 215);
            this.methodNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.methodNameTextBox.Name = "methodNameTextBox";
            this.methodNameTextBox.Size = new System.Drawing.Size(1180, 37);
            this.methodNameTextBox.TabIndex = 2;
            this.methodNameTextBox.Text = "MethodName";
            // 
            // iotHubNameTextBoxForDeviceMethod
            // 
            this.iotHubNameTextBoxForDeviceMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iotHubNameTextBoxForDeviceMethod.Location = new System.Drawing.Point(280, 100);
            this.iotHubNameTextBoxForDeviceMethod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iotHubNameTextBoxForDeviceMethod.Name = "iotHubNameTextBoxForDeviceMethod";
            this.iotHubNameTextBoxForDeviceMethod.ReadOnly = true;
            this.iotHubNameTextBoxForDeviceMethod.Size = new System.Drawing.Size(1180, 37);
            this.iotHubNameTextBoxForDeviceMethod.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 269);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 30);
            this.label19.TabIndex = 4;
            this.label19.Text = "Method payload:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 215);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 30);
            this.label18.TabIndex = 3;
            this.label18.Text = "Method name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 162);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 30);
            this.label17.TabIndex = 2;
            this.label17.Text = "Device ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 108);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 30);
            this.label14.TabIndex = 1;
            this.label14.Text = "IoT Hub:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Call Method on Device";
            // 
            // MainForm
            // 
            this.AcceptButton = this.updateSettingsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 1242);
            this.Controls.Add(this.tabCallDeviceMethod);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1334, 1098);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Explorer Twin";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabCallDeviceMethod.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTL)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabManagement.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesGridView)).EndInit();
            this.devicesGridViewContextMenu.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabMessagesToDevice.ResumeLayout(false);
            this.tabMessagesToDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagePropertiesGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabDeviceMethod.ResumeLayout(false);
            this.tabDeviceMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callDeviceMethodNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCallDeviceMethod;
        private System.Windows.Forms.TabPage tabManagement;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabMessagesToDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createDeviceButton;
        private System.Windows.Forms.Button listDevicesButton;
        private System.Windows.Forms.Button updateDeviceButton;
        private System.Windows.Forms.Button deleteDeviceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox eventHubTextBox;
        private System.Windows.Forms.Button sendMessageToDeviceButton;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button dataMonitorButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox messagesTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updateSettingsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox sasRichTextBox;
        private System.Windows.Forms.Button generateSASButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDownTTL;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.TextBox keyValueTextBox;
        private System.Windows.Forms.TextBox keyNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox eventHubNameTextBoxForDataTab;
        private System.Windows.Forms.TextBox iotHubNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deviceIDsComboBoxForEvent;
        private System.Windows.Forms.ComboBox deviceIDsComboBoxForCloudToDeviceMessage;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.DataGridView devicesGridView;
        private System.Windows.Forms.Button messageClearButton;
        private System.Windows.Forms.ToolTip ehStringToolTip;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cancelMonitoringButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.CheckBox consumerGroupCheckBox;
        private System.Windows.Forms.ContextMenuStrip devicesGridViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDeviceConnectionStringToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxMonitorFeedbackEndpoint;
        private System.Windows.Forms.TextBox protocolGatewayHost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label deviceCountLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button sasTokenButton;
        private System.Windows.Forms.DataGridView messagePropertiesGrid;
        private System.Windows.Forms.Label messagePropertiesLabel;
        private System.Windows.Forms.ToolStripMenuItem showDevicePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button deviceTwinPropertiesBtn;
        private System.Windows.Forms.TabPage tabDeviceMethod;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox iotHubNameTextBoxForDeviceMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.ComboBox deviceIDsComboBoxForDeviceMethod;
        private System.Windows.Forms.TextBox methodPayloadTextBox;
        private System.Windows.Forms.TextBox methodNameTextBox;
        private System.Windows.Forms.Button callDeviceMethodButton;
        private System.Windows.Forms.TextBox returnPayloadTextBox;
        private System.Windows.Forms.TextBox returnStatusTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown callDeviceMethodNumericUpDown;
        private System.Windows.Forms.Button callDeviceMethodCancelButton;
        private System.Windows.Forms.CheckBox enableSystemProperties;
        private System.Windows.Forms.ComboBox dhConStringTextBox;
        private System.Windows.Forms.CheckBox enableOperationMonitoring;
        private System.Windows.Forms.ToolStripMenuItem copyDeviceIdToolStripMenuItem;
    }
}

