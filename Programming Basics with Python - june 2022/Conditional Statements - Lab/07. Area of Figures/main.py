from math import pi

type = input()

if type == 'square':
    sizeL = float(input())
    print(format(sizeL * sizeL, '.3f'))
if type == 'rectangle':
    sizeL = float(input())
    sizeH = float(input())
    print(format(sizeL * sizeH, '.3f'))

if type == 'circle':
    sizeR = float(input())
    print(format( pi * sizeR ** 2, '.3f'))

if type == 'triangle':
    sizeA = float(input())
    sizeB = float(input())
    print(format(0.5 * sizeA * sizeB, '.3f'))


