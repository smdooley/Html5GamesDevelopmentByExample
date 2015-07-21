// global object variable to store all game scope variables
var audiogame = {};

// init function when the DOM is ready
$(function () {
    // get references of the audio elements
    audiogame.buttonOverSound = document.getElementById('buttonover');
    audiogame.buttonOverSound.volume = 0.3;

    audiogame.buttonActiveSound = document.getElementById('buttonactive');
    audiogame.buttonActiveSound.volume = 0.3;

    // listen to the button event that links to #game
    $('a[href="#game"]')
    .hover(function () {
        audiogame.buttonOverSound.currentTime = 0;
        audiogame.buttonOverSound.play();
    }, function () {
        audiogame.buttonOverSound.pause();
    })
    .click(function (e) {
        audiogame.buttonActiveSound.currentTime = 0;
        audiogame.buttonActiveSound.play();

        return false;
    });
});