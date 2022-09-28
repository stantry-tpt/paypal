---
nav_title: "Tipos de identificadores de API"
article_title: Tipos de identificadores de API
page_order: 2.2
description: "Este artículo de referencia trata sobre los distintos tipos de identificadores de API que existen en el panel de Braze, dónde se pueden encontrar y para qué se utilizan." 
page_type: reference

---

# API tipos de identificadores

> Esta guía de referencia trata de los diferentes tipos de identificadores de API que se pueden encontrar en el panel de Braze, su propósito, dónde puede encontrarlos y cómo se utilizan normalmente. Para obtener información sobre REST API claves o claves API un grupo de aplicaciones, consulte Descripción general de [rest API clave]({{site.baseurl}}/api/api_key/)

Los siguientes identificadores de API se pueden utilizar para acceder a la plantilla, el lienzo, la campaña, el segmento, el envío o la tarjeta del API externo de Braze. Todos los mensajes deben seguir [la codificación UTF-8][1] .

{% tabs %}
{% tab App Ids %}

## La clave API identificador de aplicación

El identificador de aplicación API clave o `app_id` es un parámetro que asocia la actividad con una aplicación específica del grupo de aplicaciones. Designa la aplicación del grupo de aplicaciones con el que estás interactuando. Por ejemplo, encontrarás una `app_id` para la aplicación para iOS, una `app_id` para la aplicación de Android y una `app_id` para tu integración web. En Braze, puedes encontrar que tienes varias aplicaciones para la misma plataforma en los varios tipos de plataformas que Braze es compatible.

#### ¿Dónde puedo encontrarlo?

Hay dos formas de localizar tu información `app_id`:

1. Puede encontrar este `app_id` identificador o de aplicación en la configuración de la **consola para programadores******. En esta nueva página, en la sección **Identificación**, podrás ver todo lo `app_id` que existe para tus aplicaciones.

