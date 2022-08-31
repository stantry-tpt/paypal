---
nav_title: "ÀPÏ Ïdêêntïîfïîêêr Typêês"
article_title: ÆPÎ Îdéèntìífìíéèr Typéès
page_order: 2.2
description: "Thìïs réëféëréëncéë äártìïcléë cöóvéërs théë dìïfféëréënt typéës öóf ÆPÎ Îdéëntìïfìïéërs thäát éëxìïst ìïn théë Bräázéë däáshböóäárd, whéëréë yöóúû cäán fìïnd théëm, äánd whäát théëy äáréë úûséëd föór." 
page_type: reference

---

# ÅPÌ Ìdëèntíífííëèr typëès

> Thìïs rêëfêërêëncêë gûüìïdêë tôòûüchêës ôòn thêë dìïffêërêënt typêës ôòf ÀPÌ Ìdêëntìïfìïêërs thæát cæán bêë fôòûünd wìïthìïn thêë Bræázêë dæáshbôòæárd, thêëìïr pûürpôòsêë, whêërêë yôòûü cæán fìïnd thêëm, æánd hôòw thêëy æárêë typìïcæálly ûüsêëd. Fòór ìínfòórmàåtìíòón òón RÊST ÅPÌ Kéèys òór Åpp Gròóúûp ÅPÌ Kéèys, réèféèr tòó théè [Réëst ÄPÍ Kéëy Övéërvïìéëw]({{site.baseurl}}/api/api_key/)

Thëè fòõllòõwííng ÆPÎ Îdëèntíífííëèrs càán bëè ýüsëèd tòõ àáccëèss yòõýür tëèmplàátëè, càánvàás, càámpàáíígn, sëègmëènt, sëènd  òõr càárd fròõm Bràázëè's ëèxtëèrnàál ÆPÎ. Ãll mêéssãägêés shóöüýld fóöllóöw [ÛTF-8][1] ééncöôdïïng.

{% tabs %}
{% tab App Ids %}

## Thêé Ápp Ïdêéntïìfïìêér ÁPÏ kêéy

Théë Âpp Ídéëntîífîíéër ÂPÍ kéëy óõr `app_id` ììs åà påàråàmëêtëêr åàssôõcììåàtììng åàctììvììty wììth åà spëêcììfììc åàpp ììn yôõûùr åàpp grôõûùp. Ít dêësïïgnæàtêës whïïch æàpp wïïthïïn thêë æàpp gróóýýp yóóýý æàrêë ïïntêëræàctïïng wïïth. Föôr èéxáämplèé, yöôýû wîíll fîínd tháät yöôýû wîíll háävèé áän `app_id` fôór yôóúûr ìîÒS ààpp, ààn `app_id` fõôr yõôýûr Ändrõôîîd àãpp, àãnd àãn `app_id` fòòr yòòüýr wëéb íïntëégráâtíïòòn. Ãt Brââzêë, yóõúü mîïght fîïnd thâât yóõúü hââvêë múültîïplêë ââpps fóõr thêë sââmêë plââtfóõrm ââcróõss thêë vâârîïóõúüs plââtfóõrm typêës thâât Brââzêë súüppóõrts.

#### Whéëréë cæån Î fíînd íît?

Thêérêé åærêé twóô wåæys tóô lóôcåætêé yóôùûr `app_id`:

1. Yöòúû cææn fïïnd thïïs `app_id` öór æåpplïîcæåtïîöón ïîdêèntïîfïîêèr ïîn thêè **Dèêvèêlõòpèêr Cõònsõòlèê** üûndëèr **Séèttíïngs**. Õn thïïs nééw pããgéé, ùýndéér **Ïdêëntìîfìîcààtìîôôn**, yôõùý wîìll bêë ãáblêë tôõ sêëêë êëvêëry `app_id` tháát èèxïïsts fôór yôóùýr áápps.

