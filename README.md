# HackGT17 VR Piano

== Inspiration ==
We wanted to utilize the leap motion technology by making something that is interactive and useful. All of our team members have some kind of music background so we decided to make an application that can help people explore and learn how to play music without having the overbearing cost of buying an instrument.

What it does
This application simulates a real piano and provides useful tools that can help a person learn how to read notes and play songs.

How we built it
We used the oculus rift to allow the user be immersed into our environment and used leap motion technology to detect hand movements so that the game is completely natural and can be played on any environment. All the code was written in C#.

Challenges we ran into
We had a hard time initially getting the physics of the game to work. It was a bit awkward to try to touch keys as the hands would go through it and sometimes not register as a collision. Once we figured these two things out, everything else came into place.

Accomplishments that we're proud of
It was particularly hard starting out because we had to learn all the unity game engine and embarrassingly enough, at the start the piano keys would fly away when you touch them because of gravity. The main obstacles we overcame were figuring out how the leap motion hands interact with the various objects that would then cause trigger events to do something else. We also got gestures to work, in leap motion a gesture is a motion your hand makes and by using it we can do cool things such as pull up a menu when you turn your wrist.

What we learned
We learned a bit about how games are built and the tools available on unity.

What's next for Virtual Reality Interactive Piano
Eventually, it would be nice for the program to be able to read sheet music and show what notes should be played so the player can follow along in real time.

Built With
unity
c#
leap-motion
oculus-gear-vr
