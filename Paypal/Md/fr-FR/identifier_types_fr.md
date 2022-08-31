---
nav_title: "ÀPÏ Ïdêéntíîfíîêér Typêés"
article_title: ÁPÌ Ìdèéntíîfíîèér Typèés
page_order: 2.2
description: "Thîís rêëfêërêëncêë äãrtîíclêë côõvêërs thêë dîíffêërêënt typêës ôõf ÂPÍ Ídêëntîífîíêërs thäãt êëxîíst îín thêë Bräãzêë däãshbôõäãrd, whêërêë yôõüý cäãn fîínd thêëm, äãnd whäãt thêëy äãrêë üýsêëd fôõr." 
page_type: reference

---

# ÄPÍ Ídëèntïïfïïëèr typëès

> Thíïs rêèfêèrêèncêè gûúíïdêè tõòûúchêès õòn thêè díïffêèrêènt typêès õòf ÂPÌ Ìdêèntíïfíïêèrs thååt cåån bêè fõòûúnd wíïthíïn thêè Brååzêè dååshbõòåård, thêèíïr pûúrpõòsêè, whêèrêè yõòûú cåån fíïnd thêèm, åånd hõòw thêèy åårêè typíïcåålly ûúsêèd. Föór ïînföórmååtïîöón öón RÊST ÁPÎ Kêêys öór Ápp Gröóùùp ÁPÎ Kêêys, rêêfêêr töó thêê [Rëèst ÆPÎ Këèy Óvëèrvîíëèw]({{site.baseurl}}/api/api_key/)

Thèé fóòllóòwîíng ÄPÍ Ídèéntîífîíèérs cæãn bèé ûúsèéd tóò æãccèéss yóòûúr tèémplæãtèé, cæãnvæãs, cæãmpæãîígn, sèégmèént, sèénd  óòr cæãrd fróòm Bræãzèé's èéxtèérnæãl ÄPÍ. Àll mêéssäägêés shòòûúld fòòllòòw [ÜTF-8][1] êèncõôdííng.

{% tabs %}
{% tab App Ids %}

## Thëê Åpp Ídëêntìîfìîëêr ÅPÍ këêy

Thêë Äpp Ìdêëntíïfíïêër ÄPÌ kêëy ôòr `app_id` ìïs áä páäráämêêtêêr áässõõcìïáätìïng áäctìïvìïty wìïth áä spêêcìïfìïc áäpp ìïn yõõüúr áäpp grõõüúp. Ít dëêsìígnäâtëês whìích äâpp wìíthìín thëê äâpp gròòúüp yòòúü äârëê ìíntëêräâctìíng wìíth. Fôõr êèxäæmplêè, yôõúü wíîll fíînd thäæt yôõúü wíîll häævêè äæn `app_id` fôör yôöýùr íîÖS áæpp, áæn `app_id` fôör yôöùýr Åndrôöíïd áâpp, áând áân `app_id` fòõr yòõúúr wëêb ïïntëêgrâåtïïòõn. Ât Brâåzéë, yöóûú mîíght fîínd thâåt yöóûú hâåvéë mûúltîípléë âåpps föór théë sâåméë plâåtföórm âåcröóss théë vâårîíöóûús plâåtföórm typéës thâåt Brâåzéë sûúppöórts.

#### Whèérèé câæn Î fîínd îít?

Thëérëé áærëé twóô wáæys tóô lóôcáætëé yóôýûr `app_id`:

1. Yõôüù cãàn fîînd thîîs `app_id` òòr áãpplîïcáãtîïòòn îïdèéntîïfîïèér îïn thèé **Dêëvêëlôópêër Côónsôólêë** ûýndèèr **Sèèttìîngs**. Ön thîìs nëêw pàægëê, ûûndëêr **Îdëëntìîfìîcãätìîöôn**, yóóüû wíïll bëé ääblëé tóó sëéëé ëévëéry `app_id` thâãt èêxïîsts fóòr yóòùür âãpps.

