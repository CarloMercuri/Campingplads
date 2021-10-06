using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Campingplads.Pages
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderButtonCabin.ImageUrl = "~/Images/hytte_final.png";
            OrderButtonTent.ImageUrl = "~/Images/tent_final.png";
            OrderButtonWagon.ImageUrl = "~/Images/campingvogn_final.png";
            ButtonAdventure.ImageUrl = "~/Images/oplevelser_final.png";
            OrderButton.ImageUrl = "~/Images/dato_final.png";
            OrderButtonOffer.ImageUrl = "~/Images/tilbud_final.png";
        }

        protected void TypeButtonClick(object sender, EventArgs e)
        {
            ImageButton btn = sender as ImageButton;
            string parameter = "";

            switch (btn.ID)
            {
                case "OrderButtonCabin":
                    parameter = "cabin";
                    break;

                case "OrderButtonTent":
                    parameter = "tent";
                    break;

                case "OrderButtonWagon":
                    parameter = "wagon";
                    break;

            }
            Response.Redirect("SpotInfo.aspx?Type=" + parameter);


        }
    }
}