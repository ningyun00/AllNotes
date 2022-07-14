# java

## 一	程序入门

### JDK的安装环境变量的配置

1. ###### jdk官网下载：[java JDK 下载地址](https://www.oracle.com/java/technologies/downloads/#java18)。

2. 环境变量的配置：

   1. 系统变量中创建（变量名：CLASS_PATH	变量值：.;%JAVA_HOME%\bin;%JAVA_HOME%\jre\bin;）。
   2. 系统变量中创建（变量名：JAVA_HOME	变量值：%JAVA_HOME<!--jdk版本号-->%）。
   3. 系统变量中创建（变量名：JAVA_HOME<!--JDK版本号--> 变量值：安装在c盘的jdk目录C:\Program Files\Java\jdk1.8.0_66）。
   4. 在系统变量中编辑path变量（变量值增加：%JAVA_HOME%\bin、%JAVA_HOME%\jre\bin）。
   5. 在用户变量中添加（变量名：JAVA_HOME   变量值：安装在c盘的jdk目录C:\Program Files\Java\jdk1.8.0_66）。
   6. 打开cmd运行窗口执行 java -version出现版本号及配置完成
	
3. cmd执行java：javac 文件名.java 将java文件编译成class文件 在java 文件名即可执行

4. java主方法的框架：	

   ```java
   public class 类名{
       public static void main(String[]args){
           //程序的主入口
           System.out.print("你好 寜");
       }
   }
   
   ```
   

### 单词

```java
//public 公共的、class 类、static 静态、void 无返回、main 主要的、String 字符串类型、args 数组、System 系统、out 输出、print 打印
```



------



## 二 变量与运算符

### 变量

1. 数据类型：（引用类型：floot、double、int、String、char。包装类：Float、Double、Integer、String、Character）
2. 储存媒介：1Tb = 1024Gb 1Gb = 1024mb 1mb = 1024kb 1kb = 1024b

### 运算符

1. 算数运算符：”+“、”-“、”*“、”/“、"%模"、"+拼接"

2. 变量++ 先自己加在计算其它的。++变量先计算其它的在计算自己。

3. 关系运算符：>大于、<小于、>=大于等于、<=小于等于、!=不等于、==等于。

4. 赋值："变量名" = 内容

    ```java
    public static void main(String[] args) {
    	int A;//声名
        A = 0;//赋值
        int B = 1;//声明并赋值
    }
    ```

### 单词

```java
//int 整型、floot 浮点、double 双精度、char 单字符、String 字符串、
```



------



## 三 数据类型转换与键盘录入

#### 数据类型转换：

1. 自动转换：由小范围转到大范围

    ```java
    int A = 100; double B = A;//A=100/B=100;
    ```

2. 强制转换：由大范围到小范围

    ```java
    double B = 1.2;int A = (int) B;//B=1.2/A=1;
    ```

3. 包装类型数据转换：

    ```java
    Integer A  = 10;//A=10
    Double B = Double.valueOf(A);//B=10.0
    Double A = 1111.001;//A=1111.001
    Integer B = Integer.valueOf(A.intValue());//B=1111
    ```

#### 键盘录入：

1. 导入包

    ```java
    import java.util.Scanner;//导入包
    ```

2. 创建对象

    ```java
    Scanner scanner = new Scanner(System.in);//创建对象
    ```

3. 接收数据：以下常用类型

    ```java
    scanner.next();//接收字符串类型
    scanner.nextInt();//接收整数类型
    scanner.nextFloat();//接收浮点数类型
    scanner.nextDouble();//接收小数类型
    ```

4. 使用数据

    ```java
    System.out.println(scanner.next());//使用数据
    ```

### 单词

```java
//import 导入、util 工具、new 新、Scanner 扫描器、in 在、
```



------



## 四 逻辑关系、逻辑运算符、if语句

#### 逻辑运算符：

​	&&(与)、||(或)、!(非)、&并且

#### 逻辑关系：

```java
true && true => true  ---  true && false => false
true || true => true  ---  true || false => true
!true => false        ---  !false => true
true & false => false ---  true & true => true 
true|true => true     ---  true|false => true
```

#### if和if-else语句：

```java
//if(true){才能进大括号}
if(1 + 1 == 2){//true
	System.out.println(1 + 1 == 2);//true
}
//if(false){}else{if为false进这个大括号}
if(1 + 1 != 2){//false
    	System.out.println(1 + 1 == 2);//true
}else{
    	System.out.println(1 + 1 != 2);//false
}
```

#### 三目运算符：比较条件 ? true : false

