using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LuaFramework;


//任意 连接 请求 (http socket连接请求)

//游戏服务器 发消息

//转菊花 
//    => 网络异常  发包没有回到

//    => 网络延迟
    
//    => 服务器异常 没有回应

//    => 被人顶下先

//通通不用管 
    
//    =>  发出一个请求 服务器没有回应 
//    =>  等待一段时间 重连网络 
//public enum NetType
//{
//    chat,
//    login
//}
public class NetworkManagerV2 : Manager
{




    //public SelfNetwork newWork;
    
    //public class NetChanelUnit
    //{

    //    //public NetType netType = NetType.login;
        

        
    //    //public Queue<KeyValuePair<int, object>> sEvents;



    //    public NetChanelUnit()
    //    {
    //        //this.ip = ip;
    //        //this.port = port;
    //        //this.netType = netType;
    //        //this.newWork = new SelfNetwork();
    //        //this.sEvents = new Queue<KeyValuePair<int, object>>();
    //    }

    //    public virtual void Update(){}

    //    public virtual void LinkServer()
    //    {
    //        //Debug.Log(" LinkServer ip " + ip + " port" + port + " netType " + netType.ToString());
    //        newWork.LinkServer(ip, port); 
    //    }

    //    //public virtual void SendMessage(BasePacket pkt)
    //    //{
    //    //    //Debug.Log("ip " + ip + " port" + port + " netType " + netType.ToString() + " ptkType " + pkt.pktType);

    //    //    this.newWork.SendPacket(pkt);
    //    //}



    //    public virtual void Release()
    //    {
    //        this.isConnect = false;
    //        this.newWork.CloseConnect();
    //    }

    //    // --当连接建立时--
    //    public virtual void OnConnect()
    //    {
    //        this.isConnect = true;
    //        //Debug.Log(" OnConnect " + netType.ToString()); 
    //    }


    //    public void OnConnectError() {
    //        this.isConnect = false;
    //        //this.newWork.Destroy();
    //    }

    //    // -- 异常断线 --
    //    // -- 等待 重新 连接 --
    //    public void OnNetError()
    //    {
    //        this.isConnect = false;
    //        //this.newWork.Destroy();
    //        //Debug.Log(" OnNetError " + netType.ToString()); 
    //    }

    //     //接受到网络消息
    //    public virtual void OnSocketMsg(object[] objs)
    //    {
    //        if (objs == null || objs.Length == 0) return;
    //        int ptkType = (int)objs[0];
    //        int error = (int)objs[1];
    //        Byte[] al = (Byte[])objs[2];
    //        if (error != 0)
    //        {
    //            //Debug.Log(" SocketMsgError " + netType.ToString() + " error " + error);
    //            //GameMain.Instance.evt.CallEvent(Opcodes.SocketMsgError, error);
    //        }
    //        else
    //        {
    //            //Debug.Log(" OnSocketMsg netType " + netType.ToString() + " ptkType " + ptkType);
    //            //GameMain.Instance.evt.CallEvent(ptkType, al);
    //        }
    //    }
    //}

    //public class LoginChanelUnit : NetChanelUnit
    //{
    //    //public LoginChanelUnit(NetType netType)
    //    //    : base(netType)
    //    //{

    //    //}

    //    public override void OnConnect()
    //    {
    //        base.OnConnect();


    //        Debug.Log("ready login gameserver");
    //        //LoginMsg cl = new LoginMsg();
    //        //cl.data.token = GameMain.Instance.dataPool.roleModel.token;
    //        //cl.data.platform = (int)AppConst.ptqd;
    //        //cl.data.version = "0.1.0";
    //        //GameMain.Instance.Send(cl);

    //        //GameMain.Instance.evt.AddListener(Opcodes.RESPONSE_LOGIN_MSG, onRESPONSE_LOGIN_MSG);
    //    }

    //    public float headTimer = 0f;
    //    public override void Update ()
    //    { 
    //        //心跳包
    //        //if(this.isConnect && (this.headTimer -= RealTime.deltaTime) < 0f)
    //        //{
    //        //    this.headTimer = 60.0f;
    //        //    Debug.Log("tet");
    //        //    this.newWork.HeatUpdate();
    //        //}
    //    }

    //    public int preCode = -1;

    //    //public override void SendMessage(BasePacket pkt)
    //    //{
    //    //    NetworkManager.Instance.isWaiting = true;

    //    //    this.preCode = pkt.pktType;

    //    //    //Debug.Log("....................................... SendMessage pkt.pktType " + pkt.pktType);

    //    //    base.SendMessage(pkt);
    //    //}

    //    public override void OnSocketMsg(object[] objs) {

