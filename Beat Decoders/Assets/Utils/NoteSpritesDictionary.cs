using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpritesDictionary : MonoBehaviour
{
    [SerializeField] Sprite crotchetSprite;
    [SerializeField] Sprite crotchetRestSprite;
    [SerializeField] Sprite longQuaverSprite;
    [SerializeField] Sprite longSemiQuaverSprite;
    [SerializeField] Sprite minimSprite;
    [SerializeField] Sprite minimRestSprite;
    [SerializeField] Sprite quaverSprite;
    [SerializeField] Sprite quaverRestSprite;
    [SerializeField] Sprite semiBreveRestSprite;
    [SerializeField] Sprite semiQuaverSprite;
    [SerializeField] Sprite semiQuaverRestSprite;
    [SerializeField] Dictionary<string, Sprite> noteSprites;

    void Awake()
    {
        noteSprites = new Dictionary<string, Sprite>{
            {"Crotchet", crotchetSprite},
            {"CrotchetRest", crotchetRestSprite},
            {"LongQuaver", longQuaverSprite},
            {"LongSemiQuaver", longSemiQuaverSprite},
            {"InverseLongSemiQuaver", longSemiQuaverSprite},
            {"Minim", minimSprite},
            {"MinimRest", minimRestSprite},
            {"Quaver", quaverSprite},
            {"QuaverRest", quaverRestSprite},
            {"SemiBreveRest", semiBreveRestSprite},
            {"SemiQuaver", semiQuaverSprite},
            {"SemiQuaverRest", semiQuaverRestSprite}
        };
    }

    public Sprite GetSprite(string note)
    {
        return noteSprites[note];
    }
}
