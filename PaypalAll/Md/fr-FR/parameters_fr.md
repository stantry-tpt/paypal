---
page_order: 2.4
nav_title: Paramètres
article_title: Paramètres API
layout: glossary_page
glossary_top_header: "Paramètres"
glossary_top_text: "Utilisez ces paramètres pour définir vos demandes de API. Bien que les paramètres dont vous avez besoin soient répertoriés sous les points d’extrémité, cela devrait vous donner plus d’informations sur leurs nuances et leurs autres caractéristiques."

description: "Ce glossaire couvre en détail les paramètres impliqués dans la réalisation de API demandes." 
page_type: glossary

glossaries:
  - name: Clé REST API du Groupe d’applications
    description: L’application <code>api_key</code> indique le titre de l’application avec lequel les données de cette demande sont associées et authentifie le demandeur en tant que personne autorisée à envoyer des messages sur l’application. Il doit être inclus à chaque demande en tant qu’en-tête d’autorisation HTTP. Vous pouvez le trouver dans la <strong>section Console</strong> pour développeurs du tableau de bord Braze.
    field: "api_key"
  - name: Identifiant de l’application
    description: Si vous souhaitez envoyer de l’argent à un ensemble de jetons d’appareil (au lieu d’utilisateurs), vous devez indiquer au nom de l’application spécifique que vous utilisez la messagerie. Dans ce cas, vous devrez indiquer l’identifiant de l’application approprié dans un objet tokens. Vous pouvez le trouver dans la <strong>section Console</strong> pour développeurs du tableau de bord Braze.
    field: "app_id"
  - name: Identifiant externe d’utilisateur
    description: Un identifiant unique pour envoyer un message à des utilisateurs spécifiques. Cet identifiant doit être identique à celui que vous avez défini dans le SDK de Braze. Vous pouvez uniquement cibler les utilisateurs pour des messages qui ont déjà été identifiés par le biais du SDK ou du API utilisateur. Un maximum de 50 identifiants d’utilisateurs externes sont autorisés dans une demande. <br>
 <br>
 Pour les points d'extrémité de déclenchement de la campagne, si vous fournissez ce champ, les critères seront comportant les segments de la campagne et seuls les utilisateurs figurant dans la liste des identifiants d'utilisateur externes et le segment de la campagne recevront le message.
    field: "external_user_ids"
  - name: Identifiant de segment
    description: Il <code>segment_id</code> indique le segment à lequel le message doit être envoyé. Un identifiant de segment pour chacun des segments que vous avez créés est disponible dans la <strong>section Console</strong> pour les développeurs du tableau de bord Braze. <br>
 <br>
 Pour les points d’extrémité du message, si vous fournissez à la fois un identifiant de segment et une liste d’identifiants d’utilisateurs externes dans une demande de messagerie unique, les critères seront classés en couches et seuls les utilisateurs répertoriés dans la liste des identifiants d’utilisateurs externes et du segment fourni recevront le message.
    field: "segment_id"
  - name: Identifiant de la campagne
    description: Pour les points d’extrémité de la messagerie, il <code>campaign_id</code> indique la campagne API au cours de laquelle il faut suivre les analyses nécessaires à la communication. Un identifiant de campagne pour chacune des campagnes que vous avez créées est disponible dans la <strong>section Console</strong> de développeurs du tableau de bord Braze. Si vous indiquez un identifiant de campagne dans l’organisme demandé, vous devez fournir un <code>message_variation_id</code> élément de chacun des objets du message indiquant la version représentée de votre campagne. <br>
 <br>
 Pour les critères d’échéance de déclenchement de la campagne, l’état <code>campaign_id</code> indique la API’identifiant de la campagne qui sera déclenchée. Ce champ est requis pour toutes les demandes d’endpoint de déclenchement.
    field: "campaign_id"
  - name: Identifiant de toile
    description: Pour les critères d’échéance déclenchant un tableau, l’indique <code>canvas_id</code> que l’identifiant de la toile doit être déclenché ou programmé. Ce champ est requis pour toutes les demandes d’endpoint de déclenchement.
    field: "canvas_id"
  - name: Envoyer l’identifiant
    description: Pour les points d’extrémité de la messagerie, il <code>send_id</code> indique l’envoi en fonction duquel les analyses d’un message doivent être suivies. Cela <code>send_id</code> vous permet de récupérer des analyses dans un exemple spécifique d’envoi d’une campagne via le point d’extrémité <code>sends/data_series</code> . API et API déclenchent des campagnes qui sont envoyées lors d’une émission génèreront automatiquement un identifiant d’envoi si un identifiant d’envoi n’est pas fourni. <br>
 <br>
 Si vous voulez spécifier votre propre <code>send_id</code>, vous devez d'abord en créer un via le point d' <code>sends/id/create</code> extrémité. Ces <code>send_id</code> caractères doivent être composés de tous les caractères ASCII et d’une longueur maximum de 64 caractères.  Si vous souhaitez regrouper ces envois, vous pouvez réutiliser un identifiant d’envoi pour plusieurs envois de la même campagne. <br>
 <br>
 <code>send_id</code> Les emails envoyés via Mailjet ne peuvent pas faire l’objet de suivi. <br>
 <br>
 Les conversions de campagne sont attribuées au dernier suivi reçu par <code>send_id</code> l’utilisateur pour cette campagne, sauf si le dernier envoi reçu par l’utilisateur n’a pas été suivi.
    field: "send_id"
  - name: Déclencher des propriétés
    description: "Lorsque vous utilisez l’un des points d’extrémité pour envoyer une campagne avec la livraison API déclenchée, vous pouvez fournir une carte des clés et des valeurs pour personnaliser votre message. Si vous faites une demande de API contenant un objet dans <code>\"trigger_properties\"</code>, les valeurs de cet objet peuvent alors être référencées dans votre modèle de message dans l’espace de <code>api_trigger_properties</code> nom. <br>
 <br>
 Par exemple, une demande avec <code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> peut ajouter les chaussures\" de mot \"au message en ajoutant <code>{{api_trigger_properties.${product_name}}}</code>."
    field: "trigger_properties"
  - name: Propriétés de saisie de toile
    description: "Lorsque vous utilisez l’un des points d’extrémité pour déclencher ou programmer un toile via l’API, vous pouvez fournir une carte de clés et de valeurs pour personnaliser les messages envoyés par les premières étapes de votre toile, dans l’espace <code>\"canvas_entry_properties\"</code> de nom. <br>
 <br>
 Par exemple, une demande avec <code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> peut ajouter les chaussures\" de mot \"à un message en ajoutant <code>{{canvas_entry_properties.${product_name}}}</code>."
    field: "canvas_entry_properties"
  - name: Diffusion
    description: "Lorsque vous envoyez un message à un segment ou à une audience de campagne à l’aide d’un point d’extrémité API, Braze vous demande de définir explicitement si votre message est une \"émission diffusée\" à un grand groupe d’utilisateurs en incluant l’alcool <code>broadcast</code> dans le API appel. En d’autres termes, si vous avez l’intention d’envoyer un message de API à l’ensemble du segment qu’une campagne ou Canvas cible, vous devez inclure <code>broadcast: true</code> dans votre appel API. <br>
<br>
La diffusion est un champ obligatoire et la valeur par défaut définie par Braze lorsqu’une campagne ou un toile est <code>broadcast: false</code>effectuée . Vous ne pouvez pas définir les deux <code>broadcast: true</code> ainsi qu'une <code>recipients</code> liste. Si l’indicateur <code>broadcast</code> est true et qu’une liste explicite de destinataires est fournie, le API point d’extrémité renvoie une erreur. De la même manière, l’inclusion <code>broadcast: false</code> et la non-fourniture d’une liste de destinataires renviendront une erreur. 
    
    <br>
<br>
Faites preuve de prudence lorsque vous configurez <code>broadcast: true</code>ce indicateur involontairement et vous pourrez envoyer votre campagne ou toile à un public plus grand que prévu. L’indicateur <code>broadcast</code> est requis pour éviter les envois fortuits à de grands groupes d’utilisateurs."
    field: "broadcast"
    
---
