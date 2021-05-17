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

    public class Write_SQL_DB : BaseWebAiiTest
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
        public void Write_SQL_DB_CodedStep()
        {
            
// dont forget to reference using System.Data.SqlClient;
            
/* The connection string will be different depending on your environment and the name of the database, table, etc.
See http://www.connectionstrings.com for connection string examples.
*/          
SqlConnection thisConnection = new SqlConnection("Data Source=MACHINE\\SQLEXPRESS; Initial Catalog=Test Studio 1; Integrated Security=true;");
thisConnection.Open();

//Write the name of the database to the log.
Log.WriteLine(thisConnection.Database);

//Create a SQL command to insert a new value into the "City" column.
SqlCommand thisCommand = thisConnection.CreateCommand();
thisCommand.CommandText = "INSERT INTO Table_1 (Name, City, Message, Verified) VALUES ('Jovn', 'Oslo', 'Hi', 'yes')";
    
thisCommand.ExecuteNonQuery();
        }
    }
}
