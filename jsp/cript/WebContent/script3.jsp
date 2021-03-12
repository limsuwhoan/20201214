<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%--
    	.선언문:<%! %>-전역변수 선언, 메소드 선언
    스크립트플릿(scriptlet):<% %> -지역변수 , 일반루틴
    표현식(expression) : <%= %> - 화면출력 (변수,메소드 호출)
     --%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
String str2 ="홍길동"
;
%>
	<%!
		String str ="전역 변수";
	%>
	<%!
	String getStr() {
	return str;
   	}
	%>
	<!-- HTML주석
	<h1>전역변수:<%=str  %></h1>
	 -->
	 <%-- JSP 주석 
	<h2>메소드 호출:<%=getStr() %></h2> 
	--%>
	<h1><%=str2 %></h1>
</body>
</html>