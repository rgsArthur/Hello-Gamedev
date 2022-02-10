using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    float playTime = 0;
    float x = 0;
    float y = 0;



    public GameObject newCircle;
    Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.cyan, Color.gray, Color.magenta, Color.yellow };
    int countColors;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(newCircle);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject circleClone = Instantiate<GameObject>(newCircle);
        SpriteRenderer spr = circleClone.GetComponent<SpriteRenderer>();
        spr.color = colors[countColors];
        countColors = (++countColors) % (colors.Length);

        playTime += Time.deltaTime * 100;
        x = Mathf.Cos(playTime);
        y = Mathf.Sin(playTime);
        circleClone.transform.position = new Vector2(x, y);

    }
}
