//----------------------------------------------------------------------------
//  Copyright (C) 2014 by Richard Lee. All rights reserved.
//  http://richardxlee.com
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace RileeCapture
{
    public static class FaceDetection
    {
        public static void Detect(Image<Bgr, Byte> image, String faceFileName, List<Rectangle> recFaces, List<Image<Bgr, Byte>> imgFaces, out long detectionTime)
        {
            Stopwatch watch;

            {
                //Read the HaarCascade objects
                using (CascadeClassifier faceClassifier = new CascadeClassifier(faceFileName))
                {
                    watch = Stopwatch.StartNew();
                    using (Image<Gray, Byte> gray = image.Convert<Gray, Byte>()) //Convert it to Grayscale
                    {
                        //Normalizes brightness and increases contrast of the image
                        gray._EqualizeHist();

                        //Detect the faces  from the gray scale image and store the locations as rectangle
                        //The first dimensional is the channel
                        //The second dimension is the index of the rectangle in the specific channel
                        Rectangle[] facesDetected = faceClassifier.DetectMultiScale(
                           gray,
                           1.1,
                           10,
                           new Size(20, 20),
                           Size.Empty);
                        recFaces.AddRange(facesDetected);
                        //Now for each rectangle, get the sub face image from the coordinates and store it for display later
                        foreach (Rectangle rec in facesDetected)
                            imgFaces.Add(image.GetSubRect(rec));
                    }
                    watch.Stop();
                }
            }
            detectionTime = watch.ElapsedMilliseconds;
        }
    }
}
