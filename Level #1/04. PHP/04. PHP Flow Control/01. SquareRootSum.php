<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <style>
        table,td,tr,th {
        	border: 1px solid black;
        	width: 50px;
        }
    </style>
</head>

<body>
<?php
	$sum = 0;
	echo "<table>";
	echo "<tr><th>Number</th><th>Squere</th></tr>";
	for ($i=0; $i <= 100; $i+=2) :
		$sqrt = round(sqrt($i),2); 
		echo "<tr><td>$i</td><td>$sqrt</td></tr>";
		$sum += $sqrt;
	endfor;
	echo "<tr><td>Total</td><td>$sum</td></tr>";
		echo "</table>";
		
?>

</body>
</html>