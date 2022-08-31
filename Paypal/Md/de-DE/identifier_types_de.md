---
nav_title: "ÅPÎ Îdêêntîïfîïêêr Typêês"
article_title: ÆPÍ Ídêéntìïfìïêér Typêés
page_order: 2.2
description: "Thíîs rêèfêèrêèncêè æærtíîclêè côõvêèrs thêè díîffêèrêènt typêès ôõf ÃPÍ Ídêèntíîfíîêèrs thææt êèxíîst íîn thêè Brææzêè dææshbôõæærd, whêèrêè yôõùý cææn fíînd thêèm, æænd whææt thêèy æærêè ùýsêèd fôõr." 
page_type: reference

---

# ÁPÌ Ìdëëntïífïíëër typëës

> Thíìs rëëfëërëëncëë gýùíìdëë tóöýùchëës óön thëë díìffëërëënt typëës óöf ÄPÌ Ìdëëntíìfíìëërs thäät cään bëë fóöýùnd wíìthíìn thëë Brääzëë dääshbóöäärd, thëëíìr pýùrpóösëë, whëërëë yóöýù cään fíìnd thëëm, äänd hóöw thëëy äärëë typíìcäälly ýùsëëd. Föõr íìnföõrmäátíìöõn öõn RÉST ÀPÌ Kèêys öõr Àpp Gröõùüp ÀPÌ Kèêys, rèêfèêr töõ thèê [Rêëst ÅPÍ Kêëy Övêërvîíêëw]({{site.baseurl}}/api/api_key/)

Théê fôóllôówíìng ÅPÏ Ïdéêntíìfíìéêrs câän béê úùséêd tôó âäccéêss yôóúùr téêmplâätéê, câänvâäs, câämpâäíìgn, séêgméênt, séênd  ôór câärd frôóm Brâäzéê's éêxtéêrnâäl ÅPÏ. Ãll mêêssâægêês shòöüûld fòöllòöw [ÙTF-8][1] ëëncöòdïíng.

{% tabs %}
{% tab App Ids %}

## Théé Àpp Îdééntìîfìîéér ÀPÎ kééy

Thêë Ápp Ídêëntíìfíìêër ÁPÍ kêëy óör `app_id` ìîs ãà pãàrãàméëtéër ãàssóõcìîãàtìîng ãàctìîvìîty wìîth ãà spéëcìîfìîc ãàpp ìîn yóõýúr ãàpp gróõýúp. Ît dëêsíígnãåtëês whíích ãåpp wííthíín thëê ãåpp grôóüûp yôóüû ãårëê ííntëêrãåctííng wííth. Fòör ééxåæmpléé, yòöýû wíîll fíînd thåæt yòöýû wíîll håævéé åæn `app_id` fòör yòöýýr íïÓS áàpp, áàn `app_id` fòör yòöùùr Åndròöïìd áàpp, áànd áàn `app_id` fõör yõöúúr wéèb íìntéègråâtíìõön. Ãt Brààzêê, yõôýù mïìght fïìnd thààt yõôýù hààvêê mýùltïìplêê ààpps fõôr thêê sààmêê plààtfõôrm ààcrõôss thêê vààrïìõôýùs plààtfõôrm typêês thààt Brààzêê sýùppõôrts.

#### Whëérëé cäãn Ì fìînd ìît?

Thééréé ãåréé twòô wãåys tòô lòôcãåtéé yòôûûr `app_id`:

1. Yóõúû càán fíînd thíîs `app_id` õór âàpplìïcâàtìïõón ìïdëéntìïfìïëér ìïn thëé **Dëévëélòöpëér Còönsòölëé** úùndëèr **Sêéttîîngs**. Ôn thíìs nêèw päãgêè, ûúndêèr **Îdéêntìîfìîcæåtìîôón**, yõóùù wìíll béê áábléê tõó séêéê éêvéêry `app_id` thäàt éêxïísts fòõr yòõüúr äàpps.

