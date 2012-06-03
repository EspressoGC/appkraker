/**
Copyright (C) 2012 KryptonX.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files
(the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

- The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
**/

namespace appkraker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitPanel = new System.Windows.Forms.SplitContainer();
            this.toppanel = new System.Windows.Forms.Panel();
            this.knownLengthButton = new System.Windows.Forms.RadioButton();
            this.doesnotknowLength = new System.Windows.Forms.RadioButton();
            this.digitOnly = new System.Windows.Forms.CheckBox();
            this.printLog = new System.Windows.Forms.CheckBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.bottomLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileOptionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fileOptionsLabel = new System.Windows.Forms.Label();
            this.outPutFileLocation = new System.Windows.Forms.TextBox();
            this.blockSplitter = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.targetText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.rightSplitter = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wrongpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).BeginInit();
            this.splitPanel.Panel1.SuspendLayout();
            this.splitPanel.Panel2.SuspendLayout();
            this.splitPanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.bottomLayoutPanel.SuspendLayout();
            this.fileOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockSplitter)).BeginInit();
            this.blockSplitter.Panel1.SuspendLayout();
            this.blockSplitter.Panel2.SuspendLayout();
            this.blockSplitter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitter)).BeginInit();
            this.rightSplitter.Panel1.SuspendLayout();
            this.rightSplitter.Panel2.SuspendLayout();
            this.rightSplitter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitPanel
            // 
            this.splitPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel.IsSplitterFixed = true;
            this.splitPanel.Location = new System.Drawing.Point(0, 0);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPanel.Panel1
            // 
            this.splitPanel.Panel1.Controls.Add(this.toppanel);
            // 
            // splitPanel.Panel2
            // 
            this.splitPanel.Panel2.Controls.Add(this.bottomLayoutPanel);
            this.splitPanel.Size = new System.Drawing.Size(453, 200);
            this.splitPanel.SplitterDistance = 60;
            this.splitPanel.TabIndex = 0;
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.knownLengthButton);
            this.toppanel.Controls.Add(this.doesnotknowLength);
            this.toppanel.Controls.Add(this.digitOnly);
            this.toppanel.Controls.Add(this.printLog);
            this.toppanel.Controls.Add(this.mainButton);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(449, 56);
            this.toppanel.TabIndex = 0;
            // 
            // knownLengthButton
            // 
            this.knownLengthButton.AutoSize = true;
            this.knownLengthButton.Enabled = false;
            this.knownLengthButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.knownLengthButton.Location = new System.Drawing.Point(330, 30);
            this.knownLengthButton.Name = "knownLengthButton";
            this.knownLengthButton.Size = new System.Drawing.Size(108, 19);
            this.knownLengthButton.TabIndex = 4;
            this.knownLengthButton.Text = "Known length";
            this.knownLengthButton.UseVisualStyleBackColor = true;
            // 
            // doesnotknowLength
            // 
            this.doesnotknowLength.AutoSize = true;
            this.doesnotknowLength.Checked = true;
            this.doesnotknowLength.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.doesnotknowLength.Location = new System.Drawing.Point(330, 7);
            this.doesnotknowLength.Name = "doesnotknowLength";
            this.doesnotknowLength.Size = new System.Drawing.Size(122, 19);
            this.doesnotknowLength.TabIndex = 3;
            this.doesnotknowLength.TabStop = true;
            this.doesnotknowLength.Text = "Unknown length";
            this.doesnotknowLength.UseVisualStyleBackColor = true;
            // 
            // digitOnly
            // 
            this.digitOnly.AutoSize = true;
            this.digitOnly.Checked = true;
            this.digitOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digitOnly.Enabled = false;
            this.digitOnly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digitOnly.Location = new System.Drawing.Point(3, 31);
            this.digitOnly.Name = "digitOnly";
            this.digitOnly.Size = new System.Drawing.Size(89, 19);
            this.digitOnly.TabIndex = 2;
            this.digitOnly.Text = "Digits Only";
            this.digitOnly.UseVisualStyleBackColor = true;
            this.digitOnly.CheckedChanged += new System.EventHandler(this.digitOnly_CheckedChanged);
            // 
            // printLog
            // 
            this.printLog.AutoSize = true;
            this.printLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printLog.Location = new System.Drawing.Point(3, 7);
            this.printLog.Name = "printLog";
            this.printLog.Size = new System.Drawing.Size(112, 19);
            this.printLog.TabIndex = 1;
            this.printLog.Text = "Print log to file";
            this.printLog.UseVisualStyleBackColor = true;
            this.printLog.CheckedChanged += new System.EventHandler(this.printLog_CheckedChanged);
            // 
            // mainButton
            // 
            this.mainButton.Enabled = false;
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mainButton.Font = new System.Drawing.Font("Andy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(166, 7);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(117, 44);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Krak It!";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // bottomLayoutPanel
            // 
            this.bottomLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.bottomLayoutPanel.ColumnCount = 3;
            this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.94186F));
            this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.05814F));
            this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.bottomLayoutPanel.Controls.Add(this.fileOptionsPanel, 0, 0);
            this.bottomLayoutPanel.Controls.Add(this.blockSplitter, 1, 0);
            this.bottomLayoutPanel.Controls.Add(this.rightSplitter, 2, 0);
            this.bottomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomLayoutPanel.Name = "bottomLayoutPanel";
            this.bottomLayoutPanel.RowCount = 1;
            this.bottomLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomLayoutPanel.Size = new System.Drawing.Size(449, 132);
            this.bottomLayoutPanel.TabIndex = 0;
            // 
            // fileOptionsPanel
            // 
            this.fileOptionsPanel.Controls.Add(this.fileOptionsLabel);
            this.fileOptionsPanel.Controls.Add(this.outPutFileLocation);
            this.fileOptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileOptionsPanel.Enabled = false;
            this.fileOptionsPanel.Location = new System.Drawing.Point(5, 5);
            this.fileOptionsPanel.Name = "fileOptionsPanel";
            this.fileOptionsPanel.Size = new System.Drawing.Size(96, 122);
            this.fileOptionsPanel.TabIndex = 0;
            // 
            // fileOptionsLabel
            // 
            this.fileOptionsLabel.AutoSize = true;
            this.fileOptionsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOptionsLabel.Location = new System.Drawing.Point(3, 0);
            this.fileOptionsLabel.Name = "fileOptionsLabel";
            this.fileOptionsLabel.Size = new System.Drawing.Size(79, 28);
            this.fileOptionsLabel.TabIndex = 0;
            this.fileOptionsLabel.Text = "Output File Location";
            // 
            // outPutFileLocation
            // 
            this.outPutFileLocation.Location = new System.Drawing.Point(3, 31);
            this.outPutFileLocation.Name = "outPutFileLocation";
            this.outPutFileLocation.Size = new System.Drawing.Size(79, 22);
            this.outPutFileLocation.TabIndex = 1;
            // 
            // blockSplitter
            // 
            this.blockSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockSplitter.IsSplitterFixed = true;
            this.blockSplitter.Location = new System.Drawing.Point(109, 5);
            this.blockSplitter.Name = "blockSplitter";
            this.blockSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // blockSplitter.Panel1
            // 
            this.blockSplitter.Panel1.Controls.Add(this.panel1);
            // 
            // blockSplitter.Panel2
            // 
            this.blockSplitter.Panel2.Controls.Add(this.panel2);
            this.blockSplitter.Size = new System.Drawing.Size(232, 122);
            this.blockSplitter.SplitterDistance = 25;
            this.blockSplitter.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.targetText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 23);
            this.panel1.TabIndex = 0;
            // 
            // targetText
            // 
            this.targetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetText.Location = new System.Drawing.Point(0, 0);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(230, 22);
            this.targetText.TabIndex = 1;
            this.targetText.Text = "[.target app path here]";
            this.targetText.TextChanged += new System.EventHandler(this.targetText_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 91);
            this.panel2.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Location = new System.Drawing.Point(0, 0);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(230, 91);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "[.waiting]";
            // 
            // rightSplitter
            // 
            this.rightSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSplitter.Location = new System.Drawing.Point(349, 5);
            this.rightSplitter.Name = "rightSplitter";
            this.rightSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightSplitter.Panel1
            // 
            this.rightSplitter.Panel1.Controls.Add(this.panel3);
            // 
            // rightSplitter.Panel2
            // 
            this.rightSplitter.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.rightSplitter.Size = new System.Drawing.Size(95, 122);
            this.rightSplitter.SplitterDistance = 81;
            this.rightSplitter.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wrongpass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 77);
            this.panel3.TabIndex = 3;
            // 
            // wrongpass
            // 
            this.wrongpass.Location = new System.Drawing.Point(3, 29);
            this.wrongpass.Name = "wrongpass";
            this.wrongpass.Size = new System.Drawing.Size(86, 22);
            this.wrongpass.TabIndex = 1;
            this.wrongpass.Text = "error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "error output:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(91, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(453, 200);
            this.Controls.Add(this.splitPanel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "appkraker v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitPanel.Panel1.ResumeLayout(false);
            this.splitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel)).EndInit();
            this.splitPanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.bottomLayoutPanel.ResumeLayout(false);
            this.fileOptionsPanel.ResumeLayout(false);
            this.fileOptionsPanel.PerformLayout();
            this.blockSplitter.Panel1.ResumeLayout(false);
            this.blockSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blockSplitter)).EndInit();
            this.blockSplitter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rightSplitter.Panel1.ResumeLayout(false);
            this.rightSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitter)).EndInit();
            this.rightSplitter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitPanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.CheckBox digitOnly;
        private System.Windows.Forms.CheckBox printLog;
        private System.Windows.Forms.RadioButton doesnotknowLength;
        private System.Windows.Forms.RadioButton knownLengthButton;
        private System.Windows.Forms.TableLayoutPanel bottomLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel fileOptionsPanel;
        private System.Windows.Forms.Label fileOptionsLabel;
        private System.Windows.Forms.TextBox outPutFileLocation;
        private System.Windows.Forms.SplitContainer blockSplitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.SplitContainer rightSplitter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox wrongpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}

