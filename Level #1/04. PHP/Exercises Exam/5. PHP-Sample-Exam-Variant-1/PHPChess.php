<?php
	$text = $_GET['board'];
	
	$rows = preg_split("/\//", $text, -1, PREG_SPLIT_NO_EMPTY);
	$figures = array();
	$figures['Bishop'] = 0;
	$figures['Horseman'] = 0;
	$figures['King'] = 0;
	$figures['Pawn'] = 0;
	$figures['Queen'] = 0;
	$figures['Rook'] = 0;
	
	
	if (count($rows) != 8) {
		echo "<h1>Invalid chess board</h1>";
		exit ;
	}
	echo "<table>";
	foreach ($rows as $key => $row) {
		echo "<tr>";
		$fig = explode('-', $row);
		if (count($fig) != 8) {
			echo "<h1>Invalid chess board</h1>";
			exit ;
		}
		
		foreach ($fig as $val) {
			
			if ($val == "B") {
				$figures['Bishop']++;
			}
			else if ($val == "H") {
				$figures['Horseman']++;
			}
			else if ($val == "K") {
				$figures['King']++;
			}
			else if ($val == "P") {
				$figures['Pawn']++;
			}
			else if ($val == "Q") {
				$figures['Queen']++;
			}
			else if ($val == "R") {
				$figures['Rook']++;
			}
			echo "<td>$val</td>";
		}
		echo "</tr>";
	}
	echo "</table>";
	 $result = json_encode($figures);
	 echo "$result";
	
	
?>