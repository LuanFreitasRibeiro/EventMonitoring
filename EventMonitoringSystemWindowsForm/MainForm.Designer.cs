namespace EventMonitoringSystemWindowsForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddDevice;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.TextBox textBoxDeviceType;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelDeviceType;

        // Event section controls
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonLoadEvents;
        private System.Windows.Forms.Button buttonAckEvent;
        private System.Windows.Forms.Button buttonResolveEvent;
        private System.Windows.Forms.Button buttonTriggerEvent;
        private System.Windows.Forms.TextBox textBoxEventMessage;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelEventMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddDevice = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.textBoxDeviceType = new System.Windows.Forms.TextBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.labelDeviceType = new System.Windows.Forms.Label();

            // Event section controls
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonLoadEvents = new System.Windows.Forms.Button();
            this.buttonAckEvent = new System.Windows.Forms.Button();
            this.buttonResolveEvent = new System.Windows.Forms.Button();
            this.buttonTriggerEvent = new System.Windows.Forms.Button();
            this.textBoxEventMessage = new System.Windows.Forms.TextBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelEventMessage = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(210, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Device Monitoring";
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 20;
            this.listBoxDevices.Location = new System.Drawing.Point(20, 70);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(400, 120);
            this.listBoxDevices.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(320, 200);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 30);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(440, 70);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(93, 20);
            this.labelDeviceName.TabIndex = 3;
            this.labelDeviceName.Text = "Device Name";
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.Location = new System.Drawing.Point(440, 95);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(180, 27);
            this.textBoxDeviceName.TabIndex = 4;
            // 
            // labelDeviceType
            // 
            this.labelDeviceType.AutoSize = true;
            this.labelDeviceType.Location = new System.Drawing.Point(440, 135);
            this.labelDeviceType.Name = "labelDeviceType";
            this.labelDeviceType.Size = new System.Drawing.Size(89, 20);
            this.labelDeviceType.TabIndex = 5;
            this.labelDeviceType.Text = "Device Type";
            // 
            // textBoxDeviceType
            // 
            this.textBoxDeviceType.Location = new System.Drawing.Point(440, 160);
            this.textBoxDeviceType.Name = "textBoxDeviceType";
            this.textBoxDeviceType.Size = new System.Drawing.Size(180, 27);
            this.textBoxDeviceType.TabIndex = 6;
            // 
            // buttonAddDevice
            // 
            this.buttonAddDevice.Location = new System.Drawing.Point(440, 200);
            this.buttonAddDevice.Name = "buttonAddDevice";
            this.buttonAddDevice.Size = new System.Drawing.Size(180, 30);
            this.buttonAddDevice.TabIndex = 7;
            this.buttonAddDevice.Text = "Add Device";
            this.buttonAddDevice.UseVisualStyleBackColor = true;
            this.buttonAddDevice.Click += new System.EventHandler(this.buttonAddDevice_Click);

            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEvents.Location = new System.Drawing.Point(20, 250);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(74, 28);
            this.labelEvents.TabIndex = 8;
            this.labelEvents.Text = "Events";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(20, 285);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(400, 120);
            this.listBoxEvents.TabIndex = 9;
            // 
            // buttonLoadEvents
            // 
            this.buttonLoadEvents.Location = new System.Drawing.Point(320, 415);
            this.buttonLoadEvents.Name = "buttonLoadEvents";
            this.buttonLoadEvents.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadEvents.TabIndex = 10;
            this.buttonLoadEvents.Text = "Load Events";
            this.buttonLoadEvents.UseVisualStyleBackColor = true;
            this.buttonLoadEvents.Click += new System.EventHandler(this.buttonLoadEvents_Click);
            // 
            // buttonAckEvent
            // 
            this.buttonAckEvent.Location = new System.Drawing.Point(440, 285);
            this.buttonAckEvent.Name = "buttonAckEvent";
            this.buttonAckEvent.Size = new System.Drawing.Size(180, 30);
            this.buttonAckEvent.TabIndex = 11;
            this.buttonAckEvent.Text = "Acknowledge Event";
            this.buttonAckEvent.UseVisualStyleBackColor = true;
            this.buttonAckEvent.Click += new System.EventHandler(this.buttonAckEvent_Click);
            // 
            // buttonResolveEvent
            // 
            this.buttonResolveEvent.Location = new System.Drawing.Point(440, 325);
            this.buttonResolveEvent.Name = "buttonResolveEvent";
            this.buttonResolveEvent.Size = new System.Drawing.Size(180, 30);
            this.buttonResolveEvent.TabIndex = 12;
            this.buttonResolveEvent.Text = "Resolve Event";
            this.buttonResolveEvent.UseVisualStyleBackColor = true;
            this.buttonResolveEvent.Click += new System.EventHandler(this.buttonResolveEvent_Click);
            // 
            // labelEventMessage
            // 
            this.labelEventMessage.AutoSize = true;
            this.labelEventMessage.Location = new System.Drawing.Point(440, 370);
            this.labelEventMessage.Name = "labelEventMessage";
            this.labelEventMessage.Size = new System.Drawing.Size(108, 20);
            this.labelEventMessage.TabIndex = 13;
            this.labelEventMessage.Text = "Event Message";
            // 
            // textBoxEventMessage
            // 
            this.textBoxEventMessage.Location = new System.Drawing.Point(440, 395);
            this.textBoxEventMessage.Name = "textBoxEventMessage";
            this.textBoxEventMessage.Size = new System.Drawing.Size(180, 27);
            this.textBoxEventMessage.TabIndex = 14;
            // 
            // buttonTriggerEvent
            // 
            this.buttonTriggerEvent.Location = new System.Drawing.Point(440, 430);
            this.buttonTriggerEvent.Name = "buttonTriggerEvent";
            this.buttonTriggerEvent.Size = new System.Drawing.Size(180, 30);
            this.buttonTriggerEvent.TabIndex = 15;
            this.buttonTriggerEvent.Text = "Trigger Event";
            this.buttonTriggerEvent.UseVisualStyleBackColor = true;
            this.buttonTriggerEvent.Click += new System.EventHandler(this.buttonTriggerEvent_Click);

            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.textBoxDeviceName);
            this.Controls.Add(this.labelDeviceType);
            this.Controls.Add(this.textBoxDeviceType);
            this.Controls.Add(this.buttonAddDevice);

            // Add event controls
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonLoadEvents);
            this.Controls.Add(this.buttonAckEvent);
            this.Controls.Add(this.buttonResolveEvent);
            this.Controls.Add(this.labelEventMessage);
            this.Controls.Add(this.textBoxEventMessage);
            this.Controls.Add(this.buttonTriggerEvent);

            this.Name = "MainForm";
            this.Text = "Device Monitoring System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
