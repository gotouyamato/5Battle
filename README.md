# 5Battle

## 概要
1～5の数字と人間、悪魔、天使の3つの職業を組み合わせたシンプルな心理カードバトルゲーム<br>
出したカードの数字の大きさや、職業の相性によって勝敗が決まります

## 機能
* **カードプレイ:** 手持ちのカードを場に出したり、場から手札に戻したりでき、決定ボタンで決定
* **ターン進行:** 次のターンへ進むボタンを押すと、場の初期化や勝敗結果が表示される
* **勝敗判定:** 出したカードの数字と職業の組み合わせによって勝敗を判定する
* **ルール説明:** ゲーム内の？ボタンでルールを表記

## 技術スタック
* **ゲームエンジン:** Unity
* **プログラミング言語:** C#

## 各スクリプトの役割
* **BattleScript.cs:** メインの勝敗判定処理
* **CardScript.cs:** カードの出し入れ処理
* **DecisionScript.cs:** 決定ボタンの処理
* **EndScript.cs:** エンディング画面の処理
* **NextTurnButtonScript.cs:** 次のターンへ進む際の処理
* **RuleScript.cs:** ルール説明を表示する処理
* **TitleButtonScript.cs:** タイトルボタンを押す処理
