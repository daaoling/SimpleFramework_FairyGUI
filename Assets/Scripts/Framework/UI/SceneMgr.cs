using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SceneMgr : Singleton<SceneMgr>
{
    public GameObject root = null;

    public BaseScene current;

    public Dictionary<SceneId, BaseScene> scenes = new Dictionary<SceneId, BaseScene>();

    public Callback<SceneId> onShowSceneSignal;
        
    public GameObject top_message_panel = null;

    /// <summary>
    /// 添加顶部跑马灯
    /// </summary>
    public void AddTopMessage()
    {
        //if (SceneMgr.Instance.top_message_panel == null)
        //{
        //    SceneMgr.Instance.top_message_panel = NGUITools.AddChildV2(
        //        SceneMgr.Instance.current.gameObject,
        //        UI.systemPanelPath + "/" + UI.announcement
        //    );
        //}   
    }

        public SceneMgr()
        {
            Debug.Log(" SceneMgr ");

            //RoleModel.Instance.levelReallyChangeSignal += OnLevelChanged;
            //RoleModel.Instance.energyChangeSignal += OnEnergyChanged;
        }    

        public void SwitchingScene(SceneId senceId, params object[] sceneArgs)
        {
            if (current != null && senceId == current.sceneId)
            {
                Debug.Log("  试图切换场景至当前场景：" + current.sceneId.ToString());
                return;
            }

            HideCurrentScene();

            ShowScene(senceId, sceneArgs);
        }

        private void ShowScene(SceneId sceneId, params object[] sceneArgs)
        {
            //GameObject go = new GameObject(sceneId.ToString());

            //Transform t = go.transform;
            ////t.parent = (root == null ? UIRoot.list[0].transform : root.transform);
            //t.parent =
            //    //GameMain.Instance._2DUI.transform;
            //    GameObject.Find("2DUI").transform;
            //t.localPosition = Vector3.zero;
            //t.localRotation = Quaternion.identity;
            //t.localScale = Vector3.one;
            ////go.layer = (root == null ? UIRoot.list[0].gameObject.layer : root.layer);
            //go.layer = 
            //    //GameMain.Instance._2DUI.layer;
            //    GameObject.Find("2DUI").layer;
            //current = go.AddComponent(sceneId.ToString()) as BaseScene; //sceneType.tostring等于该场景的classname
            //current.Init(sceneId, sceneArgs);
            //current.InitScene();
            //if (sceneId != SceneId.FightScene && sceneId != SceneId.EndScene)
            //{
            //    string prefabPath = UI.AfterLoadingPanelAnimation;
            //    GameObject child = NGUITools.AddChildV2(go, prefabPath);
            //    child.GetComponent<mAnimation>().isPalyEndDstory = true;
            //}

            //scenes.Add(current.sceneId, current);

            //if (onShowSceneSignal != null) onShowSceneSignal(sceneId);
            
        }

        public void HideCurrentScene()
        {
            //if (current != null)
            //{
            //    current.ReleaseScene();
                
            //    UnityEngine.Object.Destroy(current.gameObject);

            //    scenes.Remove(current.sceneId);
            //}
        }

        /// <summary>
        /// 当网络延迟的时候
        /// </summary>
        public GameObject waiting = null; ///网络延迟 显示面板
        public void OnWaitingForNet(bool isWait)
        {
            //Debug.Log(" OnWaitingForNet " + isWait);

            //if (isWait && waiting == null)
            //{
            //    string path = UI.systemCommonPanelPath + "/" + PANEL_ID.common_WaitingForNetResponse.ToString();
            //    GameObject prefab = NGUITools.LoadAsset<GameObject>(path);
            //    this.waiting = NGUITools.AddChild(current.gameObject, prefab);
            //}
            //else if(!isWait && waiting != null)
            //{
            //    NGUITools.Destroy(waiting);
            //    this.waiting = null;
            //}
        }

        public void OnConnectError(object arg)
        {
            //NetType netType = (NetType)arg;
            //ShowReconnectView(netType);

            //Debug.Log(" 1........... OnConnectError  " + netType.ToString() + " ShowReconnectView ");
        }
        public void OnNetError(object arg)
        {
            //NetType netType = (NetType)arg;
            //ShowReconnectView(netType);
        }

        //public void ShowReconnectView(NetType netType)
        //{
            //string path = UI.systemCommonPanelPath + "/" + PANEL_ID.common_reconnect.ToString();
            //GameObject prefab = NGUITools.LoadAsset<GameObject>(path);
            //GameObject ready_reconnect = NGUITools.AddChild(current.gameObject, prefab);
            //ready_reconnect.GetComponent<common_reconnect>().netType = netType;
        //}

        //public void OnLevelChanged(int oldLevel, int newLevel) {
        //    if (rolePanel == null) CreateRoleChangeTipPanel();
        //    rolePanel.GetComponent<RoleLevelUpTipPanel>().InitView(oldLevel, newLevel);
        //}
        //public void OnEnergyChanged(int oldValue, int newValue) {
        //    if (rolePanel == null) CreateRoleChangeTipPanel();
        //    rolePanel.GetComponent<RoleLevelUpTipPanel>().InitEnergy(oldValue, newValue);
        //}

		/// <summary>
		/// show get soul
		/// </summary>
		public void ShowGetSoul(int soulId, Callback destorySignal = null){
            //SceneMgr.Instance.ShowGetSoul

            //Debug.Log(" ShowGetSoul soulId " + soulId);

            //ConfigHeroVo staticHeroVo = 
            //    GameMain.Instance.staticDataPool.configHeroPool.GetConfigHeroVo(soulId);
            //string path =
            //    UI.systemCommonPanelPath + "/" + UI.GetSoulPanel + "_" + staticHeroVo.quality;
            //GameObject goObj = 
            //    UnityEngine.Object.Instantiate(Resources.Load(path)) as GameObject;
			
            //goObj.transform.parent = current.transform;
            //goObj.transform.localPosition = Vector3.zero;
            //goObj.transform.localScale = Vector3.one;

            //goObj.GetComponent<GetSoulPanel>().Show(soulId, destorySignal);
		}


        public void Update(float deltaTime)
        {
            ///小红点管理器更新
            //RubyManager.Instance.Update(deltaTime);
        }
        
}


