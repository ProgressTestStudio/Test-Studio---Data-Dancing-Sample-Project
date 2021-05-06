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

    public class Write_into_Excel__1_ : BaseWebAiiTest
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
        public void Step_1_Random_Word_Extract_and_write_to_Excel_CodedStep()
        {
                        string dataSourcePath = this.ExecutionContext.DeploymentDirectory + @"\Data\domainResults.xlsx";
                        string myPath = "C:\\My Documents\\Test Studio Projects\\Data Dancing\\Data\\domainResults.xlsx";
            
                        if (!System.IO.File.Exists(myPath))
                        {
                            System.IO.File.Copy(dataSourcePath, myPath);
                        }
            
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(myPath);
            
                        System.Threading.Thread.Sleep(1000);
                        ActiveBrowser.RefreshDomTree();
            
                        if (ActiveBrowser.ContainsText("Unavailable"))
                        {
                            excelApp.Cells[Data.IterationIndex + 2 , 1] = "Registered";
                            //excelApp.Cells[2 , 1] = "Registered";
                        }
                        if (ActiveBrowser.ContainsText("is available"))
                        {
                            excelApp.Cells[Data.IterationIndex + 2 , 1] = "Available";
                            //excelApp.Cells[2 , 1] = "Available";
                        }
            
                        excelApp.Visible = true;
                        excelApp.ActiveWorkbook.Save();
            
                        workbook.Close(false, Type.Missing, Type.Missing);
                        excelApp.Workbooks.Close();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            
                        excelApp.Quit();
                        GC.Collect();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }
}
