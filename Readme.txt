升级记录：
1.0002:
	增加BLLClass抽象类，BLL层数据继承自该类。
1.0001：
	1：变IConsoleEntity为抽象类ConsoleEntity，从未以后编写数据库实体类时直接集成自该类则不需要加上Id 和 IsLock字段。
	2：增加可删除接口和可索引接口,ConsoleEntity实现该两个接口。
	3：IConsoleListable<T>接口中增加搜索方法，为后台列表页的搜索框提供支持。