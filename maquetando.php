<?php
/**
 * User: gabix
 * Date: 18/06/15
 * Time: 01:35
 */
require_once 'config' . DIRECTORY_SEPARATOR . 'init.php';

$title = "Maquetando";
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <?= GeneradorDeHTML::DameMeta($title) ?>
    <link href="css/bootstrap.min.css" rel="stylesheet">
</head>
<body>

<h1><?= $title ?></h1>
<div>TODO write content</div>


<script src="js/jquery-1.11.3.min.js"></script>
<script src="js/bootstrap.min.js"></script>
</body>
</html>
