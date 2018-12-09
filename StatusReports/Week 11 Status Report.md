Had difficulty before the meeting getting the project to build which I resolved by upgrading to a newer version of Unity and by removing unused assets.
During the meeting we discovered a problem where the camera would randomly flip while in use causing disorientation and mild nausea.
We discussed possible causes settling on accelerometer issues or the program being so heavy that accelerometer readings were taken late.
Spent the following evening adding logging to the project to track FPS and the accelerometer readings in order to try and pinpoint the cause of the flipping, but neither readings revealed anything of note.
Added a script that defined when the water on camera effect should play and when it should not. So that it only played when directly facing the waterfall.
Also added variation to the size of water droplets coming off the waterfall at the suggestion of my supervisor.

