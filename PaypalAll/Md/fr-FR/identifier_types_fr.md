---
nav_title: "Types d’identifiant API"
article_title: Types d’identifiant API
page_order: 2.2
description: "Cet article de référence couvre les différents types d’identifiants de API qui existent dans le tableau de bord Braze, où vous pouvez les trouver et ce pour quoi ils sont utilisés." 
page_type: reference

---

# Types d’identifiant API

> Ce guide de référence porte sur les différents types d’identifiants de API que l’on peut trouver dans le tableau de bord Braze, leur but, où vous pouvez les trouver et la manière dont ils sont généralement utilisés. Pour en savoir plus sur les clés REST API ou sur les clés API de groupes d’applications, reportez-vous au reste API Aperçu de la [clé.]({{site.baseurl}}/api/api_key/)

Les identifiants de API suivants peuvent être utilisés pour accéder à votre modèle, toile, campagne, segment, envoi ou carte depuis la API externe de Braze. Tous les messages doivent suivre [l’encodage UTF-8][1] .

{% tabs %}
{% tab App Ids %}

## La clé API de l’identifiant de l’application

L’identifiant de l’application API clé ou `app_id` est un paramètre associant l’activité à une application spécifique du groupe d’applications. Il désigne l’application avec laquelle vous interagissez au sein du groupe d’applications avec lequel vous communiquez. Par exemple, vous vous trouverez que vous aurez une `app_id` pour votre application iOS, une `app_id` pour votre application Android et une `app_id` pour votre intégration web. Chez Braze, vous pouvez trouver plusieurs applications pour la même plateforme sur les différents types de plateforme que Braze prend en charge.

#### Où puis-je la trouver ?

Vous pouvez trouver vos :`app_id`

1. Vous pouvez trouver cet `app_id` identifiant ou l’identifiant d’application dans la **console** de développement sous **Paramètres**. Sur cette nouvelle page, sous **Identification**, vous pourrez voir tout ce `app_id` qui existe pour vos applications.

2. Accédez à **Gérer les paramètres** sous **Paramètres**. Sur cette nouvelle page, dans l’onglet **Paramètres** , à mi-chemin de la page, vous trouverez une « clé API pour **APP NAME** on **PLATFORM** » (par exemple « API Key pour la glace sur iOS). Cette clé API est l’identifiant de votre application.

#### Pour quelle raison peut-il être utilisé ?

Les identifiants d’application à Braze sont utilisés lors de l’intégration du savoir-faire et sont également utilisés pour référence d’une application spécifique dans REST API appels. Avec le `app_id` vous pouvez faire beaucoup de choses comme récupérer des données pour un événement personnalisé qui s’est produit pour une application particulière, récupérer les statistiques noninstallées, les statistiques des utilisateurs nouvelles, les statistiques DAU et les statistiques de début de session pour une application particulière.

Parfois, vous trouverez peut-être que vous êtes invité à obtenir une `app_id` application, mais vous ne travaillez pas avec une application, car il s’agit d’un champ existant spécifique à une plateforme spécifique, vous pouvez « ignorer » ce champ en incluant toute suite de caractères en tant que titulaire de place pour ce paramètre obligatoire.

#### Clés API d’identification de l’application multiples

Au cours de la configuration du KSD, le cas d’utilisation le plus courant pour plusieurs applications identifier API clés est de séparer ces clés pour le débogage et les variantes de construction.
Pour passer facilement d’un identifiant d’application à plusieurs clés API dans vos builds, nous vous recommandons de créer un fichier distinct `braze.xml` pour chaque version[ de build.][3] Une variante de la build est une combinaison de type de build et de parfum de produit. Notez que par défaut, un nouveau projet Android est configuré avec `debug` et `release` construire des types et pas de saveurs de produit.

