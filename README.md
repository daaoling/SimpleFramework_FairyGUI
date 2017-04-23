#tolua fairygui 一个结合示例框架

当前框架版本Unity4.7 U5的版本在计划内

## 2017-2-14

新增敏感词检测模块

## 2017-2-2

暂时不维护tolua版本 转而使用xlua版本 并且把相关的代码移植了过去

## 2016-11-4 
mvc 框架搭建
初步完成场景管理

## Update Notice

直接拉取xlua最新的覆盖(可以用pbc的那个分支)

直接拉取fgui最新的覆盖

ExampleGenConfig.CSharpCallLua 加上

	typeof(FairyGUI.EventCallback0)
	typeof(FairyGUI.EventCallback1)


## Notice 2017-4-23

1.调用LuaEnv.Dispose时，报“try to dispose a LuaEnv with C# callback!”错是什么原因？
https://github.com/Tencent/xLua/blob/master/Assets/XLua/Doc/faq.md

loadmgr 销毁的时候 有个callback 没有dispose

2. CSharp call lua  editor下方式很多
   移动平台老老实实给我 gen code

	1. 加 CSharpCallLua attribute 
	但有时候是用dll的
	2. 看 ObjectTranslator:initCSharpCallLua 在 ExampleGenConfig.CSharpCallLua 加上即可

https://github.com/Tencent/xLua/issues/24


