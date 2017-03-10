


var real = [ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',

            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',

            'w', 'x', 'y', 'z' ];

var sub = [ 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O',

            'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C',

            'V', 'B', 'N', 'M' ];


function encrypt (s, ns) {

    var fs = ns || "";
    return s.length > 0 ? encrypt(s.substr(1, s.length), fs += sub[real.indexOf(s[0])]) : fs.replace(/undefined/g, "");

}

function decrypt (s, ns) {

    var fs = ns || "";
    return s.length > 0 ? decrypt(s.substr(1, s.length), fs += real[sub.indexOf(s[0])]) : fs.replace(/undefined/g, "");
}
