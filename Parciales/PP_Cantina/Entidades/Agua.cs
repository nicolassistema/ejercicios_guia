

using System.Text;

namespace Entidades
{
    public sealed class Agua : Botella
    {
        private const int MEDIDA = 400;

        #region Builder

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML) { }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medida">Content default of the bottle.</param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {
            if (medida <= this.Contenido)
            {
                this.Contenido -=  medida;
            }
            else if (medida > this.Contenido)
            {
                this.Contenido -= this.Contenido;
            }

            return this.Contenido;
        }

        /// <summary>
        /// Shows the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        protected string GenerarInforme()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.ToString());
            data.Append($"Medida: {MEDIDA}.\n");

            return data.ToString();
        }

        #endregion

    }
}
