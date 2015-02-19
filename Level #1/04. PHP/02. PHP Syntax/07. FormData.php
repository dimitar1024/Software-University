<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta charset="utf-8" />
    
</head>
<body>
<?php


$firstName = trim($_POST['first']);
$age = (int)$_POST['age'];
$sex = $_POST['gander'];

?>
    <form method="post">
        <input type="text" name="first" placeholder="Enter first name:" /><br />
		<input type="text" name="age" placeholder="Enter age:" /><br />
		<input type="radio" name="gander" value="male" id="male"/><label for="male">Male</label><br />
		<input type="radio" name="gander" value="female" id="female"/><label for="female">Female</label><br />
        <input type="submit" name="sumbmit" value="Изпрати" />
    </form>
	
	<?php
echo "My name is ". $firstName . ". I am " . $age . " years old. I am " . $sex;
?>
	
	    

</body>
</html>