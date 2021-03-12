namespace XY_Plotting
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelTxt1 = new System.Windows.Forms.Label();
            this.textBoxEq1 = new System.Windows.Forms.TextBox();
            this.textBoxEq2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPKa1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPKa2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMolmassa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(0, 28);
            this.chartData.Name = "chartData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartData.Series.Add(series1);
            this.chartData.Size = new System.Drawing.Size(849, 578);
            this.chartData.TabIndex = 0;
            this.chartData.Text = "chart1";
            // 
            // buttonInit
            // 
            this.buttonInit.BackColor = System.Drawing.Color.Teal;
            this.buttonInit.ForeColor = System.Drawing.Color.White;
            this.buttonInit.Location = new System.Drawing.Point(12, 627);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(129, 44);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = false;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.Teal;
            this.buttonCalc.ForeColor = System.Drawing.Color.White;
            this.buttonCalc.Location = new System.Drawing.Point(885, 600);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(123, 71);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Beräkna";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(147, 630);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(163, 28);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.Text = "Visualization type";
            // 
            // labelTxt1
            // 
            this.labelTxt1.AutoSize = true;
            this.labelTxt1.Location = new System.Drawing.Point(25, 27);
            this.labelTxt1.Name = "labelTxt1";
            this.labelTxt1.Size = new System.Drawing.Size(136, 20);
            this.labelTxt1.TabIndex = 4;
            this.labelTxt1.Text = "Ekvivalenspunkt 1";
            // 
            // textBoxEq1
            // 
            this.textBoxEq1.Location = new System.Drawing.Point(196, 24);
            this.textBoxEq1.Name = "textBoxEq1";
            this.textBoxEq1.ReadOnly = true;
            this.textBoxEq1.Size = new System.Drawing.Size(202, 26);
            this.textBoxEq1.TabIndex = 5;
            // 
            // textBoxEq2
            // 
            this.textBoxEq2.Location = new System.Drawing.Point(196, 56);
            this.textBoxEq2.Name = "textBoxEq2";
            this.textBoxEq2.ReadOnly = true;
            this.textBoxEq2.Size = new System.Drawing.Size(202, 26);
            this.textBoxEq2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ekvivalenspunkt 2";
            // 
            // textBoxPKa1
            // 
            this.textBoxPKa1.Location = new System.Drawing.Point(196, 88);
            this.textBoxPKa1.Name = "textBoxPKa1";
            this.textBoxPKa1.ReadOnly = true;
            this.textBoxPKa1.Size = new System.Drawing.Size(202, 26);
            this.textBoxPKa1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "pKa1";
            // 
            // textBoxPKa2
            // 
            this.textBoxPKa2.Location = new System.Drawing.Point(196, 120);
            this.textBoxPKa2.Name = "textBoxPKa2";
            this.textBoxPKa2.ReadOnly = true;
            this.textBoxPKa2.Size = new System.Drawing.Size(202, 26);
            this.textBoxPKa2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "pKa2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTxt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMolmassa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPKa2);
            this.groupBox1.Controls.Add(this.textBoxPKa1);
            this.groupBox1.Controls.Add(this.textBoxEq2);
            this.groupBox1.Controls.Add(this.textBoxEq1);
            this.groupBox1.Location = new System.Drawing.Point(885, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beräknade värden";
            // 
            // textBoxMolmassa
            // 
            this.textBoxMolmassa.Location = new System.Drawing.Point(196, 152);
            this.textBoxMolmassa.Name = "textBoxMolmassa";
            this.textBoxMolmassa.ReadOnly = true;
            this.textBoxMolmassa.Size = new System.Drawing.Size(202, 26);
            this.textBoxMolmassa.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Molmassa";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(885, 252);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(404, 305);
            this.dataGridView.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1669, 32);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 29);
            this.toolStripButton1.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 29);
            this.toolStripButton2.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1669, 676);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Titration";
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelTxt1;
        private System.Windows.Forms.TextBox textBoxEq1;
        private System.Windows.Forms.TextBox textBoxEq2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPKa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPKa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMolmassa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

