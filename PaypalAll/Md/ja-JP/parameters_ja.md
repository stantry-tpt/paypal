---
page_order: 2.4
nav_title: パラメーター
article_title: APIパラメータ
layout: glossary_page
glossary_top_header: "パラメーター"
glossary_top_text: "これらのパラメータを使用して、APIリクエストを定義します。必要なパラメータはエンドポイントの下にリスト表示されますが、これにより、その機能やその他の機能に関する分析情報が得られる必要があります。"

description: "この変更は、APIリクエストの作成に必要なパラメータについて詳細に説明しています。" 
page_type: glossary

glossaries:
  - name: アプリグループ REST APIキー
    description: これは <code>api_key</code> 、このリクエストのデータが関連付けられているアプリのタイトルを示し、アプリにメッセージを送信許可されているユーザーとしてリクエスト者を認証します。すべてのリクエストに、HTTP承認ヘッダーとして含まれている必要があります。これは、アプリアプリダッシュボードの <strong>デベロッパー</strong> セクションにアクセスできます。
    field: "api_key"
  - name: アプリID
    description: 一連の端末トークン(ユーザーの代わりに)にプッシュを送信する場合は、メッセージングしている特定のアプリを代表して指定する必要があります。この場合、トークンオブジェクトで適切なアプリIDを提供します。これは、アプリアプリダッシュボードの <strong>デベロッパー</strong> セクションにアクセスできます。
    field: "app_id"
  - name: 外部ユーザーID
    description: 特定のユーザーにメッセージを送信する一意の識別子。この識別子は、1000-1944-1944-1994-199、1994-199、1994-19 SDKまたはユーザーAPIを通じてすでに識別されているメッセージングのユーザーのみを対象とすることができます。リクエストでは最大50人の外部ユーザーDが許可されています。<br>
 <br>
 キャンペーントリガーのエンドポイントの場合、このフィールドを提供する場合、基準はキャンペーンのセグメントのレイヤーに重ねされ、外部ユーザー ID のリストに表示され、キャンペーンのセグメントにメッセージが表示されるユーザーのみです。
    field: "external_user_ids"
  - name: セグメントID
    description: メッセージ <code>segment_id</code> を送信するセグメントを示しています。お客様が作成した各<strong></strong>セグメントのセグメントIDは、デベロッパーダッシュボードのセクションに表示されます。<br>
 <br>
 メッセージエンドポイントの場合、1回のメッセージリクエストでセグメントIDと外部ユーザーIDのリストを提供した場合、基準はレイヤーされ、外部ユーザーIDのリストに表示され、指定されたセグメントに対するユーザーのみメッセージを受信します。
    field: "segment_id"
  - name: キャンペーンID
    description: メッセージングエンドポイントの場合、 <code>campaign_id</code> メッセージの分析を追跡する必要があるAPIキャンペーンを示しています。作成した各キャンペーンの<strong></strong>キャンペーンIDは、デベロッパーのダッシュボードのセクションに表示されます。リクエスト本文にキャンペーンIDを提供 <code>message_variation_id</code> する場合、お客様のキャンペーンの一部が表示されたことを示す、メッセージの各項目に、キャンペーンIDを提供する必要があります。<br>
 <br>
 キャンペーントリガーのエンドポイントの場合、トリガー <code>campaign_id</code> されるキャンペーンのAPI IDが示されます。このフィールドは、すべてのトリガーエンドポイントリクエストで必要です。
    field: "campaign_id"
  - name: 識別子
    description: トリガーするエンドポイントの場合、 <code>canvas_id</code> トリガーまたはスケジュールを設定する機能の識別子が示されます。このフィールドは、すべてのトリガーエンドポイントリクエストで必要です。
    field: "canvas_id"
  - name: 識別子の送信
    description: メッセージングエンドポイントの場合、メッセージ <code>send_id</code> の分析を追跡する必要がある送信下のアドレスを示しています。これにより <code>send_id</code> 、エンドポイント経由で送信されたキャンペーンの特定のインスタンスに関する分析を引き戻 <code>sends/data_series</code> すすることができます。ブロードキャストとして送信されたAPIおよびAPIトリガーキャンペーンは、送信IDが提供されない場合は、送信IDを自動的に生成します。<br>
 <br>
 自分で指定する場合 <code>send_id</code>は、最初にエンドポイントを介して作成する必要 <code>sends/id/create</code> があります。入力 <code>send_id</code> できる文字はASCII文字すべてで、長は64文字以上でなければなりません。複数の送信で同じキャンペーンの複数の送信に対して送信IDを再利用できます。それらの分析情報をまとめてグループ分析を行う場合は、それらの情報をまとめて送信する必要があります。<br>
 <br>
 <code>send_id</code> Mailjet経由で送信されたメールでは追跡は利用できません。ご注意ください。<br>
 <br>
 キャンペーンのコンバージョンは、最後 <code>send_id</code> に受け取ったユーザーの追跡が行方法でない限り、そのキャンペーンで受け取った最後の追跡に基決されています。
    field: "send_id"
  - name: トリガーのプロパティ
    description: "APIトリガー配達でキャンペーンを送信するためにエンドポイントのいずれかを使用する場合、キーと値の地図を提供して、メッセージをカスタマイズすることができます。オブジェクトを含む <code>\"trigger_properties\"</code>APIリクエストを実行すると、そのオブジェクトの値を、そのオブジェクトの下のメッセージテンプレートで参照 <code>api_trigger_properties</code> することができます。<br>
 <br>
 たとえば、リクエストを追加して<code>\"trigger_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code>メッセージに靴を\"\"追加することができます<code>{{api_trigger_properties.${product_name}}}</code>。"
    field: "trigger_properties"
  - name: 項目入力のプロパティ
    description: "API <code>\"canvas_entry_properties\"</code> 経由でアプリ内のエンドポイントをトリガーまたはスケジュールする際に、アプリ内の最初のステップで送信されたメッセージをカスタマイズするためにキーと値の地図を提供することができます。<br>
 <br>
 たとえば、リクエストを追加して<code>\"canvas_entry_properties\" : {\"product_name\" : \"shoes\", \"product_price\" : 79.99}</code>、単語靴\"\"をメッセージに追加することができます<code>{{canvas_entry_properties.${product_name}}}</code>。"
    field: "canvas_entry_properties"
  - name: 放送
    description: "APIエンドポイントを使用してセグメントやキャンペーンのオーディエンスにメッセージを送信する場合、一\"\"<code>broadcast</code>部のユーザーにAPIコールを含めて、メッセージが大きなグループに配信されるかどうかを明示的に定義する必要があります。つまり、キャンペーンまたは「ターゲットを設定」するセグメント全体にAPIメッセージを送信する予定がある場合は、API <code>broadcast: true</code> コールに含める必要があります。<br>
<br>
ブロードキャストは必須フィールドであり、キャンペーンまたはファイル名が入力された場合に、そのデフォルト値が「変更後」によって設定されます <code>broadcast: false</code>。指定されたリストと両方を <code>broadcast: true</code> 持つご自分の <code>recipients</code> 名前は使用できます。フラグが <code>broadcast</code> true に設定され、明示的な受取人リストが提供されている場合、APIエンドポイントはエラーを返します。同様に、受取 <code>broadcast: false</code> 人リストを提供していない場合は、エラーが戻されます。
    
    <br>
<br>
意図せずこのフラグ <code>broadcast: true</code>を設定する場合は、注意を払う必要があります。このフラグを設定すると、キャンペーンやデータを予想よりも大きなオーディエンスに送る可能性があります。このフラグ <code>broadcast</code> は、間違って送信されたユーザーから保護するために必要です。"
    field: "broadcast"
    
---
