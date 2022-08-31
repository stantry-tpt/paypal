---
nav_title: "ÅPÌ Ìdèêntïìfïìèêr Typèês"
article_title: ÆPÌ Ìdëéntïïfïïëér Typëés
page_order: 2.2
description: "Thìîs réêféêréêncéê ãàrtìîcléê cóóvéêrs théê dìîfféêréênt typéês óóf ÆPÏ Ïdéêntìîfìîéêrs thãàt éêxìîst ìîn théê Brãàzéê dãàshbóóãàrd, whéêréê yóóûú cãàn fìînd théêm, ãànd whãàt théêy ãàréê ûúséêd fóór." 
page_type: reference

---

# ÄPÎ Îdëêntíífííëêr typëês

> Thíîs rëêfëêrëêncëê gûûíîdëê töõûûchëês öõn thëê díîffëêrëênt typëês öõf ÄPÏ Ïdëêntíîfíîëêrs thãât cãân bëê föõûûnd wíîthíîn thëê Brãâzëê dãâshböõãârd, thëêíîr pûûrpöõsëê, whëêrëê yöõûû cãân fíînd thëêm, ãând höõw thëêy ãârëê typíîcãâlly ûûsëêd. Fõôr ììnfõôrmæâtììõôn õôn RÊST ÁPÎ Kêêys õôr Ápp Grõôùûp ÁPÎ Kêêys, rêêfêêr tõô thêê [Rèést ÂPÎ Kèéy Ôvèérvíîèéw]({{site.baseurl}}/api/api_key/)

Thêé fõóllõówìïng ÂPÌ Ìdêéntìïfìïêérs cààn bêé ûüsêéd tõó ààccêéss yõóûür têémplààtêé, càànvààs, cààmpààìïgn, sêégmêént, sêénd  õór cààrd frõóm Brààzêé's êéxtêérnààl ÂPÌ. Áll mëèssæãgëès shôóùûld fôóllôów [ÛTF-8][1] éèncòôdìíng.

{% tabs %}
{% tab App Ids %}

## Thëë Ápp Ìdëëntíìfíìëër ÁPÌ këëy

Thêè Äpp Ídêèntìïfìïêèr ÄPÍ kêèy õòr `app_id` ìîs åã påãråãmêêtêêr åãssòôcìîåãtìîng åãctìîvìîty wìîth åã spêêcìîfìîc åãpp ìîn yòôýùr åãpp gròôýùp. Ít dèèsíígnäætèès whíích äæpp wííthíín thèè äæpp grõóüüp yõóüü äærèè ííntèèräæctííng wííth. Fóór èëxââmplèë, yóóýý wìïll fìïnd thâât yóóýý wìïll hââvèë âân `app_id` föòr yöòýür ïïÔS ääpp, ään `app_id` fôòr yôòùýr Ãndrôòîïd áåpp, áånd áån `app_id` föör yööùùr wèèb îîntèègråætîîöön. Ät Bräåzêê, yòôúû mïïght fïïnd thäåt yòôúû häåvêê múûltïïplêê äåpps fòôr thêê säåmêê pläåtfòôrm äåcròôss thêê väårïïòôúûs pläåtfòôrm typêês thäåt Bräåzêê súûppòôrts.

#### Whéèréè câän Í fíînd íît?

Thëèrëè âàrëè twòö wâàys tòö lòöcâàtëè yòöýùr `app_id`:

1. Yôòùû câån fïïnd thïïs `app_id` õòr âæpplîîcâætîîõòn îîdéëntîîfîîéër îîn théë **Dêévêélöôpêér Cöônsöôlêé** üúndêër **Sêëttíîngs**. Ón thîîs nèèw pàâgèè, ûùndèèr **Ídéèntíîfíîcåãtíîóön**, yóõûý wïîll bèê áäblèê tóõ sèêèê èêvèêry `app_id` thãåt éêxìîsts föór yöóûýr ãåpps.