```java
System.out.println(1 + 1 == 2 ? true : false);//true
```

#### equals()使用：

```java
System.out.println("你好寜".equals("你好寜"));//true
/*要求：拿实际存在的值 比 有可能为空的值*/
```

### 单词

```java
//true 真、false 否、if 如果、else 还、equals 等于
```



------



## 五 swith

```java
String A = "樱";
switch (A) {//多值条件
    case "寜":
        System.out.println(A);
        break;
    case "花":
        System.out.println(A);
        break;
    default://其它值
        System.out.println(A);
        break;
}
```

### 单词

```java
//switch 切换、case 请况、break 结束、default 默认的、
```



------



## 六 猜拳游戏：

```java
public static void main(String[] args) {
//电脑
    Random rd = new Random();//随机数对象
    int dn = rd.nextInt(3) + 1;//1~3
//人
    Scanner sc = new Scanner(System.in);//创建对象
    System.out.print("请出拳（1代表石头，2代表剪刀，3代表布）");
    int ren = sc.nextInt();
  /*分析 1代表石头，2代表剪刀，3代表布
        人		  电脑	  胜负
        1			1		平局
        1			2		人
        1			3		电脑

        2			1		电脑
        2			2		平局
        2			3		人

        3			1		人
        3			2		电脑
        3			3		平局*/
    if (ren > 0 && ren < 4) {//1~3
        if ((ren == 1 && dn == 2) || (ren == 2 && dn == 3) || (ren == 3 && dn == 1){//人赢
            System.out.println("电脑出的：" + dn);
            System.out.println("人赢");
        }else if((ren == 1 && dn == 3)||(ren == 2 && dn == 1)||(ren==3 && dn==2)){//电脑赢
            System.out.println("电脑出的：" + dn);
            System.out.println("电脑赢");
        } else {
            System.out.println("电脑出的：" + dn);
            System.out.println("平局");
        }
    } else {
        System.out.println("你的输入有误！");
    }
}//random 随机
```



------



## 七 while循环

#### 先判断在循环

#### 循环四要素：

1. 循环变量的初始化

2. 循环条件

3. 循环体

4. 循环值的改变

    ```java
    int A = 0;//循环变量初始化
    while(A<=10){//循环条件 条件为true才执行
    	System.out.println(A);//循环体---012345678910
    	A++;//循环变量的改变
    }//while 当...的时候
    ```



------



## 八 do-while循环

```

```



#### 先循环在判断

```java
int A = 0;//循环变量初始化
do{
	System.out.println(A);//循环体---012345678910
    A++;//循环变量的改变
}while(A>=10);//循环条件  条件为true才结束
//do 做、while 而
```



------



## 九 for循环break与continue

### for循环

```java
for (int i = 0;/*循环变量的初始化*/ i < 10;/*循环条件*/ i++/*循环值的改变*/) {
    System.out.print(i);//循环体 0123456789
}
```

### break

```java
for (int i = 0;/*循环变量的初始化*/ i < 10;/*循环条件*/ i++/*循环值的改变*/) {
	if(i==2){
   		break;
   	}
    System.out.print(i);//循环体 01
}//break 结束
```

### continue

```java
for (int i = 0;/*循环变量的初始化*/ i < 10;/*循环条件*/ i++/*循环值的改变*/) {
	if(i==2){
   		continue;
   	}
     System.out.print(i);//循环体 013456789
}//break 结束、continue 跳出本次
```



------



## 十 嵌套循环

```java
//内部循环不结束外部循环无法执行
for (int i = 0; i < 1; i++) {
    while(true){
        break;
    }
}
```



------

## 十一 数组

### 一维数组

#### 创建数组

```java
/**
    * 数据类型需要一致
    * 注意数组长度是否越界、
    */
//创建数组
int [] array = new int ["数组长度"];
//赋值
array[0] = value;
//创建数组并赋值
int [] array = new int [] {1,2,3,4,...}
//jian'ch
int [] array
//有规律的创建数组并赋值
int [] array = new int ["数组长度"];
for(int i = 0; i < array.length; i++){
    array[i] = value;
}
```

#### 数组的使用

