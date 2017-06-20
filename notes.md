Game Design

Identify with the player's motivation
    - be the top player
    - solve puzzles
    - socialize
    - be part of a story

Game design
    - concept creation
    - describe it
    - implement it

Game engine
    - provides
        - visuals
        - sound
        - logic
        - user interface

Choosing the game engine
    - create it
    - use an existing one

The Unity 3D engine
    - not game genre specific
    - easy to learn but feature rich
        - lighting
        - physics engine
        - particle systems
    - wide platform support
    - good documentation and community

Opening Class Files
    - SpaceShooterStarter
    - Resolution: 600x900

Getting Started
    - Delete directional light
    - Remove the skybox lighting material
        - Window --> Lighting --> Skybox Material (Environment) ==> NONE

Add player ship
    - Drag Models -> vehicle_playerShip into the scene
    - Rename this object as Player
    - Reset ship transform (position, rotation, scale)
        - Now have the picture of the ship, but little else
        - We want to be able to move the ship and have it interact in our environment
        - We will use the physics engine for this
    - Add a Rigidbody component
        - Add Component --> Physics --> Rigidbody
    - Hit the play button.
    - Deselect Physics on the Player

Add a collider on the ship
    - For now we will use a simple collider
    - Add Component --> Physics --> Capsule Collider
    - Change the height
        - Change the orientation or direction --> Z-axis

Add engine fire
    - There is a particle effect prefab for the engine fire.  Make
      this a child of the player.
        - Prefabs --> VFX --> Engines

Camera
    - By default, the camera will be behind and above the player
    - Reset the camera tranform to place it at origin
    - Now point it down and place it 10 units on the Y axis above the player
    - The default camera type is perspective
        - This is how we see the real world and can judge distances this way
    - Change to orthographic
    - Things are too big
        - Set the camera size to 10
    - We want the ship to be at the bottom
        - Move the ship, or
        - move the camera.  Choose z --> 8

Lighting
    - Set background color to black
        - Main Camera - Background ==> BLACK
    - Light the ship by adding directional light
        - Create --> Light --> Directional Light
    - Rename to Main Light
    - Reset the transform to origin
    - Use the rotation controls to add a tilt to the light the ship slightly
        - Rotation of X: 15
    - Then light the front of the ship by rotating around the Y axis
        - Rotation of Y: -115

Add a background
    - disable the player object for now
    - Create --> 3D Object --> Quad
    - Reset its transform
    - Can't see it?
        - check the scene view.  its just a line as far as the camera can tell.
        - rotate along the x axis: 90 degrees
    - Remove the Mesh Collider component
    - Find the Texture: tile_nebula_green
        - view it in the preview window
    - Drag the texture onto the Quad
        - this automatically sets the Quad's material to use this texture
        - Unity material is what Unity uses to render graphics
            - apply effects such as shadows, lighting
    - The scaling is wrong.  What should it be?
        - look at the texture preview again: 1024x2048 (1:2)
        - how much do we need to grow x?
            - grow x to 13.9.  That looks good.
            - bump it to x: 15.
            - And for 1:2, y --> 30
    - The texture is too dark
        - we can turn on/off the lighting to see it is interacting with the light for the ship
        - but we don't need lighting.
        - currently the material is interacting with out lighting system and is using
          the Standard shader.
            - change the Shader to Unlit --> Texture
        - this is now exactly how the original file represents the image.
            - verify this by toggling the Main Light on/off
    - Bring back the player by enabling it again
        - what's wrong?
    - The background can be anywhere underneath the ship.  Let's choose 10.
    - Adjust the Z position of the background as well

Add a starfield background

Add movement
    - Associate the script PlayerController to the Player
    - Test and observe the ship is quite slow
    - Enable the debug code and check what's happening
    - Add the speed public variable
    - Test to see what we want
        - Use this value once the game has been stopped
    - What about moving outside the window?
        X: -6, 6    Z: -1, 13

Add shots for the player
    - Turn off the player
    - Within in Materials is the bolt we will fire
        - fx_bolt_orage
    - Drag this into the Hierarchy
    - Optionally change to cyan (from Texture)
    - We need the bolt to interact with other objects and move within the environment
    - Find the bolt in the Prefabs area
    - The bolt doesn't distroy the asteroids
        - Select the bolt
        - Add a capsule collider under the phyics menu
            - The orientation is wrong.  We need the direction along the Z axis
            - Adjust the radius and height (use the top-down to help):
                - R=.03 H=.66
        - Finally we need to make it a trigger
    - A script is provided in the Scripts directory for the bolt, called Mover
        - Open this script for editing
        - What do we want the bolt to do?
            - Move automatically
            - Distroy anything it touches
            - Go away after that
            - Since we've added the rigid body component, it will have its own velocity
                - All objects have a Transform.  Movement along the blue axis in Unity
                  is the "forward" direction."
                - Add the code:
                    rigidbody.velocity = transform.forward * speed;
            - We used a speed of 10 on the player.  So speed to 20 on the bolt.
            - Play to test
            - Delete the earlier prefab called Bolt
            - Drag the new bolt into the Prefabs area
            - Can drag the object into the scene during play, too

Shooting the shots

Adding a boundary

Creating the asteroids

Creating explosions

Create a Game Controller

Spawn Waves







    - For this game, we only want to have something happen on a collision

