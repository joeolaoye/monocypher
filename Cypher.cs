public class Cypher {
	public static Dictionary<char, char> keyMap = new Dictionary<char, char>() { 
		{ 'a', 'Q' }, { 'b', 'W' }, { 'c', 'E' }, 
		{ 'd', 'R' }, { 'e', 'T' }, { 'f', 'Y' }, 
		{ 'g', 'U' }, { 'h', 'I' }, { 'i', 'O' }, 
		{ 'j', 'P' }, { 'k', 'A' }, { 'l', 'S' }, 
		{ 'm', 'D' }, { 'n', 'F' }, { 'o', 'G' }, 
		{ 'p', 'H' }, { 'q', 'J' }, { 'r', 'K' }, 
		{ 's', 'L' }, { 't', 'Z' }, { 'u', 'X' }, 
		{ 'v', 'C' }, { 'w', 'V' }, { 'x', 'B' }, 
		{ 'y', 'N' }, { 'z', 'M' },
		{ '1', '5' }, { '2', '9' }, { '3', '6' },
		{ '4', '7' }, { '5', '8' }, { '6', '1' },
		{ '7', '2' }, { '8', '3' }, { '9', '0' },
		{ '0', '4' }, 
		{ '[', '-' }, { '-', '_' }, { '+', ':' },
		{ '.', ',' }, { '^', '[' }, { '@', ']' },
		{ '_', '+' }, { ':', '.' }, { '*', '^' },
		{ ',', '*' }, { ']', '@' }
	};
	public static Regex regex = new Regex("[-+.^@_:,]");
	
	public static string doEncryption(string s) {
        //try to remove some special characters from the string as this cypher is not equipped for symbols
        s = regex.Replace(s, "");
        char[] c = new char[s.Length];
        for (int i = 0; i < s.Length; i++) {
			c[i] = keyMap[char.ToLower(s[i])];
        }
        return (new string(c));
    }
	
	public static string doDecryption(string s) {
        char[] p1 = new char[s.Length];
        for (int i = 0; i < s.Length; i++) {
			p1[i] = keyMap.FirstOrDefault(x => x.Value == s.ElementAt((i))).Key;
        }
        return (new string(p1));
    }
}
