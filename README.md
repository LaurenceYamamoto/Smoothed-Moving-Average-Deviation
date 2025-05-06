# Smoothed Moving Average Deviation

このインジケーターは、移動平均線からの価格の偏差を滑らかにしたものを表示します。

## 特徴

- 価格を移動平均で割った相対的な偏差を計算
- 偏差を指定した方法で平滑化
- 多様な移動平均タイプをサポート（シンプル、指数、二重指数など）

## パラメーター

- **Moving Average Period**: 移動平均の期間（デフォルト: 120）
- **Moving Average Type**: 移動平均のタイプ（デフォルト: Simple）
- **Smooth Period**: 平滑化期間（デフォルト: 6）
- **Smooth Method**: 平滑化方法（デフォルト: DoubleExponential）

## インストール方法

1. このリポジトリをクローンまたはダウンロードします
2. cAlgoのIndicatorsフォルダにファイルをコピーします
3. cTraderを再起動します

## ライセンス

このプロジェクトはBSD 3-Clause Licenseの下でライセンスされています - 詳細は[LICENSE](LICENSE)ファイルを参照してください。