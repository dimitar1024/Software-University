var canvas = document.getElementById("canvas");
var ctx = canvas.getContext("2d");
var livesStart = 3;
var continueAnimating = false;
var lives;
var total = 0;
var blockWidth = 100;
var blockHeight = 30;
var blockSpeed = 30;
var block = {
    x: 0,
    y: canvas.height - blockHeight,
    width: blockWidth,
    height: blockHeight,
    blockSpeed: blockSpeed
}

var rockWidth = 15;
var rockHeight = 15;
var totalRocks = 15;
var rocks = [];
for (var i = 0; i < totalRocks; i++) {
    addRock();
}


function addRock() {
    var rock = {
        width: rockWidth,
        height: rockHeight
    }
    resetRock(rock);
    rocks.push(rock);
}

function resetRock(rock) {
    rock.x = Math.random() * (canvas.width - rockWidth);
    rock.y = 15 + Math.random() * 30;
    rock.speed = 0.5 + Math.random() * 0.5;
}


document.onkeydown = function (event) {
    if (event.keyCode == 27) {
        continueAnimating = false;
        alert(" Game Over \n Your Score:" + total);
    }

    if (event.keyCode == 39) {
        block.x += block.blockSpeed;
        if (block.x >= (canvas.width - block.width)) {
            block.x = (canvas.width - block.width);
        }

    } else if (event.keyCode == 37) {
        block.x -= block.blockSpeed;
        if (block.x <= 0) {
            block.x = 0;
        }
    }
}


function animate() {


    if (continueAnimating) {
        requestAnimationFrame(animate);
    }

    for (var i = 0; i < rocks.length; i++) {

        var rock = rocks[i];

        if (isColliding(rock, block)) {
            lives -= 1;
            resetRock(rock);
        }



        rock.y += rock.speed;

        if (rock.y > canvas.height) {
            resetRock(rock);
            total += 10;
        }

        if (lives == 0) {
            alert(" Game Over \n Your Score:" + total);
            location.reload();
        }

    }

    drawAll();

}

function isColliding(a, b) {
    return !(
    b.x > a.x + a.width || b.x + b.width < a.x || b.y > a.y + a.height || b.y + b.height < a.y);
}

function drawAll() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    ctx.fillStyle = "url('img/rocks-bg.jpg')";

    ctx.fillStyle = "black";
    ctx.fillRect(block.x, block.y, block.width, block.height);
    ctx.strokeStyle = "lightgray";
    ctx.strokeRect(block.x, block.y, block.width, block.height);
	var rockImage = new Image();
		rockImage.src = "rock.png";
    for (var i = 0; i < rocks.length; i++) {
		
        var rock = rocks[i];
        ctx.beginPath();
		//ctx.drawImage(rockImage,this.rock.x, this.rock.y);
        ctx.fillStyle = "red";
        ctx.strokeStyle = "black";
        ctx.arc(rock.x, rock.y, rock.width, 0, 2 * Math.PI);
        ctx.fill();
        ctx.stroke();
        //ctx.fillRect(, rock.y, rock.width, rock.height);
    }

    ctx.font = "36px Times New Roman";
    ctx.fillStyle = 'white';
    ctx.fillText("\u2764 " + lives + " \u2691 " + total, 20, 40);
}

$("#start-btn").click(function () {
    lives = livesStart;
    block.x = 0;
    for (var i = 0; i < rocks.length; i++) {
        resetRock(rocks[i]);
    }
    if (!continueAnimating) {
        continueAnimating = true;
        animate();
    };
});