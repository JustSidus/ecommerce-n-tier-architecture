# E-Commerce Platform - N-Tier Architecture

Sistema de comercio electrónico diseñado con un enfoque en la escalabilidad, seguridad transaccional y mantenibilidad a largo plazo. El proyecto implementa una arquitectura estricta de N-Capas (N-Tier) para garantizar el aislamiento de responsabilidades, facilitando el desarrollo modular, las pruebas aisladas y la adaptabilidad ante futuros requerimientos operativos o de negocio.

## Valor Arquitectónico y Estructura del Sistema

La solución está construida sobre cuatro capas funcionales, cada una con un propósito claro diseñado para proteger la integridad del sistema:

### Capa de Presentación (Presentation)
Desacopla por completo la interfaz de usuario de la lógica transaccional. Esto permite iterar, optimizar o incluso reemplazar por completo la experiencia del cliente (UI) sin riesgo de afectar los flujos de compra críticos. Facilita la escalabilidad del frontend de forma independiente.

### Capa de Negocio (Business Logic Layer)
Actúa como el motor central y salvaguarda de la plataforma. Garantiza la integridad de las operaciones comerciales centralizando validaciones de inventario, procesamiento de carritos y cálculo de precios. Al estar totalmente aislada de la infraestructura, permite aplicar pruebas rigurosas sobre las reglas de negocio sin depender de bases de datos o interfaces gráficas.

### Capa de Datos (Data Access Layer)
Abstrae la persistencia de información mediante patrones de acceso estandarizados. Esta capa centraliza la interacción con el motor de base de datos, protegiendo al sistema contra vulnerabilidades y asegurando que las operaciones CRUD se realicen de manera transaccional. Su diseño permite eventuales migraciones de infraestructura o cambios de motor de base de datos con un impacto nulo en las reglas de negocio.

### Capa de Entidades (Entities / Domain)
Proporciona un modelo de dominio fuertemente tipado que actúa como contrato universal para toda la solución. Al estandarizar la estructura de los datos (Productos, Órdenes, Clientes) que viajan entre la base de datos y la interfaz, se eliminan las discrepancias de información, previniendo errores de transformación de datos a lo largo del ciclo de vida de cada solicitud.

## Stack Tecnológico

* **Core Platform:** C# / .NET
* **Client-Side:** HTML, CSS, JavaScript

## Configuración y Despliegue

1. Clonar el repositorio localmente:
   ```bash
   git clone https://github.com/JustSidus/ecommerce-n-tier-architecture.git
   ```
2. Abrir la solución en el entorno de desarrollo.
3. Restaurar las dependencias del proyecto y paquetes NuGet.
4. Actualizar la cadena de conexión (Connection String) en el archivo de configuración apuntando a la base de datos provisionada.
5. Ejecutar los scripts de inicialización o migraciones para estructurar el esquema de la base de datos.
6. Compilar y ejecutar la solución.
