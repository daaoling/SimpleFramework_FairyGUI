BaseState = class()

function BaseState:init(x)
  self.Name = x
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