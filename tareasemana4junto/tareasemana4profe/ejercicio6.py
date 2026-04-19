promedio = float(input("Ingresa el promedio (0 - 20): "))

if 0 <= promedio <= 5:
    print("Calificación: Deficiente")
elif 6 <= promedio <= 10:
    print("Calificación: Regular")
elif 11 <= promedio <= 14:
    print("Calificación: Bueno")
elif 15 <= promedio <= 20:
    print("Calificación: Excelente")
else:
    print("Valor inválido")