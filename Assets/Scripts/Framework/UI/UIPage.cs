using UnityEngine;
using System.Collections;
using FairyGUI;


public enum PanelId
{
    Login
}

//public enum UIType
//{
//    Normal,
//}

public enum SceneId
{
    ReadyLinkPtScene ///准备连接游戏
}



public class UIPage
{
    #region 必须设置
    public PanelId panelId;
    public bool mResident = true;  //是否常驻内存
    public string pkgPath = string.Empty;
    public string mainPath = string.Empty;
    #endregion

    #region 可选设置
    public Callback<Callback> animationCallBack = null; ///显示动画函数
    public Callback<Callback> animationDisappearCallBack = null; ///关闭动画函数 
    #endregion

    public GComponent mainCom;
    public bool isVisable { get { return mainCom.visible; } }///当前是否可见标志位
   
    
    /// <summary>
    /// 这里要注意优先吧UIPackage加到包里面
    /// </summary>
    /// <returns></returns>
    public bool Create()
    {
        mainCom = UIPackage.CreateObject(pkgPath, mainPath).asCom;
        mainCom.SetSize(GRoot.inst.width, GRoot.inst.height);
        mainCom.AddRelation(GRoot.inst, RelationType.Size);
        GRoot.inst.AddChild(mainCom);

        return true;
    }

   

   
    

    //////////////////////////////////////

    public virtual void Init() { }

    //窗口控制初始化 这个相当于显示对象第一次生成
    public virtual void InitWidget() { }

    //游戏事件注册
    protected virtual void OnAddListener() { }
    //将要显示
    public virtual void WillApprear() { }
    
   
    //真正显示
    public virtual void OnDidAppear() 
    {

    }

    //游戏事件注销
    protected virtual void OnRemoveListener() { }
    //将要隐藏
    public virtual void WillDisappear() { }
    
    
    ///真正关闭
    public virtual void OnDidDisappear() 
    {
        if (mResident) {
            mainCom.visible = false;
        }
        else {
            RealseWidget();
            Destroy();
        }
    }

    
    //窗口释放
    public virtual void RealseWidget() { }

    //类对象释放
    public virtual void Release() { }

    public virtual void OnUpdate() { }

    //预加载
    public void PreLoad()
    {
        if (mainCom == null)
        {
            if (Create())
            {
                InitWidget();
            }
        }
    }

    public void Show()
    {
        if (mainCom == null)
        {
            if (Create())
            {
                InitWidget();
            }
        }

        if (mainCom != null && !this.isVisable) {
            WillApprear();
            OnAddListener();

            if (animationCallBack != null) {
                AnimationShow(OnDidAppear);
            }
            else {
                OnDidAppear();
            }
        }
        else {
            Debug.LogError("this ?");
        }
    }
    void AnimationShow(Callback callBack)
    {
        animationCallBack(callBack);
    }

    public void Hide(bool force = false)
    {
        if (this.mainCom != null && this.isVisable) {
            OnRemoveListener();
            WillDisappear();

            if (force) animationDisappearCallBack = null;

            if (animationDisappearCallBack != null) {
                AnimationHide(OnDidDisappear);
            }
            else {
                OnDidDisappear();
            }
        }
        else {
            Debug.LogError("this?!");
        }
    }
    void AnimationHide(Callback callBack)
    {
        animationCallBack(callBack);
    }


    //延时删除
    public void DelayDestroy()
    {
        RealseWidget();
        Destroy();
    }
    

    //销毁窗体
    protected void Destroy()
    {
        this.mainCom.Dispose();
        this.mainCom = null;
    }
}
