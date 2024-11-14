using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        Officer officer;
        Soldier soldier;
        Character[] characterFarm = new Character[2];
        void Start()
        {
            officer = new Officer("officer",60,new Position(40,50,60));
            soldier = new Soldier();

            characterFarm[0] = officer;
            characterFarm[1] = soldier;

            for (int i = 0; i < characterFarm.Length; i++)
            {
                characterFarm[i].DisplayInfo();
            }
            Debug.Log("Soldier's Health before : "+soldier.Health);
            officer.Attack(10,soldier);
             Debug.Log("Soldier's Health after : "+soldier.Health);
        }

    }
}