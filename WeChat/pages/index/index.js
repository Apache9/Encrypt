var md5 = require('../../utils/md5.js')
var aes = require('../../utils/aes.js')

//index.js
//获取应用实例
var app = getApp()
Page({
  data: {
    encrypted: '',
    password: '',
    decrypted: ''
  },
  parseHexString: function (str) {
    var result = [];
    while (str.length >= 2) {
      result.push(parseInt(str.substring(0, 2), 16));
      str = str.substring(2, str.length);
    }
    return result;
  },
  toByte: function (c) {
    if (c >= 65 && c <= 90) {
      return c - 65;
    }
    if (c >= 97 && c <= 122) {
      return c - 97 + 26;
    }
    if (c >= 48 && c <= 57) {
      return c - 48 + 52;
    }
    if (c == 43) {
      return 62;
    }
    if (c == 47) {
      return 63;
    }
    return 0;
  },
  base64DecodeToArray: function (str) {
    var arr = [];
    for (var i = 0; i < str.length / 4; i++) {
      var c0 = this.toByte(str.charCodeAt(4 * i));
      var c1 = this.toByte(str.charCodeAt(4 * i + 1));
      var c2 = this.toByte(str.charCodeAt(4 * i + 2));
      var c3 = this.toByte(str.charCodeAt(4 * i + 3));
      arr.push((c0 << 2) | (c1 >> 4));
      arr.push(((c1 << 4) & 0xFF) | (c2 >> 2));
      arr.push(((c2 << 6) & 0xFF) | c3);
    }
    if (str.charAt(str.length - 1) == '=') {
      arr.pop();
      if (str.charAt(str.length - 2) == '=') {
        arr.pop();
      }
    }
    return arr;
  },
  //事件处理函数
  bindEncryptedInput: function(e) {
    this.setData({
      encrypted : e.detail.value
    });
  },
  bindPasswordInput: function(e) {
    this.setData({
      password: e.detail.value
    });
  },
  bindDecrypt: function(e) {
    var encryptedData = this.base64DecodeToArray(this.data.encrypted);
    var key = this.parseHexString(md5(this.data.password));
    var aesCbc = new aes.ModeOfOperation.cbc(key, key);
    var decryptedBytes = aesCbc.decrypt(encryptedData);
    var decryptedText = aes.utils.utf8.fromBytes(aes.padding.pkcs7.strip(decryptedBytes));
    this.setData({
      decrypted: decryptedText
    });
  },
  onLoad: function () {
    console.log('onLoad')
  }
})
