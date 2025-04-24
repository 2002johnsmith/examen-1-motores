using UnityEngine;
using UnityEngine.InputSystem;
using System;
public class InputReader : MonoBehaviour
{
    public static event Action<Vector2> Movimiento;
    public static event Action changePlayer;
    public static event Action JumpPlayer;
    public static event Action changeAtras;

    public void Movimientoo(InputAction.CallbackContext context)
    {
        Movimiento?.Invoke(context.ReadValue<Vector2>());
    }
    public void Jumpplayer(InputAction.CallbackContext context)
    {
        JumpPlayer?.Invoke();
    }
    public void Change(InputAction.CallbackContext context)
    {
        changePlayer?.Invoke();
    }
    public void ChangeBack(InputAction.CallbackContext context)
    {
        changeAtras?.Invoke();
    }
}
