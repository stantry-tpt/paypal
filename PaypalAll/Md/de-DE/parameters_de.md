---
page_order: 2.4
nav_title: Parameter
article_title: API-Parameter
layout: glossary_page
glossary_top_header: "Parameter"
glossary_top_text: "Verwenden Sie diese Parameter, um Ihre API-Anforderungen zu definieren. Obwohl die von Ihnen benötigten Parameter unter Endpunkte aufgeführt sind, sollten Sie dadurch mehr Einblick in deren Nuance und andere Spezifikationen erhalten."

description: "Dieses Glossar behandelt im Detail die Parameter, die bei API-Anfragen verwendet werden." 
page_type: glossary

glossaries:
  - name: App-Gruppe REST API-Schlüssel
    description: zeigt den App-Titel <code>api_key</code> an, mit dem die Daten in dieser Anfrage verknüpft sind, und authentifiziert den Anforderer als jemanden, der Nachrichten an die App senden darf. Sie muss bei jeder Anfrage als HTTP-Autorisierungsheader enthalten sein. Sie finden sie im Abschnitt „<strong>Developer Console</strong>“ des Braze-Dashboards.
    field: "api_key"
  - name: App-Kennung
    description: Wenn Sie Push an eine Reihe von Gerätetokens senden möchten (anstelle von Benutzern), müssen Sie angeben, in welchem Namen welche bestimmte App Sie Nachrichten senden. In diesem Fall geben Sie die entsprechende App-Kennung in einem Token-Objekt an. Sie finden sie im Abschnitt „<strong>Developer Console</strong>“ des Braze-Dashboards.
    field: "app_id"
  - name: Externe Benutzer-ID
    description: Eine eindeutige Kennung zum Senden einer Nachricht an bestimmte Benutzer. Diese Kennung sollte mit der im Braze SDK festgelegten Kennung übereinstimmen. Sie können nur Benutzer für Nachrichten ansprechen, die bereits über das SDK oder die Benutzer-API identifiziert wurden. In einer Anfrage sind maximal 50 externe Benutzer-IDs zulässig. <br>
 <br>
 Wenn Sie dieses Feld für Kampagnenauslöserendpunkte bereitstellen, werden die Kriterien mit den Kampagnensegmenten geschichtet und nur Benutzer, die in der Liste der externen Benutzer-IDs und des Kampagnensegments enthalten sind, erhalten die Nachricht.
    field: "external_user_ids"
  - name: Segment-Kennung
    description: zeigt das Segment <code>segment_id</code> an, an das die Nachricht gesendet werden soll. Eine Segmentkennung für jedes der von Ihnen erstellten Segmente finden Sie im Abschnitt „<strong>Developer Console</strong>“ des Braze-Dashboards. <br>
 <br>
 Wenn Sie für Nachrichtenendpunkte sowohl eine Segmentkennung als auch eine Liste externer Benutzer-IDs in einer einzigen Messaging-Anforderung bereitstellen, werden die Kriterien mehrschichtig dargestellt und nur Benutzer, die sowohl in der Liste der externen Benutzer-IDs als auch im angegebenen Segment enthalten sind, erhalten die Nachricht.
    field: "segment_id"
  - name: Kampagnen-ID
    description: Für Messaging-Endpunkte <code>campaign_id</code> zeigt die API-Kampagne an, unter der die Analyse einer Nachricht verfolgt werden soll. Eine Kampagnenkennung für jede der Kampagnen, die Sie erstellt haben, finden Sie im Abschnitt „<strong>Developer Console</strong>“ des Braze-Dashboards. Wenn Sie im Anforderungstext eine Kampagnenkennung angeben, müssen Sie <code>message_variation_id</code> in jedem der Nachrichtenobjekte eine angeben, die die dargestellte Variante Ihrer Kampagne angibt. <br>
 <br>
 Für Kampagnenauslöserendpunkte <code>campaign_id</code> gibt die die API-ID der auszulösenden Kampagne an. Dieses Feld ist für alle Trigger-Endpunktanforderungen erforderlich.
    field: "campaign_id"
  - name: Canvas-Kennung
    description: Bei Endpunkten, die Canvas auslösen, <code>canvas_id</code> gibt die die Kennung des Canvas an, der ausgelöst oder geplant werden soll. Dieses Feld ist für alle Trigger-Endpunktanforderungen erforderlich.
    field: "canvas_id"
  - name: Kennung senden
    description: Für Messaging-Endpunkte <code>send_id</code> gibt die an, unter welchem Senden die Analyse für eine Nachricht verfolgt werden soll. <code>send_id</code> Mit können Sie Analysen für eine bestimmte Instanz einer Kampagne abrufen, die über den <code>sends/data_series</code> Endpunkt gesendet wird. API- und API-Trigger-Kampagnen, die als Broadcast gesendet werden, generieren automatisch eine Sendekennung, wenn keine Sendekennung bereitgestellt wird. <br>
 <br>
 Wenn Sie Ihre eigene angeben möchten<code>send_id</code>, müssen Sie zunächst eine über den <code>sends/id/create</code> Endpunkt erstellen. Der <code>send_id</code> muss alle ASCII-Zeichen und höchstens 64 Zeichen lang sein.  Sie können eine Sendekennung für mehrere Sendungen derselben Kampagne wiederverwenden, wenn Sie die Analysen dieser Sendungen zusammen gruppieren möchten. <br>
 <br>
 Beachten Sie, dass die <code>send_id</code> Nachverfolgung für E-Mails, die über Mailjet gesendet werden, nicht verfügbar ist. <br>
 <br>
 Kampagnenkonversionen werden der letzten verfolgten<code>send_id</code>, die der Benutzer von dieser Kampagne erhalten hat, zugeordnet, es sei denn, die letzte Sendung, die der Benutzer erhalten hat, wurde nicht verfolgt.
    field: "send_id"
  - name: Eigenschaften auslösen
    description: "Wenn Sie einen der Endpunkte zum Senden einer Kampagne mit API-Triggered Delivery verwenden, können Sie eine Karte mit Schlüsseln und Werten bereitstellen, um Ihre Nachricht anzupassen. Wenn Sie eine API-Anforderung erstellen, die ein Objekt in enthält<code>\"trigger_properties\"</code>, können die Werte in diesem Objekt dann in Ihrer Nachrichtenvorlage unter dem <code>api_trigger_properties</code> Namensraum referenziert werden. <br>
 <br>
 Eine Anfrage mit <code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> könnte beispielsweise das Wort \"Schuhe\" zur Nachricht hinzufügen, indem sie hinzufügt<code>{{api_trigger_properties.${product_name}}}</code>."
    field: "trigger_properties"
  - name: Canvas-Eingabeeigenschaften
    description: "Wenn Sie einen der Endpunkte zum Auslösen oder Planen eines Canvas über die API verwenden, können Sie eine Karte mit Schlüsseln und Werten bereitstellen, um Nachrichten anzupassen, die von den ersten Schritten Ihres Canvas im <code>\"canvas_entry_properties\"</code> Namensraum gesendet werden. <br>
 <br>
 Beispielsweise <code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> könnte eine Anfrage mit das Wort \"Schuhe\" zu einer Nachricht hinzufügen, indem sie hinzufügt<code>{{canvas_entry_properties.${product_name}}}</code>."
    field: "canvas_entry_properties"
  - name: Rundfunk
    description: "Wenn Sie eine Nachricht an ein Segment oder eine Kampagnenzielgruppe senden, die einen API-Endpunkt verwendet, muss Braze ausdrücklich definieren, ob Ihre Nachricht eine \"Nachricht\" an eine große Gruppe von Benutzern ist, indem ein <code>broadcast</code> Boolescher in den API-Aufruf aufgenommen wird. Das heißt, wenn Sie beabsichtigen, eine API-Nachricht an das gesamte Segment zu senden, das eine Kampagne oder Canvas anvisiert, müssen Sie sie <code>broadcast: true</code> in Ihren API-Aufruf aufnehmen. <br>
<br>
Broadcast ist ein erforderliches Feld und der von Braze festgelegte Standardwert, wenn eine Kampagne oder Canvas erstellt wird, ist <code>broadcast: false</code>. Sie können nicht beide <code>broadcast: true</code> und eine <code>recipients</code> Liste angegeben haben. Wenn das <code>broadcast</code> Flag auf wahr gesetzt ist und eine explizite Empfängerliste bereitgestellt wird, gibt der API-Endpunkt einen Fehler zurück. In ähnlicher Weise wird die Angabe <code>broadcast: false</code> und Nichtbereitstellung einer Empfängerliste zu einem Fehler führen. 
    
    <br>
<br>
Seien Sie vorsichtig bei der Einstellung von <code>broadcast: true</code>, da das unbeabsichtigte Setzen dieses Flags dazu führen kann, dass Sie Ihre Kampagne oder Ihren Canvas an eine größere Zielgruppe als erwartet senden. Das <code>broadcast</code> Flag ist erforderlich, um vor versehentlichen Sendungen an große Benutzergruppen zu schützen."
    field: "broadcast"
    
---