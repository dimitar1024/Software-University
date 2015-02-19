<?php
	$n = 1234;
	$array = array();
	
	if (strlen($n) > 2) {
		
	
		for ($i=102; $i <= $n; $i++) { 
			if (strlen($i) >= 4) {
				break;
			}
			
			$first = (int)$i % 10;
			$second = (int)($i / 10)%10;
			$third = (int)($i/100)%10;
			
			if (($first != $second) && ($first != $third) && ($second != $third)) {
				array_push($array, $i);
			}
		}
		foreach ($array as $value) {
    echo $value . ", ";
		}
	}
	else {
		echo "no";
	}
	

?>