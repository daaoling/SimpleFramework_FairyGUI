local BasePage = class("UIPage")

function BasePage:ctor()
  self:mainCom = nil
end

function BasePage:Create()
  self:OnInitWidget()
end

function BasePage:Show()
  if not self:mainCom then
    self:Create()
  end
  
  self:mainCom:visible = true
  self:OnWillApprear()
  self:OnDidAppear()
end




function BasePage:Hide()
  self:mainCom:visible = false
  self:OnWillDisappear()
  self:OnDidDisappear()
end




function BasePage:Destroy()
  this.mainCom.Dispose();
  this.mainCom = null;
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
