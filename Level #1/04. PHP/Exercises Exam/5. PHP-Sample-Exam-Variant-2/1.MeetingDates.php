<?php
date_default_timezone_set("Europe/Sofia");
	$start = strtotime($_GET['dateOne']);
	$end = strtotime($_GET['dateTwo']);
	
	$startDate = (($start < $end) ? $start : $end);
	$endDate = (($start > $end) ? $end : $start);
	$endDate = strtotime($_GET['dateTwo']);
	
	
	$currentDate = $startDate;
	$meetingDays = array();
	while ($currentDate <= $endDate) {
		$dayOfWeek = date('N', $currentDate);
		if ($dayOfWeek == 4) {
			$meetingDays[] = $currentDate;
		}
		$currentDate = strtotime("+1 day", $currentDate);
	}
	
	if (count($meetingDays) == 0) {
		echo "<h2>No Thursdays</h2>";
	} else {
		echo "<ol>";
			foreach ($meetingDays as $day) {
				$date = date('d-m-Y', $day);
				echo "<li>$date</li>";
			}
		echo "</ol>";
	}
?>