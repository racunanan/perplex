# import sys
# print(sys.argv[1])

f = open("testtext.txt", "r+")

content = f.read()
print(content)

f.seek(0)
f.write("this is now the output text\n" + content)
f.seek(0)

content = f.read()
print(content)

f.close()