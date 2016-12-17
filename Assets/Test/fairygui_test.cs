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
		GRoot.inst.SetContentScaleFactor(1152, 648);
//		Stage.inst.onKeyDown.Add(OnKeyDown);
		
		UIPackage.AddPackage("UI/DengLu");

		_mainView = UIPackage.CreateObject("DengLu", "Main").asCom;
		_mainView.fairyBatching = true;
		_mainView.SetSize(GRoot.inst.width, GRoot.inst.height);
		_mainView.AddRelation(GRoot.inst, RelationType.Size);
		GRoot.inst.AddChild(_mainView);

	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
}
