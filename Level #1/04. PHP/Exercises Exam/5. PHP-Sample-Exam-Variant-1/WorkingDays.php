<?php
date_default_timezone_set("Europe/Sofia");
$startDate = strtotime($_GET['dateOne']);
$endDate = strtotime($_GET['dateTwo']);
$holidays = preg_split("/\r?\n/", $_GET['holidays'], -1, PREG_SPLIT_NO_EMPTY);

foreach ($holidays as $key => $value) {
	$holidays[$key] = strtotime($value);
}

$currentDate = $startDate;
$workDays = array();
while ($currentDate <= $endDate) {
	if (isWork($currentDate, $holidays)) {
		$workDays[] = $currentDate;
	}
	$currentDate = strtotime("+1 day", $currentDate);
}

if (count($workDays) == 0) {
	echo "<h2>No workdays</h2>";
} else {
	echo "<ol>";
	foreach ($workDays as $value) {
		$date = date('d-m-Y', $value);
		echo "<li>$date</li>";
	}
	echo "</ol>";
}

function isWork($strToTime, $holidays) {
	$dayOfWeek = date('N', $strToTime);
	if ($dayOfWeek > 5 || in_array($strToTime, $holidays)) {
		return false;
	}

	return true;
}
?>