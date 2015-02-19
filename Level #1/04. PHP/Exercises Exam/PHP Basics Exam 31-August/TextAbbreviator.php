<?php
    $text = $_GET['list'];
	$maxLength = $_GET['maxSize'];
	$matches = preg_split("/\r?\n/", $text, -1, PREG_SPLIT_NO_EMPTY);
	
	$input = array();
	$result = "<ul>";
	foreach ($matches as $value) {
		$input[] = trim($value);
	
		
	}
	
	foreach ($input as $value) {
		if (strlen($value) <= $maxLength ) {
			$result .= "<li>". htmlspecialchars($value)."</li>";
		}
		else {
			$result .= "<li>". htmlspecialchars(substr($value, 0, $maxLength)) . "...</li>";
		}
	}
	
	$result .= "</ul>";
	echo "$result";
?>