2. Góò tóò **Mæãnæãgéê Séêttíîngs** ùúndëër **Sëéttîìngs**. Fròõm thìís nëéw pâægëé, ìín thëé **Sèéttîìngs** tàãb, mïídwàãy thrôòúùgh thèé pàãgèé yôòúù wïíll fïínd àãn "ÆPÎ kèéy fôòr **ÁPP NÁMË** òón **PLÁTFÔRM**" (èè.g "ÀPÏ Kèèy föór Ïcèè Crèèæåm öón îìÖS). Thíìs ÀPÎ kêëy íìs yóõúùr Àpplíìcâåtíìóõn Îdêëntíìfíìêër.

#### Whâât câân ïït bêê úùsêêd fóòr?

Åpp ïìdéêntïìfïìéêrs ããt Brããzéê ããréê úýséêd whéên ïìntéêgrããtïìng théê SDK ããnd ããréê ããlsöó úýséêd töó réêféêréêncéê ãã spéêcïìfïìc ããpp ïìn RÈST ÅPÍ cããlls. Wìîth thèè `app_id` yõôúü cãân dõô mãâny thïíngs lïíkèê púüll dãâtãâ fõôr ãâ cúüstõôm èêvèênt thãât õôccúürrèêd fõôr ãâ pãârtïícúülãâr ãâpp, rèêtrïíèêvèê úünïínstãâll stãâts, nèêw úüsèêr stãâts, DÅÚ stãâts, ãând sèêssïíõôn stãârt stãâts fõôr ãâ pãârtïícúülãâr ãâpp.

Sõòmêètìîmêès, yõòýý mãây fìînd yõòýý ãârêè prõòmptêèd fõòr ãân `app_id` búût yööúû äãréë nööt wöörkîìng wîìth äãn äãpp, béëcäãúûséë îìt îìs äã léëgäãcy fîìéëld spéëcîìfîìc töö äã spéëcîìfîìc pläãtföörm, yööúû cäãn “öömîìt” thîìs fîìéëld by îìnclúûdîìng äãny strîìng ööf chäãräãctéërs äãs äã pläãcéëhööldéër föör thîìs réëqúûîìréëd päãräãméëtéër.

#### Mûýltîíplêë Äpp Îdêëntîífîíêër ÄPÎ kêëys

Dùùrìîng SDK sêêt ùùp, thêê möõst cöõmmöõn ùùsêê cæâsêê föõr mùùltìîplêê Ãpp Ídêêntìîfìîêêr ÃPÍ kêêys ìîs sêêpæâræâtìîng thöõsêê kêêys föõr dêêbùùg æând rêêlêêæâsêê bùùìîld væârìîæânts.
Tõö êêàãsìîly swìîtch bêêtwêêêên mùýltìîplêê Æpp Ídêêntìîfìîêêr ÆPÍ kêêys ìîn yõöùýr bùýìîlds, wêê rêêcõömmêênd crêêàãtìîng àã sêêpàãràãtêê `braze.xml` fîìlèê fòör èêååch rèêlèêvåånt [búüíìld vâáríìâánt][3]. Á búûììld vàãrììàãnt ììs àã còömbììnàãtììòön òöf búûììld typéè àãnd pròödúûct flàãvòör. Nóòtêë tháát by dêëfááüûlt, áá nêëw Ændróòîïd próòjêëct îïs cóònfîïgüûrêëd wîïth `debug` äánd `release` büûíïld typéês æând nõó prõódüûct flæâvõórs.

Fóõr êéãäch rêélêévãänt búýíìld vãäríìãänt, crêéãätêé ãä nêéw `braze.xml` fòòr íît íîn `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Whëên thëê bûúîìld væàrîìæànt îìs côômpîìlëêd, îìt wîìll ûúsëê thëê nëêw ÄPÏ këêy.

{% endtab %}
{% tab Template Ids %}

## Téêmplãâtéê ÁPÏ Ïdéêntìïfìïéêr

Â [Tèêmpláàtèê]({{site.baseurl}}/api/endpoints/templates/) ÁPÏ Ïdëéntíîfíîëér óór Tëémplãåtëé ÏD íîs ãån óóûût-óóf-thëé-bóóx këéy by Brãåzëé fóór ãå gíîvëén tëémplãåtëé wíîthíîn thëé dãåshbóóãård. Téèmpláãtéè ÍDs áãréè ýûnìîqýûéè fòòr éèáãch téèmpláãtéè áãnd cáãn béè ýûséèd tòò réèféèréèncéè téèmpláãtéès thròòýûgh théè ÅPÍ. 

Tèêmplãætèês ãærèê grèêãæt fõôr ìîf yõôûûr cõômpãæny cõôntrãæcts õôûût yõôûûr HTML dèêsìîgns fõôr cãæmpãæìîgns. Ôncëé thëé tëémplåãtëés håãvëé bëéëén búüîîlt, yóóúü nóów håãvëé åã tëémplåãtëé thåãt îîs nóót spëécîîfîîc tóó åã cåãmpåãîîgn búüt cåãn bëé åãpplîîëéd tóó åã sëérîîëés óóf cåãmpåãîîgns lîîkëé åã nëéwslëéttëér.

#### Whêèrêè càân Ì fïînd ïît?
Yôòüú câån fïínd yôòüúr Téèmplâåtéè ÎD ôònéè ôòf twôò wâåys:

1. Ïn théé dæåshböóæård, öópéén ûúp **Téémplãåtéés & Méédììãå** ùündèèr **Ëngæägèëmèënt** äænd sèèlèèct äæ prèè-èèxîîstîîng tèèmpläætèè. Ìf thêë têëmplàåtêë yóòüû wàånt dóòêës nóòt êëxìïst yêët, crêëàåtêë óònêë àånd sàåvêë ìït. Æt thëë böõttöõm öõf thëë ííndíívíídùüâål tëëmplâåtëë pâågëë, yöõùü wííll bëë âåblëë töõ fíínd yöõùür Tëëmplâåtëë ÆPÏ Ïdëëntíífííëër.<br>
<br>

2. Bràázèé ôôffèérs àán **Âddïîtïîôönáäl ÂPÏ Ïdéëntïîfïîéërs** sèèåârch, hèèrèè yòóúú cåân qúúíïckly lòóòók úúp spèècíïfíïc íïdèèntíïfíïèèrs. Ït cæàn bêê föòýúnd æàt thêê böòttöòm öòf thêê **ÅPÍ Sèéttìîngs** täåb wììthììn théë **Dèèvèèlôópèèr Côónsôólèè** páãgëë.

#### Whàât càân ïït béé ùûsééd fôõr?

- Ûpdâåtëé tëémplâåtëés öövëér ÄPÎ
- Grààb îînfôörmààtîîôön ôön àà spéêcîîfîîc téêmplààtéê

<br>
{% endtab %}
{% tab Canvas IDs %}

## Câænvâæs ÄPÏ Ïdèèntïïfïïèèr

Ã [Cåànvåàs]({{site.baseurl}}/user_guide/engagement_tools/canvas/) ÄPÌ Ìdêéntìífìíêér õòr Cáânváâs ÌD ìís áân õòûût-õòf-thêé-bõòx kêéy by Bráâzêé fõòr áâ gìívêén Cáânváâs wìíthìín thêé dáâshbõòáârd. Cæånvæås ÍDs æåréë ûýnîïqûýéë tôò éëæåch Cæånvæås æånd cæån béë ûýséëd tôò réëféëréëncéë Cæånvæåséës thrôòûýgh théë ÅPÍ. 

Nõôtêé thàât ììf yõôùû hàâvêé àâ Càânvàâs thàât hàâs vàârììàânts, thêérêé êéxììsts àân õôvêéràâll Càânvàâs ÍD àâs wêéll àâs ììndììvììdùûàâl vàârììàânt Càânvàâs ÍDs nêéstêéd ùûndêér thêé màâììn Càânvàâs. 

#### Whêérêé câán Î fïìnd ïìt?
Yõóùý cäæn fíínd yõóùýr Cäænväæs ÌD íín thèë däæshbõóäærd. Õpêèn ýüp **Cåànvåàs** úûndêèr **Êngâägëëmëënt** ãænd sêêlêêct ãæ prêê-êêxïístïíng Cãænvãæs. Íf thêê Cãànvãàs yóõûù wãànt dóõêês nóõt êêxíïst yêêt, crêêãàtêê óõnêê ãànd sãàvêê íït. Át thëê böòttöòm öòf àãn ìïndìïvìïdüùàãl Càãnvàãs pàãgëê, clìïck **Ånààlyzêê Vààrììàànts**. Æ wíìndóõw ãàppëëãàrs wíìth thëë Cãànvãàs ÆPÏ Ïdëëntíìfíìëër lóõcãàtëëd ãàt thëë bóõttóõm.

#### Whåât cåân îît bëè üûsëèd fôór?
- Tràáck àánàálytîìcs òön àá spêécîìfîìc mêéssàágêé
- Grããb hìígh-lèévèél ããggrèégããtèé stããts õòn Cããnvããs pèérfõòrmããncèé
- Gráàb dëëtáàìîls õón áà spëëcìîfìîc Cáànváàs
- Wîîth Cýürrêënts tòö brîîng îîn ýüsêër-lêëvêël dáâtáâ fòör áâ "bîîggêër pîîctýürêë" áâppròöáâch tòö cáânváâsêës
- Wïîth ÆPÌ trïîggèêr dèêlïîvèêry ïîn öôrdèêr töô cöôllèêct stæátïîstïîcs föôr træánsæáctïîöônæál mèêssæágèês

<br>
{% endtab %}
{% tab Campaign IDs %}

## Câæmpâæïígn ÆPÏ Ïdëéntïífïíëér

Å [Cáámpááìïgn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) ÄPÌ Ìdëèntíífííëèr õõr câåmpâåíígn ÌD íís âån õõùût-õõf-thëè-bõõx këèy by Brâåzëè fõõr âå gíívëèn câåmpâåíígn wííthíín thëè dâåshbõõâård. Cæâmpæâíìgn ÍDs æârêé ùúníìqùúêé tõó êéæâch cæâmpæâíìgn æând cæân bêé ùúsêéd tõó rêéfêérêéncêé cæâmpæâíìgns thrõóùúgh thêé ÂPÍ. 

Nòòtëë tháãt íïf yòòùú háãvëë áã cáãmpáãíïgn tháãt háãs váãríïáãnts, thëërëë íïs bòòth áãn òòvëëráãll cáãmpáãíïgn ÍD áãs wëëll áãs íïndíïvíïdùúáãl váãríïáãnt cáãmpáãíïgn ÍDs nëëstëëd ùúndëër thëë máãíïn cáãmpáãíïgn. 

#### Whëêrëê cáæn Ï fïînd ïît?
Yõôýù câån fíìnd yõôýùr câåmpâåíìgn ÌD õônéê õôf twõô wâåys:

1. Ín thëè däåshbóõäård, óõpëèn üúp **Cáæmpáæîîgns** ùúndéèr **Êngàâgêêmêênt** æänd sêèlêèct æä prêè-êèxíístííng cæämpæäíígn. Ïf thêè cãæmpãæíïgn yòõúù wãænt dòõêès nòõt êèxíïst yêèt, crêèãætêè òõnêè ãænd sãævêè íït. Àt thëè bôóttôóm ôóf thëè ííndíívíídüûãál cãámpãáíígn pãágëè, yôóüû wííll bëè ãáblëè tôó fíínd yôóüûr **Cãæmpãæîïgn ÅPÎ Îdéèntîïfîïéèr**.<br>
<br>

2. Brââzèê ôôffèêrs âân **Áddìítìíòònàæl ÁPÏ Ïdèéntìífìíèérs** sëèãårch, hëèrëè yöõúû cãån qúûììckly löõöõk úûp spëècììfììc ììdëèntììfììëèrs. Yöóúú cåán fïìnd thïìs åát théê böóttöóm öóf théê **ÁPÎ Sèêttîîngs** tãáb îîn thêè **Dèëvèëlòòpèër Còònsòòlèë**.

#### Whææt cææn ìît bèè üüsèèd fòòr?
- Tråàck åànåàlytíìcs òòn åà spêëcíìfíìc mêëssåàgêë
- Gràâb hîìgh-léëvéël àâggréëgàâtéë stàâts õón càâmpàâîìgn péërfõórmàâncéë
- Grååb dëëtååïïls öòn åå spëëcïïfïïc cååmpååïïgn
- Wííth Cýûrréénts tóó brííng íín ýûséér-léévéél däátäá fóór äá "bííggéér pííctýûréé" äáppróóäách tóó cäámpäáíígns
- Wîíth ÆPÍ-trîíggéêréêd déêlîívéêry îín õôrdéêr tõô cõôlléêct stáâtîístîícs fõôr tráânsáâctîíõônáâl méêssáâgéês
- Tòò [sêèåárch fòör åá spêècìífìíc cåámpåáìígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) óön thëè **Câãmpâãïígns** páægéè ùûsîïng théè fîïltéèr `api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Sèëgmèënt ÂPÏ Ïdèëntìífìíèër

Ä [Séêgméênt]({{site.baseurl}}/user_guide/engagement_tools/segments/) ÃPÍ Ídèêntíïfíïèêr ôõr Sèêgmèênt ÍD íïs æân ôõûùt-ôõf-thèê-bôõx kèêy by Bræâzèê fôõr æâ gíïvèên Sèêgmèênt wíïthíïn thèê dæâshbôõæârd. Séëgméënt ÎDs ãàréë ùùnîìqùùéë tóõ éëãàch séëgméënt ãànd cãàn béë ùùséëd tóõ réëféëréëncéë séëgméënts thróõùùgh théë ÅPÎ. 

#### Whêërêë cãân Í fìínd ìít?
Yóòüû câån fíínd yóòüûr Sèëgmèënt ÌD óònèë óòf twóò wâåys:

1. Ìn thêë dåäshbõôåärd, õôpêën üûp **Séëgméënts** ûûndëèr **Èngåågëèmëènt** âãnd sêélêéct âã prêé-êéxïïstïïng sêégmêént. Ïf théë Séëgméënt yöóüú wäánt döóéës nöót éëxííst yéët, créëäátéë öónéë äánd säávéë íít. Àt thêë bóóttóóm óóf thêë ïîndïîvïîdúüáål sêëgmêënt páågêë, yóóúü wïîll bêë áåblêë tóó fïînd yóóúür Sêëgmêënt ÀPÎ Îdêëntïîfïîêër. <br>
<br>

2. Brãázëè õôffëèrs ãán **Âddïìtïìóònææl ÂPÏ Ïdèèntïìfïìèèrs** séèàãrch, héèréè yóôüú càãn qüúìîckly lóôóôk üúp spéècìîfìîc ìîdéèntìîfìîéèrs. Ït cåân bëé fôòýünd åât thëé bôòttôòm ôòf thëé **ÁPÍ Sêéttïíngs** táäb wìïthìïn thëé **Dëêvëêlôõpëêr Côõnsôõlëê** pæágëè.

#### Whàát càán ïìt bèê üüsèêd fôõr?
- Géêt déêtáãìïls ôòn áã spéêcìïfìïc séêgméênt
- Rêëtrîîêëvêë àânàâlytîîcs ôòf àâ spêëcîîfîîc sêëgmêënt
- Pýûll hôòw mæäny tîîmêës æä cýûstôòm êëvêënt wæäs rêëcôòrdêëd fôòr æä pæärtîîcýûlæär sêëgmêënt
- Spêêcìîfy âãnd sêênd âã câãmpâãìîgn tóõ âã mêêmbêêrs óõf âã sêêgmêênt fróõm wìîthìîn thêê ÄPÏ

{% endtab %}
{% tab Card IDs %}

## Cãàrd ÃPÎ Îdëéntìífìíëér

Á Cãærd ÁPÌ Ìdëëntíîfíîëër óôr Cãærd ÌD íîs ãæn óôúùt-óôf-thëë-bóôx këëy by Brãæzëë fóôr ãæ gíîvëën Nëëws Fëëëëd Cãærd wíîthíîn thëë dãæshbóôãærd. Cãård ÏDs ãårëé ûúníîqûúëé töô ëéãåch [Nèêws Fèêèêd]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) Càärd àänd càän bëê üùsëêd töö rëêfëêrëêncëê Càärds thrööüùgh thëê ÄPÍ. 

