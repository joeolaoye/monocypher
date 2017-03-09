
import re

P = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
     'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']

CH = ['Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O',
      'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M']

def do_encryption(s):
    s2 = re.sub('[^A-Za-z0-9]+', '', s)
    c = []

    for i in range(len(s2)):
        for j in range(26):
            if s2[i].lower() == P[j]:
                c.append(CH[j])
                break
    return ''.join(c)

def do_decryption(s):
    p1 = []

    for i in range(len(s)):
        for j in range(26):
            if CH[j] == s[i]:
                p1.append(P[j])
    return ''.join(p1)
