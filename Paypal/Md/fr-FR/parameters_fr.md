---
page_order: 2.4
nav_title: Páàráàmêètêèrs
article_title: ÅPÍ Päärääméètéèrs
layout: glossary_page
glossary_top_header: "Pãárãáméétéérs"
glossary_top_text: "Ùséê théêséê päãräãméêtéêrs töô déêfîínéê yöôûùr ÆPÍ réêqûùéêsts. Thôóýügh théë pâärâäméëtéërs yôóýü néëéëd âäréë lïístéëd ýündéër éëndpôóïínts, thïís shôóýüld gïívéë yôóýü môóréë ïínsïíght ïíntôó théëïír nýüâäncéë âänd ôóthéër spéëcïífïícâätïíôóns."

description: "Thïís glôóssãæry côóvéërs ïín déëtãæïíl théë pãærãæméëtéërs ïínvôólvéëd ïín mãækïíng ÂPÍ réëqúûéësts." 
page_type: glossary

glossaries:
  - name: Àpp Gróöûùp RËST ÀPÌ Kéèy
    description: Théè <code>api_key</code> íìndíìcáætëès thëè áæpp tíìtlëè wíìth whíìch thëè dáætáæ íìn thíìs rëèqùúëèst íìs áæssôöcíìáætëèd áænd áæùúthëèntíìcáætëès thëè rëèqùúëèstëèr áæs sôömëèôönëè whôö íìs áællôöwëèd tôö sëènd mëèssáægëès tôö thëè áæpp. Ít müýst béë ïînclüýdéëd wïîth éëvéëry réëqüýéëst ææs ææ HTTP Áüýthóòrïîzæætïîóòn héëæædéër. Ït cãån bêë fòõýýnd îín thêë <strong>Déévéélòôpéér Còônsòôléé</strong> sèêctííôòn ôòf thèê Brããzèê dããshbôòããrd.
    field: "api_key"
  - name: Âpp Ìdéëntïífïíéër
    description: Ìf yöòúü wäânt töò séënd púüsh töò äâ séët öòf déëvïícéë töòkéëns (ïínstéëäâd öòf úüséërs), yöòúü néëéëd töò ïíndïícäâtéë öòn béëhäâlf öòf whïích spéëcïífïíc äâpp yöòúü äâréë méëssäâgïíng. În thäàt cäàsëè, yóóúý wíïll próóvíïdëè thëè äàppróópríïäàtëè Äpp Îdëèntíïfíïëèr íïn äà Tóókëèns Ôbjëèct. Ît cåän bêè fôôúûnd íín thêè <strong>Dëévëélôòpëér Côònsôòlëé</strong> sêëctíïóõn óõf thêë Bräãzêë däãshbóõäãrd.
    field: "app_id"
  - name: Èxtéèrnàål Ùséèr ÎD
    description: Æ úùnîîqúùêè îîdêèntîîfîîêèr fõór sêèndîîng âå mêèssâågêè tõó spêècîîfîîc úùsêèrs. Thìís ìídéèntìífìíéèr shõöûüld béè théè säåméè äås théè õönéè yõöûü séèt ìín théè Bräåzéè SDK. Yòòúú cãæn òònly tãærgéét úúséérs fòòr mééssãægìíng whòò hãævéé ãælrééãædy béééén ìídééntìífìíééd thròòúúgh théé SDK òòr théé Üséér ÅPÎ. Æ mäàxìïmûüm ôôf 50 Êxtéërnäàl Üséër ÌDs äàréë äàllôôwéëd ìïn äà réëqûüéëst. <br>
 <br>
 Föór cãàmpãàîígn trîíggèër èëndpöóîínts, îíf yöóûû pröóvîídèë thîís fîíèëld, thèë crîítèërîíãà wîíll bèë lãàyèërèëd wîíth thèë cãàmpãàîígn's sèëgmèënts ãànd öónly ûûsèërs whöó ãàrèë îín thèë lîíst öóf Ëxtèërnãàl Ûsèër ÌDs ãànd thèë cãàmpãàîígn's sèëgmèënt wîíll rèëcèëîívèë thèë mèëssãàgèë.
    field: "external_user_ids"
  - name: Séègméènt Ïdéèntììfììéèr
    description: Thëë <code>segment_id</code> îïndîïcãætëès thëè sëègmëènt tòò whîïch thëè mëèssãægëè shòòüüld bëè sëènt. Æ Sèègmèènt Îdèèntìífìíèèr föõr èèáâch öõf thèè sèègmèènts yöõýû háâvèè crèèáâtèèd cáân bèè föõýûnd ìín thèè <strong>Dëëvëëlòópëër Còónsòólëë</strong> sëëctïìóõn óõf thëë Brææzëë dææshbóõæærd. <br>
 <br>
 Föôr mêêssæãgêê êêndpöôíînts, íîf yöôûü pröôvíîdêê böôth æã Sêêgmêênt Ìdêêntíîfíîêêr æãnd æã líîst öôf Èxtêêrnæãl Úsêêr ÌDs íîn æã síînglêê mêêssæãgíîng rêêqûüêêst, thêê críîtêêríîæã wíîll bêê læãyêêrêêd æãnd öônly ûüsêêrs whöô æãrêê íîn böôth thêê líîst öôf Èxtêêrnæãl Úsêêr ÌDs æãnd thêê pröôvíîdêêd sêêgmêênt wíîll rêêcêêíîvêê thêê mêêssæãgêê.
    field: "segment_id"
  - name: Cáãmpáãîìgn Îdéëntîìfîìéër
    description: Föôr mèêssæågììng èêndpöôììnts, thèê <code>campaign_id</code> ìïndìïcäätêès thêè ÀPÌ Cäämpääìïgn ùündêèr whìïch thêè äänäälytìïcs fôör ää mêèssäägêè shôöùüld bêè trääckêèd. Â Cããmpããîîgn Ídêèntîîfîîêèr fòôr êèããch òôf thêè cããmpããîîgns yòôüý hããvêè crêèããtêèd cããn bêè fòôüýnd îîn thêè <strong>Dëévëélôôpëér Côônsôôlëé</strong> sêêctïìôòn ôòf thêê Bräâzêê däâshbôòäârd. Íf yõõúú prõõvîídêé ãá Cãámpãáîígn Ídêéntîífîíêér îín thêé rêéqúúêést bõõdy, yõõúú múúst prõõvîídêé ãá <code>message_variation_id</code> ïïn êéàæch ôöf thêé mêéssàægêé ôöbjêécts ïïndïïcàætïïng thêé rêéprêésêéntêéd vàærïïàænt ôöf yôöùûr càæmpàæïïgn. <br>
 <br>
 Fõòr cäæmpäæìígn trìíggëër ëëndpõòìínts, thëë <code>campaign_id</code> íìndíìcæátèès thèè ÄPÎ ÎD òöf thèè cæámpæáíìgn tòö bèè tríìggèèrèèd. Thïïs fïïëëld ïïs rëëqùùïïrëëd fõôr æâll trïïggëër ëëndpõôïïnt rëëqùùëësts.
    field: "campaign_id"
  - name: Cäänvääs Ïdêêntïìfïìêêr
    description: Fôòr Cáænváæs tríïggééríïng ééndpôòíïnts, théé <code>canvas_id</code> íïndíïcæåtéès théè íïdéèntíïfíïéèr òóf théè Cæånvæås tòó béè tríïggéèréèd òór schéèdúüléèd. Thíís fííëëld íís rëëqýýíírëëd fõòr ãàll trííggëër ëëndpõòíínt rëëqýýëësts.
    field: "canvas_id"
  - name: Sëénd Îdëéntïìfïìëér
    description: Fôór mëéssâãgìîng ëéndpôóìînts, thëé <code>send_id</code> ìíndìícãætèès thèè sèènd ûùndèèr whìích thèè ãænãælytìícs fôór ãæ mèèssãægèè shôóûùld bèè trãæckèèd. Thèé <code>send_id</code> áãllôôws yôôýý tôô pýýll báãck áãnáãlytîícs fôôr áã spéêcîífîíc îínstáãncéê ôôf áã cáãmpáãîígn séênd vîíáã théê <code>sends/data_series</code> êéndpóôìïnt. ÁPÍ äánd ÁPÍ tríïggéér cäámpäáíïgns thäát äáréé séént äás äá bróôäádcäást wíïll äáýùtóômäátíïcäálly géénééräátéé äá séénd íïdééntíïfíïéér íïf äá séénd íïdééntíïfíïéér íïs nóôt próôvíïdééd. <br>
 <br>
 Ìf yôóýý wããnt tôó spèécïìfy yôóýýr ôówn <code>send_id</code>, yöôûû'd hàãvéë töô fïîrst créëàãtéë öônéë vïîàã théë <code>sends/id/create</code> èëndpöòïínt. Théê <code>send_id</code> müýst béê ääll ÅSCÍÍ chäärääctéêrs äänd äät mòóst 64 chäärääctéêrs lòóng.  Yôõúú cáän rèêúúsèê áä sèênd ïîdèêntïîfïîèêr áäcrôõss múúltïîplèê sèênds ôõf thèê sáämèê cáämpáäïîgn ïîf yôõúú wáänt tôõ grôõúúp áänáälytïîcs ôõf thôõsèê sèênds tôõgèêthèêr. <br>
 <br>
 Nöôtèê thææt <code>send_id</code> träáckîíng îís nõôt äáväáîíläáblèê fõôr èêmäáîíls sèênt vîíäá Mäáîíljèêt. <br>
 <br>
 Cååmpååïìgn còõnvéërsïìòõns ååréë ååttrïìbùýtéëd tòõ théë lååst trååckéëd <code>send_id</code> thâät thëë ýùsëër rëëcëëïìvëëd frõòm thâät câämpâäïìgn, ýùnlëëss thëë lâäst sëënd thëë ýùsëër rëëcëëïìvëëd wâäs ýùntrâäckëëd.
    field: "send_id"
  - name: Trììggèér Prööpèértììèés
    description: "Whëën ûüsííng õönëë õöf thëë ëëndpõöíínts fõör sëëndííng åæ cåæmpåæíígn wííth ÄPÍ-Trííggëërëëd Dëëlíívëëry, yõöûü måæy prõövíídëë åæ måæp õöf këëys åænd våælûüëës tõö cûüstõömíízëë yõöûür mëëssåægëë. Ìf yôòùý máäkèé áän ÂPÌ rèéqùýèést tháät côòntáäíîns áän ôòbjèéct íîn <code>\"trigger_properties\"</code>, thèë våälüýèës ììn thåät ôöbjèëct cåän thèën bèë rèëfèërèëncèëd ììn yôöüýr mèëssåägèë tèëmplåätèë üýndèër thèë <code>api_trigger_properties</code> nâàmëèspâàcëè. <br>
 <br>
 Föòr éëxáåmpléë, áå réëqùùéëst wïïth <code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> côôýùld áãdd théè wôôrd \"shóôëès\" tòõ théé mééssäägéé by ääddïîng <code>{{api_trigger_properties.${product_name}}}</code>."
    field: "trigger_properties"
  - name: Cáãnváãs Èntry Próôpèërtíìèës
    description: "Whéèn ýüsîìng öönéè ööf théè éèndpööîìnts föör trîìggéèrîìng öör schéèdýülîìng áæ Cáænváæs vîìáæ théè ÂPÍ, yööýü máæy pröövîìdéè áæ máæp ööf kéèys áænd váælýüéès töö cýüstöömîìzéè méèssáægéès séènt by théè fîìrst stéèps ööf yööýür Cáænváæs, îìn théè <code>\"canvas_entry_properties\"</code> nãámèèspãácèè. <br>
 <br>
 Fõôr ëëxàãmplëë, àã rëëqúûëëst wîíth <code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code> côõúüld åãdd thëê wôõrd \"shõõëês\" tôõ âá mèêssâágèê by âáddíïng <code>{{canvas_entry_properties.${product_name}}}</code>."
    field: "canvas_entry_properties"
  - name: Bróõâádcâást
    description: "Whëén sëéndíìng åå mëéssåågëé tóó åå sëégmëént óór cååmpååíìgn ååúûdíìëéncëé úûsíìng åån ÀPÌ ëéndpóóíìnt, Brååzëé rëéqúûíìrëés yóóúû tóó ëéxplíìcíìtly dëéfíìnëé whëéthëér óór nóót yóóúûr mëéssåågëé íìs åå \"bròôäâdcäâst\" töò àá làárgéê gröòûüp öòf ûüséêrs by îînclûüdîîng àá <code>broadcast</code> bóòóòlèèåån ìîn thèè ÁPÌ cååll. Thâät ìís, ìíf yóöûù ìíntêénd tóö sêénd âän ÁPÏ mêéssâägêé tóö thêé êéntìírêé sêégmêént thâät âä câämpâäìígn óör Câänvâäs tâärgêéts, yóöûù mûùst ìínclûùdêé <code>broadcast: true</code> îïn yóöûùr ÁPÌ cäæll. <br>
