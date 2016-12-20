using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseScene
{
    public SceneId sceneId;
    public Dictionary<PanelId, UIPage> panels;

    public virtual void Init(SceneId sceneId)
    {
        this.sceneId = sceneId;
        this.panels = new Dictionary<PanelId, UIPage>();

        ///添加对应的UIPackage

        ///你需要在这里初始化所有的UIPage Setting
    }
    
    /// <summary>
    /// add all Panel
    /// 监听错误处理
    /// </summary>
    public virtual void InitScene()
    {
        foreach (PanelId panelId in panels.Keys)
        {
            UIPage bPanel = panels[panelId];
            bPanel.Init();

            if (bPanel.mResident)
            {
                bPanel.PreLoad();
            }
        }
    }

    public virtual void ReleaseScene()
    {
        foreach (PanelId panelId in panels.Keys)
        {
            UIPage bPanel = panels[panelId];

            bPanel.Hide(true);
            if (bPanel.mResident)
                bPanel.Destroy();

            bPanel.Release();
        }

        panels.Clear();
    }

    public virtual void Release()
    {

    }

    public virtual void Update()
    {
        foreach (UIPage pWindow in panels.Values)
        {
            if (pWindow.isVisable)
            {
                pWindow.Update();
            }
        }
    }


    

    /// <summary>
    /// UI 的管理 涉及
    ///         是否异步生成
    ///        
    ///         是否同步显示
    /// 
    /// </summary>
    /// <param name="pageName"></param>
    /// <param name="page"></param>
    /// <param name="isAsync"> 
    ///     是否同步显示
    ///         比如抽奖面板 你需要一个个显示出来 那么就是异步生成 那么就可以 loadFunc(callBack)
    ///         loadFunc 里面延时处理 callBack 生成回调
    /// </param>
    /// <param name="callBack"></param>
    public void ShowPage(string pageName, UIPage page, 
        bool isAsync,
           Callback<Callback> loadFunc, Callback callBack)
    {
        if (string.IsNullOrEmpty(pageName) || page == null)
        {
            Debug.LogError(" string.IsNullOrEmpty(pageName) || page == null ");
            return;
        }

        //if (isAsync)
            //page.Show(callBack);
        else
            page.Show();
    }
}


