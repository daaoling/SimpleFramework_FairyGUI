using UnityEngine;
using System.Collections;
using FairyGUI;

public class fairygui_test : MonoBehaviour 
{


	private GComponent _mainView;

	// Use this for initialization
	void Start () {
	
		#if UNITY_WEBPLAYER || UNITY_WEBGL || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR
		CopyPastePatch.Apply();
		#endif

		Application.targetFrameRate = 60;
	
//		Stage.inst.onKeyDown.Add(OnKeyDown);
		
		

        //EventContext

		


        DemoStart();
	}


    void DemoStart()
    {
        UIConfig.defaultFont = "afont";

		GRoot.inst.SetContentScaleFactor(1152,648);

        UIPackage.AddPackage("UI/Common");
        UIPackage.AddPackage("UI/DengLu");
        UIPackage.AddPackage("UI/Main");

        UIPackage.AddPackage("UI/DengLu");
        GComponent mainView = UIPackage.CreateObject("DengLu", "Main").asCom;
        mainView.SetSize(GRoot.inst.width, GRoot.inst.height);
        mainView.AddRelation(GRoot.inst, RelationType.Size);
        GRoot.inst.AddChild(mainView);


        //GComponent n9 = mainView.GetChild("n9").asCom;
        //GComponent mainView2 = UIPackage.CreateObject("Main", "Main").asCom;
        //n9.AddChild(mainView2);
    }
}
