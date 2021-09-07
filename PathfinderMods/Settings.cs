using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityModManagerNet;

namespace PathfinderMods
{
    class Settings : UnityModManager.ModSettings
    {
        public float MyFloatOption = 2f;
        public bool MyBoolOption = true;
        public string MyTextOption = "Hello";

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}
