local MainCtrl = class("MainCtrl")
function MainCtrl:Start()
  log("MainCtrl:Start")
  UIMgr.ShowPage(MainPanelList.MainPanel)
end
return MainCtrl