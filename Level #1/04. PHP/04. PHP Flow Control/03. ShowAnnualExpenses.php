<!DOCTYPE html>

<html>
	<head>
		<meta charset="utf-8" />
		<title></title>
		<style>
			input[type=text] {
				background-color: #FFFF99;
			}
			table, td, tr, th {
				border: 1px solid black;
				width: 50px;
				
			}
			td,th{
				padding : 3px;
			}
		</style>
	</head>

	<body>
		<form  method="post">
			<label for="year">Enter number of years: </label><input type="text" id="year"name="years" placeholder="Enter years" />
			<input type="submit" name="submit" value="Show result" />
		</form>
		<?php
			if (isset($_POST)) {
				$years = (int)$_POST['years'];
				
		$current_year = 2014;	
		echo "<table>";
		echo "<tr>
	            <th>Year</th>
	            <th>January</th>
	            <th>February</th>
	            <th>Marth</th>
	            <th>April</th>
	            <th>May</th>
	            <th>June</th>
	            <th>July</th>
	            <th>August</th>
	            <th>September</th>
	            <th>October</th>
	            <th>November</th>
	            <th>December</th>
	            <th>Total:</th>
	        </tr>";
		for ($i=0; $i < $years; $i++) {
			
			$january = rand(0, 999);
			$february = rand(0, 999);
			$marth = rand(0, 999);
			$april = rand(0, 999);
			$may = rand(0, 999);
			$june = rand(0, 999);
			$july = rand(0, 999);
			$august = rand(0, 999);
			$september = rand(0, 999);
			$october = rand(0, 999);
			$november = rand(0, 999);
			$december = rand(0, 999);
			
			$total = $january+$february+$marth+$april+$may+$june+$july+$august+$september+$october+$november+$december;
			echo "<tr>
		        	<td>$current_year</td>
		        	<td>$january</td>
		        	<td>$february</td>
		        	<td>$marth</td>
		        	<td>$april</td>
		        	<td>$may</td>
		        	<td>$june</td>
		        	<td>$july</td>
		        	<td>$august</td>
		        	<td>$september</td>
		            <td>$october</td>
		            <td>$november</td>
		            <td>$december</td>
		            <td>$total</td>
		        </tr>";
				$current_year--;
			
		}
		echo "</table>";
		}
		?>
	</body>
</html>