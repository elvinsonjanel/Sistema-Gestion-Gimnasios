# Sistema de Gestión Integral para Gimnasios

![C#](https://img.shields.io/badge/Language-C%23-%23239120?style=flat&logo=csharp)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-512BD4?style=flat)
![Material Design](https://img.shields.io/badge/Design-MaterialSkin-0078D7?style=flat)
![Estado](https://img.shields.io/badge/Estado-En%20Desarrollo-yellow)
![Licencia](https://img.shields.io/badge/Licencia-Privado-lightgrey)

Sistema de escritorio diseñado para modernizar, automatizar y fortalecer las capacidades operativas y administrativas de gimnasios. Este proyecto nace como solución a las limitaciones de los sistemas tradicionales (dependencia crítica de internet, control de acceso por códigos verbales y descuadres de caja), garantizando la continuidad operativa, la seguridad de los datos y una experiencia de usuario intuitiva.

> **Nota:** Este repositorio contiene el desarrollo de la interfaz y la lógica de negocio. La integración con bases de datos y hardware externo se encuentra en proceso.

---

## 🌟 Características Principales (Propuestas)

- **Operación Offline-First:** Arquitectura diseñada para funcionar con base de datos local, garantizando el registro de asistencias y cobros sin depender de internet.
- **Control de Acceso Biométrico:** Integración planificada con lector de huella dactilar para validar membresías en < 1 segundo, eliminando la suplantación de identidad.
- **Módulo POS (Punto de Venta):** Registro exacto de ventas menores (suplementos, agua) con cálculo automático de impuestos y cuadre de caja.
- **Alertas Inteligentes:** Notificaciones automáticas de vencimiento de membresías (ciclo fecha-a-fecha) y gestión de saldos pendientes.
- **Roles y Permisos:** Segregación estricta entre Administrador y Recepcionista mediante login seguro.
- **Interfaz Moderna:** Diseño limpio basado en Material Design para reducir la carga cognitiva del personal y acelerar la capacitación.

---

## 🛠️ Stack Tecnológico Actual

* **Lenguaje de Programación:** C# (.NET Framework 4.7.2)
* **Framework de Interfaz:** Windows Forms
* **Arquitectura:** Aplicación de Escritorio Modular

---

## 📐 Estandarización y Convenciones

El sistema sigue un estricto manual de normas para garantizar la mantenibilidad y escalabilidad del código:

### Nomenclatura de Programas y Clases
Se utiliza exclusivamente la convención **`snake_case`** (minúsculas, sin tildes, separadas por guion bajo) para los nombres de los formularios y módulos.
* **Módulos (Operativos):** `modulo_de_[funcion]` (Ej. `modulo_de_ingresar_al_sistema`, `modulo_de_registrar_clientes`).
* **Consultas (Reportes):** `consulta_de_[funcion]` (Ej. `consulta_de_historial_de_pagos`).

### Atajos de Teclado (UX Estándar)
Diseñado para la velocidad del personal de recepción:
| Tecla | Función | Tecla | Función |
|-------|---------|-------|---------|
| **F2** | Editar registro | **Ctrl + G** | Guardar |
| **F3** | Buscar | **Ctrl + N** | Nuevo registro |
| **F5** | Refrescar pantalla | **Ctrl + P** | Imprimir / Exportar |

---

## 📂 Estructura del Proyecto (Avance Actual)

El repositorio actualmente cuenta con los siguientes módulos de interfaz implementados:

1. **`modulo_de_ingresar_al_sistema`**: Pantalla de autenticación con validación de roles (Administrador / Recepcionista).
2. **`modulo_de_registrar_clientes`**: Formulario de alta de nuevos socios con campos para datos personales, documento de identidad, contacto y generación automática de código de socio.

---

## 🚀 Estrategia de Despliegue Propuesta

Para garantizar la continuidad del negocio durante la implementación, el proyecto contempla la técnica de **Instalación en Paralelo**:
1. **Migración de Datos:** Preservación de códigos de identificación e historiales.
2. **Operación en Paralelo (2-4 semanas):** El sistema antiguo y el nuevo corren simultáneamente para validar cuadres de caja.
3. **Puesta en Marcha Definitiva:** Desactivación del sistema legado tras validar la integridad de los datos.

---

## 📄 Documentación Adicional
Toda la especificación detallada de procesos, diagramas de flujo de datos (DFD), Diagramas Entidad-Relación (DER) y mini-especificaciones se encuentra en los documentos oficiales de Análisis y Diseño de Sistemas.
