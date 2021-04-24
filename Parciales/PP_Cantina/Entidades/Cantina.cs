using System.Collections.Generic;

namespace Entidades
{
    public sealed class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        #region Properties

        /// <summary>
        /// Get: Gets the list of bottles.
        /// </summary>
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }

        }

        #endregion

        #region Builder

        private Cantina(int espacios)
        {
            botellas = new List<Botella>();
            espaciosTotales = espacios;
        }

        #endregion

        #region Methods

        public static Cantina GetCantina(int espacios)
        {
            if (Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }

            return Cantina.singleton;
        }

        #endregion

        #region Operator

        /// <summary>
        /// Tries to add a bottle in the list if have an empty space inside.
        /// </summary>
        /// <param name="c">Cantina to add bottles.</param>
        /// <param name="b">Bottle to add in the Cantina.</param>
        /// <returns>True if can add, otherwise returns false.</returns>
        public static bool operator +(Cantina c, Botella b)
        {
            if (!(c is null) && !(b is null))
            {
                if (c.botellas.Count < c.espaciosTotales)
                {
                    c.botellas.Add(b);
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
