var matchingGame = {};
matchingGame.deck = [
    'cardAK', 'cardAK',
    'cardAK', 'cardAK',
    'cardAK', 'cardAK',
    'cardBK', 'cardBK',
    'cardBQ', 'cardBQ',
    'cardBJ', 'cardBJ',
];

function shuffle() {
    return 0.5 - Math.random();
}

function selectCard() {

    // do nothing if there are already two cards flipped
    if ($('.card-flipped').size() > 1) {
        return;
    }

    $(this).addClass('card-flipped');

    // check the pattern of both flipped cards 0.7s later
    if ($('.card-flipped').size() == 2) {
        setTimeout(checkPattern, 700);
    }
}

function checkPattern() {
    if (isMatchPattern()) {
        $('.card-flipped').removeClass('card-flipped').addClass('card-removed');
        $('.card-removed').bind('webkitTransitionEnd', removeTookCards);
    } else {
        $('.card-flipped').removeClass('card-flipped');
    }
}

function isMatchPattern() {
    var cards = $('.card-flipped');
    var firstPattern = $(cards[0]).data('pattern');
    var secondPattern = $(cards[1]).data('pattern');
    return (firstPattern == secondPattern);
}

function removeTookCards() {
    $('.card-removed').remove();

    // check if all cards are removed and show game over
    if ($('.card').length === 0) {
        gameOver();
    }
}

function gameOver() {
    //var cards = $('#cards').children('.card').length;
    //if (cards === 0) {
    //    $('<h4></h4>', {
    //        'class': 'alert alert-success',
    //        'text': 'You Won!'
    //    })
    //    .appendTo('body');
    //}

    // stop the timer
    clearInterval(matchingGame.timer);

    // set the score in the game over popup
    $('.score').html($('#elapsed-time').html());

    // load the saved last score from local storage
    var lastElapsedTime = localStorage.getItem('last-elapsed-time');

    // convert the elapsed seconds into minute:second format
    // calculate the minutes and seconds from elapsed time
    var minute = Math.floor(lastElapsedTime / 60);
    var second = lastElapsedTime % 60;

    // add padding 0 if minute and second is less then 10
    if (minute < 10) minute = '0' + minute;
    if (second < 10) second = '0' + second;

    // display the last elapsed time
    $('.last-score').html(minute + ':' + second);

    // save the score into local storage
    localStorage.setItem('last-elapsed-time', matchingGame.elapsedTime);

    // show the game over popup
    $('#popup').removeClass('hide');
}

function countTimer() {
    // increment elapsed time
    matchingGame.elapsedTime++;

    // calculate the minutes and seconds from elapsed time
    var minute = Math.floor(matchingGame.elapsedTime / 60);
    var second = matchingGame.elapsedTime % 60;

    // add padding 0 if minute and second is less then 10
    if (minute < 10) minute = '0' + minute;
    if (second < 10) second = '0' + second;

    // display the elapsed time
    $('#elapsed-time').html(minute + ':' + second);
}

$(function () {

    // shuffle the deck
    matchingGame.deck.sort(shuffle);

    // clone 12 copies of the card
    for (var i = 0; i < 11; i++) {
        $('.card:first-child').clone().appendTo('#cards');
    }

    // initialize each card's position
    $('#cards').children().each(function (index, element) {
        // align the cards 4x3
        $(element).css({
            'top': ($(element).height() + 20) * Math.floor(index / 4),
            'left': ($(element).width() + 20) * (index % 4)
        });

        // get a pattern from the shuffled deck
        var pattern = matchingGame.deck.pop();

        // visually apply the pattern on the card's back face
        $(element).find('.back').addClass(pattern);

        // embed the pattern data into the DOM element
        $(element).attr('data-pattern', pattern);

        // listen for the click event on each card
        $(element).on('click', selectCard);
    });

    // reset the elapsed time to 0
    matchingGame.elapsedTime = 0;

    // start the timer
    matchingGame.timer = setInterval(countTimer, 1000);
});