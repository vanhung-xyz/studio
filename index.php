<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $sinhvien = array(
        array("ten"=>"Nguyen Van H","tuoi"=> 20, "diem"=>85),
        array("ten"=>"Tran Thi B","tuoi"=> 21, "diem"=>35),
        array("ten"=>"Nguyen Ngoc Q","tuoi"=> 19 ,"diem"=>55),
        array("ten"=>"Nguyen Thi Q","tuoi"=> 19 ,"diem"=>39)
    );
    foreach($sinhvien as $sv){
        $diem = $sv["diem"];
        $ketqua = ($diem >=40)?"do":"truot";

        echo"ten: ".$sv["ten"]."," ."\n"; 
        echo"tuoi: ".$sv["tuoi"].","."\n";
        echo"diem: ".$diem.","."\n";
        echo"ket qua: ".$ketqua. "<br>"."\n";
    }
    ?>
</body>
</html>