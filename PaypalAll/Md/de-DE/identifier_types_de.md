---
nav_title: "API Kennungstypen"
article_title: API Kennungstypen
page_order: 2.2
description: "Dieser Verweisartikel umfasst die verschiedenen Arten von API Kennungen, die in der Braze-Übersicht vorhanden sind, wo Sie sie finden und was sie verwendet werden." 
page_type: reference

---

# API Identifier-Typen

> Diese Referenzleitfaden berühren die verschiedenen Arten von API Identifiers, die im Braze-Dashboard, ihrem Zweck, wo Sie sie finden und wie sie typischerweise verwendet werden. Informationen zu REST API Keys oder App-Gruppe API Keys finden Sie in der [API Key-Übersicht]({{site.baseurl}}/api/api_key/)

Die folgenden API Identifier können verwendet werden, um auf Ihre Vorlage, das Arbeitsbereich, das Kampagnen-, Segment, das Senden oder die Karte von der externen API von Braze zuzugreifen. Alle Nachrichten müssen der UTF-8-Codierung[ folgen][1].

{% tabs %}
{% tab App Ids %}

## Der App-Identifier API Key

Der App Identifier API Schlüssel oder `app_id` ist ein Parameter, der Die Aktivität mit einer bestimmten App in Ihrer App-Gruppe zuordnen soll. Es ist eine Bezeichnung, mit der App in der App Gruppe angezeigt wird, mit der Sie interagieren. Beispielsweise wird festgestellt, dass Sie für `app_id` Ihre iOS-App, eine `app_id` für Ihre Android-App und eine `app_id` für Ihre Web-Integration haben. Bei Braze finden Sie möglicherweise, dass Sie mehrere Apps für dieselbe Plattform in den verschiedenen Plattformtypen haben, die Braze unterstützt.

#### Wo finde ich sie?

Es gibt zwei Möglichkeiten, Ihre `app_id`:

1. Sie können diese `app_id` oder den Anwendungskennung in den Einstellungen** für **Entwicklerkonsolen** **finden. Auf dieser neuen Seite unter " **Identifikation**" können Sie sehen `app_id` , was für Ihre Apps vorhanden ist.

2. Gehen Sie zu "**Einstellungen ******verwalten". **Auf der Seite unter "Einstellungen" finden Sie auf der Seite unter "Einstellungen**" einen "API Key für **APP NAME** auf **PLATTFORM**" (z.B. "API Schlüssel für Die Eiscreme auf iOS"). Dieser API Key ist Ihr Application Identifier.

#### Wofür kann es verwendet werden?

App-Identifier an Braze werden bei der Integration des SDK verwendet und werden auch verwendet, um in REST API Aufrufen einen bestimmten App zu referenzieren. Mit den `app_id` vielen Dingen wie Pull Data für ein benutzerdefiniertes Ereignis, das für ein bestimmtes App aufgetreten ist, rufen Sie de uninstall Stats, neue User Stats, DAU Stats und Session starte stats für eine bestimmte App.

Manchmal finden Sie, dass Sie nach einem `app_id` bestimmten Feld gefragt werden, aber Sie nicht mit einem App arbeiten, da es sich um ein legacy-spezifisch für eine bestimmte Plattform bezieht, können Sie dieses Feld "auslassen", indem Sie eine Zeichenfolge für diesen erforderlichen Parameter angeben.

#### Mehrere App-Identifier API Keys

Beim SDK-Einrichtung werden die häufigsten Verwendungsfall für mehrere App Identifier-API Keys getrennt mit diesen Keys für Debug und Release-Build-Varianten.
Um einfach zwischen mehreren App Identifier-API Keys in Ihren Builds zu wechseln, empfehlen wir, eine separate `braze.xml` Datei für jede relevante [Build-Variante][3] zu erstellen. Eine Build-Variante ist eine Kombination aus Build-Typ und Produktgeschmack. Beachten Sie, dass ein neues Android-Projekt standardmäßig mit `debug` und ohne Produktgeschmack konfiguriert und `release` erstellt wird.

