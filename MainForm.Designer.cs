namespace Laba3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tbFalseAlarmProbability = new System.Windows.Forms.TextBox();
            this.tbSecondProbability = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProbabilityOfMissingErrorDetection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFirstProbability = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.tbProbabilityOfTotalClassificationError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.Location = new System.Drawing.Point(14, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(598, 420);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // tbFalseAlarmProbability
            // 
            this.tbFalseAlarmProbability.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbFalseAlarmProbability.Enabled = false;
            this.tbFalseAlarmProbability.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbFalseAlarmProbability.Location = new System.Drawing.Point(10, 216);
            this.tbFalseAlarmProbability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFalseAlarmProbability.Name = "tbFalseAlarmProbability";
            this.tbFalseAlarmProbability.Size = new System.Drawing.Size(234, 34);
            this.tbFalseAlarmProbability.TabIndex = 4;
            // 
            // tbSecondProbability
            // 
            this.tbSecondProbability.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSecondProbability.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSecondProbability.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbSecondProbability.Location = new System.Drawing.Point(82, 84);
            this.tbSecondProbability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSecondProbability.Name = "tbSecondProbability";
            this.tbSecondProbability.Size = new System.Drawing.Size(162, 34);
            this.tbSecondProbability.TabIndex = 2;
            this.tbSecondProbability.Text = "0.6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "False alarm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "P2(x):";
            // 
            // tbProbabilityOfMissingErrorDetection
            // 
            this.tbProbabilityOfMissingErrorDetection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbProbabilityOfMissingErrorDetection.Enabled = false;
            this.tbProbabilityOfMissingErrorDetection.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProbabilityOfMissingErrorDetection.Location = new System.Drawing.Point(10, 287);
            this.tbProbabilityOfMissingErrorDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProbabilityOfMissingErrorDetection.Name = "tbProbabilityOfMissingErrorDetection";
            this.tbProbabilityOfMissingErrorDetection.Size = new System.Drawing.Size(234, 34);
            this.tbProbabilityOfMissingErrorDetection.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Missing error detection:";
            // 
            // tbFirstProbability
            // 
            this.tbFirstProbability.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbFirstProbability.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstProbability.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbFirstProbability.Location = new System.Drawing.Point(81, 42);
            this.tbFirstProbability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstProbability.Name = "tbFirstProbability";
            this.tbFirstProbability.Size = new System.Drawing.Size(163, 34);
            this.tbFirstProbability.TabIndex = 1;
            this.tbFirstProbability.Text = "0.4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total classification error:";
            // 
            // btnClassify
            // 
            this.btnClassify.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClassify.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnClassify.Location = new System.Drawing.Point(10, 126);
            this.btnClassify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(234, 38);
            this.btnClassify.TabIndex = 0;
            this.btnClassify.Text = "Classify";
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // tbProbabilityOfTotalClassificationError
            // 
            this.tbProbabilityOfTotalClassificationError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbProbabilityOfTotalClassificationError.Enabled = false;
            this.tbProbabilityOfTotalClassificationError.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbProbabilityOfTotalClassificationError.Location = new System.Drawing.Point(9, 358);
            this.tbProbabilityOfTotalClassificationError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProbabilityOfTotalClassificationError.Name = "tbProbabilityOfTotalClassificationError";
            this.tbProbabilityOfTotalClassificationError.Size = new System.Drawing.Size(235, 34);
            this.tbProbabilityOfTotalClassificationError.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "P1(x):";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.tbProbabilityOfTotalClassificationError);
            this.gbSettings.Controls.Add(this.btnClassify);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Controls.Add(this.tbFirstProbability);
            this.gbSettings.Controls.Add(this.label4);
            this.gbSettings.Controls.Add(this.tbProbabilityOfMissingErrorDetection);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.tbSecondProbability);
            this.gbSettings.Controls.Add(this.tbFalseAlarmProbability);
            this.gbSettings.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSettings.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbSettings.Location = new System.Drawing.Point(620, 15);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSettings.Size = new System.Drawing.Size(258, 420);
            this.gbSettings.TabIndex = 12;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(891, 448);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Probabilistic Approach";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tbFalseAlarmProbability;
        private System.Windows.Forms.TextBox tbSecondProbability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProbabilityOfMissingErrorDetection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFirstProbability;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.TextBox tbProbabilityOfTotalClassificationError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSettings;
    }
}

