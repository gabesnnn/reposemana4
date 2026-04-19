print("--- Menú de operaciones ---")
print("1. Calcular área de un círculo")
print("2. Calcular área de un cuadrado")
print("3. Calcular área de un triángulo")
print("4. Salir")

opcion = int(input("Selecciona una opción (1-4): "))

match opcion:
    case 1:
        print("Elegiste círculo")
        print("Área del círculo = π * r^2")

    case 2:
        print("Elegiste cuadrado")
        print("Área del cuadrado = lado^2")

    case 3:
        print("Elegiste triángulo")
        print("Área del triángulo = (base * altura) / 2")

    case 4:
        print("Saliendo del programa...")

    case _:
        print("Opción inválida. Ingresa un número del 1 al 4.")