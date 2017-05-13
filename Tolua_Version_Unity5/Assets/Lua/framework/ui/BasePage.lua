local BasePage = class("BasePage")

function BasePage:ctor(mResident, pkgPath, mainPath)
  self.mainCom = nil
  self.mResident = mResident
  self.pkgPath = pkgPath
  self.mainPath = mainPath
end

function BasePage:Create()
--  self:mainCom = UIPackage.CreateObject(pkgPath, mainPath)
--  self:mainCom:SetSize(GRoot.inst:width, GRoot.inst:height)
--  self:mainCom:AddRelation(GRoot.inst, RelationType.Size)
--  GRoot.inst:AddChild(mainCom)

  self.mainCom = CS.FairyGUI.UIPackage.CreateObject(self.pkgPath, self.mainPath)
  self.mainCom:SetSize(CS.FairyGUI.GRoot.inst.width, CS.FairyGUI.GRoot.inst.height)
  self.mainCom:AddRelation(CS.FairyGUI.GRoot.inst, CS.FairyGUI.RelationType.Size)
  CS.FairyGUI.GRoot.inst:AddChild(self.mainCom)
  
  self:OnInitWidget()
end

function BasePage:Show()
  if not self.mainCom then
    self:Create()
  end
  self:OnWillApprear()
  
  self.mainCom.visible = true
  self:OnDidAppear()
end

function BasePage:Hide()
  self:OnWillDisappear()
  
  self:OnDidDisappear()
  if self.mResident then
    self.mainCom.visible = false
  else
    self:Destroy()
  end
end

function BasePage:Destroy()
  self.mainCom:Dispose();
  self.mainCom = null;
  self:OnRealseWidget();
end

--窗口控制初始化 这个相当于显示对象第一次生成
function BasePage:OnInitWidget()
end

--将要显示
function BasePage:OnWillApprear()
end

--真正显示
function BasePage:OnDidAppear()
end

--将要隐藏
function BasePage:OnWillDisappear()
end

--真正关闭
function BasePage:OnDidDisappear()
end

function BasePage:OnRealseWidget()
end

return BasePage
