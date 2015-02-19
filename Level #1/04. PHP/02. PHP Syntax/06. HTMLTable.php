<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta charset="utf-8" />
    <style>
    table {
    border: 1px solid black;
    margin: 50px;
}
tr{
	 
}
th {
    background-color: #ff6a00;
     border: 1px solid black;
    text-align: left;
    width: 120px;
    padding: 5px;
}

td {
 border: 1px solid black;
    text-align: right;
    width: 120px;
    padding: 5px;
}
    </style>
</head>
<body>
<?php


$firstName = trim($_POST['first']);
$phone = trim($_POST['phone']);
$age = (int)$_POST['age'];
$address = trim($_POST['address']);

?>
    <form method="post">
        <input type="text" name="first" placeholder="Enter first name:" />
        <input type="text" name="phone" placeholder="Enter phone:" />
		<input type="text" name="age" placeholder="Enter age:" />
		<input type="text" name="address" placeholder="Enter address:" />
		
        <input type="submit" name="sumbmit" value="Изпрати" />
    </form>
	
	<table>
    	<tr>
            <th>Name</th>
            <td><?= $firstName;?></td>
        </tr>
        <tr>
            <th>Phone number</th>
            <td><?= $phone;?></td>
        </tr>
        <tr>
            <th>Age</th>
            <td><?= $age;?></td>
        </tr>
        <tr>
            <th>Address</th>
            <td><?= $address;?></td>
        </tr>
    </table>
	
	    

</body>
</html>