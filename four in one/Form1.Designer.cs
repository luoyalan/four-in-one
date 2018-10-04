namespace four_in_one
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
            this.panelSerialPort = new System.Windows.Forms.Panel();
            this.SerialPortBaudrate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SPconnet = new System.Windows.Forms.Button();
            this.SelectCOM = new System.Windows.Forms.DomainUpDown();
            this.panelTCP = new System.Windows.Forms.Panel();
            this.ShowMyIP = new System.Windows.Forms.Button();
            this.PortTCP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPTCP = new System.Windows.Forms.TextBox();
            this.AlsTCPClient = new System.Windows.Forms.RadioButton();
            this.ConnectToTCPServer = new System.Windows.Forms.Button();
            this.StartTCPServer = new System.Windows.Forms.Button();
            this.AlsTCPServer = new System.Windows.Forms.RadioButton();
            this.oSerialPort = new System.Windows.Forms.RadioButton();
            this.oTCP = new System.Windows.Forms.RadioButton();
            this.MessageToSend = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.Label();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSerialPort.SuspendLayout();
            this.panelTCP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSerialPort
            // 
            this.panelSerialPort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSerialPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSerialPort.Controls.Add(this.SerialPortBaudrate);
            this.panelSerialPort.Controls.Add(this.label4);
            this.panelSerialPort.Controls.Add(this.SPconnet);
            this.panelSerialPort.Controls.Add(this.SelectCOM);
            this.panelSerialPort.Location = new System.Drawing.Point(103, 76);
            this.panelSerialPort.Name = "panelSerialPort";
            this.panelSerialPort.Size = new System.Drawing.Size(352, 126);
            this.panelSerialPort.TabIndex = 0;
            // 
            // SerialPortBaudrate
            // 
            this.SerialPortBaudrate.Location = new System.Drawing.Point(20, 70);
            this.SerialPortBaudrate.Name = "SerialPortBaudrate";
            this.SerialPortBaudrate.Size = new System.Drawing.Size(52, 20);
            this.SerialPortBaudrate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Serial Port Baudrate:";
            // 
            // SPconnet
            // 
            this.SPconnet.Location = new System.Drawing.Point(214, 27);
            this.SPconnet.Name = "SPconnet";
            this.SPconnet.Size = new System.Drawing.Size(78, 50);
            this.SPconnet.TabIndex = 1;
            this.SPconnet.Text = "Connect";
            this.SPconnet.UseVisualStyleBackColor = true;
            this.SPconnet.Click += new System.EventHandler(this.SPconnet_Click);
            // 
            // SelectCOM
            // 
            this.SelectCOM.Location = new System.Drawing.Point(20, 22);
            this.SelectCOM.Name = "SelectCOM";
            this.SelectCOM.Size = new System.Drawing.Size(132, 20);
            this.SelectCOM.TabIndex = 0;
            this.SelectCOM.Text = "Select COM";
            // 
            // panelTCP
            // 
            this.panelTCP.BackColor = System.Drawing.SystemColors.Info;
            this.panelTCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTCP.Controls.Add(this.ShowMyIP);
            this.panelTCP.Controls.Add(this.PortTCP);
            this.panelTCP.Controls.Add(this.label3);
            this.panelTCP.Controls.Add(this.label2);
            this.panelTCP.Controls.Add(this.IPTCP);
            this.panelTCP.Controls.Add(this.AlsTCPClient);
            this.panelTCP.Controls.Add(this.ConnectToTCPServer);
            this.panelTCP.Controls.Add(this.StartTCPServer);
            this.panelTCP.Controls.Add(this.AlsTCPServer);
            this.panelTCP.Location = new System.Drawing.Point(103, 246);
            this.panelTCP.Name = "panelTCP";
            this.panelTCP.Size = new System.Drawing.Size(352, 152);
            this.panelTCP.TabIndex = 1;
            // 
            // ShowMyIP
            // 
            this.ShowMyIP.Location = new System.Drawing.Point(20, 68);
            this.ShowMyIP.Name = "ShowMyIP";
            this.ShowMyIP.Size = new System.Drawing.Size(128, 51);
            this.ShowMyIP.TabIndex = 12;
            this.ShowMyIP.Text = "Show IP Address from this PC";
            this.ShowMyIP.UseVisualStyleBackColor = true;
            this.ShowMyIP.Click += new System.EventHandler(this.ShowMyIP_Click);
            // 
            // PortTCP
            // 
            this.PortTCP.Location = new System.Drawing.Point(226, 84);
            this.PortTCP.Name = "PortTCP";
            this.PortTCP.Size = new System.Drawing.Size(69, 20);
            this.PortTCP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP:";
            // 
            // IPTCP
            // 
            this.IPTCP.Location = new System.Drawing.Point(226, 45);
            this.IPTCP.Name = "IPTCP";
            this.IPTCP.Size = new System.Drawing.Size(76, 20);
            this.IPTCP.TabIndex = 4;
            // 
            // AlsTCPClient
            // 
            this.AlsTCPClient.AutoSize = true;
            this.AlsTCPClient.Location = new System.Drawing.Point(201, 10);
            this.AlsTCPClient.Name = "AlsTCPClient";
            this.AlsTCPClient.Size = new System.Drawing.Size(67, 17);
            this.AlsTCPClient.TabIndex = 1;
            this.AlsTCPClient.TabStop = true;
            this.AlsTCPClient.Text = "als Client";
            this.AlsTCPClient.UseVisualStyleBackColor = true;
            // 
            // ConnectToTCPServer
            // 
            this.ConnectToTCPServer.Location = new System.Drawing.Point(203, 114);
            this.ConnectToTCPServer.Name = "ConnectToTCPServer";
            this.ConnectToTCPServer.Size = new System.Drawing.Size(99, 25);
            this.ConnectToTCPServer.TabIndex = 3;
            this.ConnectToTCPServer.Text = "Connet to Server";
            this.ConnectToTCPServer.UseVisualStyleBackColor = true;
            this.ConnectToTCPServer.Click += new System.EventHandler(this.ConnectToTCPServer_Click);
            // 
            // StartTCPServer
            // 
            this.StartTCPServer.Location = new System.Drawing.Point(102, 10);
            this.StartTCPServer.Name = "StartTCPServer";
            this.StartTCPServer.Size = new System.Drawing.Size(78, 26);
            this.StartTCPServer.TabIndex = 2;
            this.StartTCPServer.Text = "Start Server";
            this.StartTCPServer.UseVisualStyleBackColor = true;
            this.StartTCPServer.Click += new System.EventHandler(this.StartTCPServer_Click);
            // 
            // AlsTCPServer
            // 
            this.AlsTCPServer.AutoSize = true;
            this.AlsTCPServer.Location = new System.Drawing.Point(3, 10);
            this.AlsTCPServer.Name = "AlsTCPServer";
            this.AlsTCPServer.Size = new System.Drawing.Size(72, 17);
            this.AlsTCPServer.TabIndex = 0;
            this.AlsTCPServer.TabStop = true;
            this.AlsTCPServer.Text = "als Server";
            this.AlsTCPServer.UseVisualStyleBackColor = true;
            // 
            // oSerialPort
            // 
            this.oSerialPort.AutoSize = true;
            this.oSerialPort.Location = new System.Drawing.Point(8, 76);
            this.oSerialPort.Name = "oSerialPort";
            this.oSerialPort.Size = new System.Drawing.Size(73, 17);
            this.oSerialPort.TabIndex = 2;
            this.oSerialPort.TabStop = true;
            this.oSerialPort.Text = "Serial Port";
            this.oSerialPort.UseVisualStyleBackColor = true;
            // 
            // oTCP
            // 
            this.oTCP.AutoSize = true;
            this.oTCP.Location = new System.Drawing.Point(8, 246);
            this.oTCP.Name = "oTCP";
            this.oTCP.Size = new System.Drawing.Size(46, 17);
            this.oTCP.TabIndex = 3;
            this.oTCP.TabStop = true;
            this.oTCP.Text = "TCP";
            this.oTCP.UseVisualStyleBackColor = true;
            // 
            // MessageToSend
            // 
            this.MessageToSend.Location = new System.Drawing.Point(523, 246);
            this.MessageToSend.Name = "MessageToSend";
            this.MessageToSend.Size = new System.Drawing.Size(236, 20);
            this.MessageToSend.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(679, 272);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(80, 40);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(523, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 121);
            this.listBox1.TabIndex = 6;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(520, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(38, 16);
            this.Info.TabIndex = 7;
            this.Info.Text = "INFO";
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(576, 361);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(122, 60);
            this.CloseConnection.TabIndex = 8;
            this.CloseConnection.Text = "Close Connection";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Write Message here";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(337, 19);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(91, 22);
            this.Confirm.TabIndex = 10;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Please select a protocol and click Confirm button";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseConnection);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MessageToSend);
            this.Controls.Add(this.oTCP);
            this.Controls.Add(this.oSerialPort);
            this.Controls.Add(this.panelTCP);
            this.Controls.Add(this.panelSerialPort);
            this.Name = "Form1";
            this.Text = "Four in one";
            this.panelSerialPort.ResumeLayout(false);
            this.panelSerialPort.PerformLayout();
            this.panelTCP.ResumeLayout(false);
            this.panelTCP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSerialPort;
        private System.Windows.Forms.DomainUpDown SelectCOM;
        private System.Windows.Forms.Panel panelTCP;
        private System.Windows.Forms.Button ConnectToTCPServer;
        private System.Windows.Forms.Button StartTCPServer;
        private System.Windows.Forms.RadioButton AlsTCPClient;
        private System.Windows.Forms.RadioButton AlsTCPServer;
        private System.Windows.Forms.RadioButton oSerialPort;
        private System.Windows.Forms.RadioButton oTCP;
        private System.Windows.Forms.TextBox MessageToSend;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button CloseConnection;
        private System.Windows.Forms.TextBox SerialPortBaudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SPconnet;
        private System.Windows.Forms.TextBox PortTCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPTCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShowMyIP;
    }
}

