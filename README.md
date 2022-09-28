# Unity_GoogleSignIn-Demo 
 
✴️ 搭配 [haowenjhang/GoogleSignIn](https://github.com/haowenjhang/GoogleSignIn "游標顯示") 服用
* Unity 2020.3.2.1
* Google 登入 / 登出 / 取得使用者資訊

### - 重點整理 
1. Add Android Studio build 出來的 `aar` ex. `GoogleSignIn_lib-release` in Plugins / Android
2. 注意 Publishing Setting 裡的設定
3. 注意 Plugins / Android 裡的文件設定
4. Create Keystore and Get `SHA-1` Key 


### - How to get SHA-1 Key
`keytool -list -v -keystore keyStoreName.keystore`




### - 申請憑證
用戶端編號 (Client ID)

![截圖 2022-09-28 13 58 32](https://user-images.githubusercontent.com/30752142/192701098-115d24de-f0c6-4ae8-80b5-61a8adfbf67f.png)
