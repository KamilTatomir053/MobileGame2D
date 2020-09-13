using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    public Transform[] boxPositions;

    public GameObject box;

    public float spawnPercentage = 0.3f;

    public float repeatTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Boxes", repeatTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Boxes()
    {
        for (int i = 0; i < boxPositions.Length; i++)
        {
            float spawnRandom = Random.Range(0f, 1f);

            if (spawnRandom < spawnPercentage)
            {
                GameObject boxObject = Instantiate(box);

                boxObject.transform.position = boxPositions[i].position;

                boxObject.SetActive(true);
            }
        }
    }

    public void Stop()
    {
        CancelInvoke("Boxes");
    }
}
