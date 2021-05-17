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
using System.Data.SqlClient;
 

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace new_test_project
{

    public class csv__1_ : BaseWebAiiTest
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
        public void csv_CodedStep()
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
            
/*         formatting options of choice
           
           var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
*/
           var elapsedTime = stopWatch.Elapsed.TotalMilliseconds;
           
           Log.WriteLine("RunTime " + elapsedTime);
           Log.WriteLine(utcDate.ToString("F"));
            
           
           // dont forget to reference using System.Data.SqlClient;
            
/*         The connection string will be different depending on your environment and the name of the database, table, etc.
           See http://www.connectionstrings.com for connection string examples.
*/          
           SqlConnection thisConnection = new SqlConnection("Data Source=MACHINE\\SQLEXPRESS; Initial Catalog=Test Studio 1; Integrated Security=true;");
           thisConnection.Open();
           
           //Write the name of the database to the log.
           Log.WriteLine(thisConnection.Database);

           //Write the elapsed time
           SqlCommand thisCommand = thisConnection.CreateCommand();
           thisCommand.CommandText = "INSERT INTO Table_2 (Result) VALUES (@text)";
           thisCommand.Parameters.AddWithValue("@text", elapsedTime);
            
            
           thisCommand.ExecuteNonQuery();
           
           
           if (elapsedTime > 50000)
           {
           Log.WriteLine("WARNING");
           }
            
          
        }
    }
}
