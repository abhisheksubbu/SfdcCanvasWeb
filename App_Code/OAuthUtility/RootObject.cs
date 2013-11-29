using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RootObject
/// </summary>
public class User
{
    public string language { get; set; }
    public string timeZone { get; set; }
    public string locale { get; set; }
    public string userName { get; set; }
    public string userId { get; set; }
    public string userType { get; set; }
    public string fullName { get; set; }
    public string email { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string profilePhotoUrl { get; set; }
    public string profileId { get; set; }
    public bool accessibilityModeEnabled { get; set; }
    public object roleId { get; set; }
    public string currencyISOCode { get; set; }
    public string profileThumbnailUrl { get; set; }
}

public class Dimensions
{
    public string width { get; set; }
    public string height { get; set; }
}

public class Environment
{
    public Dimensions dimensions { get; set; }
    public string locationUrl { get; set; }
    public string uiTheme { get; set; }
}

public class Organization
{
    public string name { get; set; }
    public string organizationId { get; set; }
    public bool multicurrencyEnabled { get; set; }
    public string currencyIsoCode { get; set; }
}

public class Links
{
    public string enterpriseUrl { get; set; }
    public string metadataUrl { get; set; }
    public string partnerUrl { get; set; }
    public string restUrl { get; set; }
    public string sobjectUrl { get; set; }
    public string searchUrl { get; set; }
    public string queryUrl { get; set; }
    public string recentItemsUrl { get; set; }
    public string userUrl { get; set; }
    public string chatterFeedsUrl { get; set; }
    public string chatterGroupsUrl { get; set; }
    public string chatterUsersUrl { get; set; }
    public string chatterFeedItemsUrl { get; set; }
}

public class Context
{
    public User user { get; set; }
    public Environment environment { get; set; }
    public Organization organization { get; set; }
    public Links links { get; set; }
}

public class Parameters
{
}

public class RootObject
{
    public Context context { get; set; }
    public string algorithm { get; set; }
    public Parameters parameters { get; set; }
    public string userId { get; set; }
    public string clientId { get; set; }
    public string instanceUrl { get; set; }
    public object issuedAt { get; set; }
    public string oauthToken { get; set; }
}