    //        if (objs == null || objs.Length == 0) return;
            
    //        int ptkType = (int)objs[0];
    //        int error = (int)objs[1];
    //        Byte[] al = (Byte[])objs[2];

    //        #region legacy
    //        ///回应的码 == 请求的码
    //        //if ((this.preCode + 2000) == ptkType) {
    //        //    NetworkManager.Instance.isWaiting = false;
    //        //} 

    //        //if (error != 0)
    //        //{
    //        //    //Debug.Log(" SocketMsgError " + netType.ToString() + " error " + error);
    //        //    GameMain.Instance.evt.CallEvent(Opcodes.SocketMsgError, error);
    //        //}
    //        //else
    //        //{
    //        //    //Debug.Log(" OnSocketMsg netType " + netType.ToString() + " ptkType " + ptkType);
    //        //    GameMain.Instance.evt.CallEvent(ptkType, al);
    //        //}
    //        #endregion
            
    //    }
    //}


    //private bool _isWaiting = false; ///是否正在等待网络消息回应
    //public bool isWaiting { 
    //    get { 
    //        return _isWaiting; 
    //    } 
    //    set { 
    //        _isWaiting = value;
    //        Debug.Log(" _isWaiting " + value);
    //        //Messenger.Broadcast<bool>(NotiConst.RequestNetResponse.ToString(), _isWaiting);
    //    }
    //}

    //int netTypeLength;
    //public LoginChanelUnit login_channel_unit;
    //public LoginChanelUnit login_channel_unit
    //{
    //    get
    //    {
    //        return NetworkManager.Instance.channelUnit[(int)NetType.login] as LoginChanelUnit;
    //    }
    //}
    //public ChatUnit chat_channel_unit { 
    //    get {
    //        return NetworkManager.Instance.channelUnit[(int)NetType.chat] as ChatUnit;
    //    } 
    //}


    public string ip;
    public int port;

    public SelfNetwork newWork;

    void Awake()
    {
        this.newWork = new SelfNetwork();
        this.newWork.OnRegister();
    }

    public void OnInit()
    {
        //CallMethod("Start");
        Util.CallMethod("Network", "Start");
    }

    //void OnEnable()
    //{
        

        //GameMain.Instance.evt.AddListener(NotiConst.Connect, OnConnect);
        //GameMain.Instance.evt.AddListener(NotiConst.ConnectError, OnConnectError);

        //GameMain.Instance.evt.AddListener(NotiConst.NetError, OnNetError);

        //GameMain.Instance.evt.AddListener(NotiConst.SocketPack, OnSocketMsg);
        //GameMain.Instance.evt.AddListener(Opcodes.SocketMsgError, OnSocketError);
    //}

    public void Update()
    {
        //for (int i = 0; i < netTypeLength; i++)
        //{
        //    channelUnit[i].DispatchEvent();
            //if (channelUnit[i].sEvents.Count > 0)
            //{
            //    while (channelUnit[i].sEvents.Count > 0)
            //    {
            //        KeyValuePair<int, object> _event = channelUnit[i].sEvents.Dequeue();
            //        GameMain.Instance.evt.CallEvent(_event.Key, _event.Value);
            //    }
            //}
        //}

        DispatchEvent();
        
        HeatBeat();

        ////for (int i = 0; i < netTypeLength; i++)
        ////{
        ////    channelUnit[i].Update();
        ////}
        //Update();
    }

    //void OnDisable()
    //{
    //    Util.CallMethod("Network", "OnDisable");

    //    //GameMain.Instance.evt.RemoveListener(NotiConst.Connect, OnConnect);
    //    //GameMain.Instance.evt.RemoveListener(NotiConst.ConnectError, OnConnectError);

    //    //GameMain.Instance.evt.RemoveListener(NotiConst.NetError, OnNetError);

    //    //GameMain.Instance.evt.RemoveListener(NotiConst.SocketPack, OnSocketMsg);
    //    //GameMain.Instance.evt.RemoveListener(Opcodes.SocketMsgError, OnSocketError);
    //}
    public void Unload()
    {
        Util.CallMethod("Network", "Unload");
    }

    /// <summary>
    /// 析构函数
    /// </summary>
    void OnDestroy()
    {
        this.newWork.OnRemove();
        Debug.Log("~NetworkManager was destroy");
    }

    public void SendConnect()
    {
        this.newWork.LinkServer(AppConst.SocketAddress, AppConst.SocketPort);
    }

    public void SendMessage(ByteBuffer buffer)
    {
        //Debug.Log("SendMessage");
        this.newWork.SendMessage(buffer);
    }

    //public void Release() {
        
