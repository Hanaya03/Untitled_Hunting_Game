using UnityEngine;

public class DodgeState : PlayerState
{
    public DodgeState(PlayerContext context, PlayerStateManager.EPlayerState estate) : base(context, estate){
        PlayerContext Context = context;
    }

    public override void EnterState(){Debug.Log("Entering dodge state!");}
    public override void ExitState(){Debug.Log("Exiting dodge state!");}
    public override void UpdateState(){Debug.Log("Updating dodge state!");}
    public override PlayerStateManager.EPlayerState GetNextState(){return StateKey;}
    public override void OnTriggerEnter(Collider other){}
    public override void OnTriggerStay(Collider other){}
    public override void OnTriggerExit(Collider other){}
}
