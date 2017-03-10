<?php

class Cypher
{
    private static $enc = array(
        'a' => 'Q',
        'b' => 'W',
        'c' => 'E',
        'd' => 'R',
        'e' => 'T',
        'f' => 'Y',
        'g' => 'U',
        'h' => 'I',
        'i' => 'O',
        'j' => 'P',
        'k' => 'A',
        'l' => 'S',
        'm' => 'D',
        'n' => 'F',
        'o' => 'G',
        'p' => 'H',
        'q' => 'J',
        'r' => 'K',
        's' => 'L',
        't' => 'Z',
        'u' => 'X',
        'v' => 'C',
        'w' => 'V',
        'x' => 'B',
        'y' => 'N',
        'z' => 'M'
    );

    public static function doEncryption($s)
    {
        $s = preg_replace("/[^a-z]/i", "", $s);

        $s = str_split($s);
        foreach ($s as $i => &$c) {
            $c = self::$enc[$c];
        }
        unset($c);
        return implode("", $s);
    }

    public static function doDecryption($s)
    {
        $s = str_split($s);
        foreach ($s as &$c) {
            $key = array_search($c, self::$enc);
            $c = $key;
        }
        unset($c);
        return implode("", $s);
    }
}