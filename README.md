# Home Glue 🏠
Glue  other smart assistants to your HomeKit setup.

## Why?
I confess, my girlfriend and I are sucked in to the 🍎 eco-system.
This is also the reason why I mostly use HomeKit certified accessories (or make sure I can expose my smart home gadgets via projects like [Homebridge](https://homebridge.io/)).
The Home app on iOS might not be the best, but it just works and it works with ease.

However, there are some products I do like from other "eco-systems" or manufacturers. For instance, I have a smart speaker that supports both Google Assistant and Amazon Alexa.
I think it is a shame not to use the smart assistant features, just because I happen to be an 🍏 fan boy.
Therefor I started thinking, what if I could make a "reverse Homebridge", exposing my HomeKit Home to other smart assistants. 🤔

Also, one of the things I currently miss in the Home app, is the ability to see historic data/trends. 📈 Exposing the accessories to third party services/assistants would also make it possible to keep a record of past sensor values and such.

## How?
On a high level there needs to be an app on an Apple device that can access the HomeKit Framework APIs to interact with the devices in the Home, and an app in the cloud that acts as a "broker" between the other systems and the app on the Apple device.

### iDevice app
I briefly investigated using the private HomeKit framework on macOS Catalina. The API looked almost identical to the one on iOS, but unfortunately it wasn't that straightforward that I could just use the same calls as on iOS and get something working.
Also, this would requiring having a macOS device on 24/7, which I figured isn't ideal.

After some consideration, I think it will be best to create an Apple TV app and/or iPad app. Most people use one of these as their hub anyway (to allow for automations and controlling the device when you're not at home).

The app can use background tasks (maybe triggered by a push notification if another smart assistant is requesting an action or information). This will not guarantee that there is connection to the home for the other smart assistants all the time, but at least there can be some communication on a frequent basis.

This will probably be my first attempt at using Swift and SwiftUI in an app, so bare with me. 😩

### Cloud Broker
The broker will manage communication between the other systems (smart assistants) and the app on the iDevice.
At first, this will just be a collector of data.
Later on, smart assistant specific endpoints/requirements will be implemented.

I plan to write this in .NET Core, as I'm more familiar with C# and this will be able to run anywhere (macOS, Linux, Windows, ...).

## When?
Please note that this is just a side project for me (of which I have many). Don't expect a nicely documented, fully working solution any time soon. 😉
