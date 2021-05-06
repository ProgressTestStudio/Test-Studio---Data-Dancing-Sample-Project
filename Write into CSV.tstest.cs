using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Threading;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace Data_Dancing
{

    public class Write_into_CSV : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void Write_into_CSV_CodedStep()
        {
           DateTime now = DateTime.Now;
           DateTime utcDate = DateTime.UtcNow;
           String[] cultureNames = { "en-US" };
            
           Stopwatch stopWatch = new Stopwatch();
           stopWatch.Start();
            
           Thread.Sleep(10000);
            
           stopWatch.Stop();
           
        // Get the elapsed time as a TimeSpan value.
           System.TimeSpan ts = stopWatch.Elapsed;

           var elapsedTime = stopWatch.Elapsed.TotalMilliseconds;
           
            Log.WriteLine("RunTime " + elapsedTime);
            Log.WriteLine(utcDate.ToString("F"));
            
            var filePath = @"C:\test.csv";  
            var delimiter = ", ";  
            var runat = "RUN AT: " ;
            var dur = "DURATION (ms): ";
            var warn = "WARNING! ";
           
           if (elapsedTime > 5000 && elapsedTime < 7000)
           {
            File.AppendAllText(filePath, warn.ToString());
            File.AppendAllText(filePath, runat.ToString());
            File.AppendAllText(filePath, utcDate.ToString());
            File.AppendAllText(filePath, delimiter.ToString());
            File.AppendAllText(filePath, dur.ToString());
            File.AppendAllText(filePath, elapsedTime.ToString());
            File.AppendAllText(filePath, delimiter.ToString());
            File.AppendAllText(filePath, "\n");
           }
           else 
           {
            File.AppendAllText(filePath, runat.ToString());
            File.AppendAllText(filePath, utcDate.ToString());
            File.AppendAllText(filePath, delimiter.ToString());
            File.AppendAllText(filePath, dur.ToString());
            File.AppendAllText(filePath, elapsedTime.ToString());
            File.AppendAllText(filePath, delimiter.ToString());
            File.AppendAllText(filePath, "\n");
           }
           
         //  System.IO.File.Delete(filePath);
           
           
           
           if (elapsedTime > 50000)
           {
                Log.WriteLine("WARNING");
           }
            
        }
    }
}
