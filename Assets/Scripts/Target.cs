using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Transform[] _points;

    private int _currentPoint = 0;

    private void Update()
    {
        if (transform.position == _points[_currentPoint].position)
            _currentPoint = (_currentPoint + 1) % _points.Length;

        transform.position = Vector3.MoveTowards(transform.position, _points[_currentPoint].position, _speed * Time.deltaTime);
    }
}
