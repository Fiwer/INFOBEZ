import base64
import binascii

# Base64
# Creating a string
s = "I'm killing your brain like a poisonous mushroom"
# Encoding the string into bytes
b = s.encode("UTF-8")
# Base64 Encode the bytes
e = base64.b64encode(b)
# Decoding the Base64 bytes to string
s1 = e.decode("UTF-8")
# Printing Base64 encoded string
print("Base64 Encoded:", s1)

# Creating a string
s = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t"
# Encoding the string into bytes
b = s.encode("UTF-8")
# Decoding the Base64 bytes
e = base64.b64decode(b)
# Decoding the Base64 bytes to string
s1 = e.decode("UTF-8")
# Printing Base64 encoded string
print("Base64 Decode:", s1)

# Base32
# Creating a string
s = "KRUGC5BAO5QXGIDUOJUWG23ZEBXW4ZJB"
# Encoding the string into bytes
b = s.encode("UTF-8")
# Decoding the Base32 bytes
e = base64.b32decode(b)
# Decoding the Base32 bytes to string
s1 = e.decode("UTF-8")
# Printing Base32 encoded string
print("Base32 Decode:", s1)

# Creating a string
s = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d"
# Encoding the string into bytes
b = bytes.fromhex(s)
# Decoding the Base32 bytes to string
s1 = b.decode("UTF-8")
# Printing Base32 encoded string
print("Hex Decode:", s1)

# Zd4
a = "1c0111001f010100061a024b53535009181c"
b = "686974207468652062756c6c277320657965"
xor_result = int(a, 16) ^ int(b, 16)
print('%x' % xor_result)


# Zd5

encoded = binascii.unhexlify('1b37373331363f78151b7f2b783431333d78397828372d363c78373e783a393b3736')
for xor_key in range(256):
 decoded = ''.join(chr(b ^ xor_key) for b in encoded)
if decoded.isprintable():
 print("Zd5: ",xor_key, decoded)

# Zd6

def repeated_key_xor(plain_text, key):
    # returns plain text by repeatedly xoring it with key
    pt = plain_text
    len_key = len(key)
    encoded = []

    for i in range(0, len(pt)):
        encoded.append(pt[i] ^ key[i % len_key])
    return bytes(encoded)


# Driver Code
def main():
    plain_text = b'Burning \'em, if you ain\'t quick and nimble\nI go crazy when I hear a cymbal'
    key = b'ICE'

    print("Plain text: ", plain_text)
    print("Encrypted as: ", repeated_key_xor(plain_text, key).hex())


if __name__ == '__main__':
    main()
