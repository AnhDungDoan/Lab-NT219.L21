#!/usr/bin/python3

# XOR two bytearrays
def xor(first, second,thirth):
   return bytearray(x^y^z for x,y,z in zip(first, second, thirth))

MSG   = "This is a known message!"
HEX_1 = "a469b1c502c1cab966965e50425438e1bb1b5f9037a4c159"
HEX_2 = "bf73bcd3509299d566c35b5d450337e1bb175f903fafc159"

# Convert ascii string to bytearray
D1 = bytes(MSG, 'utf-8')

# Convert hex string to bytearray
D2 = bytearray.fromhex(HEX_1)
D3 = bytearray.fromhex(HEX_2)
print(D1)
print(D2)
print(D3)


r1 = xor(D1, D2,D3)

print(r1.decode('utf-8'))

