# COMP790---Assignment-1
 COMP790 Assignment 1

The game is a 3D game where players interact with a target object that move unpredictably within a specified range. The target object continually moves in two dimensions—X, Y-creating erratic behavior. This movement is achieved through a combination of random time offsets and the `Mathf.PingPong` function, which ensures the target oscillates back and forth in a somewhat chaotic manner.

In terms of gameplay mechanics, the target is equipped with a `BoxCollider` and a `Rigidbody`. The collider detects collisions with other objects, while the Rigidbody component allows the target to be affected by physical interactions. When the target collides with another object, it is immediately destroyed. This destruction provides instant feedback and keeps the gameplay dynamic and engaging.

The game is considered a game because it adheres to several fundamental principles. First, it involves interaction: players can influence the outcome by colliding with the target. Second, it has clear rules and objectives. The target’s movement is confined within a certain range, and the primary objective is to interact with it, either through direct collision or other means. These rules help define the gameplay experience and create a structured environment where players can engage with the game’s mechanics.