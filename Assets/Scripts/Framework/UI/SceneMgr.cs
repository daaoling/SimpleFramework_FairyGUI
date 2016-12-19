using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SceneMgr : Singleton<SceneMgr>
{
    public BaseScene current;

    public Dictionary<SceneId, BaseScene> scenes = new Dictionary<SceneId, BaseScene>();

    public void SwitchingScene(SceneId senceId)
    {
        if (current != null && senceId == current.sceneId)
        {
            Debug.Log("  试图切换场景至当前场景：" + current.sceneId.ToString());
            return;
        }

        HideCurrentScene();

        ShowScene(senceId, scenes[senceId]);
    }

    private void ShowScene(SceneId sceneId, BaseScene current)
    {

        current.Init(sceneId);
        current.InitScene();
    }

    public void HideCurrentScene()
    {
        if (current != null)
        {
            current.ReleaseScene();
            current.Release();

            scenes.Remove(current.sceneId);
        }
    }

    public void Update()
    {
        if (current != null) current.Update();
    }
        
}


