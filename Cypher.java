import java.util.Arrays;
import java.util.stream.Collectors;
import java.util.Map;
import java.util.HashMap;

/**
 *
 * @author uk
 */

@SuppressWarnings("unchecked")
public class Cypher {

    public static Map<String, String> lookupTable = new HashMap(26);
    static {
        lookupTable.put("a", "Q");
        lookupTable.put("b", "W");
        lookupTable.put("c", "E");
        lookupTable.put("d", "R");
        lookupTable.put("e", "T");
        lookupTable.put("f", "Y");
        lookupTable.put("g", "U");
        lookupTable.put("h", "I");
        lookupTable.put("i", "O");
        lookupTable.put("j", "P");
        lookupTable.put("k", "A");
        lookupTable.put("l", "S");
        lookupTable.put("m", "D");
        lookupTable.put("n", "F");
        lookupTable.put("o", "G");
        lookupTable.put("p", "H");
        lookupTable.put("q", "J");
        lookupTable.put("r", "K");
        lookupTable.put("s", "L");
        lookupTable.put("t", "Z");
        lookupTable.put("u", "X");
        lookupTable.put("v", "C");
        lookupTable.put("w", "V");
        lookupTable.put("x", "B");
        lookupTable.put("y", "N");
        lookupTable.put("z", "M");
    }

    public static String doEncryption(String s) {
        //try to remove some special characters from the string as this cypher is not equipped for symbols
        s = s.replaceAll("[-+.^@_:,]", "");

        return Arrays.asList(s.split(""))
            .stream()
            // Won't return * so long as you speak the English alphabet
            .map(c -> lookupTable.getOrDefault(c, "*").toString())
            .collect(Collectors.joining(""));
    }

    public static String doDecryption(String s) {
        return Arrays.asList(s.split(""))
            .stream()
            .map(c -> {
                Map.Entry<String, String> tableEntry = lookupTable.entrySet()
                    .stream()
                    .filter((Map.Entry entry) -> c.equals(entry.getValue()))
                    .findFirst()
                    // Quite unlikely, but we shouldn't let the code go up in flames if a character is not in our character set
                    .orElse(null);
                
                return tableEntry == null? "*" : tableEntry.getKey();
            })
            .collect(Collectors.joining(""));
    }

    public static void main(String... rags) {
        String str = "abc", 
            enc = doEncryption(str), 
            dec = doDecryption(enc);
        System.out.println(String.format("str: %s, enc: %s, dec: %s", str, enc, dec));
        str = "test"; 
        enc = doEncryption(str); 
        dec = doDecryption(enc);
        System.out.println(String.format("str: %s, enc: %s, dec: %s", str, enc, dec));
    }
}