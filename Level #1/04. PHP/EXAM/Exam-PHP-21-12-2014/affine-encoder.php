<?php
	error_reporting(0);
	$jsonTable = $_GET['jsonTable'];
	
	$table = json_decode($jsonTable);
	$columnLength = 0;
	$out = array();
	$k = $table[1][0];
	$s = $table[1][1];
	$matrix = $table[0];
	$currentChar = 0;
	foreach ($table[0] as $cell) {
		$length = strlen($cell);
		if ($length > $columnLength) {
			$columnLength = $length;
		}
	}
	
	for ($row = 0; $row < count($matrix); $row++) {
		$len = $columnLength - 1;
		for ($col = 0; $col <= $len; $col++) {
	
			if (ctype_alpha($matrix[$row][$col])) {
				$asciiCode = ord($matrix[$row][$col]);
				$m = 0;
				if ($asciiCode >= 97 && $asciiCode <= 122) {
					$m = $asciiCode - 97;
				}
				if ($asciiCode >= 65 && $asciiCode <= 90) {
					$m = $asciiCode - 65;
				}
	
				$cript = (($k * $m + $s) % 26) + 1;
				$position = $cript + 64;
				$latter = chr($position);
				$out[$row][$col] = $latter;
			} else {
				$out[$row][$col] = $matrix[$row][$col];
			}
	
		}
	
	}
	
	echo "<table border='1' cellpadding='5'>";
	for ($row=0; $row < count($out); $row++) {
		echo "<tr>"; 
		for ($col=0; $col < $columnLength; $col++) {
			
			if ($out[$row][$col] != "") {
				echo "<td style='background:#CCC'>".$out[$row][$col]."</td>";
			} 
			else{
				echo "<td></td>";
			}
		}
		echo "</tr>";
	}
	echo "</table>";
	
	
	
	
	
	
	
?>