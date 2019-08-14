# **ESB**

Bus de Servicio Empresarial para la gestión de comunicación entre los servicios.

## Method Description

### MiSeUser

#### Description

Méetodo encargado del envío de mensajes para el microservicio de usuarios

- Parameters

    - string new_user_data: colección de parámetros para el microservicio de usuarios

### MiSeDriver

#### Description

Méetodo encargado del envío de mensajes para el microservicio de pilotos

- Parameters

    - string mise_driver_data: colección de parámetros para el microservicio de pilotos

### CarTracking

#### Description

Méetodo encargado del envío de mensajes para el microservicio de rastreo de vehículos

- Parameters

    - string tracking_data: colección de parámetros para el microservicio de rastreo de vehículos

### QueueMessage

#### Description

Cola de mensajes en espera a ser transmitidos

- Parameters

    * string service_name: nombre del servicio solicitado
    * string service_data: colección de parámetros para el microservicio solicitados

### Log

#### Description

Encargado de registrar los mensajes y el estado de los mismos

- Parameters

    * string service_name: nombre del servicio solicitado
    * string service_data: colección del paramétros para el microservicio solicitado
    * int status: estado del mensaje; -1 -> incorrecto; 0 -> correcto ; 1 -> en espera
