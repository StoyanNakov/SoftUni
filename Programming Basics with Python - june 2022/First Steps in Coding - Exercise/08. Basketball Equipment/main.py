taxsPerY = int(input())

sneakers = taxsPerY - (taxsPerY * 0.4)
bClothes = sneakers - (sneakers * 0.2)
bBalls =  bClothes / 4
bAccessories = bBalls / 5
sum = sneakers + bClothes + bBalls + bAccessories + taxsPerY

print(sum)