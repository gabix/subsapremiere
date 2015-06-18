<?php
/* entorno namespace */
define('APP_ROOT', dirname(dirname(__FILE__)));
define('DS', DIRECTORY_SEPARATOR);
define('APP_URL_ROOT', "http://localhost/subsapremiere");

/* debug */
define('DEBUGUEANDO', true);
define('ONTHEFLY', false);

/* cargo y lleno el autoloader */
require_once(APP_ROOT.DS."clases".DS."Loader.php");

Loader::register();
Loader::addExtension('class', 'php');
Loader::addExtension('class', 'class.php');
Loader::addExtension('class', 'inc.php');
Loader::addExtension('resources', 'php');
Loader::addExtension('resources', 'html');
Loader::addLookupDirectory(APP_ROOT);
Loader::addLookupDirectory(APP_ROOT.DS.'config');
Loader::addLookupDirectory(APP_ROOT.DS.'clases');

/* BaseDeDatos related */
/**
define('DB_HOST', 'localhost');
define('DB_USER', 'root');
define('DB_PASS', '');
define('DB_NAME', 'escribite');
 */

//Debuguie::AddMsg("init", "a ver:".DB_HOST."|".DB_USER."|".DB_PASS."|".DB_NAME, "info");

