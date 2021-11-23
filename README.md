# Unity Weekly Assigment 4: Formal elements

A project with step-by-step scenes illustrating some of the formal elements of game development in Unity, including: 

* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.


:rocket::rocket::rocket::rocket::rocket::rocket::rocket:

## Change A Component in The Space-Ship game:
### Boundaries
I've added conditions that keep our player, the space-ship, in the scene's boundaries.
But first, let's lay some ground symbols:

This code apper in the following address [GitHub Pages](https://pages.github.com/)

1.```csharp
float offsetx = 11f; 
```
2.```csharp
float offsety = 3.5f;
```
3.```csharp
Vector2 GameBoundaries;
```
    
The actual changes can on _Asserts_ :arrow_forward: _Scripts_ :arrow_forward: _1-movers_ :arrow_forward: _KeyboardMover.cs_


Checking our player's position and keeping him inside the boundaries of the game.
```csharp
if (this.transform.position.x <= -GameBoundaries.x){
            this.transform.position = new Vector3(-GameBoundaries.x, transform.position.y, transform.position.z);
        }
        else if (this.transform.position.x >= GameBoundaries.x){
            this.transform.position = new Vector3(GameBoundaries.x, transform.position.y, transform.position.z);
        }
        if (this.transform.position.y <= -GameBoundaries.y){
            this.transform.position = new Vector3(transform.position.x, -GameBoundaries.y , transform.position.z);
        }
        else if (this.transform.position.y >= GameBoundaries.y){
            this.transform.position = new Vector3(transform.position.x, GameBoundaries.y, transform.position.z);
        }

```

## Cloning
To clone the project, you may need to install git lfs first (if it is not already installed):

    git lfs install 

To clone faster, you can limit the depth to 1 like this:

    git clone --depth=1 https://github.com/<repository-name>.git

When you first open this project, you may not see the text in the score field.
This is because `TextMeshPro` is not in the project.
The Unity Editor should hopefully prompt you to import TextMeshPro;
once you do this, re-open the scenes, and you should be able to see the texts.



## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi


Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)