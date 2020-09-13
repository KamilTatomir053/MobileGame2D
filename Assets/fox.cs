using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fox : MonoBehaviour
{
    public Transform[] positions;

    public int position = 2;

    public float speed = 0.1f;

    int points = 0;

    public Text score;

    public GameObject button;

    public GameObject boxes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, positions[position].position, speed);

        if (Input.GetKeyDown(KeyCode.LeftArrow)) Left();
        if (Input.GetKeyDown(KeyCode.RightArrow)) Right();
    }

    public void Left()
    {
        if (position > 0)
        {
            position--;
        }
    }

    public void Right()
    {
        if (position < positions.Length - 1)
        {
            position++;
        }
    }

    public void AddPoint()
    {
        points++;

        score.text = "Score: " + points;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("box") == true)
        {
            button.SetActive(true);

            gameObject.SetActive(false);

            boxes.GetComponent<boxes>().Stop();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
