# Contribute
下記にコーディングにおいての記述ルールや、開発における案内などをまとめておきます。  

# TOC
- [Commit Rules](#cor)
  - [Rule.01 - .metaファイルについて](#cor-01)
- [Coding Rules](#cr)
  - [Rule.01 - 最低限はコーディング規約に従うこと](#cr-01)
  - [Rule.02 - 自分で書いたコードは、自分でしっかり確認すること](#cr-02)
  - [Rule.03 - コメントの付けすぎに気をつけること](#cr-03)
  - [Rule.04 - 適度に空行を追加し、コードを読みやすくすること](#cr-04)
- [How To Development](#htd)
  - [タスク管理ツールについて](#htd-01)
  - [作業を始める前に](#htd-02)
  - [開発に必要なツールのセットアップ](#htd-03)
  	- [Unity](#htd-03-01)
    - [Visual Studio](#htd-03-02)
    - [GitHub Desktop](#htd-03-02)

<a id="cor"></a>
# Commit Rules
コミットにおけるルールに関しましては未だ未確定な要素もありますので、  
**今後、更新及び拡充する可能性があります**。予めご了承いただきますようお願いいたします。

<a id="cor-01"></a>
## .metaファイルについて
.metaファイルは、Assetの設定などを保存するファイルです。  
ゲーム開発中に意図せず設定が頻繁に変更されると、**混乱を招くことにもなりかねます**ので、  
以下のケース以外では、.metaファイルをコミットすることは**絶対にしないように**お願いします。

- 新規のファイル(クラスファイルやリソースファイルなど)を作成したとき
- 特定のファイルをリネームしたとき
- 特定のファイルが存在するディレクトリを変更したとき

>アセットの内部処理 - Unity マニュアル  
https://docs.unity3d.com/ja/2018.1/Manual/BehindtheScenes.html

<a id="cr"></a>
# Coding Rules
コーディングにおけるルールに関しましては未だ未確定な要素もありますので、  
**今後、更新及び拡充する可能性があります**。予めご了承いただきますようお願いいたします。

<a id="cr-01"></a>
## 最低限はコーディング規約に従うこと
基本的にマイクロソフト社が提供する、**C#のコーディング規約に従って開発を進めてください。**  
ある程度のオリジナリティは基本OKとしていますが、コーディング規約からは大きく逸脱しないよう心がけましょう。

>[C# のコーディング規則 (C# プログラミング ガイド)](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

<a id="cr-02"></a>
## 自分で書いたコードは、自分でしっかり確認すること
本プロジェクトでは**共同で開発していく**という大前提を**必ず忘れないようにしてください。**  
その上で、変更を加えたコードを提出する前に、**以下の二つ**を**必ず確認するようにしましょう。**

1. 動作検証を**しっかり**と行ったか。
2. **検証後にコードを書き換えていない**か。

作業した自分が確認や検証作業を怠ると、他メンバーの確認が必要になったり、後のバグに繋がることもあります。  
**責任を持って**十分に確認、検証作業を行い、**他メンバーに迷惑をかけないように心がけましょう。**

<a id="cr-03"></a>
## コメントの付けすぎに気をつけること
コメントはときに処理の詳しい説明や、メモなどの用途に役立ちますが、  
逆に付けすぎると可読性を低下させてしまいます。  
もちろんコメントは重要なものではありますが、GitHubやDiscordもありますので、そちらの方も活用しましょう。

また、フィールド変数やメソッドを定義する際につけるコメントを**summaryタグ**で  
囲むと、コメントの確認が容易になります。  
詳しくは[こちら](https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/xmldoc/summary)をご参照ください。

**・ 良い例 ・**

```c#
/// <summary>
/// オブジェクトが地面と接触しているかどうかを返します
/// </summary>
private bool isOnGround = true;
```
```c#
/// <summary>オブジェクトを地面と接触していない判定にする</summary>
isOnGround = false;
```

**・ 悪い例 ・**  
コメントはなるべく短く、わかりやすくが基本です。  
また、コメントにおける状況説明などは基本必要ありません。  
冗長な文も避けましょう。
```c#
/// <summary>
/// オブジェクトが地面と接触しているかどうかを返します
/// また、地面は平面です。
/// 斜面はありません。
/// また、...(以下、数行に渡ってコメントが続く)
/// </summary>
private bool isOnGround = true;
```

<a id="cr-04"></a>
## 適度に空行を追加し、コードを読みやすくすること  
空行がなく、びっしり詰まったようなコードは、可読性を**著しく低下**させます。  
そのため、適度に空行を追加し、なるべくコードの可読性をあげるように心がけましょう。

それとは別に、以下のように、必ず空行を追加しなくてはならない箇所もあります。  
- 名前空間(using)を定義している最終行の後
- 各メソッドの間
- 各フィールド変数の間
- プロパティの間
- 最後の行の後 (EOF)

**・ 良い例 ・**
```c#
using System;

public class Hello
{
  public static void Main()　
  {
    Say("Hello");
  }

  private void Say(string hello)
  {
    isHello = (hello.Equals("Hello") ? true : false);

    // 引数helloが"Hello"と同値ならば「Hello World」と出力する
    if(isHello)
    {
      Console.WriteLine("Hello World");
      return;
    }

    Console.WriteLine("hoge");
  }
}
```

**・ 悪い例 ・**  
一見、コンパクトなコードのようには見えますが、可読性は**十分に低い**です。  
これほど短いコードならまだしも、**100行を超えるコーディング**も予期されますので、  
必ず空行を追加し、可読性を上げることを習慣づけましょう。
```c#
using System;
public class Hello
{
  public static void Main()　
  {
    Say("Hello");
  }
  private void Say(string hello)
  {
    isHello = (hello.Equals("Hello") ? true : false);
    // 引数helloが"Hello"と同値ならば「Hello World」と出力する
    if(isHello)
    {
      Console.WriteLine("Hello World");
      return;
    }
    Console.WriteLine("hoge");
  }
}
```

<a id="htd"></a>
# How To Development

<a id="htd-01"></a>
## タスク管理ツールについて
プログラム班では、[Trello](https://trello.com/)を使用してタスク管理を行います。  
下記のリンクがTrelloの招待リンクとなりますので、**関連スタッフの方は必ず入るようにお願いいたします**。

また、**トレロのチームの割り振り**は参加後連絡してもらえれば、**すかぽんがチームメンバーの設定を行う**ので、今後チーム用のボードが増えてもこちらの更新前に早めに見れるようになるので**参加後のご連絡**の方も宜しくお願いします。

というわけで、トレロのチーム設定の方もしておきました。
> https://trello.com/invite/b/OumYwUQJ/82cbb7bc40bf0a5e937a02a20c7edfaf/%E9%96%8B%E7%99%BA

> https://trello.com/invite/b/BtFl3LjB/0f09f2038510000c97318c1b651153b2/%E9%BB%84%E6%B3%89%E6%A1%9C%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E4%BC%81%E7%94%BB%E7%94%A8%E6%A7%8B%E6%83%B3%E5%9B%BA%E3%82%81%E7%94%A8

<a id="htd-02"></a>

## 作業を始める前に
コーディングを開始する前に、以下のステップを済ませておきましょう。  
1. [Trelloのプロジェクトに参加する](https://trello.com/invite/b/OumYwUQJ/82cbb7bc40bf0a5e937a02a20c7edfaf/%E9%96%8B%E7%99%BA)
2. Trelloのプロジェクトに参加した旨を、Discordでプログラム班のチーフに伝える
3. YomizakraProjectのフォークプロジェクトを作成する

<a id="htd-03"></a>
## 開発に必要なツールのセットアップ
インストールに関しての説明は省かせていただきます。  
恐れ入りますが、不明点などは各自で調べてセットアップにあたってもらえると助かります。  
簡単な質問でしたらDiscord上で質問していただければ、手すきのスタッフが回答にあたります。

<a id="htd-03-01"></a>
### 1. Unity
本プロジェクトでは、Unity上で開発を進めています。  
当然ながら、Unityがなければ開発もデバッグも出来ませんので、必ず導入しておきましょう。  

> [Download-Unity](https://unity3d.com/jp/get-unity/download)

Unity Hubのセットアップ後、バージョン**2019.1.0f2**をダウンロードしてください。  
互換性によっては、開発中データの挙動がおかしくなる可能性があります。

<a id="htd-03-02"></a>
### 2. Visual Studio
Visual Studioは、マイクロソフト社が開発・提供する統合開発環境(IDE)です。  
本プロジェクトでは主にC#でコードを書いていきます。  
Visual Studioを導入しておくと、C#での開発がスムーズに進められます。

> [Visual Studio のインストール | Microsoft Docs](https://docs.microsoft.com/ja-jp/visualstudio/install/install-visual-studio?view=vs-2019)

<a id="htd-03-03"></a>
### 3. GitHub Desktop
GitHub Desktopは、GitHub用に設計されたクライアントです。  
あくまで推奨しているソフトウェアですので、他に便利なクライアントがありましたら、  
そちらの方を使用していただいても構いません。  

> [GitHub Desktop | Simple collaboration from your desktop](https://desktop.github.com/)















