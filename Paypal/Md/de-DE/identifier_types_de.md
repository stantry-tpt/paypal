---
nav_title: "ÀPÏ Ïdéëntíífííéër Typéës"
article_title: ÃPÏ Ïdéëntïífïíéër Typéës
page_order: 2.2
description: "Thììs réëféëréëncéë àãrtììcléë cóòvéërs théë dììfféëréënt typéës óòf ÅPÏ Ïdéëntììfììéërs thàãt éëxììst ììn théë Bràãzéë dàãshbóòàãrd, whéëréë yóòýú càãn fììnd théëm, àãnd whàãt théëy àãréë ýúséëd fóòr." 
page_type: reference

---

# ÂPÏ Ïdéëntïîfïîéër typéës

> Thîís rèéfèérèéncèé gúùîídèé tòöúùchèés òön thèé dîíffèérèént typèés òöf ÆPÌ Ìdèéntîífîíèérs thãát cãán bèé fòöúùnd wîíthîín thèé Brãázèé dãáshbòöãárd, thèéîír púùrpòösèé, whèérèé yòöúù cãán fîínd thèém, ãánd hòöw thèéy ãárèé typîícãálly úùsèéd. Fôòr íínfôòrmâætííôòn ôòn RËST ÁPÏ Kèêys ôòr Ápp Grôòýüp ÁPÏ Kèêys, rèêfèêr tôò thèê [Réêst ÅPÌ Kéêy Óvéêrvïìéêw]({{site.baseurl}}/api/api_key/)

Thèê fõôllõôwîïng ÆPÏ Ïdèêntîïfîïèêrs cààn bèê ûüsèêd tõô ààccèêss yõôûür tèêmplààtèê, càànvààs, cààmpààîïgn, sèêgmèênt, sèênd  õôr cààrd frõôm Brààzèê's èêxtèêrnààl ÆPÏ. Àll mëèssàægëès shóòüýld fóòllóòw [ÛTF-8][1] êêncôödìíng.

{% tabs %}
{% tab App Ids %}

## Thèê Ápp Ídèêntíïfíïèêr ÁPÍ kèêy

Thëë Âpp Ídëëntîïfîïëër ÂPÍ këëy òôr `app_id` ïîs áå páåráåméètéèr áåssôöcïîáåtïîng áåctïîvïîty wïîth áå spéècïîfïîc áåpp ïîn yôöýùr áåpp grôöýùp. Ít dêësïìgnæåtêës whïìch æåpp wïìthïìn thêë æåpp gröóúùp yöóúù æårêë ïìntêëræåctïìng wïìth. Fôõr êêxååmplêê, yôõûý wïïll fïïnd thååt yôõûý wïïll hååvêê åån `app_id` fõòr yõòûýr íïÒS æápp, æán `app_id` fôõr yôõúúr Åndrôõììd åäpp, åänd åän `app_id` fòôr yòôûùr wëêb ïìntëêgrããtïìòôn. Åt Brãæzèë, yôõüù mììght fììnd thãæt yôõüù hãævèë müùltììplèë ãæpps fôõr thèë sãæmèë plãætfôõrm ãæcrôõss thèë vãærììôõüùs plãætfôõrm typèës thãæt Brãæzèë süùppôõrts.

#### Whëèrëè càæn Í fîìnd îìt?

Théèréè åâréè twöõ wåâys töõ löõcåâtéè yöõüúr `app_id`:

1. Yôöüû câæn fíïnd thíïs `app_id` õòr áápplìícáátìíõòn ìídééntìífìíéér ìín théé **Dêêvêêlòõpêêr Còõnsòõlêê** ûúndèër **Sëëttííngs**. Ôn thïïs nëêw päàgëê, üùndëêr **Îdêéntîîfîîcâätîîõón**, yóóýù wïíll bèê àãblèê tóó sèêèê èêvèêry `app_id` thäát èèxììsts fõõr yõõûûr äápps.

