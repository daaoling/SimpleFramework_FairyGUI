FSM = {}
FSM.__index = FSM 

function FSM:New()
  o = setmetatable({}, self)
  o.states = {}
  o.curState = nil
  return o
end

function FSM:AddInitState(baseState)
  self.states[baseState.Name] = baseState
  self.curState = baseState
end

function FSM:AddState(baseState)
  self.states[baseState.Name] = baseState
end

function FSM:SwitchState(transitionName)
  if(self.curState.Name ~= transitionName) then
      self.curState:Leave()
      self.curState = self.states[transitionName]
      self.curState:Before()
  end
end

function FSM:Update()
  self.curState:Update()
end
