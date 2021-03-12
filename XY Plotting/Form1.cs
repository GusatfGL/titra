using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace XY_Plotting
{
    public partial class Form1 : Form
    {

        double[] xs1;
        double[] ys1;
        public Form1()
        {
            InitializeComponent();
            ys1 = GetData("y.txt");
            xs1 = GetData("x.txt");
        }

        private double[] GetData(string file)
        {
            string path = @"C:\Users\gusta\source\repos\XY Plotting\XY Plotting\" + file;
            string[] lines = File.ReadAllLines(path);
            double[] ret = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                ret[i] = Convert.ToDouble(lines[i]);
            }
            return ret;
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {// generate some random XY data

            // create a series for each line
            Series series1 = new Series("Titration 1");
            series1.Points.DataBindXY(xs1, ys1);
            series1.ChartType = SeriesChartType.Line;
            series1.MarkerStyle = MarkerStyle.Circle;

            // add each series to the chart
            chartData.Series.Clear();
            chartData.Series.Add(series1);

            // additional styling
            chartData.ResetAutoValues();
            chartData.Titles.Clear();
            chartData.Titles.Add($"Scatter Plot");
            chartData.ChartAreas[0].AxisX.Title = "ml added of NaOH";
            chartData.ChartAreas[0].AxisY.Title = "pH";
            chartData.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartData.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            textBoxEq1.Text = GetEq1().ToString() + " ml";
            textBoxEq2.Text = GetEq2().ToString() + " ml";
            textBoxPKa1.Text = GetPKa1().ToString();
            textBoxPKa2.Text = GetPka2().ToString();
            textBoxMolmassa.Text = GetMolmassa().ToString() + " g/mol";
            dataGridView.DataSource = GetDeltas();
        }

        private double GetEq1()
        {
            double tempMax = 0;
            double maxAddedFluid = 0;
            for (int i = 0; i < xs1.Length-1; i++)
            {
                if (tempMax < (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]))
                {
                    tempMax = (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]);
                    maxAddedFluid = (xs1[i] + xs1[i + 1]) / 2;
                }
            }
            return maxAddedFluid;
        }

        private double GetEq2()
        {
            return GetEq1() / 2;
        }
        
        private double GetPKa1()
        {
            double tempMax = 0;
            double maxAddedFluid = 0;
            for (int i = 0; i < xs1.Length - 1; i++)
            {
                if (tempMax < (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]))
                {
                    tempMax = (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]);
                    maxAddedFluid = xs1[i];
                }
            }
            double addedFluidAtPKa1 = maxAddedFluid / 4;
            double pKa1 = 0;
            double diff = int.MaxValue;
            for (int i = 0; i < xs1.Length; i++)
            {
                if (Math.Abs(diff) > xs1[i] - addedFluidAtPKa1)
                {
                    diff = xs1[i] - addedFluidAtPKa1;
                    pKa1 = ys1[i];
                }
            }
            return pKa1;
        }
        
        private double GetPka2()
        {
            double tempMax = 0;
            double maxAddedFluid = 0;
            for (int i = 0; i < xs1.Length - 1; i++)
            {
                if (tempMax < (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]))
                {
                    tempMax = (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]);
                    maxAddedFluid = xs1[i];
                }
            }
            double addedFluidAtPKa2 = maxAddedFluid * 3/4;
            double pKa2 = 0;
            double diff = int.MaxValue;
            for (int i = 0; i < xs1.Length; i++)
            {
                if (Math.Abs(diff) > xs1[i] - addedFluidAtPKa2)
                {
                    diff = xs1[i] - addedFluidAtPKa2;
                    pKa2 = ys1[i];
                }
            }
            return pKa2;
        }

        private double GetMolmassa()
        {
            double tempMax = 0;
            double maxAddedFluid = 0;
            for (int i = 0; i < xs1.Length - 1; i++)
            {
                if (tempMax < (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]))
                {
                    tempMax = (ys1[i + 1] - ys1[i]) / (xs1[i + 1] - xs1[i]);
                    maxAddedFluid = xs1[i];
                }
            }
            double n = maxAddedFluid/(10.0*1000.0) * 0.5; // 2: 1
            //tex:
            //$M=\frac{m}{n}$
            double M = 0.3 / n;
            return Math.Round(M,1);
        }

        private List<DeltaAcid> GetDeltas()
        {
            List<DeltaAcid> list = new List<DeltaAcid>();
            list.Add(new DeltaAcid()
            {
                Acid = "Oxalsyra",
                FfPKa1 = Math.Abs(1 - (1.2/ GetPKa1())),
                FfPKa2 = Math.Abs(1 - (4.2 / GetPka2())),
                FfMolarMass = Math.Abs(1 - (90.03) / GetMolmassa())

            });
            list.Add(new DeltaAcid()
            {
                Acid = "L-vinsyra",
                FfPKa1 = Math.Abs(1 - (3.0 / GetPKa1())),
                FfPKa2 = Math.Abs(1 - (4.3 / GetPka2())),
                FfMolarMass = Math.Abs(1 - (150.087) / GetMolmassa())

            });
            list.Add(new DeltaAcid()
            {
                Acid = "Bärstenssyra",
                FfPKa1 = Math.Abs(1 - (4.2 / GetPKa1())),
                FfPKa2 = Math.Abs(1 - (5.6 / GetPka2())),
                FfMolarMass = Math.Abs(1 - (118.09) / GetMolmassa())

            });
            list.Add(new DeltaAcid()
            {
                Acid = "Äppelsyra",
                FfPKa1 = Math.Abs(1 - (3.4 / GetPKa1())),
                FfPKa2 = Math.Abs(1 - (5.2 / GetPka2())),
                FfMolarMass = Math.Abs(1-(134.0874) / GetMolmassa())
            });
            list.Add(new DeltaAcid()
            {
                Acid = "Malonsyra",
                FfPKa1 = Math.Abs(1 - (2.8 / GetPKa1())),
                FfPKa2 = Math.Abs(1 - (5.7 / GetPka2())),
                FfMolarMass = Math.Abs(1 - (104.0615) / GetMolmassa())

            });
            list = list.OrderBy(o => o.Match).ToList();
            return list;
        }
    }
}
