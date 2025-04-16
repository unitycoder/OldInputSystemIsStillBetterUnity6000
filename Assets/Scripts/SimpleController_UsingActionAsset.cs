using UnityEngine;

// Use action set asset instead of lose InputActions directly on component.
public class SimpleController_UsingActionAsset : MonoBehaviour
{
    public float moveSpeed;
    private SimpleControls m_Controls;

    public void Awake()
    {
        m_Controls = new SimpleControls();
    }

    public void OnEnable()
    {
        m_Controls.Enable();
    }

    public void OnDisable()
    {
        m_Controls.Disable();
    }

    public void Update()
    {
        var move = m_Controls.gameplay.move.ReadValue<Vector2>();
        Move(move);
    }

    private void Move(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * moveSpeed * Time.deltaTime;
    }
}
