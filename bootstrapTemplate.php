<?php
require_once 'config' . DIRECTORY_SEPARATOR . 'init.php';

$title = "Template para bootstrap";
$subTitle = "subtitulo loco, para usted, de yo, por siempre, tuyo, siiiii.";
?>

<!DOCTYPE html>
<html lang="es">
    <head>
<?= GeneradorDeHTML::DameMeta($title) ?>
        <link href="css/bootstrap.min.css" rel="stylesheet" />
        <link href="css/micss.css" rel="stylesheet" />
    </head>
    <body>

<!--fixed navbar -->
<nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="#"><?= $title ?></a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li class="active"><a href="#">Home</a></li>
                <li><a href="#about">About</a></li>
                <li><a href="#contact">Contact</a></li>
            </ul>
        </div>
    </div>
</nav>

<!-- Contenido -->
<div class="container">
    <div class="starter-template">
        <h1 class="text-center text-uppercase"><?= $title ?></h1>
        <h3 class="text-right text-info"><i><?= $subTitle ?></i></h3>
        <hr />
        <p>Mira todo el contenido que tiene esta super-duper-p&aacute;gina!!!</p>
    </div>
</div>

        <!-- js scripts -->
        <script src="js/jquery-1.11.3.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
    </body>
</html>