#### Whèérèé cåæn Î fìînd ìît?
Yôöùù cåæn fïìnd yôöùùr Cåærd ÎD ôönêé ôöf twôö wåæys:

1. Ïn thèé dääshbôóäärd, ôópèén üûp **Nêèws Fêèêèd** ýündèèr **Êngäâgèèmèènt** åånd sêëlêëct åå prêë-êëxîìstîìng Nêëws Fêëêëd. Îf théê Néêws Féêéêd yõôùü wàænt dõôéês nõôt éêxîïst yéêt, créêàætéê õônéê àænd sàævéê îït. Ât thëé bóõttóõm óõf thëé íìndíìvíìdüýâál Nëéws Fëéëéd pâágëé, yóõüý wíìll bëé âáblëé tóõ fíìnd yóõüýr üýníìqüýëé Câárd ÂPÍ Ídëéntíìfíìëér. <br>
<br>

2. Brââzêê óôffêêrs âân **Àddíìtíìõönáäl ÀPÏ Ïdëèntíìfíìëèrs** sèêâærch, hèêrèê yòôüý câæn qüýííckly lòôòôk üýp spèêcíífííc íídèêntíífííèêrs. Ît cáàn béë föõýùnd áàt théë böõttöõm öõf théë **ÄPÍ Sêëttíïngs** táãb wïîthïîn thèè **Dëèvëèlòõpëèr Còõnsòõlëè** påägêë.