Pour chaque version de build pertinente, créez-en une nouvelle `braze.xml` pour `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Lorsque la version de compilation est compilée, elle utilise la nouvelle clé API.

{% endtab %}
{% tab Template Ids %}

## Identifiant API du modèle

Un [modèle]({{site.baseurl}}/api/endpoints/templates/) API identifiant ou numéro de modèle est une clé hors du cadre par Braze pour un modèle donné dans le tableau de bord. Les identifiants de modèle sont propres à chaque modèle et peuvent être utilisés pour des modèles de référence via le API. 

Les modèles sont adaptés si votre entreprise contracte vos conceptions HTML pour des campagnes. Une fois les modèles créés, vous avez maintenant un modèle qui ne correspond pas à une campagne, mais qui peut être appliqué à une série de campagnes, comme par exemple un newsletter.

#### Où puis-je la trouver ?
Vous pouvez trouver votre identifiant de modèle de l’une des deux manières suivantes :

1. Dans le tableau de bord, ouvrez **modèles et supports** sous **Engagement** et sélectionnez un modèle préexistant. Si le modèle que vous souhaitez n’existe pas encore, créez-en et enregistrez-le. En bas de la page de modèle individuel, vous pourrez trouver votre modèle API identifiant.<br>
<br>

2. Braze propose une **recherche d’identifiants** API supplémentaires. Vous pouvez y rechercher rapidement des identifiants spécifiques. Vous pouvez le trouver en bas de l’onglet **Paramètres** API de la **page Console** de développement.

#### Pour quelle raison peut-il être utilisé ?

- Mettre à jour les modèles sur API
- Saisissez des informations sur un modèle spécifique.

<br>
{% endtab %}
{% tab Canvas IDs %}

## Identifiant API toile

Un [toile]({{site.baseurl}}/user_guide/engagement_tools/canvas/) API identifiant ou identifiant de toile est une clé hors de la case par Braze pour un toile donné dans le tableau de bord. Les identifiants de toile sont uniques à chaque toile et peuvent être utilisés pour faire référence aux toiles à travers le API. 

Notez que si vous avez un tableau comportant des variantes, il existe un numéro de toile global ainsi qu’un ID de toile variant individuel ident sous le tableau principal. 

#### Où puis-je la trouver ?
Vous pouvez trouver votre identifiant toile dans le tableau de bord. Ouvrez toile **** sous **Engagement** et sélectionnez un toile préexistante. Si le tableau que vous souhaitez obtenir n’existe pas encore, créez-en et enregistrez-le. En bas d’une page toile individuelle, cliquez sur **Analyser les** versions. Une fenêtre s’affiche avec l’identifiant API canvas situé en bas.

#### Pour quelle raison peut-il être utilisé ?
- Suivre les analyses d’un message spécifique
- Statistiques agrégées de haut niveau sur les performances sur toile
- Saisissez des détails sur un toile spécifique.
- Avec les courants afin de mettre en place des données au niveau de l’utilisateur pour une « plus grande image » approche des toiles
- Une fois le API déclencher la livraison afin de collecter des statistiques sur les messages relatifs aux transactions

<br>
{% endtab %}
{% tab Campaign IDs %}

## Identifiant API de la campagne

Une [campagne]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) API identifiant ou identifiant de campagne est une clé hors du cadre par Braze pour une campagne donnée dans le tableau de bord. Les identifiants de campagne sont propres à chaque campagne et peuvent être utilisés pour les campagnes de référence par le biais du API. 

Notez que si vous avez une campagne comportant des variantes, il y a un numéro global de campagne ainsi que des identifiants de campagne variant individuels imbriqués sous la campagne principale. 

#### Où puis-je la trouver ?
Vous pouvez trouver l’identifiant de votre campagne de deux manières :

1. Dans le tableau de bord, ouvrez les **campagnes** sous **Engagement** et sélectionnez une campagne préexistante. Si la campagne que vous souhaitez n’existe pas encore, créez-en et enregistrez-la. En bas de la page de la campagne, vous pouvez trouver votre **identifiant API** campagne.<br>
<br>

2. Braze propose une **recherche d’identifiants** API supplémentaires. Vous pouvez y rechercher rapidement des identifiants spécifiques. Vous le trouverez en bas de l’onglet **Paramètres** API dans la console** de **développeurs.

#### Pour quelle raison peut-il être utilisé ?
- Suivre les analyses d’un message spécifique
- Obtenir des statistiques agrégées de haut niveau sur les performances des campagnes.
- En savoir plus sur une campagne spécifique
- Avec les courants afin de fournir des données au niveau de l’utilisateur pour une approche « plus globale » des campagnes
- Une livraison avec API déclenché pour collecter des statistiques sur les messages relatifs aux transactions
- Pour [rechercher une campagne]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) spécifique sur la page Campagnes** à l’aide **du filtre`api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Segmenter l’identifiant API

