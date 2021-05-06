using Telerik.WebAii.Controls.Xaml.Wpf;
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
using ArtOfTest.WebAii.Wpf;

namespace Data_Dancing
{
    public class CRM_Test_1 : BaseWebAiiTest
    {
        #region [ Dynamic Applications Reference ]

        private Applications _applications;

        /// <summary>
        /// Gets the Applications object that has references
        /// to all the elements, windows or regions
        /// in this project.
        /// </summary>
        public Applications Applications
        {
            get
            {
                if (_applications == null)
                {
                    _applications = new Applications(Manager.Current);
                }
                return _applications;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"LeftClick on CellElement11Path")]
        public void CRM_Test_1_CodedStep()
        {
            // LeftClick on CellElement11Path
            Applications.CRMexe.CRM_Application__Built_with_Progress_Telerik_UI_for_WPF.CellElement11Path.User.Click(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 25, 83, ArtOfTest.Common.OffsetReference.TopLeftCorner, ArtOfTest.Common.ActionPointUnitType.Percentage, ((System.Windows.Forms.Keys)(0)));
        
          
        }
    }
}
