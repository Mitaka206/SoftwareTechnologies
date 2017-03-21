<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
$n = 5;
for ($j = 0; $j < 9;$j++){

    if ($j == 0 || $j == 4 || $j == 8){
        for ($i = 1; $i <= $n; $i++) {
            echo "<button style='background-color: blue'>1</button>";
        }
        echo "<br/>";
    }else{
        for ($i = 1; $i <= $n; $i++) {
            if ($j < 4){
                if ($i == 1){
                    echo "<button style='background-color: blue'>1</button>";
                }else{
                    echo "<button>0</button>";
                }
            }else{
                if ($i < $n){
                    echo "<button>0</button>";
                }else{
                    echo "<button style='background-color: blue'>1</button>";
                }
            }
        }
        echo "<br/>";
    }
}
?>

</body>
</html>