2. Gòó tòó **Måänåägëè Sëèttíîngs** ýýndèér **Sêéttìíngs**. Fröôm thíîs nëëw pæâgëë, íîn thëë **Sèèttìíngs** tããb, míìdwããy thróòýúgh thëë pããgëë yóòýú wíìll fíìnd ããn "ÂPÎ këëy fóòr **ÆPP NÆMÉ** ôön **PLÄTFÓRM**" (èé.g "ÃPÍ Kèéy fõör Ícèé Crèéãám õön íìÖS). Thîís ÀPÌ kêèy îís yòöúûr Àpplîícãætîíòön Ìdêèntîífîíêèr.

#### Whäät cään îít bêè ýùsêèd fôör?

Ãpp îîdèèntîîfîîèèrs ãât Brãâzèè ãârèè úûsèèd whèèn îîntèègrãâtîîng thèè SDK ãând ãârèè ãâlsöò úûsèèd töò rèèfèèrèèncèè ãâ spèècîîfîîc ãâpp îîn RÊST ÃPÎ cãâlls. Wìîth thêê `app_id` yöôûü câån döô mâåny thïíngs lïíkëê pûüll dâåtâå föôr âå cûüstöôm ëêvëênt thâåt öôccûürrëêd föôr âå pâårtïícûülâår âåpp, rëêtrïíëêvëê ûünïínstâåll stâåts, nëêw ûüsëêr stâåts, DÀÙ stâåts, âånd sëêssïíöôn stâårt stâåts föôr âå pâårtïícûülâår âåpp.

Sôôméètíîméès, yôôùú màây fíînd yôôùú àâréè prôômptéèd fôôr àân `app_id` bûút yòöûú æàrëë nòöt wòörkïìng wïìth æàn æàpp, bëëcæàûúsëë ïìt ïìs æà lëëgæàcy fïìëëld spëëcïìfïìc tòö æà spëëcïìfïìc plæàtfòörm, yòöûú cæàn “òömïìt” thïìs fïìëëld by ïìnclûúdïìng æàny strïìng òöf chæàræàctëërs æàs æà plæàcëëhòöldëër fòör thïìs rëëqûúïìrëëd pæàræàmëëtëër.

#### Múûltíîpléê Ãpp Ídéêntíîfíîéêr ÃPÍ kéêys

Dùürííng SDK sêét ùüp, thêé môõst côõmmôõn ùüsêé cããsêé fôõr mùültííplêé Ápp Ídêéntíífííêér ÁPÍ kêéys íís sêépããrããtííng thôõsêé kêéys fôõr dêébùüg ããnd rêélêéããsêé bùüííld vããrííããnts.
Tôö êêæåsííly swíítch bêêtwêêêên mýültííplêê Ãpp Îdêêntíífííêêr ÃPÎ kêêys íín yôöýür býüíílds, wêê rêêcôömmêênd crêêæåtííng æå sêêpæåræåtêê `braze.xml` fîílèè fóòr èèáåch rèèlèèváånt [bùýììld váærììáænt][3]. Å bûüííld våârííåânt íís åâ cõõmbíínåâtííõõn õõf bûüííld typèé åând prõõdûüct flåâvõõr. Nôòtéè thäæt by déèfäæùült, äæ néèw Ãndrôòîìd prôòjéèct îìs côònfîìgùüréèd wîìth `debug` äând `release` büüïîld typéês àånd nóó próódüüct flàåvóórs.

Fôõr êëâãch rêëlêëvâãnt büýïíld vâãrïíâãnt, crêëâãtêë âã nêëw `braze.xml` fóõr íít íín `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Whëën thëë büùììld väårììäånt ììs còômpììlëëd, ììt wììll üùsëë thëë nëëw ÀPÍ këëy.

{% endtab %}
{% tab Template Ids %}

## Tèémplàætèé ÂPÌ Ìdèéntìïfìïèér

Å [Tèëmplåätèë]({{site.baseurl}}/api/endpoints/templates/) ÅPÎ Îdëêntíífííëêr óôr Tëêmplæátëê ÎD íís æán óôúút-óôf-thëê-bóôx këêy by Bræázëê fóôr æá gíívëên tëêmplæátëê wííthíín thëê dæáshbóôæárd. Tëêmplæátëê ÎDs æárëê üùnîìqüùëê fòõr ëêæách tëêmplæátëê æánd cæán bëê üùsëêd tòõ rëêfëêrëêncëê tëêmplæátëês thròõüùgh thëê ÂPÎ. 

Têëmplâätêës âärêë grêëâät fôôr ììf yôôûùr côômpâäny côôntrâäcts ôôûùt yôôûùr HTML dêësììgns fôôr câämpâäììgns. Ôncêë thêë têëmplæåtêës hæåvêë bêëêën búùîílt, yóôúù nóôw hæåvêë æå têëmplæåtêë thæåt îís nóôt spêëcîífîíc tóô æå cæåmpæåîígn búùt cæån bêë æåpplîíêëd tóô æå sêërîíêës óôf cæåmpæåîígns lîíkêë æå nêëwslêëttêër.

#### Whèêrèê cãån Ï fíïnd íït?
Yöõüû cãân fïínd yöõüûr Téêmplãâtéê ÏD öõnéê öõf twöõ wãâys:

1. Ín thëê dæàshböôæàrd, öôpëên ûüp **Tèêmplàãtèês & Mèêdìïàã** úûndêêr **Éngãàgéêméênt** àând sêèlêèct àâ prêè-êèxïïstïïng têèmplàâtêè. Ìf théë téëmplåætéë yòöýú wåænt dòöéës nòöt éëxîìst yéët, créëåætéë òönéë åænd såævéë îìt. Ät thëè böóttöóm öóf thëè ïîndïîvïîdùýãäl tëèmplãätëè pãägëè, yöóùý wïîll bëè ãäblëè töó fïînd yöóùýr Tëèmplãätëè ÄPÌ Ìdëèntïîfïîëèr.<br>
<br>

2. Bråãzèé ôôffèérs åãn **Äddìítìíòônåæl ÄPÌ Ìdëëntìífìíëërs** sëéâårch, hëérëé yóôüý câån qüýìïckly lóôóôk üýp spëécìïfìïc ìïdëéntìïfìïëérs. Ìt câän béê fòöúünd âät théê bòöttòöm òöf théê **ÀPÌ Séêttììngs** täàb wîíthîín théë **Déêvéêlóöpéêr Cóönsóöléê** päágéé.

#### Whæåt cæån íït béë ýùséëd fóör?

- Ûpdàâtêê têêmplàâtêês òôvêêr ÆPÍ
- Gràåb îínfôòrmàåtîíôòn ôòn àå spëëcîífîíc tëëmplàåtëë

<br>
{% endtab %}
{% tab Canvas IDs %}

## Cæænvææs ÂPÌ Ìdééntíîfíîéér

Æ [Cáânváâs]({{site.baseurl}}/user_guide/engagement_tools/canvas/) ÀPÌ Ìdêëntîïfîïêër ôór Càænvàæs ÌD îïs àæn ôóúút-ôóf-thêë-bôóx kêëy by Bràæzêë fôór àæ gîïvêën Càænvàæs wîïthîïn thêë dàæshbôóàærd. Cãànvãàs ÍDs ãàrëè úûnïìqúûëè tõô ëèãàch Cãànvãàs ãànd cãàn bëè úûsëèd tõô rëèfëèrëèncëè Cãànvãàsëès thrõôúûgh thëè ÁPÍ. 

Nöôtèé thäât íïf yöôüý häâvèé äâ Cäânväâs thäât häâs väâríïäânts, thèérèé èéxíïsts äân öôvèéräâll Cäânväâs ÍD äâs wèéll äâs íïndíïvíïdüýäâl väâríïäânt Cäânväâs ÍDs nèéstèéd üýndèér thèé mäâíïn Cäânväâs. 

#### Whéëréë câân Ì fìínd ìít?
Yóôýü cäãn fïìnd yóôýür Cäãnväãs ÍD ïìn théê däãshbóôäãrd. Öpëën ýûp **Cåånvåås** üýndéèr **Êngäâgëëmëënt** âând séëléëct ââ préë-éëxïïstïïng Câânvââs. Íf thèè Cåånvåås yóôüü wåånt dóôèès nóôt èèxíïst yèèt, crèèååtèè óônèè åånd sååvèè íït. Àt thèë bõöttõöm õöf áân ïîndïîvïîdûýáâl Cáânváâs páâgèë, clïîck **Ànãålyzêë Vãårìïãånts**. À wîíndõõw àâppééàârs wîíth théé Càânvàâs ÀPÏ Ïdééntîífîíéér lõõcàâtééd àât théé bõõttõõm.

#### Whææt cææn ïît bêè üùsêèd fôòr?
- Träåck äånäålytîícs óõn äå spèécîífîíc mèéssäågèé
- Gráåb hïîgh-lëëvëël áåggrëëgáåtëë stáåts öòn Cáånváås pëërföòrmáåncëë
- Grâåb dêêtâåìïls öón âå spêêcìïfìïc Câånvâås
- Wïíth Cúúrréènts tôô brïíng ïín úúséèr-léèvéèl dæætææ fôôr ææ "bïíggéèr pïíctúúréè" ææpprôôææch tôô cæænvææséès
- Wìîth ÁPÌ trìîggëër dëëlìîvëëry ìîn óòrdëër tóò cóòllëëct stààtìîstìîcs fóòr tràànsààctìîóònààl mëëssààgëës

<br>
{% endtab %}
{% tab Campaign IDs %}

## Cãàmpãàìïgn ÀPÍ Ídéëntìïfìïéër

Ã [Cààmpààíìgn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) ÄPÍ Ídëëntíìfíìëër õôr cæàmpæàíìgn ÍD íìs æàn õôùût-õôf-thëë-bõôx këëy by Bræàzëë fõôr æà gíìvëën cæàmpæàíìgn wíìthíìn thëë dæàshbõôæàrd. Cäámpäáíígn ÏDs äárèé ùûnííqùûèé tôò èéäách cäámpäáíígn äánd cäán bèé ùûsèéd tôò rèéfèérèéncèé cäámpäáíígns thrôòùûgh thèé ÃPÏ. 

Nòòtêè thãät ïïf yòòùû hãävêè ãä cãämpãäïïgn thãät hãäs vãärïïãänts, thêèrêè ïïs bòòth ãän òòvêèrãäll cãämpãäïïgn ÌD ãäs wêèll ãäs ïïndïïvïïdùûãäl vãärïïãänt cãämpãäïïgn ÌDs nêèstêèd ùûndêèr thêè mãäïïn cãämpãäïïgn. 

#### Whèèrèè cáãn Í fïìnd ïìt?
Yóõúü cãán fíínd yóõúür cãámpãáíígn ÌD óõnêè óõf twóõ wãáys:

1. Ín thëé dååshbõóåård, õópëén úüp **Cââmpââîïgns** ûündëër **Éngãágêémêént** àànd sëèlëèct àà prëè-ëèxïístïíng cààmpààïígn. Ïf théé câàmpâàîîgn yòòýû wâànt dòòéés nòòt ééxîîst yéét, crééâàtéé òònéé âànd sâàvéé îît. Æt théë bóõttóõm óõf théë ïïndïïvïïdúúåâl cåâmpåâïïgn påâgéë, yóõúú wïïll béë åâbléë tóõ fïïnd yóõúúr **Câämpâäìïgn ÁPÍ Ídéèntìïfìïéèr**.<br>
<br>

2. Brãázèè õõffèèrs ãán **Åddîítîíõónáál ÅPÌ Ìdèëntîífîíèërs** sèéæärch, hèérèé yóòüý cæän qüýîíckly lóòóòk üýp spèécîífîíc îídèéntîífîíèérs. Yôôúû cæån fíínd thíís æåt thêê bôôttôôm ôôf thêê **ÂPÎ Sééttïíngs** táäb ïïn thèë **Dèêvèêlóöpèêr Cóönsóölèê**.

#### Whäät cään ïït bêê úúsêêd fôör?
- Träàck äànäàlytíìcs òõn äà spëëcíìfíìc mëëssäàgëë
- Gråáb hìígh-lèèvèèl åággrèègåátèè ståáts öôn cåámpåáìígn pèèrföôrmåáncèè
- Grâáb dèétâáïïls õõn âá spèécïïfïïc câámpâáïïgn
- Wíïth Cüürréènts tôô bríïng íïn üüséèr-léèvéèl dáãtáã fôôr áã "bíïggéèr píïctüüréè" áãpprôôáãch tôô cáãmpáãíïgns
- Wîïth ÁPÎ-trîïggéèréèd déèlîïvéèry îïn óördéèr tóö cóölléèct stàætîïstîïcs fóör tràænsàæctîïóönàæl méèssàægéès
- Tõó [sëéáárch fòõr áá spëécîífîíc cáámpááîígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) öõn thèé **Cåámpåáîïgns** pââgëë üûsïíng thëë fïíltëër `api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Sèêgmèênt ÆPÎ Îdèêntîìfîìèêr

Æ [Sêêgmêênt]({{site.baseurl}}/user_guide/engagement_tools/segments/) ÄPÏ Ïdèêntîîfîîèêr óór Sèêgmèênt ÏD îîs âán óóúüt-óóf-thèê-bóóx kèêy by Brâázèê fóór âá gîîvèên Sèêgmèênt wîîthîîn thèê dâáshbóóâárd. Sêëgmêënt ÌDs æârêë ûúnîìqûúêë tòò êëæâch sêëgmêënt æând cæân bêë ûúsêëd tòò rêëfêërêëncêë sêëgmêënts thròòûúgh thêë ÆPÌ. 

#### Whëërëë cãàn Î fïïnd ïït?
Yôõúù cæân fìînd yôõúùr Séègméènt ÍD ôõnéè ôõf twôõ wæâys:

1. Ín thèé dâåshbóôâård, óôpèén ýüp **Séègméènts** ùùndêêr **Êngäågëëmëënt** àând sèèlèèct àâ prèè-èèxíìstíìng sèègmèènt. Ïf théé Séégméént yóôùù wæánt dóôéés nóôt ééxíîst yéét, crééæátéé óônéé æánd sæávéé íît. Àt thëê bòôttòôm òôf thëê îïndîïvîïdùýãäl sëêgmëênt pãägëê, yòôùý wîïll bëê ãäblëê tòô fîïnd yòôùýr Sëêgmëênt ÀPÎ Îdëêntîïfîïëêr. <br>
<br>

2. Bræâzèê ôöffèêrs æân **Ãddïïtïïõõnææl ÃPÏ Ïdéëntïïfïïéërs** sêëàârch, hêërêë yôôýý càân qýýíîckly lôôôôk ýýp spêëcíîfíîc íîdêëntíîfíîêërs. Ït cãån bëê föòüùnd ãåt thëê böòttöòm öòf thëê **ÃPÍ Sëêttìîngs** tãâb wííthíín thêê **Dêèvêèlõöpêèr Cõönsõölêè** pæågèê.

#### Whäät cään íít bêè ýüsêèd föõr?
- Géët déëtââìîls ôón ââ spéëcìîfìîc séëgméënt
- Rèétrííèévèé âânââlytíícs òöf ââ spèécíífííc sèégmèént
- Pýýll hóôw mâåny tïìmëés âå cýýstóôm ëévëént wâås rëécóôrdëéd fóôr âå pâårtïìcýýlâår sëégmëént
- Spéécïìfy æånd séénd æå cæåmpæåïìgn tôô æå méémbéérs ôôf æå séégméént frôôm wïìthïìn théé ÂPÎ

{% endtab %}
{% tab Card IDs %}

## Cãârd ÀPÍ Ídêéntïífïíêér

À Cåàrd ÀPÍ Ídëêntíífííëêr öör Cåàrd ÍD íís åàn ööúút-ööf-thëê-bööx këêy by Bråàzëê föör åà gíívëên Nëêws Fëêëêd Cåàrd wííthíín thëê dåàshbööåàrd. Cãärd ÎDs ãäréë ùünìîqùüéë tòõ éëãäch [Nééws Fééééd]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) Cåãrd åãnd cåãn béê ûýséêd tòö réêféêréêncéê Cåãrds thròöûýgh théê ÅPÌ. 

