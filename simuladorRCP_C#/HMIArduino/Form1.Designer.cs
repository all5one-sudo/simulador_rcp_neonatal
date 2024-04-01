namespace HMIArduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connection = new System.Windows.Forms.GroupBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularProgressBarExcesos = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarOptimos = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarLeves = new CircularProgressBar.CircularProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connection.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connection
            // 
            this.connection.BackColor = System.Drawing.Color.Transparent;
            this.connection.Controls.Add(this.labelBaud);
            this.connection.Controls.Add(this.progressBarConnection);
            this.connection.Controls.Add(this.buttonClose);
            this.connection.Controls.Add(this.buttonOpen);
            this.connection.Controls.Add(this.comboBoxBaud);
            this.connection.Controls.Add(this.comboBoxPort);
            this.connection.Controls.Add(this.labelPort);
            this.connection.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.connection.Location = new System.Drawing.Point(12, 12);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(213, 255);
            this.connection.TabIndex = 0;
            this.connection.TabStop = false;
            this.connection.Text = "Conexión ";
            this.connection.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.ForeColor = System.Drawing.Color.Snow;
            this.labelBaud.Location = new System.Drawing.Point(63, 98);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(87, 23);
            this.labelBaud.TabIndex = 7;
            this.labelBaud.Text = "BaudRate";
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(6, 223);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(201, 23);
            this.progressBarConnection.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Silver;
            this.buttonClose.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(69, 194);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Silver;
            this.buttonOpen.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpen.Location = new System.Drawing.Point(69, 164);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Abrir";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            this.buttonOpen.MouseEnter += new System.EventHandler(this.buttonOpen_MouseEnter);
            this.buttonOpen.MouseLeave += new System.EventHandler(this.buttonOpen_MouseLeave);
            this.buttonOpen.MouseHover += new System.EventHandler(this.buttonOpen_MouseHover);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(46, 124);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 34);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(46, 61);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 34);
            this.comboBoxPort.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.ForeColor = System.Drawing.Color.Snow;
            this.labelPort.Location = new System.Drawing.Point(49, 35);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(115, 23);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Puerto COM:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 645);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circularProgressBarExcesos);
            this.panel1.Controls.Add(this.circularProgressBarOptimos);
            this.panel1.Controls.Add(this.circularProgressBarLeves);
            this.panel1.Location = new System.Drawing.Point(698, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 606);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porcentaje de ciclos excesivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porcentaje de ciclos correctos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Porcentaje de ciclos leves";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultados del test";
            // 
            // circularProgressBarExcesos
            // 
            this.circularProgressBarExcesos.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarExcesos.AnimationSpeed = 500;
            this.circularProgressBarExcesos.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarExcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarExcesos.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBarExcesos.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.circularProgressBarExcesos.InnerMargin = 2;
            this.circularProgressBarExcesos.InnerWidth = -1;
            this.circularProgressBarExcesos.Location = new System.Drawing.Point(43, 418);
            this.circularProgressBarExcesos.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarExcesos.Maximum = 1000;
            this.circularProgressBarExcesos.Name = "circularProgressBarExcesos";
            this.circularProgressBarExcesos.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.circularProgressBarExcesos.OuterMargin = -25;
            this.circularProgressBarExcesos.OuterWidth = 26;
            this.circularProgressBarExcesos.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(205)))), ((int)(((byte)(142)))));
            this.circularProgressBarExcesos.ProgressWidth = 20;
            this.circularProgressBarExcesos.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.circularProgressBarExcesos.Size = new System.Drawing.Size(144, 144);
            this.circularProgressBarExcesos.StartAngle = 270;
            this.circularProgressBarExcesos.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarExcesos.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarExcesos.SubscriptText = "";
            this.circularProgressBarExcesos.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarExcesos.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarExcesos.SuperscriptText = "%";
            this.circularProgressBarExcesos.TabIndex = 2;
            this.circularProgressBarExcesos.Text = "100";
            this.circularProgressBarExcesos.TextMargin = new System.Windows.Forms.Padding(-3, 6, 0, 0);
            this.circularProgressBarExcesos.Value = 1000;
            // 
            // circularProgressBarOptimos
            // 
            this.circularProgressBarOptimos.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarOptimos.AnimationSpeed = 500;
            this.circularProgressBarOptimos.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarOptimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarOptimos.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBarOptimos.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.circularProgressBarOptimos.InnerMargin = 2;
            this.circularProgressBarOptimos.InnerWidth = -1;
            this.circularProgressBarOptimos.Location = new System.Drawing.Point(43, 226);
            this.circularProgressBarOptimos.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarOptimos.Maximum = 1000;
            this.circularProgressBarOptimos.Name = "circularProgressBarOptimos";
            this.circularProgressBarOptimos.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.circularProgressBarOptimos.OuterMargin = -25;
            this.circularProgressBarOptimos.OuterWidth = 26;
            this.circularProgressBarOptimos.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(205)))), ((int)(((byte)(142)))));
            this.circularProgressBarOptimos.ProgressWidth = 20;
            this.circularProgressBarOptimos.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.circularProgressBarOptimos.Size = new System.Drawing.Size(144, 144);
            this.circularProgressBarOptimos.StartAngle = 270;
            this.circularProgressBarOptimos.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarOptimos.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarOptimos.SubscriptText = "";
            this.circularProgressBarOptimos.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarOptimos.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarOptimos.SuperscriptText = "%";
            this.circularProgressBarOptimos.TabIndex = 1;
            this.circularProgressBarOptimos.Text = "100";
            this.circularProgressBarOptimos.TextMargin = new System.Windows.Forms.Padding(-3, 6, 0, 0);
            this.circularProgressBarOptimos.Value = 1000;
            // 
            // circularProgressBarLeves
            // 
            this.circularProgressBarLeves.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarLeves.AnimationSpeed = 500;
            this.circularProgressBarLeves.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarLeves.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarLeves.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBarLeves.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.circularProgressBarLeves.InnerMargin = 2;
            this.circularProgressBarLeves.InnerWidth = -1;
            this.circularProgressBarLeves.Location = new System.Drawing.Point(43, 41);
            this.circularProgressBarLeves.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarLeves.Maximum = 1000;
            this.circularProgressBarLeves.Name = "circularProgressBarLeves";
            this.circularProgressBarLeves.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.circularProgressBarLeves.OuterMargin = -25;
            this.circularProgressBarLeves.OuterWidth = 26;
            this.circularProgressBarLeves.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(205)))), ((int)(((byte)(142)))));
            this.circularProgressBarLeves.ProgressWidth = 20;
            this.circularProgressBarLeves.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.circularProgressBarLeves.Size = new System.Drawing.Size(144, 144);
            this.circularProgressBarLeves.StartAngle = 270;
            this.circularProgressBarLeves.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarLeves.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarLeves.SubscriptText = "";
            this.circularProgressBarLeves.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarLeves.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarLeves.SuperscriptText = "%";
            this.circularProgressBarLeves.TabIndex = 0;
            this.circularProgressBarLeves.Text = "100";
            this.circularProgressBarLeves.TextMargin = new System.Windows.Forms.Padding(-3, 6, 0, 0);
            this.circularProgressBarLeves.Value = 1000;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 606);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            series1.Legend = "Legend1";
            series1.LegendText = "Distancia [cm]";
            series1.Name = "Distancia";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(682, 603);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.RosyBrown;
            title1.Name = "Title1";
            title1.Text = "Distancia en tiempo real";
            this.chart1.Titles.Add(title1);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFinalizar);
            this.groupBox1.Controls.Add(this.buttonIniciar);
            this.groupBox1.Location = new System.Drawing.Point(14, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(23, 92);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(165, 34);
            this.buttonFinalizar.TabIndex = 1;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(23, 34);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(165, 38);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(14, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 202);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1171, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.connection);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Médico RCP para Neonatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.connection.ResumeLayout(false);
            this.connection.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaud;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circularProgressBarExcesos;
        private CircularProgressBar.CircularProgressBar circularProgressBarOptimos;
        private CircularProgressBar.CircularProgressBar circularProgressBarLeves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

