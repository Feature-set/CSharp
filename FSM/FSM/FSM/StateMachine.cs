using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    internal class StateMachine
    {
        private State curState;
        
        public StateMachine()
        {
            // 초기값 선언
            curState = State.Idle;
        }

        public void TransState(State inputState)
        {
            // 상태 변경
            curState = inputState;
        }
    }
}
