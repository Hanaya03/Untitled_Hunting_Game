using UnityEngine;

public class FreeMoveState : PlayerState
{
    public FreeMoveState(PlayerContext context, PlayerStateManager.EPlayerState estate) : base(context, estate){
        PlayerContext Context = context;
    }

    public override void EnterState(){Debug.Log("Entering freemove state!");}
    public override void ExitState(){Debug.Log("Exiting freemove state!");}
    public override void UpdateState(){Debug.Log("Updating freemove state!");}
    public override PlayerStateManager.EPlayerState GetNextState(){return StateKey;}
    public override void OnTriggerEnter(Collider other){}
    public override void OnTriggerStay(Collider other){}
    public override void OnTriggerExit(Collider other){}
}
