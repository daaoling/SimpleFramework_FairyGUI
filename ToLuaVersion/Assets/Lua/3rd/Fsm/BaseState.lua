BaseState = {}
BaseState.__index = BaseState
function BaseState:New(Name)
  o = setmetatable({}, self)
  o.Name = Name
  return o
end

function BaseState:Before()
  print(" Before " .. self.Name)
end

function BaseState:Update()
  print(" Update " .. self.Name)
end

function BaseState:Leave()
  print(" Leave " .. self.Name)
end