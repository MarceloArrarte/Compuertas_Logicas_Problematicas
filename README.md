# Probando las compuertas lógicas

Este es un pequeño ejercicio para revisar la utilidad de tener
tests acertados que permitan validar rápidamente que tu
programa funciona como se espera.

Clona el repositorio, ejecuta los tests y verás que algunos
fallan. Encuentra el motivo de cada error y modifica las
clases del proyecto CompuertasLogicas para que todos los
tests pasen.

Además, si encuentras casuísticas que no están contempladas,
agrega los tests que creas necesarios teniendo en cuenta
lo siguiente:
- Normalmente, los tests consisten de tres etapas:
  - **(A)rrange**: cargo valores iniciales que me permitan hacer la prueba que quiero.
  - **(A)ct**: realizo la operación cuyo resultado quiero validar (invocar un método, construir un objeto, etc).
  - **(A)ssert**: chequeo valores que me indiquen el éxito o fracaso del paso anterior.
- Los tests deberían ser breves y tener un único motivo para fallar.
- No solo la cantidad de tests hacen a un buen proyecto de pruebas,
porque muchas pruebas probando casos similares no aportan mucho.
Deberías enfocarte en probar casos u operaciones claramente distintos
para cubrir una mayor cantidad de las responsabilidades de tu programa.