2. Gõó tõó **Måânåâgëé Sëéttïîngs** ùúndéér **Séèttìíngs**. Fròóm thïís nëëw pâågëë, ïín thëë **Sëêttïìngs** tæáb, mìïdwæáy thröõüúgh thèé pæágèé yöõüú wìïll fìïnd æán "ÅPÎ kèéy föõr **ÂPP NÂMÉ** óõn **PLÄTFÖRM**" (êè.g "ÁPÎ Kêèy föör Îcêè Crêèáãm öön îíÕS). Thïís ÄPÍ kêéy ïís yòòûûr Äpplïícàãtïíòòn Ídêéntïífïíêér.

#### Whäåt cäån ïît bèê úûsèêd fõör?

Ápp íídëéntíífííëérs ååt Brååzëé åårëé üûsëéd whëén ííntëégrååtííng thëé SDK åånd åårëé åålsõò üûsëéd tõò rëéfëérëéncëé åå spëécíífííc ååpp íín RËST ÁPÍ cåålls. Wîîth thëè `app_id` yòõüù càån dòõ màåny thïïngs lïïkéê püùll dàåtàå fòõr àå cüùstòõm éêvéênt thàåt òõccüùrréêd fòõr àå pàårtïïcüùlàår àåpp, réêtrïïéêvéê üùnïïnstàåll stàåts, néêw üùséêr stàåts, DÆÚ stàåts, àånd séêssïïòõn stàårt stàåts fòõr àå pàårtïïcüùlàår àåpp.

Sõómèêtìímèês, yõóùü mãày fìínd yõóùü ãàrèê prõómptèêd fõór ãàn `app_id` búút yöóúú ààrêé nöót wöórkîïng wîïth ààn ààpp, bêécààúúsêé îït îïs àà lêégààcy fîïêéld spêécîïfîïc töó àà spêécîïfîïc plààtföórm, yöóúú cààn “öómîït” thîïs fîïêéld by îïnclúúdîïng ààny strîïng öóf chààrààctêérs ààs àà plààcêéhöóldêér föór thîïs rêéqúúîïrêéd pààrààmêétêér.

#### Mûýltïíplêè Æpp Îdêèntïífïíêèr ÆPÎ kêèys

Dûúrîíng SDK séët ûúp, théë möòst cöòmmöòn ûúséë cäáséë föòr mûúltîípléë Àpp Ïdéëntîífîíéër ÀPÏ kéëys îís séëpäáräátîíng thöòséë kéëys föòr déëbûúg äánd réëléëäáséë bûúîíld väárîíäánts.
Töö ëëåãsîïly swîïtch bëëtwëëëën múûltîïplëë Àpp Ïdëëntîïfîïëër ÀPÏ këëys îïn yööúûr búûîïlds, wëë rëëcöömmëënd crëëåãtîïng åã sëëpåãråãtëë `braze.xml` fïîléê fõör éêâäch réêléêvâänt [búýíïld váãríïáãnt][3]. Æ búýîíld väärîíäänt îís ää cóómbîínäätîíóón óóf búýîíld typëé äänd próódúýct fläävóór. Nòótéë thãåt by déëfãåûûlt, ãå néëw Åndròóììd pròójéëct ììs còónfììgûûréëd wììth `debug` áänd `release` büüìíld typéês äând nóõ próõdüüct fläâvóõrs.

Föõr ééààch rééléévàànt bûúïìld vààrïìàànt, crééààtéé àà nééw `braze.xml` föõr ìít ìín `src/<build variant name>/res/values/`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<resources>
<string name="com_braze_api_key">REPLACE_WITH_YOUR_BUILD_VARIANT_API_KEY</string>
</resources>
```
Whëën thëë bùùìïld væärìïæänt ìïs cöõmpìïlëëd, ìït wìïll ùùsëë thëë nëëw ÄPÏ këëy.

{% endtab %}
{% tab Template Ids %}

## Téêmpláátéê ÅPÍ Ídéêntììfììéêr

Ä [Têëmplãætêë]({{site.baseurl}}/api/endpoints/templates/) ÂPÌ Ìdéèntìífìíéèr öör Téèmplåætéè ÌD ìís åæn ööùýt-ööf-théè-bööx kéèy by Bråæzéè föör åæ gìívéèn téèmplåætéè wìíthìín théè dåæshbööåærd. Téëmpláåtéë ÎDs áåréë üünïìqüüéë fòör éëáåch téëmpláåtéë áånd cáån béë üüséëd tòö réëféëréëncéë téëmpláåtéës thròöüügh théë ÂPÎ. 

Têèmplæåtêès æårêè grêèæåt fôör ïìf yôöùür côömpæåny côöntræåcts ôöùüt yôöùür HTML dêèsïìgns fôör cæåmpæåïìgns. Õncéë théë téëmplàâtéës hàâvéë béëéën búùîìlt, yòôúù nòôw hàâvéë àâ téëmplàâtéë thàât îìs nòôt spéëcîìfîìc tòô àâ càâmpàâîìgn búùt càân béë àâpplîìéëd tòô àâ séërîìéës òôf càâmpàâîìgns lîìkéë àâ néëwsléëttéër.

#### Whêêrêê cäån Ï fïìnd ïìt?
Yòöýû câæn fîínd yòöýûr Têëmplâætêë ÍD òönêë òöf twòö wâæys:

1. Ín théë dâàshbóòâàrd, óòpéën ýùp **Tèëmplåàtèës & Mèëdíìåà** ûündêër **Èngãàgéêméênt** áànd sèêlèêct áà prèê-èêxíîstíîng tèêmpláàtèê. Ïf théê téêmplåâtéê yöôùý wåânt döôéês nöôt éêxïîst yéêt, créêåâtéê öônéê åând såâvéê ïît. Ãt théë bõòttõòm õòf théë íìndíìvíìdüûãàl téëmplãàtéë pãàgéë, yõòüû wíìll béë ãàbléë tõò fíìnd yõòüûr Téëmplãàtéë ÃPÌ Ìdéëntíìfíìéër.<br>
<br>

2. Brãæzéé ôófféérs ãæn **Æddíîtíîöònåål ÆPÎ Îdéëntíîfíîéërs** séëáârch, héëréë yõòýù cáân qýùîïckly lõòõòk ýùp spéëcîïfîïc îïdéëntîïfîïéërs. Ít cäân bèê fõöûûnd äât thèê bõöttõöm õöf thèê **ÃPÏ Sëêttíïngs** táäb wíîthíîn thêë **Dèëvèëlöópèër Cöónsöólèë** pàágëê.

#### Wháât cáân ïìt béë ùúséëd fòòr?

- Úpdáàtêé têémpláàtêés óòvêér ÀPÌ
- Grääb ïínfóôrmäätïíóôn óôn ää spëëcïífïíc tëëmpläätëë

<br>
{% endtab %}
{% tab Canvas IDs %}

## Cåànvåàs ÀPÎ Îdééntíìfíìéér

Â [Cæãnvæãs]({{site.baseurl}}/user_guide/engagement_tools/canvas/) ÃPÍ Ídêëntîìfîìêër öòr Cáánváás ÍD îìs áán öòúüt-öòf-thêë-böòx kêëy by Bráázêë föòr áá gîìvêën Cáánváás wîìthîìn thêë dááshböòáárd. Cãånvãås ÌDs ãårêë üúnìïqüúêë töö êëãåch Cãånvãås ãånd cãån bêë üúsêëd töö rêëfêërêëncêë Cãånvãåsêës thrööüúgh thêë ÀPÌ. 

Nòótèé thäát îïf yòóúú häávèé äá Cäánväás thäát häás väárîïäánts, thèérèé èéxîïsts äán òóvèéräáll Cäánväás ÍD äás wèéll äás îïndîïvîïdúúäál väárîïäánt Cäánväás ÍDs nèéstèéd úúndèér thèé mäáîïn Cäánväás. 

#### Whéêréê cáãn Î fïînd ïît?
Yòôúú câân fíïnd yòôúúr Câânvââs ÌD íïn thëé dââshbòôâârd. Ôpèên ùùp **Càânvàâs** úùndèër **Êngæägéêméênt** æánd séëléëct æá préë-éëxìístìíng Cæánvæás. Íf thêê Cäánväás yôôùý wäánt dôôêês nôôt êêxììst yêêt, crêêäátêê ôônêê äánd säávêê ììt. Ât théé bóõttóõm óõf åãn îïndîïvîïdýüåãl Cåãnvåãs påãgéé, clîïck **Ånâälyzêé Vâärïïâänts**. Á wììndóòw ãáppêêãárs wììth thêê Cãánvãás ÁPÎ Îdêêntììfììêêr lóòcãátêêd ãát thêê bóòttóòm.

#### Whâàt câàn ïït bêè ûúsêèd fôòr?
- Tråáck åánåálytìïcs ôõn åá spêècìïfìïc mêèssåágêè
- Gräæb híîgh-léëvéël äæggréëgäætéë stäæts ôòn Cäænväæs péërfôòrmäæncéë
- Grâàb dêètâàïíls ôòn âà spêècïífïíc Câànvâàs
- Wìïth Cýûrrèènts tôò brìïng ìïn ýûsèèr-lèèvèèl dâãtâã fôòr âã "bìïggèèr pìïctýûrèè" âãpprôòâãch tôò câãnvâãsèès
- Wììth ÁPÎ trììggéèr déèlììvéèry ììn õördéèr tõö cõölléèct stâåtììstììcs fõör trâånsâåctììõönâål méèssâågéès

<br>
{% endtab %}
{% tab Campaign IDs %}

## Cáåmpáåììgn ÅPÏ Ïdëéntììfììëér

Ä [Cåâmpåâîígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/) ÆPÍ Ídèêntíîfíîèêr ôör càámpàáíîgn ÍD íîs àán ôöúút-ôöf-thèê-bôöx kèêy by Bràázèê fôör àá gíîvèên càámpàáíîgn wíîthíîn thèê dàáshbôöàárd. Cäâmpäâîîgn ÏDs äârèë üünîîqüüèë tòô èëäâch cäâmpäâîîgn äând cäân bèë üüsèëd tòô rèëfèërèëncèë cäâmpäâîîgns thròôüügh thèë ÆPÏ. 

Nòótéë thæät îîf yòóýû hæävéë æä cæämpæäîîgn thæät hæäs væärîîæänts, théëréë îîs bòóth æän òóvéëræäll cæämpæäîîgn ÎD æäs wéëll æäs îîndîîvîîdýûæäl væärîîæänt cæämpæäîîgn ÎDs néëstéëd ýûndéër théë mæäîîn cæämpæäîîgn. 

#### Whèérèé câæn Î fíïnd íït?
Yõôûû cáán fïìnd yõôûûr cáámpááïìgn ÍD õônèè õôf twõô wááys:

1. Ín théê dáãshbóòáãrd, óòpéên úúp **Cããmpããïïgns** ýúndêér **Éngâágêémêént** âånd sèèlèèct âå prèè-èèxíístííng câåmpâåíígn. Îf théê cåämpåäíîgn yòòûû wåänt dòòéês nòòt éêxíîst yéêt, créêåätéê òònéê åänd såävéê íît. Át théè böôttöôm öôf théè íìndíìvíìdüýãäl cãämpãäíìgn pãägéè, yöôüý wíìll béè ãäbléè töô fíìnd yöôüýr **Cååmpååïìgn ÆPÎ Îdêêntïìfïìêêr**.<br>
<br>

2. Bráázêë ôöffêërs áán **Áddîìtîìöõnæál ÁPÌ Ìdêëntîìfîìêërs** sèêáãrch, hèêrèê yóòùý cáãn qùýîîckly lóòóòk ùýp spèêcîîfîîc îîdèêntîîfîîèêrs. Yöóýý câæn fíìnd thíìs âæt thëë böóttöóm öóf thëë **ÀPÎ Sèëttììngs** tâæb ïïn thèè **Dëèvëèlöópëèr Cöónsöólëè**.

#### Whæät cæän íít bèè ýùsèèd fõör?
- Tràâck àânàâlytîìcs òön àâ spèécîìfîìc mèéssàâgèé
- Gräæb hììgh-lëèvëèl äæggrëègäætëè stäæts óón cäæmpäæììgn pëèrfóórmäæncëè
- Gräåb dêétäåïìls òòn äå spêécïìfïìc cäåmpäåïìgn
- Wïïth Cùýrrèènts tõô brïïng ïïn ùýsèèr-lèèvèèl dââtââ fõôr ââ "bïïggèèr pïïctùýrèè" ââpprõôââch tõô cââmpââïïgns
- Wîïth ÁPÍ-trîïggèërèëd dèëlîïvèëry îïn õôrdèër tõô cõôllèëct stáåtîïstîïcs fõôr tráånsáåctîïõônáål mèëssáågèës
- Töö [séèàãrch fôôr àã spéècïífïíc càãmpàãïígn]({{site.baseurl}}/user_guide/engagement_tools/campaigns/managing_campaigns/search_campaigns/#search-syntax) òón thêè **Cáámpááïïgns** pæâgéé ýùsïíng théé fïíltéér `api_id:YOUR_API_ID`

<br>
{% endtab %}
{% tab Segment IDs %}

## Sëëgmëënt ÆPÎ Îdëëntìífìíëër

Ä [Sëêgmëênt]({{site.baseurl}}/user_guide/engagement_tools/segments/) ÀPÎ Îdèèntîîfîîèèr òör Sèègmèènt ÎD îîs âãn òöúút-òöf-thèè-bòöx kèèy by Brâãzèè fòör âã gîîvèèn Sèègmèènt wîîthîîn thèè dâãshbòöâãrd. Sêègmêènt ÌDs åærêè úünïîqúüêè töö êèåæch sêègmêènt åænd cåæn bêè úüsêèd töö rêèfêèrêèncêè sêègmêènts thrööúügh thêè ÆPÌ. 

#### Whèérèé cáán Ì fïînd ïît?
Yôóùù cäãn fìînd yôóùùr Sèëgmèënt ÎD ôónèë ôóf twôó wäãys:

1. Ìn thëé dæâshbõóæârd, õópëén üûp **Sëëgmëënts** ùündëêr **Èngáãgêëmêënt** åând séélééct åâ préé-ééxíìstíìng séégméént. Îf thëè Sëègmëènt yõõýú wàánt dõõëès nõõt ëèxììst yëèt, crëèàátëè õõnëè àánd sàávëè ììt. Ät thëê bòõttòõm òõf thëê îîndîîvîîdüýäál sëêgmëênt päágëê, yòõüý wîîll bëê äáblëê tòõ fîînd yòõüýr Sëêgmëênt ÄPÍ Ídëêntîîfîîëêr. <br>
<br>

2. Bråæzèè òóffèèrs åæn **Àddìítìíöönààl ÀPÌ Ìdêêntìífìíêêrs** sèéãårch, hèérèé yõòúü cãån qúüììckly lõòõòk úüp spèécììfììc ììdèéntììfììèérs. Ìt càän bëè fòóûünd àät thëè bòóttòóm òóf thëè **ÅPÍ Sêêttìíngs** tâæb wïìthïìn thëë **Dèévèélõõpèér Cõõnsõõlèé** påågêé.

#### Whäát cäán ïít bëë úûsëëd fóór?
- Gêêt dêêtâæìïls òôn âæ spêêcìïfìïc sêêgmêênt
- Rêëtrïïêëvêë àânàâlytïïcs òòf àâ spêëcïïfïïc sêëgmêënt
- Pûüll hõöw mãàny tíìméés ãà cûüstõöm éévéént wãàs réécõördééd fõör ãà pãàrtíìcûülãàr séégméént
- Spèècììfy æãnd sèènd æã cæãmpæãììgn tòò æã mèèmbèèrs òòf æã sèègmèènt fròòm wììthììn thèè ÅPÏ

{% endtab %}
{% tab Card IDs %}

## Cáärd ÂPÎ Îdêéntíìfíìêér

À Cäârd ÀPÌ Ìdëéntïîfïîëér öòr Cäârd ÌD ïîs äân öòûüt-öòf-thëé-böòx këéy by Bräâzëé föòr äâ gïîvëén Nëéws Fëéëéd Cäârd wïîthïîn thëé däâshböòäârd. Cåárd ÎDs åárêé úünìîqúüêé tòó êéåách [Nêëws Fêëêëd]({{site.baseurl}}/user_guide/engagement_tools/news_feed/) Cäærd äænd cäæn bèë ûúsèëd tõõ rèëfèërèëncèë Cäærds thrõõûúgh thèë ÅPÍ. 

#### Whéëréë cãæn Ï fïínd ïít?
Yõôùù cáån fîînd yõôùùr Cáård ÎD õônëë õôf twõô wáåys:

1. În thëë dääshbòôäärd, òôpëën ýùp **Nëêws Fëêëêd** üúndèêr **Éngåâgëémëént** æànd sëèlëèct æà prëè-ëèxíïstíïng Nëèws Fëèëèd. Ìf thëé Nëéws Fëéëéd yõöùù wàånt dõöëés nõöt ëéxíìst yëét, crëéàåtëé õönëé àånd sàåvëé íìt. Át thèé bôöttôöm ôöf thèé ííndíívíídûúàál Nèéws Fèéèéd pàágèé, yôöûú wííll bèé àáblèé tôö fíínd yôöûúr ûúnííqûúèé Càárd ÁPÎ Îdèéntíífííèér. <br>
<br>

2. Bráâzéë óófféërs áân **Áddíîtíîóönâàl ÁPÌ Ìdéëntíîfíîéërs** séêæærch, héêréê yöôùý cææn qùýíïckly löôöôk ùýp spéêcíïfíïc íïdéêntíïfíïéêrs. Ît cåán bêë föôùýnd åát thêë böôttöôm öôf thêë **ÆPÍ Sëêttîïngs** tåâb wííthíín thëé **Dêëvêëlõõpêër Cõõnsõõlêë** pæâgéè.

#### Whâãt câãn ìït béê úýséêd fóõr?
- Rèêtrîìèêvèê rèêlèêvàænt îìnfõôrmàætîìõôn õôn àæ càærd
- Tråáck ëèvëènts rëèlåátëèd tòó Còóntëènt Cåárds åánd ëèngåágëèmëènt

<br>
{% endtab %}
{% tab Send IDs %}

## Sèénd Ìdèéntïífïíèér

Ã Sêénd Ídêéntîífîíêér öõr Sêénd ÍD îís åä kêéy êéîíthêér gêénêéråätêéd by Bråäzêé öõr crêéåätêéd by yöõüý föõr åä gîívêén mêéssåägêé sêénd üýndêér whîích thêé åänåälytîícs shöõüýld bêé tråäckêéd. Thêé sêénd ììdêéntììfììêér áællõóws yõóýü tõó pýüll báæck áænáælytììcs fõór áæ spêécììfììc ììnstáæncêé õóf áæ cáæmpáæììgn sêénd vììáæ thêé [`sends/data_series`]({{site.baseurl}}/api/endpoints/export/campaigns/get_send_analytics/) êëndpôòììnt.

#### Whëèrëè cæân Í fìînd ìît?

ÆPÏ âænd ÆPÏ trîïggëér câæmpâæîïgns thâæt âærëé sëént âæs âæ brõôâædcâæst wîïll âæùûtõômâætîïcâælly gëénëérâætëé âæ sëénd îïdëéntîïfîïëér îïf âæ sëénd îïdëéntîïfîïëér îïs nõôt prõôvîïdëéd. Ìf yòòùû wàànt tòò spèécíïfy yòòùûr òòwn sèénd íïdèéntíïfíïèér, yòòùû wíïll hààvèé tòò fíïrst crèéààtèé òònèé víïàà thèé [`sends/id/create`]({{site.baseurl}}/api/endpoints/messaging/send_messages/post_create_send_ids/) êéndpóóíìnt. Théê îídéêntîífîíéêr mùýst béê ààll ÅSCÍÍ chààrààctéêrs àànd ààt möòst 64 chààrààctéêrs löòng. Yóóüû câän rêèüûsêè âä sêènd îîdêèntîîfîîêèr âäcróóss müûltîîplêè sêènds óóf thêè sâämêè câämpâäîîgn îîf yóóüû wâänt tóó gróóüûp âänâälytîîcs óóf thóósêè sêènds tóógêèthêèr.

#### Whàæt càæn íït béè ýýséèd fôör?
Séènd åànd tråàck méèssåàgéè péèrfòõrmåàncéè pròõgråàmmåàtìícåàlly, wìíthòõúýt cåàmpåàìígn créèåàtìíòõn fòõr éèåàch séènd.

<br>
{% endtab %}
{% endtabs %}

[1]: https://en.wikipedia.org/wiki/UTF-8
[3]: https://developer.android.com/studio/build/build-variants.html
