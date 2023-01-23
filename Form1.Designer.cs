namespace ColonyOptimization
{
    partial class app
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            this.DistMatrix = new System.Windows.Forms.DataGridView();
            this.PhMatrix = new System.Windows.Forms.DataGridView();
            this.NextItBtn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.StepNumberText = new System.Windows.Forms.Label();
            this.ShortWayText = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Label();
            this.shortWayDist = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxNIt = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.textBoxAlfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBeta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlfa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.mas = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumPointRead = new System.Windows.Forms.NumericUpDown();
            this.DoFiveStepBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ReloadSearchingBtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numOfPointVisible = new System.Windows.Forms.CheckBox();
            this.checkBoxShowWay = new System.Windows.Forms.CheckBox();
            this.PanelMatrix = new System.Windows.Forms.Panel();
            this.PanelPhMatrix = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ButtonPhMatrix = new System.Windows.Forms.Button();
            this.PanelDistMatrix = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DistMatrixButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DistMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhMatrix)).BeginInit();
            this.panel11.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.DrawingPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPointRead)).BeginInit();
            this.PanelMatrix.SuspendLayout();
            this.PanelPhMatrix.SuspendLayout();
            this.panel7.SuspendLayout();
            this.PanelDistMatrix.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DistMatrix
            // 
            this.DistMatrix.AllowUserToAddRows = false;
            this.DistMatrix.AllowUserToDeleteRows = false;
            this.DistMatrix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DistMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DistMatrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.DistMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistMatrix.Location = new System.Drawing.Point(0, 0);
            this.DistMatrix.Name = "DistMatrix";
            this.DistMatrix.ReadOnly = true;
            this.DistMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DistMatrix.RowHeadersWidth = 50;
            this.DistMatrix.RowTemplate.Height = 24;
            this.DistMatrix.Size = new System.Drawing.Size(553, 200);
            this.DistMatrix.TabIndex = 0;
            // 
            // PhMatrix
            // 
            this.PhMatrix.AllowUserToAddRows = false;
            this.PhMatrix.AllowUserToDeleteRows = false;
            this.PhMatrix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PhMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhMatrix.Location = new System.Drawing.Point(0, 0);
            this.PhMatrix.Name = "PhMatrix";
            this.PhMatrix.ReadOnly = true;
            this.PhMatrix.RowHeadersWidth = 51;
            this.PhMatrix.RowTemplate.Height = 24;
            this.PhMatrix.Size = new System.Drawing.Size(553, 200);
            this.PhMatrix.TabIndex = 1;
            // 
            // NextItBtn
            // 
            this.NextItBtn.BackColor = System.Drawing.Color.White;
            this.NextItBtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.NextItBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextItBtn.Font = new System.Drawing.Font("Nirmala UI", 8.8F);
            this.NextItBtn.Location = new System.Drawing.Point(29, 237);
            this.NextItBtn.Name = "NextItBtn";
            this.NextItBtn.Size = new System.Drawing.Size(95, 36);
            this.NextItBtn.TabIndex = 2;
            this.NextItBtn.Text = "Step";
            this.NextItBtn.UseVisualStyleBackColor = false;
            this.NextItBtn.Click += new System.EventHandler(this.DoStep_Click);
            // 
            // panel11
            // 
            this.panel11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.panel11.Controls.Add(this.panelParam);
            this.panel11.Controls.Add(this.DrawingPanel);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel11.Location = new System.Drawing.Point(275, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(693, 594);
            this.panel11.TabIndex = 10;
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.panel8);
            this.panelParam.Controls.Add(this.panel4);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParam.Location = new System.Drawing.Point(0, 440);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(693, 154);
            this.panelParam.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.StepNumberText);
            this.panel8.Controls.Add(this.ShortWayText);
            this.panel8.Controls.Add(this.Step);
            this.panel8.Controls.Add(this.shortWayDist);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(331, 154);
            this.panel8.TabIndex = 2;
            // 
            // StepNumberText
            // 
            this.StepNumberText.AutoSize = true;
            this.StepNumberText.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepNumberText.Location = new System.Drawing.Point(125, 48);
            this.StepNumberText.Name = "StepNumberText";
            this.StepNumberText.Size = new System.Drawing.Size(18, 20);
            this.StepNumberText.TabIndex = 0;
            this.StepNumberText.Text = "0";
            // 
            // ShortWayText
            // 
            this.ShortWayText.AutoSize = true;
            this.ShortWayText.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShortWayText.Location = new System.Drawing.Point(125, 13);
            this.ShortWayText.Name = "ShortWayText";
            this.ShortWayText.Size = new System.Drawing.Size(84, 20);
            this.ShortWayText.TabIndex = 0;
            this.ShortWayText.Text = "No way     ";
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step.Location = new System.Drawing.Point(6, 48);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(104, 20);
            this.Step.TabIndex = 0;
            this.Step.Text = "Step number:";
            // 
            // shortWayDist
            // 
            this.shortWayDist.AutoSize = true;
            this.shortWayDist.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shortWayDist.Location = new System.Drawing.Point(6, 13);
            this.shortWayDist.Name = "shortWayDist";
            this.shortWayDist.Size = new System.Drawing.Size(90, 20);
            this.shortWayDist.TabIndex = 0;
            this.shortWayDist.Text = "Short way: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.textBoxNIt);
            this.panel4.Controls.Add(this.textBoxQ);
            this.panel4.Controls.Add(this.textBoxP);
            this.panel4.Controls.Add(this.textBoxL);
            this.panel4.Controls.Add(this.textBoxBeta);
            this.panel4.Controls.Add(this.textBoxAlfa);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.labelBeta);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.labelAlfa);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(337, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 154);
            this.panel4.TabIndex = 1;
            // 
            // textBoxNIt
            // 
            this.textBoxNIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBoxNIt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNIt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNIt.Location = new System.Drawing.Point(210, 105);
            this.textBoxNIt.Name = "textBoxNIt";
            this.textBoxNIt.Size = new System.Drawing.Size(50, 20);
            this.textBoxNIt.TabIndex = 2;
            this.textBoxNIt.Text = "5";
            // 
            // textBoxQ
            // 
            this.textBoxQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBoxQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQ.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQ.Location = new System.Drawing.Point(176, 63);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(50, 20);
            this.textBoxQ.TabIndex = 2;
            this.textBoxQ.Text = "30";
            // 
            // textBoxP
            // 
            this.textBoxP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBoxP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxP.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP.Location = new System.Drawing.Point(277, 37);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(50, 20);
            this.textBoxP.TabIndex = 2;
            this.textBoxP.Text = "0.1";
            // 
            // textBoxL
            // 
            this.textBoxL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBoxL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxL.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL.Location = new System.Drawing.Point(176, 37);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(50, 20);
            this.textBoxL.TabIndex = 2;
            this.textBoxL.Text = "1";
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBoxBeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBeta.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBeta.Location = new System.Drawing.Point(83, 63);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(50, 27);
            this.textBoxBeta.TabIndex = 2;
            this.textBoxBeta.Text = "3";
            // 
            // textBoxAlfa
            // 
            this.textBoxAlfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBoxAlfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAlfa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlfa.Location = new System.Drawing.Point(83, 37);
            this.textBoxAlfa.Name = "textBoxAlfa";
            this.textBoxAlfa.Size = new System.Drawing.Size(50, 27);
            this.textBoxAlfa.TabIndex = 2;
            this.textBoxAlfa.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(131, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Q  = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "number of iterations   = ";
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBeta.Location = new System.Drawing.Point(17, 63);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(61, 20);
            this.labelBeta.TabIndex = 1;
            this.labelBeta.Text = "beta  = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(227, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "P   = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "L  = ";
            // 
            // labelAlfa
            // 
            this.labelAlfa.AutoSize = true;
            this.labelAlfa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlfa.Location = new System.Drawing.Point(17, 37);
            this.labelAlfa.Name = "labelAlfa";
            this.labelAlfa.Size = new System.Drawing.Size(64, 20);
            this.labelAlfa.TabIndex = 1;
            this.labelAlfa.Text = "alfa    = ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Const -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.Controls.Add(this.mas);
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(693, 440);
            this.DrawingPanel.TabIndex = 0;
            // 
            // mas
            // 
            this.mas.AutoSize = true;
            this.mas.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas.Location = new System.Drawing.Point(589, 402);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(75, 20);
            this.mas.TabIndex = 0;
            this.mas.Text = "500 : 300";
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.White;
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Nirmala UI", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartBtn.Location = new System.Drawing.Point(29, 74);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(217, 33);
            this.RestartBtn.TabIndex = 5;
            this.RestartBtn.Text = "New colony";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1543, 44);
            this.panel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "© 2022";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel3.Controls.Add(this.NumPointRead);
            this.panel3.Controls.Add(this.DoFiveStepBtn);
            this.panel3.Controls.Add(this.NextItBtn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ReloadSearchingBtn);
            this.panel3.Controls.Add(this.RestartBtn);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.numOfPointVisible);
            this.panel3.Controls.Add(this.checkBoxShowWay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 594);
            this.panel3.TabIndex = 8;
            // 
            // NumPointRead
            // 
            this.NumPointRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.NumPointRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumPointRead.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumPointRead.Location = new System.Drawing.Point(186, 31);
            this.NumPointRead.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumPointRead.Name = "NumPointRead";
            this.NumPointRead.Size = new System.Drawing.Size(61, 27);
            this.NumPointRead.TabIndex = 8;
            this.NumPointRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumPointRead.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumPointRead.Paint += new System.Windows.Forms.PaintEventHandler(this.NumPointRead_paint);
            // 
            // DoFiveStepBtn
            // 
            this.DoFiveStepBtn.BackColor = System.Drawing.Color.White;
            this.DoFiveStepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoFiveStepBtn.Font = new System.Drawing.Font("Nirmala UI", 8.8F);
            this.DoFiveStepBtn.Location = new System.Drawing.Point(151, 237);
            this.DoFiveStepBtn.Name = "DoFiveStepBtn";
            this.DoFiveStepBtn.Size = new System.Drawing.Size(95, 36);
            this.DoFiveStepBtn.TabIndex = 6;
            this.DoFiveStepBtn.Text = "5 step";
            this.DoFiveStepBtn.UseVisualStyleBackColor = false;
            this.DoFiveStepBtn.Click += new System.EventHandler(this.DoFiveStepButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of points";
            // 
            // ReloadSearchingBtn
            // 
            this.ReloadSearchingBtn.BackColor = System.Drawing.Color.White;
            this.ReloadSearchingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadSearchingBtn.Font = new System.Drawing.Font("Nirmala UI", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadSearchingBtn.Location = new System.Drawing.Point(29, 304);
            this.ReloadSearchingBtn.Name = "ReloadSearchingBtn";
            this.ReloadSearchingBtn.Size = new System.Drawing.Size(217, 33);
            this.ReloadSearchingBtn.TabIndex = 5;
            this.ReloadSearchingBtn.Text = "Restart searching";
            this.ReloadSearchingBtn.UseVisualStyleBackColor = false;
            this.ReloadSearchingBtn.Click += new System.EventHandler(this.ReloadSearchingBtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(186, 244);
            this.textBox5.MaxLength = 3;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "10";
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlfa_KeyPr);
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAlfa_KeyUp);
            // 
            // numOfPointVisible
            // 
            this.numOfPointVisible.AutoSize = true;
            this.numOfPointVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numOfPointVisible.Checked = true;
            this.numOfPointVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numOfPointVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numOfPointVisible.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfPointVisible.Location = new System.Drawing.Point(29, 174);
            this.numOfPointVisible.Name = "numOfPointVisible";
            this.numOfPointVisible.Size = new System.Drawing.Size(193, 24);
            this.numOfPointVisible.TabIndex = 0;
            this.numOfPointVisible.Text = "Show number of points";
            this.numOfPointVisible.UseVisualStyleBackColor = true;
            this.numOfPointVisible.CheckedChanged += new System.EventHandler(this.numOfPointVisible_CheckedChanged);
            // 
            // checkBoxShowWay
            // 
            this.checkBoxShowWay.AutoSize = true;
            this.checkBoxShowWay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxShowWay.Checked = true;
            this.checkBoxShowWay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowWay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowWay.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowWay.Location = new System.Drawing.Point(29, 144);
            this.checkBoxShowWay.Name = "checkBoxShowWay";
            this.checkBoxShowWay.Size = new System.Drawing.Size(142, 24);
            this.checkBoxShowWay.TabIndex = 0;
            this.checkBoxShowWay.Text = "Show short way";
            this.checkBoxShowWay.UseVisualStyleBackColor = true;
            this.checkBoxShowWay.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PanelMatrix
            // 
            this.PanelMatrix.AutoScroll = true;
            this.PanelMatrix.Controls.Add(this.PanelPhMatrix);
            this.PanelMatrix.Controls.Add(this.panel7);
            this.PanelMatrix.Controls.Add(this.PanelDistMatrix);
            this.PanelMatrix.Controls.Add(this.panel5);
            this.PanelMatrix.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMatrix.Location = new System.Drawing.Point(968, 0);
            this.PanelMatrix.Name = "PanelMatrix";
            this.PanelMatrix.Size = new System.Drawing.Size(553, 594);
            this.PanelMatrix.TabIndex = 12;
            // 
            // PanelPhMatrix
            // 
            this.PanelPhMatrix.Controls.Add(this.PhMatrix);
            this.PanelPhMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPhMatrix.Location = new System.Drawing.Point(0, 273);
            this.PanelPhMatrix.Name = "PanelPhMatrix";
            this.PanelPhMatrix.Size = new System.Drawing.Size(553, 200);
            this.PanelPhMatrix.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ButtonPhMatrix);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 235);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(553, 38);
            this.panel7.TabIndex = 4;
            // 
            // ButtonPhMatrix
            // 
            this.ButtonPhMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPhMatrix.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.ButtonPhMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPhMatrix.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPhMatrix.Location = new System.Drawing.Point(0, 0);
            this.ButtonPhMatrix.Name = "ButtonPhMatrix";
            this.ButtonPhMatrix.Size = new System.Drawing.Size(553, 38);
            this.ButtonPhMatrix.TabIndex = 1;
            this.ButtonPhMatrix.Text = "Ph Matrix";
            this.ButtonPhMatrix.UseVisualStyleBackColor = true;
            this.ButtonPhMatrix.Click += new System.EventHandler(this.PhMatrixBtn_Click);
            // 
            // PanelDistMatrix
            // 
            this.PanelDistMatrix.Controls.Add(this.DistMatrix);
            this.PanelDistMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDistMatrix.Location = new System.Drawing.Point(0, 35);
            this.PanelDistMatrix.Name = "PanelDistMatrix";
            this.PanelDistMatrix.Size = new System.Drawing.Size(553, 200);
            this.PanelDistMatrix.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DistMatrixButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 35);
            this.panel5.TabIndex = 2;
            // 
            // DistMatrixButton
            // 
            this.DistMatrixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistMatrixButton.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.DistMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistMatrixButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistMatrixButton.Location = new System.Drawing.Point(0, 0);
            this.DistMatrixButton.Name = "DistMatrixButton";
            this.DistMatrixButton.Size = new System.Drawing.Size(553, 35);
            this.DistMatrixButton.TabIndex = 0;
            this.DistMatrixButton.Text = "Dist Matrix";
            this.DistMatrixButton.UseVisualStyleBackColor = true;
            this.DistMatrixButton.Click += new System.EventHandler(this.DistMatrixBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1521, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 594);
            this.panel6.TabIndex = 14;
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1543, 638);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.PanelMatrix);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(975, 685);
            this.Name = "app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рома ищет дом";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            ((System.ComponentModel.ISupportInitialize)(this.DistMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhMatrix)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panelParam.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.DrawingPanel.ResumeLayout(false);
            this.DrawingPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPointRead)).EndInit();
            this.PanelMatrix.ResumeLayout(false);
            this.PanelPhMatrix.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.PanelDistMatrix.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DistMatrix;
        private System.Windows.Forms.DataGridView PhMatrix;
        private System.Windows.Forms.Button NextItBtn;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelMatrix;
        private System.Windows.Forms.Panel PanelDistMatrix;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button DistMatrixButton;
        private System.Windows.Forms.Panel PanelPhMatrix;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button ButtonPhMatrix;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.CheckBox checkBoxShowWay;
        private System.Windows.Forms.Label shortWayDist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlfa;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNIt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DoFiveStepBtn;
        private System.Windows.Forms.Label StepNumberText;
        private System.Windows.Forms.Label ShortWayText;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.Button ReloadSearchingBtn;
        private System.Windows.Forms.CheckBox numOfPointVisible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown NumPointRead;
        private System.Windows.Forms.TextBox textBoxAlfa;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.Label mas;
        private System.Windows.Forms.Label label7;
    }
}