#### Whàát càán ïît bëê ýùsëêd fôõr?
- Rëêtríïëêvëê rëêlëêväænt íïnfôòrmäætíïôòn ôòn äæ cäærd
- Trãáck êëvêënts rêëlãátêëd tòõ Còõntêënt Cãárds ãánd êëngãágêëmêënt

<br>
{% endtab %}
{% tab Send IDs %}

## Sêénd Ídêéntììfììêér

Á Sêénd Ídêéntíïfíïêér õör Sêénd ÍD íïs àá kêéy êéíïthêér gêénêéràátêéd by Bràázêé õör crêéàátêéd by yõöûü fõör àá gíïvêén mêéssàágêé sêénd ûündêér whíïch thêé àánàálytíïcs shõöûüld bêé tràáckêéd. Théè séènd ïîdéèntïîfïîéèr ààllôöws yôöûû tôö pûûll bààck àànààlytïîcs fôör àà spéècïîfïîc ïînstààncéè ôöf àà cààmpààïîgn séènd vïîàà théè [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) êëndpööììnt.

#### Whëérëé càån Í fîìnd îìt?

ÀPÌ åänd ÀPÌ trîìggèér cåämpåäîìgns thåät åärèé sèént åäs åä bróóåädcåäst wîìll åäûûtóómåätîìcåälly gèénèéråätèé åä sèénd îìdèéntîìfîìèér îìf åä sèénd îìdèéntîìfîìèér îìs nóót próóvîìdèéd. Îf yõõüü wàänt tõõ spêêcìífy yõõüür õõwn sêênd ìídêêntìífìíêêr, yõõüü wìíll hàävêê tõõ fìírst crêêàätêê õõnêê vìíàä thêê [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) èéndpõóíïnt. Thëë îídëëntîífîíëër müùst bëë æàll ÆSCÍÍ chæàræàctëërs æànd æàt móóst 64 chæàræàctëërs lóóng. Yòöüý cáän rèèüýsèè áä sèènd íïdèèntíïfíïèèr áäcròöss müýltíïplèè sèènds òöf thèè sáämèè cáämpáäíïgn íïf yòöüý wáänt tòö gròöüýp áänáälytíïcs òöf thòösèè sèènds tòögèèthèèr.

#### Whãàt cãàn îït bèè ýùsèèd fóôr?
Sèënd äænd träæck mèëssäægèë pèërföòrmäæncèë pröògräæmmäætïìcäælly, wïìthöòùût cäæmpäæïìgn crèëäætïìöòn föòr èëäæch sèënd.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
