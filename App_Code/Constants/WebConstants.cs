using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WebConstants
/// </summary>
public static class WebConstants
{
    //public const string ConsumerSecret = "4806514479539779073"; // Suyati Dev Box
    public const string ConsumerSecret = "6393748103986089841";   // Partner Dev Box

    public const string StartPage = "~/Default.aspx";
    public const string TwitterAuthStartPage = "/OAuth/TwitterOAuthPage.aspx";
    public const string TwitterAuthLandingPage = "http://local.testwebapp.com/OAuth/TwitterOAuthLanding.aspx";
    public const string LinkedInAuthLandingPage = "http://local.testwebapp.com/LinkedInOAuthLanding.aspx";
    public const string GooglePlusAuthLandingPage = "https://local.testwebapp.com/GooglePlusOAuthLanding.aspx";

    public const string SocialEyeServiceURL = "http://devws.suyati.com/SocialEyeService/SocialEyeServiceImpl.svc";
    //public const string SocialEyeServiceURL = "http://localws.suyati.com/SocialEyeService/SocialEyeServiceImpl.svc";

    public const string HTTP_GET = "GET";
    public const string HTTP_POST = "POST";
    public const string HTTP_CONTENTTYPE = "application/xml; charset=utf-8";

    public const string TwitterAccessTokenKey = "TwitterAccessToken";

    public const string SignedRequestParam = "signed_request";

}