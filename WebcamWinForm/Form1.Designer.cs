
namespace WebCamWinForm2020
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblVideoDevices = new System.Windows.Forms.Label();
            ddlVideoDevices = new System.Windows.Forms.ComboBox();
            btnRecord = new System.Windows.Forms.Button();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            recordingTimer = new System.Windows.Forms.Timer(components);
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVideoDevices
            // 
            lblVideoDevices.AutoSize = true;
            lblVideoDevices.Location = new System.Drawing.Point(15, 11);
            lblVideoDevices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVideoDevices.Name = "lblVideoDevices";
            lblVideoDevices.Size = new System.Drawing.Size(121, 25);
            lblVideoDevices.TabIndex = 0;
            lblVideoDevices.Text = "Video Source:";
            // 
            // ddlVideoDevices
            // 
            ddlVideoDevices.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ddlVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ddlVideoDevices.FormattingEnabled = true;
            ddlVideoDevices.Location = new System.Drawing.Point(15, 40);
            ddlVideoDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ddlVideoDevices.Name = "ddlVideoDevices";
            ddlVideoDevices.Size = new System.Drawing.Size(1178, 33);
            ddlVideoDevices.TabIndex = 1;
            // 
            // btnRecord
            // 
            btnRecord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRecord.Location = new System.Drawing.Point(1039, 81);
            btnRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new System.Drawing.Size(154, 51);
            btnRecord.TabIndex = 8;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatus });
            statusStrip.Location = new System.Drawing.Point(0, 697);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            statusStrip.Size = new System.Drawing.Size(1209, 32);
            statusStrip.TabIndex = 9;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(147, 25);
            lblStatus.Text = "Strip Status Label";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pictureBox1.Location = new System.Drawing.Point(15, 81);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1018, 612);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // recordingTimer
            // 
            recordingTimer.Interval = 17;
            recordingTimer.Tick += recordingTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1209, 729);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip);
            Controls.Add(btnRecord);
            Controls.Add(ddlVideoDevices);
            Controls.Add(lblVideoDevices);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Webcam App";
            Load += Form1_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVideoDevices;
        private System.Windows.Forms.ComboBox ddlVideoDevices;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer recordingTimer;
    }
}

