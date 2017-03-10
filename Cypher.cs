public class Cypher {
	public static char[] p = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
        'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
        'w', 'x', 'y', 'z'};
    public static char[] ch = {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O',
        'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C',
        'V', 'B', 'N', 'M'};
	public static Regex regex = new Regex("[-+.^@_:,]");
	
	public static string doEncryption(string s) {
        //try to remove some special characters from the string as this cypher is not equipped for symbols
        s = regex.Replace(s, "");
        char[] c = new char[s.Length];
        for (int i = 0; i < s.Length; i++) {
            for (int j = 0; j < 26; j++) {
                if (p[j] == char.ToLower(s.ElementAt(i))) {
                    c[i] = ch[j];
                    break;
                }
            }
        }
        return (new string(c));
    }
	
	public static string doDecryption(string s) {
        char[] p1 = new char[s.Length];
        for (int i = 0; i < s.Length; i++) {
            for (int j = 0; j < 26; j++) {
                if (ch[j] == s.ElementAt(i)) {
                    p1[i] = p[j];
                    break;
                }
            }
        }
        return (new string(p1));
    }
}
