## 云平台短信验证码通知短信java/php/.net开发实现

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![GitHub stars]()]()
[![GitHub forks]()]()

## 项目初衷

* 主要提供学习便利，方便初学者学习简单的http接口对接实现
* 由于各大短信通道服务商API参数基本相同，本Demo可以适当减少开发者对接短信通道接口的开发成本，提供参考
* 推荐阿里云、其他实惠优质的短信通道服务商给有需要的朋友

## Demo

* [Java - maven]()
* [Java - jar]()
* [Php]()
* [.Net]()

## 接口简述

* 请求方式

```
HTTP - GET
```

* 请求代码
``` uri
https://{{url}}?appKey={{app_key}}&appSecret={{app_secret}}&phones={{mobile}}&content=【{{sign}}】{{content}}
```

* 返回值
``` json
{"errorCode":"000000","errorMsg":"提交成功"}
```
``` xml
<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<xml>
    <errorCode>000000</errorCode>
    <errorMsg>提交成功</errorMsg>
</xml>
```

## 注意事项

* 请求参数 app_key, app_secret 均未填值，以防被恶意刷量
* 若有需要可找到本文档下方作者联系方式

## 优质短信通道推荐

### 阿里云短信

* 三大运营商的资深战略合作伙伴
* 服务于阿里巴巴、支付宝、天猫等知名平台
* 全球市场、技术权威、系统稳定

首充金额（元） | 单价（元） | 短信数量（条）| 活动优惠
----|----|----|----
￥225 | 0.045 | 5000 | 双十一
￥2000 | 0.04 | 50000 | 双十一
￥19000 | 0.038 | 500000 | 双十一
￥37000 | 0.037 | 1000000 | 双十一

### 某信云短信

* 三大运营商的资深战略合作伙伴
* 服务于网易、58、中石化等知名平台
* 5秒必达、系统稳定、价格实惠

首充金额（元） | 单价（元） | 短信数量（条） | 活动优惠
----|----|----|----
￥500 | 0.04 | 12500 | 首充红包
￥1000 | 0.05 | 28572 | 首充红包
￥2000 | 0.03 | 66667 | 首充红包
> ￥2000 | < 0.03 | ++++ | 首充红包


## 更多资源
![](./img/wx.jpg)

## My Blog
[blog.guijianpan.com](http://blog.guijianpan.com "倚楼听风雨")





