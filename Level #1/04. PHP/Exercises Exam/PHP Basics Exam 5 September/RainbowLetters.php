<?php
error_reporting(0);
$text = $_GET['text'];
$red = $_GET['red'];
$green = $_GET['green'];
$blue = $_GET['blue'];
$nth = $_GET['nth'];
$hexCode = RGBToHex($red, $green, $blue);

$result = '<p>';
for ($i = 0; $i < strlen($text); $i++) {
	if (($i + 1) % $nth == 0) {
		$result .= "<span style=\"color: $hexCode\">" . htmlspecialchars($text[$i]) . "</span>";
	} else {
		$result .= htmlspecialchars($text[$i]);
	}
}

$result .= '</p>';

echo "$result";

function RGBToHex($red, $green, $blue) {

	$hex = "#";
	$hex .= str_pad(dechex($red), 2, "0", STR_PAD_LEFT);
	$hex .= str_pad(dechex($green), 2, "0", STR_PAD_LEFT);
	$hex .= str_pad(dechex($blue), 2, "0", STR_PAD_LEFT);

	return $hex;
}
?>
