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

This code apper in the following link [Click Me ](https://github.com/shahaknir/Weekly4-GameDev/blob/master/Assets/Scripts/1-movers/KeyboardMover.cs)

1.float offsetx = 11f; 
2.float offsety = 3.5f;
3.Vector2 GameBoundaries;

    
The actual changes can on [_Asserts_](https://github.com/shahaknir/Weekly4-GameDev/tree/master/Assets) :arrow_forward: [_Scripts_](https://github.com/shahaknir/Weekly4-GameDev/tree/master/Assets/Scripts) :arrow_forward: [_1-movers_](https://github.com/shahaknir/Weekly4-GameDev/tree/master/Assets/Scripts/1-movers) :arrow_forward: [_KeyboardMover.cs_](https://github.com/shahaknir/Weekly4-GameDev/blob/master/Assets/Scripts/1-movers/KeyboardMover.cs)


Checking our player's position and keeping him inside the boundaries of the game:
```csharp
		if (this.transform.position.x <= -GameBoundaries.x){
            this.transform.position = 
			new Vector3(-GameBoundaries.x, transform.position.y, transform.position.z);
        }
        else if (this.transform.position.x >= GameBoundaries.x){
            this.transform.position = 
			new Vector3(GameBoundaries.x, transform.position.y, transform.position.z);
        }
        if (this.transform.position.y <= -GameBoundaries.y){
            this.transform.position = 
			new Vector3(transform.position.x, -GameBoundaries.y , transform.position.z);
        }
        else if (this.transform.position.y >= GameBoundaries.y){
            this.transform.position = 
			new Vector3(transform.position.x, GameBoundaries.y, transform.position.z);
        }

```

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