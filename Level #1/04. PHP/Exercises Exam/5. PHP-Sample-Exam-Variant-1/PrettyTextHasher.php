<?php
    $text = $_GET['text'];
	$hashValue = $_GET['hashValue'];
	$fontSize = $_GET['fontSize'];
	$fontStyle = $_GET['fontStyle'];
	$style;
	if ($fontStyle == "normal") {
		$style = "font-style:normal;";
	}
	else if ($fontStyle == "bold") {
		$style = "font-weight:bold;";
	}
	else if ($fontStyle == "italic") {
		$style = "font-style:italic"; 
	}
	
	$result = "";
	$result = "<p style=\"font-size:$fontSize;$style\">";
	for ($i=0; $i < strlen($text); $i++) { 
		if ($i % 2 == 0) {
			$hash = ord($text[$i]) + $hashValue;
			$result .= chr($hash);
		}
		else {
			$hash = ord($text[$i]) - $hashValue;
			$result .= chr($hash);
		}
	}
	$result .="</p>";
	
	echo "$result";
	
?>