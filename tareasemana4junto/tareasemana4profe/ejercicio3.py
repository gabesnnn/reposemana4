peso = float(input("Ingrese el peso en kg: "))
estatura = float(input("Ingrese la estatura (puede ser en metros o cm): "))

# Si la estatura es mayor a 3, asumimos que está en cm
if estatura > 3:
    estatura = estatura / 100

imc = peso / (estatura ** 2)

imc_red = round(imc, 2)

print(f"IMC: {imc_red}")

if imc < 18.5:
    print("Bajo peso - Azul")
elif imc < 25:
    print("Normal - Verde")
elif imc < 30:
    print("Sobrepeso - Amarillo")
else:
    print("Obesidad - Rojo")