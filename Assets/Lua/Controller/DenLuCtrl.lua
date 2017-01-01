local DenLuCtrl = class("DenLuCtrl")
function DenLuCtrl:Start()
  log("MainCtrl:Start")
  UIMgr.ShowPage(DengLuPanelList.DengLuPanel)
end



return DenLuCtrl