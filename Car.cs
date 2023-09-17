using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_KnowCheck2 {
    internal class Car : Vehicle {
        public bool isCool;
        public string honkNoise;


        public override string ToString() {
            string[] coolAdjectives = { "nice", "rad", "sweet" };
            string[] uncoolAdjectives = { "lame", "tacky", "heinous" };
            string currentAdjective;

            if (isCool) {
                currentAdjective = coolAdjectives[new Random().Next(coolAdjectives.Length)];
            } else {
                currentAdjective = uncoolAdjectives[new Random().Next(uncoolAdjectives.Length)];
            }

            string output = $"{name}: A {currentAdjective} car that's {color} and goes \"{honkNoise} {honkNoise}\"";
            return output;
        }
    }
}
