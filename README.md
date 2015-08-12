# Html5GamesDevelopmentByExample

## Chapter 2 - Getting started with DOM-based game development

### Topics

* Preparing the development tools
* Setting up our first game—Ping Pong
* Learning basic positioning with the jQuery JavaScript library
* Getting keyboard inputs
* Creating the Ping Pong game with scoring

### Summary

* Creating our first HTML5 game—Ping Pong
* Using jQuery to manipulate DOM objects
* Getting keyboard inputs with multiple keys down support
* Detecting collisions with the bounding box
* We also discussed how to create a game loop and move the ball and paddles.

## Chapter 3 - Building a Memory Matching Game in CSS3

### Topics

Transform a playing card with animation
Flip a playing card with new CSS3 properties
Create the whole memory matching game
And embed a custom web font to our game

### Summary

* Transforming and animating the game object by transition module
* Flipping a card back and forth with perspective depth illusion
* Creating a matching memory game based on CSS3 styles and animation and game logic by jQuery
* Choosing and embedding web fonts from an online font delivery servic

## Chapter 4 - Building the Untangle Game with Canvas and Drawing API

### Topics

* Introducing the HTML5 canvas element
* Drawing a circle in canvas
* Drawing lines in the canvas element
* Interacting with drawn objects in canvas with mouse events
* Detecting line intersection
* Building the Untangle puzzle game with canvas

### Summary

* Drawing different paths and shapes in canvas, including circles, arcs, and lines.
* Adding mouse events and interaction with the drawn paths in the canvas.
* Dragging drawn paths in the canvas.
* Checking line intersection with the help of mathematics formulas.
* Creating an untangle puzzle game in which players need to drag the circles so the connecting lines are not intersected by each other.

## Chapter 5 - Building a Canvas Games Masterclass

### Topics

* Fill our game objects with gradient color
* Fill text in the canvas with custom webfont
* Draw images in Canvas
* Animate a sprite sheet image
* And build multiple canvas layers

### Summary

* Filling shapes with either linear or radial gradient
* Filling text in canvas with font-face embedding and other text styles
* Drawing images into canvas
* Animating a sprite sheet by the clipping function when drawing images
* Dividing the game into several layers by stacking several canvas elements
* Mixing the CSS transition animation in a canvas-based game

## Chapter 6 - Adding Sound Effects to your Games (Handling the audio event on playback completes)

### Topics

* Adding a sound effect to the play button
* Building a mini piano musical game
* Linking the music game and the play button
* Adding keyboard-driven to the game
* Creating a keyboard-driven music game
* Completing the musical game with level data recording and the game over event

### Summary

* Adding the audio tag to the HTML. There are different attributes we can set to define how the audio tag behaves and loads different format sources.
* Controlling the audio playback and volume by using the JavaScript API.
* Adding sound effects on mouse hover and active with the help of jQuery.
* Creating a music game in canvas with keyboard inputs.
* Handling audio events; the audio element sends several events when its state changes.

## Chapter 7 - Using Local Storage to Store Game Data

### Topics

* Storing data by using HTML5 local storage
* Saving the object in the local storage
* Notifying players for breaking a new record with a nice ribbon effect
* Saving the entire game progress

### Summary

* Saving and retrieving basic data into the key-value pair local storage
* Encoding an object into the JSON formatted string and parsing the string back to a JavaScript object
* Saving the entire game progress, so the game can resume even if left mid way

## Chapter 8 - Building a Multiplayer Draw-and-Guess Game with WebSockets (TODO)

### Topics

* Trying an existing multi-user sketchpad which shows drawings from different connected users through WebSockets
* Installing a WebSockets server which is implemented by node.js
* Connecting the server from a browser
* Creating an instant chat room with WebSocket API
* Creating a multi-user drawing pad in Canvas
* Building a draw-and-guess game by integrating the chat room and drawing with game logic

### Summary

* Learned how WebSockets provide real-time events by drawing on an existing multi-player sketchpad. It shows drawings from other users who are connected.
* Installed a Node.js server with the WebSocket library. By using this server, we can easily build an event-based server to handle WebSocket requests from browsers.
* Discussed the relationship between the server and a client.
* Built an instant chat room application. We learned how to implement a server script to broadcast incoming messages to other connected browsers. We also learned how to display a received message from the server on the client side.
* Built a multi-user drawing board. We learned how to pack data in the JSON format to pass a message between the server and browsers.
* Built a draw-and-guess game by integrating the chatting and drawing pad. We also learned how to create the game logic in a multi-player game.

## Chapter 9 - Building a Physics Car Game with Box2D and Canvas

### Topics

* Installing the Box2D JavaScript library
* Creating a static ground body in the physics world
* Drawing the physics world on the Canvas
* Creating a dynamic box in the physics world
* Advancing the world time
* Adding wheels to the game
* Creating the physics car
* Adding force to the car with a keyboard input
* Checking a collision in the Box2D world
* Restarting the game
* Adding a level support to our car game
* Replacing the Box2D outline drawing with graphics
* Adding a final touch to make the game fun to play

### Summary

* Installing the JavaScript ported physics engine
* Creating static and dynamic bodies in the physics world
* Setting up the car by using joints to constrain bodies and wheels
* Getting a keyboard input with the prototype library
* Interacting with the car by adding force to it
* Checking collisions in the physics world as the level destination
* Drawing an image to replace the outline of our physical game objects

# Template 

<div id="game">
	<section id="menu-scene" class="scene"></section>
	<section id="game-scene" class="scene"></section>
	<section id="gameover-scene" class="scene"></section>
	<section id="credit-scene" class="scene"></section>
	<section id="leaderboard-scene" class="scene"></section>
</div>