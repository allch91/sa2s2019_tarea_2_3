# **MicroService User**

MicroServicio encargado de la lógica de solicitud de servicio del usuario.

## Method Description

### Request

#### Description

Envío de datos necesarios para que el piloto pueda recibir la solicitud: el usuario solicitante, número de teléfono de contacto, la ubicación del cliente.

- Parameters

    - string user_id : usuario que solicita el servicio
    - string user_phone : teléfono del usuario que solicita el servicio
    - int user_pos_x : ubicación del usuario coordenada x
    - int user_pos_y : ubicación del usuario coordenada y
    - int user_pos_z : ubicación del usuario coordenada z