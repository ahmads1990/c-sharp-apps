using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using tasksForm;

namespace FunctionPlotter
{
    public partial class PlottingForm : Form
    {
        public PlottingForm()
        {
            InitializeComponent();
        }
        //data
        Chart plotChart;
        Equation plotEquation;
        //x range data
        float xMin;
        float xMax;
        float StepSize;
        //dataa values
        float[] xValues;
        float[] yValues;
        private void PlottingForm_Load(object sender, EventArgs e)
        {
            //
            xMin = -100;
            xMax = 100;
            StepSize = 1;
            //clear
            chart1.Series.Clear();
            plotEquation = new Equation();
  
            ChartArea CA = chart1.ChartAreas[0];  // quick reference
            CA.AxisX.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            this.chart1.ChartAreas[0].AxisX.Minimum = -100;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;
            this.chart1.ChartAreas[0].AxisY.Minimum = -100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateXValues();
            //plotEquation.addNewExpression(txtbx_expr.Text.ToString());
            plotEquation.addNewExpression("5*x^3+2*3");
            plotEquation.parseExpression();
            yValues=plotEquation.evaluateArray(xValues);
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = SeriesChartType.Spline;

            for (int i = 0; i < xValues.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY((double)xValues[i],(double) yValues[i]);
            }
           

        }
        private void generateXValues()
        {
            int size = (int)((xMax - xMin) / StepSize) + 1;
            xValues = new float[size];
            float xStart = xMin;
            xValues[0] = xStart;
            for (int i = 1; i < size; i++)
            {
                xStart += StepSize;
                xValues[i] = xStart;
            }
        }
    }
}
