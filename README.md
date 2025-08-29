[![C#](https://img.shields.io/badge/C%23-9.0+-239120?style=flat&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-6.0+-512BD4?style=flat&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg?style=flat)](https://opensource.org/licenses/MIT)
![Onurix Logo](https://cdn.onurix.com/web/assets/img/logo50.png)

# Ejemplos de Cliente API de Onurix en C#

Este repositorio contiene ejemplos de código en C# para interactuar con la **API de Onurix**. Está diseñado para ayudarte a integrar fácilmente los servicios de Onurix (SMS, Llamadas, WhatsApp, etc.) en tus aplicaciones C#.

## 📋 Tabla de Contenido

- [Ejemplos de Cliente API de Onurix en C#](#ejemplos-de-cliente-api-de-onurix-en-c)
  - [📋 Tabla de Contenido](#-tabla-de-contenido)
  - [⚙️ Prerrequisitos](#️-prerrequisitos)
  - [📂 Estructura del Repositorio](#-estructura-del-repositorio)
    - [Calls](#calls)
    - [General](#general)
    - [Groups and Contacts](#groups-and-contacts)
    - [SMS](#sms)
    - [URL](#url)
    - [WhatsApp](#whatsapp)
  - [📖 Uso](#-uso)
  - [⚙️ Configuración de Parámetros](#️-configuración-de-parámetros)
    - [Credenciales de Autenticación (Obligatorias) `POST o GET`](#credenciales-de-autenticación-obligatorias-post-o-get)
    - [Parámetros Comunes](#parámetros-comunes)
    - [Parámetros Específicos](#parámetros-específicos)
    - [Ejemplo de parámetros para `sms/SendSMS.cs`](#ejemplo-de-parámetros-para-smssendsmscs)
  - [📚 Documentación Completa de la API](#-documentación-completa-de-la-api)
  - [📄 Licencia](#-licencia)
  - [📞 Soporte](#-soporte)

## ⚙️ Prerrequisitos

Antes de empezar, asegúrate de tener instalado lo siguiente:
- **.NET SDK 6.0 o superior** (para compilar y ejecutar las aplicaciones C#)

## 📂 Estructura del Repositorio

Los ejemplos de código están organizados en carpetas que corresponden a las diferentes categorías de la API de Onurix. Las peticiones a la API se realizan comúnmente mediante `HTTP POST` o `GET`. Para los envíos de WhatsApp, es necesario enviar los datos en formato `JSON`.

A continuación, se detalla cada endpoint de ejemplo y el método HTTP que utiliza:

### Calls
| Archivo          | Método | Descripción                                                             |
| :--------------- | :----- | :---------------------------------------------------------------------- |
| `SendCall.cs`    | `POST` | Genera una llamada con un mensaje de voz.                               |
| `SendCALL2FA.cs` | `POST` | Genera y entrega un código de verificación 2FA a través de una llamada. |

### General
| Archivo                  | Método | Descripción                                                   |
| :----------------------- | :----- | :------------------------------------------------------------ |
| `Balance.cs`             | `GET`  | Consulta el saldo de créditos de la cuenta.                   |
| `Security.cs`            | `POST` | Bloquea un número de teléfono para no recibir comunicaciones. |
| `VerificationCode2FA.cs` | `POST` | Realiza la verificación de un código 2FA.                     |
| `VerificationMessage.cs` | `GET`  | Verifica el estado de un envío de SMS o llamada.              |

### Groups and Contacts
| Archivo                         | Método | Descripción                              |
| :------------------------------ | :----- | :--------------------------------------- |
| `AssociateContactToGroup.cs`    | `POST` | Asocia un contacto a un grupo.           |
| `ContactCreate.cs`              | `POST` | Crea un nuevo contacto.                  |
| `ContactDelete.cs`              | `POST` | Elimina un contacto.                     |
| `ContactGroupList.cs`           | `GET`  | Lista los contactos de un grupo.         |
| `ContactUpdate.cs`              | `POST` | Actualiza la información de un contacto. |
| `DisassociateContactToGroup.cs` | `POST` | Desasocia un contacto de un grupo.       |
| `GroupCreate.cs`                | `POST` | Crea un nuevo grupo de contactos.        |
| `GroupDelete.cs`                | `POST` | Elimina un grupo de contactos.           |
| `GroupList.cs`                  | `GET`  | Lista todos los grupos de la cuenta.     |
| `GroupUpdate.cs`                | `POST` | Actualiza el nombre de un grupo.         |

### SMS
| Archivo         | Método | Descripción                                                        |
| :-------------- | :----- | :----------------------------------------------------------------- |
| `SendSMS.cs`    | `POST` | Envía un mensaje de texto (SMS).                                   |
| `SendSMS2FA.cs` | `POST` | Envía un mensaje de texto (SMS) con un código de verificación 2FA. |

### URL
| Archivo           | Método | Descripción                                |
| :---------------- | :----- | :----------------------------------------- |
| `Statistics.cs`   | `GET`  | Obtiene las estadísticas de una URL corta. |
| `URLShortener.cs` | `POST` | Crea una URL corta.                        |

### WhatsApp
| Archivo                  | Método        | Descripción                                                     |
| :----------------------- | :------------ | :-------------------------------------------------------------- |
| `SendWhatsApp2FA.cs`     | `POST (JSON)` | Envía un mensaje de WhatsApp con un código de verificación 2FA. |
| `WhatsAppGeneralSend.cs` | `POST (JSON)` | Envía un mensaje de WhatsApp usando una plantilla.              |

## 📖 Uso

1.  **Clona el repositorio:**
    ```bash
    git clone https://github.com/onurixlatam/onurix-csharp.git
    cd onurix-csharp
    ```

2.  **Navega al directorio del ejemplo** que deseas utilizar. Por ejemplo, para enviar un SMS, usarías:
    ```bash
    cd SMS/SendSMS
    ```

3.  **Edita el archivo `.cs`** (ej. `SendSMS.cs`) con tu editor de código preferido y reemplaza los valores de las variables (`AQUI_SU_KEY`, `AQUI_SU_CLIENT`, etc.) con tus datos.

4.  **Ejecuta el ejemplo** desde tu terminal con el comando `dotnet run`:
    ```bash
    dotnet run
    ```
    El comando `dotnet run` compilará y ejecutará automáticamente el proyecto definido en la carpeta actual.

5.  **Verifica la respuesta** que se imprimirá en la consola.

## ⚙️ Configuración de Parámetros

Para usar los ejemplos, necesitas reemplazar los valores de los placeholders (`AQUI_...`) con tus datos reales. A continuación, se detallan los parámetros que encontrarás en los scripts:

### Credenciales de Autenticación (Obligatorias) `POST o GET`

| Parámetro | Descripción                                                               |
| :-------- | :------------------------------------------------------------------------ |
| `client`  | Tu ID de Cliente. Lo encuentras en tu panel de Onurix en `Seguridad API`. |
| `key`     | Tu Llave de API. La encuentras en tu panel de Onurix en `Seguridad API`.  |

### Parámetros Comunes

| Parámetro  | Descripción                                                                 | Ejemplo                                      |
| :--------- | :-------------------------------------------------------------------------- | :------------------------------------------- |
| `phone`    | Número de teléfono de destino. Para múltiples números, sepáralos por comas. | `573001234567` o `573001234567,573001234568` |
| `name`     | Nombre para un contacto o grupo.                                            | `Mi Grupo`                                   |
| `lastname` | Apellido para un contacto.                                                  | `Pérez`                                      |
| `email`    | Correo electrónico de un contacto.                                          | `ejemplo@email.com`                          |
| `id`       | ID de un recurso (mensaje, contacto, grupo).                                | `12345`                                      |
| `group-id` | ID de un grupo.                                                             | `6789`                                       |
| `groups`   | IDs de grupos separados por comas.                                          | `1,2,3`                                      |
| `app-name` | Nombre de la aplicación 2FA creada en Onurix.                               | `MiApp`                                      |

### Parámetros Específicos

| Servicio     | Parámetro    | Descripción                                                              |
| :----------- | :----------- | :----------------------------------------------------------------------- |
| **SMS**      | `sms`        | Contenido del mensaje de texto a enviar.                                 |
| **Llamadas** | `message`    | Mensaje que se reproducirá en la llamada.                                |
| **Llamadas** | `voice`      | Voz a usar en la llamada (ej. `Mariana`, `Penelope`).                    |
| **Llamadas** | `audio-code` | ID de un audio previamente cargado en la plataforma.                     |
| **URL**      | `url-long`   | La URL original que deseas acortar.                                      |
| **URL**      | `alias`      | (Opcional) Alias personalizado para la URL corta.                        |
| **WhatsApp** | `templateId` | ID de la plantilla de WhatsApp aprobada por Meta.                        |
| **WhatsApp** | `data`       | Un objeto C# que se convertirá a JSON con los valores para la plantilla. |

### Ejemplo de parámetros para `sms/SendSMS.cs`

```csharp
// Define el cuerpo de la solicitud.
var requestBody = new {
    client = "12345",
    key = "*********************",
    phone = "573001234567",
    sms = "Este es un mensaje de prueba enviado desde Onurix.com",
    groups = "1,2,3"
};
```

**Ejemplo de `$data` para WhatsApp:**

```csharp
var data = new {
    phones = "573001234567",
    body = new Dictionary<int, object> {
        {1, new { type = "text", value = "John Doe" }},
        {2, new { type = "text", value = "ORD-12345" }}
    }
};
```

## 📚 Documentación Completa de la API

Para obtener una descripción detallada de todos los endpoints, parámetros y respuestas de la API, por favor consulta nuestra documentación oficial en [https://docs.onurix.com/](https://docs.onurix.com/).

## 📄 Licencia

Este proyecto está bajo la Licencia MIT.

## 📞 Soporte

Para soporte y preguntas, no dudes en contactarnos:
- **Email**: soporte@onurix.com
- **Website**: [https://onurix.com](https://onurix.com)