```java
/**
	* 以冒泡排序为列：
	*/
int [] array = {3,2,4,7,8}//创建数组
for (int i = 0 ; i < array.length - 1 ; i++) {//0-4
    //循环实现冒泡排序
    for(int j = 0 ; j < arr.length - i - 1 ; j++) {//0-4、0-3、0-2、0-1
        if(arr [j] > arr[j + 1]) {
            int temp = arr[j];
            arr [j] = arr[j+1];
            arr [j+1] = temp;
        }
    }
}
System.out.println(Arrays.toString(arr));//输出结果[2,3,4,7,8]
/**
	* 使用工具包进行升序排列：
	*/
Arrays.sort(array);
for (int i = 0; i < array.length-1; i++) {
    System.out.print(array[i]+"\t");
}
/**
 	* 使用工具包进行降序排列：
	*/
Arrays.sort(arr);
for (int i = arr.length - 1; i >= 0; i--) {
    System.out.print(arr[i] + "\t");
}
```

### 二维数组

#### 创建二维数组

```java
/**
	* 创建二维数组并赋值：
	*/
int[][] arrays = new int[5][5];//数组下标从零开始 数组范围是 [A]*[B]	
arrays[0][0] = 0;
arrays[0][1] = 1;
arrays[0][2] = 2;
arrays[0][3] = 3;
arrays[0][4] = 4;
//遍历
for (int i = 0; i < arrays.length; i++) {//这里零表示一维数组第一层
    for (int j = 0; j < arrays[i].length; j++) {//这里表示arrary[0~4]第一层的长度
        System.out.print(arrays[i][j] + "\t");
    }
}
//遍历
for (int[] array : arrays) {
    for (int i : array) {
        System.out.print(i + "\t");
    }
    System.out.println();
}
```

#### 二维数组理解：

红色区域为二维数组的范围

| [5]*[5] |  0   |  1   |  2   |  3   |  4   |
| :-----: | :--: | :--: | :--: | :--: | :--: |
|    0    | 0~0  | 0~1  | 0~2  | 0~3  | 0~4  |
|    1    | 1~0  | 1~1  | 1~2  | 1~3  | 1~4  |
|    2    | 2~0  | 2~1  | 2~2  | 2~3  | 2~4  |
|    3    | 3~0  | 3~1  | 3~2  | 3~3  | 3~4  |
|    4    | 4~0  | 4~1  | 4~2  | 4~3  | 4~4  |



------



## 十二 类与对象

### 类的定义

类是概念模型、对象是类的实例、对象是具体的实体;(人类)共有特征

对象 (你)：拥有自己的行为、动作、属性；

```java
//创建类
public class 类名 {//类名要求 首字母大小、禁止以数字或符号开头以及关键字、依照驼峰命名法如：OneTest
	int A = 1;    
}
public class 实例化 {
    类名 声明 = new 类名();
	声明.A;//可调用类的公共属性
}
```



------



## 十三 方法

### 方法形式：

```java
public 数据类型 方法名(形参){
    return 数据类型;
} 
```

### 无参（无返）

```java
public void one(){
	//代码块执行。无return
}
```

### 无参（有返）

```java
public int two(){
	return 1;
}
```

### 有参（无返）

```java
public void three(int one,int two,...){//按照需求写
	//执行代码
}
```

### 有参（有返）

```java
public int four(int one,int two){//按照需求写
	//执行代码
	return 1;
}
```



## 十四 字符串的使用

### 创建字符串

```java
//创建字符串对象
String string = new String("one");//可不带参数
//方法：
//1.获取字符串长度
string.length();//返回整数//快速区分length是否带括号看数据类除了能用数字类型的一律不用括号--3
//2.字符串的比较
"one".equals(string);//注意：拥有具体值放前面比较可能有空的值--true
//3.不区分大小写比较
"ONE".equalsIgnoreCase(string);//要求同上--true
//4.转大写
string.toUpperCase();//用要转的数据类型.方法名--ONE
//5.转小写
string.toLowerCase();//同上--one
//6.查找
string.indexOf("n",0);//(要查找的内容,从那里开始截取)--1//可查找单字符、字符串//未找到返回-1
//7.倒序查找
string.lastIndexOf('n',2);//(要查找的内容,从length()到0开始查找);--1//未找到返回-1
//8.去除前后两端的空格
string.timl();
//9.替换
string.replace("n","N");//(修改前,修改后);--oNe
//10.切割
String [] array = string.split("切割条件");//返回数组类型按照输入内容切割
//11.拼接
one.concat("123");//和+拼接一样;--one123
//12.截取
one.substring(1);//(起始范围,结束范围)截取指定位置的字符串--ne
//1
```









































------

## JSP(Java Servlet Pages)

### jsp页面代码

