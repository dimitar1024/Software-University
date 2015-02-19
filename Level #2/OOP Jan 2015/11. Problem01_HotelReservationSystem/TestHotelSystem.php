<?php

function __autoload($className) {
    include_once("./" . $className . ".php");
}

$firstGuest = new Guest("Svetlin", "Nakov", 8305154569);
$secondGuest = new Guest("Angel", "Georgiev", 8712318975);
$thirdGuest = new Guest("Mario", "Peshev", 8910012457);
$firstReservation = new Reservation("25-12-2014", "02-01-2015", $firstGuest);
$secondReservation = new Reservation("01-07-2014", "10-07-2014", $secondGuest);
$thirdReservation = new Reservation("24-10-2014", "26-10-2014", $thirdGuest);
$fourReservation = new Reservation("04-07-2014", "07-07-2014", $thirdGuest);
$fifthReservation = new Reservation("20-08-2014", "23-08-2014", $firstGuest);
$sixReservation = new Reservation("24-12-2014", "4-01-2015", $secondGuest);

$rooms[313] = new SingleRoom(313, 15);
BookManager::bookRoom($rooms[313], $firstReservation);
BookManager::bookRoom($rooms[313], $fourReservation);
$rooms[310] = new SingleRoom(310, 20);
BookManager::bookRoom($rooms[310], $firstReservation);
BookManager::bookRoom($rooms[310], $secondReservation);
$rooms[401] = new SingleRoom(401, 40);
BookManager::bookRoom($rooms[401], $fifthReservation);
BookManager::bookRoom($rooms[401], $sixReservation);


