<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta charset="utf-8" />
</head>
<body>
<?php


$firstname = $_POST['firstname'];
$lastname = $_POST['lastname'];
$age = (int)$_POST['age'];

?>
    <form method="post">
        <input type="text" name="firstname" placeholder="Enter first name:" />
        <input type="text" name="lastname" placeholder="Enter last name:" />
        <input type="text" name="age" placeholder="Enter age: "/>

        <input type="submit" name="sumbmit" value="Изпрати" />
    </form>
    
<?php
echo $firstname . ' '. $lastname .' '.$age;
?>
</body>
</html>