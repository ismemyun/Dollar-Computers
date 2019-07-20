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
            this.NumberButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
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
            this.NumberButtonTableLayoutPanel.SuspendLayout();
            this.CalculatetableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberButtonTableLayoutPanel
            // 
            this.NumberButtonTableLayoutPanel.ColumnCount = 4;
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.TwoButton, 1, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ClearButton, 3, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.FiveButton, 1, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.backspaceButton, 3, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.FourButton, 0, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.OneButton, 0, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.DoneButton, 3, 2);
            this.NumberButtonTableLayoutPanel.Location = new System.Drawing.Point(12, 295);
            this.NumberButtonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NumberButtonTableLayoutPanel.Name = "NumberButtonTableLayoutPanel";
            this.NumberButtonTableLayoutPanel.RowCount = 4;
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.Size = new System.Drawing.Size(285, 138);
            this.NumberButtonTableLayoutPanel.TabIndex = 0;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.Turquoise;
            this.DecimalButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.DecimalButton.Location = new System.Drawing.Point(145, 105);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(65, 30);
            this.DecimalButton.TabIndex = 10;
            this.DecimalButton.Tag = ".";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.Turquoise;
            this.NumberButtonTableLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.ZeroButton.Location = new System.Drawing.Point(3, 105);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(136, 30);
            this.ZeroButton.TabIndex = 8;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.Turquoise;
            this.ThreeButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.ThreeButton.Location = new System.Drawing.Point(145, 71);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(65, 28);
            this.ThreeButton.TabIndex = 6;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.Turquoise;
            this.TwoButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.TwoButton.Location = new System.Drawing.Point(74, 71);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(65, 28);
            this.TwoButton.TabIndex = 5;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.LightSalmon;
            this.ClearButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.ClearButton.Location = new System.Drawing.Point(216, 37);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(66, 28);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.Turquoise;
            this.SixButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.SixButton.Location = new System.Drawing.Point(145, 37);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(65, 28);
            this.SixButton.TabIndex = 3;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.Turquoise;
            this.FiveButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.FiveButton.Location = new System.Drawing.Point(74, 37);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(65, 28);
            this.FiveButton.TabIndex = 2;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.Turquoise;
            this.EightButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.EightButton.Location = new System.Drawing.Point(74, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(65, 28);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.Turquoise;
            this.SevenButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(65, 28);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.Turquoise;
            this.NineButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.NineButton.Location = new System.Drawing.Point(145, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(65, 28);
            this.NineButton.TabIndex = 1;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // backspaceButton
            // 
            this.backspaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backspaceButton.BackColor = System.Drawing.Color.Turquoise;
            this.backspaceButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.backspaceButton.Location = new System.Drawing.Point(216, 3);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(66, 28);
            this.backspaceButton.TabIndex = 1;
            this.backspaceButton.Tag = "backspace";
            this.backspaceButton.Text = "<---";
            this.backspaceButton.UseVisualStyleBackColor = false;
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.Turquoise;
            this.FourButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.FourButton.Location = new System.Drawing.Point(3, 37);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(65, 28);
            this.FourButton.TabIndex = 1;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.Turquoise;
            this.OneButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.OneButton.Location = new System.Drawing.Point(3, 71);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(65, 28);
            this.OneButton.TabIndex = 1;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.PaleGreen;
            this.DoneButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.DoneButton.Location = new System.Drawing.Point(216, 71);
            this.DoneButton.Name = "DoneButton";
            this.NumberButtonTableLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(66, 64);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
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
            this.HeightLabel.Location = new System.Drawing.Point(2, 49);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(134, 48);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(140, 52);
            this.HeighttextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(57, 40);
            this.HeighttextBox.TabIndex = 4;
            this.HeighttextBox.TextChanged += new System.EventHandler(this.HeighttextBox_TextChanged);
            this.HeighttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputtextBox_KeyPress);
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(201, 49);
            this.HeightUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(84, 48);
            this.HeightUnitLabel.TabIndex = 5;
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatetableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Location = new System.Drawing.Point(2, 97);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(134, 48);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(140, 100);
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
            this.WeighUnitLabel.Location = new System.Drawing.Point(201, 97);
            this.WeighUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeighUnitLabel.Name = "WeighUnitLabel";
            this.WeighUnitLabel.Size = new System.Drawing.Size(84, 48);
            this.WeighUnitLabel.TabIndex = 8;
            this.WeighUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMItextBox
            // 
            this.BMItextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMItextBox.BackColor = System.Drawing.Color.LightBlue;
            this.BMItextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.BMItextBox.Location = new System.Drawing.Point(2, 233);
            this.BMItextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BMItextBox.Name = "BMItextBox";
            this.BMItextBox.ReadOnly = true;
            this.BMItextBox.Size = new System.Drawing.Size(88, 40);
            this.BMItextBox.TabIndex = 9;
            this.BMItextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateBMIButton
            // 
            this.CalculatetableLayoutPanel.SetColumnSpan(this.CalculateBMIButton, 3);
            this.CalculateBMIButton.Location = new System.Drawing.Point(2, 148);
            this.CalculateBMIButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(195, 41);
            this.CalculateBMIButton.TabIndex = 10;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.BackColor = System.Drawing.Color.LightGreen;
            this.CalculatetableLayoutPanel.SetColumnSpan(this.ResulttextBox, 3);
            this.ResulttextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.ResulttextBox.Location = new System.Drawing.Point(94, 195);
            this.ResulttextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResulttextBox.Multiline = true;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.ReadOnly = true;
            this.CalculatetableLayoutPanel.SetRowSpan(this.ResulttextBox, 2);
            this.ResulttextBox.Size = new System.Drawing.Size(191, 78);
            this.ResulttextBox.TabIndex = 11;
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
            this.CalculatetableLayoutPanel.Controls.Add(this.ResulttextBox, 1, 4);
            this.CalculatetableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.CalculatetableLayoutPanel.Controls.Add(this.resetButton, 3, 3);
            this.CalculatetableLayoutPanel.Controls.Add(this.BMItextBox, 0, 5);
            this.CalculatetableLayoutPanel.Controls.Add(this.BMILabel, 0, 4);
            this.CalculatetableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.CalculatetableLayoutPanel.Name = "CalculatetableLayoutPanel";
            this.CalculatetableLayoutPanel.RowCount = 6;
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.88832F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.8731F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.8731F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.36548F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.CalculatetableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatetableLayoutPanel.Size = new System.Drawing.Size(287, 277);
            this.CalculatetableLayoutPanel.TabIndex = 12;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(201, 148);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 41);
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
            this.BMILabel.Location = new System.Drawing.Point(3, 192);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(86, 38);
            this.BMILabel.TabIndex = 12;
            this.BMILabel.Text = "BMI";
            this.BMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.CalculatetableLayoutPanel);
            this.Controls.Add(this.NumberButtonTableLayoutPanel);
            this.Font = new System.Drawing.Font("Calibri", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMIForm";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.NumberButtonTableLayoutPanel.ResumeLayout(false);
            this.CalculatetableLayoutPanel.ResumeLayout(false);
            this.CalculatetableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NumberButtonTableLayoutPanel;
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
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TableLayoutPanel CalculatetableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label BMILabel;
    }
}

