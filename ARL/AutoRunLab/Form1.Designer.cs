namespace AutoRunLab
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConstV = new System.Windows.Forms.Label();
            this.numericUpDownConst = new System.Windows.Forms.NumericUpDown();
            this.labelConst = new System.Windows.Forms.Label();
            this.labelmA = new System.Windows.Forms.Label();
            this.labelImax = new System.Windows.Forms.Label();
            this.numericUpDownImax = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonnpn = new System.Windows.Forms.RadioButton();
            this.radioButtonpnp = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSt = new System.Windows.Forms.CheckBox();
            this.checkBoxRe = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxChart = new System.Windows.Forms.TextBox();
            this.labelChart = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.radioButtonTransistor = new System.Windows.Forms.RadioButton();
            this.radioButtonDiod = new System.Windows.Forms.RadioButton();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxGraf = new System.Windows.Forms.GroupBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.trackBarMinusU = new System.Windows.Forms.TrackBar();
            this.trackBarMinusI = new System.Windows.Forms.TrackBar();
            this.labelScaleU = new System.Windows.Forms.Label();
            this.labelScaleI = new System.Windows.Forms.Label();
            this.groupBoxScale = new System.Windows.Forms.GroupBox();
            this.labelPlusI = new System.Windows.Forms.Label();
            this.labelMinusI = new System.Windows.Forms.Label();
            this.labelZeroI = new System.Windows.Forms.Label();
            this.labelPlusU = new System.Windows.Forms.Label();
            this.labelMinusU = new System.Windows.Forms.Label();
            this.labelZeroU = new System.Windows.Forms.Label();
            this.trackBarPlusI = new System.Windows.Forms.TrackBar();
            this.trackBarPlusU = new System.Windows.Forms.TrackBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImax)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxGraf.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinusU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinusI)).BeginInit();
            this.groupBoxScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlusI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlusU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.MaximumAutoSize = 70F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "U, B";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 8F);
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.MaximumAutoSize = 70F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "I, mA";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 8F);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 1);
            this.chart1.Name = "chart1";
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Teal,
        System.Drawing.Color.Black,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Silver,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "серия";
            series1.Points.Add(dataPoint1);
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(652, 498);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1esfse";
            this.chart1.Titles.Add(title1);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Location = new System.Drawing.Point(659, 25);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Подключение";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisconnect.Location = new System.Drawing.Point(758, 25);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(85, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Отключить";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStatus.AutoCheck = false;
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxStatus.Location = new System.Drawing.Point(849, 9);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStatus.TabIndex = 4;
            this.checkBoxStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            this.checkBoxStatus.CheckedChanged += new System.EventHandler(this.checkBoxStatus_CheckedChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(16, 258);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(103, 27);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Измерить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelConstV);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Controls.Add(this.numericUpDownConst);
            this.panel1.Controls.Add(this.labelConst);
            this.panel1.Controls.Add(this.labelmA);
            this.panel1.Controls.Add(this.labelImax);
            this.panel1.Controls.Add(this.numericUpDownImax);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(660, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 292);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Команда:";
            // 
            // labelConstV
            // 
            this.labelConstV.AutoSize = true;
            this.labelConstV.Location = new System.Drawing.Point(249, 272);
            this.labelConstV.Name = "labelConstV";
            this.labelConstV.Size = new System.Drawing.Size(14, 13);
            this.labelConstV.TabIndex = 12;
            this.labelConstV.Text = "B";
            // 
            // numericUpDownConst
            // 
            this.numericUpDownConst.Location = new System.Drawing.Point(176, 270);
            this.numericUpDownConst.Name = "numericUpDownConst";
            this.numericUpDownConst.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownConst.TabIndex = 11;
            // 
            // labelConst
            // 
            this.labelConst.AutoSize = true;
            this.labelConst.Location = new System.Drawing.Point(140, 272);
            this.labelConst.Name = "labelConst";
            this.labelConst.Size = new System.Drawing.Size(30, 13);
            this.labelConst.TabIndex = 10;
            this.labelConst.Text = "Uкэ:";
            // 
            // labelmA
            // 
            this.labelmA.AutoSize = true;
            this.labelmA.Location = new System.Drawing.Point(102, 195);
            this.labelmA.Name = "labelmA";
            this.labelmA.Size = new System.Drawing.Size(22, 13);
            this.labelmA.TabIndex = 9;
            this.labelmA.Text = "mA";
            // 
            // labelImax
            // 
            this.labelImax.AutoSize = true;
            this.labelImax.Location = new System.Drawing.Point(15, 195);
            this.labelImax.Name = "labelImax";
            this.labelImax.Size = new System.Drawing.Size(32, 13);
            this.labelImax.TabIndex = 8;
            this.labelImax.Text = "Imax:";
            // 
            // numericUpDownImax
            // 
            this.numericUpDownImax.Location = new System.Drawing.Point(53, 193);
            this.numericUpDownImax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownImax.Name = "numericUpDownImax";
            this.numericUpDownImax.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownImax.TabIndex = 7;
            this.numericUpDownImax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonOut);
            this.groupBox4.Controls.Add(this.radioButtonIn);
            this.groupBox4.Location = new System.Drawing.Point(134, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 64);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вид характеристики";
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Location = new System.Drawing.Point(6, 42);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(75, 17);
            this.radioButtonOut.TabIndex = 1;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Выходная";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Location = new System.Drawing.Point(6, 19);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(67, 17);
            this.radioButtonIn.TabIndex = 0;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "Входная";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            this.radioButtonIn.CheckedChanged += new System.EventHandler(this.radioButtonIn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonnpn);
            this.groupBox3.Controls.Add(this.radioButtonpnp);
            this.groupBox3.Location = new System.Drawing.Point(134, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 65);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип";
            // 
            // radioButtonnpn
            // 
            this.radioButtonnpn.AutoSize = true;
            this.radioButtonnpn.Location = new System.Drawing.Point(6, 18);
            this.radioButtonnpn.Name = "radioButtonnpn";
            this.radioButtonnpn.Size = new System.Drawing.Size(43, 17);
            this.radioButtonnpn.TabIndex = 1;
            this.radioButtonnpn.TabStop = true;
            this.radioButtonnpn.Text = "npn";
            this.radioButtonnpn.UseVisualStyleBackColor = true;
            // 
            // radioButtonpnp
            // 
            this.radioButtonpnp.AutoSize = true;
            this.radioButtonpnp.Location = new System.Drawing.Point(6, 41);
            this.radioButtonpnp.Name = "radioButtonpnp";
            this.radioButtonpnp.Size = new System.Drawing.Size(43, 17);
            this.radioButtonpnp.TabIndex = 0;
            this.radioButtonpnp.TabStop = true;
            this.radioButtonpnp.Text = "pnp";
            this.radioButtonpnp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSt);
            this.groupBox2.Controls.Add(this.checkBoxRe);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ветви";
            // 
            // checkBoxSt
            // 
            this.checkBoxSt.AutoSize = true;
            this.checkBoxSt.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSt.Name = "checkBoxSt";
            this.checkBoxSt.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSt.TabIndex = 2;
            this.checkBoxSt.Text = "Прямая";
            this.checkBoxSt.UseVisualStyleBackColor = true;
            // 
            // checkBoxRe
            // 
            this.checkBoxRe.AutoSize = true;
            this.checkBoxRe.Location = new System.Drawing.Point(6, 42);
            this.checkBoxRe.Name = "checkBoxRe";
            this.checkBoxRe.Size = new System.Drawing.Size(75, 17);
            this.checkBoxRe.TabIndex = 3;
            this.checkBoxRe.Text = "Обратная";
            this.checkBoxRe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxChart);
            this.groupBox1.Controls.Add(this.labelChart);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.radioButtonTransistor);
            this.groupBox1.Controls.Add(this.radioButtonDiod);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элемент";
            // 
            // textBoxChart
            // 
            this.textBoxChart.Location = new System.Drawing.Point(119, 24);
            this.textBoxChart.Name = "textBoxChart";
            this.textBoxChart.Size = new System.Drawing.Size(154, 20);
            this.textBoxChart.TabIndex = 5;
            this.textBoxChart.TextChanged += new System.EventHandler(this.textBoxChart_TextChanged);
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Location = new System.Drawing.Point(7, 27);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(106, 13);
            this.labelChart.TabIndex = 4;
            this.labelChart.Text = "Название графика:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя серии:";
            // 
            // radioButtonTransistor
            // 
            this.radioButtonTransistor.AutoSize = true;
            this.radioButtonTransistor.Location = new System.Drawing.Point(115, 84);
            this.radioButtonTransistor.Name = "radioButtonTransistor";
            this.radioButtonTransistor.Size = new System.Drawing.Size(119, 17);
            this.radioButtonTransistor.TabIndex = 1;
            this.radioButtonTransistor.TabStop = true;
            this.radioButtonTransistor.Text = "Четырехполюсник";
            this.radioButtonTransistor.UseVisualStyleBackColor = true;
            this.radioButtonTransistor.CheckedChanged += new System.EventHandler(this.radioButtonTransistor_CheckedChanged);
            // 
            // radioButtonDiod
            // 
            this.radioButtonDiod.AutoSize = true;
            this.radioButtonDiod.Location = new System.Drawing.Point(9, 84);
            this.radioButtonDiod.Name = "radioButtonDiod";
            this.radioButtonDiod.Size = new System.Drawing.Size(100, 17);
            this.radioButtonDiod.TabIndex = 0;
            this.radioButtonDiod.TabStop = true;
            this.radioButtonDiod.Text = "Двухполюсник";
            this.radioButtonDiod.UseVisualStyleBackColor = true;
            this.radioButtonDiod.CheckedChanged += new System.EventHandler(this.radioButtonDiod_CheckedChanged);
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.Location = new System.Drawing.Point(6, 69);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(78, 23);
            this.buttonClearChart.TabIndex = 9;
            this.buttonClearChart.Text = "Очистить";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.buttonClearChart_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnect.AutoSize = true;
            this.labelConnect.Location = new System.Drawing.Point(657, 9);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(114, 13);
            this.labelConnect.TabIndex = 10;
            this.labelConnect.Text = "Статус подключения:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(6, 24);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxGraf
            // 
            this.groupBoxGraf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxGraf.Controls.Add(this.buttonSave);
            this.groupBoxGraf.Controls.Add(this.buttonClearChart);
            this.groupBoxGraf.Location = new System.Drawing.Point(462, 505);
            this.groupBoxGraf.Name = "groupBoxGraf";
            this.groupBoxGraf.Size = new System.Drawing.Size(94, 114);
            this.groupBoxGraf.TabIndex = 12;
            this.groupBoxGraf.TabStop = false;
            this.groupBoxGraf.Text = "График";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxData.Controls.Add(this.buttonSaveData);
            this.groupBoxData.Controls.Add(this.button4);
            this.groupBoxData.Location = new System.Drawing.Point(562, 505);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(92, 114);
            this.groupBoxData.TabIndex = 14;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(8, 24);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(78, 23);
            this.buttonSaveData.TabIndex = 0;
            this.buttonSaveData.Text = "Сохранить";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // trackBarMinusU
            // 
            this.trackBarMinusU.Location = new System.Drawing.Point(49, 19);
            this.trackBarMinusU.Maximum = 0;
            this.trackBarMinusU.Minimum = -10;
            this.trackBarMinusU.Name = "trackBarMinusU";
            this.trackBarMinusU.Size = new System.Drawing.Size(176, 45);
            this.trackBarMinusU.TabIndex = 15;
            this.trackBarMinusU.Value = -10;
            this.trackBarMinusU.Scroll += new System.EventHandler(this.trackBarMinusU_Scroll);
            // 
            // trackBarMinusI
            // 
            this.trackBarMinusI.Location = new System.Drawing.Point(49, 62);
            this.trackBarMinusI.Maximum = -1;
            this.trackBarMinusI.Minimum = -10;
            this.trackBarMinusI.Name = "trackBarMinusI";
            this.trackBarMinusI.Size = new System.Drawing.Size(176, 45);
            this.trackBarMinusI.TabIndex = 16;
            this.trackBarMinusI.Value = -10;
            this.trackBarMinusI.Scroll += new System.EventHandler(this.trackBarMinusI_Scroll);
            // 
            // labelScaleU
            // 
            this.labelScaleU.AutoSize = true;
            this.labelScaleU.Location = new System.Drawing.Point(7, 24);
            this.labelScaleU.Name = "labelScaleU";
            this.labelScaleU.Size = new System.Drawing.Size(18, 13);
            this.labelScaleU.TabIndex = 18;
            this.labelScaleU.Text = "U:";
            // 
            // labelScaleI
            // 
            this.labelScaleI.AutoSize = true;
            this.labelScaleI.Location = new System.Drawing.Point(7, 69);
            this.labelScaleI.Name = "labelScaleI";
            this.labelScaleI.Size = new System.Drawing.Size(13, 13);
            this.labelScaleI.TabIndex = 19;
            this.labelScaleI.Text = "I:";
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxScale.Controls.Add(this.labelPlusI);
            this.groupBoxScale.Controls.Add(this.labelMinusI);
            this.groupBoxScale.Controls.Add(this.labelZeroI);
            this.groupBoxScale.Controls.Add(this.labelPlusU);
            this.groupBoxScale.Controls.Add(this.labelMinusU);
            this.groupBoxScale.Controls.Add(this.labelZeroU);
            this.groupBoxScale.Controls.Add(this.trackBarPlusI);
            this.groupBoxScale.Controls.Add(this.trackBarPlusU);
            this.groupBoxScale.Controls.Add(this.trackBarMinusU);
            this.groupBoxScale.Controls.Add(this.labelScaleI);
            this.groupBoxScale.Controls.Add(this.trackBarMinusI);
            this.groupBoxScale.Controls.Add(this.labelScaleU);
            this.groupBoxScale.Location = new System.Drawing.Point(12, 505);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(444, 114);
            this.groupBoxScale.TabIndex = 20;
            this.groupBoxScale.TabStop = false;
            this.groupBoxScale.Text = "Масштаб";
            // 
            // labelPlusI
            // 
            this.labelPlusI.AutoSize = true;
            this.labelPlusI.Location = new System.Drawing.Point(410, 64);
            this.labelPlusI.Name = "labelPlusI";
            this.labelPlusI.Size = new System.Drawing.Size(31, 13);
            this.labelPlusI.TabIndex = 27;
            this.labelPlusI.Text = "+100";
            // 
            // labelMinusI
            // 
            this.labelMinusI.AutoSize = true;
            this.labelMinusI.Location = new System.Drawing.Point(25, 69);
            this.labelMinusI.Name = "labelMinusI";
            this.labelMinusI.Size = new System.Drawing.Size(28, 13);
            this.labelMinusI.TabIndex = 26;
            this.labelMinusI.Text = "-100";
            // 
            // labelZeroI
            // 
            this.labelZeroI.AutoSize = true;
            this.labelZeroI.Location = new System.Drawing.Point(225, 61);
            this.labelZeroI.Name = "labelZeroI";
            this.labelZeroI.Size = new System.Drawing.Size(13, 13);
            this.labelZeroI.TabIndex = 25;
            this.labelZeroI.Text = "0";
            // 
            // labelPlusU
            // 
            this.labelPlusU.AutoSize = true;
            this.labelPlusU.Location = new System.Drawing.Point(410, 21);
            this.labelPlusU.Name = "labelPlusU";
            this.labelPlusU.Size = new System.Drawing.Size(25, 13);
            this.labelPlusU.TabIndex = 24;
            this.labelPlusU.Text = "+10";
            // 
            // labelMinusU
            // 
            this.labelMinusU.AutoSize = true;
            this.labelMinusU.Location = new System.Drawing.Point(31, 24);
            this.labelMinusU.Name = "labelMinusU";
            this.labelMinusU.Size = new System.Drawing.Size(22, 13);
            this.labelMinusU.TabIndex = 23;
            this.labelMinusU.Text = "-10";
            // 
            // labelZeroU
            // 
            this.labelZeroU.AutoSize = true;
            this.labelZeroU.Location = new System.Drawing.Point(225, 21);
            this.labelZeroU.Name = "labelZeroU";
            this.labelZeroU.Size = new System.Drawing.Size(13, 13);
            this.labelZeroU.TabIndex = 22;
            this.labelZeroU.Text = "0";
            // 
            // trackBarPlusI
            // 
            this.trackBarPlusI.Location = new System.Drawing.Point(244, 61);
            this.trackBarPlusI.Minimum = 1;
            this.trackBarPlusI.Name = "trackBarPlusI";
            this.trackBarPlusI.Size = new System.Drawing.Size(171, 45);
            this.trackBarPlusI.TabIndex = 21;
            this.trackBarPlusI.Value = 10;
            this.trackBarPlusI.Scroll += new System.EventHandler(this.trackBarPlusI_Scroll);
            // 
            // trackBarPlusU
            // 
            this.trackBarPlusU.Location = new System.Drawing.Point(244, 16);
            this.trackBarPlusU.Name = "trackBarPlusU";
            this.trackBarPlusU.Size = new System.Drawing.Size(171, 45);
            this.trackBarPlusU.TabIndex = 20;
            this.trackBarPlusU.Value = 10;
            this.trackBarPlusU.Scroll += new System.EventHandler(this.trackBarPlusU_Scroll);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U,
            this.I});
            this.dataGridView1.Location = new System.Drawing.Point(660, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(183, 267);
            this.dataGridView1.TabIndex = 21;
            // 
            // U
            // 
            this.U.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.U.DefaultCellStyle = dataGridViewCellStyle2;
            this.U.HeaderText = "U, B";
            this.U.Name = "U";
            this.U.ReadOnly = true;
            // 
            // I
            // 
            this.I.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.I.DefaultCellStyle = dataGridViewCellStyle3;
            this.I.HeaderText = "I, mA";
            this.I.Name = "I";
            this.I.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(849, 352);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(115, 267);
            this.dataGridView2.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.Location = new System.Drawing.Point(849, 25);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(115, 23);
            this.buttonInfo.TabIndex = 23;
            this.buttonInfo.Text = "О программе";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 623);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxScale);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxGraf);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(991, 661);
            this.Name = "Form1";
            this.Text = "AutoRunLab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImax)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGraf.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinusU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinusI)).EndInit();
            this.groupBoxScale.ResumeLayout(false);
            this.groupBoxScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlusI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlusU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonDisconnect;
        public System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonnpn;
        private System.Windows.Forms.RadioButton radioButtonpnp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSt;
        private System.Windows.Forms.CheckBox checkBoxRe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTransistor;
        private System.Windows.Forms.RadioButton radioButtonDiod;
        private System.Windows.Forms.Button buttonClearChart;
        private System.Windows.Forms.Label labelConnect;
        public System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxGraf;
        private System.Windows.Forms.Label labelmA;
        private System.Windows.Forms.Label labelImax;
        private System.Windows.Forms.NumericUpDown numericUpDownImax;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Label labelConstV;
        private System.Windows.Forms.NumericUpDown numericUpDownConst;
        private System.Windows.Forms.Label labelConst;
        private System.Windows.Forms.TrackBar trackBarMinusU;
        private System.Windows.Forms.TrackBar trackBarMinusI;
        private System.Windows.Forms.Label labelScaleU;
        private System.Windows.Forms.Label labelScaleI;
        private System.Windows.Forms.GroupBox groupBoxScale;
        private System.Windows.Forms.TrackBar trackBarPlusI;
        private System.Windows.Forms.TrackBar trackBarPlusU;
        private System.Windows.Forms.Label labelPlusI;
        private System.Windows.Forms.Label labelMinusI;
        private System.Windows.Forms.Label labelZeroI;
        private System.Windows.Forms.Label labelPlusU;
        private System.Windows.Forms.Label labelMinusU;
        private System.Windows.Forms.Label labelZeroU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxChart;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn U;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInfo;
    }
}

