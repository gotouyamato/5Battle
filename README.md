# 5Battle

## 概要
1～5の数字と人間、悪魔、天使の3つの職業を組み合わせたシンプルな心理カードバトルゲーム<br>
出したカードの数字の大きさや、職業の相性によって勝敗が決まる

## 製作期間
1か月程度

## 開発環境
* **ゲームエンジン:** Unity
* **プログラミング言語:** C#
* **OS:** Windows

## 製作意図
C#とUnityの学習を目的として、ゼロからゲームを完成させることで、ゲーム開発の基本的な流れを習得することを目指しました。

## サウンド
効果音は効果音ラボ様(https://soundeffect-lab.info)の素材を使用しています。

## 操作方法
* **カード選択:** マウスで場に出したいカードをクリック
* **決定:** 決定ボタンでカードを決定

## ルール説明
1～5の数字を一つずつ選びその数字の大きさで勝敗を決め、先に三勝した方の勝ちとなる。<br>
職業カードはそれぞれに相性があり、有利な場合は出した数字に＋１される。<br>
ただし、悪魔を出して有利になった場合は数字に関係なく勝利する。<br>
相性関係は以下のとおりである。<br>
人間→悪魔　悪魔→天使　天使→人間

## 各スクリプトの役割
* **BattleScript.cs:** メインの勝敗判定処理
* **CardScript.cs:** カードの出し入れ処理
* **DecisionScript.cs:** 決定ボタンの処理
* **EndScript.cs:** エンディング画面の処理
* **NextTurnButtonScript.cs:** 次のターンへ進む際の処理
* **RuleScript.cs:** ルール説明を表示する処理
* **TitleButtonScript.cs:** タイトルボタンを押す処理
