using Telerik.TestStudio.Translators.Common;
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

    public class Random_Email_Generator_with_custom_domain : BaseWebAiiTest
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
    
        [CodedStep(@"Enter text '123' in 'QText' - DataDriven: [$(myrandomemail)]")]
        public void Random_Email_Generator_with_custom_domain_CodedStep()
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
            this.SetExtractedValue("myRandomEmail",sb.ToString());
            this.SetExtractedValue("ConfirmEmail",sb.ToString());
            
            // Enter text '123' in 'QText'
            //Actions.SetText(Pages.Google0.QText, ((string)(System.Convert.ChangeType(Data["myRandomEmail"], typeof(string)))));
            
        }
    }
}
