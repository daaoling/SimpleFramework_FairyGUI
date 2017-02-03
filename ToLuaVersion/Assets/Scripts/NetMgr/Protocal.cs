
//namespace LuaFramework {
    //public class Protocal {
    //    ///BUILD TABLE
    //    public const int Connect = 101;     //连接服务器
    //    public const int Exception = 102;     //异常掉线
    //    public const int Disconnect = 103;     //正常断线   
    //}


    public class Protocal 
    {
         public const int Connect		= 101;	//--连接服务器
         public const int ConnectError = 102; //-- 连接失败
         public const int Exception   = 103;	//--异常掉线
         public const int Disconnect  = 104;	//--正常断线
         public const int ReceiveTimeOut = 105; //-- 消息超时接收 
         public const int Message		= 106;	//--接收消息
    }
//}