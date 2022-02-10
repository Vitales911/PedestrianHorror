using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public float ForceValue;
    private Rigidbody rb;
    public DeadPlayer deadPlayer;
    public GameObject PanelDead;
    public PlayerWin playerWin;
    public GameObject PanelWon;
    private bool _wait = false;
    private float Second = 3f;
    public Text timerStart;
    public GameObject _timerStart;

    void Start()
    {
        timerStart.text = Second.ToString();
        Physics.gravity = new Vector3(0, -20, 0);
        rb = GetComponent<Rigidbody>();
        SwipePlayer.SwipeEvent += OnSwipe;
        StartCoroutine(Wait());
    }
    private void OnSwipe(Vector2 direction)
    {
        Vector3 dir =
            direction == Vector2.up ? Vector3.forward : 
            direction == Vector2.down ? Vector3.back : (Vector3)direction;

        Move(dir);
    }
    void Update()
    {
        if (Second > 0)
        {
            Second -= Time.deltaTime;
            timerStart.text = Mathf.Round(Second).ToString();

        }
        if (_wait == true)
        {
        if (Input.GetKeyDown(KeyCode.A))
            Move(Vector3.left);
        else if (Input.GetKeyDown(KeyCode.D))
            Move(Vector3.right);
        else if (Input.GetKeyDown(KeyCode.W))
            Move(Vector3.forward);
        else if (Input.GetKeyDown(KeyCode.S))
            Move(Vector3.back);
        }


        Lose();
        Won();
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(Second);
        _wait = true;
        _timerStart.SetActive(false);
    }
    private void Move(Vector3 direction)
    {
        rb.AddRelativeForce(direction * ForceValue);
    }

    public void Lose()
    {
        if (deadPlayer.Dead == true)
        {
            PanelDead.SetActive(true);
        }
        
    }
    public void Won()
    {
        if (playerWin.Won == true)
        {
            PanelWon.SetActive(true);
        }
    }
}
