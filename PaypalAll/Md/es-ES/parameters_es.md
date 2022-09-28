---
page_order: 2.4
nav_title: Parámetros
article_title: API parámetros
layout: glossary_page
glossary_top_header: "Parámetros"
glossary_top_text: "Utilice estos parámetros para definir sus solicitudes de API. Aunque los parámetros que necesita están enumerados en los puntos finales, esto debería darte más información sobre sus matices y otras especificaciones."

description: "Este glosario cubre con detalle los parámetros para realizar API solicitudes." 
page_type: glossary

glossaries:
  - name: Clave REST API del grupo de aplicaciones
    description: El <code>api_key</code> título de la aplicación al que están asociados los datos de esta solicitud y autentica al solicitante como alguien que tiene permiso para enviar mensajes a la aplicación. Debe incluirse con cada solicitud como encabezado de autorización HTTP. Puede encontrarse en la <strong>sección Consola</strong> para programadores del panel de Braze.
    field: "api_key"
  - name: Identificador de aplicación
    description: Si desea enviar inserción a un conjunto de tokens de dispositivos (en lugar de usuarios), debe indicar en nombre de qué aplicación específica se trata de los mensajes. En ese caso, proporcionará el identificador de aplicación correspondiente en un objeto de tokens. Puede encontrarse en la <strong>sección Consola</strong> para programadores del panel de Braze.
    field: "app_id"
  - name: Id. de usuario externo
    description: Un identificador exclusivo para enviar mensajes a usuarios específicos. Este identificador debe ser el mismo que el que configuró en el SDK de Braze. Solo puedes dirigir la dirección a usuarios (usuarios) para mensajes que ya se hayan identificado a través de la SDK o en la API de usuarios. Las solicitudes permiten un máximo de 50 Id. de usuario externos. <br>
 <br>
 En cuanto a los puntos de conexión del desencadenador de campaña, si proporciona este campo, los criterios se aplicarán en capas con los segmentos de la campaña y solo los usuarios que figuran en la lista de Id. de usuario externos y el segmento de la campaña recibirán el mensaje.
    field: "external_user_ids"
  - name: Identificador de segmento
    description: Este <code>segment_id</code> significa el segmento al que se debe enviar el mensaje. Encontrará un identificador de segmento para cada uno de los segmentos que ha creado en la <strong>sección Consola</strong> para programadores del panel de Braze. <br>
 <br>
 En el caso de los puntos de conexión de los mensajes, si se proporcionan un identificador de segmento y una lista de Id. de usuario externos en una sola solicitud de mensajería, se aplicarán los criterios y solo los usuarios que estén en la lista de Id. de usuario externos y en el segmento proporcionado recibirán el mensaje.
    field: "segment_id"
  - name: Identificador de campaña
    description: En el caso de los puntos de conexión de mensajes <code>campaign_id</code> , significa que la campaña API con la que se debe realizar un seguimiento de los análisis de un mensaje. Encontrará un identificador de campaña para cada una de las campañas que ha creado en la <strong>sección Consola</strong> para programadores del panel de Braze. Si proporciona un identificador de campaña en el cuerpo de la solicitud, deberá proporcionar en cada uno de los objetos de mensaje una <code>message_variation_id</code> variante representada de la campaña. <br>
 <br>
 Para los puntos de conexión del desencadenador de la <code>campaign_id</code> campaña, indica el API Id. de la campaña que se debe activar. Este campo es obligatorio para todas las solicitudes de punto de conexión del desencadenador.
    field: "campaign_id"
  - name: Identificador de Canvas
    description: Para los puntos de conexión de Canvas, significa <code>canvas_id</code> que el identificador de Canvas que se activará o programará. Este campo es obligatorio para todas las solicitudes de punto de conexión del desencadenador.
    field: "canvas_id"
  - name: Identificador de envío
    description: En el caso de los puntos de conexión de los <code>send_id</code> mensajes, estos indican el envío mediante el cual se debe realizar un seguimiento de los análisis de un mensaje. Este <code>send_id</code> sistema permite extraer los análisis de una instancia específica de envío de una campaña a través del <code>sends/data_series</code> punto final. API y API activar campañas que se envían como difusión generarán automáticamente un identificador de envío si no se proporciona uno. <br>
 <br>
 Si desea especificar una propia <code>send_id</code>, primero tendrá que crear una a través del <code>sends/id/create</code> punto de conexión. Deben <code>send_id</code> tener todos los caracteres de ASCII y un máximo de 64 caracteres de longitud.  Puede volver a utilizar un identificador de envío en varios envíos de la misma campaña si desea agrupar los análisis de esos envíos juntos. <br>
 <br>
 Ten en cuenta que <code>send_id</code> no hay disponible información de seguimiento para los correos electrónicos enviados a través de Mailjet. <br>
 <br>
 Las conversiones de campaña se atribuyen al último seguimiento <code>send_id</code> que el usuario recibió en la campaña, a menos que no se haya realizado el seguimiento del último envío que el usuario ha recibido.
    field: "send_id"
  - name: Propiedades de desencadenador
    description: "Cuando utilice uno de los puntos finales para enviar una campaña con Entrega activada por API, puede proporcionar un mapa de claves y valores para personalizar el mensaje. Si realiza una solicitud de API que contiene un objeto en <code>\"trigger_properties\"</code>, los valores de ese objeto se pueden hacer referencia en la plantilla de mensaje en el <code>api_trigger_properties</code> espacio de nombres. <br>
 <br>
 Por ejemplo, una solicitud con <code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> la que se podría añadir la palabra \"zapatos\" al mensaje añadiendo <code>{{api_trigger_properties.${product_name}}}</code>."
    field: "trigger_properties"
  - name: Propiedades de entrada de Canvas
    description: "Cuando utilice uno de los puntos de conexión para activar o programar un Canvas a través del API, puede proporcionar un mapa de claves y valores para personalizar los mensajes enviados por los primeros pasos de Canvas en el <code>\"canvas_entry_properties\"</code> espacio de nombres. <br>
 <br>
 Por ejemplo, una solicitud con <code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> la podría añadir la palabra \"zapatos\" a un mensaje añadiendo <code>{{canvas_entry_properties.${product_name}}}</code>."
    field: "canvas_entry_properties"
  - name: Difusión
    description: "Al enviar un mensaje a un segmento o público de una campaña a través de un punto de conexión API, Braze exige que definas explícitamente si el mensaje es o no una \"difusión\" a un grupo grande de usuarios, incluyendo un <code>broadcast</code> booleano en la llamada API. Es decir, si tienes la intención de enviar un mensaje API a todo el segmento que dirige una campaña o Canvas, debes incluir <code>broadcast: true</code> en la llamada API. <br>
<br>
Broadcast es un campo obligatorio y el valor predeterminado establecido por Braze cuando se realiza una campaña o Canvas es <code>broadcast: false</code>. No puede tener ambos <code>broadcast: true</code> y se especifica una <code>recipients</code> lista. Si el <code>broadcast</code> indicador se establece en true y se proporciona una lista explícita de destinatarios, el punto de conexión API devolverá un error. Del mismo modo, al incluir <code>broadcast: false</code> la lista de destinatarios y no proporcionarla, se devolverá un error. 
    
    <br>
<br>
Tenga cuidado al establecer <code>broadcast: true</code>esta marca, ya que si se configura este indicador de forma no intencionada, puede enviar la campaña o Canvas a una audiencia superior a la prevista. El <code>broadcast</code> indicador es obligatorio para protegerte contra los envíos accidentales a grupos de usuarios."
    field: "broadcast"
    
---