2. Ve a **Administrar configuración** en **Configuración**. Desde esta nueva página, en la **pestaña Configuración** , a la mitad de la página encontrará una "clave de API para **APP NAME** en **PLATFORM**" (p. ej., "API Key para Helado en iOS). Esta clave API es tu identificador de aplicación.

#### ¿Para qué puede utilizarse?

Los identificadores de aplicación en Braze se utilizan en la integración de la SDK y también se utilizan para hacer referencia a una aplicación específica en REST API llamadas. Con el `app_id` usted puede hacer muchas cosas, como extraer datos para un evento personalizado que ocurrió para una aplicación en particular, recuperar las estadísticas de desinstalación, las nuevas estadísticas de usuario, las estadísticas de DAU, y las estadísticas de inicio de sesión para una aplicación en particular.

En ocasiones, puede que se le solicite un `app_id` pero no está trabajando con una aplicación, porque se trata de un campo heredado específico a una plataforma específica, puede "omitir" este campo al incluir cualquier cadena de caracteres como marcador de posición para este parámetro requerido.

#### Varias claves API identificadores de aplicación

Durante SDK configuración, el caso de uso más común para varias claves de API identificador de aplicación es separar dichas claves para la depuración y liberación de variantes de compilación.
Para cambiar fácilmente entre varios identificadores de aplicación API claves en las compilación, le recomendamos crear un archivo independiente `braze.xml` para cada variante[ de compilación pertinente][3]. Una variante de construcción es una combinación de tipo de construcción y sabor a producto. Tenga en cuenta que de forma predeterminada un nuevo proyecto de Android está configurado con `debug` y `release` tipos de construcción y sin sabores de producto.

Para cada variante de compilación pertinente, cree una nueva `braze.xml` para ella en `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Cuando se compila la variante de compilación, utilizará la nueva clave API.

{% endtab %}
{% tab Template Ids %}

## Identificador API plantilla

Una [plantilla]({{site.baseurl}}/api/endpoints/templates/) API identificador o Id. de plantilla es una clave out-of-the-box de Braze para una plantilla determinada dentro del panel. Los Id. de plantilla son exclusivos para cada plantilla y se pueden usar para hacer referencia a plantillas a través de las API. 

Las plantillas son ideales para si tu empresa contrata tus diseños HTML para campañas. Una vez creadas las plantillas, ahora tendrás una plantilla no específica de una campaña, pero que puede aplicarse a una serie de campañas como un boletín de noticias.

#### ¿Dónde puedo encontrarlo?
Puedes encontrar el Id. de plantilla de una de dos maneras:

1. En el panel, abre **Plantillas y medios** en **Interacción** y selecciona una plantilla existente. Si la plantilla que deseas todavía no existe, crea una y guárdala. En la parte inferior de la página de plantilla individual, podrá encontrar el identificador de API de plantilla.<br>
<br>

2. Braze ofrece una **búsqueda adicional API identificadores** , aquí puedes buscar rápidamente los identificadores específicos. Puede encontrarlo en la parte inferior de la **pestaña Configuración** API, en la página de la **consola** para programadores.

#### ¿Para qué puede utilizarse?

- Actualizar plantillas durante más de API
- Obtener información de una plantilla específica

<br>
{% endtab %}
{% tab Canvas IDs %}

## Identificador API de Canvas

Un [identificador de API de Canvas]({{site.baseurl}}/user_guide/engagement_tools/canvas/) o Id. de Canvas es una clave out-of-the-box de Braze para un Canvas determinado dentro del panel. Los Id. de canvas son exclusivos para cada uno de ellos y se pueden utilizar para hacer referencia a los canvases a través del API. 

Ten en cuenta que si tienes un Canvas que tiene variantes, existe un ID de Canvas global y un Id. de canvas de variantes individuales anidados bajo el lienzo principal. 

#### ¿Dónde puedo encontrarlo?
Encontrarás tu ID de Canvas en el panel. **Abre Canvas** en **Interacción** y selecciona un canvas existente. Si el canvas que quieres todavía no existe, crea uno y guárdalo. En la parte inferior de una página de Canvas individual, haga clic en **Analizar variantes**. Aparecerá una ventana con el identificador API de Canvas en la parte inferior.

#### ¿Para qué puede utilizarse?
- Realizar un seguimiento de los análisis en un mensaje específico
- Obtenga estadísticas agregadas de alto nivel en el rendimiento de Canvas
- Obtener detalles sobre un Canvas específico
- Con Currents para ofrecer datos a nivel de usuario para un enfoque de una visión general de los lienzos
- Con los API activa la entrega para recopilar estadísticas sobre mensajes sobre transacciones

<br>
{% endtab %}
{% tab Campaign IDs %}

## Identificador de API de campaña

[ Un ]({{site.baseurl}}/user_guide/engagement_tools/campaigns/)identificador de API de campaña o Id. de campaña es una clave general de Braze para una campaña determinada dentro del panel. Los Id. de las campañas son exclusivos para cada campaña y se pueden utilizar para hacer referencia a las campañas a través de las API. 

Ten en cuenta que si tienes una campaña que tiene variantes, hay tanto un Id. de campaña general como id. de campaña de variantes individuales anidados en la campaña principal. 

#### ¿Dónde puedo encontrarlo?
Puedes encontrar el Id. de campaña de una de dos maneras:

1. En el panel, abre **Campañas** en **Interacción** y selecciona una campaña existente. Si la campaña que desees todavía no existe, crea una y guárdala. En la parte inferior de la página de cada campaña, podrás encontrar **el identificador** de API de campaña.<br>
<br>

2. Braze ofrece una **búsqueda adicional API identificadores** , aquí puedes buscar rápidamente los identificadores específicos. Puede encontrar esta información en la parte inferior de la **pestaña Configuración** de API de la **consola para programadores**.

#### ¿Para qué puede utilizarse?
- Realizar un seguimiento de los análisis en un mensaje específico
- Obtenga estadísticas agregadas de alto nivel sobre el rendimiento de la campaña
- Obtener detalles de una campaña específica
- Con Currents para ofrecer datos a nivel de usuario para un enfoque de una visión más general de las campañas
- Con la entrega activada por la API con el fin de recopilar estadísticas sobre mensajes sobre transacciones
- Para [buscar una campaña]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) específica en la **página Campañas** mediante el filtro `api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Identificador API segmento

Un [identificador]({{site.baseurl}}/user_guide/engagement_tools/segments/) de API segmento o Id. de segmento es una clave out-of-box de Braze para un segmento determinado dentro del panel. Los Id. de segmento son exclusivos para cada segmento y se pueden utilizar para hacer referencia a los segmentos a través del API. 

#### ¿Dónde puedo encontrarlo?
El Id. de segmento tiene dos maneras:

1. En el panel, abre **segmentos** en **Interacción** y selecciona un segmento existente. Si el segmento que deseas todavía no existe, crea uno y guárdalo. En la parte inferior de la página de segmento individual, podrá encontrar el identificador de API segmento. <br>
<br>

2. Braze ofrece una **búsqueda adicional API identificadores** , aquí puedes buscar rápidamente los identificadores específicos. Puede encontrarlo en la parte inferior de la **pestaña Configuración** API, en la página de la **consola** para programadores.

#### ¿Para qué puede utilizarse?
- Obtener detalles sobre un segmento específico
- Recuperar análisis de un segmento específico
- Extraer el número de veces que se grabó un evento personalizado para un segmento determinado
- Especificar y enviar una campaña a un miembro de un segmento desde el interior del API

{% endtab %}
{% tab Card IDs %}

## Identificador API tarjeta

Una tarjeta API identificador o id. de tarjeta es una clave general de Braze para una tarjeta de fuente de noticias determinada en el panel. Los Id. de las tarjetas son exclusivos para cada [tarjeta de fuente]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) de noticias y se pueden utilizar para hacer referencia a las Tarjetas a través de las API. 

