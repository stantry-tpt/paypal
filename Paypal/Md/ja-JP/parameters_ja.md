---
page_order: 2.4
nav_title: パラメータ
article_title: APIパラメータ
layout: glossary_page
glossary_top_header: "パラメータ"
glossary_top_text: "これらのパラメータを使用して、APIリクエストを定義します。必要なパラメータはエンドポイントの下にリストされていますが、これにより、そのニュアンスやその他の仕様に関する洞察が得られます。"

description: "この用語集では、APIリクエストの作成に関連するパラメータについて詳しく説明します。" 
page_type: glossary

glossaries:
  - name: アプリケーショングループREST APIキー
    description: は、このリクエストのデータが関連付けられている App タイトル<code>api_key</code>を示し、リクエスト者を App にメッセージを送信できるユーザーとして認証します。HTTP Authorizationヘッダーとしてすべてのリクエストに含める必要があります。Brazeダッシュボードの<strong>開発者コンソール</strong>セクションにあります。
    field: "api_key"
  - name: アプリ識別子
    description: （ユーザーではなく）一連のデバイストークンにプッシュを送信する場合は、メッセージングしている特定のアプリを代理で指定する必要があります。その場合、トークンオブジェクトに適切なアプリ識別子を入力します。Brazeダッシュボードの<strong>開発者コンソール</strong>セクションにあります。
    field: "app_id"
  - name: 外部ユーザーID
    description: 特定のユーザーにメッセージを送信するための一意の識別子。この識別子は、Braze SDKで設定した識別子と同じである必要があります。SDK またはユーザー API で既に識別されたメッセージングのみ、ユーザーをターゲットにできます。リクエストには最大 50 個の外部ユーザー ID を使用できます。<br>
 <br>
 キャンペーントリガエンドポイントの場合、このフィールドを指定すると、条件はキャンペーンのセグメントと階層化され、外部ユーザーIDとキャンペーンのセグメントのリストにあるユーザーのみがメッセージを受信します。
    field: "external_user_ids"
  - name: セグメント識別子
    description: は、メッセージを送信するセグメント<code>segment_id</code>を示します。作成した各セグメントのセグメント識別子は、Brazeダッシュボードの<strong>開発者コンソール</strong>セクションにあります。<br>
 <br>
 メッセージエンドポイントの場合、単一のメッセージングリクエストでセグメント識別子と外部ユーザーIDのリストの両方を提供すると、条件が階層化され、外部ユーザーIDのリストと提供されたセグメントの両方にあるユーザーのみがメッセージを受信します。
    field: "segment_id"
  - name: キャンペーン識別子
    description: メッセージングエンドポイントの場合、はメッセージの分析を追跡するAPIキャンペーン<code>campaign_id</code>を示します。作成した各キャンペーンのキャンペーン識別子は、Brazeダッシュボードの<strong>開発者コンソール</strong>セクションにあります。リクエスト本文にキャンペーン識別子を指定する場合は、キャンペーンの代表されるバリアントを示す各メッセージオブジェクト<code>message_variation_id</code>にを提供する必要があります。<br>
 <br>
 キャンペーントリガエンドポイントの場合、はトリガされるキャンペーンのAPI ID<code>campaign_id</code>を示します。このフィールドは、すべてのトリガーエンドポイントリクエストに必要です。
    field: "campaign_id"
  - name: キャンバス識別子
    description: Canvasトリガーエンドポイントの場合、はトリガーまたはスケジュールするCanvasの識別子<code>canvas_id</code>を示します。このフィールドは、すべてのトリガーエンドポイントリクエストに必要です。
    field: "canvas_id"
  - name: 識別子を送信
    description: メッセージングエンドポイントの場合、はメッセージの分析を追跡する送信<code>send_id</code>を示します。<code>send_id</code> では、<code>sends/data_series</code>エンドポイントを介して送信されたキャンペーンの特定のインスタンスの分析をプルバックできます。ブロードキャストとして送信されるAPIおよびAPIトリガーキャンペーンは、送信識別子が提供されない場合、自動的に送信識別子を生成します。<br>
 <br>
 独自の を指定する場合は<code>send_id</code>、まず<code>sends/id/create</code>エンドポイントを介して を作成する必要があります。はすべてASCII文字で、最大64文字の長さ<code>send_id</code>でなければなりません。同じキャンペーンの複数の送信間で、それらの送信の分析をグループ化したい場合は、それらの送信識別子を再利用できます。<br>
 <br>
 Mailjet経由で送信された電子メールには<code>send_id</code>追跡機能はありません。<br>
 <br>
 キャンペーン変換は、ユーザーが受信した最後の送信<code>send_id</code>が追跡されていない場合を除き、そのキャンペーンからユーザーが受信した最後の追跡に帰属します。
    field: "send_id"
  - name: トリガープロパティ
    description: "APIトリガ配信でキャンペーンを送信するためにエンドポイントの1つを使用する場合、キーと値のマップを提供してメッセージをカスタマイズできます。にオブジェクトを含む API リクエストを作成すると<code>\"trigger_properties\"</code>、そのオブジェクトの値は名前<code>api_trigger_properties</code>空間のメッセージテンプレートで参照できます。<br>
 <br>
 たとえば、リクエストでは、<code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code>を追加することでメッセージに語\"�\"��シューズを追加できます<code>{{api_trigger_properties.${product_name}}}</code>。"
    field: "trigger_properties"
  - name: キャンバス入力プロパティ
    description: "APIを介してCanvasをトリガーまたはスケジュールするためにエンドポイントの1つを使用する場合、<code>\"canvas_entry_properties\"</code>名前空間で、Canvasの最初のステップによって送信されたメッセージをカスタマイズするためのキーと値のマップを提供することができます。<br>
 <br>
 たとえば、リクエストによって、<code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code>を追加することでメッセージに\"語�\"��シューズを追加できます<code>{{canvas_entry_properties.${product_name}}}</code>。"
    field: "canvas_entry_properties"
  - name: ブロードキャスト
    description: "APIエンドポイントを使用してセグメントまたはキャンペーンオーディエンスにメッセージを送信する場合、Brazeでは、APIコールに\"ブール値を含めることによって、メッセージが大規模なユーザーグループへの\"ブロードキャスト<code>broadcast</code>であるかどうかを明示的に定義する必要があります。つまり、キャンペーンまたはキャンバスがターゲットとするセグメント全体にAPIメッセージを送信する場合は、APIコール<code>broadcast: true</code>に含める必要があります。<br>
<br>
ブロードキャストは必須フィールドで、キャンペーンまたはキャンバスの作成時にBrazeによって設定されるデフォルト値はです<code>broadcast: false</code>。<code>broadcast: true</code> と<code>recipients</code>のリストの両方を指定することはできません。<code>broadcast</code> フラグがtrueに設定され、受信者の明示的なリストが指定されている場合、APIエンドポイントはエラーを返します。同様に、受信者リストを含め<code>broadcast: false</code>、提供しない場合もエラーが返されます。
    
    <br>
<br>
このフラグを誤って設定すると<code>broadcast: true</code>、キャンペーンやCanvasを予想よりも大きなオーディエンスに送信する可能性があるため、を設定するときは注意してください。<code>broadcast</code> フラグは、大量のユーザーグループへの偶発的な送信から保護するために必要です。"
    field: "broadcast"
    
---
