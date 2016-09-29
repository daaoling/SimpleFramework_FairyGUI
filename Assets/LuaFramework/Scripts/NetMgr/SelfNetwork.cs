using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using UnityEngine;
using LuaFramework;


public class SelfNetwork
{
		private const int buffSize = 20 * 1024;
		
		private int nowPktLength = -1;
		
        private int nowReadIndex = 0;
		private int nowWriteIndex = 0;
        private byte[] allReceiveByte = new byte[buffSize];

        private Thread thd;
        private Socket socket;

		public void CloseConnect()
		{
            try
            {
                if (this.thd != null) {
                    this.thd.Abort();
                    this.thd = null;
                } 
                
                //this.socket.Shutdown(SocketShutdown.Both);
                if(this.socket != null){
                    this.socket.Shutdown(SocketShutdown.Both);
                    this.socket.Close();
                    this.socket = null;
                }

            }
            catch (Exception e)
            {
                Debug.Log("清理有点问题貌似" + e.ToString());
            }
		}

        public void OnRegister()
        {
            ///考虑断线重连 每次连接前先清理一次
            /////reset
            this.nowPktLength = -1;
            this.nowWriteIndex = 0;
            this.nowReadIndex = 0;
            this.allReceiveByte = new byte[buffSize];
        }

        /// <summary>
        /// 移除代理
        /// </summary>
        public void OnRemove()
        {
            this.CloseConnect();
        }

        public void LinkServer(string ip, int port)
		{
            try
            {
                OnRegister();

                IPEndPoint epServer = new IPEndPoint(IPAddress.Parse(ip), port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socket.BeginConnect(epServer, new AsyncCallback(ConnectResult), socket);

                Debug.Log(" 开始与" + ip + ":" + port + "服务器进行连接 ");
            }
            catch (Exception exc)
            {
                this.CloseConnect();

                //netUnit.AddEvent(NotiConst.ConnectError, this.netUnit.netType);
                Debug.Log("1 与服务器进行连接异常" + exc.ToString());

                NetworkManagerV2.AddEvent(Protocal.ConnectError, new ByteBuffer());
            }
		}

		private void ConnectResult (IAsyncResult rec_socket)
		{
            try
            {
                this.socket = (Socket)rec_socket.AsyncState;
                this.socket.EndConnect(rec_socket);
                this.socket.NoDelay = true;

                this.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, 2000);
                this.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

                Debug.Log("与服务器" + this.socket.RemoteEndPoint + "连接成功");
                NetworkManagerV2.AddEvent(Protocal.Connect, new ByteBuffer());

                this.thd = new Thread(new ThreadStart(this.Work));
                this.thd.Start();
            }
            catch (Exception exc)
            {
                this.CloseConnect();
                //netUnit.AddEvent(NotiConst.ConnectError, this.netUnit.netType);
                Debug.Log(" 2 开始与服务器进行连接异常" + exc.ToString());

                NetworkManagerV2.AddEvent(Protocal.ConnectError, new ByteBuffer());
            }
		}




		public void Work ()
		{
			while (true) {
                try
                {
                    if (this.IsSocketConnected())
                    {
                        //如果远程主机处于关机状态或关闭了连接，则 Available 会引发 SocketException
                        //if (this.socket.Available != 0) 妈的这个有 BUG 别用

                        //C# 进行SOCKET开发---当连接与与服务器断开时的问题 http://blog.csdn.net/qwlovedzm/article/details/6171992
                        
                        //C# 如何判断socket连接断开？ http://bbs.csdn.net/topics/290010343
                        
                        //https://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.poll.aspx
                        //此方法不能检测某些类型的连接问题，例如，网络电缆中断或远程主机意外关闭。您必须尝试发送或接收数据以检测这些类型的错误
                        if (this.socket.Poll(0, SelectMode.SelectRead))
                        {
                            byte[] bt = new byte[buffSize];
                            int leng = this.socket.Receive(bt, bt.Length, SocketFlags.None);
                            //Debug.Log(" this.socket.Receiv leng  " + leng);
                            //为什么TCP Socket.Receive不阻塞，直接返回0字节
                            //https://social.msdn.microsoft.com/Forums/vstudio/zh-CN/fcc03f1b-4329-4bc7-be60-09210629169c/tcp-socketreceive0
                            if (leng <= 0)
                            {
                                CloseConnect();
                                NetworkManagerV2.AddEvent(Protocal.Disconnect, new ByteBuffer());
                                Debug.Log("net error  Receive 0 ");
                                break;
                            }
                            else
                            {
                                if (leng > buffSize - nowWriteIndex)
                                {
                                    Debug.Log("缓冲区不够了" + (buffSize - nowWriteIndex));
                                    byte[] newReceiveByte = new byte[buffSize];
                                    ByteCode.copyByte(allReceiveByte, nowReadIndex, newReceiveByte, 0, nowWriteIndex - nowReadIndex);
                                    allReceiveByte = newReceiveByte;
                                    nowWriteIndex = nowWriteIndex - nowReadIndex;
                                    nowReadIndex = 0;
                                }
                                ByteCode.copyByte(bt, 0, allReceiveByte, nowWriteIndex, leng);
                                //bt = null;
                                nowWriteIndex = nowWriteIndex + leng;
                                //Debug.Log(" nowWriteIndex  " + nowWriteIndex);
                                DecodeData();
                                //Debug.Log(" nowReadIndex  " + nowReadIndex);
                            }
                        }
                    }
                    else {
                        CloseConnect();
                        NetworkManagerV2.AddEvent(Protocal.Exception, new ByteBuffer());
                        Debug.Log("  !this.IsSocketConnected()  ");
                        break;
                    }
                }
                catch (Exception e)
                {
                    CloseConnect();
                    NetworkManagerV2.AddEvent(Protocal.Exception, new ByteBuffer());
                    Debug.Log("  net error  " + e.ToString());
                    break;
                }
                
                //when close connection
                //if not add below will raise
                //System.ObjectDisposedException: The object was used after being disposed.
                Thread.Sleep(10);
			}
		}
		
