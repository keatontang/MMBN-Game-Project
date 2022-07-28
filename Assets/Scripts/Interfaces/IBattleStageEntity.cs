using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBattleStageEntity
{

    public string Name { get;}
    public Transform worldPosition{get;set;}
    [SerializeField] public float AttackMultiplier{get;set;}
    [SerializeField] public float DefenseMultiplier{get;set;}
    public int ID { get; }
    public bool stunnable{get;}
    public bool vulnerable{get; set;}
    public Vector3Int getCellPosition();
    public void setCellPosition(int x, int y);

    //light attack means that the attack will not trigger InvincibilityFrames
    //hitStun means the attack will interrupt animations. Some enemies cannot be hitStunned
    //pierceCloaking means the attack will be able to hit targets that are concealed
    public void hurtEntity(int damage, bool lightAttack, bool hitStun, bool pierceCloaking = false);
    public int getHealth();
    public void setHealth(int value);
    public IEnumerator setStatusEffect(EStatusEffects status);




}
