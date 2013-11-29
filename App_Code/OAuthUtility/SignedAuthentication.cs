using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml;

/// <summary>
/// Summary description for SignedAuthentication
/// </summary>
public class SignedAuthentication
{
    #region Public Methods
    /// <summary>
    /// Check if the signed_request param in Request object is from Force.com Canvas context
    /// </summary>
    /// <param name="signedRequestParam">Request.Params["signed_request"]</param>
    /// <returns>bool</returns>
    public bool IsAuthenticatedCanvasUser(string signedRequestParam)
    {
        bool IsAuthenticated = false;
        string payload = signedRequestParam.Split('.')[1];
        string expectedSignature = signedRequestParam.Split('.')[0];
        var Encoding = new UTF8Encoding();
        byte[] ActualPayload = FromUrlBase64String(payload);
        var Hmac = SignWithHMAC(ActualPayload, Encoding.GetBytes(WebConstants.ConsumerSecret));
        var HmacBase64 = ToUrlBase64String(Hmac);
        if (HmacBase64 != expectedSignature)
        {
            IsAuthenticated = true;
        }
        return IsAuthenticated;
    }

    public RootObject GetCanvasContextData(string signedRequestParam)
    {
        string payload = signedRequestParam.Split('.')[1];
        var Encoding = new UTF8Encoding();
        var decodedJson = payload.Replace("=", string.Empty).Replace('-', '+').Replace('_', '/');
        var base64JsonArray = Convert.FromBase64String(decodedJson.PadRight(decodedJson.Length + (4 - decodedJson.Length % 4) % 4, '='));
        RootObject rootobj = JsonConvert.DeserializeObject<RootObject>(Encoding.GetString(base64JsonArray));
        return rootobj;
    }

    #endregion

    #region Private Methods
    private string ToUrlBase64String(byte[] Input)
    {
        return Convert.ToBase64String(Input).Replace("=", String.Empty).Replace('+', '-').Replace('/', '_');
    }

    private byte[] FromUrlBase64String(string Base64UrlSafe)
    {
        Base64UrlSafe = Base64UrlSafe.PadRight(Base64UrlSafe.Length + (4 - Base64UrlSafe.Length % 4) % 4, '=');
        Base64UrlSafe = Base64UrlSafe.Replace('-', '+').Replace('_', '/');
        return Convert.FromBase64String(Base64UrlSafe);
    }

    private byte[] SignWithHMAC(byte[] dataToSign, byte[] keyBody)
    {
        using (var hmac = new HMACSHA256(keyBody))
        {
            hmac.ComputeHash(dataToSign);
            return hmac.Hash;
        }
    }
    #endregion

}