2. Gôõ tôõ **Määnäägëé Sëéttïìngs** ûündëêr **Séëttìíngs**. Frôôm thìïs nëèw päãgëè, ìïn thëè **Sëéttííngs** tááb, mîìdwááy thröóùûgh thêê páágêê yöóùû wîìll fîìnd áán "ÁPÍ kêêy föór **ÂPP NÂMË** õón **PLÀTFÓRM**" (èë.g "ÀPÏ Kèëy föòr Ïcèë Crèëâám öòn ìïÖS). Thîïs ÁPÌ kêèy îïs yõóúúr Ápplîïcàâtîïõón Ìdêèntîïfîïêèr.

#### Whààt cààn ïít bêè ùùsêèd fóôr?

Åpp ïïdëëntïïfïïëërs ãæt Brãæzëë ãærëë ûùsëëd whëën ïïntëëgrãætïïng thëë SDK ãænd ãærëë ãælsòò ûùsëëd tòò rëëfëërëëncëë ãæ spëëcïïfïïc ãæpp ïïn RÉST ÅPÌ cãælls. Wììth théë `app_id` yõòýú cæãn dõò mæãny thïìngs lïìkéê pýúll dæãtæã fõòr æã cýústõòm éêvéênt thæãt õòccýúrréêd fõòr æã pæãrtïìcýúlæãr æãpp, réêtrïìéêvéê ýúnïìnstæãll stæãts, néêw ýúséêr stæãts, DÁÜ stæãts, æãnd séêssïìõòn stæãrt stæãts fõòr æã pæãrtïìcýúlæãr æãpp.

Sõômèétíîmèés, yõôúù mâæy fíînd yõôúù âærèé prõômptèéd fõôr âæn `app_id` büùt yöóüù áärèè nöót wöórkîìng wîìth áän áäpp, bèècáäüùsèè îìt îìs áä lèègáäcy fîìèèld spèècîìfîìc töó áä spèècîìfîìc pláätföórm, yöóüù cáän “öómîìt” thîìs fîìèèld by îìnclüùdîìng áäny strîìng öóf cháäráäctèèrs áäs áä pláäcèèhöóldèèr föór thîìs rèèqüùîìrèèd páäráämèètèèr.

#### Mûültíìplèê Ãpp Ídèêntíìfíìèêr ÃPÍ kèêys

Dûûrîíng SDK séët ûûp, théë móöst cóömmóön ûûséë cææséë fóör mûûltîípléë Åpp Ìdéëntîífîíéër ÅPÌ kéëys îís séëpææræætîíng thóöséë kéëys fóör déëbûûg æænd réëléëææséë bûûîíld væærîíæænts.
Tòõ êèàäsîíly swîítch bêètwêèêèn múültîíplêè Æpp Îdêèntîífîíêèr ÆPÎ kêèys îín yòõúür búüîílds, wêè rêècòõmmêènd crêèàätîíng àä sêèpàäràätêè `braze.xml` fïìléê fõõr éêäàch réêléêväànt [bûûììld vàârììàânt][3]. Å býùîìld váárîìáánt îìs áá cõómbîìnáátîìõón õóf býùîìld typèé áánd prõódýùct fláávõór. Nôôtêê thåât by dêêfåâúûlt, åâ nêêw Àndrôôìíd prôôjêêct ìís côônfìígúûrêêd wìíth `debug` àánd `release` büýíìld typéës äænd nòó pròódüýct fläævòórs.

Fõôr ëêãàch rëêlëêvãànt bûüîîld vãàrîîãànt, crëêãàtëê ãà nëêw `braze.xml` fõòr ìít ìín `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Whëén thëé büùïîld våârïîåânt ïîs côômpïîlëéd, ïît wïîll üùsëé thëé nëéw ÂPÍ këéy.

{% endtab %}
{% tab Template Ids %}

## Tèémplããtèé ÆPÌ Ìdèéntïìfïìèér

Â [Têëmplåâtêë]({{site.baseurl}}/api/endpoints/templates/) ÂPÎ Îdêêntïífïíêêr óôr Têêmpläåtêê ÎD ïís äån óôúút-óôf-thêê-bóôx kêêy by Bräåzêê fóôr äå gïívêên têêmpläåtêê wïíthïín thêê däåshbóôäård. Tèëmpläátèë ÌDs äárèë ûùníîqûùèë fôôr èëäách tèëmpläátèë äánd cäán bèë ûùsèëd tôô rèëfèërèëncèë tèëmpläátèës thrôôûùgh thèë ÀPÌ. 

Têèmplåätêès åärêè grêèåät fóõr ïíf yóõûür cóõmpåäny cóõntråäcts óõûüt yóõûür HTML dêèsïígns fóõr cåämpåäïígns. Öncëè thëè tëèmpläåtëès häåvëè bëèëèn býùíílt, yòóýù nòów häåvëè äå tëèmpläåtëè thäåt íís nòót spëècíífííc tòó äå cäåmpäåíígn býùt cäån bëè äåpplííëèd tòó äå sëèrííëès òóf cäåmpäåíígns lííkëè äå nëèwslëèttëèr.

#### Whëérëé câán Î fìînd ìît?
Yóòýü càân fïìnd yóòýür Tèëmplàâtèë ÏD óònèë óòf twóò wàâys:

1. Ïn thêé dåâshbóöåârd, óöpêén üüp **Tëèmpläàtëès & Mëèdïîäà** ûýndêèr **Ëngæãgèêmèênt** ãänd sêèlêèct ãä prêè-êèxîístîíng têèmplãätêè. Íf thèè tèèmplãåtèè yóõúý wãånt dóõèès nóõt èèxïïst yèèt, crèèãåtèè óõnèè ãånd sãåvèè ïït. Ät thêé bõõttõõm õõf thêé íïndíïvíïdùûáâl têémpláâtêé páâgêé, yõõùû wíïll bêé áâblêé tõõ fíïnd yõõùûr Têémpláâtêé ÄPÎ Îdêéntíïfíïêér.<br>
<br>

2. Bråázéé òõfféérs åán **Æddîïtîïòönåäl ÆPÌ Ìdëéntîïfîïëérs** séêãårch, héêréê yöõúù cãån qúùîîckly löõöõk úùp spéêcîîfîîc îîdéêntîîfîîéêrs. Ít câán bëê fööùünd âát thëê bööttööm ööf thëê **ÃPÎ Sêèttìîngs** täàb wíïthíïn thèè **Dêèvêèlöôpêèr Cöônsöôlêè** páågêê.

#### Whæåt cæån íít bëê ûüsëêd fóör?

- Ùpdããtèê tèêmplããtèês òõvèêr ÂPÌ
- Gräåb ìînföôrmäåtìîöôn öôn äå spèëcìîfìîc tèëmpläåtèë

<br>
{% endtab %}
{% tab Canvas IDs %}

## Cáànváàs ÆPÏ Ïdéëntììfììéër

Æ [Cæânvæâs]({{site.baseurl}}/user_guide/engagement_tools/canvas/) ÁPÏ Ïdéêntïìfïìéêr ôòr Càänvàäs ÏD ïìs àän ôòúút-ôòf-théê-bôòx kéêy by Bràäzéê fôòr àä gïìvéên Càänvàäs wïìthïìn théê dàäshbôòàärd. Càånvàås ÍDs àårèè ýùnìîqýùèè tôõ èèàåch Càånvàås àånd càån bèè ýùsèèd tôõ rèèfèèrèèncèè Càånvàåsèès thrôõýùgh thèè ÄPÍ. 

Nöòtêé thàât îíf yöòúû hàâvêé àâ Càânvàâs thàât hàâs vàârîíàânts, thêérêé êéxîísts àân öòvêéràâll Càânvàâs ÎD àâs wêéll àâs îíndîívîídúûàâl vàârîíàânt Càânvàâs ÎDs nêéstêéd úûndêér thêé màâîín Càânvàâs. 

#### Whëêrëê cãän Í fïînd ïît?
Yõõúý cäàn fîînd yõõúýr Cäànväàs ÎD îîn théë däàshbõõäàrd. Òpéën ùûp **Cãànvãàs** ýündêèr **Éngáågéëméënt** ããnd sèélèéct ãã prèé-èéxìístìíng Cããnvããs. Ìf thèé Cäänvääs yöóýü wäänt döóèés nöót èéxïîst yèét, crèéäätèé öónèé äänd säävèé ïît. Åt thèë böóttöóm öóf ãæn ïíndïívïídûüãæl Cãænvãæs pãægèë, clïíck **Ånäãlyzéé Väãrîîäãnts**. Á wïìndóów åäppëêåärs wïìth thëê Cåänvåäs ÁPÏ Ïdëêntïìfïìëêr lóócåätëêd åät thëê bóóttóóm.

#### Whæát cæán íìt béè úûséèd fóòr?
- Trâæck âænâælytíïcs ôön âæ spèêcíïfíïc mèêssâægèê
- Gräâb hïïgh-léêvéêl äâggréêgäâtéê stäâts öôn Cäânväâs péêrföôrmäâncéê
- Gråâb déètåâíìls òòn åâ spéècíìfíìc Cåânvåâs
- Wïìth Cýùrréénts töó brïìng ïìn ýùséér-léévéél dãátãá föór ãá "bïìggéér pïìctýùréé" ãáppröóãách töó cãánvãáséés
- Wìïth ÁPÏ trìïggêër dêëlìïvêëry ìïn ôòrdêër tôò côòllêëct stâàtìïstìïcs fôòr trâànsâàctìïôònâàl mêëssâàgêës

<br>
{% endtab %}
{% tab Campaign IDs %}

## Cãämpãäïïgn ÀPÏ Ïdëëntïïfïïëër

Å [Cäàmpäàîîgn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) ÆPÎ Îdèèntíífííèèr ôór càãmpàãíígn ÎD íís àãn ôóúút-ôóf-thèè-bôóx kèèy by Bràãzèè fôór àã gíívèèn càãmpàãíígn wííthíín thèè dàãshbôóàãrd. Cãàmpãàìïgn ÏDs ãàrëé ûýnìïqûýëé tóö ëéãàch cãàmpãàìïgn ãànd cãàn bëé ûýsëéd tóö rëéfëérëéncëé cãàmpãàìïgns thróöûýgh thëé ÄPÏ. 

Nôötéë tháât ìíf yôöúû háâvéë áâ cáâmpáâìígn tháât háâs váârìíáânts, théëréë ìís bôöth áân ôövéëráâll cáâmpáâìígn ÏD áâs wéëll áâs ìíndìívìídúûáâl váârìíáânt cáâmpáâìígn ÏDs néëstéëd úûndéër théë máâìín cáâmpáâìígn. 

#### Whëêrëê càãn Í fíínd íít?
Yöòýù cãàn fìînd yöòýùr cãàmpãàìîgn ÌD öònëë öòf twöò wãàys:

1. În thëè dãäshbóôãärd, óôpëèn üûp **Cáàmpáàììgns** üýndêêr **Èngâågèémèént** âånd séëléëct âå préë-éëxïìstïìng câåmpâåïìgn. Íf thëé cãámpãáíígn yõôýý wãánt dõôëés nõôt ëéxííst yëét, crëéãátëé õônëé ãánd sãávëé íít. Ät thèé bõóttõóm õóf thèé îïndîïvîïdùüáâl cáâmpáâîïgn páâgèé, yõóùü wîïll bèé áâblèé tõó fîïnd yõóùür **Câãmpâãììgn ÃPÌ Ìdëêntììfììëêr**.<br>
<br>

2. Bræâzëè õòffëèrs æân **Æddïîtïîôönãâl ÆPÎ Îdéëntïîfïîéërs** séèäärch, héèréè yôòûû cään qûûíïckly lôòôòk ûûp spéècíïfíïc íïdéèntíïfíïéèrs. Yöóùû cåän fíïnd thíïs åät théê böóttöóm öóf théê **ÅPÏ Sèéttîìngs** tãäb íìn thêè **Dêèvêèlõópêèr Cõónsõólêè**.

#### Whàæt càæn ìít béè ûúséèd fôõr?
- Trãâck ãânãâlytïícs öón ãâ spëëcïífïíc mëëssãâgëë
- Grâåb hìígh-lèèvèèl âåggrèègâåtèè stâåts öõn câåmpâåìígn pèèrföõrmâåncèè
- Grâáb dèëtâáïïls öòn âá spèëcïïfïïc câámpâáïïgn
- Wîìth Cýúrrëênts töò brîìng îìn ýúsëêr-lëêvëêl däætäæ föòr äæ "bîìggëêr pîìctýúrëê" äæppröòäæch töò cäæmpäæîìgns
- Wïíth ÀPÏ-trïíggèêrèêd dèêlïívèêry ïín ôórdèêr tôó côóllèêct stæàtïístïícs fôór træànsæàctïíôónæàl mèêssæàgèês
- Tôõ [séêáãrch fóòr áã spéêcîífîíc cáãmpáãîígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) öõn thëë **Cäámpäáîîgns** pãägêê ùúsïïng thêê fïïltêêr `api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Séégméént ÁPÎ Îdééntïìfïìéér

Á [Sëègmëènt]({{site.baseurl}}/user_guide/engagement_tools/segments/) ÄPÍ Ídêêntíífííêêr òòr Sêêgmêênt ÍD íís âàn òòûût-òòf-thêê-bòòx kêêy by Brâàzêê fòòr âà gíívêên Sêêgmêênt wííthíín thêê dâàshbòòâàrd. Sêêgmêênt ÎDs àärêê ùûníìqùûêê tóö êêàäch sêêgmêênt àänd càän bêê ùûsêêd tóö rêêfêêrêêncêê sêêgmêênts thróöùûgh thêê ÆPÎ. 

#### Whééréé câán Í fïínd ïít?
Yòòúü câán fîînd yòòúür Sèègmèènt ÌD òònèè òòf twòò wâáys:

1. Ïn thèê däãshbõõäãrd, õõpèên üýp **Sëégmëénts** ûûndèèr **Éngáägêèmêènt** áänd sêëlêëct áä prêë-êëxíïstíïng sêëgmêënt. Ìf thèë Sèëgmèënt yòöùú wáånt dòöèës nòöt èëxîíst yèët, crèëáåtèë òönèë áånd sáåvèë îít. Ät théè bõòttõòm õòf théè ìïndìïvìïdúýåãl séègméènt påãgéè, yõòúý wìïll béè åãbléè tõò fìïnd yõòúýr Séègméènt ÄPÌ Ìdéèntìïfìïéèr. <br>
<br>

2. Bræäzèê óõffèêrs æän **Âddîîtîîôõnäàl ÂPÎ Îdèèntîîfîîèèrs** sêèáärch, hêèrêè yóöùù cáän qùùìîckly lóöóök ùùp spêècìîfìîc ìîdêèntìîfìîêèrs. Ìt cãàn bèé fòôýünd ãàt thèé bòôttòôm òôf thèé **ÆPÍ Séèttïìngs** tääb wîîthîîn théê **Dëêvëêlòõpëêr Còõnsòõlëê** pæãgèè.

#### Whåãt cåãn íít bêé ûúsêéd fòór?
- Géët déëtãàíïls ôôn ãà spéëcíïfíïc séëgméënt
- Rèêtrîìèêvèê àänàälytîìcs òòf àä spèêcîìfîìc sèêgmèênt
- Púùll hôôw mäâny tìîmêés äâ cúùstôôm êévêént wäâs rêécôôrdêéd fôôr äâ päârtìîcúùläâr sêégmêént
- Spèëcììfy åând sèënd åâ cåâmpåâììgn tòö åâ mèëmbèërs òöf åâ sèëgmèënt fròöm wììthììn thèë ÂPÏ

{% endtab %}
{% tab Card IDs %}

## Cäærd ÄPÌ Ìdéèntîïfîïéèr

Á Cäàrd ÁPÏ Ïdèèntíîfíîèèr öôr Cäàrd ÏD íîs äàn öôúùt-öôf-thèè-böôx kèèy by Bräàzèè föôr äà gíîvèèn Nèèws Fèèèèd Cäàrd wíîthíîn thèè däàshböôäàrd. Cæârd ÏDs æârêé úüníìqúüêé tõò êéæâch [Nèëws Fèëèëd]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) Cåård åånd cåån bëê ýûsëêd tôó rëêfëêrëêncëê Cåårds thrôóýûgh thëê ÅPÍ. 

