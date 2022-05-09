namespace FunctionPlotter
{
    partial class PlottingForm
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_entr = new System.Windows.Forms.Label();
            this.txtbx_expr = new System.Windows.Forms.TextBox();
            this.lbl_expr_msg = new System.Windows.Forms.Label();
            this.lbl_x_rng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbx_x_min = new System.Windows.Forms.TextBox();
            this.txtbx_x_max = new System.Windows.Forms.TextBox();
            this.txtbx_x_stepsize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(538, 357);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lbl_entr
            // 
            this.lbl_entr.AutoSize = true;
            this.lbl_entr.Location = new System.Drawing.Point(582, 23);
            this.lbl_entr.Name = "lbl_entr";
            this.lbl_entr.Size = new System.Drawing.Size(115, 13);
            this.lbl_entr.TabIndex = 1;
            this.lbl_entr.Text = "Enter Expression Here:";
            // 
            // txtbx_expr
            // 
            this.txtbx_expr.Location = new System.Drawing.Point(585, 39);
            this.txtbx_expr.Name = "txtbx_expr";
            this.txtbx_expr.Size = new System.Drawing.Size(164, 20);
            this.txtbx_expr.TabIndex = 2;
            // 
            // lbl_expr_msg
            // 
            this.lbl_expr_msg.AutoSize = true;
            this.lbl_expr_msg.Location = new System.Drawing.Point(585, 66);
            this.lbl_expr_msg.Name = "lbl_expr_msg";
            this.lbl_expr_msg.Size = new System.Drawing.Size(35, 13);
            this.lbl_expr_msg.TabIndex = 3;
            this.lbl_expr_msg.Text = "label1";
            // 
            // lbl_x_rng
            // 
            this.lbl_x_rng.AutoSize = true;
            this.lbl_x_rng.Location = new System.Drawing.Point(585, 93);
            this.lbl_x_rng.Name = "lbl_x_rng";
            this.lbl_x_rng.Size = new System.Drawing.Size(80, 13);
            this.lbl_x_rng.TabIndex = 4;
            this.lbl_x_rng.Text = "Enter X Range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "StepSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbx_x_min
            // 
            this.txtbx_x_min.Location = new System.Drawing.Point(585, 127);
            this.txtbx_x_min.Name = "txtbx_x_min";
            this.txtbx_x_min.Size = new System.Drawing.Size(75, 20);
            this.txtbx_x_min.TabIndex = 13;
            // 
            // txtbx_x_max
            // 
            this.txtbx_x_max.Location = new System.Drawing.Point(700, 127);
            this.txtbx_x_max.Name = "txtbx_x_max";
            this.txtbx_x_max.Size = new System.Drawing.Size(75, 20);
            this.txtbx_x_max.TabIndex = 14;
            // 
            // txtbx_x_stepsize
            // 
            this.txtbx_x_stepsize.Location = new System.Drawing.Point(585, 166);
            this.txtbx_x_stepsize.Name = "txtbx_x_stepsize";
            this.txtbx_x_stepsize.Size = new System.Drawing.Size(75, 20);
            this.txtbx_x_stepsize.TabIndex = 15;
            // 
            // PlottingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbx_x_stepsize);
            this.Controls.Add(this.txtbx_x_max);
            this.Controls.Add(this.txtbx_x_min);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_x_rng);
            this.Controls.Add(this.lbl_expr_msg);
            this.Controls.Add(this.txtbx_expr);
            this.Controls.Add(this.lbl_entr);
            this.Controls.Add(this.chart1);
            this.Name = "PlottingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlottingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_entr;
        private System.Windows.Forms.TextBox txtbx_expr;
        private System.Windows.Forms.Label lbl_expr_msg;
        private System.Windows.Forms.Label lbl_x_rng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbx_x_min;
        private System.Windows.Forms.TextBox txtbx_x_max;
        private System.Windows.Forms.TextBox txtbx_x_stepsize;
    }
}