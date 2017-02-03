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
   
	//预加载
	public void PreLoad()
	{
		if (mainCom == null)
		{
			Create();
		}
	}

	public virtual void Init() { }
	
	/// <summary>
	/// 这里要注意优先吧UIPackage加到包里面
	/// </summary>
	/// <returns></returns>
	public void Create()
	{
		//create mainCom by lua

		//        mainCom = UIPackage.CreateObject(pkgPath, mainPath).asCom;
		//        mainCom.SetSize(GRoot.inst.width, GRoot.inst.height);
		//        mainCom.AddRelation(GRoot.inst, RelationType.Size);
		//        GRoot.inst.AddChild(mainCom);

		this.mainCom.visible = false;

		OnInitWidget();
	}

	public void Show()
	{
		if (mainCom == null)
		{
			Create();
		}
		
		if (mainCom != null && !this.isVisable) {

			OnWillApprear();
			OnAddListener();
			
			if (animationCallBack != null) {
				animationCallBack(Appear);
			}
			else {
				Appear();
			}
		}
		else {
			Debug.LogError("this ?");
		}
	}

	void Appear()
	{
		mainCom.visible = true;
		OnDidAppear();
	}

	
	public void Hide(bool force = false)
	{
		if (this.mainCom != null && this.isVisable) {
			OnRemoveListener();
			OnWillDisappear();
			
			if (force) animationDisappearCallBack = null;
			
			if (animationDisappearCallBack != null) {
				animationCallBack(DisAppear);
			}
			else {
				DisAppear();
			}
		}
		else {
			Debug.LogError("this?!");
		}
	}


	void DisAppear() 
	{
		OnDidDisappear();
		
		if (mResident) {
			mainCom.visible = false;
		}
		else {
			Destroy();
		}
	}

	//销毁窗体
	public void Destroy()
	{
		OnRealseWidget();

		this.mainCom.Dispose();
		this.mainCom = null;
	}

	//类对象释放
	public virtual void Release() { }
	
	public virtual void Update() { }
    

    ////////// event callback /////

    //窗口控制初始化 这个相当于显示对象第一次生成
    public virtual void OnInitWidget() { }

    //游戏事件注册
    protected virtual void OnAddListener() { }
    //将要显示
    public virtual void OnWillApprear() { }
    
    //真正显示
    public virtual void OnDidAppear() {  }

    //游戏事件注销
    protected virtual void OnRemoveListener() { }
    //将要隐藏
    public virtual void OnWillDisappear() { }
    
    
    ///真正关闭
    public virtual void OnDidDisappear() { }

    
    //窗口释放
    public virtual void OnRealseWidget() { }
}
