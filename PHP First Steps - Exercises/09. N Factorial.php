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
$dig = 1;
do
{
    $dig = $dig * $n;
    $n--;
} while ($n > 1);

echo $dig;
?>
</body>
</html>