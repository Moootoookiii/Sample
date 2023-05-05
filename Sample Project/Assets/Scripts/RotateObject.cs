using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private float angle;

    private void Update()
    {
        if(RotateButton.onButtonDown)
        {
            angle += _rotateSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        
    }
}