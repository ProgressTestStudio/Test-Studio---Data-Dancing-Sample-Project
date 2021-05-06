using Telerik.WebAii.Controls.Xaml;
using Telerik.WebAii.Controls.Html;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestStudio.Translators.Common;
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

    public class Blazor_Dashboard : BaseWebAiiTest
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

        [CodedStep(@"Enter text 'test' in 'Text'")]
        public void Blazor_Dashboard_CodedStep()
        {

        }

        [CodedStep(@"Enter text 'test' in 'Text' - DataDriven: [$(myRandomEmail)]")]
        public void Blazor_Dashboard_CodedStep1()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            char ch;
            for (int ctr = 0; ctr < 9; ctr++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rnd.NextDouble() + 65)));
                sb.Append(ch);
            }
            sb.Append("@GMAIL.COM");
            this.SetExtractedValue("myRandomEmail", sb.ToString());
            this.SetExtractedValue("ConfirmEmail", sb.ToString()); 
            // Enter text 'test' in 'Text'
            Actions.SetText(Pages.TelerikUIForBlazor0.Text, "");
            Pages.TelerikUIForBlazor0.Text.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            ActiveBrowser.Window.SetFocus();
            Pages.TelerikUIForBlazor0.Text.Focus();
            Pages.TelerikUIForBlazor0.Text.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["myRandomEmail"], typeof(string)))), 50, 100, true);
        }     

        #endregion

        // Add your test methods here...
    
        [CodedStep(@"Verify 'TextContent' 'Contains' 'Blazor UI' on 'AppTitleH1Tag' - DataDriven: [$(results)]")]
        public void Blazor_Dashboard_CodedStep2()
        {
            // Verify 'TextContent' 'Contains' 'Blazor UI' on 'AppTitleH1Tag'
            Pages.TelerikUIForBlazor.AppTitleH1Tag.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, ((string)(System.Convert.ChangeType(Data["results"], typeof(string)))));
            
        }

        [CodedStep(@"TelerikBlazorGrid: 'Data' items count 'Equals' '15'.")]
        public void Blazor_Dashboard_CodedStep3()
        {
            // TelerikBlazorGrid: 'Data' items count 'Equals' '15'.
            Pages.TelerikUIForBlazor1.Div.ControlAssert().NumberValue("DataItems.Count", 15, ArtOfTest.Common.NumberCompareType.Equals);
            
        }
    }
}
