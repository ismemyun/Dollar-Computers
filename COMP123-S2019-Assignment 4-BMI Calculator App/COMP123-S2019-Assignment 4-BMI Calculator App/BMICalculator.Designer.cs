namespace COMP123_S2019_Assignment_4_BMI_Calculator_App
{
    partial class BMICalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialradioButton = new System.Windows.Forms.RadioButton();
            this.MetricradioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.WeighUnitLabel = new System.Windows.Forms.Label();
            this.BMItextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.CalculatetableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMIprogressBar = new System.Windows.Forms.ProgressBar();
            this.CalculatetableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialradioButton
            // 
            this.ImperialradioButton.AutoSize = true;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.ImperialradioButton, 2);
            this.ImperialradioButton.Location = new System.Drawing.Point(2, 3);
            this.ImperialradioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ImperialradioButton.Name = "ImperialradioButton";
            this.ImperialradioButton.Size = new System.Drawing.Size(123, 37);
            this.ImperialradioButton.TabIndex = 1;
            this.ImperialradioButton.TabStop = true;
            this.ImperialradioButton.Text = "Imperial";
            this.ImperialradioButton.UseVisualStyleBackColor = true;
            this.ImperialradioButton.CheckedChanged += new System.EventHandler(this.ImperialradioButton_CheckedChanged);
            // 
            // MetricradioButton
            // 
            this.MetricradioButton.AutoSize = true;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.MetricradioButton, 2);
            this.MetricradioButton.Location = new System.Drawing.Point(140, 3);
            this.MetricradioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MetricradioButton.Name = "MetricradioButton";
            this.MetricradioButton.Size = new System.Drawing.Size(104, 37);
            this.MetricradioButton.TabIndex = 2;
            this.MetricradioButton.TabStop = true;
            this.MetricradioButton.Text = "Metric";
            this.MetricradioButton.UseVisualStyleBackColor = true;
            this.MetricradioButton.CheckedChanged += new System.EventHandler(this.MetricradioButton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatetableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Location = new System.Drawing.Point(2, 60);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(134, 50);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(140, 63);
            this.HeighttextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(57, 40);
            this.HeighttextBox.TabIndex = 4;
            this.HeighttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputtextBox_KeyPress);
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(201, 60);
            this.HeightUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(84, 50);
            this.HeightUnitLabel.TabIndex = 5;
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatetableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Location = new System.Drawing.Point(2, 110);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(134, 53);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(140, 113);
            this.WeighttextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(57, 40);
            this.WeighttextBox.TabIndex = 7;
            this.WeighttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputtextBox_KeyPress);
            // 
            // WeighUnitLabel
            // 
            this.WeighUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeighUnitLabel.Location = new System.Drawing.Point(201, 110);
            this.WeighUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeighUnitLabel.Name = "WeighUnitLabel";
            this.WeighUnitLabel.Size = new System.Drawing.Size(84, 53);
            this.WeighUnitLabel.TabIndex = 8;
            this.WeighUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMItextBox
            // 
            this.BMItextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMItextBox.BackColor = System.Drawing.Color.LightBlue;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.BMItextBox, 2);
            this.BMItextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.BMItextBox.Location = new System.Drawing.Point(140, 230);
            this.BMItextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BMItextBox.Name = "BMItextBox";
            this.BMItextBox.ReadOnly = true;
            this.BMItextBox.Size = new System.Drawing.Size(145, 40);
            this.BMItextBox.TabIndex = 9;
            this.BMItextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateBMIButton
            // 
            this.CalculatetableLayoutPanel.SetColumnSpan(this.CalculateBMIButton, 3);
            this.CalculateBMIButton.Location = new System.Drawing.Point(2, 166);
            this.CalculateBMIButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(195, 52);
            this.CalculateBMIButton.TabIndex = 10;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.BackColor = System.Drawing.Color.LightGreen;
            this.ResulttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.ResulttextBox, 4);
            this.ResulttextBox.Font = new System.Drawing.Font("Calibri", 18F);
            this.ResulttextBox.Location = new System.Drawing.Point(2, 326);
            this.ResulttextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResulttextBox.Multiline = true;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.ReadOnly = true;
            this.ResulttextBox.Size = new System.Drawing.Size(283, 74);
            this.ResulttextBox.TabIndex = 11;
            this.ResulttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculatetableLayoutPanel
            // 
            this.CalculatetableLayoutPanel.ColumnCount = 4;
            this.CalculatetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.05575F));
            this.CalculatetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.02787F));
            this.CalculatetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25435F));
            this.CalculatetableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.16949F));
            this.CalculatetableLayoutPanel.Controls.Add(this.ImperialradioButton, 0, 0);
            this.CalculatetableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.CalculatetableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.CalculatetableLayoutPanel.Controls.Add(this.WeighUnitLabel, 3, 2);
            this.CalculatetableLayoutPanel.Controls.Add(this.HeighttextBox, 2, 1);
            this.CalculatetableLayoutPanel.Controls.Add(this.HeightUnitLabel, 3, 1);
            this.CalculatetableLayoutPanel.Controls.Add(this.WeighttextBox, 2, 2);
            this.CalculatetableLayoutPanel.Controls.Add(this.MetricradioButton, 2, 0);
            this.CalculatetableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.CalculatetableLayoutPanel.Controls.Add(this.resetButton, 3, 3);
            this.CalculatetableLayoutPanel.Controls.Add(this.ResulttextBox, 0, 6);
            this.CalculatetableLayoutPanel.Controls.Add(this.BMILabel, 0, 4);
            this.CalculatetableLayoutPanel.Controls.Add(this.BMItextBox, 2, 4);
            this.CalculatetableLayoutPanel.Controls.Add(this.BMIprogressBar, 0, 5);
            this.CalculatetableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.CalculatetableLayoutPanel.Name = "CalculatetableLayoutPanel";
            this.CalculatetableLayoutPanel.RowCount = 7;
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.37363F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.18841F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.01932F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatetableLayoutPanel.Size = new System.Drawing.Size(287, 417);
            this.CalculatetableLayoutPanel.TabIndex = 12;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(201, 166);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 52);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMILabel.AutoSize = true;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.BMILabel, 2);
            this.BMILabel.Location = new System.Drawing.Point(3, 227);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(132, 50);
            this.BMILabel.TabIndex = 12;
            this.BMILabel.Text = "YOUR BMI";
            this.BMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIprogressBar
            // 
            this.BMIprogressBar.BackColor = System.Drawing.Color.LightSalmon;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.BMIprogressBar, 4);
            this.BMIprogressBar.ForeColor = System.Drawing.Color.White;
            this.BMIprogressBar.Location = new System.Drawing.Point(3, 280);
            this.BMIprogressBar.Name = "BMIprogressBar";
            this.BMIprogressBar.Size = new System.Drawing.Size(281, 36);
            this.BMIprogressBar.TabIndex = 13;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.CalculatetableLayoutPanel);
            this.Font = new System.Drawing.Font("Calibri", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Form";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.CalculatetableLayoutPanel.ResumeLayout(false);
            this.CalculatetableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton ImperialradioButton;
        private System.Windows.Forms.RadioButton MetricradioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.Label WeighUnitLabel;
        private System.Windows.Forms.TextBox BMItextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.TableLayoutPanel CalculatetableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.ProgressBar BMIprogressBar;
    }
}

