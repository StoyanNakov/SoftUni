a = int(input())
b = int(input())
symbom = input()
odd_or_even = ''
if symbom == '+':
    if (a+b) % 2 == 0:
        odd_or_even = 'even'
    else:
        odd_or_even = 'odd'
    print(f'{a} + {b} = {a+b} - {odd_or_even}')

if symbom == '-':
    if (a-b) % 2 == 0:
        odd_or_even = 'even'
    else:
        odd_or_even = 'odd'
    print(f'{a} - {b} = {a-b} - {odd_or_even}')

if symbom == '*':
    if (a*b) % 2 == 0:
        odd_or_even = 'even'
    else:
        odd_or_even = 'odd'
    print(f'{a} * {b} = {a*b} - {odd_or_even}')

if symbom == '/':
    if b != 0:
        print(f'{a} / {b} = {(a / b):.2f}')
    else:
        print(f'Cannot divide {a} by zero')

if symbom == '%':
    if b != 0:
        print(f'{a} % {b} = {(a % b)}')
    else:
        print(f'Cannot divide {a} by zero')