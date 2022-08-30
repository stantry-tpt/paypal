---
hidden: true
nav_title: Rich Notifications
article_title: Rich Push Notifications for iOS
platform: iOS
page_order: 3
description: "This article covers implementing rich push notifications in your iOS application."
channel:
  - push

---

# iOS 10 rich notifications

iOS 10 introduces the ability to send push notifications with images, gifs, and video. To enable this functionality, clients must create a `Service Extension`, a new type of extension that enables modification of a push payload before it is displayed.

## Creating a service extension

To create a [`Notification Service Extension`][23], navigate to **File > New > Target** in Xcode and select **Notification Service Extension**.

![][26]{: style="max-width:90%"}

Ensure that **Embed In Application** is set to embed the extension in your application.

## Setting up the service extension

A `Notification Service Extension` is its own binary that is bundled with your app. It must be set up in the [Apple Developer Portal][27] with its own app ID and provisioning profile.

The `Notification Service Extension`'s bundle ID must be distinct from your main app target's bundle ID. For example, if your app's bundle ID is `com.company.appname`, you can use `com.company.appname.AppNameServiceExtension` for your service extension.

### Configuring the service extension to work with Braze

Braze sends down an attachment payload in the APNs payload under the `ab` key that we use to configure, download and display rich content. For example:

```json
{
  "ab" :
    {
    ...

    "att" :
      {
       "url" : "http://mysite.com/myimage.jpg",
       "type" : "jpg"
       }
    },
  "aps" :
    {
    ...
    }
}
```

The relevant payload values are:

```objc
// The Braze dictionary key
static NSString *const AppboyAPNSDictionaryKey = @"ab";

// The attachment dictionary
static NSString *const AppboyAPNSDictionaryAttachmentKey = @"att";

// The attachment URL
static NSString *const AppboyAPNSDictionaryAttachmentURLKey = @"url";

// The type of the attachment - a suffix for the file you save
static NSString *const AppboyAPNSDictionaryAttachmentTypeKey = @"type";
```

To manually display push with a Braze payload, download the content from the value under `AppboyAPNSDictionaryAttachmentURLKey`, save it as a file with the file type stored under the `AppboyAPNSDictionaryAttachmentTypeKey` key, and add it to the notification attachments.

### Sample code

You can write the service extension in either Objective-C or Swift.

To use our Objective-C sample code, replace the contents of your `Notification Service Extension` target's autogenerated `NotificationService.m` with the contents from the Appboy [`NotificationService.m`][1].

To use our Swift sample code, replace the contents of your `Notification Service Extension` target's autogenerated `NotificationService.swift` with the contents from the Appboy [`NotificationService.swift`][2].

## Creating a rich notification in your dashboard

To create a rich notification in your Braze dashboard, create an iOS push, attach an image or GIF, or provide a URL that hosts an image, GIF, or video. Note that assets are downloaded on the receipt of push notifications, so you should plan for large, synchronous spikes in requests if you are hosting your content.

Refer to [`unnotificationattachment`][28] for a list of supported file types and sizes.

[1]: https://github.com/Appboy/appboy-ios-sdk/blob/master/Example/StopwatchNotificationService/NotificationService.m
[2]: https://github.com/Appboy/appboy-ios-sdk/blob/master/HelloSwift/HelloSwiftNotificationExtension/NotificationService.swift
[23]: https://developer.apple.com/reference/usernotifications/unnotificationserviceextension
[26]: {% image_buster /assets/img_archive/ios10_se_at.png %}
[27]: https://developer.apple.com
[28]: https://developer.apple.com/reference/usernotifications/unnotificationattachment