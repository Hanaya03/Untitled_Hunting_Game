using UnityEngine;

public class PlayerStateManager : StateManager<PlayerStateManager.EPlayerState>
{
    public enum EPlayerState{
        Idle,
        FreeMove,
        Dodge,
    }

    private PlayerContext _context;

    [SerializeField] private Rigidbody _playerRB;

    void Awake(){
        _context = new PlayerContext(_playerRB);
        InitializeStates();
    }

    void Start(){
        CurrentState = States[EPlayerState.Idle]; 
    }

    private void InitializeStates(){
        States.Add(EPlayerState.Idle, new IdleState(_context, EPlayerState.Idle));
        States.Add(EPlayerState.FreeMove, new FreeMoveState(_context, EPlayerState.FreeMove));
        States.Add(EPlayerState.Dodge, new DodgeState(_context, EPlayerState.Dodge));
        CurrentState = States[EPlayerState.Idle];
    }
}
