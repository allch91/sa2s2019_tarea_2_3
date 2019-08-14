# **MicroService Driver**

MicroServicio encargado de la lógica de solicitud de servicio al piloto disponible

## Method Description

### AvailableDriver

#### Description

Verificación de disponibilidad de pilotos según la ubicación del usuario solicitante

- Parameters

    - int user_pos_x: ubicación del usuario coordenada x
    - int user_pos_y: ubicación del usuario coordenada y
    - int user_pos_z: ubicación del usuario coordenada z

### DriverNotification

#### Description

Envío de notificación al piloto disponible, si la notificación no se recibe retorna falso

- Parameters
    
    * string user_id: usuario que solicita el servicio
    * string user_phone: número de teléfono del usuario que solicita el servicio
    * int user_pos_x: ubicación del usuario coordenada x
    * int user_pos_y: ubicación del usuario coordenada y
    * int user_pos_z: ubicación del usuario coordenada z

### RegisterDriver

#### Description

Registro de un nuevo conductor, si no se puede registar retorna falso

- Parameters

    * string driver_id: nuevo piloto a registrar
    * string driver_phone: número de teléfono del nuevo piloto
    * int driver_licence: número de licencia del nuevo piloto