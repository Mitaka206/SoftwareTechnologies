<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>

<?php
$n1 = intval($_GET["num"]);
for ($i = 1; $i <= $n1; $i++){
    if ($i % 2 == 0){
        echo " $i";
    }
}
?>
</body>
</html>