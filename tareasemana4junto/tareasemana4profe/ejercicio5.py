# Entrada
edad = int(input("Ingrese su edad: "))

# Proceso
if edad >= 18:
    print("Acceso permitido. Bienvenido.")
else:
    faltan = abs(18 - edad)
    print("Acceso denegado.")
    print(f"Te faltan {faltan} año(s) para registrarte.")