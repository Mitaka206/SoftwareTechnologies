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
$n = intval($_GET["num"]);

$a = 0;
$b = 1;
$c = 1;

for ($i = 1; $i <= $n; $i++){
    $temp = $a;
    $a = $b;
    $b = $c;
    $c = $temp + $b +$a;

    echo " $a";
}
?>

</body>
</html>