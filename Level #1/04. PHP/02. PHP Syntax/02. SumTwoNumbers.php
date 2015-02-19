<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta charset="utf-8" />
</head>
<body>
<?php


$firstNumber = (float)$_POST['first'];
$secondNumber = (float)$_POST['second'];

?>
    <form method="post">
        <input type="text" name="first" placeholder="Enter first name:" />
        <input type="text" name="second" placeholder="Enter last name:" />

        <input type="submit" name="sumbmit" value="Изпрати" />
    </form>
    
<?php
echo '$firstNumber + $secondNumber ' .'= '. round(($firstNumber+$secondNumber),2);
?>
</body>
</html>