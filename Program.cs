//----------------------------------------------------------------------------
//  Copyright (C) 2014 by Richard Lee. All rights reserved.
//  http://richardxlee.com
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Emgu.CV;

namespace RileeCapture
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new RileeCapture());
      }
   }
}