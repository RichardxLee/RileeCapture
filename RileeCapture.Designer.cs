namespace RileeCapture
{
    partial class RileeCapture
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
            releaseData();
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
            this.components = new System.ComponentModel.Container();
            this.pnlControls = new System.Windows.Forms.GroupBox();
            this.btnDrawMasterImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chbObjectRecognition = new System.Windows.Forms.CheckBox();
            this.chbFaceDetection = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.imbMaster5 = new Emgu.CV.UI.ImageBox();
            this.imbMaster4 = new Emgu.CV.UI.ImageBox();
            this.imbMaster3 = new Emgu.CV.UI.ImageBox();
            this.imbMaster2 = new Emgu.CV.UI.ImageBox();
            this.imbMaster1 = new Emgu.CV.UI.ImageBox();
            this.pnlModes = new System.Windows.Forms.GroupBox();
            this.picCaptured = new System.Windows.Forms.PictureBox();
            this.pnlControls.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster1)).BeginInit();
            this.pnlModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptured)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnDrawMasterImage);
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Location = new System.Drawing.Point(640, 118);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(190, 342);
            this.pnlControls.TabIndex = 3;
            this.pnlControls.TabStop = false;
            this.pnlControls.Text = "Controls";
            // 
            // btnDrawMasterImage
            // 
            this.btnDrawMasterImage.Location = new System.Drawing.Point(22, 38);
            this.btnDrawMasterImage.Name = "btnDrawMasterImage";
            this.btnDrawMasterImage.Size = new System.Drawing.Size(146, 39);
            this.btnDrawMasterImage.TabIndex = 4;
            this.btnDrawMasterImage.Text = "&Object Recognition";
            this.btnDrawMasterImage.UseVisualStyleBackColor = true;
            this.btnDrawMasterImage.Click += new System.EventHandler(this.btnDrawMasterImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 83);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chbObjectRecognition
            // 
            this.chbObjectRecognition.AutoSize = true;
            this.chbObjectRecognition.Location = new System.Drawing.Point(22, 52);
            this.chbObjectRecognition.Name = "chbObjectRecognition";
            this.chbObjectRecognition.Size = new System.Drawing.Size(117, 17);
            this.chbObjectRecognition.TabIndex = 5;
            this.chbObjectRecognition.Text = "Object Recognition";
            this.chbObjectRecognition.UseVisualStyleBackColor = true;
            this.chbObjectRecognition.CheckedChanged += new System.EventHandler(this.chbObjectRecognition_CheckedChanged);
            // 
            // chbFaceDetection
            // 
            this.chbFaceDetection.AutoSize = true;
            this.chbFaceDetection.Location = new System.Drawing.Point(22, 29);
            this.chbFaceDetection.Name = "chbFaceDetection";
            this.chbFaceDetection.Size = new System.Drawing.Size(99, 17);
            this.chbFaceDetection.TabIndex = 4;
            this.chbFaceDetection.Text = "Face Detection";
            this.chbFaceDetection.UseVisualStyleBackColor = true;
            this.chbFaceDetection.CheckedChanged += new System.EventHandler(this.chbFaceDetection_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(70, 17);
            this.tslStatus.Text = "Initializing...";
            // 
            // imbMaster5
            // 
            this.imbMaster5.Location = new System.Drawing.Point(532, 466);
            this.imbMaster5.Name = "imbMaster5";
            this.imbMaster5.Size = new System.Drawing.Size(100, 100);
            this.imbMaster5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imbMaster5.TabIndex = 8;
            this.imbMaster5.TabStop = false;
            // 
            // imbMaster4
            // 
            this.imbMaster4.Location = new System.Drawing.Point(402, 466);
            this.imbMaster4.Name = "imbMaster4";
            this.imbMaster4.Size = new System.Drawing.Size(100, 100);
            this.imbMaster4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imbMaster4.TabIndex = 7;
            this.imbMaster4.TabStop = false;
            // 
            // imbMaster3
            // 
            this.imbMaster3.Location = new System.Drawing.Point(272, 466);
            this.imbMaster3.Name = "imbMaster3";
            this.imbMaster3.Size = new System.Drawing.Size(100, 100);
            this.imbMaster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imbMaster3.TabIndex = 6;
            this.imbMaster3.TabStop = false;
            // 
            // imbMaster2
            // 
            this.imbMaster2.Location = new System.Drawing.Point(142, 466);
            this.imbMaster2.Name = "imbMaster2";
            this.imbMaster2.Size = new System.Drawing.Size(100, 100);
            this.imbMaster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imbMaster2.TabIndex = 5;
            this.imbMaster2.TabStop = false;
            // 
            // imbMaster1
            // 
            this.imbMaster1.Location = new System.Drawing.Point(12, 466);
            this.imbMaster1.Name = "imbMaster1";
            this.imbMaster1.Size = new System.Drawing.Size(100, 100);
            this.imbMaster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imbMaster1.TabIndex = 2;
            this.imbMaster1.TabStop = false;
            // 
            // pnlModes
            // 
            this.pnlModes.Controls.Add(this.chbObjectRecognition);
            this.pnlModes.Controls.Add(this.chbFaceDetection);
            this.pnlModes.Location = new System.Drawing.Point(640, 12);
            this.pnlModes.Name = "pnlModes";
            this.pnlModes.Size = new System.Drawing.Size(190, 100);
            this.pnlModes.TabIndex = 9;
            this.pnlModes.TabStop = false;
            this.pnlModes.Text = "Recognition Modes";
            // 
            // picCaptured
            // 
            this.picCaptured.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCaptured.Location = new System.Drawing.Point(12, 12);
            this.picCaptured.Name = "picCaptured";
            this.picCaptured.Size = new System.Drawing.Size(622, 448);
            this.picCaptured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptured.TabIndex = 10;
            this.picCaptured.TabStop = false;
            this.picCaptured.Paint += new System.Windows.Forms.PaintEventHandler(this.picCaptured_Paint);
            this.picCaptured.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCaptured_MouseDown);
            this.picCaptured.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCaptured_MouseMove);
            this.picCaptured.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCaptured_MouseUp);
            // 
            // RileeCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 599);
            this.Controls.Add(this.picCaptured);
            this.Controls.Add(this.pnlModes);
            this.Controls.Add(this.imbMaster5);
            this.Controls.Add(this.imbMaster4);
            this.Controls.Add(this.imbMaster3);
            this.Controls.Add(this.imbMaster2);
            this.Controls.Add(this.imbMaster1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlControls);
            this.Name = "RileeCapture";
            this.Text = "Rilee Capture";
            this.pnlControls.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbMaster1)).EndInit();
            this.pnlModes.ResumeLayout(false);
            this.pnlModes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlControls;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private Emgu.CV.UI.ImageBox imbMaster1;
        private Emgu.CV.UI.ImageBox imbMaster2;
        private Emgu.CV.UI.ImageBox imbMaster3;
        private Emgu.CV.UI.ImageBox imbMaster4;
        private Emgu.CV.UI.ImageBox imbMaster5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chbFaceDetection;
        private System.Windows.Forms.CheckBox chbObjectRecognition;
        private System.Windows.Forms.GroupBox pnlModes;
        private System.Windows.Forms.PictureBox picCaptured;
        private System.Windows.Forms.Button btnDrawMasterImage;

    }
}