2. Gôó tôó **Mãánãágéë Séëttïíngs** ùûndëêr **Sêêttïíngs**. Frõõm thíìs nêéw päægêé, íìn thêé **Sèêttììngs** tåãb, mìídwåãy thröòûùgh thëê påãgëê yöòûù wìíll fìínd åãn "ÆPÌ këêy föòr **ÆPP NÆMË** ôón **PLÆTFÓRM**" (êë.g "ÅPÍ Kêëy fôör Ícêë Crêëåæm ôön ììÔS). Thìïs ÃPÏ kèêy ìïs yòóýúr Ãpplìïcäàtìïòón Ïdèêntìïfìïèêr.

#### Whäát cäán íít bëé üúsëéd fõôr?

Âpp íìdëëntíìfíìëërs àät Bràäzëë àärëë üüsëëd whëën íìntëëgràätíìng thëë SDK àänd àärëë àälsóö üüsëëd tóö rëëfëërëëncëë àä spëëcíìfíìc àäpp íìn RÊST ÂPÌ càälls. Wíïth thêê `app_id` yòôùý cåãn dòô måãny thíîngs líîkéè pùýll dåãtåã fòôr åã cùýstòôm éèvéènt thåãt òôccùýrréèd fòôr åã påãrtíîcùýlåãr åãpp, réètríîéèvéè ùýníînståãll ståãts, néèw ùýséèr ståãts, DÁÛ ståãts, åãnd séèssíîòôn ståãrt ståãts fòôr åã påãrtíîcùýlåãr åãpp.

Sõõmèétìïmèés, yõõûü mãæy fìïnd yõõûü ãærèé prõõmptèéd fõõr ãæn `app_id` búýt yóöúý åãréé nóöt wóörkïìng wïìth åãn åãpp, béécåãúýséé ïìt ïìs åã léégåãcy fïìééld spéécïìfïìc tóö åã spéécïìfïìc plåãtfóörm, yóöúý cåãn “óömïìt” thïìs fïìééld by ïìnclúýdïìng åãny strïìng óöf chåãråãctéérs åãs åã plåãcééhóöldéér fóör thïìs rééqúýïìrééd påãråãméétéér.

#### Mûültïîplëé Åpp Ìdëéntïîfïîëér ÅPÌ këéys

Dýúrííng SDK sèët ýúp, thèë môòst côòmmôòn ýúsèë câásèë fôòr mýúltííplèë Æpp Ídèëntíífííèër ÆPÍ kèëys íís sèëpâárâátííng thôòsèë kèëys fôòr dèëbýúg âánd rèëlèëâásèë býúííld vâárííâánts.
Tôö éêàäsïîly swïîtch béêtwéêéên múûltïîpléê Åpp Ídéêntïîfïîéêr ÅPÍ kéêys ïîn yôöúûr búûïîlds, wéê réêcôömméênd créêàätïîng àä séêpàäràätéê `braze.xml` fìílèé fòòr èéääch rèélèéväänt [bûûïîld vâàrïîâànt][3]. Å búùîíld vàærîíàænt îís àæ còòmbîínàætîíòòn òòf búùîíld typëé àænd pròòdúùct flàævòòr. Nöötèè thäãt by dèèfäãùýlt, äã nèèw Ændrööìíd prööjèèct ìís cöönfìígùýrèèd wìíth `debug` áãnd `release` büýîïld typèês äánd nõò prõòdüýct fläávõòrs.

Fóör ééãâch rééléévãânt bùüìïld vãârìïãânt, crééãâtéé ãâ nééw `braze.xml` fòõr îít îín `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Whêén thêé büýïìld våârïìåânt ïìs cõòmpïìlêéd, ïìt wïìll üýsêé thêé nêéw ÁPÏ kêéy.

{% endtab %}
{% tab Template Ids %}

## Téèmplæâtéè ÀPÎ Îdéèntìífìíéèr

Â [Têëmplâàtêë]({{site.baseurl}}/api/endpoints/templates/) ÃPÏ Ïdèèntîïfîïèèr óòr Tèèmplæätèè ÏD îïs æän óòúût-óòf-thèè-bóòx kèèy by Bræäzèè fóòr æä gîïvèèn tèèmplæätèè wîïthîïn thèè dæäshbóòæärd. Téêmplââtéê ÎDs ââréê üùníïqüùéê föör éêââch téêmplââtéê âând câân béê üùséêd töö réêféêréêncéê téêmplââtéês thrööüùgh théê ÃPÎ. 

Tëêmplåætëês åærëê grëêåæt föõr îïf yöõûùr cöõmpåæny cöõntråæcts öõûùt yöõûùr HTML dëêsîïgns föõr cåæmpåæîïgns. Õncêè thêè têèmplâátêès hâávêè bêèêèn bùýíìlt, yôôùý nôôw hâávêè âá têèmplâátêè thâát íìs nôôt spêècíìfíìc tôô âá câámpâáíìgn bùýt câán bêè âápplíìêèd tôô âá sêèríìêès ôôf câámpâáíìgns líìkêè âá nêèwslêèttêèr.

#### Whéêréê cãàn Í fìïnd ìït?
Yõòùù cäãn fîînd yõòùùr Tëémpläãtëé ÍD õònëé õòf twõò wäãys:

1. Ìn thêë dæäshbòöæärd, òöpêën üúp **Tëëmplåâtëës & Mëëdííåâ** ûûndëër **Éngââgëémëént** åànd sëêlëêct åà prëê-ëêxììstììng tëêmplåàtëê. Ïf thèè tèèmpláätèè yóòùü wáänt dóòèès nóòt èèxïïst yèèt, crèèáätèè óònèè áänd sáävèè ïït. Ât théë bòòttòòm òòf théë îïndîïvîïdúýâål téëmplâåtéë pâågéë, yòòúý wîïll béë âåbléë tòò fîïnd yòòúýr Téëmplâåtéë ÂPÍ Ídéëntîïfîïéër.<br>
<br>

2. Bràázèé ôõffèérs àán **Âddììtììóônáäl ÂPÌ Ìdêêntììfììêêrs** sëêáárch, hëêrëê yööùù cáán qùùìïckly löööök ùùp spëêcìïfìïc ìïdëêntìïfìïëêrs. Ìt cãán béé fòòúúnd ãát théé bòòttòòm òòf théé **ÂPÌ Séèttíïngs** tåæb wìîthìîn thèë **Dëèvëèlòòpëèr Còònsòòlëè** pæågëé.

#### Wháàt cáàn îît bëè ùûsëèd fóôr?

- Ùpdàâtéê téêmplàâtéês òòvéêr ÃPÎ
- Gråãb îïnföõrmåãtîïöõn öõn åã spéècîïfîïc téèmplåãtéè

<br>
{% endtab %}
{% tab Canvas IDs %}

## Cåánvåás ÃPÎ Îdêëntìîfìîêër

Ã [Cåænvåæs]({{site.baseurl}}/user_guide/engagement_tools/canvas/) ÄPÌ Ìdëéntíífííëér òòr Câánvâás ÌD íís âán òòüút-òòf-thëé-bòòx këéy by Brâázëé fòòr âá gíívëén Câánvâás wííthíín thëé dâáshbòòâárd. Cáânváâs ÏDs áârèè úùnììqúùèè tòö èèáâch Cáânváâs áând cáân bèè úùsèèd tòö rèèfèèrèèncèè Cáânváâsèès thròöúùgh thèè ÂPÏ. 

Nòòtéé thæät îïf yòòúü hæävéé æä Cæänvæäs thæät hæäs væärîïæänts, thééréé ééxîïsts æän òòvééræäll Cæänvæäs ÍD æäs wééll æäs îïndîïvîïdúüæäl væärîïæänt Cæänvæäs ÍDs nééstééd úündéér théé mæäîïn Cæänvæäs. 

#### Whëérëé câän Ï fíìnd íìt?
Yòôúû cáàn fïìnd yòôúûr Cáànváàs ÌD ïìn thëë dáàshbòôáàrd. Ôpêën úüp **Cåãnvåãs** üúndëér **Èngààgêêmêênt** åänd sèèlèèct åä prèè-èèxîìstîìng Cåänvåäs. Ïf thëè Cæânvæâs yòòúù wæânt dòòëès nòòt ëèxîìst yëèt, crëèæâtëè òònëè æând sæâvëè îìt. Ât thëë bòóttòóm òóf æãn îìndîìvîìdúýæãl Cæãnvæãs pæãgëë, clîìck **Änáàlyzëê Váàrííáànts**. À wìíndõöw ââppëéâârs wìíth thëé Câânvââs ÀPÍ Ídëéntìífìíëér lõöcââtëéd âât thëé bõöttõöm.

#### Whæát cæán íít bèê ýúsèêd fóór?
- Tráãck áãnáãlytíìcs õôn áã spèècíìfíìc mèèssáãgèè
- Græàb híìgh-lêêvêêl æàggrêêgæàtêê stæàts ôón Cæànvæàs pêêrfôórmæàncêê
- Gràãb dêétàãîïls ôôn àã spêécîïfîïc Càãnvàãs
- Wïïth Cúürrèènts tôò brïïng ïïn úüsèèr-lèèvèèl dæåtæå fôòr æå "bïïggèèr pïïctúürèè" æåpprôòæåch tôò cæånvæåsèès
- Wîíth ÄPÌ trîíggèër dèëlîívèëry îín ôòrdèër tôò côòllèëct stäàtîístîícs fôòr träànsäàctîíôònäàl mèëssäàgèës

<br>
{% endtab %}
{% tab Campaign IDs %}

## Càämpàäíígn ÃPÏ Ïdêéntíífííêér

Á [Cãàmpãàïígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) ÁPÍ Ídèêntïífïíèêr óõr càæmpàæïígn ÍD ïís àæn óõýút-óõf-thèê-bóõx kèêy by Bràæzèê fóõr àæ gïívèên càæmpàæïígn wïíthïín thèê dàæshbóõàærd. Cåâmpåâìïgn ÌDs åârëè úünìïqúüëè tôö ëèåâch cåâmpåâìïgn åând cåân bëè úüsëèd tôö rëèfëèrëèncëè cåâmpåâìïgns thrôöúügh thëè ÄPÌ. 

Nòótêé thæât îìf yòóüû hæâvêé æâ cæâmpæâîìgn thæât hæâs væârîìæânts, thêérêé îìs bòóth æân òóvêéræâll cæâmpæâîìgn ÎD æâs wêéll æâs îìndîìvîìdüûæâl væârîìæânt cæâmpæâîìgn ÎDs nêéstêéd üûndêér thêé mæâîìn cæâmpæâîìgn. 

#### Whéêréê cãàn Î fíìnd íìt?
Yóóúù cáán fìínd yóóúùr cáámpááìígn ÌD óónéë óóf twóó wááys:

1. Ìn thëë dáäshbóóáärd, óópëën úúp **Cæåmpæåíîgns** ûúndèèr **Éngããgèémèént** âànd séëléëct âà préë-éëxïïstïïng câàmpâàïïgn. Ìf thëé cãâmpãâíígn yöòûû wãânt döòëés nöòt ëéxííst yëét, crëéãâtëé öònëé ãând sãâvëé íít. Æt thêé bóòttóòm óòf thêé íìndíìvíìdûüãål cãåmpãåíìgn pãågêé, yóòûü wíìll bêé ãåblêé tóò fíìnd yóòûür **Cäämpääììgn ÅPÍ Ídêèntììfììêèr**.<br>
<br>

2. Brâæzêê óóffêêrs âæn **Åddïìtïìòönääl ÅPÏ Ïdéëntïìfïìéërs** sêêáàrch, hêêrêê yôöüù cáàn qüùìîckly lôöôök üùp spêêcìîfìîc ìîdêêntìîfìîêêrs. Yòòúü càán fîìnd thîìs àát théè bòòttòòm òòf théè **ÁPÍ Sëèttïìngs** táàb îín thèè **Dêêvêêlööpêêr Cöönsöölêê**.

#### Whæät cæän ïït béè ýüséèd fôór?
- Trãäck ãänãälytïìcs òón ãä spëècïìfïìc mëèssãägëè
- Grãàb hîîgh-léèvéèl ãàggréègãàtéè stãàts öôn cãàmpãàîîgn péèrföôrmãàncéè
- Gräãb dëëtäãíîls óôn äã spëëcíîfíîc cäãmpäãíîgn
- Wìíth Cýùrréënts tóõ brìíng ìín ýùséër-léëvéël dæætææ fóõr ææ "bìíggéër pìíctýùréë" ææppróõææch tóõ cææmpææìígns
- Wíîth ÄPÎ-tríîggêérêéd dêélíîvêéry íîn òórdêér tòó còóllêéct stæâtíîstíîcs fòór træânsæâctíîòónæâl mêéssæâgêés
- Tòô [sèéáärch fòõr áä spèécîífîíc cáämpáäîígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) óón théê **Cåæmpåæíígns** päãgéë ùüsîîng théë fîîltéër `api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Sèègmèènt ÂPÌ Ìdèèntíìfíìèèr

Æ [Sëégmëént]({{site.baseurl}}/user_guide/engagement_tools/segments/) ÄPÎ Îdéèntìífìíéèr öór Séègméènt ÎD ìís æàn öóúút-öóf-théè-böóx kéèy by Bræàzéè föór æà gìívéèn Séègméènt wìíthìín théè dæàshböóæàrd. Sèëgmèënt ÌDs ãærèë ûýníïqûýèë tõò èëãæch sèëgmèënt ãænd cãæn bèë ûýsèëd tõò rèëfèërèëncèë sèëgmèënts thrõòûýgh thèë ÁPÌ. 

#### Whëèrëè càán Ï fíínd íít?
Yõõüú cãân fíìnd yõõüúr Séëgméënt ÏD õõnéë õõf twõõ wãâys:

1. În thèé dàäshböôàärd, öôpèén ùýp **Séègméènts** ýündêêr **Èngáágëêmëênt** åænd sêêlêêct åæ prêê-êêxíîstíîng sêêgmêênt. Íf théè Séègméènt yòöùü wàãnt dòöéès nòöt éèxïîst yéèt, créèàãtéè òönéè àãnd sàãvéè ïît. Àt thêè böóttöóm öóf thêè ììndììvììdúûáâl sêègmêènt páâgêè, yöóúû wììll bêè áâblêè töó fììnd yöóúûr Sêègmêènt ÀPÍ Ídêèntììfììêèr. <br>
<br>

2. Bráâzëé öõffëérs áân **Æddíìtíìõònåál ÆPÌ Ìdéëntíìfíìéërs** sêêàárch, hêêrêê yöòýú càán qýúíîckly löòöòk ýúp spêêcíîfíîc íîdêêntíîfíîêêrs. Ìt cáæn bèê fõõúünd áæt thèê bõõttõõm õõf thèê **ÅPÎ Sëëttìîngs** tåãb wîîthîîn thëê **Dëèvëèlóópëèr Cóónsóólëè** pââgëë.

#### Whâät câän ììt bèë ùûsèëd fòõr?
- Gëêt dëêtààíïls õón àà spëêcíïfíïc sëêgmëênt
- Rèëtríïèëvèë åânåâlytíïcs òôf åâ spèëcíïfíïc sèëgmèënt
- Pûùll hóów mæåny tììmèës æå cûùstóóm èëvèënt wæås rèëcóórdèëd fóór æå pæårtììcûùlæår sèëgmèënt
- Spëëcíìfy áænd sëënd áæ cáæmpáæíìgn tòô áæ mëëmbëërs òôf áæ sëëgmëënt fròôm wíìthíìn thëë ÄPÍ

{% endtab %}
{% tab Card IDs %}

## Cæárd ÀPÍ Ídêèntíîfíîêèr

Å Cáárd ÅPÏ Ïdëêntîïfîïëêr öör Cáárd ÏD îïs áán ööûût-ööf-thëê-bööx këêy by Bráázëê föör áá gîïvëên Nëêws Fëêëêd Cáárd wîïthîïn thëê dááshbööáárd. Cäàrd ÍDs äàrêê üünìïqüüêê tóô êêäàch [Nëêws Fëêëêd]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) Cáærd áænd cáæn bëè üúsëèd töõ rëèfëèrëèncëè Cáærds thröõüúgh thëè ÂPÍ. 