1. 指令：<%@ %>  实例：<%@ page language="java" import="java.util.*,java.sql.*" pageEncoding="UTF-8"%>
2. 静态元素：包括HTML代码,CSS代码，JavaScript代码；
3. 小脚本：<% %>  实例：<% //在这里面可以写任何的Java代码 %>
4. 声明：<%! %>  实例：<%! //一般是在jsp之中定义像java中的方法 %>
5. 表达式:<%= %>  实例：<%= //这里调用方法或者写内容%>
6. 注释：<!-- --> HTML注释用户看得见    <%-- --%>用户看不见

### 在java Servlet 服务端创建服务

继承HTTPServlet 重写 doGet()、doPost()

```java
public class selectPhoneServlet extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {//req 请求、resp响应
        doPost(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.setCharacterEncoding("utf-8");//设置编码格式
        response.setContentType("text/html;charset=utf-8");//设置编码格式
        response.setCharacterEncoding("utf-8");//设置编码格式
        PrintWriter pipedWriter = resp.getWriter();//响应输出
        HttpSession session = request.getSesstion();//获取session
        request.getParameter("name属性");//获取name属性值
        session.setAttribute("key",value);//设置session
        
    }
}
```



------



## 数据库连接池

#### 数据库连接池的大致定义：

​	创建多个连接对象经行交互，避免重复关闭创建连接对象

### 自定义连接池：

```java
//不满足SUM公司的标准
//创建自定义类。实现DataSource接口。并重写方法
public class DaoDataSource implements DataSource{//实现接口 DataSourec
    private static List<Connection> connectionArrayList = new ArrayList<>();
    //创建连接集合
    static {//在静态块中加载执行
        for (int i = 0; i < 3; i++) {
            connectionArrayList.add(BaseDao.getConnection());//添加3条连接对象
        }
    }
    public void giveBack(Connection connection) {//归还连接对象
        connectionArrayList.add(connection);
    }
	@Override//重写连接方法
    public Connection getConnection() throws SQLException {
        if (connectionArrayList.size() == 0) {//判断是否还有连接对象。没有则添加数据
            for (int i = 0; i < 3; i++) {
                connectionArrayList.add(BaseDao.getConnection());
            }
        }
        Connection connection =  connectionArrayList.remove(0);//每调用一次连接对象都移除一个
        return connection;//返回剩余的对象
    }
}
//优化后的写法
//创建一个类
public class connectionWrap implements Connection {
    private Connection connection;//私有连接对象
    private List<Connection> connectionList;//私有集合
    //构造方法
    public connectionWrap(Connection connection,List<Connection> connectionList) {
        this.connection = connection;
        this.connectionList = connectionList;
    }
    //重写 (所有)  方法
    @Override
    public Statement createStatement() throws SQLException {
        return connection.createStatement();
    }
    @Override
    public PreparedStatement prepareStatement(String sql) throws SQLException {
        return connection.prepareStatement(sql);
    }
    @Override
    public void close() throws SQLException {
        System.out.println("归还之前:"+connectionList.size());
        connectionList.add(connection);
        System.out.println("归还之后:"+connectionList.size());
    }
}
//并修改DaoDataSource类中的getConnection方法;
@Override
public Connection getConnection() throws SQLException {
    if (connectionArrayList.size() == 0) {
        for (int i = 0; i < 3; i++) {
            connectionArrayList.add(BaseDao.getConnection());
        }
    }
    return new StudentConnectionWrap(connectionArrayList.remove(0),connectionArrayList);
}
```

#### 使用连接池:

```java
//使用连接池
public static void main(String[] args) {
    Connection connection = null;//空连接对象
    PreparedStatement preparedStatement = null;//空预编译对象
    DaoDataSource daoDataSource = new DaoDataSource();
    try {//多个连接对象 ↓这里创建了多个连接对象。
        connection = daoDataSource.getConnection();
        connection = daoDataSource.getConnection();
        connection = daoDataSource.getConnection();
        //前三条用光了静态加载的对象。但之后还有数据要用所以又补充了三条
        connection = BaseDao.getConnection();
        String sql = "INSERT INTO student VALUE(NULL,'寜','女','2004-01-30')";
        preparedStatement = connection.prepareStatement(sql);
        if (preparedStatement.executeUpdate() > 0) {
            System.out.println("添加成功");
        } else {
            System.out.println("添加失败");
        }
    } catch (Exception e) {
        e.printStackTrace();
    } finally {
        {//优化前 这里的BaseDao为基础连接对象和关闭操作
            BaseDao.close(null, preparedStatement, null);
            daoDataSource.giveBack(connection);
        }{//优化后 连接对象不再是关闭而是归还
        	BaseDao.close(null, preparedStatement, connection);
        }
    }
}
```



------



### 开源连接池：