Erstellen Sie für jede relevante Build-Variante ein neues `braze.xml` in `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Wenn die Build-Variante zusammengestellt wird, wird der neue API Schlüssel verwendet.

{% endtab %}
{% tab Template Ids %}

## Template API Identifier

Eine [Vorlage]({{site.baseurl}}/api/endpoints/templates/) API Identifier oder Template ID ist ein out-of-the-box Key von Braze für eine angegebene Vorlage im Dashboard. Die Vorlagen-IDs sind für jede Vorlage eindeutig und können über die API verwendet werden, um Vorlagen zu referenzieren. 

Vorlagen sind großartig, wenn Sich Ihre Firmenverträge mit Ihren HTML-Designs für Kampagnen erstellen. Sobald die Vorlagen erstellt wurden, verfügen Sie jetzt über eine Vorlage, die nicht speziell für eine Kampagne ist, aber für eine Reihe von Kampagnen wie einem Newsletter übernommen werden kann.

#### Wo finde ich sie?
Ihre Template-ID finden Sie eine von zwei Arten:

1. Öffnen Sie **im Dashboard Vorlagen & Medien** unter **Engagement** und wählen Sie eine bereits vorhandene Vorlage aus. Wenn die gewünschte Vorlage noch nicht vorhanden ist, erstellen Sie eine und speichern Sie sie. Unten auf der Seite "Vorlage" können Sie Ihre Vorlage API Identifier finden.<br>
<br>

2. Braze bietet eine **zusätzliche API Suche nach Kennungen, hier können Sie schnell nach bestimmten Kennungen** suchen. Sie finden sie unten auf der **Registerkarte API Einstellungen** in der **Developer Konsole** .

#### Wofür kann es verwendet werden?

- Vorlagen über API aktualisieren
- Grabinformationen zu einer bestimmten Vorlage

<br>
{% endtab %}
{% tab Canvas IDs %}

## Arbeitsbereich API-Kennung

Ein [Arbeitsbereich]({{site.baseurl}}/user_guide/engagement_tools/canvas/) API "Identifier" oder "Canvas-ID" ist ein out-of-the-box-Schlüssel von Braze für ein gegebenes Arbeitsbereich in der Übersicht. In dem Canvas-IDs sind jeweils ein Arbeitsbereich angegeben und können mithilfe des API verwendet werden, um Arbeitsbereiche zu referenzieren. 

Beachten Sie, dass, wenn sie ein Arbeitsbereich mit Varianten haben, es eine gesamtbildliche Arbeitsbereich-ID sowie eine einzelne Variante des Canvas-IDs gibt. 

#### Wo finde ich sie?
In der Übersicht finden Sie Ihre Canvas-ID. **Öffnen Sie das Arbeitsbereich** unter **"Engagement**" und wählen Sie ein bereits vorhandenes Arbeitsbereich aus. Wenn das Arbeitsbereich noch nicht vorhanden ist, erstellen Sie eines und speichern Sie es. Klicken Sie unten auf einer einzelnen Arbeitsbereichsseite auf " **Varianten analysieren"**. Ein Fenster erscheint mit dem Arbeitsbereich API Identifier unten.

#### Wofür kann es verwendet werden?
- Analyse zu einer bestimmten Nachricht nachverfolgen
- Grabe Gesamtstatistiken auf dem Canvas
- Grabdetails in einem bestimmten Arbeitsbereich
- Mit Aktuellen, um Benutzer-Level-Daten für einen "größeren Bild"-Ansatz in das Arbeitsbereich zu bringen
- Mit API Zustellung auslösen, um Statistiken zu Transaktionsnachrichten zu erfassen

<br>
{% endtab %}
{% tab Campaign IDs %}

## Kampagnen API-Kennung

Eine [Kampagne]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) API Identifier oder Kampagnen-ID ist ein out-of-box Key von Braze für eine bestimmte Kampagne im Dashboard. Kampagnen-IDs sind für jede Kampagne eindeutig und können über die API zu Referenzkampagnen verwendet werden. 

Beachten Sie, dass bei einer Kampagne, die Varianten hat, sowohl eine Gesamt-ID als auch eine einzelne Variante der Kampagnen-IDs im Rahmen der Hauptkampagne vorhanden ist. 

#### Wo finde ich sie?
Ihre Kampagnen-ID finden Sie eine von zwei Arten:

1. Öffnen Sie **im Dashboard unter** **"Engagement** " Kampagnen und wählen Sie eine bereits vorhandene Kampagne aus. Wenn die Kampagne noch nicht vorhanden ist, erstellen Sie eine und speichern Sie ihn. Unten auf der einzelnen Kampagnenseite können Sie Ihre **Kampagne API Identifier** finden.<br>
<br>

2. Braze bietet eine **zusätzliche API Suche nach Kennungen, hier können Sie schnell nach bestimmten Kennungen** suchen. Dies befindet sich unten in den **API-Einstellungen** in der **Developer-Konsole**.

#### Wofür kann es verwendet werden?
- Analyse zu einer bestimmten Nachricht nachverfolgen
- Graba aggregate Stats on Campaign Performance auf höchster Ebene
- Grabdetails zu einer bestimmten Kampagne
- Mit Aktuellen, um Benutzer-Level-Daten für einen "größeren Bild"-Ansatz für Kampagnen zu bringen
- Mit API ausgelöster Lieferung zur Erfassung von Statistiken zu Transaktionsnachrichten
- Nach [einer bestimmten Kampagne auf der ]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax)Seite "**Kampagnen**" nach dem Filter zu suchen`api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## API-Kennung segmenten