#### Whêërêë càãn Î fíînd íît?
Yôóýú cåán fíìnd yôóýúr Cåárd ÍD ôónëë ôóf twôó wåáys:

1. Ín thêè dááshbóòáárd, óòpêèn ûùp **Nèéws Fèéèéd** ùýndêër **Èngãægèêmèênt** äånd sèëlèëct äå prèë-èëxîîstîîng Nèëws Fèëèëd. Íf thèè Nèèws Fèèèèd yóòùü wàánt dóòèès nóòt èèxíîst yèèt, crèèàátèè óònèè àánd sàávèè íît. Ät thèê bõóttõóm õóf thèê ííndíívíídùýâál Nèêws Fèêèêd pâágèê, yõóùý wííll bèê âáblèê tõó fíínd yõóùýr ùýnííqùýèê Câárd ÄPÏ Ïdèêntíífííèêr. <br>
<br>

2. Bráàzêê öòffêêrs áàn **Äddíítííóõnáãl ÄPÍ Ídèéntíífííèérs** séëåärch, héëréë yõóüü cåän qüüíïckly lõóõók üüp spéëcíïfíïc íïdéëntíïfíïéërs. Ït cæãn bëè fõòûýnd æãt thëè bõòttõòm õòf thëè **ÀPÍ Sééttííngs** täåb wîìthîìn thèé **Dêèvêèlöòpêèr Cöònsöòlêè** pãägêë.

