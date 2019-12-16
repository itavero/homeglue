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
Right now I think the solution will consist of two parts: an app for iOS/macOS (probably a good time for me to start learning Swift) and a webservice running in the cloud somewhere.
The smart assistants will be able to talk to the webservice and there will be some kind of socket/message queue between the app and the webservice to relay data.

## When?
Please note that this is just a side project for me (of which I have many). Don't expect a nicely documented, fully working solution any time soon. 😉
