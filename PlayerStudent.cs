/// Sahil Pillay-Muneef
/// GPR103
/// Assessment #2

using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class PlayerStudent : MonoBehaviour
{
    ////////////////////////////////////////////////////////////////////
    // REMOVE the numbered instruction steps below before submission. //
    // KEEP the variable descriptions.                                //
    // FOLLOW the below instructions.                                 //
    // CREATE a empty GameObject in the provided Sample Scene.        //
    // ATTACH this script as a component. Save the scene.             //
    ////////////////////////////////////////////////////////////////////

    // 1. Define the following class variables (fields) with the most appropriate datatype.
    // 2. Each variable must have the appropriate accessor defined.
    // 3. Each variable name must be both wirtten in camelCasing and must use a logical and descriptive name
    // 4. No varibale assignments are required here, assign these in the Start() function.

    // A publicly accessible variable to store the Players Name.
    public string playerName;
    // A publicly accessible variable to store the Players maximum amount of lives.
    public int lives;
    // A publicly accessible variable to store the Players current amount of lives.
    public int currentLives;
    // A publicly accessible variable to store the Players maximum amount of health.
    public float health;
    // A publicly accessible variable to store the Players current amount of health.
    public float currentHeath;
    // A publicly accessible variable to store the Players maximum speed.
    public float maxSpeed;
    // A publicly accessible variable to store the Players current speed.
    public float currentSpeed;
    // A private variable to determine if the players input can be read by the program.
    private bool inputIsRead;
    // A private variable to describes if the player is still alive or not.
    private bool playerIsAlive;
        // A public variable to store the current 2-dimensional position of the player in the game world.


    void Start()
    {
        // 5. Assign a starting value to each of the above class variables (Fields).
        // - Use your name for the players name.
        playerName = "Sahil";
        // - Set the players current lives to the maximum lives possible & current health to the maximum health possible.
        lives = 5;
        currentLives = lives;
        health = 100.0f;
        currentHeath = health;
        // - Set the Maximum speed to your age and set the current speed to the maximum speed.
        maxSpeed = 18.0f;
        currentSpeed = maxSpeed;
        // - Set both the players ability to input and whether they are alive to TRUE.
        inputIsRead = true;
        playerIsAlive = true;
            //  -Set the position of the player to 0 on the x-axis, 1 on the y-axis
    }
}
