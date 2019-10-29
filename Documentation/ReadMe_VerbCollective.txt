Basic Documentation for Verb Collective v.98

The Verb Collective is a toolkit designed to aid artists in exploring interactive media and to help non specialized instructors teach virtual and augmented reality.  It is designed to fit seamlessly into the interface of Unity, though it leverages some of the same structures of visual coding environments, it is intentionally designed without specialized interfaces. 

Verbs are short scripts that have very targeted functions.  Verbs, when triggered, can trigger other verbs on the original gameobject or else trigger verbs on a separate gameobject. Trigger verbs are used to begin interaction chains (example: whenTyped is used to trigger an array of verbs when a character on the keyboard is pressed) while standard verbs are set to wait for a trigger or else activate on start.  All types of verbs can be used to trigger an array of verbs at the end of their sequence.

The Verb Collective is designed to be modular and lightweight and for student expertise in its functions to be directly transferable to the Unity platform as well as other similar platforms. While other popular toolkits are focused either on rapid production or on teaching code itself, the Verb Collective is focused on emergent dynamics and fostering exploratory play. 

The modularity of the system is such that while it is limited in scope it is highly customizable. Designed with three tiers of users in mind, it functions as well for beginners as it does for more skilled developers. 

This toolkit was designed at Yale University with support from HP as part of the Blended Reality Grant.  Special thanks go to Gus Schmedlen, Vice President of Worldwide Education at HP and Randall Rode from Yale University, whose combined support has been fundamental to our success.  This current package is our working beta and we hope to expand the range of verbs and improve the system with feedback from users.

For a more in depth description of the core strategies that are possible please see the complete paper, included in this package as a PDF.

Primary Scripts:

* Classes
o Verb
* The base class of all Verbs. Functions and variables to control the audio, activation of verbs, and an exit to each verb. The user can select the audio and the activity option in the editor. 
o Trigger
* Adds the override function Conjugate to the Verb class. 

* Verbs - Can be activated using a Trigger Verb or at the start of a scene. 
o toApproach
* Object will approach a target position at a variable speed. The user can change target position and speed in the editor.
o toAscend
* Object ascend on the screen at a variable rate and to a maximum height. The user can change the rate and the maximum height in the editor.
o toAttach
* Object is set as a child to a target object. The user can select the target in the editor.
o toCount
* Object contains a simple counter.
o toDescend
* Object descends on the screen at a variable rate and minimum height. The user can change the rate and the minimum height in the editor.
o toDie
* Object will be destroyed. 
o toDisable
* Target object will be set to inactive. The user can change the target in the editor.
o toEnable
* Target object will be set to active. The user can change the target in the editor.
o toFace
* Object will face a target object at a variable speed, either once or constantly. The user can change the speed at which the object faces the target object, the target object, and whether this is once or constant in the editor.
o toGrow
* Object will grow at a variable multiplier for a duration of time. The user can change the multiplier and the duration of time in the editor. 
o toLoad
* A new scene will be loaded. The user can select the scene to be loaded in the editor.
o toOrbit
* Object will orbit a target object at a variable speed, duration of time and a variable axis.The user can change the speed, duration of time and the axis in the editor.
o toReturn
* Object will return to its place of origin at a variable rate. The user can change the rate in the editor.
o toRotate
* Object will rotate on a variable axis and at a variable speed for a duration of time. The user can change the axis, speed and duration of time in the editor.
o toShrink
* Object will shrink at a variable multiplier for a duration of time. The user can change the multiplier and the duration of time in the editor.
o toSpawn
* Object will spawn a target object in a variable location, with the option to destroy object. The user can select the target object and the location, as well as whether or not the object is destroyed.
o toStop
* Object will be set to inactive. 
o toTeleport
* Object will teleport to a variable location with the option to return to a variable starting point. The user can change the target position and past position, as well as set if teleporting will be two-way in the editor.
o toWait
* Object will be set to inactive for a duration of time. The user can change the duration of time in the editor. 
* Trigger Verbs - Will activate a Verb when scenario is met. 
o whenHit
* Trigger will execute once object interacts with another collider object. 
o whenHeld
* Trigger will execute once an object is held. 
o whenStill
* Trigger will execute once object remains still for a variable threshold. The user can set the threshold in the editor.
o whenTouched
* Trigger will execute when an object enters a collider space. 
o whenTyped
* Trigger will execute when the user types a variable letter. The user can select the letter in the editor.
o whenAway
* Trigger will execute when Object passes a variable threshold distance from a variable location. The user can change the location and threshold in the editor.
o whenDistant
* Trigger will execute when Object passes a variable threshold distance from a target object. The user can change the target object and threshold in the editor.
o whenPressed
* Trigger will execute when the user presses down a variable letter. The user can select the letter in the editor.
o whenVisible
* Trigger will execute when the Object is in the field of view against a variable threshold. The user can change the threshold in the editor. 
o whenWatched
* Trigger will execute when the Object is in the center of the field of view against a threshold for a duration of gaze time. The user can change the duration of gaze and the threshold in the editor.




More Info:
http://blendedreality.yale.edu/

Customer Support Contact:
verbcollectivecommunity@gmail.com

