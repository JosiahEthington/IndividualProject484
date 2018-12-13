namespace WinFormDutyCalc
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
            this.button1 = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.hoursThisQuarterLabel = new System.Windows.Forms.Label();
            this.hoursFlownLastLabel = new System.Windows.Forms.Label();
            this.hoursLeftThisQuarterLabel = new System.Windows.Forms.Label();
            this.hoursAvailableNextQuarterLabel = new System.Windows.Forms.Label();
            this.hoursLeftThisYearLabel = new System.Windows.Forms.Label();
            this.requiredRestLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.AccessibleName = "File name";
            this.fileNameBox.Location = new System.Drawing.Point(57, 75);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameBox.TabIndex = 1;
            this.fileNameBox.Text = "test.csv";
            // 
            // hoursThisQuarterLabel
            // 
            this.hoursThisQuarterLabel.AutoSize = true;
            this.hoursThisQuarterLabel.Location = new System.Drawing.Point(537, 43);
            this.hoursThisQuarterLabel.Name = "hoursThisQuarterLabel";
            this.hoursThisQuarterLabel.Size = new System.Drawing.Size(124, 13);
            this.hoursThisQuarterLabel.TabIndex = 2;
            this.hoursThisQuarterLabel.Text = "Hours flown this quarter: ";
            // 
            // hoursFlownLastLabel
            // 
            this.hoursFlownLastLabel.AutoSize = true;
            this.hoursFlownLastLabel.Location = new System.Drawing.Point(537, 68);
            this.hoursFlownLastLabel.Name = "hoursFlownLastLabel";
            this.hoursFlownLastLabel.Size = new System.Drawing.Size(124, 13);
            this.hoursFlownLastLabel.TabIndex = 3;
            this.hoursFlownLastLabel.Text = "Hours flown last quarter: ";
            // 
            // hoursLeftThisQuarterLabel
            // 
            this.hoursLeftThisQuarterLabel.AutoSize = true;
            this.hoursLeftThisQuarterLabel.Location = new System.Drawing.Point(537, 95);
            this.hoursLeftThisQuarterLabel.Name = "hoursLeftThisQuarterLabel";
            this.hoursLeftThisQuarterLabel.Size = new System.Drawing.Size(110, 13);
            this.hoursLeftThisQuarterLabel.TabIndex = 4;
            this.hoursLeftThisQuarterLabel.Text = "Hours left this quarter:";
            // 
            // hoursAvailableNextQuarterLabel
            // 
            this.hoursAvailableNextQuarterLabel.AutoSize = true;
            this.hoursAvailableNextQuarterLabel.Location = new System.Drawing.Point(537, 139);
            this.hoursAvailableNextQuarterLabel.Name = "hoursAvailableNextQuarterLabel";
            this.hoursAvailableNextQuarterLabel.Size = new System.Drawing.Size(142, 13);
            this.hoursAvailableNextQuarterLabel.TabIndex = 5;
            this.hoursAvailableNextQuarterLabel.Text = "Hours available next quarter:";
            // 
            // hoursLeftThisYearLabel
            // 
            this.hoursLeftThisYearLabel.AutoSize = true;
            this.hoursLeftThisYearLabel.Location = new System.Drawing.Point(537, 117);
            this.hoursLeftThisYearLabel.Name = "hoursLeftThisYearLabel";
            this.hoursLeftThisYearLabel.Size = new System.Drawing.Size(100, 13);
            this.hoursLeftThisYearLabel.TabIndex = 6;
            this.hoursLeftThisYearLabel.Text = "Hours left this year: ";
            // 
            // requiredRestLabel
            // 
            this.requiredRestLabel.AutoSize = true;
            this.requiredRestLabel.Location = new System.Drawing.Point(276, 43);
            this.requiredRestLabel.Name = "requiredRestLabel";
            this.requiredRestLabel.Size = new System.Drawing.Size(167, 13);
            this.requiredRestLabel.TabIndex = 7;
            this.requiredRestLabel.Text = "Required Rest Period Remaining: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FAR 315.269 Flight Time Regulations Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requiredRestLabel);
            this.Controls.Add(this.hoursLeftThisYearLabel);
            this.Controls.Add(this.hoursAvailableNextQuarterLabel);
            this.Controls.Add(this.hoursLeftThisQuarterLabel);
            this.Controls.Add(this.hoursFlownLastLabel);
            this.Controls.Add(this.hoursThisQuarterLabel);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label hoursThisQuarterLabel;
        private System.Windows.Forms.Label hoursFlownLastLabel;
        private System.Windows.Forms.Label hoursLeftThisQuarterLabel;
        private System.Windows.Forms.Label hoursAvailableNextQuarterLabel;
        private System.Windows.Forms.Label hoursLeftThisYearLabel;
        private System.Windows.Forms.Label requiredRestLabel;
        private System.Windows.Forms.Label label1;
    }
}

