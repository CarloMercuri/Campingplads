using Campingplads.DataControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Campingplads
{
    public partial class _Default : Page
    {
        DatabaseInterface dbInterface;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnClick(object sender, EventArgs e)
        {
            Label1.Text = "suck it";
            //List<CampingSpotTypeInformation> list = dbInterface.GetAvaibleSpotTypesInDates(new DateTime(2021, 11, 03), new DateTime(2021, 11, 15));

            //foreach(CampingSpotTypeInformation m in list)
            //{
            //    Debug.WriteLine("");
            //    Debug.Write($"{m.SpotName} - {m.SpotType} - {m.SpotDescription} - {m.SquareMeters} - {m.MaxPeople}");
            //}

        }
    }
}