<?php
/**
 * User: gabix
 * Date: 18/06/15
 * Time: 01:55
 */

class GeneradorDeHTML {

    private static $instance = null;

    public static function instance() {
        if (null === self::$instance) {
            self::$instance = new GeneradorDeHTML();
        }
        return self::$instance;
    }

    private function __construct() {
        $this->_inicio();
    }

    public static function start() {
        return null;
    }

    public function __clone() {
        die("NO CLONES NO CRY");
    }

    private static function _inicio() {
        return null;
    }


    /**
     * @param string $agregameAlTitle agregate palabras al titulo que figurará en el title del meta del html.
     * @return string todos los metas necesarios.
     */
    public static function DameMeta($agregameAlTitle = "") {
        $_title = "Subtitulos para Premiere";
        $_ret = <<<META
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="keywords" content="subtitulos, subtitles, conversor, convert, a premiere, to premiere" />
        <meta name="description" content="un conversor de texto a subtitulos para premiere, a premiere subtitle generator based on plain text" />
        <meta name="author" content="Hoppix" />
        <title>#title</title>
META;

        if ($agregameAlTitle <> "") $_title .= " - $agregameAlTitle";
        $_ret = str_replace("#title", $_title, $_ret);
        return $_ret . "\n";
    }
}