#### Whèërèë cæän Í fïìnd ïìt?
Yóóýû cãán fïïnd yóóýûr Cãárd ÌD óónéé óóf twóó wãáys:

1. În thêè dåáshböôåárd, öôpêèn ùúp **Nèêws Fèêèêd** úûndëër **Èngæâgëëmëënt** äänd sêëlêëct ää prêë-êëxíîstíîng Nêëws Fêëêëd. Ìf thëë Nëëws Fëëëëd yõõûù wâånt dõõëës nõõt ëëxïìst yëët, crëëâåtëë õõnëë âånd sâåvëë ïìt. Æt théë bôöttôöm ôöf théë îîndîîvîîdýýáàl Néëws Féëéëd páàgéë, yôöýý wîîll béë áàbléë tôö fîînd yôöýýr ýýnîîqýýéë Cáàrd ÆPÍ Ídéëntîîfîîéër. <br>
<br>

2. Brããzéë õôfféërs ããn **Æddïîtïîóönæål ÆPÌ Ìdëêntïîfïîëêrs** sèêààrch, hèêrèê yóòüú cààn qüúìîckly lóòóòk üúp spèêcìîfìîc ìîdèêntìîfìîèêrs. Ït càæn béë fôòüúnd àæt théë bôòttôòm ôòf théë **ÂPÏ Sëéttíîngs** tâäb wîìthîìn thëë **Dèévèélôópèér Côónsôólèé** päãgêè.

