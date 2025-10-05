using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    private int ScoreSuperCount;

    public TriangleFinder Tri;
    public CircleFinder Circle;
    public BoxFinder Square;

    public TMP_Text TextMesh;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Tri.ScoreCounter = 100;
        }
        
        ScoreSuperCount = Tri.ScoreCounter + Circle.ScoreCounter + Square.ScoreCounter;
        score = ScoreSuperCount * 50;
        TextMesh.text = "Score : " + score;
    }
}
