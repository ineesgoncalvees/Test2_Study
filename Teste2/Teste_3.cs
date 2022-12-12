using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste2
{

    enum Monster { Troll, Ogre, Elf, Demon, Vampire, Werewolf, Minion }


    public class Teste_3
    {
        // 1.1
       List<Monster?> listOfMonsters;

        // 1.2
        Monster monst;

        monst = listOfMonsters[0] == null ? Monster.Minion : listOfMonsters[0];

        // 1.3
        private int HowManyNulls() => listOfMonsters.Count(x => x == null);

        // 3.1
        public static Vector2 Deg2Vec(float angle) =>
            new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));

         public static float Vec2Deg(Vector2 vector) =>
            Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;

        public static Vector2 Direction(Vector2 from, Vector2 to) => 
            (to - from) / (to - from).magnitude;

        public static float Distance(Vector2 obj1, Vector2 obj2) =>
            (obj1 - obj2).magnitude;

        // 3.2
        Func<float> myVar = Deg2Vec;
    }
}