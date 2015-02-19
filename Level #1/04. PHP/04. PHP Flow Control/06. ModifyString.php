<!DOCTYPE html>

<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<style>
			table{
				margin: 10px;
			}
			table, td, tr, th {
				border: 1px solid black;
				
			}
			td, th {
				padding: 3px;
			}
		</style>
	</head>

	<body>
		<form method="post">
        <input type="text" name="str" placeholder="Enter string" />
        
        <input type="radio" id="palindrome"name="func" value="1" />
        <label for="palindrome">Check Palindrome</label>
        <input type="radio" id="reverse" name="func" value="2" />
        <label for="reverse">Reverse String</label>
        <input type="radio" id="split" name="func" value="3" />
        <label for="split">Split</label>
        <input type="radio" id="hash"name="func" value="4" />
        <label for="hash">Hash String</label>
        <input type="radio" id="shuffle"name="func" value="5" />
        <label for="shuffle">Shuffle String</label>
        <input type="submit" value="Submit" />
    </form>
		<?php
		if (isset($_POST)) {
			$func = $_POST['func'];
			$string = $_POST['str'];
			
			switch ($func) {
				case 1:
					$rev = strrev($string);
					
					if ($string == $rev) {
						echo $string." is a palindrome!";
					}
					else {
						echo $string." is not a palindrome!";
					}
					break;
				case 2:
					$rev = strrev($string);
					
					echo $rev;
					break;
				case 3:
					$split = str_split($string);
					$split = array_filter($split);
					$split = implode(" ", $split);
					echo $split;
					break;
				case 4:
					echo hash('ripemd160', $string);
					break;
				case 5:
					echo str_shuffle($string);
					break;
				
				
			}
		}
		?>
	</body>
</html>