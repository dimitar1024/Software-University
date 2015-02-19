<?php
    $input = $_GET['list'];
	$checkbox = false;
	if ($_GET['show']) {
		$checkbox = true;
	}
	 
	$list = array_filter(preg_split("/\s+/", $input, -1, PREG_SPLIT_NO_EMPTY));
	
	foreach ($list as $key => $value) {
		$list[$key] = trim($value);
	}
	$length = $_GET['length'];
	$result = "<ul>";
	if (!$checkbox) {
		foreach ($list as $el) {
			if(strlen($el) >= $length){
				$result .= "<li>".htmlspecialchars($el)."</li>";
			}
		}
	}
	else {
		foreach ($list as $el) {
			if(strlen($el) < $length){
				$result .= "<li style=\"color: red;\">".htmlspecialchars($el)."</li>";
			}
			else{
				$result .= "<li>".htmlspecialchars($el)."</li>";
			}
		}
	}
	$result .= "</ul>";
	
	echo "$result";
?>