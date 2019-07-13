<?php
        $host = "https://api.zhuanxinyun.com/api/v2/sendSms.json";
		$sign = "【签名】";
		$app_key = "app_key";
		$app_secret = "app_secret";
		$code = "6666";
		$phones = "18088888888";
        $content = "本次验证码是".code."，如非本人操作请忽略。";
		$uri = $host."?appKey=".$app_key."&appSecret=".$app_secret."&phones=".$phones."&content=".$sign.$content;
		$ch = curl_init();
		$timeout = 5;
		curl_setopt($ch, CURLOPT_URL, $url);
		curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
		curl_setopt($ch, CURLOPT_CONNECTTIMEOUT, $timeout);
		$contents = curl_exec($ch);
		curl_close($ch);
		var_dump($contents);//输入返回内容
?>