---
--- Created by PC.
--- DateTime: 2017/5/13 23:36
---

local dag = class('Dog', super)
---@class test
function dag.say()
    print("hello")
    self:saySelf()
end

function dag:saySelf()
    print("saySelf")
    self:saySelf()
end
function dag.NotSay()

end