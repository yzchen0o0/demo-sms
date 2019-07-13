package com.guijianpan.sms;

import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;

/**
 * 短信发送工具类
 * 
 * <p>
 * 		本代码为Maven结构，http接口请求依赖 okhttp-3.14.2.jar 
 *</p>
 * 
 * @author yzChen(WXID:ThrowNullPoint)  2019-7-9 10:07:28
 */
public class SmsUtil {
	
	private static final String SIGN = "【签名】";
	private static final String HOST = "https://api.zhuanxinyun.com/api/v2/sendSms.json";
	private static final String APP_KEY = "APP_KEY";
	private static final String APP_SECRET = "APP_SECRET";

	/**
	 * 测试
	 * @param args
	 */
	public static void main(String[] args) {
		String mobile = "18566775162";
		String code = "666666";
		String body = sendSmsCode(mobile, code);
		System.out.println(body);
	}
	
	/**
	 * 发送短信验证码
	 * @param mobile		接收手机号
	 * @param code			验证码
	 */
	public static String sendSmsCode(String mobile, String code) {
		StringBuffer content = new StringBuffer().append("您的验证码是" ).append(code).append("，请勿泄露验证码！");
		return sendSms(mobile, content.toString());
	}
	
	/**
	 * 发送短信信息
	 * @param mobile		接收手机号
	 * @param content		短信内容
	 */
	public static String sendSms(String mobile, String content) {
		StringBuffer url = new StringBuffer().append(HOST).append("?appKey=").append(APP_KEY).append("&appSecret=")
				.append(APP_SECRET).append("&phones=").append(mobile).append("&content=").append(SIGN).append(content);

		Request request = new Request.Builder().url(url.toString()).get().build();
		OkHttpClient client = new OkHttpClient();
		try {
			Response response = client.newCall(request).execute();
			return response.body().string();
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		return null;
	}

}
