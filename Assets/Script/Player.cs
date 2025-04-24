using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float speed;
    private Vector3 mov;
    [SerializeField] private float jumpforce;
    public bool Activo=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (!Activo)
        {
            return;
        }
        rb.linearVelocity = new Vector3(mov.x, rb.linearVelocity.y, mov.z);
    }
    private void OnEnable()
    {
        InputReader.Movimiento += Movment;
        InputReader.JumpPlayer += Salto;
    }
    private void OnDisable()
    {
        InputReader.Movimiento -= Movment;
        InputReader.JumpPlayer -= Salto;
    }
    public void Movment(Vector2 direction)
    {
        if (!Activo)
        {
            return;
        }
        mov = new Vector3(direction.x, 0, direction.y);
    }
    public void Salto()
    {
        if (!Activo)
        {
            return;
        }
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
    }
}
