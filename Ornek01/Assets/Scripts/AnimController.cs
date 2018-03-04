using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    public List<Sprite> sprites = new List<Sprite>();

    public int index = 0;

    public float frameRate = 1f; //Seconds.

    private SpriteRenderer _spriteRenderer;

    private void Awake() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = sprites[0];

        StartCoroutine(Run());
    }

    IEnumerator Run() {
        while (true) {
            yield return new WaitForSeconds(frameRate);
            if (index >= sprites.Count - 1) {
                index = 0;
            } else {
                index++;
            }
            _spriteRenderer.sprite = sprites[index];
        }
    }
}
