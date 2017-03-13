
import re

encoding = {
    'a': 'Q', 'b': 'W', 'c': 'E', 'd': 'R', 'e': 'T', 'f': 'Y', 'g': 'U', 'h': 'I',
    'i': 'O', 'j': 'P', 'k': 'A', 'l': 'S', 'm': 'D', 'n': 'F', 'o': 'G', 'p': 'H',
    'q': 'J', 'r': 'K', 's': 'L', 't': 'Z', 'u': 'X', 'v': 'C', 'w': 'V', 'x': 'B',
    'y': 'N', 'z': 'M'
}


def do_encryption(s):
    s2 = re.sub('[^A-Za-z0-9]+', '', s)
    c = []

    for i in range(len(s2)):
        c.append(encoding[s2[i].lower()])
    return ''.join(c)


def do_decryption(s):
    p1 = []
    for i in range(len(s)):
        for k in encoding:
            if encoding[k] == s[i]:
                p1.append(k)
    return ''.join(p1)
