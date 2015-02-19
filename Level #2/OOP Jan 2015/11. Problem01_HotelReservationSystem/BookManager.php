<?php

class BookManager {

    public static function bookRoom(Room $room, Reservation $reservation) {
        try {
            $room->addReservation($reservation);
            echo "Room " . $room->getRoomNumber() . " successfully booked for "
            . $reservation->getGuest()->__toString()
            . " from " . $reservation->getStartDate()->format("d-m-y")
            . " to " . $reservation->getEndDate()->format("d-m-y") ."<br/>";
            // <br/> because "\n" does not work.
        } catch (EReservationException $ex) {
            echo $ex->getMessage();
        }
    }
}
