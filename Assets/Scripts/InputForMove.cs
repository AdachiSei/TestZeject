using UnityEngine;
using Zenject;

public class InputForMove : MonoBehaviour
{
    [Inject]
    private IInputtable _inputObject;

    void Update()
    {
        if (_inputObject != null)
        {
            Move(_inputObject.InputForMove());
        }
    }

    void Move(Vector3 vec)
    {
        var position = transform.localPosition;
        transform.localPosition = position + vec;
    }
}