Un [identifiant API]({{site.baseurl}}/user_guide/engagement_tools/segments/) segment ou un identifiant de segment est une clé hors du cadre par Braze pour un segment donné dans le tableau de bord. Les identifiants de segment sont propres à chaque segment et peuvent être utilisés pour des segments de référence à travers le API. 

#### Où puis-je la trouver ?
Vous pouvez trouver votre identifiant de segment de l’une des deux façons suivantes :

1. Dans le tableau de bord, ouvrez **les segments** sous **Engagement** et sélectionnez un segment préexistant. Si le segment que vous souhaitez n’existe pas encore, créez-en un et enregistrez-le. En bas de la page segment, vous pourrez trouver votre identifiant de segment API. <br>
<br>

2. Braze propose une **recherche d’identifiants** API supplémentaires. Vous pouvez y rechercher rapidement des identifiants spécifiques. Vous pouvez le trouver en bas de l’onglet **Paramètres** API de la **page Console** de développement.

#### Pour quelle raison peut-il être utilisé ?
- Obtenez des informations sur un segment spécifique.
- Récupérer des analyses d’un segment spécifique.
- Tirez le nombre de fois qu’un événement personnalisé a été enregistré pour un segment particulier.
- Indiquez et envoyez une campagne à des membres d’un segment dans la API

{% endtab %}
{% tab Card IDs %}

## Identifiant API de carte

Une carte API un identifiant ou une pièce d’identité de carte est une clé hors du cadre par Braze pour un flux d’actualités donné dans le tableau de bord. Les identifiants de carte sont propres à chaque []({{site.baseurl}}/user_guide/engagement_tools/news_feed/) Carte Actualités et peuvent être utilisés pour référence des Cartes via la API. 

#### Où puis-je la trouver ?
Vous pouvez trouver votre Identifiant de carte de l’une des deux façons suivantes :

1. Dans le tableau de bord, ouvrez le flux **d’actualités** sous **Engagement** et sélectionnez un fil d’actualités préexistant. Si le flux d’actualités que vous souhaitez n’existe pas encore, créez-en un et enregistrez-le. En bas de la page d’actualités de chaque page, vous pourrez trouver votre carte unique API identifiant. <br>
<br>

2. Braze propose une **recherche d’identifiants** API supplémentaires. Vous pouvez y rechercher rapidement des identifiants spécifiques. Vous pouvez le trouver en bas de l’onglet **Paramètres** API de la **page Console** de développement.

#### Pour quelle raison peut-il être utilisé ?
- Récupérer les informations pertinentes sur une carte
- Suivre les événements liés aux Cartes de contenu et aux engagements

<br>
{% endtab %}
{% tab Send IDs %}

## Envoyer l’identifiant

Un identifiant d’envoi ou d’envoi est une clé générée par Braze ou créée par vous pour envoyer un message dans le cadre duquel les analyses doivent être suivies. L’identifiant d’envoi vous permet de récupérer des analyses dans un exemple spécifique d’envoi de campagne via le point d’extrémité [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) .

#### Où puis-je la trouver ?

API et API déclenchent des campagnes qui sont envoyées lors d’une émission génèreront automatiquement un identifiant d’envoi si un identifiant d’envoi n’est pas fourni. Si vous souhaitez spécifier votre propre identifiant d’envoi, vous devez d’abord en créer un via le point d’extrémité [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) . L’identifiant doit être composé de tous les caractères ASCII et au plus 64 caractères. Si vous souhaitez regrouper ces envois, vous pouvez réutiliser un identifiant d’envoi pour plusieurs envois de la même campagne.

#### Pour quelle raison peut-il être utilisé ?
Envoyez et suivez les performances des messages par programme, sans création de campagne pour chaque envoi.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