    //    //for (int i = 0; i < netTypeLength; i++)
    //    //{
    //    //    //channelUnit[i].newWork.Destroy();
    //    //    channelUnit[i].Release();
    //    //}
        
    //    this.login_channel_unit.Release();


    //    Debug.Log("~ net Release");
    //}


    //public void LinkServer(string ip, int port)
    //{
    //    this.newWork.LinkServer(ip, port);
    //}



    // -- 发送SOCKET消息 --
    //public void SendMessage(NetType netType, BasePacket pkt)
    //{
    //    //channelUnit[(int)netType].SendMessage(pkt);

    //    //if (netType == NetType.login)
    //    //{
    //    //    NetworkManagerV2.Instance.isWaiting = true;

    //    //    //channelUnit[(int)netType].preCode = pkt.pktType;

    //    //    this.login_channel_unit.preCode = pkt.pktType;
    //    //    //Debug.Log("....................................... SendMessage pkt.pktType " + pkt.pktType);

    //    //    //base.SendMessage(pkt);
    //    //    this.login_channel_unit.newWork.SendPacket(pkt);
    //    //}
    //    //else
    //    //{
    //    //    this.login_channel_unit.newWork.SendPacket(pkt);
    //    //}
    //}



    // --链接成功--
    //public void OnConnect(object arg)
    //{
    //    NetworkManagerV2.Instance.isWaiting = false;

    //    NetType netType = (NetType)arg;

    //    this.login_channel_unit.OnConnect();

    //    //Debug.Log(" OnConnect " + netType.ToString()); 
    //}

    // --链接失败--
    //public void OnConnectError(object arg) 
    //{
    //    NetworkManagerV2.Instance.isWaiting = false;

    //    NetType netType = (NetType)arg;

    //    this.login_channel_unit.OnConnectError();

    //    //SceneMgr.Instance.CreateTip("连接异常!");
    //}

    // -- 网络层抛出--
    // -- 有可能网络层没有检测到 那么上层UI菊花太久了也会抛出 --
    //public void OnNetError(object arg)
    //{
    //    NetworkManagerV2.Instance.isWaiting = false;

    //    NetType netType = (NetType)arg;

    //    this.login_channel_unit.OnNetError();

    //    //Debug.Log(" OnNetError " + netType.ToString()); 

    //    //SceneMgr.Instance.CreateTip("网络异常 骚年重启吧!么么哒!");
    //}

    //public void OnSocketMsg(object arg)
    //{
    //    object[] objs = (object[])arg;

    //    NetType netType = (NetType)objs[0];
    //    //Debug.Log("SocketMsg" + netType.ToString());
    //    this.login_channel_unit.OnSocketMsg((object[])objs[1]);
    //}

    //private void OnSocketError(object arg)
    //{
    //    ///有些网络错误码需要别的处理
    //    int error = (int)arg;
    
    //    //CfgErrcodeVo errorVo = StaticDataPool.Instance.configErrorCodePool.GetErrorVo(error);
    //    //Debugger.Log(errorVo != null ? errorVo.msg : " 错误代码 " + error);
    //    //SceneMgr.Instance.CreateTip(errorVo!= null ? errorVo.msg : "错误代码" + error);
    //}

    //public T Parse<T>(object obj)
    //{
        //Byte[] arg = (Byte[])obj;
        //using (System.IO.Stream getStream = new System.IO.MemoryStream(arg)) 
        //{
        //    T res = ProtoBuf.Serializer.Deserialize<T>(getStream);
        //    return res;
        //}
    //}

    static readonly object m_lockObject = new object();
    static Queue<KeyValuePair<int, ByteBuffer>> mEvents = new Queue<KeyValuePair<int, ByteBuffer>>();
    public static void AddEvent(int _event, ByteBuffer data)
    {
        lock (m_lockObject)
        {
            mEvents.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
        }
    }

    void DispatchEvent()
    {
        lock (m_lockObject)
        {
            if (mEvents.Count > 0)
            {
                //Debug.Log(" mEvents.Count " + mEvents.Count);
                while (mEvents.Count > 0)
                {
                    KeyValuePair<int, ByteBuffer> _event = mEvents.Dequeue();
                    facade.SendMessageCommand(NotiConst.DISPATCH_MESSAGE, _event);
                }
            }
        }
    }



    //public bool isConnect = false; ///当前chanel是否连接上
    ///
    public float headTimer = 0f;
    void HeatBeat()
    {
        //心跳包
        //if(this.isConnect && (this.headTimer -= RealTime.deltaTime) < 0f)
        //{
        //    this.headTimer = 60.0f;
        //    Debug.Log("tet");
        //    this.newWork.HeatUpdate();
        //}
    }
}
