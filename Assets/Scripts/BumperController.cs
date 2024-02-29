using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
  public Collider bola;
  public float multiplier;

  private Renderer renderer;
  private Animator animator;

  public AudioManager audioManager;
  public VFXManager VFXManager;

  public ScoreManager scoreManager;
  private int score = 10;

  private void Start()
  {
    renderer = GetComponent<Renderer>();
    animator = GetComponent<Animator>();

  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.collider == bola)
    {
      Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
      bolaRig.velocity *= multiplier;

      animator.SetTrigger("hit");

      audioManager.PlaySFX(collision.transform.position);

      VFXManager.PlayVFX(collision.transform.position);

      scoreManager.AddScore(score);

    }
  }
}