#### C3P0连接池： [c3p0-0.9.1.2.jar](..\00-lib-工具包\c3p0\c3p0-0.9.1.2.jar) 

##### 普通创建连接池

```java
//导入jar包
public class C3P0DataSource {
    private static ComboPooledDataSource dataSource = new ComboPooledDataSource();
    static {
        try {
            dataSource.setDriverClass("com.mysql.cj.jdbc.Driver");//导入驱动
            dataSource.setJdbcUrl("jdbc:mysql://127.0.0.1:3306/class?															characterEncoding=utf-8");//数据库连接地址
            dataSource.setUser("root");//用户名
            dataSource.setPassword("root");//密码
        } catch (PropertyVetoException e) {
            e.printStackTrace();
        }
    }
        /**
     * 获取连接对象
     */
    public static Connection getConnection() {
        Connection connection = null;
        try {
            connection = dataSource.getConnection();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return connection;
    }

    /**
     * 关闭数据库连接
     */
    public static void close(ResultSet resultSet, Statement statement, Connection connection) {
        try {
            if (resultSet != null) {
                resultSet.close();
            }
            if (statement != null) {
                statement.close();
            }
            if (connection != null) {
                connection.close();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
```

##### 配置文件创建C3P0连接池

```xml
<c3p0-config><!--文件命名必须为 (c3p0-config) -->
    <default-config>
        <property name="driverClass">com.mysql.cj.jdbc.Driver</property>
        <property name="jdbcUrl">
            jdbc:mysql://127.0.0.1:3306/class?characterEncoding=utf-8
        </property>
        <property name="user">root</property>
        <property name="password">root</property>
        <!-- 可选配置（初始化连接数量） -->
        <property name="initialPoolSize">5</property>
    </default-config>
</c3p0-config>
```

##### 使用配置文件创建的C3P0连接池 和 直接使用C3P0连接池

```java
//将C3P0DataSource中的静态块删除
//直接使用
public static void main(String[] args) {
    Connection connection = null;
    PreparedStatement preparedStatement = null;
    try {
        connection = C3P0DataSource.getConnection();//获取连接对象
        String sql = "INSERT INTO student VALUE(NULL,'寜','女','2004-01-30')";
        preparedStatement = connection.prepareStatement(sql);
        if (preparedStatement.executeUpdate() > 0) {
            System.out.println("添加成功");
        } else {
            System.out.println("添加失败");
        }
    } catch (Exception e) {
        e.printStackTrace();
    } finally {//归还连接对象
        C3P0DataSource.close(null, preparedStatement, connection);
    }
}
```



------



#### DBCP连接池： [commons-dbcp-1.4.jar](..\00-lib-工具包\DBCP\commons-dbcp-1.4.jar)  [commons-pool-1.6.jar](..\00-lib-工具包\DBCP\commons-pool-1.6.jar) 

##### 普通连接：

```java
public class DbcpDataSource {
    private static BasicDataSource dataSource = new BasicDataSource();
static {
    basicDataSource.setDriverClassName("com.mysql.cj.jdbc.Driver");
    basicDataSource.setUrl("jdbc:mysql://127.0.0.1:3306/class?characterEncoding=utf-8");
    basicDataSource.setUsername("root");
    basicDataSource.setPassword("root");
    /**
     * 获取连接对象
     */
    public static Connection getConnection() {
        Connection connection = null;
        try {
            connection = dataSource.getConnection();//使用创建连接
        } catch (Exception e) {
            e.printStackTrace();
        }
        return connection;
    }
    /**
     * 关闭数据库连接
     */
    public static void close(ResultSet resultSet, Statement statement, Connection connection) {
        try {
            if (resultSet != null) {
                resultSet.close();
            }
            if (statement != null) {
                statement.close();
            }
            if (connection != null) {
                connection.close();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
```

##### 使用配置文件创建连接池：

```properties
# 创建资源包	
driverClassName = com.mysql.cj.jdbc.Driver
url = jdbc:mysql://localhost:3306/class
username = root
password = root
```

```java
try {
    Properties properties = new Properties();
    //路径从项目路径开始往下写
    properties.load(new FileInputStream("onclass/src/dbcp.properties"));
    dataSource = (BasicDataSource) BasicDataSourceFactory.createDataSource(properties);
} catch (Exception e) {
    e.printStackTrace();
}
```

##### 使用连接池：

