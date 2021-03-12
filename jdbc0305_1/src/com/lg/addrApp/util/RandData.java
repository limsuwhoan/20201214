package com.lg.addrApp.util;

import java.util.Random;

import com.lg.addrApp.model.AddrBook;

public class RandData {
	static String[] name = {
		"홍길동", "김길동", "박길동",
		"최길동", "이길동"};
	static int[] age = {100, 200, 300, 400, 500};
	static String[] tel = {"010-1111-1111",
		"010-2222-2222", "010-3333-3333",
		"010-4444-4444", "010-5555-5555"};
	static String[] address = {"대구 동구 신천동",
		"서울 동구 신천동", "인천 동구 신천동",
		"부산 동구 신천동", "대전 동구 신천동"};
	static String[] email = {"hong@naver.com",
		"lee@naver.com", "hong@kakao.com",
		"park@gmail.com", "choi@daum.net"};
	
	Random r = new Random();
	
	public String getRName() {
		return name[r.nextInt(5)];
	}
	
	public int getRAge() {
		return age[r.nextInt(5)];
	}
	
	public String getRTel() {
		return tel[r.nextInt(5)];
	}
	
	public String getRAddr() {
		return address[r.nextInt(5)];
	}
	
	public String getREmail() {
		return email[r.nextInt(5)];
	}
	
	public AddrBook getABook() {
		return new AddrBook(
				getRName(),
				getRAge(),
				getRTel(),
				getRAddr(),
				getREmail());
	}
}
