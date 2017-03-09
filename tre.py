import re
__author__ = 'g-man'

if __name__ == '__main__':
    s = 'dghgdgadgfdg....rtyt[[][[][..@@#'
    s2 = re.sub('[^A-Za-z0-9]+', '', s)
    print(s2)