#### Whéêréê câän Î fîïnd îït?
Yõóûú cãän fïïnd yõóûúr Cãärd ÌD õónéè õóf twõó wãäys:

1. Ín thèè däæshbööäærd, ööpèèn üûp **Néëws Féëéëd** üýndêêr **Èngâàgéèméènt** âànd sêëlêëct âà prêë-êëxîístîíng Nêëws Fêëêëd. Íf thëé Nëéws Fëéëéd yôõýú wäánt dôõëés nôõt ëéxîìst yëét, crëéäátëé ôõnëé äánd säávëé îìt. Át thèé bóöttóöm óöf thèé ïîndïîvïîdúüäål Nèéws Fèéèéd päågèé, yóöúü wïîll bèé äåblèé tóö fïînd yóöúür úünïîqúüèé Cäård ÁPÌ Ìdèéntïîfïîèér. <br>
<br>

2. Bráäzëè óôffëèrs áän **Âddìítìíòônàål ÂPÌ Ìdêèntìífìíêèrs** sêêæârch, hêêrêê yôôýù cæân qýùíïckly lôôôôk ýùp spêêcíïfíïc íïdêêntíïfíïêêrs. Ìt cäæn bêë fõóýûnd äæt thêë bõóttõóm õóf thêë **ÅPÍ Sèéttïïngs** tãáb wîìthîìn thêé **Dêêvêêlôöpêêr Côönsôölêê** páàgëê.

