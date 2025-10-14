# Finbourne.Notifications.Sdk.Model.EmailNotificationType
The information required to create or update an Email notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of delivery mechanism for this notification | 
**Subject** | **string** | The subject of the email | 
**PlainTextBody** | **string** | The plain text body of the email | 
**HtmlBody** | **string** | The HTML body of the email (if any) | [optional] 
**EmailAddressTo** | **List&lt;string&gt;** | &#39;To&#39; recipients of the email | 
**EmailAddressCc** | **List&lt;string&gt;** | &#39;Cc&#39; recipients of the email | [optional] 
**EmailAddressBcc** | **List&lt;string&gt;** | &#39;Bcc&#39; recipients of the email | [optional] 

```csharp
using Finbourne.Notifications.Sdk.Model;
using System;

string type = "type";
string subject = "subject";
string plainTextBody = "plainTextBody";
string htmlBody = "example htmlBody";
List<string> emailAddressTo = new List<string>();
List<string> emailAddressCc = new List<string>();
List<string> emailAddressBcc = new List<string>();

EmailNotificationType emailNotificationTypeInstance = new EmailNotificationType(
    type: type,
    subject: subject,
    plainTextBody: plainTextBody,
    htmlBody: htmlBody,
    emailAddressTo: emailAddressTo,
    emailAddressCc: emailAddressCc,
    emailAddressBcc: emailAddressBcc);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