```java
public static void main(String[] args) throws FileNotFoundException {
    Connection connection = null;
    PreparedStatement preparedStatement = null;
    try {
        connection = DbcpDataSource.getConnection();
        String sql = "INSERT INTO student VALUE(NULL,'寜','女','2004-01-30')";
        preparedStatement = connection.prepareStatement(sql);
        if (preparedStatement.executeUpdate() > 0) {
            System.out.println("添加成功");
        } else {
            System.out.println("添加失败");
        }
    } catch (Exception e) {
        e.printStackTrace();
    } finally {
        DbcpDataSource.close(null, preparedStatement, connection);
    }
}
```



------



## Ajax

异步请求不用刷新页面的请求

### javascript方式写：

```java
//创建请求对象
var request=new XMLHttpRequest();
if(request==undefined){//如果浏览器版本较低（ie6以下）的创建请求方式
    request=new ActiveXObjct("Microsoft.XMLHTTP");
}
function valPost(){
    var NAME = $("选择器").val();
    //open(提交方式,url,是否即时发送请求)
    request.open("post", "服务器名称", true);
    //设置请求头
    request.setRequestHeader("content-Type","application/x-www-form-urlencoded");
    //将请求发送,携带参数
    request.send("NAME="+encodeURI(NAME));
    request.onreadystatechange = callback;
}
//3.回调函数，请求状态发生改变时，执行的方法
function callback(){
    if(request.readyState==4){
        if(request.status==200){
            //获取响应文本，显示在页面
            var msg = request.responseText;//msg =要给的值参数
            $("选择器").html(msg);
        }
    }
}
//服务端 数据处理并进行发送
resp.getWriter().write("要给的值参数");
//request 请求、XMLHttpRequest 可扩展超文本传输请求、undefined 未定义、open 打开
//onreadystatechange 状态改变时当前数据源的数据将要发生变化时事件、readyState 请求处理、
```

请求状态码： readystate: XMLHttpRequest的状态信息 0：XMLHttpRequest对象没有完成初始化 1：XMLHttpRequest对象开始发送请求 2：XMLHttpRequest对象的请求发送完成 3：XMLHttpRequest对象开始读取响应，还没有结束 4：XMLHttpRequest对象读取响应结束 status：HTTP的状态码 200：服务器响应正常 400：无法找到请求的资源 403：没有访问权限 404：访问的资源不存在 500：服务器内部错误

### 用jquery写：

```java
function 方法名(){
    var value = $("选择器").val();
    $.ajax({
        type:"post",//提交方式
        url:"服务器",//提交到那个服务器
        data:"value = "+encodeURI(value),
        dataType:"json",
        success:function (msg){//msg表示从服务器发送过来的数据
            $("选择器").html(msg);
        }
    });
}
/****************指定get方式****************/
$.get(
    "服务器名称",
    { name: name },
    function(msg){
        $("要显示的标签").html(msg);
    }
);
/****************指定post方式****************/
$.post(
    "服务器名称",
    { name: name },
    function(msg){
        $("要显示的标签").html(msg);
    }
);
//服务端 数据处理并进行发送
resp.getWriter().write("要给的值参数");
```

### JSON：

josn是一种传输数据的格式： [{"cid":5,"cname":"长沙","pid":1,},{"cid":6,"cname":"湘潭","pid":1}]

[]：集合 	{}:对象 	:前面表示属性名 	:后面表示属性值 	[]{}可以嵌套

```java
//服务端
String value = req.getParameter("要拿的name属性");
List<对象> list = 对象Dao层.select();//结果集对象
Gson gson=new Gson();//创建Gson对象
String json = gson.toJson(list);//将list对象转成json类型
resp.getWriter().print(json);//发送响应

//javascript代码
$(function () {
    $.ajax({//jsp发出ajax请求
        type: "post", //请求方式
        url: "服务器名称",//服务器的地址
        data:"内容",
        dataType: "json", //响应数据类型
        success: function (msg) {//msg=响应内容
            /* var province = $("#province");//获取省份下拉列表
            province.prop("length", 1);//清空省份下拉列表，设置长度为1表示只保留“请选择”
            for (var i = 0; i < msg.length; i++) {
                var pid = msg[i].PID;
                var pname = msg[i].PName;
                var options = "<option value=" + pid + ">" + pname + "</option>";
                province.append(options);
            }
           */
        }
    });//ajax
});
function selectCity() {
    var pid = $("#province").val();
    if (pid === "0") {
        return;
    }
    /******指定josn请求******/
    $.getJSON(
        "服务器名称",
        {pid: pid},
        function (msg) {
            var city = $("#city");//获取城市下拉列表
            city.prop("length", 1);//清空城市下拉列表，设置长度为1表示只保留“请选择”
            for (var i = 0; i < msg.length; i++) {
                var cid = msg[i].CID;
                var cname = msg[i].CName;
                var options = "<option value=" + cid + ">" + cname + "</option>";
                city.append(options);
            }
        }
    );
}

```



