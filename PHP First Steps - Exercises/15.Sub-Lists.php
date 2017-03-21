<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num1"/>
    M: <input type="text" name="num2"/>
    <input type="submit"/>
</form>

<?php
if (isset($_GET['num1']) && ($_GET['num2'])) {
    $n = intval($_GET['num1']);
    $n1 = intval($_GET['num2']);

    for ($i = 1; $i <= $n; $i++) {
        echo "<li>List $i</li>";
        for ($j = 1; $j <= $n1; $j++) {
            echo "<li>Element $i.$j</li>";
        }
    }
}
?>

<ul>

</ul>
</body>
</html>