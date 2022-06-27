town = input()
sales = float(input())
commission = 0
if town == 'Sofia':
    if sales >= 0 and sales <= 500:
        commission = (sales * 0.05)
    if sales > 500 and sales <= 1000:
        commission = (sales * 0.07)
    if 1000 < sales <= 10000:
        commission = (sales * 0.08)
    if sales > 10000:
        commission = (sales * 0.12)
if town == 'Varna':
    if sales >= 0 and sales <= 500:
        commission = (sales * 0.045)
    if sales > 500 and sales <= 1000:
        commission = (sales * 0.075)
    if sales > 1000 and sales <= 10000:
        commission = (sales * 0.10)
    if sales > 10000:
        commission = (sales * 0.13)
if town == 'Plovdiv':
    if sales >= 0 and sales <= 500:
        commission = (sales * 0.055)
    if sales > 500 and sales <= 1000:
        commission = (sales * 0.08)
    if sales > 1000 and sales <= 10000:
        commission = (sales * 0.12)
    if sales > 10000:
        commission = (sales * 0.145)
if commission > 0:
    print(f'{commission:.2f}')
else:
    print('error')
