<?php
    $mouth = date("F");
    $year = date("Y");
    $days = date("t");
    
   	for ($i=1; $i <= $days; $i++) { 
   		$date = strtotime("$i . $mouth  . $year");
   		
   		if(date("l",$date) == "Sunday"){
   			echo date("jS F Y", $date). "<br/>";
   		}
   	
   	}
    
?>