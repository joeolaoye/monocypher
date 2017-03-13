<?php

class Cypher
{
    private static $enc = [
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
    ];
    
    /**
       @method doEncryption
       @var $s Input (string)
       Encrypts a string and replace with a corresponding Cypher value
       @return String
    */
    public static function doEncryption($s)
    {
        $s = preg_replace("/[^a-z]/i", "", $s);

        $s = str_split($s);
        foreach ($s as &$c) {
            $c = self::$enc[$c];
        }
        unset($c);
        return implode("", $s);
    }
    
     /**
       @method doDeccryption
       @var $s Input (encrypted string)
       Decrypts a string
       @return String
    */
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
