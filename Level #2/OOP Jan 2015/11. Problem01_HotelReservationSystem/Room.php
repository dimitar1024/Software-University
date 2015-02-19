<?php

require_once('iReservable.php');

abstract class Room implements iReservable {

    private $reservations = [];
    private $hasRestroom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $price;
    private $roomType;
    private $extras = [];

    public function __construct($roomNumber, $bedCount, $price, $hasRestroom, $hasBalcony, $roomType) {
        $this->bedCount = $bedCount;
        $this->roomNumber = $roomNumber;
        $this->price = $price;
        $this->hasRestroom = $hasRestroom;
        $this->hasBalcony = $hasBalcony;
        $this->roomType = $roomType;
    }

    public function getRoomNumber() {
        return $this->roomNumber;
    }

    public function getBedCount() {
        return $this->bedCount;
    }

    public function getPrice() {
        return $this->price;
    }

    public function hasRestroom() {
        return $this->hasRestroom;
    }

    public function hasBalcony() {
        return $this->hasBalcony;
    }

    public function getRoomType() {
        return $this->roomType;
    }

    public function addReservation($reservation) {
        foreach ($this->reservations as $res) {
        if (($reservation->getStartDate() >= $res->getStartDate() &&
                    $reservation->getStartDate() <= $res->getEndDate())
            ) {
                throw new EReservationException($this->roomNumber, $reservation);
            } elseif (($reservation->getEndDate() >= $res->getStartDate() &&
                    $reservation->getEndDate() <= $res->getEndDate())
            ) {
                throw new EReservationException($this->roomNumber, $reservation);
            }
        }
        $this->reservations[] = $reservation;
    }

    public function hasExtra($extra) {
        return in_array($extra, $this->extras);
    }

    protected function addExtras($extras) {
        $this->extras[] = $extras;
    }

    public function __toString() {
        $resultString = "Room number: $this->roomNumber - type: $this->roomType\n";
        foreach ($this->reservations as $reservation) {
            $resultString .= $reservation->__toString() . PHP_EOL;
        }
        return $resultString;
    }

}
