#109329

#generyczny słowniczek

Jeden_Dziewiec = {0:'',1:'jeden', 2:'dwa', 
                  3:'trzy', 4:'cztery', 5:'pięć', 
                  6:'sześć', 7:'siedem', 8:'osiem', 9:'dziewięć'}

Dziesiec_Dziewietnascie = {10:'dziesięć',11:'jedenaście', 12:'dwanaście', 
                           13:'trzynaście', 14:'czternaście',15:'piętnaście',
                           16:'szesnaście',17:'siedemnaście',18:'osiemnaście',
                           19:'dziewiętnaście'}
Dziesiatki = {0:'',20:'dwadzieścia', 30:'trzydzieści', 40:'czterdzieści', 50:'pięćdziesiąt',
             60:'sześćdziesiąt', 70:'siedemdziesiąt', 80:'osiemdziesiąt', 90:'dziewięćdziesiąt'}

Setki = {0:'',100:'sto', 200:'dwieście', 300:'trzysta', 400:'czterysta', 
         500:'pięćset', 600:'sześćset', 700:'siedemset', 800:'osiemset', 900:'dziewięćset'}

 
while True:
    num=int(input("Podaj cyfre z zakresu od 0 do 1000: "))
    if 0 <= num <= 1000:
        break
    else:
        print('Niepoprawne dane wejściowe!')
    #input od usera
#while num < 0 & num > 1000:
    #print("xd")

def do10(num):
        print(Jeden_Dziewiec.get(num))
        print('Liczba znakow w zmienionej liczbie: ' + str(len(Jeden_Dziewiec.get(num).replace(" ", "")))) # liczy liczbę znaków w zmienionej liczbie bez spacji 
        

def do20(num):
    print(Dziesiec_Dziewietnascie.get(num))
    print('Liczba znakow w zmienionej liczbie: ' + str(len(Dziesiec_Dziewietnascie.get(num).replace(" ", "")))) # liczy liczbę znaków w zmienionej liczbie bez spacji 

def do100(num):
    jedn = num % 10     # wyciągnięcie jedności z cyfry
    jedn = Jeden_Dziewiec.get(jedn)
    dzies = num // 10   # wyciągnięcie dziesiątek z cyfry
    dzies *= 10         # *10 żeby wydobyć dziesiatki ze słownika w liście
    dzies = Dziesiatki.get(dzies)
    Calosc = dzies+ ' ' +jedn
    print(Calosc)
    print('Liczba znakow w zmienionej liczbie: ' + str(len(Calosc.replace(" ", "")))) # liczy liczbę znaków w zmienionej liczbie bez spacji 

def do1000(num):
    setne = num // 100 # wyciągnięcie pierwszej cyfry od lewej z inputu usera
    setne *= 100       # *100 żeby wydobyć setki ze słownika
    setne = Setki.get(setne)
    jedn = num % 10    # wyciągnięcie jedności
    jedn = Jeden_Dziewiec.get(jedn)
    dzies = num % 100  # wyciągnięcie dziesiątek
    if 9 < dzies < 20:
        dzies = Dziesiec_Dziewietnascie.get(dzies)
        jedn = ''     # zastąpienie jedności pustym polem w przypadku gdy cyfra jest wieksza od 9 i mniejsza od 20
    else:
        jedn = num % 10     #wyciągnięcie jedności
        jedn = Jeden_Dziewiec.get(jedn)
        dzies = dzies // 10 # wyciągnięcie 2 cyfry z trzycyfrowej liczby od usera 
        dzies *= 10         # *10 aby wydobyć dziesiątki ze słownika
        dzies = Dziesiatki.get(dzies)
    Calosc = setne +' '+ dzies +' '+ jedn
    print(Calosc)
    print('Liczba znakow w zmienionej liczbie: ' + str(len(Calosc.replace(" ", "")))) # liczy liczbę znaków w zmienionej liczbie bez spacji 

#sprawdzenie zakresu podanej liczby

if num == 0:
    print('Zero')

elif 0 < num < 10: 
    num = do10(num)

elif 9 < num < 20:
    num = do20(num)

elif 19 < num < 100:
    num = do100(num)

elif 99 < num <= 999:
    num = do1000(num)

elif num == 1000:
    print('Tysiąc!')
    

    

