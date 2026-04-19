parcial = float(input("Ingrese examen parcial: "))
final = float(input("Ingrese examen final: "))

p1 = float(input("Ingrese práctica 1: "))
p2 = float(input("Ingrese práctica 2: "))
p3 = float(input("Ingrese práctica 3: "))

# Encontrar la menor práctica
menor = min(p1, p2, p3)

# Promedio de las 2 mejores prácticas
prom_prac = (p1 + p2 + p3 - menor) / 2

# Promedio final
prom_final = (parcial + final + prom_prac) / 3

print("Promedio de prácticas:", prom_prac)
print("Promedio final:", prom_final)

# Clasificación
if prom_final >= 18:
    print("Excelente")
elif prom_final >= 14:
    print("Bueno")
elif prom_final >= 10:
    print("Regular")
else:
    print("Deficiente")