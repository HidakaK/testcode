#type()は変数の型を表す
x=2
rnew=x
for i in range(1000000):
    r1=rnew
    r2=x/r1
    rnew=(r1+r2)/2
print(r1,rnew,r2)
