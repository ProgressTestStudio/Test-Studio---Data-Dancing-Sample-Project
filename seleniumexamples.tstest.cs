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

    public class seleniumexamples : BaseWebAiiTest
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
    
        [CodedStep(@"Enter text 'testuser2@progress.com' in 'EmailCreateText'")]
        public void seleniumexamples_CodedStep()
        {
            // Enter text 'testuser2@progress.com' in 'EmailCreateText'
            Actions.SetText(Pages.MyStore.EmailCreateText, "");
            Pages.MyStore.EmailCreateText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            ActiveBrowser.Window.SetFocus();
            Pages.MyStore.EmailCreateText.Focus();
            Pages.MyStore.EmailCreateText.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(DateTime.Now.ToString("MMddyyyy") + "u@progress.com", 50, 100, true);
            
        }
    
        [CodedStep(@"New Coded Step")]
        public void seleniumexamples_CodedStep1()
        {
             // Enter text 'testuser2@progress.com' in 'EmailCreateText'
            Actions.SetText(Pages.MyStore.EmailCreateText, "");
            Pages.MyStore.EmailCreateText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            ActiveBrowser.Window.SetFocus();
            Pages.MyStore.EmailCreateText.Focus();
            Pages.MyStore.EmailCreateText.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(Guid.NewGuid().ToString() + "u@progress.com", 50, 100, true);
            
        }
    }
}
