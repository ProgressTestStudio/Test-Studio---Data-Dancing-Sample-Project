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

namespace new_test_project
{

    public class _FA_Text_Extract : BaseWebAiiTest
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
        public void _2FA_Text_Extract_CodedStep()
        {
            
            //declare var and cut its value accordingly
            string bon = GetExtractedValue("YourBonusPTag").ToString(); 
            
            bon = bon.Substring(bon.IndexOf(":")+2);
            
            Log.WriteLine(bon);
            
            //cut and assign to global var BonusCodeGlobal - create a helper class for it separately on project level
            BonusCodeGlobal.myBonusCode = bon;
           
            /*
            this is an option to use a variable in the same test and do not declare it globally
            
            SetExtractedValue("giveaname", bon);
             */     
                 
            
        }
    }
}
