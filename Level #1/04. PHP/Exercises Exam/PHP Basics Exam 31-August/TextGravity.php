<?php
    $text = $_GET['text'];
	$size = $_GET['lineLength'];
	
	$rows = intval(strlen($text)/$size) + (strlen($text)%$size == 0 ? 0 : 1);
	$matrix = array();
	$char = 0;
	for ($row=0; $row < $rows; $row++) {
		$matrix[] = array(); 
		for ($col=0; $col < $size; $col++) { 
			if ($char <strlen($text)) {
				$matrix[$row][$col] = $text[$char];
			}
			else {
				$matrix[$row][$col] = " ";
			}
		
		$char++;	
		}
	}
	
	for ($c= (count($matrix) -1); $c >0 ; $c--) { 
		for ($col=0; $col < $size; $col++) { 
			for ($row=(count($matrix) -1); $row > 0 ; $row--) { 
				if ($matrix[$row][$col] == " ") {
					$matrix[$row][$col] = $matrix[$row-1][$col];
					$matrix[$row-1][$col] = " ";
				}
				
			}
		}
	}
	
	echo "<table>";
	for ($row=0; $row < count($matrix); $row++) { 
		echo "<tr>";
		for ($col=0; $col < count($matrix[$row]); $col++) { 
			echo "<td>".htmlspecialchars($matrix[$row][$col])."</td>";
		}
		echo"</tr>";
	}
	echo "<table>";
?>