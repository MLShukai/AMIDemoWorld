# AMIDemoWorld

バーチャル学会 2023 のデモワールドです。

## Project Setup

### Prerequirements

- Git
- Git LFS
- VRChat Creator Companion (VCC)
- Unity 2019 4.31f1

### プロジェクト開く手順

1. このリポジトリをcloneする。
2. レポジトリのルートディレクトリで`git-lfs install`でGitLFSを有効化
3. VRChatCreatorCompanion(VCC)の`Add Existing Project`から追加
4. `Manage Project`から `VRChat SDK - Worlds`のバージョン **3.4.0** を選択し、インストール
5. VCCからプロジェクトを開く。

### 外部依存関係

BOOTHで無料配布されているアセットの入手および導入の方法を記述します。再配布を禁止しているアセットが大半占めるためです。

## ルール

プロジェクトを破壊せず、安全に開発するためのルールです。ここに書いてあることは厳守してください。

1. シーンファイルの編集する人は必ず一人とする。
2. BOOTHの配布アセットを導入した際は `.gitignore`にフォルダを追記し、READMEの `外部依存関係` セクションに入手、導入方法を追記する。
3. 変更は必ずブランチを分けて行い、プルリクエストを用いてメインブランチにマージする。
4. **有料アセットは用いない**
