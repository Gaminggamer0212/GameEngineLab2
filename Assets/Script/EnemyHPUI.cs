using UnityEngine;
using UnityEngine.UI;

public abstract class EnemyHPUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] protected Image healthFillImage;

    [SerializeField] protected float ratio;

    public virtual void UpdateHealthBar(float currHealth, float maxHealth)
    {
        ratio = Mathf.Clamp01(currHealth / maxHealth);
        healthBar.value = ratio;
    }
}
