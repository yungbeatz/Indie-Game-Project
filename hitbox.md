# Hitboxes with Unity
Our task was to code a game. We decided to make an indie jump and run game.  We used Unity to make the game. In this report, we are going to explain one of the main features of an indie game: The HitBoxes

## Goals
➜  We can explain what a hitbox is
➜  We can explain what a box collider is
➜  We can explain what a circle collider i

## Firstly what even is a hitbox?
HitBoxes are a set of 2D shapes that a game uses to register real-time collisions. For example, HitBoxes register if you've hit an enemy or to make sure the Player cannot walk through Walls or fall through the map.
 ![](https://external-preview.redd.it/GnQgwlEMXf0NtXEpEsmEKCCGlwOuxP6ki2TCqxIbyNw.jpg?auto=webp&s=b8649e6f55f72c7fdad42500a496e585c3c3bfb0)
*(If the image is too small, click on it to see a resized version of it.)*
  
## How did we use them in our game?
 So that we know now what a HitBox is, in Unity there are 2 different components you can use to create HitBoxes for your objects:
 1.) **Box Collider 2D**
 1.) **Circle Collider 2D**
 
 ### Box Collider 2D
This how we used the Box Collider for our player Object: 
![](https://cdn.discordapp.com/attachments/939339393028743228/960872376856354826/unknown.png)
*(If the gif is too small, click on it to see a resized version of it.)*
With the help of those settings we created a hitbox for our player objext.
![](https://cdn.discordapp.com/attachments/939339393028743228/960872871377379408/unknown.png)
*(If the gif is too small, click on it to see a resized version of it.)*
You can either use the Values of Offset and Size to edit the HitBox, or you click on the button next to `Edit Collider` and edit the green box shown in the player image.
 ### Circle Collider 2D
This how we used the Circle Collider for our Enemy Object: 
![](https://cdn.discordapp.com/attachments/838181823972507679/960875441474928650/unknown.png)
With the help of those settings we created a HitBox for our enemy object.
![](https://cdn.discordapp.com/attachments/838181823972507679/960875564267348018/unknown.png)
Here we only have offset since it's a circle and not a box anymore. But like in the box collider, we can use the button next to `Edit Collider` again to adjust the HitBox with the green circle around our Enemy Object.

## What happens if we use a Hitboxes and what if not?
**In this Gif the Player Object contains a Hitbox:**
![](https://cdn.discordapp.com/attachments/838181823972507679/960878342297497621/ezgif-5-9cdcc59ad1.gif)
**In this Gif the Hitbox is disabled for the Player Object:**
![](https://cdn.discordapp.com/attachments/838181823972507679/960878705738125312/ezgif-5-9ea095d016.gif)

## How can we make the Player Object Die as soon as our Enemy Object hits it?
We need to add Tags to our two objects:
![](https://cdn.discordapp.com/attachments/838181823972507679/960880107122225183/unknown.png)
![](https://cdn.discordapp.com/attachments/838181823972507679/960880310650822698/unknown.png)
Here we set two diffrent tags for our objects, we will need those later.
Now we will start programming a script for this:
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
```
Here we told the Code to check the tag of the object the player just collided with and if the tag is "Trap", the code runs the `Die();` function. The `Die();` function changes the animation of the player to the death animation and afterwards runs the `RestartLevel();` function, this function makes sure to reload the current scene, in short words it restarts the level.
 **Preview:**
 ![](https://cdn.discordapp.com/attachments/838181823972507679/960883316788187156/ezgif-5-81e27b993e.gif)

Reflexion:
The project went quite well, we made a game that is playable and looks good, even though it may not have a lot of different features yet. We worked as a team, but we overestimated the amount that we could do. We ended up with lots of uncompleted tasks that we had to forfeit. The next time we work in a team, we will spread the tasks more evenly and plan our time strategically. 
Verification
➜  We can explain what a hitbox is ✅
➜  We can explain what a box collider is ✅
➜  We can explain what a circle collider is ✅




