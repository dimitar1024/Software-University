<?php
    $today = getdate();
	
	$newYear = mktime(0,0,0,1,1, $today['year']+1);
	
	$result = $newYear - $today[0];
	
	
	echo 'Hours until new year : '. round($result/3600) ."<br/>"; 
echo 'Minutes until new year : ' . round($result/60) ."<br/>";
echo 'Seconds until new year : ' .  $result ."<br/>";
echo 'Days:Hours:Minutes:Seconds: '. round($result/86400).':'.date("H:m:s", $result) ."<br/>";
	
?>