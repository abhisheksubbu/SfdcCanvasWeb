using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool IsCanvasContext = false;
        SignedAuthentication auth = new SignedAuthentication();
        if (Request.Params[WebConstants.SignedRequestParam] != null)
        {
            IsCanvasContext = auth.IsAuthenticatedCanvasUser(Request.Params[WebConstants.SignedRequestParam]);
        }

        if (IsCanvasContext)
        {
            //Proper Canvas Context
            RootObject contextObj = auth.GetCanvasContextData(Request.Params[WebConstants.SignedRequestParam]);
            lbl_Greet.Text = "Canvas Context User : " + contextObj.context.user.fullName;
            
        }
        else
        {
            //Not from Canvas Context
            lbl_Greet.Text = "Hi Anonymous User";
        }
    }
}