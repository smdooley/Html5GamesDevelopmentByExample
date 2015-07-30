/*!
 * Box2D Car Game Example
 * http://42games.net/html5games/box2d-car-game/
 * 
 * This is an example game for the book HTML5 Games Development: A Beginning Guide.
 * 
 * Copyright 2010, Thomas Seng Hin Mak
 * makzan@42games.net
 *   
 * All Right Reserved.
 */

// global object that contains the variable needed for the car game
var carGame = {};

var canvas;
var ctx;
var canvasWidth;
var canvasHeight;

var car;

$(function () {
    carGame.world = createWorld();
    console.log('The world is created.', carGame.world);
    carGame.ground = createGround();
    console.log('The ground is created.', carGame.ground);

    // create a car
    car = createCarAt(50, 210);

    // create a box
    //var boxSd = new b2BoxDef();
    //boxSd.density = 1.0;
    //boxSd.friction = 1.5;
    //boxSd.restitution = .4;
    //boxSd.extents.Set(40, 20);

    //var boxBd = new b2BodyDef();
    //boxBd.AddShape(boxSd);
    //boxBd.position.Set(50, 210);

    //carGame.world.CreateBody(boxBd);

    //// create two wheels in the world
    //createWheel(carGame.world, 25, 230);
    //createWheel(carGame.world, 75, 230);

    // get context reference
    canvas = document.getElementById('game');
    ctx = canvas.getContext('2d');
    canvasWidth = parseInt(canvas.width);
    canvasHeight = parseInt(canvas.height);

    // draw the world
    drawWorld(carGame.world, ctx);

    // start advancing the step
    step();
});

function createWorld() {
    // set the size of the world
    var worldAABB = new b2AABB();
    worldAABB.minVertex.Set(-4000, -4000);
    worldAABB.maxVertex.Set(4000, 4000);

    // define gravity
    var gravity = new b2Vec2(0, 300);

    // set to ignore sleeping object
    var doSleep = false;

    // create the world with the size, gravity and sleep object parameters
    var world = new b2World(worldAABB, gravity, doSleep);

    return world;
}

function createGround() {
    // box shape definition
    var groundSd = new b2BoxDef();
    groundSd.extents.Set(250, 25);
    groundSd.restitution = 0.4;

    // body definition with the given shape we just created
    var groundBd = new b2BodyDef();
    groundBd.AddShape(groundSd);
    groundBd.position.Set(250, 370);
    var body = carGame.world.CreateBody(groundBd);

    return body;
}

function createWheel(world, x, y) {
    // circle definition
    var ballSd = new b2CircleDef();
    ballSd.density = 1.0;
    ballSd.radius = 10;
    ballSd.restitution = 0.1;
    ballSd.friction = 4.3;

    // body definition
    var ballBd = new b2BodyDef();
    ballBd.AddShape(ballSd);
    ballBd.position.Set(x, y);

    return world.CreateBody(ballBd);
}

function createCarAt(x, y) {
    // car box definition
    var boxSd = new b2BoxDef();
    boxSd.density = 1.0;
    boxSd.friction = 1.5;
    boxSd.restitution = .4;
    boxSd.extents.Set(40, 20);

    // car body definition
    var boxBd = new b2BodyDef();
    boxBd.AddShape(boxSd);
    boxBd.position.Set(x, y);

    var carBody = carGame.world.CreateBody(boxBd);

    // create the wheels
    var wheelBody1 = createWheel(carGame.world, x - 25, y + 20);
    var wheelBody2 = createWheel(carGame.world, x + 25, y + 20);

    // create a joint to connect left wheel to the car body
    var jointDef = new b2RevoluteJointDef();
    jointDef.anchorPoint.Set(x - 25, y + 20);
    jointDef.body1 = carBody;
    jointDef.body2 = wheelBody1;
    carGame.world.CreateJoint(jointDef);

    // create a joint to connect right wheel to the car body
    var jointDef = new b2RevoluteJointDef();
    jointDef.anchorPoint.Set(x + 25, y + 20);
    jointDef.body1 = carBody;
    jointDef.body2 = wheelBody2;
    carGame.world.CreateJoint(jointDef);

    return carBody;


}

// drawing functions
function drawWorld(world, context) {
    for (var b = world.m_bodyList; b != null; b = b.m_next) {
        for (var s = b.GetShapeList() ; s != null; s = s.GetNext()) {
            drawShape(s, context);
        }
    }
}

// drawShape function directly copy from draw_world.js in Box2dJS library
function drawShape(shape, context) {
    context.strokeStyle = '#003300';
    context.beginPath();
    switch (shape.m_type) {
        case b2Shape.e_circleShape:
            var circle = shape;
            var pos = circle.m_position;
            var r = circle.m_radius;
            var segments = 16.0;
            var theta = 0.0;
            var dtheta = 2.0 * Math.PI / segments;
            // draw circle
            context.moveTo(pos.x + r, pos.y);
            for (var i = 0; i < segments; i++) {
                var d = new b2Vec2(r * Math.cos(theta),
                r * Math.sin(theta));
                var v = b2Math.AddVV(pos, d);
                context.lineTo(v.x, v.y);
                theta += dtheta;
            }
            context.lineTo(pos.x + r, pos.y);
            // draw radius
            context.moveTo(pos.x, pos.y);
            var ax = circle.m_R.col1;
            var pos2 = new b2Vec2(pos.x + r * ax.x, pos.y + r * ax.y);
            context.lineTo(pos2.x, pos2.y);
            break;
        case b2Shape.e_polyShape:
            var poly = shape;
            var tV = b2Math.AddVV(poly.m_position,
            b2Math.b2MulMV(poly.m_R, poly.m_vertices[0]));
            context.moveTo(tV.x, tV.y);
            for (var i = 0; i < poly.m_vertexCount; i++) {
                var v = b2Math.AddVV(poly.m_position,
                b2Math.b2MulMV(poly.m_R, poly.m_vertices[i]));
                context.lineTo(v.x, v.y);
            }
            context.lineTo(tV.x, tV.y);
            break;
    }
    context.stroke();
}

function step() {
    carGame.world.Step(1.0 / 60, 1);
    ctx.clearRect(0, 0, canvasWidth, canvasHeight);
    drawWorld(carGame.world, ctx);
    setTimeout(step, 10);
}