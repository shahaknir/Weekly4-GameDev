using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;

    float offsetx = 11f;

    float offsety = 3.5f;

    Vector2 GameBoundaries;

    // Start is called before the first frame update
    void Start(){
        GameBoundaries = new Vector2(Camera.main.transform.position.x+offsetx, Camera.main.transform.position.y+offsety);
        
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movementVector;

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

        //transform.Translate(movementVector);
        // NOTE: "Translate(movementVector)" uses relative coordinates - 
        //       it moves the object in the coordinate system of the object itself.
        // In contrast, "transform.position += movementVector" would use absolute coordinates -
        //       it moves the object in the coordinate system of the world.
        // It makes a difference only if the object is rotated.
    }
}