Ein [Segment]({{site.baseurl}}/user_guide/engagement_tools/segments/) API-Identifikator oder Segment-ID ist ein out-of-box-Schlüssel von Braze für ein bestimmtes Segment in der Übersicht. Segment-IDs sind für jedes Segment eindeutig und können über die API zum Referenzsegment verwendet werden. 

#### Wo finde ich sie?
Sie können Ihre Segment-ID auf eine von zwei Arten finden:

1. Öffnen Sie **im Dashboard Segmente unter **Engagement** und** wählen Sie ein vor bestehendes Segment aus. Wenn das von Ihnen gewünschte Segment noch nicht vorhanden ist, erstellen Sie eine und speichern Sie ihn. Unten auf der Seite des einzelnen Segmentes können Sie Ihr Segment API-Identifikator finden. <br>
<br>

2. Braze bietet eine **zusätzliche API Suche nach Kennungen, hier können Sie schnell nach bestimmten Kennungen** suchen. Sie finden sie unten auf der **Registerkarte API Einstellungen** in der **Developer Konsole** .

#### Wofür kann es verwendet werden?
- Informationen zu einem bestimmten Segment
- Analysen zu einem bestimmten Segment abrufen
- Ziehen Sie, wie oft ein benutzerdefiniertes Ereignis für ein bestimmtes Segment aufgezeichnet wurde
- Geben Sie eine Kampagne an Mitglieder eines Segments innerhalb der API

{% endtab %}
{% tab Card IDs %}

## Kartenkennung API

Eine Karte API Identifier oder Kartennummer ist ein out-the-box Key von Braze für eine gegebene News Feed Card in der Übersicht. Karten-IDs sind für jede [News-Feed-Karte]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) eindeutig und können über die API kartenreferenziert verwendet werden. 

#### Wo finde ich sie?
Sie können Ihre Kartennummer auf eine von zwei Arten finden:

1. Öffnen Sie **im Dashboard "News Feed** " unter **"Engagement** " und wählen Sie eine vor bestehende News-Feed aus. Wenn der von Ihnen gewünschte News-Feed noch nicht vorhanden ist, erstellen Sie einen und speichern Sie ihn. Am unteren Ende der einzelnen News-Feedseite können Sie Ihre eindeutige Karte API Identifier finden. <br>
<br>

2. Braze bietet eine **zusätzliche API Suche nach Kennungen, hier können Sie schnell nach bestimmten Kennungen** suchen. Sie finden sie unten auf der **Registerkarte API Einstellungen** in der **Developer Konsole** .

#### Wofür kann es verwendet werden?
- Relevante Informationen auf einer Karte abrufen
- Verfolgen Sie Ereignisse im Zusammenhang mit Inhaltskarten und der Interaktion

<br>
{% endtab %}
{% tab Send IDs %}

## Kennung senden

Ein "Send Identifier" oder "Senden-ID" ist ein Schlüssel, der entweder von Braze generiert oder von Ihnen erstellt wurde, um eine bestimmte Nachricht zu senden, unter der die Analysen nachverfolgt werden sollten. Mit dem send-Identifier können Sie Analysen für eine bestimmte Instanz einer Kampagne, die über den [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) Endpunkt gesendet wird, zurückziehen.

#### Wo finde ich sie?

API und API Auslösen von Kampagnen, die als Broadcast gesendet werden, generiert automatisch einen Identifikator, wenn ein Send-Identifier nicht angegeben ist. Wenn Sie Ihren eigenen Sendekennung angeben möchten, müssen Sie zuerst eine über den [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) Endpunkt erstellen. Die Kennung muss alle ASCII-Zeichen und maximal 64 Zeichen lang sein. Sie können eine Kennung über mehrere Send-Dateien im selben Feld verwenden, wenn Sie die Gruppenanalyse dieser Sendeten zusammen erstellen möchten.

#### Wofür kann es verwendet werden?
Senden und verfolgen Sie die Performance von Nachrichten systematisch ohne Erstellung von Kampagnen für jede Zahlung.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
