namespace VAH
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
            System.Windows.Forms.Button startButton;
            System.Windows.Forms.Button stopButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.comPortSpeedComboBox = new System.Windows.Forms.ComboBox();
            this.xScaleInput = new System.Windows.Forms.TextBox();
            this.xScaleComboBox = new System.Windows.Forms.ComboBox();
            this.yScaleComboBox = new System.Windows.Forms.ComboBox();
            this.yScaleInput = new System.Windows.Forms.TextBox();
            this.whiteWithBlackGrid = new System.Windows.Forms.RadioButton();
            this.blackWithWhiteGrid = new System.Windows.Forms.RadioButton();
            this.BackgroundColor = new System.Windows.Forms.GroupBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.exportValuesButton = new System.Windows.Forms.Button();
            this.lineColorComboBox = new System.Windows.Forms.ComboBox();
            this.lineColorBox = new System.Windows.Forms.GroupBox();
            this.comPortBox = new System.Windows.Forms.GroupBox();
            this.comPortSpeedBox = new System.Windows.Forms.GroupBox();
            this.xScaleBox = new System.Windows.Forms.GroupBox();
            this.yScaleBox = new System.Windows.Forms.GroupBox();
            this.resistorValues = new System.Windows.Forms.ListBox();
            this.SaveValuesButton = new System.Windows.Forms.Button();
            startButton = new System.Windows.Forms.Button();
            stopButton = new System.Windows.Forms.Button();
            this.BackgroundColor.SuspendLayout();
            this.lineColorBox.SuspendLayout();
            this.comPortBox.SuspendLayout();
            this.comPortSpeedBox.SuspendLayout();
            this.xScaleBox.SuspendLayout();
            this.yScaleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(598, 229);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(62, 31);
            startButton.TabIndex = 15;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // stopButton
            // 
            stopButton.Location = new System.Drawing.Point(662, 229);
            stopButton.Name = "stopButton";
            stopButton.Size = new System.Drawing.Size(62, 31);
            stopButton.TabIndex = 26;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(2, 2);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(575, 546);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12"});
            this.comPortComboBox.Location = new System.Drawing.Point(14, 19);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.comPortComboBox.TabIndex = 2;
            this.comPortComboBox.SelectedIndexChanged += new System.EventHandler(this.comPortComboBox_SelectedIndexChanged);
            // 
            // comPortSpeedComboBox
            // 
            this.comPortSpeedComboBox.FormattingEnabled = true;
            this.comPortSpeedComboBox.Items.AddRange(new object[] {
            "128000 bit/s",
            "115200 bit/s",
            "57600 bit/s",
            "38400 bit/s",
            "19200 bit/s",
            "14400 bit/s",
            "9600 bit/s",
            "7200 bit/s",
            "4800 bit/s",
            "2400 bit/s",
            "1800 bit/s",
            "1200 bit/s",
            "600 bit/s",
            "300 bit/s"});
            this.comPortSpeedComboBox.Location = new System.Drawing.Point(6, 19);
            this.comPortSpeedComboBox.Name = "comPortSpeedComboBox";
            this.comPortSpeedComboBox.Size = new System.Drawing.Size(121, 21);
            this.comPortSpeedComboBox.TabIndex = 5;
            this.comPortSpeedComboBox.SelectedIndexChanged += new System.EventHandler(this.comPortSpeedComboBox_SelectedIndexChanged);
            // 
            // xScaleInput
            // 
            this.xScaleInput.Location = new System.Drawing.Point(15, 18);
            this.xScaleInput.Name = "xScaleInput";
            this.xScaleInput.Size = new System.Drawing.Size(44, 20);
            this.xScaleInput.TabIndex = 6;
            this.xScaleInput.Text = "1";
            this.xScaleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xScaleComboBox
            // 
            this.xScaleComboBox.FormattingEnabled = true;
            this.xScaleComboBox.Items.AddRange(new object[] {
            "V/div",
            "mV/div",
            "mkV/div"});
            this.xScaleComboBox.Location = new System.Drawing.Point(64, 18);
            this.xScaleComboBox.Name = "xScaleComboBox";
            this.xScaleComboBox.Size = new System.Drawing.Size(121, 21);
            this.xScaleComboBox.TabIndex = 8;
            this.xScaleComboBox.SelectedIndexChanged += new System.EventHandler(this.xScaleComboBox_SelectedIndexChanged);
            // 
            // yScaleComboBox
            // 
            this.yScaleComboBox.FormattingEnabled = true;
            this.yScaleComboBox.Items.AddRange(new object[] {
            "A/div",
            "mA/div",
            "mkA/div"});
            this.yScaleComboBox.Location = new System.Drawing.Point(63, 18);
            this.yScaleComboBox.Name = "yScaleComboBox";
            this.yScaleComboBox.Size = new System.Drawing.Size(121, 21);
            this.yScaleComboBox.TabIndex = 11;
            this.yScaleComboBox.SelectedIndexChanged += new System.EventHandler(this.yScaleComboBox_SelectedIndexChanged);
            // 
            // yScaleInput
            // 
            this.yScaleInput.Location = new System.Drawing.Point(14, 18);
            this.yScaleInput.Name = "yScaleInput";
            this.yScaleInput.Size = new System.Drawing.Size(44, 20);
            this.yScaleInput.TabIndex = 9;
            this.yScaleInput.Text = "100";
            this.yScaleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // whiteWithBlackGrid
            // 
            this.whiteWithBlackGrid.AutoSize = true;
            this.whiteWithBlackGrid.Location = new System.Drawing.Point(14, 42);
            this.whiteWithBlackGrid.Name = "whiteWithBlackGrid";
            this.whiteWithBlackGrid.Size = new System.Drawing.Size(124, 17);
            this.whiteWithBlackGrid.TabIndex = 12;
            this.whiteWithBlackGrid.Text = "White with black grid";
            this.whiteWithBlackGrid.UseVisualStyleBackColor = true;
            this.whiteWithBlackGrid.CheckedChanged += new System.EventHandler(this.buttonGroup_CheckedChanged);
            // 
            // blackWithWhiteGrid
            // 
            this.blackWithWhiteGrid.AutoSize = true;
            this.blackWithWhiteGrid.Checked = true;
            this.blackWithWhiteGrid.Location = new System.Drawing.Point(14, 19);
            this.blackWithWhiteGrid.Name = "blackWithWhiteGrid";
            this.blackWithWhiteGrid.Size = new System.Drawing.Size(122, 17);
            this.blackWithWhiteGrid.TabIndex = 13;
            this.blackWithWhiteGrid.TabStop = true;
            this.blackWithWhiteGrid.Text = "Black with white grid";
            this.blackWithWhiteGrid.UseVisualStyleBackColor = false;
            this.blackWithWhiteGrid.CheckedChanged += new System.EventHandler(this.buttonGroup_CheckedChanged);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.Controls.Add(this.blackWithWhiteGrid);
            this.BackgroundColor.Controls.Add(this.whiteWithBlackGrid);
            this.BackgroundColor.Location = new System.Drawing.Point(584, 160);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(147, 63);
            this.BackgroundColor.TabIndex = 14;
            this.BackgroundColor.TabStop = false;
            this.BackgroundColor.Text = "Background Color";
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(736, 229);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(66, 31);
            this.saveImageButton.TabIndex = 16;
            this.saveImageButton.Text = ".jpg";
            this.saveImageButton.UseVisualStyleBackColor = true;
            // 
            // exportValuesButton
            // 
            this.exportValuesButton.Location = new System.Drawing.Point(597, 517);
            this.exportValuesButton.Name = "exportValuesButton";
            this.exportValuesButton.Size = new System.Drawing.Size(121, 31);
            this.exportValuesButton.TabIndex = 17;
            this.exportValuesButton.Text = "Export Rd values";
            this.exportValuesButton.UseVisualStyleBackColor = true;
            // 
            // lineColorComboBox
            // 
            this.lineColorComboBox.FormattingEnabled = true;
            this.lineColorComboBox.Items.AddRange(new object[] {
            "Red",
            "Black",
            "White",
            "Blue",
            "Purple",
            "Yellow"});
            this.lineColorComboBox.Location = new System.Drawing.Point(6, 19);
            this.lineColorComboBox.Name = "lineColorComboBox";
            this.lineColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.lineColorComboBox.TabIndex = 18;
            this.lineColorComboBox.SelectedIndexChanged += new System.EventHandler(this.lineColorComboBox_SelectedIndexChanged);
            // 
            // lineColorBox
            // 
            this.lineColorBox.Controls.Add(this.lineColorComboBox);
            this.lineColorBox.Location = new System.Drawing.Point(743, 160);
            this.lineColorBox.Name = "lineColorBox";
            this.lineColorBox.Size = new System.Drawing.Size(140, 63);
            this.lineColorBox.TabIndex = 19;
            this.lineColorBox.TabStop = false;
            this.lineColorBox.Text = "Line color";
            // 
            // comPortBox
            // 
            this.comPortBox.Controls.Add(this.comPortComboBox);
            this.comPortBox.Location = new System.Drawing.Point(583, 2);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(148, 46);
            this.comPortBox.TabIndex = 20;
            this.comPortBox.TabStop = false;
            this.comPortBox.Text = "COM-Port";
            // 
            // comPortSpeedBox
            // 
            this.comPortSpeedBox.Controls.Add(this.comPortSpeedComboBox);
            this.comPortSpeedBox.Location = new System.Drawing.Point(743, 2);
            this.comPortSpeedBox.Name = "comPortSpeedBox";
            this.comPortSpeedBox.Size = new System.Drawing.Size(140, 46);
            this.comPortSpeedBox.TabIndex = 21;
            this.comPortSpeedBox.TabStop = false;
            this.comPortSpeedBox.Text = "COM-Port speed";
            // 
            // xScaleBox
            // 
            this.xScaleBox.Controls.Add(this.xScaleInput);
            this.xScaleBox.Controls.Add(this.xScaleComboBox);
            this.xScaleBox.Location = new System.Drawing.Point(647, 54);
            this.xScaleBox.Name = "xScaleBox";
            this.xScaleBox.Size = new System.Drawing.Size(200, 48);
            this.xScaleBox.TabIndex = 22;
            this.xScaleBox.TabStop = false;
            this.xScaleBox.Text = "X-Scale ";
            // 
            // yScaleBox
            // 
            this.yScaleBox.Controls.Add(this.yScaleInput);
            this.yScaleBox.Controls.Add(this.yScaleComboBox);
            this.yScaleBox.Location = new System.Drawing.Point(647, 106);
            this.yScaleBox.Name = "yScaleBox";
            this.yScaleBox.Size = new System.Drawing.Size(200, 48);
            this.yScaleBox.TabIndex = 23;
            this.yScaleBox.TabStop = false;
            this.yScaleBox.Text = "Y-Scale";
            // 
            // resistorValues
            // 
            this.resistorValues.FormattingEnabled = true;
            this.resistorValues.Location = new System.Drawing.Point(597, 266);
            this.resistorValues.Name = "resistorValues";
            this.resistorValues.Size = new System.Drawing.Size(286, 238);
            this.resistorValues.TabIndex = 24;
            // 
            // SaveValuesButton
            // 
            this.SaveValuesButton.Location = new System.Drawing.Point(817, 229);
            this.SaveValuesButton.Name = "SaveValuesButton";
            this.SaveValuesButton.Size = new System.Drawing.Size(66, 31);
            this.SaveValuesButton.TabIndex = 25;
            this.SaveValuesButton.Text = ".txt";
            this.SaveValuesButton.UseVisualStyleBackColor = true;
            this.SaveValuesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(897, 560);
            this.Controls.Add(stopButton);
            this.Controls.Add(this.SaveValuesButton);
            this.Controls.Add(this.resistorValues);
            this.Controls.Add(this.yScaleBox);
            this.Controls.Add(this.xScaleBox);
            this.Controls.Add(this.comPortSpeedBox);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.lineColorBox);
            this.Controls.Add(this.exportValuesButton);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(startButton);
            this.Controls.Add(this.BackgroundColor);
            this.Controls.Add(this.AnT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C-V Сhr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundColor.ResumeLayout(false);
            this.BackgroundColor.PerformLayout();
            this.lineColorBox.ResumeLayout(false);
            this.comPortBox.ResumeLayout(false);
            this.comPortSpeedBox.ResumeLayout(false);
            this.xScaleBox.ResumeLayout(false);
            this.xScaleBox.PerformLayout();
            this.yScaleBox.ResumeLayout(false);
            this.yScaleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.ComboBox comPortSpeedComboBox;
        private System.Windows.Forms.TextBox xScaleInput;
        private System.Windows.Forms.ComboBox xScaleComboBox;
        private System.Windows.Forms.ComboBox yScaleComboBox;
        private System.Windows.Forms.TextBox yScaleInput;
        private System.Windows.Forms.RadioButton whiteWithBlackGrid;
        private System.Windows.Forms.RadioButton blackWithWhiteGrid;
        private System.Windows.Forms.GroupBox BackgroundColor;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button exportValuesButton;
        private System.Windows.Forms.ComboBox lineColorComboBox;
        private System.Windows.Forms.GroupBox lineColorBox;
        private System.Windows.Forms.GroupBox comPortBox;
        private System.Windows.Forms.GroupBox comPortSpeedBox;
        private System.Windows.Forms.GroupBox xScaleBox;
        private System.Windows.Forms.GroupBox yScaleBox;
        private System.Windows.Forms.ListBox resistorValues;
        private System.Windows.Forms.Button SaveValuesButton;
    }
}

