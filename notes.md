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

EXAMPLES

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

Overview of the Unity interface panels

Overview of the Unity interface controls

Overview of the provided components
    - Player, Player Engines
        - Mesh renderer
        - Mesh collider
        - Rigidbody
    - Background
        - Quad primitive with a texture applied
        - Only draws on one side.  Why?
    - Starfield
    - Main Light
        - Directional -- not a point
    - Camera
        - Orthographic
    - GameController

Fix the problems
    - Player shots are too fast
    - No audio
    - Bolts never get destroid
        - Create 3D Object -> cube
        - Rename to Boundary
        - Match the Z position to the camera
        - Set isTrigger to checked

Add the music

Add asteroid
    - Use the prefab
        - It always gets destroid?
    - Manually create it
        - CREATE empty game object
        - ADD Models --> prop_asteroid_01
            - Reset the transform on the model
            - Rigidbody
            - Capsule Collider
            - Random Rotator Script
            - DestroyByContact Script
            - Mover Script

Game Controller settings