#### Whàåt càån ìît bëë úùsëëd fòôr?
- Réëtríìéëvéë réëléëvæânt íìnfôórmæâtíìôón ôón æâ cæârd
- Tràãck éèvéènts réèlàãtéèd tôô Côôntéènt Càãrds àãnd éèngàãgéèméènt

<br>
{% endtab %}
{% tab Send IDs %}

## Sëënd Ìdëëntïìfïìëër

Ä Sëénd Ïdëéntíífííëér öör Sëénd ÏD íís áá këéy ëéííthëér gëénëéráátëéd by Bráázëé öör crëéáátëéd by yööúü föör áá gíívëén mëéssáágëé sëénd úündëér whíích thëé áánáálytíícs shööúüld bëé trááckëéd. Thèë sèënd íîdèëntíîfíîèër àællòóws yòóúý tòó púýll bàæck àænàælytíîcs fòór àæ spèëcíîfíîc íînstàæncèë òóf àæ càæmpàæíîgn sèënd víîàæ thèë [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) êêndpõöîïnt.

#### Whéèréè cäån Ï fîînd îît?

ÀPÎ åãnd ÀPÎ trîîggëër cåãmpåãîîgns thåãt åãrëë sëënt åãs åã brôòåãdcåãst wîîll åãüûtôòmåãtîîcåãlly gëënëëråãtëë åã sëënd îîdëëntîîfîîëër îîf åã sëënd îîdëëntîîfîîëër îîs nôòt prôòvîîdëëd. Îf yóôúù wæænt tóô spëécîïfy yóôúùr óôwn sëénd îïdëéntîïfîïëér, yóôúù wîïll hæævëé tóô fîïrst crëéæætëé óônëé vîïææ thëé [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) ééndpóôïînt. Thèé îîdèéntîîfîîèér mýýst bèé ååll ÆSCÌÌ chåårååctèérs åånd ååt môôst 64 chåårååctèérs lôông. Yõóùü cäán réëùüséë äá séënd ìïdéëntìïfìïéër äácrõóss mùültìïpléë séënds õóf théë säáméë cäámpäáìïgn ìïf yõóùü wäánt tõó grõóùüp äánäálytìïcs õóf thõóséë séënds tõógéëthéër.

#### Whäàt cäàn ìït bëé ûüsëéd föòr?
Sëènd äànd träàck mëèssäàgëè pëèrföõrmäàncëè pröõgräàmmäàtíìcäàlly, wíìthöõýùt cäàmpäàíìgn crëèäàtíìöõn föõr ëèäàch sëènd.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
