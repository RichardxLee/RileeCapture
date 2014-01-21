//----------------------------------------------------------------------------
//  Copyright (C) 2014 by Richard Lee. All rights reserved.
//  http://richardxlee.com
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace RileeCapture
{
    public partial class RileeCapture : Form
    {

        private Capture _capture = null;
        private Rectangle _rectSelectedArea;
        private List<Image<Bgr, Byte>> _limgCroppedMaster = new List<Image<Bgr, byte>>();    //all of the 5 cropped images to be recognized for object recognition
        private List<Emgu.CV.UI.ImageBox> _limgMasters = new List<Emgu.CV.UI.ImageBox>();   //all of the 5 recognition boxes on the bottom of the UI

        public RileeCapture()
        {
            InitializeComponent();

            btnDrawMasterImage.Enabled = false;

            //initialization for recognition boxes
            _limgMasters.Add(imbMaster1);
            _limgMasters.Add(imbMaster2);
            _limgMasters.Add(imbMaster3);
            _limgMasters.Add(imbMaster4);
            _limgMasters.Add(imbMaster5);

            try
            {
                _capture = new Capture();
                _capture.ImageGrabbed += ProcessFrame;
                _capture.Start();
                tslStatus.Text = "Capture started";
                //flip horizontal to natural
                //if ((_capture != null)&&(!_capture.FlipHorizontal)) _capture.FlipHorizontal = true;
            }
            catch (NullReferenceException ex)
            {
                tslStatus.Text = "Capture initialization failed...";
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            //get captured image from camera
            Image<Bgr, Byte> frame = _capture.RetrieveBgrFrame();

            #region facial recognition
            if (chbFaceDetection.Checked) {

                //face detection
                long detectionTime;
                List<Rectangle> recFaces = new List<Rectangle>();
                List<Image<Bgr, Byte>> faces = new List<Image<Bgr, Byte>>();
                FaceDetection.Detect(frame, "haarcascade_frontalface_default.xml", recFaces, faces, out detectionTime);
                foreach (Rectangle rec in recFaces)
                    frame.Draw(rec, new Bgr(Color.Red), 2);

                //display recognized objects in recognition boxes and update status
                if (faces.Count > 0)
                {
                    int faceCount = 0;
                    for (int i = 0; (i < faces.Count) && (i < 5); i++)
                    {
                        _limgMasters[i].Image = faces[i];
                        faceCount = i;
                    }
                    for (int j = faceCount + 1; j < 5; j++)
                    {
                        _limgMasters[j].Image = null;
                    }
                }
                else
                {
                    clearAllRecognitionBoxes();
                }
                tslStatus.Text = faces.Count + ((faces.Count>1)?" faces":" face") + " detected in " + detectionTime + " milliseconds";
            }
            #endregion

            #region object recognition
            else if (chbObjectRecognition.Checked)
            {
                long matchTime = 0;
                if (!btnDrawMasterImage.Enabled){
                    frame = SURFMatch.Draw(_limgCroppedMaster, frame, out matchTime);
                }
                tslStatus.Text = _limgCroppedMaster.Count + ((_limgCroppedMaster.Count > 1) ? " objects" : " object") + " detected in " + matchTime + " milliseconds";
            }
            #endregion

            else{
                resetCameraCapture();
            }
            

            //display the image
            picCaptured.Image = frame.ToBitmap();

            //delay for displaying the image each round to the user
            Thread.Sleep(10);
        }

        private void clearAllRecognitionBoxes()
        {
            for (int i = 0; i < 5; i++)
                _limgMasters[i].Image = null;
        }

        private void releaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void resetCameraCapture()
        {
            //quick reset
            tslStatus.Text = "resetting Emgu from previous recognitions...";
            _capture.Stop();
            Thread.Sleep(500);
            _limgCroppedMaster.Clear();
            clearAllRecognitionBoxes();
            Thread.Sleep(50);
            _capture.Start();
            //clear recognition boxes and update status
            tslStatus.Text = "Capture started";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            releaseData();
            Application.Exit();
        }

        private void btnDrawMasterImage_Click(object sender, EventArgs e)
        {
            this.btnDrawMasterImage.Text = "&Object Recognition";
            this.btnDrawMasterImage.Enabled = false;
        }

        private void chbFaceDetection_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFaceDetection.Checked)
                this.chbObjectRecognition.Checked = false;
            else{
                resetCameraCapture();
            }
        }

        private void chbObjectRecognition_CheckedChanged(object sender, EventArgs e)
        {
            if (chbObjectRecognition.Checked){
                this.chbFaceDetection.Checked = false;
                this.btnDrawMasterImage.Enabled = true;
                tslStatus.Text = "Please draw rectangles on screen over the objects want to be recognized...";
                this.btnDrawMasterImage.Text = "Finished Drawing";
            }
            else{
                resetCameraCapture();
            }
        }

        private void picCaptured_MouseDown(object sender, MouseEventArgs e)
        {
            //when first mouse down is detected, initialize the rectangle
            if (btnDrawMasterImage.Enabled)
            {
                _rectSelectedArea = new Rectangle(e.X, e.Y, 0, 0);
                this.Invalidate();
            }
        }

        private void picCaptured_MouseMove(object sender, MouseEventArgs e)
        {
            //when mouse is moving, update rectangle and drawing
            if (btnDrawMasterImage.Enabled)
            {
                if (e.Button == MouseButtons.Left){
                    //draw the rectangle as the mouse moves
                    _rectSelectedArea = new Rectangle(
                        _rectSelectedArea.Left,
                        _rectSelectedArea.Top, 
                        e.X - _rectSelectedArea.Left,
                        e.Y - _rectSelectedArea.Top);
                }
                this.Invalidate();
            }
        }

        private void picCaptured_Paint(object sender, PaintEventArgs e)
        {
            //update drawing
            if (btnDrawMasterImage.Enabled)
            {
                using(Pen pen = new Pen(Color.Red, 3)){
                    e.Graphics.DrawRectangle(pen, _rectSelectedArea);
                }
            }
        }

        private void picCaptured_MouseUp(object sender, MouseEventArgs e)
        {
            //when mouse is up, finalize the rectangle and update drawing
            if (btnDrawMasterImage.Enabled)
            {
                if(e.Button == MouseButtons.Left){
                    Bitmap bmp = new Bitmap(_rectSelectedArea.Width, _rectSelectedArea.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(picCaptured.Image, 0, 0, _rectSelectedArea, GraphicsUnit.Pixel);
                    Image<Bgr, Byte> tmpCroppedImage = new Image<Bgr, Byte>(bmp);
                    _limgCroppedMaster.Add(tmpCroppedImage);
                    //show cropped images on recognition boxes
                    for (int i = 0; i < _limgCroppedMaster.Count; i++)
                        _limgMasters[i].Image = _limgCroppedMaster[i];
                    //clear rectangle
                    _rectSelectedArea = new Rectangle();
                    this.Invalidate();
                }
            }
        }

        



   }
}
