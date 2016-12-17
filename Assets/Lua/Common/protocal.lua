--Buildin Table
Protocal = {
	Connect		= '101',	--连接服务器
	ConnectError = '102', -- 连接失败
  Exception   = '103',	--异常掉线
	Disconnect  = '104',	--正常断线
  ReceiveTimeOut = '105', -- 消息超时接收 
	Message		= '106',	--接收消息
}

Opcodes = {
   register = 0,
   login = 1
}
