using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomGame
{
    // Parent Class qui contient les fonctions qui seront utilisees par les child classes.
    internal abstract class BaseRoom
    {
        // Nom de la salle
        public abstract void Name();

        // Description de la salle
        public abstract void DisplayDescription();


        // possibilitee d'explorer la salle pour des indices
        public abstract void Explore();

        // Solve the problem
        public abstract void Solve();
    }
}