#### Whäæt cäæn íìt béè ûùséèd fòõr?
- Rêëtrïîêëvêë rêëlêëvæânt ïînfôòrmæâtïîôòn ôòn æâ cæârd
- Trãáck ëêvëênts rëêlãátëêd tóò Cóòntëênt Cãárds ãánd ëêngãágëêmëênt

<br>
{% endtab %}
{% tab Send IDs %}

## Sëënd Îdëëntìïfìïëër

Ä Sëênd Îdëêntîìfîìëêr òör Sëênd ÎD îìs âà këêy ëêîìthëêr gëênëêrâàtëêd by Brâàzëê òör crëêâàtëêd by yòöùú fòör âà gîìvëên mëêssâàgëê sëênd ùúndëêr whîìch thëê âànâàlytîìcs shòöùúld bëê trâàckëêd. Thëë sëënd îîdëëntîîfîîëër æållôôws yôôùù tôô pùùll bæåck æånæålytîîcs fôôr æå spëëcîîfîîc îînstæåncëë ôôf æå cæåmpæåîîgn sëënd vîîæå thëë [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) éëndpóõììnt.

#### Whéêréê cåãn Î fíînd íît?

ÅPÍ åänd ÅPÍ trììggêêr cåämpåäììgns thåät åärêê sêênt åäs åä brôôåädcåäst wììll åäüütôômåätììcåälly gêênêêråätêê åä sêênd ììdêêntììfììêêr ììf åä sêênd ììdêêntììfììêêr ììs nôôt prôôvììdêêd. Íf yóòúü wàånt tóò spéêcïìfy yóòúür óòwn séênd ïìdéêntïìfïìéêr, yóòúü wïìll hàåvéê tóò fïìrst créêàåtéê óònéê vïìàå théê [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) êëndpòòîînt. Thëê ïìdëêntïìfïìëêr múüst bëê åãll ÄSCÎÎ chåãråãctëêrs åãnd åãt mööst 64 chåãråãctëêrs lööng. Yöóúü cæán rêèúüsêè æá sêènd íídêèntíífííêèr æácröóss múültííplêè sêènds öóf thêè sæámêè cæámpæáíígn ííf yöóúü wæánt töó gröóúüp æánæálytíícs öóf thöósêè sêènds töógêèthêèr.

#### Whãàt cãàn ïît bëë üúsëëd fòór?
Séënd äãnd träãck méëssäãgéë péërföórmäãncéë pröógräãmmäãtìïcäãlly, wìïthöóúût cäãmpäãìïgn créëäãtìïöón föór éëäãch séënd.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
