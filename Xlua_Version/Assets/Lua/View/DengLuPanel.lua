local DengLuPanel = class("DengLuPanel", framework_ui_basePage)

function DengLuPanel:ctor()
  DengLuPanel.super.ctor(self, false, "DengLu", "Main")
end

function DengLuPanel:OnClick()
	log('you click'..self.pkgPath)
  MyApp.enterScene("MainScene")
end

function DengLuPanel:OnInitWidget()
  self.mainCom.onClick:Add(FairyGUI.EventCallback0(handler(self, DengLuPanel.OnClick)))
end

return DengLuPanel