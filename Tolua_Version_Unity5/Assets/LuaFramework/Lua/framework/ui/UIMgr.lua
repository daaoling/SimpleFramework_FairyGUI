class("UIMgr")
---@class UIMgrO
---@field public pages table

---@return UIMgr
function UIMgr.Instance()
    if UIMgr.instance == nil then
        UIMgr.instance = UIMgr.new()
    end
    return UIMgr.instance
end


function UIMgr:Init(panelList)
    self.pages = {}
    logWarn("UIMgr.Init----->>>");
    for k,v in pairs(panelList) do
        local moduleName = "View."..v
        require(moduleName)
        self.pages[k] = _G[v].new()
        print(moduleName, _G[v], self.pages[k])
    end
end

function UIMgr:ShowPage(pageName)
  local curPage = self.pages[pageName]
  curPage:Show()
  return curPage
end

function UIMgr:Hide(pageName)
  local curPage = self.pages[pageName]
  curPage:Hide()
end


function UIMgr:ClearScene()
  for k,page in pairs(self.pages) do
    page:Hide()

    local mResident = page.mResident
    if mResident ~= false then
      page:Destroy()
    end
  end
end

--local M = { }
--
--UIMgr = M
--
--M.pages = nil
--
--function M.Init(panelList)
--  M.pages = {}
--	logWarn("UIMgr.Init----->>>");
--  for k,v in pairs(panelList) do
--     M.pages[k] = require("View/"..v).new()
--  end
--end
--
--function M.ShowPage(pageName)
--  local curPage = M.pages[pageName]
--  curPage:Show()
--  return curPage
--end
--
--function M.Hide(pageName)
--  local curPage = M.pages[pageName]
--  curPage:Hide()
--end
--
--function M.ClearScene()
--  for k,page in pairs(M.pages) do
--    page:Hide()
--
--    local mResident = page.mResident
--    if mResident ~= false then
--      page:Destroy()
--    end
--
--  end
--end
--
--return M