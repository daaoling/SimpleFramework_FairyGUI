local DengLuPanel = class("DengLuPanel", framework_ui_basePage)

function DengLuPanel:ctor()
  DengLuPanel.super.ctor(self, false, "DengLu", "Main")
end


--function DengLuPanel.OnClick()
--  log('you click')
--end

--function DengLuPanel:OnClick_Arg(context)
--	log('you OnClick_Arg'..context.sender.name)
----  MyApp.enterScene("MainScene")
--end



function DengLuPanel:OnInitWidget()
  self.LoginCom = self.mainCom:GetChild("n8")

  self.LoginBtn = self.LoginCom:GetChild("n5")
  self.LoginInput = self.LoginCom:GetChild("username")

  self.RegisterBtn = self.LoginCom:GetChild("n6")  
  self.RegisterInput = self.LoginCom:GetChild("password")
end

return DengLuPanel