------



## 过滤器：

### 1.创建过滤器

```java
//实现所有服务的编码格式
public class EncodingFilter implements Filter {
    //实现抽象接口 Filter 重写抽象方法 init(初始化) doFilter(服务)
    @Override
    public void init(FilterConfig filterConfig) throws ServletException {
        System.out.println("EncodingFilter (编码) init (初始化)");
    }

    @Override
    public void doFilter(ServletRequest servletRequest, ServletResponse servletResponse, FilterChain filterChain) throws IOException, ServletException {
        System.out.println("EncodingFilter (编码) doFilter (服务)");
        HttpServletRequest request = (HttpServletRequest) servletRequest;//转换请求
        HttpServletResponse response = (HttpServletResponse) servletResponse;//转换响应
        //设置响应端的编码格式
        response.setContentType("text/html;charset=utf-8");
        if("POST".equals(request.getMethod())){
            //设置post方式的编码格式
            request.setCharacterEncoding("utf-8");
        }else{
            //设置post编码格式
            Enumeration<String> stringEnumeration = request.getParameterNames();
            //获取所有name属性
            while (stringEnumeration.hasMoreElements()) {
                String element = stringEnumeration.nextElement();
                String[] values = request.getParameterValues(element);
                for (int i = 0; i < values.length; i++) {
                    values[i] = new String(values[i].getBytes(
                        StandardCharsets.ISO_8859_1), StandardCharsets.UTF_8);
                }
            }
        }
        filterChain.doFilter(servletRequest, servletResponse);//允许通过过滤器
    }
}
```

### xml配置过滤器的使用

```xml
<filter>
    <filter-name>EncodingFilter</filter-name><!--过滤器名称-->
    <filter-class>url.EncodeFilter</filter-class><!--过滤器路径-->
</filter>
<filter-mapping><!--映射-->
    <filter-name>EncodeFilter</filter-name><!--声明-->
    <!-- 所有资源进入 -->
    <url-pattern>/*</url-pattern>
</filter-mapping>
<url-pattern>/fileName/*</url-pattern><!--指定文件目录下的所有文件-->
<servlet-name>服务名称</servlet-name><!--给指定服务用-->
```



------



## jstl和el

### jstl标签库：

```jsp
引入标签库:
	<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<!--if -->
<c:if test="value1=value2">
    true
</c:if>

<!--if else -->
<c:choose>
    <c:when test="value1=value2">
        true
    </c:when>
    <c:otherwise>
        false
    </c:otherwise>
</c:choose>

<!-- foreach遍历 -->
<!--遍历List-->
<c:forEach items="${list}" var="stu" varStatus="status">
    ${status.index}<!--下标-->
    ${stu.sname }<!--获取值-->
    ${stu.sex}<!--获取值-->
</c:forEach>

<!-- 遍历Map集合 -->
<c:forEach items="${map}" var="stu">
    ${users.key}<!--获取键-->
    ${stu.value.sname}<!--获取值-->
    ${stu.value.sex}<!--获取值-->
</c:forEach>
```

### jstl引入格式化标签库：

```jsp
1.页面引入：
	<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
2.语法：
<!-- 日期格式 -->
	<fmt:formatDate value="${值}" pattern="yyyy-MM-dd HH:mm:ss"></fmt:formatDate>
<!-- 货币格式 -->
	<fmt:formatNumber value="${值}" pattern="￥000,000.0"></fmt:formatNumber
```

### el:

```jsp
<%--注释(不可见)--%>
<%//for循环可嵌套
	for (int i = 0, i >= 1 , i++){
%>
	i
<%}%>
```



------



## Cookie的使用

### Cookie的介绍：

Cookie是储存在本地计算机的数据

```java
//创建Cookie 	key不能重复	值只能是字符串类型
Cookie cookie = new Cookie("key","value");
//cookie只存在3天
cookie.setMaxAge(60*60*24*3);
//响应到浏览器
response.addCookie(cookie);

//获取本网站的cookie
Cookie [] cookies = request.getCookies();
for(Cookie c:cookies){
    //所需获取的键名比较cookie中的键名
    if("key".equals(c.getName())){
        c.getValue();//值
    }
}
```



------



## web图片验证码：

### servlet代码：

