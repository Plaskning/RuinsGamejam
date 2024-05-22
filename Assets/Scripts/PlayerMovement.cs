using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    #region Variables
    [SerializeField] private float moveSpeed;
    [SerializeField] public Vector2 velocity;
    [SerializeField] private int UpwardrotationAmount;
    [SerializeField] private int DownwardrotationAmount;
    [SerializeField] private bool isFacingUp;

    [SerializeField] Score scoreManager;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(velocity.x, 0);
        velocity = new Vector2(velocity.x * moveSpeed, velocity.y * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = velocity;

        if (Input.GetMouseButtonDown(0) && scoreManager.money > 0)
        {
            SwitchDirection(100);
        }
    }

    public void SwitchDirection(int scoreChange)
    {

        //Spawna in en grej
        //sfx
        //cool stuff
        scoreManager.LoseScore(scoreChange);
        if (isFacingUp)
        {
            isFacingUp = false;
            velocity = new Vector2(rb.velocity.x, -1 * velocity.y);
            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, DownwardrotationAmount);
        }
        else if (!isFacingUp)
        {
            isFacingUp = true;
            velocity = new Vector2(rb.velocity.x, -1 * velocity.y);
            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, UpwardrotationAmount);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TopWall") && isFacingUp)
        {
            SwitchDirection(0);
        }
        else if (other.CompareTag("BotWall"))
        {
            Debug.Log("End screen");
            SceneManager.LoadScene("EndMenu");
        }
    }
}
