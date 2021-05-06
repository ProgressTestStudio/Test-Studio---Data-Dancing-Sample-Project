using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

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

    public class Kendo_Inline_Editing_Grid___Coded_Trim : BaseWebAiiTest
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
        public void Kendo_Inline_Editing_Grid__Coded_Trim_CodedStep()
        {
          string myData = GetExtractedValue("PIDNum").ToString();
            myData = Regex.Replace(myData, "[A-Za-z]", ""); 
            SetExtractedValue("PIDNum", myData);
    
  
        }
    
        //[CodedStep(@"Enter text '1234' in 'ProductNameText' - DataDriven: [$(PIDNum)]")]
       // public void Kendo_Inline_Editing_Grid__Coded_Trim_CodedStep1()
        //{
            // Enter text '1234' in 'ProductNameText'
         //   Actions.SetText(Pages.ApplyingInlineEditingIn.ProductNameText, ((string)(System.Convert.ChangeType(Data["PIDNum"], typeof(string)))));
            
        //}
    
        [CodedStep(@"Click 'Span'")]
        public void Kendo_Inline_Editing_Grid__Coded_Trim_CodedStep1()
        {
            // Click 'Span1'
            Pages.ApplyingInlineEditingIn.Span1.Click(false);
            
        }
    
        [CodedStep(@"Enter text '1234' in 'ProductNameText1' - DataDriven: [$(PIDNum)]")]
        public void Kendo_Inline_Editing_Grid__Coded_Trim_CodedStep2()
        {
            // Enter text '1234' in 'ProductNameText1'
            Actions.SetText(Pages.ApplyingInlineEditingIn.ProductNameText1, "");
            //Pages.ApplyingInlineEditingIn.ProductNameText1.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            Pages.ApplyingInlineEditingIn.ProductNameText1.Focus();
            Pages.ApplyingInlineEditingIn.ProductNameText1.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["PIDNum"], typeof(string)))), 50, 100, true);
            
        }
    }
}