```java
//创建随机数
Random random = new Random();
//定义一张图片的宽(400)，高(40)
int width = 400,height=40;
//创建画板	TYPE_INT_RGB(表示具有打包成整数像素的 8 位 RGB 颜色分量的图像。)
BufferedImage bufferedImage = 
    new BufferedImage(width, height, BufferedImage.TYPE_INT_RGB);
//创建画笔
Graphics backgroundBrush = bufferedImage.getGraphics();//背景画笔
//干扰线画笔
Graphics interferenceBrush = bufferedImage.getGraphics();
//噪点画笔
Graphics noiseBrush = bufferedImage.getGraphics();
//随机背景颜色
backgroundBrush.setColor(color());
//预留边框距离//边框 A B , width-A*2,height-B*2
backgroundBrush.fillRect(2, 2, width - 4, height - 4);
//边框颜色
backgroundBrush.setColor(new Color(1,1,1,1));//将边框颜色固定成黑色
//绘制边框
backgroundBrush.drawRect(0, 0, width, height);
//绘制背景
backgroundBrush.setColor(color());//随机颜色
//设置字体字体大小
backgroundBrush.setFont(new Font("宋体", Font.PLAIN, 30));  
//保存生成的随机数
StringBuffer stringBuffer = new StringBuffer();
//获取4位随机数
char[] c = "ABCDEFGHIJKLMNOPQRSTUVWXYG123456789".toCharArray();
for (int i = 0; i < 4; i++) {
    int index = random.nextInt(c.length);
    //字体宽度
    backgroundBrush.drawString(c[index] + "", 10 + i * 20, 20 + random.nextInt(20));
    stringBuffer.append(c[index]);
}
//保存4位验证码
request.getSession().setAttribute("yzmStr", stringBuffer);
//绘制干扰线
for (int i = 0; i < 15; i++) {//干扰线数量
    int x1 = random.nextInt(width);//随机生成的起点(必须在图片宽度范围)
    int y1 = random.nextInt(height);//随机生成的起点(必须在图片高度范围)
    int x2 = random.nextInt(width);//结束点
    int y2 = random.nextInt(height);//结束点
    interferenceBrush.setColor(color());//干扰线颜色
    interferenceBrush.drawLine(x1, y1, x2, y2);
}
//噪点
for (int j = 0; j < 100; j++) {//噪点数量
    int x = random.nextInt(width);
    int y = random.nextInt(height);
    noiseBrush.setColor(color());//噪点颜色
    noiseBrush.drawLine(x, y, x, y);
}
//释放画笔
backgroundBrush.dispose();
interferenceBrush.dispose();
noiseBrush.dispose();
//输出
ServletOutputStream output = resp.getOutputStream();
ImageIO.write(bufferedImage, "jpg", output);

/**
     * 随机颜色
     */
private static Color color() {
    Random random = new Random();
    int color = 255;
    int r = random.nextInt(color),g = random.nextInt(color),b = random.nextInt(color);
    return new Color(r,g,b);
}
/**
     * 验证 验证码
     */
private void valVeryCode(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
    //取ajax传来的值（验证码）
    String yzm = req.getParameter("yzm");
    //取session中保存的验证码
    HttpSession session = req.getSession();
    String yzmStr =String.valueOf(session.getAttribute("yzmStr"));
    //比较，并返回响应
    PrintWriter out = resp.getWriter();
    if (!(yzm.equalsIgnoreCase(yzmStr))) {
        out.print("验证码不正确！");
    } else {
        out.print("");
    }
}
```

### jsp页面代码：

```jsp
<input type = "text" value = "" id = "yzm" class = "l_ipt" onblur = "yz()"/>
<img id = "veryCode" src = "RegistServlet?method=veryCode" valign = "middle"/>
<a href = "javascript:changeVeryCode()" style = "font-size:12px; font-family:'宋体';">
    换一张
</a>
<%--js代码--%>
<script type = "text/javascript" src = "js/jquery-1.12.4.js"></script>
<script type = "text/javascript">
    function changeVeryCode() {//刷新 验证码 函数
        //加随机数参数是为了，频繁'换一张'时，请求能够正常发送（相同地址频繁发送请求，浏览器会阻住）
        document.getElementById("veryCode").src = 
            "服务页面?method=veryCode&amp;m=" + Math.random();
    }
    function yz() {//验证 验证码 函数
        var yzm = $("#yzm").val();
        if (yzm === "") {
            alert("请输入验证码");
            return false;
        }
        $.ajax({
            type: "POST",
            url: "服务页面",
            data: "method=valVeryCode&yzm=" + yzm,
            success: function (msg) {
                if (msg !== "") {
                    alert(msg);
                }
            }
        });
    }
</script>
```













