local UIMgr = class("UIMgr")

function UIMgr:ctor()
  self.pages = {}
end

function UIMgr:ShowPage(pageName)
  curPage = self.pages[pageName]
  curPage:Show()
end

function UIMgr:Hide(pageName)
  curPage = self.pages[pageName]
  curPage:Hide()
end

return UIMgr