#### Whæåt cæån îìt bêé ûýsêéd fòòr?
- Rëëtrìïëëvëë rëëlëëvãånt ìïnfõõrmãåtìïõõn õõn ãå cãård
- Tråãck èëvèënts rèëlåãtèëd tôô Côôntèënt Cåãrds åãnd èëngåãgèëmèënt

<br>
{% endtab %}
{% tab Send IDs %}

## Sêênd Ïdêêntîïfîïêêr

Á Sêênd Ìdêêntîìfîìêêr ôõr Sêênd ÌD îìs æâ kêêy êêîìthêêr gêênêêræâtêêd by Bræâzêê ôõr crêêæâtêêd by yôõýú fôõr æâ gîìvêên mêêssæâgêê sêênd ýúndêêr whîìch thêê æânæâlytîìcs shôõýúld bêê træâckêêd. Thëé sëénd ïïdëéntïïfïïëér æãllõòws yõòüû tõò püûll bæãck æãnæãlytïïcs fõòr æã spëécïïfïïc ïïnstæãncëé õòf æã cæãmpæãïïgn sëénd vïïæã thëé [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) èêndpõòîïnt.

#### Whëërëë cäân Ì fììnd ììt?

ÁPÎ äànd ÁPÎ trîíggéér cäàmpäàîígns thäàt äàréé séént äàs äà bróöäàdcäàst wîíll äàüýtóömäàtîícäàlly géénééräàtéé äà séénd îídééntîífîíéér îíf äà séénd îídééntîífîíéér îís nóöt próövîídééd. Îf yóõúý wâánt tóõ spëêcìîfy yóõúýr óõwn sëênd ìîdëêntìîfìîëêr, yóõúý wìîll hâávëê tóõ fìîrst crëêâátëê óõnëê vìîâá thëê [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) èëndpòöîìnt. Thêê ìîdêêntìîfìîêêr mûûst bêê áãll ÂSCÎÎ cháãráãctêêrs áãnd áãt môóst 64 cháãráãctêêrs lôóng. Yòöýú cåán rèèýúsèè åá sèènd íïdèèntíïfíïèèr åácròöss mýúltíïplèè sèènds òöf thèè såámèè cåámpåáíïgn íïf yòöýú wåánt tòö gròöýúp åánåálytíïcs òöf thòösèè sèènds tòögèèthèèr.

#### Whäãt cäãn îït béé ýýsééd föör?
Séénd âànd trâàck mééssâàgéé péérfôôrmâàncéé prôôgrâàmmâàtïìcâàlly, wïìthôôùüt câàmpâàïìgn crééâàtïìôôn fôôr ééâàch séénd.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
