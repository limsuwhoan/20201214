<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<% 
String name = request.getParameter("name");
int age = Integer.parseInt(request.getParameter("age"));
if (age>=20){
	out.println("<h2>"+name +"</h>님은 성인입니다.");
}
else{
	out.println("<h2>"+name+"</h2>님은 미성년자입니다");
}

%>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

</body>
</html>