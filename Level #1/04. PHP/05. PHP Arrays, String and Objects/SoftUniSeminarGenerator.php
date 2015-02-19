<!DOCTYPE html>
<html>
<head>
    <title>problem 07</title>
<style>
        th {
            height: 25px;
            background-color: #234465;
            color: white;
            font-weight: bold;
            border-right: #8596a7;
        }
            th:last-child {
                border-right: none;
            }
        a {
            color: black;
        }
        a:hover {
            color: red;
        }
        td {
            height: 15px;
            background-color: #e2e2e2;
            padding: 10px;
        }

            td:nth-child(2n+) {
                background-color: #fff;
            }

        input[type=button] {
            color: #fff;
            background-color: #FF9C00;
            border: 1px solid black;
        }
        
    </style>
</head>
<body>
<?php
//error_reporting(0);
$text = trim($_GET['text']);
$lines = preg_split("/\n/", $text);
$property = $_GET['property'];
$order = $_GET['order'];
$table = array();
$matches;

foreach ($lines as $key => $value) {
	preg_match("/([\w\s.,]+)\s*-\s*([\w\s.,]+)\s*-\s*([\d]{2}-[\d]{2}-[\d]{4} [\d]{2}:[\d]{2}) (.+)/", $value, $matches);

	$currentSeminar = new stdClass();
	$currentSeminar -> name = trim($matches[1]);
	$currentSeminar -> lector = trim($matches[2]);
	$currentSeminar -> date = trim(strtotime($matches[3]));
	$currentSeminar -> comment = trim($matches[4]);

	$table[] = $currentSeminar;
	usort($table, function($s1, $s2) use ($order, $property) {
		if ($s1 -> $property == $s2 -> $property) {
			return strcmp($s1 -> $name, $s2 -> $name);
		}

		return ($order == "ascending" ^ $s1 -> $property < $s2 -> $property) ? 1 : -1;
	});
}

echo "<table>";
echo "<tr><th>Seminar name</th><th>Date</th><th>Participate</th></tr>";

foreach ($table as $key => $value) {
	
	$date = date("d-m-y G:i",$value->date); 
	echo "<tr>
    		<td title='$value->comment'><a href='#'>$value->name</a></td>
    		<td>$date</td>
    		<td><input type='button' name='func' value='SIGN UP' onclick='alert(\"Being updated. Please, Excuse us!\")' /></td>
    	  </tr>";
}

echo "</table>";
?>
</body>
</html>
