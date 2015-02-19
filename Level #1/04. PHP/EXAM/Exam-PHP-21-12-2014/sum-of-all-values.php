<?php
  $keyCombination = $_GET['keys'];
  $textString = $_GET['text'];  
  
  preg_match("/([A-Za-z_]*)(\d+.*\d+)([A-Za-z_]*)/", $keyCombination, $keyParts);
  
  $start = $keyParts[1];
  $end = $keyParts[3];
  if (empty($keyParts[1]) || empty($keyParts[3])) {
      echo "<p>A key is missing</p>";
  }
  else {
      preg_match_all("/$start(\d.+?)$end/", $textString, $matches);
	  
	  $sum = 0;
	  foreach ($matches[1] as $value) {
		  $num = floatval($value);
		  $sum += $num;
	  }
	  
	  $sum_to_int = intval($sum);
	  var_dump($sum_to_int);
	  if ($sum_to_int === 0) {
		  
		  	echo "<p>The total value is: <em>nothing</em></p>";
	  }
	  else {
	  		echo "<p>The total value is: <em>$sum</em></p>";
	  }
	  
  }
?>