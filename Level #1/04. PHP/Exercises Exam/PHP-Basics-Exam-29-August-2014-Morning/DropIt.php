<?php
$text = $_GET['text'];
$minFontSize = intval($_GET['minFontSize']);
$maxFontSize = intval($_GET['maxFontSize']);
$step = intval($_GET['step']);

$currSize = $minFontSize;
$isInInterval = true;
$decoration = "";

for ($i = 0; $i < strlen($text); $i++) {
	if (ord($text[$i]) % 2 == 0) {
		$decoration = "text-decoration:line-through;";
	} else {
		$decoration = "";
	}
	
	
	echo "<span style='font-size:$currSize;$decoration'>".htmlspecialchars($text[$i])."</span>";
	$isLatter = isLatter($text[$i]);
	if ($isLatter) {
		if ($isInInterval) {
			$currSize += $step;
		} else {
			$currSize -= $step;
		}
		
		if ($isLatter && ($currSize >= $maxFontSize || $currSize <= $minFontSize)) {
			$isInInterval = !$isInInterval;
		}
	}

}

function isLatter($latterFromText) {
	return (ord($latterFromText) >= ord('a') && ord($latterFromText) <= ord('z')) || 
	((ord($latterFromText) >= ord('A') && ord($latterFromText) <= ord('Z')));
}
?>