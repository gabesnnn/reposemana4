# Entradas
cat = input("Ingrese categoría (A, B, C): ").upper()
anios = int(input("Ingrese años de servicio: "))
horas = float(input("Ingrese horas trabajadas: "))

# Tarifa por categoría
if cat == "A":
    tarifa = 33.50
elif cat == "B":
    tarifa = 29.80
elif cat == "C":
    tarifa = 25.70
else:
    print("Categoría inválida")
    raise SystemExit  # salida segura

# Bono por años de servicio
if anios <= 3:
    bono = 0.00
elif 4 <= anios <= 10:
    bono = 0.10
elif 11 <= anios <= 17:
    bono = 0.20
else:
    bono = 0.30

# Cálculo final
sueldo_final = tarifa * horas * (1 + bono)

# Salida
print(f"Sueldo: S/. {sueldo_final:.2f}")