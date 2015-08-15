var canvas = CE.defines("main-canvas")
    .extend(Input)
    .ready(function () {
        canvas.Scene.call("MyScene");
    });

canvas.Scene.New({
    name: "MyScene", // Obligatory
    materials: {
        images: {
            bus: "/content/canvasengine/img/bus.png"
        }
    },
    called: function (stage) {

    },
    preload: function (stage, pourcent, material) {

    },
    ready: function (stage, params) {

        this.bus = this.createElement();
        this.bus.drawImage("bus");
        stage.append(this.bus);

        canvas.Input.keyDown(88);
        canvas.Input.keyDown(90);
    },
    render: function (stage) {

        if (canvas.Input.isPressed(88)) {
            this.bus.x += 1;
        } else if (canvas.Input.isPressed(90)) {
            this.bus.x -= 1;
        }

        stage.refresh();
    },
    exit: function (stage) {

    }
});