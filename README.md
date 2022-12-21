# Project Title

Name: Siu Dzoen Lee

Student Number: C19401596

Class Group: TU856

Video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

# Description of the project

This is project is to create an interactable robotic body floating on a display, the idea of a robot or mech rather is inspired by Gundam (in case you question if this is in spec with the assignment brief, Gundam came out in 1979).

The action performed in order to interact with this robot is through a set of buttons in front of this display. Once a button is pushed,
an interaction will be showcased like it changing its pose, rotating it or bopping it up and down, changing lighting effects etc.

## Proposal for project:

The initial proposal for this project is still similar however a few changes have been made. The intial plan was still to create an interactable robot but
instead I have it so that the robot is lying flat on its back and the interactions you have is by being able to pick apart the robot. Think of this like a
human anatomical body where you can pull apart its organs and inspect them.


With all this said, I have scaled down the project and decided to go with an alternative route as described in the description due to time contraints with FYP.

# Instructions on how to play

## Movement
To move around in the scene, use the following keyboard bindings:
* 'W' - Foward
* 'S' - Backward
* 'A' - Left
* 'D' - Right

## Interact
To interact with interactable objects like a button, use the following key binding:
* 'E' - Interact

## Camera
For looking around in the scene, simply move the mouse to rotate the camera

# How it works
When you enter the world scene, you will be inside a small room with three buttons on a panel connected to a cylindrical stand.
Each button will have it's own governing interaction. The first button will initially spawn in the robot and from there you can
keep on pressing the button to switch betweeen poses. The second button will change the spotlight shooting down on the robot to fade in and out.
Finally, the third button will change the light from a starting color of choice to another colour.

# List of classes/assets in the project

| Class/asset | Source |
|-----------|-----------|
| InputManager.cs | Self written |
| PlayerController.cs | Generated by Unity's Input Manager|
| PlayerManager.cs | Self written |
| PlayerMovement.cs | Self written |
| PlayerUI | Modifed From | [Reference](https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PL3hhqEqLiX1EUVpxCPaQlJzsvS7568mtS&index=8) |
| CameraManager.cs | Self Written |
| InteractionManager.cs | Modified From | [Reference](https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PL3hhqEqLiX1EUVpxCPaQlJzsvS7568mtS&index=8) |
| Interactable.cs | Modified From | [Refernce](https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PL3hhqEqLiX1EUVpxCPaQlJzsvS7568mtS&index=8) [Reference](https://dotnettutorials.net/lesson/template-method-design-pattern/) |
| ButtonManager.cs | Modified From | [Reference](https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PL3hhqEqLiX1EUVpxCPaQlJzsvS7568mtS&index=8) [Reference](https://dotnettutorials.net/lesson/template-method-design-pattern/) |
| RobotSwitcher.cs | Self written |
| ChangeLight.cs | Self written |
| FadeLight.cs | Self written |
| All 3D Assets in Game Scene | Self Made |

# What I am most proud of in the assignment

What I'm most proud of is of two things. Firstly it 
# What I learned

## This is how to markdown text:

This is a [hyperlink](http://bryanduggan.org)

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)