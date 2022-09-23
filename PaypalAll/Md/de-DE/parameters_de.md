---
page_order: 2.4
nav_title: Parameter
article_title: API Parameter
layout: glossary_page
glossary_top_header: "Parameter"
glossary_top_text: "Verwenden Sie diese Parameter, um Ihre API Anforderungen zu definieren. Obwohl die benötigten Parameter unter den Endpunkten aufgeführt sind, sollten Sie dadurch mehr Einblick in ihre Nuance und andere Spezifikationen geben."

description: "Dieses Glossar umfasst genau die für die API Anfragen erforderlichen Parameter." 
page_type: glossary

glossaries:
  - name: App-Gruppe REST API Key
    description: Dies <code>api_key</code> zeigt den App Titel an, mit dem die Daten in dieser Anfrage verknüpft sind, und authentifiziert den Anfordernden als jemand, der erlaubt ist, Nachrichten an die App zu senden. Sie muss in jede Anforderung als HTTP-Autorisierungs-Header aufgenommen werden. Sie finden sie in der <strong>Developer Konsole</strong> des Braze-Dashboard.
    field: "api_key"
  - name: App-ID
    description: Wenn Sie Push-Benachrichtigungen an eine Reihe von Geräte-Token (anstelle von Nutzern) senden möchten, müssen Sie im Namen angeben, in welchem Namen bestimmte App Sie Banner sind. In diesem Fall geben Sie die entsprechende App Identifier in einem Token-Objekt an. Sie finden sie in der <strong>Developer Konsole</strong> des Braze-Dashboard.
    field: "app_id"
  - name: Externer Benutzername
    description: Ein eindeutiger Identifikator, um eine Nachricht an bestimmte Benutzer zu senden. Dieser Identifikator muss mit demselben übereinstimmen, den Sie in der Braze SDK festgelegt haben. Sie können Nutzer nur für Banner verwenden, die bereits durch den SDK oder den API identifiziert wurden. Auf Eine Anfrage sind maximal 50 externe Benutzernamen zulässig. <br>
 <br>
 Wenn Sie dieses Feld für Kampagnen auslösen, werden die Kriterien mit den Segmenten der Kampagnen verknüpft, und nur Nutzer, die in der Liste externer Nutzer-IDs und des Kampagnensegments befinden, erhalten die Nachricht.
    field: "external_user_ids"
  - name: Segment-Kennung
    description: In <code>segment_id</code> dem Segment wird angegeben, an welches die Nachricht gesendet werden soll. Ein Segmentkennung für jedes der von Ihnen erstellten Segmente finden Sie unter "Developer Console"<strong> in der </strong>Übersicht "Braze". <br>
 <br>
 Wenn Sie bei Meldungsendpunkten eine Segment-Kennung und eine Liste externer Benutzer-IDs in einer einzelnen Messaginganforderung angeben, werden die Kriterien verknüpft, und nur Benutzer, die sowohl in der Liste externer Benutzer-IDs als auch im angegebenen Segment sind, erhalten die Nachricht.
    field: "segment_id"
  - name: Kampagnenkennung
    description: Bei Messaging-Endpunkten bedeutet dies <code>campaign_id</code> , dass die API-Kampagne, unter der die Analysen für eine Nachricht nachverfolgt werden sollten. Einen Kampagnenkennung für jedes der von Ihnen erstellten Kampagnen finden Sie im <strong>Abschnitt "Developer Console"</strong> in der Übersicht "Braze". Wenn Sie im Anforderungsteil eine Kampagnenkennung angeben, müssen Sie ein <code>message_variation_id</code> einzelnes der Nachrichtenobjekte angeben, die die dargestellte Variante Ihrer Kampagne angeben. <br>
 <br>
 Bei Kampagnenauslösern wird dies auf <code>campaign_id</code> die API-ID der Kampagne schließen lassen, die ausgelöst wird. Dieses Feld ist für alle Trigger-Endpunktanforderungen erforderlich.
    field: "campaign_id"
  - name: Arbeitsbereich-Kennung
    description: In dem Arbeitsbereich, der auslösende Endpunkte auslöst, zeigt die <code>canvas_id</code> Kennung des Arbeitsbereichs an, die ausgelöst oder geplant wird. Dieses Feld ist für alle Trigger-Endpunktanforderungen erforderlich.
    field: "canvas_id"
  - name: Kennung senden
    description: Wenn die Messaging-Endpunkte angezeigt werden, bedeutet dies <code>send_id</code> , dass die Sendefunktion für eine Nachricht nachverfolgt werden muss. Sie <code>send_id</code> können damit Analysen für eine bestimmte Instanz einer Kampagne, die über den <code>sends/data_series</code> Endpunkt gesendet wird, zurückziehen. API und API Auslösen von Kampagnen, die als Broadcast gesendet werden, generiert automatisch einen Identifikator, wenn ein Send-Identifier nicht angegeben ist. <br>
 <br>
 Wenn Sie Ihre eigene <code>send_id</code>angeben möchten, müssen Sie zuerst eine über den <code>sends/id/create</code> Endpunkt erstellen. Es <code>send_id</code> muss alle ASCII-Zeichen und maximal 64 Zeichen lang sein.  Sie können eine Kennung über mehrere Send-Dateien im selben Feld verwenden, wenn Sie die Gruppenanalyse dieser Sendeten zusammen erstellen möchten. <br>
 <br>
 Beachten Sie, dass <code>send_id</code> die Sendungsverfolgung nicht für E-Mails per Mailjet gesendet werden kann. <br>
 <br>
 Die Umrechnungen der Kampagnen werden dem letzten Verfolgten zugerechnet <code>send_id</code> , den der Nutzer von dieser Kampagne erhalten hat, es sei denn, der letzte Senden des Nutzers wurde nicht nachverfolgt.
    field: "send_id"
  - name: Eigenschaften auslösen
    description: "Wenn Sie einen der Endpunkte verwenden, um eine Kampagne mit API ausgelöster Lieferung zu senden, können Sie eine Karte von Schlüsseln und Werten bereitstellen, um Ihre Nachricht anzupassen. Wenn Sie eine API Anforderung erstellen, die ein Objekt enthält <code>\"trigger_properties\"</code>, können die Werte in diesem Objekt dann im <code>api_trigger_properties</code> Namespace in der Nachrichtenvorlage referenziert werden. <br>
 <br>
 Sie können beispielsweise die Wortbacken <code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code>\" in die Nachricht einfügen, indem sie eine Anfrage \" hinzufügen<code>{{api_trigger_properties.${product_name}}}</code>."
    field: "trigger_properties"
  - name: Eigenschaften des Arbeitsbereichs
    description: "Wenn Sie einen der Endpunkte verwenden, um einen Arbeitsbereich über die API auszulösen oder zu planen, können Sie im Namespace eine Karte mit Schlüsseln und Werten bereitstellen, um nachrichten anzupassen, <code>\"canvas_entry_properties\"</code> die durch die ersten Schritte des Arbeitsbereichs gesendet werden. <br>
 <br>
 Beispielsweise könnte ein Auftrag mit <code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> den Wortbacken \"\" zu einer Nachricht hinzufügen, indem ein Hinzufüge <code>{{canvas_entry_properties.${product_name}}}</code>hinzugefügt wird."
    field: "canvas_entry_properties"
  - name: Sendung
    description: "Wenn Sie eine Nachricht an ein Segment oder eine Kampagnengruppe mit einem API Endpunkt senden, muss Braze ausdrücklich definieren, ob Ihre Nachricht einer \"großen Gruppe von Nutzern gesendet\" wird, indem Sie die API Anrufen in <code>broadcast</code> eine große Gruppe von Nutzern übertragen. Das ist, wenn Sie in Ihrem API Anruf eine API Nachricht an das gesamte Segment senden möchten, das zu den Zielvorgaben einer Kampagne oder des Arbeitsbereichs gehört <code>broadcast: true</code> . <br>
<br>
Broadcast ist ein pflichtfeld und der Standardwert von Braze, wenn eine Kampagne oder das Arbeitsbereich erstellt wird <code>broadcast: false</code>. Sie können dies nicht und <code>broadcast: true</code> eine <code>recipients</code> Liste angeben. Wenn das <code>broadcast</code> Flag auf True festgelegt ist und eine explizite Liste der Empfänger bereitgestellt wird, wird der API Endpunkt einen Fehler zurücksenden. <code>broadcast: false</code> In ähnlicher Weise wird auch eine Empfängerliste nicht angezeigt. 
    
    <br>
<br>
Verwenden Sie Vorsicht beim Setzen <code>broadcast: true</code>, da Sie dieses Flag versehentlich festlegen, dass Sie Ihre Kampagne oder das Arbeitsbereich an ein größeres als erwartet senden. Dieses <code>broadcast</code> Flag ist erforderlich, um vor einem versehentlichen Sendet an große Gruppen von Benutzern zu schützen."
    field: "broadcast"
    
---
