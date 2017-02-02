using UnityEngine;
using System.Collections;
using FairyGUI;

namespace LuaFramework
{
    public class GameManagerV2 : Manager
    {

        /// <summary>
        /// 初始化游戏管理器
        /// </summary>
        void Start()
        {
            Init();
        }


        void Init()
        {
            DontDestroyOnLoad(gameObject);  //防止销毁自己

            OnResourceInited();
        }

        public void OnResourceInited()
        {
            UIConfig.defaultFont = "afont";
            GRoot.inst.SetContentScaleFactor(1152, 648);

            LuaManager.InitStart();
            //LuaManager.DoFile("Logic/Game");            //加载游戏
            //LuaManager.DoFile("Logic/Network");         //加载网络
            //NetManager.OnInit();

            //Util.CallMethod("Game", "OnInitOK");          //初始化完成
        }
    }
}