 		private void DecodeData ()
		{
				while (true) {
						if (nowPktLength == -1) {
                                //Debug.Log(" parse nowPktLength " + nowPktLength);
								if (nowWriteIndex - nowReadIndex >= 4) {
										byte[] B2 = new byte[4];
										ByteCode.copyByte (allReceiveByte, nowReadIndex, B2, 0, 4);
										nowReadIndex += 4;
										nowPktLength = ByteCode.getInt (B2, 0);
								} else {
										break;
								}
						}
			
						if (nowPktLength != -1) {
                                //Debug.Log(" deserialize nowPktLength " + nowPktLength);
								if (nowWriteIndex - nowReadIndex >= nowPktLength) {
										byte[] needReadBytes = new byte[nowPktLength];
										ByteCode.copyByte (allReceiveByte, nowReadIndex, needReadBytes, 0, nowPktLength);
										nowReadIndex += nowPktLength;
										nowPktLength = -1;


                                        ByteBuffer buffer = new ByteBuffer(needReadBytes);
                                        NetworkManagerV2.AddEvent(Protocal.Message, buffer);
								} else {
										break;
								}
						}
				}
		}

       
    
        public void SendMessage(ByteBuffer buffer)
        {
            try
            {
                if (this.IsSocketConnected())
                {
                    if (this.socket.Poll(0, SelectMode.SelectWrite))
                    {
                        //Serializer des = new Serializer();
                        //des.SendData(pkt, pkt.pktType);
                        ////SendData(des.sendBuff, des.nowWriteIndex);

                        byte[] bt = buffer.ToBytes();
                        int length = bt.Length;

                        byte[] bts = new byte[length + 4];
                        ByteCode.copyByte(bt, 0, bts, 4, length);
                        ByteCode.putInt(bts, length, 0);
                        this.socket.Send(bts);
                        
                        buffer.Close();
                    }
                    else
                    {
                        NetworkManagerV2.AddEvent(Protocal.Exception, new ByteBuffer());
                        //this.netUnit.AddEvent(NotiConst.NetError, this.netUnit.netType);
                        Debug.Log("this.IsSocketConnected() falase");
                    }
                }
                else
                {
                    NetworkManagerV2.AddEvent(Protocal.Exception, new ByteBuffer());
                    //this.netUnit.AddEvent(NotiConst.NetError, this.netUnit.netType);
                    Debug.Log("this.IsSocketConnected() falase");
                }

            }
            catch (Exception e)
            {
                NetworkManagerV2.AddEvent(Protocal.Exception, new ByteBuffer());
                Debug.Log(" net error " + e.ToString());
            }
        }


        //public void HeatUpdate ()
        //{
        //    //SendPacket (new HeatPacket ());
        //}

        /// <summary>
        /// 当socket.connected为false时，进一步确定下当前连接状态
        /// </summary>
        /// <returns></returns>
        private bool IsSocketConnected()
        {
            #region remarks
            /********************************************************************************************
             * 当Socket.Conneted为false时， 如果您需要确定连接的当前状态，请进行非阻塞、零字节的 Send 调用。
             * 如果该调用成功返回或引发 WAEWOULDBLOCK 错误代码 (10035)，则该套接字仍然处于连接状态；        
             * 否则，该套接字不再处于连接状态。
             * Depending on http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.connected.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-2
            ********************************************************************************************/
            #endregion

            //请检查 Connected 属性，然后检查连接的当前状态。

            #region 过程
            // This is how you can determine whether a socket is still connected.
            bool connectState = true;

            //if (this.socket == null || !this.socket.Connected) return false;

            bool blockingState = this.socket.Blocking;
            try
            {
                byte[] tmp = new byte[1];

                this.socket.Blocking = false;
                this.socket.Send(tmp, 0, 0);
                //Console.WriteLine("Connected!");
                connectState = true;    //若Send错误会跳去执行catch体，而不会执行其try体里其之后的代码
            }
            catch (SocketException e)
            {
                // 10035 == WSAEWOULDBLOCK
                if (e.NativeErrorCode.Equals(10035))
                {
                    //Console.WriteLine("Still Connected, but the Send would block");
                    connectState = true;
                }

                else
                {
                    //Console.WriteLine("Disconnected: error code {0}!", e.NativeErrorCode);
                    connectState = false;
                }
            }
            finally
            {
                this.socket.Blocking = blockingState;
            }

            //Console.WriteLine("Connected: {0}", client.Connected);
            return connectState;
            #endregion
        }
}