#### ¿Dónde puedo encontrarlo?
Tienes dos opciones para encontrar el Id. de tarjeta:

1. En el panel, abre fuente de noticias **** en **"Interacción**" y selecciona una fuente de noticias existente. Si el fuente de noticias que quieres todavía no existe, crea uno y guárdalo. En la parte inferior de cada página del canal de noticias, encontrará el identificador de API tarjeta exclusivo. <br>
<br>

2. Braze ofrece una **búsqueda adicional API identificadores** , aquí puedes buscar rápidamente los identificadores específicos. Puede encontrarlo en la parte inferior de la **pestaña Configuración** API, en la página de la **consola** para programadores.

#### ¿Para qué puede utilizarse?
- Recuperar información relevante de una tarjeta
- Seguimiento de eventos relacionados con tarjetas de contenido y interacción

<br>
{% endtab %}
{% tab Send IDs %}

## Identificador de envío

Un identificador de envío o identificador de envío es una clave generada por Braze o creada por ti para un envío de mensaje determinado bajo la cual se debe realizar el seguimiento de las estadísticas. El identificador de envío le permite obtener análisis de una instancia específica de envío de una campaña a través del [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) punto de conexión.

#### ¿Dónde puedo encontrarlo?

API y API activar campañas que se envían como difusión generarán automáticamente un identificador de envío si no se proporciona uno. Si desea especificar su propio identificador de envío, primero tendrá que crear uno a través del [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) punto de conexión. El identificador debe tener todos los caracteres ASCII y un máximo de 64 caracteres de longitud. Puede volver a utilizar un identificador de envío en varios envíos de la misma campaña si desea agrupar los análisis de esos envíos juntos.

#### ¿Para qué puede utilizarse?
Envía y haz un seguimiento del rendimiento de los mensajes mediante programación, sin necesidad de crear una campaña para cada envío.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