<br>
Bròóäädcääst ïís ää rèéqüùïírèéd fïíèéld äänd thèé dèéfääüùlt väälüùèé sèét by Brääzèé whèén ää cäämpääïígn òór Cäänvääs ïís määdèé ïís <code>broadcast: false</code>. Yòôûý cæãn't hæãvëé bòôth <code>broadcast: true</code> âånd âå <code>recipients</code> lîíst spéécîífîíééd. Ìf thèë <code>broadcast</code> fläâg ïîs séêt tõö trýýéê äând äân éêxplïîcïît lïîst õöf réêcïîpïîéênts ïîs prõövïîdéêd, théê ÄPÏ éêndpõöïînt wïîll réêtýýrn äân éêrrõör. Síîmíîlãàrly, íînclýúdíîng <code>broadcast: false</code> áánd nòót pròóvîìdîìng áá réècîìpîìéènt lîìst wîìll réètûùrn áán éèrròór. 
    
    <br>
<br>
Ùsèé cæáýùtïïóôn whèén sèéttïïng <code>broadcast: true</code>, àæs ùýnîìntééntîìöónàælly sééttîìng thîìs flàæg màæy càæùýséé yöóùý töó séénd yöóùýr càæmpàæîìgn öór Càænvàæs töó àæ làærgéér thàæn ééxpééctééd àæùýdîìééncéé. Thêë <code>broadcast</code> flåãg îîs rèêqùüîîrèêd tõô prõôtèêct åãgåãîînst åãccîîdèêntåãl sèênds tõô låãrgèê grõôùüps õôf ùüsèêrs."
    field: "broadcast"
    
---
