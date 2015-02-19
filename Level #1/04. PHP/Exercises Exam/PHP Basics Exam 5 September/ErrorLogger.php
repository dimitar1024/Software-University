<?php
error_reporting(0);
    $text = $_GET['errorLog'];
	
	preg_match_all('/Exception in thread "(.+)" java.*\.(.+):.+\n.*?\.(.+)\((.*.java)\s*:\s*(\d+)/', $text, $matches, PREG_SET_ORDER);
	
	$out = "<ul>";
	
	for ($i=0; $i < count($matches); $i++) {
		
		$thread = $matches[$i][1];
		$exception = $matches[$i][2];
		$method = $matches[$i][3];
		$file = $matches[$i][4];
		$line = $matches[$i][5];
		
		$out .="<li>line <strong>$line</strong> - <strong>$exception</strong> in <em>$file:$method</em></li>"; 
		
		
	}
	
	$out .="</ul>";
	
	echo "$out";
?>